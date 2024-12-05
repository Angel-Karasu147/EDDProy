using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_busqueda
{
    public partial class frmShort : Form
    {
        private ShellShort shellShort = new ShellShort();
        


        public frmShort()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregar9_Click(object sender, EventArgs e)
        {
           
            {
                
                if (int.TryParse(si3.Text, out int elemento))
                {
                    shellShort.AgregarElemento(elemento);
                    si3.Text = shellShort.ObtenerElementos();
                   
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }

        }

        private void ordenador9_Click(object sender, EventArgs e)
        {
            
            {
                shellShort.Ordenar();
                si4.Text = shellShort.ObtenerElementos();
            }

        }
    }
}
