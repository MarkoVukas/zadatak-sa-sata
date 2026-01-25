namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnstatistika = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.Location = new System.Drawing.Point(44, 12);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(135, 43);
            this.btnUnosKnjige.TabIndex = 0;
            this.btnUnosKnjige.Text = "Unos knjige";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(44, 75);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(135, 46);
            this.btnPrikaz.TabIndex = 1;
            this.btnPrikaz.Text = "Prikaz knjiga";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            // 
            // btnstatistika
            // 
            this.btnstatistika.Location = new System.Drawing.Point(44, 136);
            this.btnstatistika.Name = "btnstatistika";
            this.btnstatistika.Size = new System.Drawing.Size(135, 43);
            this.btnstatistika.TabIndex = 2;
            this.btnstatistika.Text = "Statistika žanrova";
            this.btnstatistika.UseVisualStyleBackColor = true;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(44, 194);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(135, 43);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnstatistika);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.btnUnosKnjige);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnosKnjige;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnstatistika;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

