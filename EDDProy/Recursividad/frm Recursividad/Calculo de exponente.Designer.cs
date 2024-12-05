namespace EDDemo.Recursividad
{
    partial class Exponente
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
            this.dato1 = new System.Windows.Forms.TextBox();
            this.dato2 = new System.Windows.Forms.TextBox();
            this.insertarbt8 = new System.Windows.Forms.Button();
            this.exponente1 = new System.Windows.Forms.Button();
            this.dato3 = new System.Windows.Forms.TextBox();
            this.Complejidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dato1
            // 
            this.dato1.Location = new System.Drawing.Point(99, 66);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(100, 20);
            this.dato1.TabIndex = 1;
            // 
            // dato2
            // 
            this.dato2.Location = new System.Drawing.Point(99, 105);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(100, 20);
            this.dato2.TabIndex = 3;
            // 
            // insertarbt8
            // 
            this.insertarbt8.Location = new System.Drawing.Point(12, 66);
            this.insertarbt8.Name = "insertarbt8";
            this.insertarbt8.Size = new System.Drawing.Size(75, 23);
            this.insertarbt8.TabIndex = 4;
            this.insertarbt8.Text = "Insertar dato";
            this.insertarbt8.UseVisualStyleBackColor = true;
            this.insertarbt8.Click += new System.EventHandler(this.insertarbt8_Click);
            // 
            // exponente1
            // 
            this.exponente1.Location = new System.Drawing.Point(12, 105);
            this.exponente1.Name = "exponente1";
            this.exponente1.Size = new System.Drawing.Size(75, 23);
            this.exponente1.TabIndex = 5;
            this.exponente1.Text = "Exponente";
            this.exponente1.UseVisualStyleBackColor = true;
            this.exponente1.Click += new System.EventHandler(this.exponente1_Click);
            // 
            // dato3
            // 
            this.dato3.Location = new System.Drawing.Point(99, 141);
            this.dato3.Name = "dato3";
            this.dato3.Size = new System.Drawing.Size(100, 20);
            this.dato3.TabIndex = 7;
            // 
            // Complejidad
            // 
            this.Complejidad.AutoSize = true;
            this.Complejidad.Location = new System.Drawing.Point(12, 180);
            this.Complejidad.Name = "Complejidad";
            this.Complejidad.Size = new System.Drawing.Size(90, 13);
            this.Complejidad.TabIndex = 8;
            this.Complejidad.Text = "Complejidad: O(n)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tiempo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Resultado1
            // 
            this.Resultado1.Location = new System.Drawing.Point(12, 141);
            this.Resultado1.Name = "Resultado1";
            this.Resultado1.Size = new System.Drawing.Size(75, 21);
            this.Resultado1.TabIndex = 10;
            this.Resultado1.Text = "Resultado";
            this.Resultado1.UseVisualStyleBackColor = true;
            this.Resultado1.Click += new System.EventHandler(this.Resultado1_Click);
            // 
            // Exponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 328);
            this.Controls.Add(this.Resultado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Complejidad);
            this.Controls.Add(this.dato3);
            this.Controls.Add(this.exponente1);
            this.Controls.Add(this.insertarbt8);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.dato1);
            this.Name = "Exponente";
            this.Text = "Calculo de un exponente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dato1;
        private System.Windows.Forms.TextBox dato2;
        private System.Windows.Forms.Button insertarbt8;
        private System.Windows.Forms.Button exponente1;
        private System.Windows.Forms.TextBox dato3;
        private System.Windows.Forms.Label Complejidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Resultado1;
    }
}