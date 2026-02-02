namespace WindowsFormsApp1
{
    partial class Prikaz_knjiga
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
            this.labelNaslovAutor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.lstKnjige = new System.Windows.Forms.ListBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNaslovAutor
            // 
            this.labelNaslovAutor.AutoSize = true;
            this.labelNaslovAutor.Location = new System.Drawing.Point(38, 34);
            this.labelNaslovAutor.Name = "labelNaslovAutor";
            this.labelNaslovAutor.Size = new System.Drawing.Size(121, 13);
            this.labelNaslovAutor.TabIndex = 0;
            this.labelNaslovAutor.Text = " Upišite autora ili naslov:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(309, 34);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(421, 34);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            // 
            // lstKnjige
            // 
            this.lstKnjige.FormattingEnabled = true;
            this.lstKnjige.Location = new System.Drawing.Point(41, 103);
            this.lstKnjige.Name = "lstKnjige";
            this.lstKnjige.Size = new System.Drawing.Size(387, 121);
            this.lstKnjige.TabIndex = 4;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(84, 260);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // Prikaz_knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.lstKnjige);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNaslovAutor);
            this.Name = "Prikaz_knjiga";
            this.Text = "Pregled knjiga";
            this.Load += new System.EventHandler(this.Prikaz_knjiga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslovAutor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ListBox lstKnjige;
        private System.Windows.Forms.Button btnZatvori;
    }
}