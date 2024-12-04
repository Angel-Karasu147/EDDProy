namespace EDDemo.Estructuras_Lineales.Clases
{
    partial class Listass
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
            this.label2 = new System.Windows.Forms.Label();
            this.agregar2 = new System.Windows.Forms.TextBox();
            this.Insertarbt2 = new System.Windows.Forms.Button();
            this.eliminarbt2 = new System.Windows.Forms.Button();
            this.buscarbt2 = new System.Windows.Forms.Button();
            this.eliminabt2 = new System.Windows.Forms.Button();
            this.dato2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insertar dato";
            // 
            // agregar2
            // 
            this.agregar2.Location = new System.Drawing.Point(109, 77);
            this.agregar2.Name = "agregar2";
            this.agregar2.Size = new System.Drawing.Size(100, 20);
            this.agregar2.TabIndex = 2;
            // 
            // Insertarbt2
            // 
            this.Insertarbt2.Location = new System.Drawing.Point(215, 67);
            this.Insertarbt2.Name = "Insertarbt2";
            this.Insertarbt2.Size = new System.Drawing.Size(75, 23);
            this.Insertarbt2.TabIndex = 3;
            this.Insertarbt2.Text = "Insertar";
            this.Insertarbt2.UseVisualStyleBackColor = true;
            this.Insertarbt2.Click += new System.EventHandler(this.Insertarbt2_Click);
            // 
            // eliminarbt2
            // 
            this.eliminarbt2.Location = new System.Drawing.Point(215, 96);
            this.eliminarbt2.Name = "eliminarbt2";
            this.eliminarbt2.Size = new System.Drawing.Size(75, 23);
            this.eliminarbt2.TabIndex = 4;
            this.eliminarbt2.Text = "Eliminar";
            this.eliminarbt2.UseVisualStyleBackColor = true;
            this.eliminarbt2.Click += new System.EventHandler(this.eliminarbt2_Click);
            // 
            // buscarbt2
            // 
            this.buscarbt2.Location = new System.Drawing.Point(217, 125);
            this.buscarbt2.Name = "buscarbt2";
            this.buscarbt2.Size = new System.Drawing.Size(73, 32);
            this.buscarbt2.TabIndex = 5;
            this.buscarbt2.Text = "Buscar";
            this.buscarbt2.UseVisualStyleBackColor = true;
            this.buscarbt2.Click += new System.EventHandler(this.buscarbt2_Click);
            // 
            // eliminabt2
            // 
            this.eliminabt2.Location = new System.Drawing.Point(215, 163);
            this.eliminabt2.Name = "eliminabt2";
            this.eliminabt2.Size = new System.Drawing.Size(75, 30);
            this.eliminabt2.TabIndex = 6;
            this.eliminabt2.Text = "Eliminar";
            this.eliminabt2.UseVisualStyleBackColor = true;
            this.eliminabt2.Click += new System.EventHandler(this.eliminabt2_Click);
            // 
            // dato2
            // 
            this.dato2.AutoSize = true;
            this.dato2.Location = new System.Drawing.Point(58, 135);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(35, 13);
            this.dato2.TabIndex = 7;
            this.dato2.Text = "label1";
            // 
            // Listass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.eliminabt2);
            this.Controls.Add(this.buscarbt2);
            this.Controls.Add(this.eliminarbt2);
            this.Controls.Add(this.Insertarbt2);
            this.Controls.Add(this.agregar2);
            this.Controls.Add(this.label2);
            this.Name = "Listass";
            this.Text = "Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox agregar2;
        private System.Windows.Forms.Button Insertarbt2;
        private System.Windows.Forms.Button eliminarbt2;
        private System.Windows.Forms.Button buscarbt2;
        private System.Windows.Forms.Button eliminabt2;
        private System.Windows.Forms.Label dato2;
    }
}