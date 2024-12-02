
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recursividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeExponenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialDeUnNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secuenciaDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumasDeElementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torreDeHanobiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeOrdenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodosDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaSecuencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.recursividadToolStripMenuItem,
            this.metodosDeOrdenamientoToolStripMenuItem,
            this.metodosDeBusquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.listasDoblesToolStripMenuItem,
            this.listasCircularesToolStripMenuItem,
            this.listasCircularesDoblesToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.colasToolStripMenuItem.Text = "Nodos";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no libeales";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // recursividadToolStripMenuItem
            // 
            this.recursividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaBinariaToolStripMenuItem,
            this.calculoDeExponenteToolStripMenuItem,
            this.factorialDeUnNumeroToolStripMenuItem,
            this.secuenciaDeFibonacciToolStripMenuItem,
            this.sumasDeElementosToolStripMenuItem,
            this.torreDeHanobiToolStripMenuItem});
            this.recursividadToolStripMenuItem.Name = "recursividadToolStripMenuItem";
            this.recursividadToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.recursividadToolStripMenuItem.Text = "Recursividad";
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // calculoDeExponenteToolStripMenuItem
            // 
            this.calculoDeExponenteToolStripMenuItem.Name = "calculoDeExponenteToolStripMenuItem";
            this.calculoDeExponenteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.calculoDeExponenteToolStripMenuItem.Text = "Calculo de exponente";
            this.calculoDeExponenteToolStripMenuItem.Click += new System.EventHandler(this.calculoDeExponenteToolStripMenuItem_Click);
            // 
            // factorialDeUnNumeroToolStripMenuItem
            // 
            this.factorialDeUnNumeroToolStripMenuItem.Name = "factorialDeUnNumeroToolStripMenuItem";
            this.factorialDeUnNumeroToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.factorialDeUnNumeroToolStripMenuItem.Text = "factorial de un numero";
            this.factorialDeUnNumeroToolStripMenuItem.Click += new System.EventHandler(this.factorialDeUnNumeroToolStripMenuItem_Click);
            // 
            // secuenciaDeFibonacciToolStripMenuItem
            // 
            this.secuenciaDeFibonacciToolStripMenuItem.Name = "secuenciaDeFibonacciToolStripMenuItem";
            this.secuenciaDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.secuenciaDeFibonacciToolStripMenuItem.Text = "secuencia de Fibonacci";
            this.secuenciaDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.secuenciaDeFibonacciToolStripMenuItem_Click);
            // 
            // sumasDeElementosToolStripMenuItem
            // 
            this.sumasDeElementosToolStripMenuItem.Name = "sumasDeElementosToolStripMenuItem";
            this.sumasDeElementosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sumasDeElementosToolStripMenuItem.Text = "sumas de elementos ";
            this.sumasDeElementosToolStripMenuItem.Click += new System.EventHandler(this.sumasDeElementosToolStripMenuItem_Click);
            // 
            // torreDeHanobiToolStripMenuItem
            // 
            this.torreDeHanobiToolStripMenuItem.Name = "torreDeHanobiToolStripMenuItem";
            this.torreDeHanobiToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.torreDeHanobiToolStripMenuItem.Text = "Torre de Hanobi";
            this.torreDeHanobiToolStripMenuItem.Click += new System.EventHandler(this.torreDeHanobiToolStripMenuItem_Click);
            // 
            // metodosDeOrdenamientoToolStripMenuItem
            // 
            this.metodosDeOrdenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shellsortToolStripMenuItem});
            this.metodosDeOrdenamientoToolStripMenuItem.Name = "metodosDeOrdenamientoToolStripMenuItem";
            this.metodosDeOrdenamientoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.metodosDeOrdenamientoToolStripMenuItem.Text = "Metodos de ordenamiento";
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            this.shellsortToolStripMenuItem.Click += new System.EventHandler(this.shellsortToolStripMenuItem_Click);
            // 
            // metodosDeBusquedaToolStripMenuItem
            // 
            this.metodosDeBusquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashToolStripMenuItem,
            this.busquedaSecuencialToolStripMenuItem});
            this.metodosDeBusquedaToolStripMenuItem.Name = "metodosDeBusquedaToolStripMenuItem";
            this.metodosDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.metodosDeBusquedaToolStripMenuItem.Text = "Metodos de busqueda";
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hashToolStripMenuItem.Text = "Hash";
            this.hashToolStripMenuItem.Click += new System.EventHandler(this.hashToolStripMenuItem_Click);
            // 
            // busquedaSecuencialToolStripMenuItem
            // 
            this.busquedaSecuencialToolStripMenuItem.Name = "busquedaSecuencialToolStripMenuItem";
            this.busquedaSecuencialToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.busquedaSecuencialToolStripMenuItem.Text = "Busqueda secuencial";
            this.busquedaSecuencialToolStripMenuItem.Click += new System.EventHandler(this.busquedaSecuencialToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // listasDoblesToolStripMenuItem
            // 
            this.listasDoblesToolStripMenuItem.Name = "listasDoblesToolStripMenuItem";
            this.listasDoblesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listasDoblesToolStripMenuItem.Text = "Listas dobles";
            this.listasDoblesToolStripMenuItem.Click += new System.EventHandler(this.listasDoblesToolStripMenuItem_Click);
            // 
            // listasCircularesToolStripMenuItem
            // 
            this.listasCircularesToolStripMenuItem.Name = "listasCircularesToolStripMenuItem";
            this.listasCircularesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listasCircularesToolStripMenuItem.Text = "Listas circulares";
            this.listasCircularesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesToolStripMenuItem_Click);
            // 
            // listasCircularesDoblesToolStripMenuItem
            // 
            this.listasCircularesDoblesToolStripMenuItem.Name = "listasCircularesDoblesToolStripMenuItem";
            this.listasCircularesDoblesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listasCircularesDoblesToolStripMenuItem.Text = "Listas circulares dobles";
            this.listasCircularesDoblesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesDoblesToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 499);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recursividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeExponenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialDeUnNumeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secuenciaDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumasDeElementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torreDeHanobiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeOrdenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodosDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaSecuencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesDoblesToolStripMenuItem;
    }
}

