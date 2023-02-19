using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int D = (Int32.Parse(txtA.Text) * Int32.Parse(txtA.Text)) +
                (Int32.Parse(txtB.Text) * Int32.Parse(txtB.Text));

            double C = Math.Sqrt(D);

            txtC.Text = C.ToString("0.000");

            Double P = Int32.Parse(txtA.Text) + Int32.Parse(txtB.Text) + C;

            txtP.Text = P.ToString("0.000");
        }
    }
}
