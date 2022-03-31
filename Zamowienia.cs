using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace burgir
{
    public partial class Zamowienia : Form
    {
        string[] zamowienie;

        public Zamowienia(string[] zamowienie_)
        {
            InitializeComponent();
            zamowienie = zamowienie_;
        }

    }
}
