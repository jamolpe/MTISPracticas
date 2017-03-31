namespace control
{
    partial class Control
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
            this.TxboxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TxboxResult
            // 
            this.TxboxResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxboxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxboxResult.ForeColor = System.Drawing.SystemColors.Info;
            this.TxboxResult.HideSelection = false;
            this.TxboxResult.Location = new System.Drawing.Point(12, 12);
            this.TxboxResult.Name = "TxboxResult";
            this.TxboxResult.ReadOnly = true;
            this.TxboxResult.Size = new System.Drawing.Size(339, 310);
            this.TxboxResult.TabIndex = 0;
            this.TxboxResult.Text = "";
            this.TxboxResult.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 334);
            this.Controls.Add(this.TxboxResult);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxboxResult;
    }
}

