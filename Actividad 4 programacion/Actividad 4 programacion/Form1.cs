using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_4_programacion
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentana1 frm = FormVentana1.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ventana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentana2 frm =  FormVentana2.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ventana3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVentana3 frm =  FormVentana3.Ventana_Unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
