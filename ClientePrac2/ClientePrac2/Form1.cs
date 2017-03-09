using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientePrac2
{
    public partial class Form1 : Form
    {


        localhost.CompraProcessBinding compraProceso;
        public String referencia;
        public int cantidad;
        public Form1()
        {
            InitializeComponent();
            compraProceso = new localhost.CompraProcessBinding();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            referencia = txtReferencia.Text;
        

            localhost.CompraProcessRequest datos = new localhost.CompraProcessRequest();
            localhost.CompraProcessResponse respuesta = new localhost.CompraProcessResponse();

            datos.referencia = referencia;
            datos.unidades = Int32.Parse(txtUnidades.Text);

            respuesta = compraProceso.process(datos);

            if (respuesta.result)
            {
                MessageBox.Show("Compra realizada con exito");
            }
            else
            {
                MessageBox.Show("No ha sido posible realizar la compra");
            }

        }
    }
}
