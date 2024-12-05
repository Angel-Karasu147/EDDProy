using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace EDDemo.Recursividad
{
    public partial class Binaria : Form
    {
        private Busqueda_binaria busqueda;

        public Binaria()
        {
            InitializeComponent();
            busqueda = new Busqueda_binaria(); 
            datostx7.Text = string.Join(",", Enumerable.Range(1, 30).ToArray()); 
        }

        private void buscarbt7_Click(object sender, EventArgs e)
        {
            string[] datosString = datostx7.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] datos = Array.ConvertAll(datosString, int.Parse);

            Array.Sort(datos);

            
            string inputDato = Interaction.InputBox(
                "Introduce el dato a buscar:",
                "Búsqueda Binaria",
                "0"
            );

            if (!int.TryParse(inputDato, out int dato))
            {
                MessageBox.Show("Por favor, introduce un número válido.");
                return;
            }

           
            Stopwatch sw = Stopwatch.StartNew();
            int resultado = busqueda.Buscar(datos, 0, datos.Length - 1, dato);
            sw.Stop();

           
            if (resultado != -1)
                MessageBox.Show($"El dato {dato} fue encontrado en la posición {resultado}.");
            else
                MessageBox.Show($"El dato {dato} no fue encontrado.");

            
            tiempo1.Text = $"Tiempo: {sw.ElapsedMilliseconds} ms";
        }

        private void datostx7_TextChanged(object sender, EventArgs e)
        {
            
            datostx7.Text = string.Join(",", Enumerable.Range(1, 30).ToArray());
        }
    }
}
