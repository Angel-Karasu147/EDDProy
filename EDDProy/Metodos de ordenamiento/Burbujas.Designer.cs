namespace EDDemo.Metodos_de_ordenamiento
{
    partial class Burbujas
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
            this.agregar10 = new System.Windows.Forms.TextBox();
            this.agregarbt10 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.ListBox();
            this.ordenar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregar10
            // 
            this.agregar10.Location = new System.Drawing.Point(171, 64);
            this.agregar10.Name = "agregar10";
            this.agregar10.Size = new System.Drawing.Size(100, 20);
            this.agregar10.TabIndex = 0;
            this.agregar10.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // agregarbt10
            // 
            this.agregarbt10.Location = new System.Drawing.Point(69, 61);
            this.agregarbt10.Name = "agregarbt10";
            this.agregarbt10.Size = new System.Drawing.Size(75, 23);
            this.agregarbt10.TabIndex = 1;
            this.agregarbt10.Text = "Agregar";
            this.agregarbt10.UseVisualStyleBackColor = true;
            this.agregarbt10.Click += new System.EventHandler(this.button1_Click);
            // 
            // box2
            // 
            this.box2.FormattingEnabled = true;
            this.box2.Location = new System.Drawing.Point(69, 115);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(120, 160);
            this.box2.TabIndex = 2;
            this.box2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ordenar2
            // 
            this.ordenar2.Location = new System.Drawing.Point(243, 130);
            this.ordenar2.Name = "ordenar2";
            this.ordenar2.Size = new System.Drawing.Size(75, 23);
            this.ordenar2.TabIndex = 3;
            this.ordenar2.Text = "Ordenar";
            this.ordenar2.UseVisualStyleBackColor = true;
            this.ordenar2.Click += new System.EventHandler(this.ordenar2_Click);
            // 
            // Burbujas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 431);
            this.Controls.Add(this.ordenar2);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.agregarbt10);
            this.Controls.Add(this.agregar10);
            this.Name = "Burbujas";
            this.Text = "Burbujas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox agregar10;
        private System.Windows.Forms.Button agregarbt10;
        private System.Windows.Forms.ListBox box2;
        private System.Windows.Forms.Button ordenar2;
    }
}