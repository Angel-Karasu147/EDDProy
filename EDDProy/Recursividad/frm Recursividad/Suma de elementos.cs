using System;
using System.Windows.Forms;
using EDDemo.Recursividad; 

namespace EDDemo.Recursividad.frm_Recursividad
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = int.Parse(box1.Text);
                int valor2 = int.Parse(box2.Text);

                
                var (resultado, tiempo) = Calculadora.Sumar(valor1, valor2);

                MessageBox.Show($"Resultado: {resultado}\nTiempo de ejecución: {tiempo.TotalMilliseconds} ms", "Resultado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }
    }
}

