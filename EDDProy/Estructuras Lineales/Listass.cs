using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public partial class Listass : Form
    {
        private Listas miLista = new Listas();

        public Listass()

        {
            InitializeComponent();
        }

        private void Insertarbt2_Click(object sender, EventArgs e)
        {
            
            {
                if (int.TryParse(agregar2.Text.Trim(), out int dato))
                {
                    miLista.Agregar(dato);
                    dato2.Text = "Estado actual de la lista: " + string.Join(", ", miLista.Recorrer());
                    agregar2.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void eliminarbt2_Click(object sender, EventArgs e)
        {
            
            {
                if (int.TryParse(agregar2.Text.Trim(), out int dato))
                {
                    bool eliminado = miLista.Eliminar(dato);
                    dato2.Text = eliminado
                        ? $"Elemento {dato} eliminado.\nEstado actual de la lista: {string.Join(", ", miLista.Recorrer())}"
                        : $"El elemento {dato} no se encontró en la lista.";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void buscarbt2_Click(object sender, EventArgs e)
        {
            
            {
                if (int.TryParse(agregar2.Text.Trim(), out int dato))
                {
                    bool encontrado = miLista.Buscar(dato);
                    dato2.Text = encontrado
                        ? $"El elemento {dato} está en la lista."
                        : $"El elemento {dato} no está en la lista.";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void eliminabt2_Click(object sender, EventArgs e)
        {
           
                miLista.Limpiar();
                dato2.Text = "La lista ha sido vaciada.";
            }

        }
    }

