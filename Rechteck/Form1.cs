using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechteckForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAusrechnen_Click(object sender, EventArgs e)
        {
            string height = txtHoehe.Text;
            double heightCalculation = 0;

            if(double.TryParse(height, out heightCalculation) == false)
            {
                MessageBox.Show("Sie haben keine gültige Zahl eingegeben");
            }

            string width = txtBreite.Text;
            double widthCalculation = 0;

            if (double.TryParse(width, out widthCalculation) == false)
            {
                MessageBox.Show("Sie haben keine gültige Zahl eingegeben");
            }

            Rechteck r = new Rechteck();
            r.Height = heightCalculation;
            r.Width = widthCalculation;
            double result = r.GetArea();
            txtFlaeche.Text = result.ToString();
        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
