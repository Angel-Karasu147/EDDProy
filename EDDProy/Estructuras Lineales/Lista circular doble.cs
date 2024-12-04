using System;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases; 

namespace EDDemo.Estructuras_Lineales
{
    public partial class Mcircular : Form
    {
        private Lista_circular_doble lista; 

        public Mcircular()
        {
            InitializeComponent();
            lista = new Lista_circular_doble(); 
        }

        private void crearbt4_Click(object sender, EventArgs e)
        {
            lista.CrearListaVacia();
            MessageBox.Show("Se ha creado una lista vacía.");
        }

        private void insertarbt6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(insertartb1.Text, out int dato))
            {
                lista.Insertar(dato);
                MessageBox.Show("Dato insertado correctamente.");
                insertartb1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void buscarbt5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(insertartb1.Text, out int dato))
            {
                var nodo = lista.Buscar(dato);
                listastb1.Text = nodo != null ? "Dato encontrado." : "Dato no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void eliminarbt5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(insertartb1.Text, out int dato))
            {
                bool eliminado = lista.Eliminar(dato);
                listastb1.Text = eliminado ? "Dato eliminado correctamente." : "Dato no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void ver3_Click(object sender, EventArgs e)
        {
            
            {
                listastb1.Text = lista.VerLista();
            }

        }
    }
}
