using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class Exponente : Form
    {
        private Calculo_de_exponente calculo; 

        public Exponente()
        {
            InitializeComponent();
            calculo = new Calculo_de_exponente(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void insertarbt8_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dato1.Text, out int numero))
            {
                MessageBox.Show($"Número base establecido: {numero}");
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
                dato1.Clear();
            }
        }

        private void exponente1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dato2.Text, out int exponente))
            {
                MessageBox.Show($"Exponente establecido: {exponente}");
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido para el exponente.");
                dato2.Clear();
            }
        }

        private void Resultado1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dato1.Text, out int baseNum) || !int.TryParse(dato2.Text, out int exponente))
            {
                MessageBox.Show("Por favor, asegúrate de que los valores de la base y el exponente son números válidos.");
                return;
            }

           
            Stopwatch sw = Stopwatch.StartNew();
            long resultado = calculo.CalcularExponente(baseNum, exponente); 
            sw.Stop();

           
            dato3.Text = resultado.ToString();
            label3.Text = $"Tiempo: {sw.ElapsedMilliseconds} ms";
        }
    }
}
