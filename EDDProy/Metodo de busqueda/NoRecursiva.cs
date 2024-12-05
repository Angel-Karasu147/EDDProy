using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDDemo.Metodo_de_busqueda
{
    public partial class NoRecursiva : Form
    {
        private List<int> numeros = new List<int>();

        public NoRecursiva()
        {
            InitializeComponent();
        }

        private void generar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                numeros.Add(random.Next(1, 1001));
            }

            numeros.Sort();

            Binaria.Items.Clear();
            foreach (var numero in numeros)
            {
                Binaria.Items.Add(numero);
            }

            this.numeros = numeros;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(buscartx.Text, out int valor)) 
            {
                int posicion = Busqueda_binaria_no_recursiva.Buscar(this.numeros, valor);

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
                MessageBox.Show("Por favor, ingresa un número válido en el campo de búsqueda.");
            }
        }

        private void limpiarbt_Click(object sender, EventArgs e)
        {
            Binaria.Items.Clear();
            this.numeros.Clear();
            buscartx.Clear(); 
        }
    }
}
