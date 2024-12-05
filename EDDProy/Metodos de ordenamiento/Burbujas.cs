using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class Burbujas : Form
    {
        private Burbuja burbuja = new Burbuja();

        public Burbujas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(agregar10.Text, out int elemento))
            {
                
                burbuja.AgregarElemento(elemento);

                
                box2.Items.Clear();
                foreach (int item in burbuja.ObtenerElementos())
                {
                    box2.Items.Add(item);
                }

                
                agregar10.Clear();
            }
            else
            {
                
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void ordenar2_Click(object sender, EventArgs e)
        {
            
            burbuja.Ordenar();

            
            box2.Items.Clear();
            foreach (int item in burbuja.ObtenerElementos())
            {
                box2.Items.Add(item);
            }
        }
    }
}
