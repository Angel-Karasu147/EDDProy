namespace EDDemo.Estructuras_Lineales
{
    partial class Mdoble
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
            this.Datotx1 = new System.Windows.Forms.TextBox();
            this.Generarbt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.insertarbt1 = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.Button();
            this.Recibir1 = new System.Windows.Forms.TextBox();
            this.lista2 = new System.Windows.Forms.Button();
            this.eliminarbt3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datotx1
            // 
            this.Datotx1.Location = new System.Drawing.Point(76, 66);
            this.Datotx1.Name = "Datotx1";
            this.Datotx1.Size = new System.Drawing.Size(100, 20);
            this.Datotx1.TabIndex = 1;
            // 
            // Generarbt1
            // 
            this.Generarbt1.Location = new System.Drawing.Point(56, 24);
            this.Generarbt1.Name = "Generarbt1";
            this.Generarbt1.Size = new System.Drawing.Size(75, 23);
            this.Generarbt1.TabIndex = 2;
            this.Generarbt1.Text = "Generar lista";
            this.Generarbt1.UseVisualStyleBackColor = true;
            this.Generarbt1.Click += new System.EventHandler(this.Generarbt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese dato";
            // 
            // insertarbt1
            // 
            this.insertarbt1.Location = new System.Drawing.Point(209, 63);
            this.insertarbt1.Name = "insertarbt1";
            this.insertarbt1.Size = new System.Drawing.Size(75, 23);
            this.insertarbt1.TabIndex = 4;
            this.insertarbt1.Text = "Insertar";
            this.insertarbt1.UseVisualStyleBackColor = true;
            this.insertarbt1.Click += new System.EventHandler(this.insertarbt1_Click);
            // 
            // lista1
            // 
            this.lista1.Location = new System.Drawing.Point(299, 63);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(75, 23);
            this.lista1.TabIndex = 5;
            this.lista1.Text = "Ver lista 1";
            this.lista1.UseVisualStyleBackColor = true;
            this.lista1.Click += new System.EventHandler(this.lista1_Click);
            // 
            // Recibir1
            // 
            this.Recibir1.Location = new System.Drawing.Point(7, 116);
            this.Recibir1.Name = "Recibir1";
            this.Recibir1.Size = new System.Drawing.Size(241, 20);
            this.Recibir1.TabIndex = 6;
            // 
            // lista2
            // 
            this.lista2.Location = new System.Drawing.Point(380, 64);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(75, 23);
            this.lista2.TabIndex = 7;
            this.lista2.Text = "Ver lista 2";
            this.lista2.UseVisualStyleBackColor = true;
            this.lista2.Click += new System.EventHandler(this.lista2_Click);
            // 
            // eliminarbt3
            // 
            this.eliminarbt3.Location = new System.Drawing.Point(299, 116);
            this.eliminarbt3.Name = "eliminarbt3";
            this.eliminarbt3.Size = new System.Drawing.Size(75, 23);
            this.eliminarbt3.TabIndex = 8;
            this.eliminarbt3.Text = "Eliminar";
            this.eliminarbt3.UseVisualStyleBackColor = true;
            this.eliminarbt3.Click += new System.EventHandler(this.eliminarbt3_Click);
            // 
            // Mdoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 403);
            this.Controls.Add(this.eliminarbt3);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.Recibir1);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.insertarbt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generarbt1);
            this.Controls.Add(this.Datotx1);
            this.Name = "Mdoble";
            this.Text = "Listas dobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Datotx1;
        private System.Windows.Forms.Button Generarbt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertarbt1;
        private System.Windows.Forms.Button lista1;
        private System.Windows.Forms.TextBox Recibir1;
        private System.Windows.Forms.Button lista2;
        private System.Windows.Forms.Button eliminarbt3;
    }
}