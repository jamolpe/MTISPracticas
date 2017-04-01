using Apache.NMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInvernaderos
{
    public class Program
    {

        private ISession session;
        private IMessageProducer replyProducer;
        private Dictionary<string, int> referenciasTemp = new Dictionary<string, int>();
        private Dictionary<string, int> referenciasHume = new Dictionary<string, int>();
        

        Program()
        {

        }


        public static void Main(string[] args)
        {

            Program prog = new Program();
            prog.IniciarActiveMQServer();
            while (true)
            {

            }
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

       

        public void IniciarActiveMQServer()
        {

            Console.WriteLine("Iniciando control..");

            String destinationQueueTemp = "Temperatura";
            String destinationQueueHumedad = "Humedad";
            String destinationQueueConfiguracion = "Configuracion";

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

                var queuetemp = session.GetDestination(destinationQueueTemp);
                var queuehum = session.GetDestination(destinationQueueHumedad);
                var queueconf = session.GetDestination(destinationQueueConfiguracion);

                this.replyProducer = this.session.CreateProducer();
                this.replyProducer.DeliveryMode = MsgDeliveryMode.NonPersistent;

                // Create and setup a consumer to consume (receive) messages from the queue that the client is sending messages to.
                var consumertemp = this.session.CreateConsumer(queuetemp);
                var consumerhum = this.session.CreateConsumer(queuehum);
                var consumerconf = this.session.CreateConsumer(queueconf);

                
                // Wire-up an event to be fired when a message is received from the queue.
                consumertemp.Listener += new MessageListener(Calculo_Temp);
                consumerhum.Listener += new MessageListener(Calculo_Hum);
                consumerconf.Listener += new MessageListener(Calculo_Config);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.ToString());
            }
        }

        public void Calculo_Hum(IMessage message)
        {
            try
            {
                // Create the response message.  We'll send a simple text-based message back.
                var response = this.session.CreateTextMessage();

                // Determine the text to send back to the client.
                var textMessage = message as ITextMessage;
                string[] mns = textMessage.Text.Split('|');
                String info = "Humedad invernadero " + mns[0] + " es -> " + mns[1];


                if (textMessage == null)
                    response.Text = "false";
                else
                {
                    int hum = int.Parse(mns[1]);
                    if (hum > referenciasHume[mns[0]])
                    {
                        response.Text = "true";
                        info += "\n";
                        info += "Activando deshumificador";
                    }
                    else
                    {
                        response.Text = "false";
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
                Console.WriteLine("error " + ex.ToString());
            }
        }
        public void Calculo_Config(IMessage message)
        {
            try
            {
                String info = "";
                // Create the response message.  We'll send a simple text-based message back.
                var response = this.session.CreateTextMessage();


                // Determine the text to send back to the client.
                var textMessage = message as ITextMessage;
    
                if (textMessage == null)
                    response.Text = "false";
                else
                {
                    string[] datos = textMessage.Text.Split('|');
                    info = "Configuracion realizada para el invernadero " + datos[0]+"\n";
                    referenciasTemp.Add(datos[0],Int32.Parse(datos[1]));
                    referenciasHume.Add(datos[0], Int32.Parse(datos[2]));
                    info += "Humedad maxima = " + datos[2]+"\n";
                    info += "Temperatura maxima = " + datos[1] + "\n";
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
                Console.WriteLine("error " + ex.ToString());
            }
        }

        public void Calculo_Temp(IMessage message)
        {
            try
            {
                // Create the response message.  We'll send a simple text-based message back.
                var response = this.session.CreateTextMessage();

                // Determine the text to send back to the client.
                var textMessage = message as ITextMessage;
                string[] mns = textMessage.Text.Split('|');
                String info = "Temperatura invernadero " + mns[0] + " es -> " + mns[1];


                if (textMessage == null)
                    response.Text = "false";
                else
                {
                    Double temp = Double.Parse(mns[1]);
                    if (temp>referenciasTemp[mns[0]])
                    {
                        response.Text = "true";
                        info += "\n";
                        info += "Activando ventilador";
                    }
                    else
                    {
                        response.Text = "false";
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
                Console.WriteLine("error " + ex.ToString());
            }
        }

        public void rellenarinfo(String str)
        {
            Console.WriteLine(str);
        }
    }
}
