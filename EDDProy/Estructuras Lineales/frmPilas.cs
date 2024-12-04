using System;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Pilas miPila = new Pilas(); 

        public frmPilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string nuevoElemento = Insertartx.Text.Trim(); 

            if (!string.IsNullOrEmpty(nuevoElemento))
            {
                miPila.Agregar(nuevoElemento);
                si.Text = miPila.ObtenerEstado(); 
                Insertartx.Clear(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elementoEliminado = miPila.Eliminar();
            si.Text = elementoEliminado != null
                ? $"Elemento eliminado: {elementoEliminado}\nEstado actual: {miPila.ObtenerEstado()}"
                : "No hay elementos para eliminar.\nEstado actual: La pila está vacía.";
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
