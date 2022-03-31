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
        Dictionary<string, int> iloscBurgerow;

        public Zamowienia(Dictionary<string, int> il)
        {
            InitializeComponent();
            iloscBurgerow = il;
        }

    }
}
