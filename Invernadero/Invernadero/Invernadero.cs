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
        string tempmax;
        string humedadmax;
        bool acventiladores = false;
        bool achumificadores = false;
        private string nombreInvernadero;

        private ISession session;
        private IConnection connection;
        private ITemporaryQueue temporaryQueueTemp;
        private ITemporaryQueue temporaryQueueConf;
        private ITemporaryQueue temporaryQueueHum;
        private IMessageProducer producerConf;
        private IMessageProducer producerTemp;
        private IMessageProducer producerHum;

        public Invernadero()
        {

            InitializeComponent();
            pnl2.BringToFront();


        }



        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000;
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


            ComprobarRespuestaHumificador();
            //var res = respuesta as ITextMessage;
            //string[] respuestas = res.Text.Split('|');
            //string acciontemp = respuestas[0];
            //string aaccionhumifi = respuestas[1];

            //if (acciontemp == "ActivarVentiladores")
            //{
            //    acventiladores = true;
            //}
            //else
            //{
            //    acventiladores = false;
            //}
            //if (aaccionhumifi == "ActivarHumificador")
            //{
            //    achumificadores = true;
            //}
            //else
            //{
            //    achumificadores = false;
            //}
        }

        public void ComprobarRespuestaHumificador()
        {
            var mensaje = this.CreateTextMessage(humedad.ToString());
            var respuesta = EnviarMensajeHum(mensaje);
            var res = respuesta as ITextMessage;

            if (res.Text == "true")
            {
                achumificadores = true;
            }
            else
            {
                achumificadores = false;
            }
            
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

            String destinationQueueTemp = "Temperatura";
            String destinationQueueHum = "Humedad";
            String destinationQueueConf = "Configuracion";

            this.responseBuffer = new Dictionary<string, AsyncMessageHelper>();

            String brokerUri = "activemq:tcp://" + host + ":" + port;
            var connectionFactory = new ConnectionFactory(brokerUri);

            try
            {
                connection = connectionFactory.CreateConnection();
                connection.Start();

                this.session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);
                var destinationTemp = session.GetDestination(destinationQueueTemp);
                var destinationHum = session.GetDestination(destinationQueueHum);
                var destinationConf = session.GetDestination(destinationQueueConf);

                this.producerTemp = session.CreateProducer(destinationTemp);
                this.producerTemp.DeliveryMode = MsgDeliveryMode.NonPersistent;
                this.producerHum = session.CreateProducer(destinationHum);
                this.producerHum.DeliveryMode = MsgDeliveryMode.NonPersistent;
                this.producerConf = session.CreateProducer(destinationConf);
                this.producerConf.DeliveryMode = MsgDeliveryMode.NonPersistent;

                this.temporaryQueueHum = session.CreateTemporaryQueue();
                this.temporaryQueueTemp = session.CreateTemporaryQueue();
                this.temporaryQueueConf = session.CreateTemporaryQueue();

                var responseConsumerTemp = session.CreateConsumer(temporaryQueueTemp);
                var responseConsumerHum = session.CreateConsumer(temporaryQueueHum);
                var responseConsumerConf = session.CreateConsumer(temporaryQueueConf);

                responseConsumerTemp.Listener += new MessageListener(responseConsumer_ListenerTemp);
                responseConsumerHum.Listener += new MessageListener(responseConsumer_ListenerHum);
                responseConsumerConf.Listener += new MessageListener(responseConsumer_ListenerConf);
            }
            catch(Exception ex)
            {

            }
            
        }

        public IMessage EnviarMensajeConf(IMessage message, int timeout = 10000)
        {
            //id mensaje
            var correlationID = Guid.NewGuid().ToString();
            message.NMSCorrelationID = correlationID;

            // a quien responder los mensajes
            message.NMSReplyTo = this.temporaryQueueConf;

            // AsyncMessageHelper Ayuda al mapeo de los mensajes clase que he encotnrado por internet.
            using (var asyncMessageHelper = new AsyncMessageHelper())
            {
                // añade el async helper al bufer de respuestas.
                lock (this.responseBuffer)
                    this.responseBuffer[correlationID] = asyncMessageHelper;

                // Enviar el mensaje al queue
                this.producerConf.Send(message);

                // Esperamos a que nos llegue respuesta o acabe el tiempo de espera no problem al ser asincrono,10 segundos de espera al menos.
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
        public IMessage EnviarMensajeHum(IMessage message, int timeout = 10000)
        {
            //id mensaje
            var correlationID = Guid.NewGuid().ToString();
            message.NMSCorrelationID = correlationID;

            // a quien responder los mensajes
            message.NMSReplyTo = this.temporaryQueueHum;

            // AsyncMessageHelper Ayuda al mapeo de los mensajes clase que he encotnrado por internet.
            using (var asyncMessageHelper = new AsyncMessageHelper())
            {
                // añade el async helper al bufer de respuestas.
                lock (this.responseBuffer)
                    this.responseBuffer[correlationID] = asyncMessageHelper;

                // Enviar el mensaje al queue
                this.producerHum.Send(message);

                // Esperamos a que nos llegue respuesta o acabe el tiempo de espera no problem al ser asincrono,10 segundos de espera al menos.
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
        public IMessage EnviarMensajeTemp(IMessage message, int timeout = 10000)
        {
           //id mensaje
            var correlationID = Guid.NewGuid().ToString();
            message.NMSCorrelationID = correlationID;

            // a quien responder los mensajes
            message.NMSReplyTo = this.temporaryQueueTemp;

            // AsyncMessageHelper Ayuda al mapeo de los mensajes clase que he encotnrado por internet.
            using (var asyncMessageHelper = new AsyncMessageHelper())
            {
                // añade el async helper al bufer de respuestas.
                lock (this.responseBuffer)
                    this.responseBuffer[correlationID] = asyncMessageHelper;

                // Enviar el mensaje al queue
                this.producerTemp.Send(message);

                // Esperamos a que nos llegue respuesta o acabe el tiempo de espera no problem al ser asincrono,10 segundos de espera al menos.
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
        void responseConsumer_ListenerConf(IMessage message)
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
        /// <summary>
        /// This event will fire when a response message is received from the temporary queue.  It will attempt to map received messages back
        /// to the response buffer.
        /// </summary>
        void responseConsumer_ListenerHum(IMessage message)
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
        /// <summary>
        /// This event will fire when a response message is received from the temporary queue.  It will attempt to map received messages back
        /// to the response buffer.
        /// </summary>
        void responseConsumer_ListenerTemp(IMessage message)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxHumedadmax.Text !="" && txtboxTemp.Text!="" && txtNombreInver.Text !="")
            {
                nombreInvernadero = txtNombreInver.Text;
                tempmax = txtboxTemp.Text;
                humedadmax = txtboxHumedadmax.Text;
                lbbTemp.Text = "0.0 °C";
                lblHumedad.Text = "0 %";
                pnl1.BringToFront();

                ActiveMQInvernadero();
                var mensaje = this.CreateTextMessage(txtNombreInver.Text+"|"+tempmax + "|" + humedadmax);
                this.EnviarMensajeConf(mensaje);

                InitTimer();
                lblPrincipal.Text = "Invernadero";
       
            }


        }


    }
}

    

