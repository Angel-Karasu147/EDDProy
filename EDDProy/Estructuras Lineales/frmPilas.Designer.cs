
namespace EDDemo
{
    partial class frmPilas
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
            this.Insertartx = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Label();
            this.si = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insertartx
            // 
            this.Insertartx.Location = new System.Drawing.Point(86, 38);
            this.Insertartx.Margin = new System.Windows.Forms.Padding(2);
            this.Insertartx.Multiline = true;
            this.Insertartx.Name = "Insertartx";
            this.Insertartx.Size = new System.Drawing.Size(72, 27);
            this.Insertartx.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(184, 38);
            this.btnPush.Margin = new System.Windows.Forms.Padding(2);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(42, 21);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregar
            // 
            this.agregar.AutoSize = true;
            this.agregar.Location = new System.Drawing.Point(96, 94);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(0, 13);
            this.agregar.TabIndex = 3;
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Location = new System.Drawing.Point(83, 107);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(0, 13);
            this.si.TabIndex = 4;
            this.si.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 244);
            this.Controls.Add(this.si);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.Insertartx);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Insertartx;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label agregar;
        private System.Windows.Forms.Label si;
    }
}