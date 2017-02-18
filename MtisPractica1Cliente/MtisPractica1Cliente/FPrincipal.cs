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
            panelResultadoValidacion.BringToFront();
            
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
            panelResultadoValidacion.BringToFront();
        }

        private void btnConsultCodPostal_Click(object sender, EventArgs e)
        {
            RtxtImg.Clear();
            mensaje = "";
            txtResultado.Clear();
            txtMensaje.Clear();
            txtProvincia.Clear();
            txtPoblacion.Clear();
            txtCodPosResult.Clear();
            pnlResultadosCodPost.BringToFront();
            pnlCodPestal.BringToFront();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtMensaje.Clear();
            txtProvincia.Clear();
            txtPoblacion.Clear();
            String AuxPoblacion = "";
            String AuxProvincia = "";
            mensaje = ""; 
            Servicio.ConsultaCodigoPostal(txtCodPostal.Text,txtClave.Text,out AuxPoblacion,out AuxProvincia,out mensaje);
            MostrarResultadosCodPostal(AuxPoblacion, AuxProvincia);
        }

        private void MostrarResultadosCodPostal(String Poblacion,String Provincia)
        {
            if (Poblacion != "")
            {
                txtPoblacion.Text = Poblacion;
                if (Provincia != "")
                {
                    txtProvincia.Text = Provincia;
                }
            }
            if(mensaje != "")
            {
                txtMensaje.Text = mensaje;
            }else
            {
                txtMensaje.Text = "Correcto";
            }

            txtCodPosResult.Text = txtCodPostal.Text;
        }

        private void btnObtenerPresupuesto_Click(object sender, EventArgs e)
        {
            pnlGenerarCodPost.BringToFront();
            txtIdCliente.Clear();
            txtRefProduc.Clear();
            txtCantidadProd.Clear();
            txtIdPresupuesto.Clear();
            txtMensajeGenerar.Clear();
            pnlResultadoGenerar.BringToFront();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime date = dteFechaPresu.Value.Date;
            Boolean PresGenerado = false;
            mensaje = "";
            if (txtIdCliente.Text != "" && txtCantidadProd.Text != "")
            {
                int siguienteID = Servicio.GenerarPresupuesto(date, Int32.Parse(txtIdCliente.Text), txtRefProduc.Text, Int32.Parse(txtCantidadProd.Text), txtClave.Text,
                 out PresGenerado, out mensaje);


                if (PresGenerado)
                {
                    txtIdPresupuesto.Text = siguienteID.ToString();
                    mensaje = "Correcto";
                }
            }else
            {
                mensaje = "Introduce valores validos";
            }

            txtMensajeGenerar.Text = mensaje;
        }

        private void btnSolicitarPres_Click(object sender, EventArgs e)
        {
            pnlSolicitar.BringToFront();
            pnlRSol.BringToFront();
            txtPrecioPieza.Clear();
            txtDisponibilidad.Clear();
            txtFechaDis.Clear();
            txtMensSol.Clear();
            txtReferenciaSol.Clear();
            txtIProveedorSol.Clear();
            mensaje = "";

        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            float precio = 0;
            Boolean disponible = false;
            DateTime fechaDisp = new DateTime();
            txtFechaDis.Clear();
            fechaDisp = DateTime.Now;

            if (txtIProveedorSol.Text != "")
            {
                precio = Servicio.SolicitarPresupuesto(txtReferenciaSol.Text, Int32.Parse(txtIProveedorSol.Text), txtClave.Text, out disponible, out fechaDisp, out mensaje);
            }
            else
            {
                mensaje = "Valores mal introducidos";
            }

            txtPrecioPieza.Text = precio.ToString();
            if (disponible)
            {
                txtDisponibilidad.Text = "Disponible";
                txtFechaDis.Text = fechaDisp.ToString();
                mensaje = "Correcto";

            }
            else
            {
                txtDisponibilidad.Text = "No disponible";
                txtFechaDis.Text = fechaDisp.ToString();


            }

            txtMensSol.Text = mensaje;
        }
    }
}
