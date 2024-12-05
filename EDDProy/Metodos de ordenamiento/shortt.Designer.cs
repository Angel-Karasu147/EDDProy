namespace EDDemo.Metodos_de_busqueda
{
    partial class frmShort
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
            this.si3 = new System.Windows.Forms.TextBox();
            this.si4 = new System.Windows.Forms.TextBox();
            this.agregar9 = new System.Windows.Forms.Button();
            this.ordenador9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del arreglo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos ordenados";
            // 
            // si3
            // 
            this.si3.Location = new System.Drawing.Point(44, 78);
            this.si3.Multiline = true;
            this.si3.Name = "si3";
            this.si3.Size = new System.Drawing.Size(159, 148);
            this.si3.TabIndex = 3;
            // 
            // si4
            // 
            this.si4.Location = new System.Drawing.Point(44, 271);
            this.si4.Multiline = true;
            this.si4.Name = "si4";
            this.si4.Size = new System.Drawing.Size(159, 112);
            this.si4.TabIndex = 4;
            // 
            // agregar9
            // 
            this.agregar9.Location = new System.Drawing.Point(230, 78);
            this.agregar9.Name = "agregar9";
            this.agregar9.Size = new System.Drawing.Size(75, 23);
            this.agregar9.TabIndex = 5;
            this.agregar9.Text = "Agregar";
            this.agregar9.UseVisualStyleBackColor = true;
            this.agregar9.Click += new System.EventHandler(this.agregar9_Click);
            // 
            // ordenador9
            // 
            this.ordenador9.Location = new System.Drawing.Point(311, 78);
            this.ordenador9.Name = "ordenador9";
            this.ordenador9.Size = new System.Drawing.Size(75, 23);
            this.ordenador9.TabIndex = 6;
            this.ordenador9.Text = "Ordenar";
            this.ordenador9.UseVisualStyleBackColor = true;
            this.ordenador9.Click += new System.EventHandler(this.ordenador9_Click);
            // 
            // frmShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ordenador9);
            this.Controls.Add(this.agregar9);
            this.Controls.Add(this.si4);
            this.Controls.Add(this.si3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmShort";
            this.Text = "ShellShort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox si3;
        private System.Windows.Forms.TextBox si4;
        private System.Windows.Forms.Button agregar9;
        private System.Windows.Forms.Button ordenador9;
    }
}