using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace burgir
{
    public partial class Paragon : Form
    {
        int nrParagonu;
        public Paragon(int nr)
        {
            InitializeComponent();
            nrParagonu = nr;
        }

        private void Paragon_Load(object sender, EventArgs e)
        {
            lbDajTo.Text = $"{lbDajTo.Text} {nrParagonu.ToString()}";
            lbParagon2.Text = $"NR: {nrParagonu}";
        }
    }
}
