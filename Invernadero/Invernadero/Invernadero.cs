//mas info http://blog.cylewitruk.com/2011/08/synchronous-request-response-messaging-with-nms-and-activemq/
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Apache.NMS.ActiveMQ;
using Apache.NMS;

namespace Invernadero
{
    public partial class Invernadero : Form
    {
        private Dictionary<string, AsyncMessageHelper> responseBuffer;
        private string puerto;
        private Timer timer1;
        Double temp = 0.0;
        Double humedad = 0;
        bool acventiladores = false;
        bool achumificadores = false;

        private ISession session;
        private IConnection connection;
        private ITemporaryQueue temporaryQueue;
        private IMessageProducer producer;
        public Invernadero()
        {

            InitializeComponent();
            lbbTemp.Text = "0.0 °C";
            lblHumedad.Text = "0 %";
            InitTimer();         
            lblPrincipal.Text = "Invernadero";
            ActiveMQInvernadero();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!acventiladores)
            {
                subirTemp();
            }
            else
            {
                bajarTemp();
            }
            if (!achumificadores)
            {
                subirHumedad();
            }
            else
            {
                bajarHumedad();
            }
            
            lbbTemp.Text = temp.ToString() + " °C";
            lblHumedad.Text = humedad.ToString() + " %";
            var mensaje = this.CreateTextMessage(lbbTemp.Text+"|"+lblHumedad.Text);
            var respuesta = this.SendMessage(mensaje);
        }

        private void subirTemp()
        {
            Random random = new Random();
            temp = temp + Math.Round((random.NextDouble() * (7 - 0) + 0), 2);
        }

        private void subirHumedad()
        {
            Random random2 = new Random();
            humedad = humedad + Math.Round(random2.NextDouble() * (9 - 0) + 0);
        }

        private void bajarTemp()
        {
            Random random = new Random();
            if (temp>30)
            {
                temp = temp - Math.Round((random.NextDouble() * (8 - 0) + 0), 2);
            }
      
        }

        private void bajarHumedad()
        {
            Random random2 = new Random();

            if (humedad>35)
            {
                humedad = humedad - Math.Round(random2.NextDouble() * (9 - 0) + 0);
            }
            
        }

        public void ActiveMQInvernadero()
        {

            String user = env("ACTIVEMQ_USER", "admin");
            String password = env("ACTIVEMQ_PASSWORD", "password");
            String host = env("ACTIVEMQ_HOST", "localhost");
            int port = Int32.Parse(env("ACTIVEMQ_PORT", "61616"));

            String destinationQueue = "control";
            this.responseBuffer = new Dictionary<string, AsyncMessageHelper>();

            String brokerUri = "activemq:tcp://" + host + ":" + port;
            var connectionFactory = new ConnectionFactory(brokerUri);

            try
            {
                connection = connectionFactory.CreateConnection();
                connection.Start();

                this.session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
                var destination = session.GetDestination(destinationQueue);

                this.producer = session.CreateProducer(destination);
                this.producer.DeliveryMode = MsgDeliveryMode.NonPersistent;

                this.temporaryQueue = session.CreateTemporaryQueue();

                var responseConsumer = session.CreateConsumer(temporaryQueue);
                responseConsumer.Listener += new MessageListener(responseConsumer_Listener);
            }
            catch(Exception ex)
            {

            }
            
        }

        public void Stop()
        {
            try
            {
                this.connection.Dispose();
            }
            catch (Exception)
            {
            }
        }

        public IMessage SendMessage(IMessage message, int timeout = 10000)
        {
            // Create a unique correlation ID which we will use to map response messages to request messages.
            var correlationID = Guid.NewGuid().ToString();
            message.NMSCorrelationID = correlationID;

            // Set the reply-to header to the temporary queue that we created so that the server knows where to return messages.
            message.NMSReplyTo = this.temporaryQueue;

            // Create a new AsyncMessageHelper.  This class is a helper class to make it easier for us to map response messages to request messages.
            using (var asyncMessageHelper = new AsyncMessageHelper())
            {
                // Add the async helper to the response buffer.
                lock (this.responseBuffer)
                    this.responseBuffer[correlationID] = asyncMessageHelper;

                // Send the message to the queue.
                this.producer.Send(message);

                // Wait for a response for up to [timeout] seconds.  This blocks until the timeout expires or a message is received (.Set() is called on the trigger then, allowing execution to continue).
                asyncMessageHelper.Trigger.WaitOne(timeout, true);

                // Either the timeout has expired, or a message was received with the same correlation ID as the request message.
                IMessage responseMessage;
                try
                {
                    // The Message property on the async helper will not have been set if no message was received within the timeout period.
                    if (asyncMessageHelper.Message == null)
                        throw new TimeoutException("Timed out while waiting for a response.");

                    // We got the response message, cool!
                    responseMessage = asyncMessageHelper.Message;
                }
                finally
                {
                    // Remove the async helper from the response buffer.
                    lock (this.responseBuffer)
                        this.responseBuffer.Remove(correlationID);
                }

                // Return the response message.
                return responseMessage;
            }
        }

        /// <summary>
        /// Creates a text message for use with the client.
        /// </summary>
        public ITextMessage CreateTextMessage(string text = null)
        {
            return text == null
                ? this.session.CreateTextMessage()
                : this.session.CreateTextMessage(text);
        }


        /// <summary>
        /// This event will fire when a response message is received from the temporary queue.  It will attempt to map received messages back
        /// to the response buffer.
        /// </summary>
        void responseConsumer_Listener(IMessage message)
        {
            // Look for an async helper with the same correlation ID.
            AsyncMessageHelper asyncMessageHelper;
            lock (this.responseBuffer)
            {
                // If no async helper with the same correlation ID exists, then we've received some erranious message that we don't care about.
                if (!this.responseBuffer.TryGetValue(message.NMSCorrelationID, out asyncMessageHelper))
                    return;
            }

            // Set the Message property so we can access it in the send method.
            asyncMessageHelper.Message = message;

            // Fire the trigger so that the send method stops blocking and continues on its way.
            asyncMessageHelper.Trigger.Set();
        }


        private static String env(String key, String defaultValue)
        {
            String rc = System.Environment.GetEnvironmentVariable(key);
            if (rc == null)
            {
                return defaultValue;
            }
            return rc;
        }

        private static String arg(String[] args, int index, String defaultValue)
        {
            if (index < args.Length)
            {
                return args[index];
            }
            return defaultValue;
        }

    }
}

    

