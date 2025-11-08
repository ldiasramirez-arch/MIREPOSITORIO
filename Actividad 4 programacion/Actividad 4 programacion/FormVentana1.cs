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
    public partial class FormVentana1 : Form
    {
        private static FormVentana1 instancia = null;
        public static FormVentana1 Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new FormVentana1();
                return instancia;
            }
            return instancia;
        }
        public FormVentana1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int n = dtgvpersonas.Rows.Add();
            dtgvpersonas.Rows[n].Cells[0].Value = txtnombre.Text;
            dtgvpersonas.Rows[n].Cells[1].Value = txtapellido.Text;
            dtgvpersonas.Rows[n].Cells[2].Value = txtedad.Text;
            dtgvpersonas.Rows[n].Cells[3].Value = txttelefono.Text;
            dtgvpersonas.Rows[n].Cells[4].Value = txtpais.Text;
            dtgvpersonas.Rows[n].Cells[5].Value =txtciudad.Text;
            dtgvpersonas.Rows[n].Cells[6].Value = txtestatura.Text;
            dtgvpersonas.Rows[n].Cells[7].Value = txtgenero.Text;
            dtgvpersonas.Rows[n].Cells[8].Value = txtpadre.Text;
            dtgvpersonas.Rows[n].Cells[9].Value = txtmadre.Text;
            dtgvpersonas.Rows[n].Cells[10].Value = txtocupacion.Text;
            dtgvpersonas.Rows[n].Cells[11].Value = txtunivercidad.Text;

            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txttelefono.Text = "";
            txtciudad.Text = "";
            txtpais.Text = "";
            txtestatura.Text = "";
            txtgenero.Text = "";
            txtpadre.Text = "";
            txtmadre.Text = "";
            txtocupacion.Text = "";
            txtunivercidad.Text = "";

        }
    }
}
