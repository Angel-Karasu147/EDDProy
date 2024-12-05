using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento
{
    public partial class quicksorts : Form
    {
        
        private Quicksort quicksort = new Quicksort();

        public quicksorts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void generarbt1_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(valor2.Text, out int cantidad) && cantidad > 0)
            {
                
                quicksort.GenerarElementosAleatorios(cantidad);

               
                Desordenados.Items.Clear();
                foreach (int num in quicksort.ObtenerElementos())
                {
                    Desordenados.Items.Add(num);
                }

              
                Ordenados.Items.Clear();
            }
            else
            {
               
                MessageBox.Show("Por favor, ingresa un número válido mayor a 0.");
            }
        }

        private void ordenarbt11_Click(object sender, EventArgs e)
        {
            
            quicksort.Ordenar();

            
            Ordenados.Items.Clear();
            foreach (int num in quicksort.ObtenerElementos())
            {
                Ordenados.Items.Add(num);
            }
        }
    }
}
