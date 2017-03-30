namespace Invernadero
{
    partial class Invernadero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lbbTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(74, 48);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(118, 42);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "label2";
            // 
            // lbbTemp
            // 
            this.lbbTemp.AutoSize = true;
            this.lbbTemp.Location = new System.Drawing.Point(114, 139);
            this.lbbTemp.Name = "lbbTemp";
            this.lbbTemp.Size = new System.Drawing.Size(35, 13);
            this.lbbTemp.TabIndex = 1;
            this.lbbTemp.Text = "label2";
            // 
            // Invernadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbbTemp);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "Invernadero";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lbbTemp;
    }
}

