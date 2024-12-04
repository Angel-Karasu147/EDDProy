using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class Mdoble : Form
    {
        private Listass_dobles lista;

        public Mdoble()
        {
            InitializeComponent();
        }

        private void Generarbt1_Click(object sender, EventArgs e)
        {
            lista = new Listass_dobles();

            
            Recibir1.Text = string.Empty;
            MessageBox.Show("Se ha generado una lista vacía.");
        }

        private void insertarbt1_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Primero debes generar una lista vacía.");
                return;
            }

            if (int.TryParse(Datotx1.Text, out int valor))
            {
                lista.Insertar(valor);

                
                Datotx1.Text = string.Empty;

                MessageBox.Show($"Se ha insertado el valor {valor}.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void eliminarbt3_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Primero debes generar una lista vacía.");
                return;
            }

            if (int.TryParse(Datotx1.Text, out int valor))
            {
                if (lista.Eliminar(valor))
                {
                    MessageBox.Show($"Se ha eliminado el valor {valor}.");
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encuentra en la lista.");
                }

                
                Datotx1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void lista1_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Primero debes generar una lista vacía.");
                return;
            }

            
            Recibir1.Text = $"Lista 1: {lista.ObtenerListaInversa()}";
        }

        private void lista2_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                MessageBox.Show("Primero debes generar una lista vacía.");
                return;
            }

            
            Recibir1.Text = $"Lista 2: {lista.ObtenerListaNormal()}";
        }
    }
}
