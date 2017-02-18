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
            this.pnlValidarNif.SuspendLayout();
            this.panelResultadoValidacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIBAN.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(260, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(252, 67);
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
            this.pnlValidarNif.Size = new System.Drawing.Size(577, 111);
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
            // 
            // btnObtenerPresupuesto
            // 
            this.btnObtenerPresupuesto.Location = new System.Drawing.Point(303, 12);
            this.btnObtenerPresupuesto.Name = "btnObtenerPresupuesto";
            this.btnObtenerPresupuesto.Size = new System.Drawing.Size(140, 23);
            this.btnObtenerPresupuesto.TabIndex = 13;
            this.btnObtenerPresupuesto.Text = "Obtener Presupuesto";
            this.btnObtenerPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnConsultCodPostal
            // 
            this.btnConsultCodPostal.Location = new System.Drawing.Point(446, 12);
            this.btnConsultCodPostal.Name = "btnConsultCodPostal";
            this.btnConsultCodPostal.Size = new System.Drawing.Size(140, 23);
            this.btnConsultCodPostal.TabIndex = 14;
            this.btnConsultCodPostal.Text = "Consultar CodPostal";
            this.btnConsultCodPostal.UseVisualStyleBackColor = true;
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
            this.pnlIBAN.Size = new System.Drawing.Size(580, 111);
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
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConsultCodPostal);
            this.Controls.Add(this.panelResultadoValidacion);
            this.Controls.Add(this.pnlIBAN);
            this.Controls.Add(this.pnlValidarNif);
            this.Controls.Add(this.btnValidarNIF);
            this.Controls.Add(this.btnValidarIBAN);
            this.Controls.Add(this.btnSolicitarPres);
            this.Controls.Add(this.btnObtenerPresupuesto);
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
    }
}

