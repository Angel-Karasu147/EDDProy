using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public partial class Nodos : Form
    {
        private Cola miCola = new Cola(); 

        public Nodos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void agregarbt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(insertar.Text.Trim(), out int dato))
            {
                miCola.Encolar(dato);
                Dato.Text = "Estado actual de la cola: " + string.Join(", ", miCola.Recorrer());
                insertar.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Nodos_Load(object sender, EventArgs e)
        {
        }

        private void eliminarbt_Click(object sender, EventArgs e)
        {
            try
            {
                int elementoEliminado = miCola.Desencolar();
                Dato.Text = $"Elemento eliminado: {elementoEliminado}\nEstado actual de la cola: {string.Join(", ", miCola.Recorrer())}";
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buscarbt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(insertar.Text.Trim(), out int dato))
            {
                bool encontrado = miCola.Buscar(dato);
                Dato.Text = encontrado ? $"El elemento {dato} está en la cola." : $"El elemento {dato} no está en la cola.";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpiarbt_Click(object sender, EventArgs e)
        {
            miCola.Limpiar();
            Dato.Text = "La cola ha sido vaciada.";
        }
    }
}

