using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodo_de_busqueda
{
    public partial class Msecuencial : Form
    {
        private List<int> numeros = new List<int>();

        public Msecuencial()
        {
            InitializeComponent();
        }

        private void generarbt_Click(object sender, EventArgs e)
        {
            
            {
                Random random = new Random();
                List<int> numeros = new List<int>();

                for (int i = 0; i < 100; i++)
                {
                    numeros.Add(random.Next(1, 1001)); 
                }

                Lista.Items.Clear(); 
                foreach (var numero in numeros)
                {
                    Lista.Items.Add(numero); 
                }

               
                this.numeros = numeros;
            }

        }

        private void buscarbt_Click(object sender, EventArgs e)
        {
           
            {
                if (int.TryParse(insertar.Text, out int valor))
                {
                    int posicion = Busqueda_secuenial.Buscar(this.numeros, valor);

                    if (posicion != -1)
                    {
                        MessageBox.Show($"Tu dato {valor} ha sido encontrado en la posición {posicion}.");
                    }
                    else
                    {
                        MessageBox.Show($"Tu dato {valor} no está en esta lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }

        }

        private void Limpiarbt_Click(object sender, EventArgs e)
        {
            
            {
                Lista.Items.Clear();
                this.numeros.Clear(); 
                insertar.Clear(); 
            }

        }
    }
}
