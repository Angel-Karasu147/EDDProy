namespace EDDemo.Metodo_de_busqueda
{
    partial class NoRecursiva
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
            this.label1 = new System.Windows.Forms.Label();
            this.Binaria = new System.Windows.Forms.ListBox();
            this.buscar = new System.Windows.Forms.Button();
            this.generar = new System.Windows.Forms.Button();
            this.limpiarbt = new System.Windows.Forms.Button();
            this.buscartx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // Binaria
            // 
            this.Binaria.FormattingEnabled = true;
            this.Binaria.Location = new System.Drawing.Point(12, 87);
            this.Binaria.Name = "Binaria";
            this.Binaria.Size = new System.Drawing.Size(299, 160);
            this.Binaria.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(317, 87);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // generar
            // 
            this.generar.Location = new System.Drawing.Point(317, 116);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(75, 23);
            this.generar.TabIndex = 3;
            this.generar.Text = "Generar";
            this.generar.UseVisualStyleBackColor = true;
            this.generar.Click += new System.EventHandler(this.generar_Click);
            // 
            // limpiarbt
            // 
            this.limpiarbt.Location = new System.Drawing.Point(317, 145);
            this.limpiarbt.Name = "limpiarbt";
            this.limpiarbt.Size = new System.Drawing.Size(75, 23);
            this.limpiarbt.TabIndex = 4;
            this.limpiarbt.Text = "Limpiar";
            this.limpiarbt.UseVisualStyleBackColor = true;
            this.limpiarbt.Click += new System.EventHandler(this.limpiarbt_Click);
            // 
            // buscartx
            // 
            this.buscartx.Location = new System.Drawing.Point(398, 90);
            this.buscartx.Name = "buscartx";
            this.buscartx.Size = new System.Drawing.Size(100, 20);
            this.buscartx.TabIndex = 5;
            // 
            // NoRecursiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscartx);
            this.Controls.Add(this.limpiarbt);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.Binaria);
            this.Controls.Add(this.label1);
            this.Name = "NoRecursiva";
            this.Text = "Busqueda binaria no recursiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Binaria;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.Button limpiarbt;
        private System.Windows.Forms.TextBox buscartx;
    }
}