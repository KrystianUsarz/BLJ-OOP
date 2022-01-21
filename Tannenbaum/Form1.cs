using System;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Tanne t = new Tanne(Convert.ToInt32(txtHoeheBaumkrone.Text)
                , Convert.ToInt32(txtStammbreite.Text)
                , Convert.ToInt32(txtStammhoehe.Text));

            t.Zeichne();
            txtTanne.Text = t.Resultat;
        }

        private void textBoxKronenHoehe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // nur Zahlen und Backspace-Taste zulassen 
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b'))
                e.Handled = true;
        }
    }
}
