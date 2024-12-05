namespace EDDemo.Recursividad.frm_Recursividad
{
    partial class Factorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.ingresarbt8 = new System.Windows.Forms.TextBox();
            this.ingresarbt9 = new System.Windows.Forms.TextBox();
            this.factorialbt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // ingresarbt8
            // 
            this.ingresarbt8.Location = new System.Drawing.Point(119, 66);
            this.ingresarbt8.Name = "ingresarbt8";
            this.ingresarbt8.Size = new System.Drawing.Size(100, 20);
            this.ingresarbt8.TabIndex = 2;
            // 
            // ingresarbt9
            // 
            this.ingresarbt9.Location = new System.Drawing.Point(119, 120);
            this.ingresarbt9.Name = "ingresarbt9";
            this.ingresarbt9.Size = new System.Drawing.Size(100, 20);
            this.ingresarbt9.TabIndex = 3;
            // 
            // factorialbt
            // 
            this.factorialbt.Location = new System.Drawing.Point(62, 168);
            this.factorialbt.Name = "factorialbt";
            this.factorialbt.Size = new System.Drawing.Size(75, 23);
            this.factorialbt.TabIndex = 4;
            this.factorialbt.Text = "Calcular";
            this.factorialbt.UseVisualStyleBackColor = true;
            this.factorialbt.Click += new System.EventHandler(this.factorialbt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complejidad: O(n)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.factorialbt);
            this.Controls.Add(this.ingresarbt9);
            this.Controls.Add(this.ingresarbt8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Factorial";
            this.Text = "Calcular factorial de un numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ingresarbt8;
        private System.Windows.Forms.TextBox ingresarbt9;
        private System.Windows.Forms.Button factorialbt;
        private System.Windows.Forms.Label label3;
    }
}