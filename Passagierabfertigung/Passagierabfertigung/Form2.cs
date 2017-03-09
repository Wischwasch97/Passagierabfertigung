using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Passagierabfertigung
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buchen_Click(object sender, EventArgs e)
        {
            Form Buchen = new Buchen();
            Buchen.Show();
        }

        private void meinefluege_Click(object sender, EventArgs e)
        {
            Form MeineFluege = new MeineFluege();
            MeineFluege.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
