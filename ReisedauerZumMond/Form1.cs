using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisedauerZumMond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            string geschwindigkeit = txtGeschwindigkeit.Text;
            double Geschwindigkeit = 0;
            if(double.TryParse(geschwindigkeit, out Geschwindigkeit) == false)
            {
                MessageBox.Show("Geben sie eine Gültige geschwindikeit an");
            }
            
            if (radiobtnStunden.Checked == true)
            {
                ReisedauerZumMondBerechnung r = new ReisedauerZumMondBerechnung();
                r.Geschwindigkeit = Geschwindigkeit;
                double result = r.ZeitWegZumMondStunden();
                txtResultat.Text = result.ToString();

            }
            else if(radioButtonTage.Checked == true)
            {
                ReisedauerZumMondBerechnung r = new ReisedauerZumMondBerechnung();
                r.Geschwindigkeit = Geschwindigkeit;
                double result = r.ZeitWegZumMondTage();
                txtResultat.Text = result.ToString();
            }
        }
    }
}
