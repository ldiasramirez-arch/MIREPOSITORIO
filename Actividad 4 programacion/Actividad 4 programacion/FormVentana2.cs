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
    public partial class FormVentana2 : Form
    {
           
             private static FormVentana2 instancia = null;
            public static FormVentana2 Ventana_Unica()
            {
               if (instancia == null)
               {
                instancia = new FormVentana2();
                return instancia;
               }
               return instancia;
            }
            public FormVentana2() 
            {
              InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            ltsresultados.Items.Clear();

            if (int.TryParse(texnumeroTerminos.Text, out int nTermimos) && nTermimos > 0)
            {
                int a = 0;
                int b = 1;
                int c;

                if (nTermimos > 1)
                {
                    ltsresultados.Items.Add(a);
                }
                if (nTermimos > 2)
                {
                    ltsresultados.Items.Add(b);
                }

                for (int i = 2; i < nTermimos; i++)
                {
                    c = a + b;
                    ltsresultados.Items.Add(c);

                    a = b; b = c;
                }
            }

            
              
            

        }
    }
}
