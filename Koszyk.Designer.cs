
namespace burgir
{
    partial class Koszyk
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
            this.lbRachunek = new System.Windows.Forms.Label();
            this.cmbSosy = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLacznie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromoKod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numProba = new System.Windows.Forms.NumericUpDown();
            this.btnZgadnij = new System.Windows.Forms.Button();
            this.lbMaloDuzo = new System.Windows.Forms.Label();
            this.lbProby = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZamawiam = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProba)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRachunek
            // 
            this.lbRachunek.AutoSize = true;
            this.lbRachunek.Location = new System.Drawing.Point(3, 0);
            this.lbRachunek.Name = "lbRachunek";
            this.lbRachunek.Size = new System.Drawing.Size(199, 15);
            this.lbRachunek.TabIndex = 0;
            this.lbRachunek.Text = "lista dodanych do koszyka burgerow";
            // 
            // cmbSosy
            // 
            this.cmbSosy.FormattingEnabled = true;
            this.cmbSosy.Items.AddRange(new object[] {
            "Sos amerykański",
            "Sos słodko-kwaśny",
            "Sos barbecue",
            "Sos musztardowy",
            "Sos czosnkowy",
            "Sos śmietankowy"});
            this.cmbSosy.Location = new System.Drawing.Point(12, 333);
            this.cmbSosy.Name = "cmbSosy";
            this.cmbSosy.Size = new System.Drawing.Size(121, 23);
            this.cmbSosy.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lbRachunek);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 177);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz sos";
            // 
            // lbLacznie
            // 
            this.lbLacznie.AutoSize = true;
            this.lbLacznie.Location = new System.Drawing.Point(15, 400);
            this.lbLacznie.Name = "lbLacznie";
            this.lbLacznie.Size = new System.Drawing.Size(52, 15);
            this.lbLacznie.TabIndex = 4;
            this.lbLacznie.Text = "Łącznie: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koszyk formularz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "KOD:";
            // 
            // txtPromoKod
            // 
            this.txtPromoKod.Location = new System.Drawing.Point(54, 476);
            this.txtPromoKod.Name = "txtPromoKod";
            this.txtPromoKod.Size = new System.Drawing.Size(206, 23);
            this.txtPromoKod.TabIndex = 6;
            this.txtPromoKod.TextChanged += new System.EventHandler(this.txtPromoKod_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.numProba);
            this.groupBox1.Controls.Add(this.btnZgadnij);
            this.groupBox1.Controls.Add(this.lbMaloDuzo);
            this.groupBox1.Controls.Add(this.lbProby);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(480, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // numProba
            // 
            this.numProba.Location = new System.Drawing.Point(105, 162);
            this.numProba.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numProba.Name = "numProba";
            this.numProba.Size = new System.Drawing.Size(180, 23);
            this.numProba.TabIndex = 5;
            this.numProba.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnZgadnij
            // 
            this.btnZgadnij.Location = new System.Drawing.Point(105, 191);
            this.btnZgadnij.Name = "btnZgadnij";
            this.btnZgadnij.Size = new System.Drawing.Size(180, 44);
            this.btnZgadnij.TabIndex = 4;
            this.btnZgadnij.Text = "Zgadnij!";
            this.btnZgadnij.UseVisualStyleBackColor = true;
            this.btnZgadnij.Click += new System.EventHandler(this.btnZgadnij_Click);
            // 
            // lbMaloDuzo
            // 
            this.lbMaloDuzo.AutoSize = true;
            this.lbMaloDuzo.Location = new System.Drawing.Point(127, 127);
            this.lbMaloDuzo.Name = "lbMaloDuzo";
            this.lbMaloDuzo.Size = new System.Drawing.Size(91, 15);
            this.lbMaloDuzo.TabIndex = 2;
            this.lbMaloDuzo.Text = "za malo za duzo";
            // 
            // lbProby
            // 
            this.lbProby.AutoSize = true;
            this.lbProby.Location = new System.Drawing.Point(127, 100);
            this.lbProby.Name = "lbProby";
            this.lbProby.Size = new System.Drawing.Size(71, 15);
            this.lbProby.TabIndex = 1;
            this.lbProby.Text = "Masz 5 prób";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zgadnij liczbe od 1 do 20 i wygraj promocyjny kod na zniżkę";
            // 
            // btnZamawiam
            // 
            this.btnZamawiam.Location = new System.Drawing.Point(15, 532);
            this.btnZamawiam.Name = "btnZamawiam";
            this.btnZamawiam.Size = new System.Drawing.Size(350, 132);
            this.btnZamawiam.TabIndex = 8;
            this.btnZamawiam.Text = "Zamawiam i płacę";
            this.btnZamawiam.UseVisualStyleBackColor = true;
            this.btnZamawiam.Click += new System.EventHandler(this.btnZamawiam_Click);
            // 
            // Koszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.btnZamawiam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPromoKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLacznie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbSosy);
            this.Name = "Koszyk";
            this.Text = "Koszyk formularz";
            this.Load += new System.EventHandler(this.Koszyk_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRachunek;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.ComboBox cmbSosy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLacznie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPromoKod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZgadnij;
        private System.Windows.Forms.Label lbMaloDuzo;
        private System.Windows.Forms.Label lbProby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZamawiam;
        private System.Windows.Forms.NumericUpDown numProba;
    }
}