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
    public partial class Radixx : Form
    {
        private List<int> numbers = new List<int>();

        public Radixx()
        {
            InitializeComponent();
        }

        private void agregarbt_Click(object sender, EventArgs e)
        {
            
            {
                if (int.TryParse(ingresar.Text, out int number)) 
                {
                    numbers.Add(number);
                    Desordenados.Items.Add(number);
                    ingresar.Clear(); 
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido."); 
                }
            }

        }

        private void ordenarbt_Click(object sender, EventArgs e)
        {
           
            {
                Ordenados.Items.Clear(); 

               
                List<List<int>> passes = Radix.RadixSort(new List<int>(numbers));

                
                for (int i = 0; i < passes.Count; i++)
                {
                    Ordenados.Items.Add($"Paso {i + 1}: {string.Join(", ", passes[i])}");
                }
            }

        }

        private void limpiarbt_Click(object sender, EventArgs e)
        {
            
            {
                numbers.Clear(); 
                Desordenados.Items.Clear(); 
                Ordenados.Items.Clear(); 
            }

        }
    }
}
