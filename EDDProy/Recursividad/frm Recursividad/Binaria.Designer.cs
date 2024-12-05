namespace EDDemo.Recursividad
{
    partial class Binaria
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
            this.buscarbt7 = new System.Windows.Forms.Button();
            this.datostx7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buscarbt7
            // 
            this.buscarbt7.Location = new System.Drawing.Point(34, 120);
            this.buscarbt7.Name = "buscarbt7";
            this.buscarbt7.Size = new System.Drawing.Size(75, 23);
            this.buscarbt7.TabIndex = 2;
            this.buscarbt7.Text = "Buscar dato";
            this.buscarbt7.UseVisualStyleBackColor = true;
            this.buscarbt7.Click += new System.EventHandler(this.buscarbt7_Click);
            // 
            // datostx7
            // 
            this.datostx7.Location = new System.Drawing.Point(34, 75);
            this.datostx7.Name = "datostx7";
            this.datostx7.Size = new System.Drawing.Size(431, 20);
            this.datostx7.TabIndex = 3;
            this.datostx7.TextChanged += new System.EventHandler(this.datostx7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos";
            // 
            // tiempo1
            // 
            this.tiempo1.AutoSize = true;
            this.tiempo1.Location = new System.Drawing.Point(31, 163);
            this.tiempo1.Name = "tiempo1";
            this.tiempo1.Size = new System.Drawing.Size(42, 13);
            this.tiempo1.TabIndex = 5;
            this.tiempo1.Text = "Tiempo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "O(lon n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Complejidad";
            // 
            // Binaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tiempo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datostx7);
            this.Controls.Add(this.buscarbt7);
            this.Name = "Binaria";
            this.Text = "Busqueda Binaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buscarbt7;
        private System.Windows.Forms.TextBox datostx7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tiempo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}