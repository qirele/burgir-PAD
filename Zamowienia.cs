using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Zamowienia_Load(object sender, EventArgs e)
        {
            
            string filePath = Application.StartupPath + @"baza_zamowienia.txt";
            
            var brh = File.ReadAllText(filePath);
            lbZamowienia.Text = brh;

        }
    }
}
