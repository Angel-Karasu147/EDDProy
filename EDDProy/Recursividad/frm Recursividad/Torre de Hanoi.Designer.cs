namespace EDDemo.Recursividad.frm_Recursividad
{
    partial class Hanoi
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
            this.si3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hacer1 = new System.Windows.Forms.Button();
            this.hola1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // si3
            // 
            this.si3.Location = new System.Drawing.Point(109, 34);
            this.si3.Name = "si3";
            this.si3.Size = new System.Drawing.Size(100, 20);
            this.si3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discos";
            // 
            // hacer1
            // 
            this.hacer1.Location = new System.Drawing.Point(109, 69);
            this.hacer1.Name = "hacer1";
            this.hacer1.Size = new System.Drawing.Size(100, 25);
            this.hacer1.TabIndex = 6;
            this.hacer1.Text = "hacer torre";
            this.hacer1.UseVisualStyleBackColor = true;
            this.hacer1.Click += new System.EventHandler(this.hacer1_Click);
            // 
            // hola1
            // 
            this.hola1.Location = new System.Drawing.Point(12, 109);
            this.hola1.Multiline = true;
            this.hola1.Name = "hola1";
            this.hola1.Size = new System.Drawing.Size(367, 283);
            this.hola1.TabIndex = 7;
            this.hola1.TextChanged += new System.EventHandler(this.hola1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Complejidad: O(2^n)";
            // 
            // Hanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hola1);
            this.Controls.Add(this.hacer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.si3);
            this.Name = "Hanoi";
            this.Text = "Torre de Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox si3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hacer1;
        private System.Windows.Forms.TextBox hola1;
        private System.Windows.Forms.Label label2;
    }
}