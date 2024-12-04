namespace EDDemo.Estructuras_Lineales.Clases
{
    partial class Nodos
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
            this.Insertar_valor = new System.Windows.Forms.Label();
            this.insertar = new System.Windows.Forms.TextBox();
            this.agregarbt = new System.Windows.Forms.Button();
            this.eliminarbt = new System.Windows.Forms.Button();
            this.buscarbt = new System.Windows.Forms.Button();
            this.limpiarbt = new System.Windows.Forms.Button();
            this.Dato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insertar_valor
            // 
            this.Insertar_valor.AutoSize = true;
            this.Insertar_valor.Location = new System.Drawing.Point(25, 75);
            this.Insertar_valor.Name = "Insertar_valor";
            this.Insertar_valor.Size = new System.Drawing.Size(59, 13);
            this.Insertar_valor.TabIndex = 0;
            this.Insertar_valor.Text = "Insrta valor";
            this.Insertar_valor.Click += new System.EventHandler(this.label1_Click);
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(90, 72);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(100, 20);
            this.insertar.TabIndex = 1;
            // 
            // agregarbt
            // 
            this.agregarbt.Location = new System.Drawing.Point(215, 40);
            this.agregarbt.Name = "agregarbt";
            this.agregarbt.Size = new System.Drawing.Size(75, 23);
            this.agregarbt.TabIndex = 2;
            this.agregarbt.Text = "Agregar";
            this.agregarbt.UseVisualStyleBackColor = true;
            this.agregarbt.Click += new System.EventHandler(this.agregarbt_Click);
            // 
            // eliminarbt
            // 
            this.eliminarbt.Location = new System.Drawing.Point(215, 70);
            this.eliminarbt.Name = "eliminarbt";
            this.eliminarbt.Size = new System.Drawing.Size(75, 23);
            this.eliminarbt.TabIndex = 3;
            this.eliminarbt.Text = "Eliminar ";
            this.eliminarbt.UseVisualStyleBackColor = true;
            this.eliminarbt.Click += new System.EventHandler(this.eliminarbt_Click);
            // 
            // buscarbt
            // 
            this.buscarbt.Location = new System.Drawing.Point(215, 99);
            this.buscarbt.Name = "buscarbt";
            this.buscarbt.Size = new System.Drawing.Size(75, 23);
            this.buscarbt.TabIndex = 4;
            this.buscarbt.Text = "Buscar";
            this.buscarbt.UseVisualStyleBackColor = true;
            this.buscarbt.Click += new System.EventHandler(this.buscarbt_Click);
            // 
            // limpiarbt
            // 
            this.limpiarbt.Location = new System.Drawing.Point(215, 128);
            this.limpiarbt.Name = "limpiarbt";
            this.limpiarbt.Size = new System.Drawing.Size(75, 23);
            this.limpiarbt.TabIndex = 5;
            this.limpiarbt.Text = "Limpiar";
            this.limpiarbt.UseVisualStyleBackColor = true;
            this.limpiarbt.Click += new System.EventHandler(this.limpiarbt_Click);
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Location = new System.Drawing.Point(25, 128);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(0, 13);
            this.Dato.TabIndex = 7;
            // 
            // Nodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 379);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.limpiarbt);
            this.Controls.Add(this.buscarbt);
            this.Controls.Add(this.eliminarbt);
            this.Controls.Add(this.agregarbt);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.Insertar_valor);
            this.Name = "Nodos";
            this.Text = "colas";
            this.Load += new System.EventHandler(this.Nodos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Insertar_valor;
        private System.Windows.Forms.TextBox insertar;
        private System.Windows.Forms.Button agregarbt;
        private System.Windows.Forms.Button eliminarbt;
        private System.Windows.Forms.Button buscarbt;
        private System.Windows.Forms.Button limpiarbt;
        private System.Windows.Forms.Label Dato;
    }
}