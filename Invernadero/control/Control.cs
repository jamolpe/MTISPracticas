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
        public Control()
        {
            InitializeComponent();

            for (int i=0;i<=50;i++)
            {
                TxboxResult.Text += "a ver como se ve el texto\n";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
