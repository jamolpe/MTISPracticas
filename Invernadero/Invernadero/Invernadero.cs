
using System;
using System.Windows.Forms;

namespace Invernadero
{
    public partial class Invernadero : Form
    {
        private Timer timer1;
        Double temp = 0.0;
        public Invernadero()
        {
            
            InitializeComponent();
            InitTimer();
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
            Random random = new Random();
            temp = Math.Round((random.NextDouble() * (100 - 0) + 0),2);
            lbbTemp.Text = temp.ToString() + "G";
        }
    }

    }

