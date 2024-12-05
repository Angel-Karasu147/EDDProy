using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EDDemo.Recursividad.frm_Recursividad
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void factorialbt_Click(object sender, EventArgs e)
        {
            try
            {

                int numero = int.Parse(ingresarbt8.Text);
            

                
                Stopwatch cronometro = Stopwatch.StartNew();


                long resultado = Factorialcal.Calcular(numero);


                cronometro.Stop();
            
               
                ingresarbt9.Text = resultado.ToString();

                MessageBox.Show($"Tiempo de cálculo: {cronometro.ElapsedMilliseconds} ms", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
