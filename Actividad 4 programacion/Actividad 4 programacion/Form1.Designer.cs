namespace Actividad_4_programacion
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventana1ToolStripMenuItem,
            this.ventana2ToolStripMenuItem,
            this.ventana3ToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // ventana1ToolStripMenuItem
            // 
            this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
            this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventana1ToolStripMenuItem.Text = "Ventana1 ";
            this.ventana1ToolStripMenuItem.Click += new System.EventHandler(this.ventana1ToolStripMenuItem_Click);
            // 
            // ventana2ToolStripMenuItem
            // 
            this.ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
            this.ventana2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventana2ToolStripMenuItem.Text = "Ventana 2";
            this.ventana2ToolStripMenuItem.Click += new System.EventHandler(this.ventana2ToolStripMenuItem_Click);
            // 
            // ventana3ToolStripMenuItem
            // 
            this.ventana3ToolStripMenuItem.Name = "ventana3ToolStripMenuItem";
            this.ventana3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventana3ToolStripMenuItem.Text = "Ventana 3";
            this.ventana3ToolStripMenuItem.Click += new System.EventHandler(this.ventana3ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana3ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

