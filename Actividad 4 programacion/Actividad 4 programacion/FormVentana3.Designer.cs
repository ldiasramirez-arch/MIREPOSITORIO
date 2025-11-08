namespace Actividad_4_programacion
{
    partial class FormVentana3
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
            this.lbldolar = new System.Windows.Forms.Label();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.btncomvertir = new System.Windows.Forms.Button();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lbltasa = new System.Windows.Forms.Label();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Location = new System.Drawing.Point(12, 24);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(136, 13);
            this.lbldolar.TabIndex = 0;
            this.lbldolar.Text = "Cantidad en dolares (USD):";
            // 
            // txtdolar
            // 
            this.txtdolar.Location = new System.Drawing.Point(12, 57);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(100, 20);
            this.txtdolar.TabIndex = 1;
            // 
            // btncomvertir
            // 
            this.btncomvertir.Location = new System.Drawing.Point(12, 103);
            this.btncomvertir.Name = "btncomvertir";
            this.btncomvertir.Size = new System.Drawing.Size(75, 23);
            this.btncomvertir.TabIndex = 2;
            this.btncomvertir.Text = "Comvertir";
            this.btncomvertir.UseVisualStyleBackColor = true;
            this.btncomvertir.Click += new System.EventHandler(this.btncomvertir_Click);
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(12, 145);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(131, 13);
            this.lblpeso.TabIndex = 3;
            this.lblpeso.Text = "Cantidad en Pesos (DOP):";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(12, 185);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 4;
            // 
            // lbltasa
            // 
            this.lbltasa.AutoSize = true;
            this.lbltasa.Location = new System.Drawing.Point(12, 231);
            this.lbltasa.Name = "lbltasa";
            this.lbltasa.Size = new System.Drawing.Size(154, 13);
            this.lbltasa.TabIndex = 5;
            this.lbltasa.Text = "Tasa de Cambio (USD a DOP):";
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(12, 275);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 6;
            this.txttasa.Text = "(ej: 64.22";
            this.txttasa.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FormVentana3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.lbltasa);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.btncomvertir);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.lbldolar);
            this.Name = "FormVentana3";
            this.Text = "FormVentana3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.Button btncomvertir;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lbltasa;
        private System.Windows.Forms.TextBox txttasa;
    }
}