namespace EDDemo.Metodos_de_ordenamiento
{
    partial class quicksorts
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
            this.Desordenados = new System.Windows.Forms.ListBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.Ordenados = new System.Windows.Forms.ListBox();
            this.generarbt1 = new System.Windows.Forms.Button();
            this.ordenarbt11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Desordenados
            // 
            this.Desordenados.FormattingEnabled = true;
            this.Desordenados.Location = new System.Drawing.Point(43, 146);
            this.Desordenados.Name = "Desordenados";
            this.Desordenados.Size = new System.Drawing.Size(120, 186);
            this.Desordenados.TabIndex = 2;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(43, 61);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(138, 20);
            this.valor2.TabIndex = 3;
            // 
            // Ordenados
            // 
            this.Ordenados.FormattingEnabled = true;
            this.Ordenados.Location = new System.Drawing.Point(290, 146);
            this.Ordenados.Name = "Ordenados";
            this.Ordenados.Size = new System.Drawing.Size(120, 186);
            this.Ordenados.TabIndex = 4;
            // 
            // generarbt1
            // 
            this.generarbt1.Location = new System.Drawing.Point(190, 146);
            this.generarbt1.Name = "generarbt1";
            this.generarbt1.Size = new System.Drawing.Size(82, 23);
            this.generarbt1.TabIndex = 5;
            this.generarbt1.Text = "Generar";
            this.generarbt1.UseVisualStyleBackColor = true;
            this.generarbt1.Click += new System.EventHandler(this.generarbt1_Click);
            // 
            // ordenarbt11
            // 
            this.ordenarbt11.Location = new System.Drawing.Point(190, 191);
            this.ordenarbt11.Name = "ordenarbt11";
            this.ordenarbt11.Size = new System.Drawing.Size(82, 23);
            this.ordenarbt11.TabIndex = 6;
            this.ordenarbt11.Text = "Ordenar";
            this.ordenarbt11.UseVisualStyleBackColor = true;
            this.ordenarbt11.Click += new System.EventHandler(this.ordenarbt11_Click);
            // 
            // quicksorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordenarbt11);
            this.Controls.Add(this.generarbt1);
            this.Controls.Add(this.Ordenados);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.Desordenados);
            this.Controls.Add(this.label1);
            this.Name = "quicksorts";
            this.Text = "quicksorts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Desordenados;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.ListBox Ordenados;
        private System.Windows.Forms.Button generarbt1;
        private System.Windows.Forms.Button ordenarbt11;
    }
}