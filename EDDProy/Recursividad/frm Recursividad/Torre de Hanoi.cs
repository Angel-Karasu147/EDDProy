using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace EDDemo.Recursividad.frm_Recursividad
{
    public partial class Hanoi : Form
    {
        public Hanoi()
        {
            InitializeComponent();
        }

        
        public static string ResolverHanoi(int discos, char origen, char auxiliar, char destino, StringBuilder movimientos)
        {
            if (discos == 1)
            {
                movimientos.AppendLine($"Mover disco 1 de {origen} a {destino}");
            }
            else
            {
                ResolverHanoi(discos - 1, origen, destino, auxiliar, movimientos);
                movimientos.AppendLine($"Mover disco {discos} de {origen} a {destino}");
                ResolverHanoi(discos - 1, auxiliar, origen, destino, movimientos);
            }
            return movimientos.ToString();
        }

        
        private void hacer1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int discos = int.Parse(si3.Text);

                
                if (discos <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número de discos mayor que cero.", "Error");
                    return;
                }

               
                Stopwatch stopwatch = Stopwatch.StartNew();

                
                StringBuilder movimientos = new StringBuilder();
                ResolverHanoi(discos, 'A', 'B', 'C', movimientos);

               
                stopwatch.Stop();

               
                hola1.Text = movimientos.ToString();

                
                MessageBox.Show($"La Torre de Hanoi se completó en {stopwatch.Elapsed.TotalMilliseconds} ms", "Tiempo de Ejecución");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }

        
        private void hola1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
