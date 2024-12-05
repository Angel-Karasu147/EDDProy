namespace EDDemo.Metodo_de_busqueda
{
    partial class Msecuencial
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
            this.insertar = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.buscarbt = new System.Windows.Forms.Button();
            this.Limpiarbt = new System.Windows.Forms.Button();
            this.generarbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar dato";
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(137, 54);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(100, 20);
            this.insertar.TabIndex = 1;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(44, 106);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(193, 199);
            this.Lista.TabIndex = 2;
            // 
            // buscarbt
            // 
            this.buscarbt.Location = new System.Drawing.Point(254, 84);
            this.buscarbt.Name = "buscarbt";
            this.buscarbt.Size = new System.Drawing.Size(93, 28);
            this.buscarbt.TabIndex = 3;
            this.buscarbt.Text = "Buscar";
            this.buscarbt.UseVisualStyleBackColor = true;
            this.buscarbt.Click += new System.EventHandler(this.buscarbt_Click);
            // 
            // Limpiarbt
            // 
            this.Limpiarbt.Location = new System.Drawing.Point(254, 121);
            this.Limpiarbt.Name = "Limpiarbt";
            this.Limpiarbt.Size = new System.Drawing.Size(93, 28);
            this.Limpiarbt.TabIndex = 4;
            this.Limpiarbt.Text = "Limpiar";
            this.Limpiarbt.UseVisualStyleBackColor = true;
            this.Limpiarbt.Click += new System.EventHandler(this.Limpiarbt_Click);
            // 
            // generarbt
            // 
            this.generarbt.Location = new System.Drawing.Point(254, 50);
            this.generarbt.Name = "generarbt";
            this.generarbt.Size = new System.Drawing.Size(93, 28);
            this.generarbt.TabIndex = 5;
            this.generarbt.Text = "Generar";
            this.generarbt.UseVisualStyleBackColor = true;
            this.generarbt.Click += new System.EventHandler(this.generarbt_Click);
            // 
            // Msecuencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generarbt);
            this.Controls.Add(this.Limpiarbt);
            this.Controls.Add(this.buscarbt);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.label1);
            this.Name = "Msecuencial";
            this.Text = "Busqueda secuncial ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insertar;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button buscarbt;
        private System.Windows.Forms.Button Limpiarbt;
        private System.Windows.Forms.Button generarbt;
    }
}