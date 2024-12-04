using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class Circular : Form
    {
        private Listas_circulares listaCircular;

        public Circular()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void crearbt2_Click(object sender, EventArgs e)
        {
            
            {
                listaCircular = new Listas_circulares();
                ingresarbt5.Text = string.Empty;
                MessageBox.Show("Se ha creado una lista vacía.");
            }

        }

        private void insertarbt4_Click(object sender, EventArgs e)
        {
            
            {
                if (listaCircular == null)
                {
                    MessageBox.Show("Primero debes crear una lista.");
                    return;
                }

                if (int.TryParse(ingresarbt3.Text, out int valor))
                {
                    listaCircular.Insertar(valor);
                    ingresarbt3.Text = string.Empty;
                    MessageBox.Show($"Se ha insertado el valor {valor}.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.");
                }
            }

        }

        private void ver2_Click(object sender, EventArgs e)
        {
            
            {
                if (listaCircular == null)
                {
                    MessageBox.Show("Primero debes crear una lista.");
                    return;
                }

                ingresarbt5.Text = listaCircular.VerLista();
            }

        }

        private void buscarbt4_Click(object sender, EventArgs e)
        {
            
            {
                if (listaCircular == null)
                {
                    MessageBox.Show("Primero debes crear una lista.");
                    return;
                }

                if (int.TryParse(ingresarbt3.Text, out int valor))
                {
                    bool encontrado = listaCircular.Buscar(valor);
                    MessageBox.Show(encontrado ? $"El valor {valor} está en la lista." : $"El valor {valor} no está en la lista.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.");
                }
            }

        }

        private void eliminarbt4_Click(object sender, EventArgs e)
        {
            
            {
                if (listaCircular == null)
                {
                    MessageBox.Show("Primero debes crear una lista.");
                    return;
                }

                if (int.TryParse(ingresarbt3.Text, out int valor))
                {
                    bool eliminado = listaCircular.Eliminar(valor);
                    MessageBox.Show(eliminado ? $"Se ha eliminado el valor {valor}." : $"El valor {valor} no está en la lista.");
                    ingresarbt5.Text = listaCircular.VerLista();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.");
                }
            }

        }

       

        }
    }

