namespace MtisPractica1Cliente
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnCompNIF = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RtxtImg = new System.Windows.Forms.RichTextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlValidarNif = new System.Windows.Forms.Panel();
            this.btnValidarNIF = new System.Windows.Forms.Button();
            this.panelResultadoValidacion = new System.Windows.Forms.Panel();
            this.btnValidarIBAN = new System.Windows.Forms.Button();
            this.btnSolicitarPres = new System.Windows.Forms.Button();
            this.btnObtenerPresupuesto = new System.Windows.Forms.Button();
            this.btnConsultCodPostal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlIBAN = new System.Windows.Forms.Panel();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComprobarIBAN = new System.Windows.Forms.Button();
            this.pnlCodPestal = new System.Windows.Forms.Panel();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.pnlResultadosCodPost = new System.Windows.Forms.Panel();
            this.txtCodPosResult = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlGenerarCodPost = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.txtRefProduc = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dteFechaPresu = new System.Windows.Forms.DateTimePicker();
            this.pnlResultadoGenerar = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMensajeGenerar = new System.Windows.Forms.TextBox();
            this.txtIdPresupuesto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlSolicitar = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIProveedorSol = new System.Windows.Forms.TextBox();
            this.txtReferenciaSol = new System.Windows.Forms.TextBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.pnlRSol = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFechaDis = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.txtPrecioPieza = new System.Windows.Forms.TextBox();
            this.txtMensSol = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pnlValidarNif.SuspendLayout();
            this.panelResultadoValidacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIBAN.SuspendLayout();
            this.pnlCodPestal.SuspendLayout();
            this.pnlResultadosCodPost.SuspendLayout();
            this.pnlGenerarCodPost.SuspendLayout();
            this.pnlResultadoGenerar.SuspendLayout();
            this.pnlSolicitar.SuspendLayout();
            this.pnlRSol.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(210, 38);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(128, 20);
            this.txtNIF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(252, 56);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(54, 20);
            this.txtClave.TabIndex = 3;
            // 
            // btnCompNIF
            // 
            this.btnCompNIF.BackColor = System.Drawing.SystemColors.Control;
            this.btnCompNIF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompNIF.Image = ((System.Drawing.Image)(resources.GetObject("btnCompNIF.Image")));
            this.btnCompNIF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompNIF.Location = new System.Drawing.Point(212, 76);
            this.btnCompNIF.Name = "btnCompNIF";
            this.btnCompNIF.Size = new System.Drawing.Size(126, 28);
            this.btnCompNIF.TabIndex = 4;
            this.btnCompNIF.Text = "Comprobar";
            this.btnCompNIF.UseVisualStyleBackColor = false;
            this.btnCompNIF.Click += new System.EventHandler(this.btnCompNIF_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BIEN.png");
            this.imageList1.Images.SetKeyName(1, "MAL.png");
            // 
            // RtxtImg
            // 
            this.RtxtImg.Location = new System.Drawing.Point(197, 37);
            this.RtxtImg.Name = "RtxtImg";
            this.RtxtImg.Size = new System.Drawing.Size(24, 23);
            this.RtxtImg.TabIndex = 5;
            this.RtxtImg.Text = "";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(227, 40);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(194, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // pnlValidarNif
            // 
            this.pnlValidarNif.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlValidarNif.Controls.Add(this.txtNIF);
            this.pnlValidarNif.Controls.Add(this.label1);
            this.pnlValidarNif.Controls.Add(this.btnCompNIF);
            this.pnlValidarNif.Location = new System.Drawing.Point(12, 129);
            this.pnlValidarNif.Name = "pnlValidarNif";
            this.pnlValidarNif.Size = new System.Drawing.Size(574, 111);
            this.pnlValidarNif.TabIndex = 8;
            // 
            // btnValidarNIF
            // 
            this.btnValidarNIF.Location = new System.Drawing.Point(9, 12);
            this.btnValidarNIF.Name = "btnValidarNIF";
            this.btnValidarNIF.Size = new System.Drawing.Size(75, 23);
            this.btnValidarNIF.TabIndex = 9;
            this.btnValidarNIF.Text = "Validar NIF";
            this.btnValidarNIF.UseVisualStyleBackColor = true;
            this.btnValidarNIF.Click += new System.EventHandler(this.btnValidarNIF_Click);
            // 
            // panelResultadoValidacion
            // 
            this.panelResultadoValidacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelResultadoValidacion.Controls.Add(this.txtResultado);
            this.panelResultadoValidacion.Controls.Add(this.RtxtImg);
            this.panelResultadoValidacion.Controls.Add(this.label3);
            this.panelResultadoValidacion.Location = new System.Drawing.Point(9, 246);
            this.panelResultadoValidacion.Name = "panelResultadoValidacion";
            this.panelResultadoValidacion.Size = new System.Drawing.Size(577, 100);
            this.panelResultadoValidacion.TabIndex = 10;
            // 
            // btnValidarIBAN
            // 
            this.btnValidarIBAN.Location = new System.Drawing.Point(85, 12);
            this.btnValidarIBAN.Name = "btnValidarIBAN";
            this.btnValidarIBAN.Size = new System.Drawing.Size(75, 23);
            this.btnValidarIBAN.TabIndex = 11;
            this.btnValidarIBAN.Text = "Validar IBAN";
            this.btnValidarIBAN.UseVisualStyleBackColor = true;
            this.btnValidarIBAN.Click += new System.EventHandler(this.btnValidarIBAN_Click);
            // 
            // btnSolicitarPres
            // 
            this.btnSolicitarPres.Location = new System.Drawing.Point(160, 12);
            this.btnSolicitarPres.Name = "btnSolicitarPres";
            this.btnSolicitarPres.Size = new System.Drawing.Size(143, 23);
            this.btnSolicitarPres.TabIndex = 12;
            this.btnSolicitarPres.Text = "Solicitar Presupuesto";
            this.btnSolicitarPres.UseVisualStyleBackColor = true;
            this.btnSolicitarPres.Click += new System.EventHandler(this.btnSolicitarPres_Click);
            // 
            // btnObtenerPresupuesto
            // 
            this.btnObtenerPresupuesto.Location = new System.Drawing.Point(303, 12);
            this.btnObtenerPresupuesto.Name = "btnObtenerPresupuesto";
            this.btnObtenerPresupuesto.Size = new System.Drawing.Size(140, 23);
            this.btnObtenerPresupuesto.TabIndex = 13;
            this.btnObtenerPresupuesto.Text = "Generar Presupuesto";
            this.btnObtenerPresupuesto.UseVisualStyleBackColor = true;
            this.btnObtenerPresupuesto.Click += new System.EventHandler(this.btnObtenerPresupuesto_Click);
            // 
            // btnConsultCodPostal
            // 
            this.btnConsultCodPostal.Location = new System.Drawing.Point(446, 12);
            this.btnConsultCodPostal.Name = "btnConsultCodPostal";
            this.btnConsultCodPostal.Size = new System.Drawing.Size(140, 23);
            this.btnConsultCodPostal.TabIndex = 14;
            this.btnConsultCodPostal.Text = "Consultar CodPostal";
            this.btnConsultCodPostal.UseVisualStyleBackColor = true;
            this.btnConsultCodPostal.Click += new System.EventHandler(this.btnConsultCodPostal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 90);
            this.panel1.TabIndex = 15;
            // 
            // pnlIBAN
            // 
            this.pnlIBAN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlIBAN.Controls.Add(this.txtIBAN);
            this.pnlIBAN.Controls.Add(this.label4);
            this.pnlIBAN.Controls.Add(this.btnComprobarIBAN);
            this.pnlIBAN.Location = new System.Drawing.Point(9, 129);
            this.pnlIBAN.Name = "pnlIBAN";
            this.pnlIBAN.Size = new System.Drawing.Size(577, 111);
            this.pnlIBAN.TabIndex = 9;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(167, 38);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(232, 20);
            this.txtIBAN.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "IBAN:";
            // 
            // btnComprobarIBAN
            // 
            this.btnComprobarIBAN.BackColor = System.Drawing.SystemColors.Control;
            this.btnComprobarIBAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComprobarIBAN.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobarIBAN.Image")));
            this.btnComprobarIBAN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobarIBAN.Location = new System.Drawing.Point(212, 76);
            this.btnComprobarIBAN.Name = "btnComprobarIBAN";
            this.btnComprobarIBAN.Size = new System.Drawing.Size(126, 28);
            this.btnComprobarIBAN.TabIndex = 4;
            this.btnComprobarIBAN.Text = "Comprobar";
            this.btnComprobarIBAN.UseVisualStyleBackColor = false;
            this.btnComprobarIBAN.Click += new System.EventHandler(this.btnComprobarIBAN_Click);
            // 
            // pnlCodPestal
            // 
            this.pnlCodPestal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlCodPestal.Controls.Add(this.txtCodPostal);
            this.pnlCodPestal.Controls.Add(this.label5);
            this.pnlCodPestal.Controls.Add(this.btnComprobar);
            this.pnlCodPestal.Location = new System.Drawing.Point(9, 129);
            this.pnlCodPestal.Name = "pnlCodPestal";
            this.pnlCodPestal.Size = new System.Drawing.Size(577, 111);
            this.pnlCodPestal.TabIndex = 16;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(230, 38);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Codigo Postal:";
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.SystemColors.Control;
            this.btnComprobar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComprobar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobar.Image")));
            this.btnComprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobar.Location = new System.Drawing.Point(212, 76);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(126, 28);
            this.btnComprobar.TabIndex = 4;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // pnlResultadosCodPost
            // 
            this.pnlResultadosCodPost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlResultadosCodPost.Controls.Add(this.txtCodPosResult);
            this.pnlResultadosCodPost.Controls.Add(this.txtPoblacion);
            this.pnlResultadosCodPost.Controls.Add(this.label10);
            this.pnlResultadosCodPost.Controls.Add(this.label9);
            this.pnlResultadosCodPost.Controls.Add(this.label8);
            this.pnlResultadosCodPost.Controls.Add(this.label7);
            this.pnlResultadosCodPost.Controls.Add(this.txtProvincia);
            this.pnlResultadosCodPost.Controls.Add(this.txtMensaje);
            this.pnlResultadosCodPost.Controls.Add(this.label6);
            this.pnlResultadosCodPost.Location = new System.Drawing.Point(9, 246);
            this.pnlResultadosCodPost.Name = "pnlResultadosCodPost";
            this.pnlResultadosCodPost.Size = new System.Drawing.Size(577, 100);
            this.pnlResultadosCodPost.TabIndex = 17;
            // 
            // txtCodPosResult
            // 
            this.txtCodPosResult.Location = new System.Drawing.Point(440, 26);
            this.txtCodPosResult.Name = "txtCodPosResult";
            this.txtCodPosResult.Size = new System.Drawing.Size(120, 20);
            this.txtCodPosResult.TabIndex = 14;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(238, 26);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(115, 20);
            this.txtPoblacion.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Codigo Postal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Poblacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Provincia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mensaje:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(68, 26);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 8;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(183, 66);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(194, 20);
            this.txtMensaje.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Resultado";
            // 
            // pnlGenerarCodPost
            // 
            this.pnlGenerarCodPost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlGenerarCodPost.Controls.Add(this.btnGenerar);
            this.pnlGenerarCodPost.Controls.Add(this.label14);
            this.pnlGenerarCodPost.Controls.Add(this.label13);
            this.pnlGenerarCodPost.Controls.Add(this.label12);
            this.pnlGenerarCodPost.Controls.Add(this.label11);
            this.pnlGenerarCodPost.Controls.Add(this.txtCantidadProd);
            this.pnlGenerarCodPost.Controls.Add(this.txtRefProduc);
            this.pnlGenerarCodPost.Controls.Add(this.txtIdCliente);
            this.pnlGenerarCodPost.Controls.Add(this.dteFechaPresu);
            this.pnlGenerarCodPost.Location = new System.Drawing.Point(9, 129);
            this.pnlGenerarCodPost.Name = "pnlGenerarCodPost";
            this.pnlGenerarCodPost.Size = new System.Drawing.Size(577, 111);
            this.pnlGenerarCodPost.TabIndex = 18;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerar.Location = new System.Drawing.Point(252, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGenerar.Size = new System.Drawing.Size(101, 23);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(356, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Referencia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "idCliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Fecha Presupuesto";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Location = new System.Drawing.Point(421, 57);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadProd.TabIndex = 3;
            // 
            // txtRefProduc
            // 
            this.txtRefProduc.Location = new System.Drawing.Point(421, 16);
            this.txtRefProduc.Name = "txtRefProduc";
            this.txtRefProduc.Size = new System.Drawing.Size(100, 20);
            this.txtRefProduc.TabIndex = 2;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(151, 57);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 1;
            // 
            // dteFechaPresu
            // 
            this.dteFechaPresu.Location = new System.Drawing.Point(119, 17);
            this.dteFechaPresu.Name = "dteFechaPresu";
            this.dteFechaPresu.Size = new System.Drawing.Size(200, 20);
            this.dteFechaPresu.TabIndex = 0;
            // 
            // pnlResultadoGenerar
            // 
            this.pnlResultadoGenerar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlResultadoGenerar.Controls.Add(this.label16);
            this.pnlResultadoGenerar.Controls.Add(this.label15);
            this.pnlResultadoGenerar.Controls.Add(this.txtMensajeGenerar);
            this.pnlResultadoGenerar.Controls.Add(this.txtIdPresupuesto);
            this.pnlResultadoGenerar.Controls.Add(this.label19);
            this.pnlResultadoGenerar.Location = new System.Drawing.Point(9, 246);
            this.pnlResultadoGenerar.Name = "pnlResultadoGenerar";
            this.pnlResultadoGenerar.Size = new System.Drawing.Size(577, 100);
            this.pnlResultadoGenerar.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Mensaje";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(97, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Id Siguiente presupuesto";
            // 
            // txtMensajeGenerar
            // 
            this.txtMensajeGenerar.Location = new System.Drawing.Point(237, 66);
            this.txtMensajeGenerar.Name = "txtMensajeGenerar";
            this.txtMensajeGenerar.Size = new System.Drawing.Size(197, 20);
            this.txtMensajeGenerar.TabIndex = 9;
            // 
            // txtIdPresupuesto
            // 
            this.txtIdPresupuesto.Location = new System.Drawing.Point(237, 31);
            this.txtIdPresupuesto.Name = "txtIdPresupuesto";
            this.txtIdPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtIdPresupuesto.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(252, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Resultado";
            // 
            // pnlSolicitar
            // 
            this.pnlSolicitar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlSolicitar.Controls.Add(this.label18);
            this.pnlSolicitar.Controls.Add(this.label17);
            this.pnlSolicitar.Controls.Add(this.txtIProveedorSol);
            this.pnlSolicitar.Controls.Add(this.txtReferenciaSol);
            this.pnlSolicitar.Controls.Add(this.btnSolicitar);
            this.pnlSolicitar.Location = new System.Drawing.Point(9, 129);
            this.pnlSolicitar.Name = "pnlSolicitar";
            this.pnlSolicitar.Size = new System.Drawing.Size(577, 111);
            this.pnlSolicitar.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(407, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Id Proveedor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(119, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Referencia";
            // 
            // txtIProveedorSol
            // 
            this.txtIProveedorSol.Location = new System.Drawing.Point(388, 38);
            this.txtIProveedorSol.Name = "txtIProveedorSol";
            this.txtIProveedorSol.Size = new System.Drawing.Size(100, 20);
            this.txtIProveedorSol.TabIndex = 10;
            // 
            // txtReferenciaSol
            // 
            this.txtReferenciaSol.Location = new System.Drawing.Point(100, 38);
            this.txtReferenciaSol.Name = "txtReferenciaSol";
            this.txtReferenciaSol.Size = new System.Drawing.Size(100, 20);
            this.txtReferenciaSol.TabIndex = 9;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSolicitar.Location = new System.Drawing.Point(252, 81);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSolicitar.Size = new System.Drawing.Size(101, 23);
            this.btnSolicitar.TabIndex = 8;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // pnlRSol
            // 
            this.pnlRSol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlRSol.Controls.Add(this.label24);
            this.pnlRSol.Controls.Add(this.label23);
            this.pnlRSol.Controls.Add(this.label21);
            this.pnlRSol.Controls.Add(this.label20);
            this.pnlRSol.Controls.Add(this.txtFechaDis);
            this.pnlRSol.Controls.Add(this.txtDisponibilidad);
            this.pnlRSol.Controls.Add(this.txtPrecioPieza);
            this.pnlRSol.Controls.Add(this.txtMensSol);
            this.pnlRSol.Controls.Add(this.label22);
            this.pnlRSol.Location = new System.Drawing.Point(9, 246);
            this.pnlRSol.Name = "pnlRSol";
            this.pnlRSol.Size = new System.Drawing.Size(577, 100);
            this.pnlRSol.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(174, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Mensaje";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(325, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Fecha Disponibilidad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(159, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Disponibilidad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Precio";
            // 
            // txtFechaDis
            // 
            this.txtFechaDis.Location = new System.Drawing.Point(436, 40);
            this.txtFechaDis.Name = "txtFechaDis";
            this.txtFechaDis.Size = new System.Drawing.Size(133, 20);
            this.txtFechaDis.TabIndex = 11;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(237, 40);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(82, 20);
            this.txtDisponibilidad.TabIndex = 10;
            // 
            // txtPrecioPieza
            // 
            this.txtPrecioPieza.Location = new System.Drawing.Point(46, 40);
            this.txtPrecioPieza.Name = "txtPrecioPieza";
            this.txtPrecioPieza.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPieza.TabIndex = 9;
            // 
            // txtMensSol
            // 
            this.txtMensSol.Location = new System.Drawing.Point(238, 72);
            this.txtMensSol.Name = "txtMensSol";
            this.txtMensSol.Size = new System.Drawing.Size(216, 20);
            this.txtMensSol.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(252, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Resultado";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultCodPostal);
            this.Controls.Add(this.pnlIBAN);
            this.Controls.Add(this.pnlValidarNif);
            this.Controls.Add(this.btnValidarNIF);
            this.Controls.Add(this.btnValidarIBAN);
            this.Controls.Add(this.btnSolicitarPres);
            this.Controls.Add(this.btnObtenerPresupuesto);
            this.Controls.Add(this.panelResultadoValidacion);
            this.Controls.Add(this.pnlSolicitar);
            this.Controls.Add(this.pnlGenerarCodPost);
            this.Controls.Add(this.pnlCodPestal);
            this.Controls.Add(this.pnlRSol);
            this.Controls.Add(this.pnlResultadoGenerar);
            this.Controls.Add(this.pnlResultadosCodPost);
            this.Name = "FPrincipal";
            this.Text = "Pruebas de Servicio";
            this.pnlValidarNif.ResumeLayout(false);
            this.pnlValidarNif.PerformLayout();
            this.panelResultadoValidacion.ResumeLayout(false);
            this.panelResultadoValidacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlIBAN.ResumeLayout(false);
            this.pnlIBAN.PerformLayout();
            this.pnlCodPestal.ResumeLayout(false);
            this.pnlCodPestal.PerformLayout();
            this.pnlResultadosCodPost.ResumeLayout(false);
            this.pnlResultadosCodPost.PerformLayout();
            this.pnlGenerarCodPost.ResumeLayout(false);
            this.pnlGenerarCodPost.PerformLayout();
            this.pnlResultadoGenerar.ResumeLayout(false);
            this.pnlResultadoGenerar.PerformLayout();
            this.pnlSolicitar.ResumeLayout(false);
            this.pnlSolicitar.PerformLayout();
            this.pnlRSol.ResumeLayout(false);
            this.pnlRSol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnCompNIF;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox RtxtImg;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlValidarNif;
        private System.Windows.Forms.Button btnValidarNIF;
        private System.Windows.Forms.Panel panelResultadoValidacion;
        private System.Windows.Forms.Button btnValidarIBAN;
        private System.Windows.Forms.Button btnSolicitarPres;
        private System.Windows.Forms.Button btnObtenerPresupuesto;
        private System.Windows.Forms.Button btnConsultCodPostal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIBAN;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprobarIBAN;
        private System.Windows.Forms.Panel pnlCodPestal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Panel pnlResultadosCodPost;
        private System.Windows.Forms.TextBox txtCodPosResult;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlGenerarCodPost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.TextBox txtRefProduc;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.DateTimePicker dteFechaPresu;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlResultadoGenerar;
        private System.Windows.Forms.TextBox txtIdPresupuesto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMensajeGenerar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlSolicitar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIProveedorSol;
        private System.Windows.Forms.TextBox txtReferenciaSol;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Panel pnlRSol;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFechaDis;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.TextBox txtPrecioPieza;
        private System.Windows.Forms.TextBox txtMensSol;
    }
}

