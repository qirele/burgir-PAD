using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace burgir
{

    public partial class Koszyk : Form
    {
        string koszykPrawdziwy;

        public Koszyk(string koszyk)
        {
            InitializeComponent();
            koszykPrawdziwy = koszyk;
            
        }

        private void Koszyk_Load(object sender, EventArgs e)
        {
            lbRachunek.Text = koszykPrawdziwy;
        }
    }
}
