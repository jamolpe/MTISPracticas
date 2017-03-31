//mas info http://blog.cylewitruk.com/2011/08/synchronous-request-response-messaging-with-nms-and-activemq/
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using Apache.NMS;
using Apache.NMS.ActiveMQ;

namespace Invernadero
{
    public partial class Invernadero : Form
    {
        private string puerto;
        private Timer timer1;
        Double temp = 0.0;
        Double humedad = 0;
        bool acventiladores = false;
        bool achumificadores = false;
        public Invernadero()
        {

            InitializeComponent();
            lbbTemp.Text = "0.0 °C";
            lblHumedad.Text = "0 %";
            InitTimer();         
            lblPrincipal.Text = "Invernadero";
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

    }
}

    

