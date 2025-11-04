namespace AppPrincipal
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirDivisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarSerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.divisasToolStripMenuItem,
            this.fibonacciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPersonaToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // registrarPersonaToolStripMenuItem
            // 
            this.registrarPersonaToolStripMenuItem.Name = "registrarPersonaToolStripMenuItem";
            this.registrarPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPersonaToolStripMenuItem.Text = "Registrar Persona";
            // 
            // divisasToolStripMenuItem
            // 
            this.divisasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertirDivisasToolStripMenuItem});
            this.divisasToolStripMenuItem.Name = "divisasToolStripMenuItem";
            this.divisasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.divisasToolStripMenuItem.Text = "Divisas";
            // 
            // convertirDivisasToolStripMenuItem
            // 
            this.convertirDivisasToolStripMenuItem.Name = "convertirDivisasToolStripMenuItem";
            this.convertirDivisasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertirDivisasToolStripMenuItem.Text = "Convertir Divisas";
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarSerieToolStripMenuItem});
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            // 
            // generarSerieToolStripMenuItem
            // 
            this.generarSerieToolStripMenuItem.Name = "generarSerieToolStripMenuItem";
            this.generarSerieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarSerieToolStripMenuItem.Text = "Generar Serie";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirDivisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarSerieToolStripMenuItem;
    }
}

