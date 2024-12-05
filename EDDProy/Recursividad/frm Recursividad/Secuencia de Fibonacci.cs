using System;
using System.Diagnostics;
using System.Windows.Forms;
using EDDemo.Recursividad; 

namespace EDDemo.Recursividad.frm_Recursividad
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            
        }

        private void si2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!int.TryParse(fibo1.Text, out int numero) || numero < 0)
                {
                    MessageBox.Show("Por favor, ingrese un número válido mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                Stopwatch cronometro = Stopwatch.StartNew();

               
                long[] secuencia = fibo.GenerarSecuencia(numero);

                cronometro.Stop();

               
                string resultado = string.Join(", ", secuencia);
                fibo3.Text = resultado;

               
                MessageBox.Show($"Tiempo de cálculo: {cronometro.ElapsedMilliseconds} ms", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
