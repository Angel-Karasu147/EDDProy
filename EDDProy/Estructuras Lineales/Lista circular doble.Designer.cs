namespace EDDemo.Estructuras_Lineales
{
    partial class Mcircular
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
            this.insertartb1 = new System.Windows.Forms.TextBox();
            this.listastb1 = new System.Windows.Forms.TextBox();
            this.crearbt4 = new System.Windows.Forms.Button();
            this.insertarbt6 = new System.Windows.Forms.Button();
            this.buscarbt5 = new System.Windows.Forms.Button();
            this.eliminarbt5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ver3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertartb1
            // 
            this.insertartb1.Location = new System.Drawing.Point(79, 92);
            this.insertartb1.Name = "insertartb1";
            this.insertartb1.Size = new System.Drawing.Size(100, 20);
            this.insertartb1.TabIndex = 0;
            // 
            // listastb1
            // 
            this.listastb1.Location = new System.Drawing.Point(79, 130);
            this.listastb1.Name = "listastb1";
            this.listastb1.Size = new System.Drawing.Size(173, 20);
            this.listastb1.TabIndex = 1;
            // 
            // crearbt4
            // 
            this.crearbt4.Location = new System.Drawing.Point(6, 196);
            this.crearbt4.Name = "crearbt4";
            this.crearbt4.Size = new System.Drawing.Size(75, 23);
            this.crearbt4.TabIndex = 3;
            this.crearbt4.Text = "Crear lista";
            this.crearbt4.UseVisualStyleBackColor = true;
            this.crearbt4.Click += new System.EventHandler(this.crearbt4_Click);
            // 
            // insertarbt6
            // 
            this.insertarbt6.Location = new System.Drawing.Point(116, 196);
            this.insertarbt6.Name = "insertarbt6";
            this.insertarbt6.Size = new System.Drawing.Size(75, 23);
            this.insertarbt6.TabIndex = 4;
            this.insertarbt6.Text = "Insertar";
            this.insertarbt6.UseVisualStyleBackColor = true;
            this.insertarbt6.Click += new System.EventHandler(this.insertarbt6_Click);
            // 
            // buscarbt5
            // 
            this.buscarbt5.Location = new System.Drawing.Point(6, 242);
            this.buscarbt5.Name = "buscarbt5";
            this.buscarbt5.Size = new System.Drawing.Size(75, 23);
            this.buscarbt5.TabIndex = 6;
            this.buscarbt5.Text = "Buscar dato";
            this.buscarbt5.UseVisualStyleBackColor = true;
            this.buscarbt5.Click += new System.EventHandler(this.buscarbt5_Click);
            // 
            // eliminarbt5
            // 
            this.eliminarbt5.Location = new System.Drawing.Point(116, 242);
            this.eliminarbt5.Name = "eliminarbt5";
            this.eliminarbt5.Size = new System.Drawing.Size(75, 23);
            this.eliminarbt5.TabIndex = 7;
            this.eliminarbt5.Text = "Eliminar";
            this.eliminarbt5.UseVisualStyleBackColor = true;
            this.eliminarbt5.Click += new System.EventHandler(this.eliminarbt5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insertar dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mostrar lista";
            // 
            // ver3
            // 
            this.ver3.Location = new System.Drawing.Point(210, 196);
            this.ver3.Name = "ver3";
            this.ver3.Size = new System.Drawing.Size(71, 24);
            this.ver3.TabIndex = 10;
            this.ver3.Text = "Ver lista";
            this.ver3.UseVisualStyleBackColor = true;
            this.ver3.Click += new System.EventHandler(this.ver3_Click);
            // 
            // Mcircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 412);
            this.Controls.Add(this.ver3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarbt5);
            this.Controls.Add(this.buscarbt5);
            this.Controls.Add(this.insertarbt6);
            this.Controls.Add(this.crearbt4);
            this.Controls.Add(this.listastb1);
            this.Controls.Add(this.insertartb1);
            this.Name = "Mcircular";
            this.Text = "Listas circular doble";
            this.Load += new System.EventHandler(this.Mcircular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox insertartb1;
        private System.Windows.Forms.TextBox listastb1;
        private System.Windows.Forms.Button crearbt4;
        private System.Windows.Forms.Button insertarbt6;
        private System.Windows.Forms.Button buscarbt5;
        private System.Windows.Forms.Button eliminarbt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ver3;
    }
}