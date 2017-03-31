using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control
{
    public partial class Control : Form
    {
        String info;
        private ISession session;
        private IMessageProducer replyProducer;
        public Control()
        {
            InitializeComponent();

            IniciarActiveMQServer();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void IniciarActiveMQServer()
        {

            TxboxResult.Text += "Iniciando control..\n";

            String destinationQueue="control";
            String user = env("ACTIVEMQ_USER", "admin");
            String password = env("ACTIVEMQ_PASSWORD", "password");
            String host = env("ACTIVEMQ_HOST", "localhost");
            int port = Int32.Parse(env("ACTIVEMQ_PORT", "61616"));
            
            String brokerUri = "activemq:tcp://" + host + ":" + port + "?transport.useLogging=true";

            var connectionFactory = new NMSConnectionFactory(brokerUri);
            IConnection connection;

            try
            {
                connection = connectionFactory.CreateConnection();
                connection.Start();

                this.session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge);

                var queue = this.session.GetDestination(destinationQueue);

                this.replyProducer = this.session.CreateProducer();
                this.replyProducer.DeliveryMode = MsgDeliveryMode.NonPersistent;

                // Create and setup a consumer to consume (receive) messages from the queue that the client is sending messages to.
                var consumer = this.session.CreateConsumer(queue);
                // Wire-up an event to be fired when a message is received from the queue.
                consumer.Listener += new MessageListener(Calculo_Cliente);
            }
            catch(Exception ex)
            {
                TxboxResult.Text = "error " + ex.ToString();
            }
        }

        public void rellenarinfo(String str)
        {
            TxboxResult.Text += str;
        }
        public void Calculo_Cliente(IMessage message)
        {
            try
            {
                // Create the response message.  We'll send a simple text-based message back.
                var response = this.session.CreateTextMessage();
                

                // Determine the text to send back to the client.
                var textMessage = message as ITextMessage;

                String info = "Temperatura y humedad de invernadero " + message.NMSReplyTo.ToString() + " es -> " + textMessage.Text;
                

                if (textMessage == null)
                    response.Text = "false";
                else
                {
                    string[] datos = textMessage.Text.Split('|');
                    string temperatura = datos[0];
                    string humedad = datos[1];
                    if (Int32.Parse(temperatura)>50)
                    {
                        response.Text = "ActivarVentiladores|";
                    }
                    else
                    {
                        response.Text = "DesactivarVentiladores|";
                    }
                    if (Int32.Parse(humedad) > 50)
                    {
                        response.Text += "ActivarHumificador";
                    }
                    else
                    {
                        response.Text += "DesactivarHumificador";
                    }

                }

                // Set the correlation ID to that of the received message.
                response.NMSCorrelationID = message.NMSCorrelationID;

                // Send the response message to the reply-to destination as received in the message header.  This is the
                // temporary queue that we created in the client application.
                this.replyProducer.Send(message.NMSReplyTo, response);
                rellenarinfo(info);
            }
            catch (NMSException ex)
            {
                TxboxResult.Text = "error "+ ex.ToString();
            }
        }
    }
}
