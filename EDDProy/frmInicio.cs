using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodo_de_busqueda;
using EDDemo.Metodos_de_busqueda;
using EDDemo.Metodos_de_ordenamiento;
using EDDemo.Recursividad;
using EDDemo.Recursividad.frm_Recursividad;


namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasLinealesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nodos mnodos = new Nodos();
            mnodos.MdiParent = this;
            mnodos.Show();



        }

        



        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binaria mbinaria = new Binaria();
            mbinaria.MdiParent = this;
            mbinaria.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci frfibonacci = new Fibonacci();
            frfibonacci.MdiParent = this;
            frfibonacci.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShort fshort = new frmShort();
            fshort.MdiParent = this;
            fshort.Show();
        }

        private void calculoDeExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exponente fexponente = new Exponente();
            fexponente.MdiParent = this;
            fexponente.Show();

        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial frfactorial = new Factorial();
            frfactorial.MdiParent = this;
            frfactorial.Show();

        }

        private void sumasDeElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suma fsuma = new Suma();
            fsuma.MdiParent = this;
            fsuma.Show();

        }

        private void torreDeHanobiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hanoi fhanoi = new Hanoi();
            fhanoi.MdiParent = this;
            fhanoi.Show();

        }

        

        private void busquedaSecuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Msecuencial msecu = new Msecuencial();
            msecu.MdiParent = this;
            msecu.Show();

        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listass flista = new Listass();
            flista.MdiParent = this;
            flista.Show();

        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mdoble mdoble = new Mdoble();
            mdoble.MdiParent = this;
            mdoble.Show();

        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circular fcircular = new Circular();
            fcircular.MdiParent = this;
            fcircular.Show();


        }

        private void listasCircularesDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mcircular mcircular = new Mcircular();
            mcircular.MdiParent = this;
            mcircular.Show();

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbujas burbuja = new Burbujas();
            burbuja.MdiParent = this;
            burbuja.Show();

            
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quicksorts mquick = new quicksorts();
            mquick.MdiParent = this;
            mquick.Show();

        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radixx fradix = new Radixx();
            fradix.MdiParent = this;
            fradix.Show();

        }

        private void busquedaBinariaNoRecursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoRecursiva norecursiva = new NoRecursiva();
            norecursiva.MdiParent = this;
            norecursiva.Show();

        }
    }
}
