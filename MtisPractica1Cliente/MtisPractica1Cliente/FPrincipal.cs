using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtisPractica1Cliente
{
    public partial class FPrincipal : Form
    {

        bool ValidacionNIF = false;
        bool ValidacionIBAN = false;
        String mensaje = "";
        localhost.ServicioPractica1 Servicio;
        public FPrincipal()
        {
            InitializeComponent();
            Servicio = new localhost.ServicioPractica1();
        }

        private void btnCompNIF_Click(object sender, EventArgs e)
        {
            RtxtImg.Clear();
            mensaje = "";
            txtResultado.Clear();
            
            ValidacionNIF = Servicio.ValidarNIF(txtNIF.Text, txtClave.Text, out mensaje);
            MarcarResultadoDNI();

        }

        private void MarcarResultadoDNI()
        {
             
            if (ValidacionNIF)
            {
                Image imagen = imageList1.Images[0];
                Clipboard.SetDataObject(imagen);
                RtxtImg.Paste();
                mensaje = "Correcto";
            }
            else
            {
                Image imagen = imageList1.Images[1];
                Clipboard.SetDataObject(imagen);
                RtxtImg.Paste();
            }

            txtResultado.Text = mensaje;
        }

        private void MarcarResultadoIBAN()
        {
            if (ValidacionIBAN)
            {
                Image imagen = imageList1.Images[0];
                Clipboard.SetDataObject(imagen);
                RtxtImg.Paste();
                mensaje = "Correcto";
            }else
            {
                Image imagen = imageList1.Images[1];
                Clipboard.SetDataObject(imagen);
                RtxtImg.Paste();
            }

            txtResultado.Text = mensaje;
        }

        private void btnValidarIBAN_Click(object sender, EventArgs e)
        {
            RtxtImg.Clear();
            mensaje = "";
            txtResultado.Clear();
            pnlIBAN.BringToFront();
        }

        private void btnComprobarIBAN_Click(object sender, EventArgs e)
        {
            RtxtImg.Clear();
            mensaje = "";
            txtResultado.Clear();

            ValidacionIBAN = Servicio.ValidarIBAN(txtIBAN.Text, txtClave.Text, out mensaje);
            MarcarResultadoIBAN();
        }

        private void btnValidarNIF_Click(object sender, EventArgs e)
        {
            RtxtImg.Clear();
            mensaje = "";
            txtResultado.Clear();
            pnlValidarNif.BringToFront();
        }
    }
}
