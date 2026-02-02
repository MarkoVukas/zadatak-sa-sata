namespace WindowsFormsApp1
{
    partial class Unos_knjige
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelZanr = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelGodinaIzdavanja = new System.Windows.Forms.Label();
            this.groupBoxPodatciOKnjizi = new System.Windows.Forms.GroupBox();
            this.btnSpremi2 = new System.Windows.Forms.Button();
            this.btnosvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxPodatciOKnjizi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(107, 33);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(170, 20);
            this.txtNaslov.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(107, 66);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(152, 20);
            this.txtAutor.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(19, 36);
            this.labelNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(43, 13);
            this.labelNaslov.TabIndex = 3;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(19, 62);
            this.labelAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 4;
            this.labelAutor.Text = "Autor:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 99);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 57);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Dostupna za posudbu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 33);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Broj stranica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(362, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(164, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatni podatci";
            // 
            // labelZanr
            // 
            this.labelZanr.AutoSize = true;
            this.labelZanr.Location = new System.Drawing.Point(24, 131);
            this.labelZanr.Name = "labelZanr";
            this.labelZanr.Size = new System.Drawing.Size(38, 13);
            this.labelZanr.TabIndex = 10;
            this.labelZanr.Text = "Žanr : ";
            this.labelZanr.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // labelGodinaIzdavanja
            // 
            this.labelGodinaIzdavanja.AutoSize = true;
            this.labelGodinaIzdavanja.Location = new System.Drawing.Point(6, 99);
            this.labelGodinaIzdavanja.Name = "labelGodinaIzdavanja";
            this.labelGodinaIzdavanja.Size = new System.Drawing.Size(89, 13);
            this.labelGodinaIzdavanja.TabIndex = 14;
            this.labelGodinaIzdavanja.Text = "Godina izdavanja";
            // 
            // groupBoxPodatciOKnjizi
            // 
            this.groupBoxPodatciOKnjizi.Controls.Add(this.txtNaslov);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.labelGodinaIzdavanja);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.comboBox2);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.labelNaslov);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.labelAutor);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.labelZanr);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.txtAutor);
            this.groupBoxPodatciOKnjizi.Controls.Add(this.dateTimePicker1);
            this.groupBoxPodatciOKnjizi.Location = new System.Drawing.Point(17, 12);
            this.groupBoxPodatciOKnjizi.Name = "groupBoxPodatciOKnjizi";
            this.groupBoxPodatciOKnjizi.Size = new System.Drawing.Size(287, 159);
            this.groupBoxPodatciOKnjizi.TabIndex = 15;
            this.groupBoxPodatciOKnjizi.TabStop = false;
            this.groupBoxPodatciOKnjizi.Text = "Podatci o knjizi";
            // 
            // btnSpremi2
            // 
            this.btnSpremi2.Location = new System.Drawing.Point(37, 223);
            this.btnSpremi2.Name = "btnSpremi2";
            this.btnSpremi2.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi2.TabIndex = 16;
            this.btnSpremi2.Text = "Spremi";
            this.btnSpremi2.UseVisualStyleBackColor = true;
            // 
            // btnosvjezi
            // 
            this.btnosvjezi.Location = new System.Drawing.Point(162, 223);
            this.btnosvjezi.Name = "btnosvjezi";
            this.btnosvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnosvjezi.TabIndex = 17;
            this.btnosvjezi.Text = "Osvježi";
            this.btnosvjezi.UseVisualStyleBackColor = true;
            // 
            // Unos_knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnosvjezi);
            this.Controls.Add(this.btnSpremi2);
            this.Controls.Add(this.groupBoxPodatciOKnjizi);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Unos_knjige";
            this.Text = "Unos_knjige";
            this.Load += new System.EventHandler(this.Unos_knjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPodatciOKnjizi.ResumeLayout(false);
            this.groupBoxPodatciOKnjizi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelZanr;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelGodinaIzdavanja;
        private System.Windows.Forms.GroupBox groupBoxPodatciOKnjizi;
        private System.Windows.Forms.Button btnSpremi2;
        private System.Windows.Forms.Button btnosvjezi;
    }
}