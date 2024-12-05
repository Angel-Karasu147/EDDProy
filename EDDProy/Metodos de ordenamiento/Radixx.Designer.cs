namespace EDDemo.Metodos_de_ordenamiento
{
    partial class Radixx
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
            this.ingresar = new System.Windows.Forms.TextBox();
            this.Desordenados = new System.Windows.Forms.ListBox();
            this.Ordenados = new System.Windows.Forms.ListBox();
            this.agregarbt = new System.Windows.Forms.Button();
            this.ordenarbt = new System.Windows.Forms.Button();
            this.limpiarbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese dato";
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(127, 44);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(100, 20);
            this.ingresar.TabIndex = 1;
            // 
            // Desordenados
            // 
            this.Desordenados.FormattingEnabled = true;
            this.Desordenados.Location = new System.Drawing.Point(27, 124);
            this.Desordenados.Name = "Desordenados";
            this.Desordenados.Size = new System.Drawing.Size(132, 186);
            this.Desordenados.TabIndex = 2;
            // 
            // Ordenados
            // 
            this.Ordenados.FormattingEnabled = true;
            this.Ordenados.Location = new System.Drawing.Point(196, 124);
            this.Ordenados.Name = "Ordenados";
            this.Ordenados.Size = new System.Drawing.Size(391, 186);
            this.Ordenados.TabIndex = 3;
            // 
            // agregarbt
            // 
            this.agregarbt.Location = new System.Drawing.Point(246, 42);
            this.agregarbt.Name = "agregarbt";
            this.agregarbt.Size = new System.Drawing.Size(75, 23);
            this.agregarbt.TabIndex = 4;
            this.agregarbt.Text = "Agregar";
            this.agregarbt.UseVisualStyleBackColor = true;
            this.agregarbt.Click += new System.EventHandler(this.agregarbt_Click);
            // 
            // ordenarbt
            // 
            this.ordenarbt.Location = new System.Drawing.Point(246, 71);
            this.ordenarbt.Name = "ordenarbt";
            this.ordenarbt.Size = new System.Drawing.Size(75, 23);
            this.ordenarbt.TabIndex = 5;
            this.ordenarbt.Text = "Ordenar";
            this.ordenarbt.UseVisualStyleBackColor = true;
            this.ordenarbt.Click += new System.EventHandler(this.ordenarbt_Click);
            // 
            // limpiarbt
            // 
            this.limpiarbt.Location = new System.Drawing.Point(349, 44);
            this.limpiarbt.Name = "limpiarbt";
            this.limpiarbt.Size = new System.Drawing.Size(75, 23);
            this.limpiarbt.TabIndex = 6;
            this.limpiarbt.Text = "Limpiar";
            this.limpiarbt.UseVisualStyleBackColor = true;
            this.limpiarbt.Click += new System.EventHandler(this.limpiarbt_Click);
            // 
            // Radixx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 477);
            this.Controls.Add(this.limpiarbt);
            this.Controls.Add(this.ordenarbt);
            this.Controls.Add(this.agregarbt);
            this.Controls.Add(this.Ordenados);
            this.Controls.Add(this.Desordenados);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.label1);
            this.Name = "Radixx";
            this.Text = "Radix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresar;
        private System.Windows.Forms.ListBox Desordenados;
        private System.Windows.Forms.ListBox Ordenados;
        private System.Windows.Forms.Button agregarbt;
        private System.Windows.Forms.Button ordenarbt;
        private System.Windows.Forms.Button limpiarbt;
    }
}