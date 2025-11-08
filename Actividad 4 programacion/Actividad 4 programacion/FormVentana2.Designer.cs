namespace Actividad_4_programacion
{
    partial class FormVentana2
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
            this.texnumeroTerminos = new System.Windows.Forms.TextBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.ltsresultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // texnumeroTerminos
            // 
            this.texnumeroTerminos.Location = new System.Drawing.Point(12, 50);
            this.texnumeroTerminos.Name = "texnumeroTerminos";
            this.texnumeroTerminos.Size = new System.Drawing.Size(128, 20);
            this.texnumeroTerminos.TabIndex = 0;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(39, 76);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 23);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "agregar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltsresultados
            // 
            this.ltsresultados.FormattingEnabled = true;
            this.ltsresultados.Location = new System.Drawing.Point(12, 105);
            this.ltsresultados.Name = "ltsresultados";
            this.ltsresultados.Size = new System.Drawing.Size(128, 303);
            this.ltsresultados.TabIndex = 2;
            // 
            // FormVentana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.ltsresultados);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.texnumeroTerminos);
            this.Name = "FormVentana2";
            this.Text = "FormVentana2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texnumeroTerminos;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.ListBox ltsresultados;
    }
}