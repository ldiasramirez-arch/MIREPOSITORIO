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
    public partial class FormVentana3 : Form
    {
        private static FormVentana3 instancia = null;
        public static FormVentana3 Ventana_Unica()
        {
            if (instancia == null)
            {
                instancia = new FormVentana3();
                return instancia;
            }
            return instancia;
        }
        public FormVentana3()
        {
            InitializeComponent();
        }

        private void btncomvertir_Click(object sender, EventArgs e)
        {



    }
        }
}