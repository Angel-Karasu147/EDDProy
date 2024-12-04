namespace EDDemo.Estructuras_Lineales
{
    partial class Circular
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
            this.ingresarbt3 = new System.Windows.Forms.TextBox();
            this.crearbt2 = new System.Windows.Forms.Button();
            this.ingresarbt5 = new System.Windows.Forms.TextBox();
            this.insertarbt4 = new System.Windows.Forms.Button();
            this.ver2 = new System.Windows.Forms.Button();
            this.buscarbt4 = new System.Windows.Forms.Button();
            this.eliminarbt4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese dato";
            // 
            // ingresarbt3
            // 
            this.ingresarbt3.Location = new System.Drawing.Point(115, 101);
            this.ingresarbt3.Name = "ingresarbt3";
            this.ingresarbt3.Size = new System.Drawing.Size(100, 20);
            this.ingresarbt3.TabIndex = 1;
            // 
            // crearbt2
            // 
            this.crearbt2.Location = new System.Drawing.Point(46, 61);
            this.crearbt2.Name = "crearbt2";
            this.crearbt2.Size = new System.Drawing.Size(75, 23);
            this.crearbt2.TabIndex = 2;
            this.crearbt2.Text = "Crear lista";
            this.crearbt2.UseVisualStyleBackColor = true;
            this.crearbt2.Click += new System.EventHandler(this.crearbt2_Click);
            // 
            // ingresarbt5
            // 
            this.ingresarbt5.Location = new System.Drawing.Point(46, 170);
            this.ingresarbt5.Name = "ingresarbt5";
            this.ingresarbt5.Size = new System.Drawing.Size(201, 20);
            this.ingresarbt5.TabIndex = 4;
            // 
            // insertarbt4
            // 
            this.insertarbt4.Location = new System.Drawing.Point(46, 127);
            this.insertarbt4.Name = "insertarbt4";
            this.insertarbt4.Size = new System.Drawing.Size(75, 23);
            this.insertarbt4.TabIndex = 5;
            this.insertarbt4.Text = "Insertar";
            this.insertarbt4.UseVisualStyleBackColor = true;
            this.insertarbt4.Click += new System.EventHandler(this.insertarbt4_Click);
            // 
            // ver2
            // 
            this.ver2.Location = new System.Drawing.Point(140, 127);
            this.ver2.Name = "ver2";
            this.ver2.Size = new System.Drawing.Size(75, 23);
            this.ver2.TabIndex = 6;
            this.ver2.Text = "Ver lista";
            this.ver2.UseVisualStyleBackColor = true;
            this.ver2.Click += new System.EventHandler(this.ver2_Click);
            // 
            // buscarbt4
            // 
            this.buscarbt4.Location = new System.Drawing.Point(236, 127);
            this.buscarbt4.Name = "buscarbt4";
            this.buscarbt4.Size = new System.Drawing.Size(75, 23);
            this.buscarbt4.TabIndex = 7;
            this.buscarbt4.Text = "Buscar";
            this.buscarbt4.UseVisualStyleBackColor = true;
            this.buscarbt4.Click += new System.EventHandler(this.buscarbt4_Click);
            // 
            // eliminarbt4
            // 
            this.eliminarbt4.Location = new System.Drawing.Point(334, 127);
            this.eliminarbt4.Name = "eliminarbt4";
            this.eliminarbt4.Size = new System.Drawing.Size(75, 23);
            this.eliminarbt4.TabIndex = 8;
            this.eliminarbt4.Text = "Eliminar";
            this.eliminarbt4.UseVisualStyleBackColor = true;
            this.eliminarbt4.Click += new System.EventHandler(this.eliminarbt4_Click);
            // 
            // Circular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarbt4);
            this.Controls.Add(this.buscarbt4);
            this.Controls.Add(this.ver2);
            this.Controls.Add(this.insertarbt4);
            this.Controls.Add(this.ingresarbt5);
            this.Controls.Add(this.crearbt2);
            this.Controls.Add(this.ingresarbt3);
            this.Controls.Add(this.label1);
            this.Name = "Circular";
            this.Text = "Listas circular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresarbt3;
        private System.Windows.Forms.Button crearbt2;
        private System.Windows.Forms.TextBox ingresarbt5;
        private System.Windows.Forms.Button insertarbt4;
        private System.Windows.Forms.Button ver2;
        private System.Windows.Forms.Button buscarbt4;
        private System.Windows.Forms.Button eliminarbt4;
    }
}