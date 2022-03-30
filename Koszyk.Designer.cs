
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
            this.SuspendLayout();
            // 
            // lbRachunek
            // 
            this.lbRachunek.AutoSize = true;
            this.lbRachunek.Location = new System.Drawing.Point(71, 476);
            this.lbRachunek.Name = "lbRachunek";
            this.lbRachunek.Size = new System.Drawing.Size(27, 15);
            this.lbRachunek.TabIndex = 0;
            this.lbRachunek.Text = "Cos";
            // 
            // Koszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.lbRachunek);
            this.Name = "Koszyk";
            this.Text = "Koszyk";
            this.Load += new System.EventHandler(this.Koszyk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRachunek;
        private System.Windows.Forms.Label lbLista;
    }
}