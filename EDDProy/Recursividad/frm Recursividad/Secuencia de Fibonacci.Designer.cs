namespace EDDemo.Recursividad.frm_Recursividad
{
    partial class Fibonacci
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
            this.components = new System.ComponentModel.Container();
            this.fibo1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fibo3 = new System.Windows.Forms.TextBox();
            this.si2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fibo1
            // 
            this.fibo1.Location = new System.Drawing.Point(67, 63);
            this.fibo1.Name = "fibo1";
            this.fibo1.Size = new System.Drawing.Size(100, 20);
            this.fibo1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fibo3
            // 
            this.fibo3.Location = new System.Drawing.Point(12, 170);
            this.fibo3.Name = "fibo3";
            this.fibo3.Size = new System.Drawing.Size(207, 20);
            this.fibo3.TabIndex = 2;
            // 
            // si2
            // 
            this.si2.Location = new System.Drawing.Point(76, 110);
            this.si2.Name = "si2";
            this.si2.Size = new System.Drawing.Size(75, 23);
            this.si2.TabIndex = 3;
            this.si2.Text = "Fibonacci";
            this.si2.UseVisualStyleBackColor = true;
            this.si2.Click += new System.EventHandler(this.si2_Click);
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.si2);
            this.Controls.Add(this.fibo3);
            this.Controls.Add(this.fibo1);
            this.Name = "Fibonacci";
            this.Text = "Secuencia de Fibonacci";
            this.Load += new System.EventHandler(this.Fibonacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fibo1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox fibo3;
        private System.Windows.Forms.Button si2;
    }
}