using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sikidomok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            decimal a = numA.Value;
            decimal b = numB.Value;
            decimal K = 2 * a + 2 * b;
            decimal T = a * b;
            numK.Value = K;
            numT.Value = T;
        }

        private void btnKorSzamol_Click(object sender, EventArgs e)
        {
            decimal r = numR.Value;
            decimal K = 2 * r * (decimal)Math.PI;
            decimal T = r * r * (decimal)Math.PI;
            numKorK.Value = K;
            numKorT.Value = T;
        }

        private void btnNegyzetSzamol_Click(object sender, EventArgs e)
        {
            decimal a = numNegyzetA.Value;
            decimal K = 4 * a;
            decimal T = a * a;
            numNegyzetK.Value = K;
            numNegyzetT.Value = T;
        }

        private void btnHszSzamol_Click(object sender, EventArgs e)
        {
            decimal a = numHszA.Value;
            decimal b = numHszB.Value;
            decimal c = numHszC.Value;
            decimal K = a + b + c;
            decimal s = K / 2;
            decimal T = (decimal)Math.Sqrt((double)(s * (s - a) * (s - b) * (s - c)));
            numHszK.Value = K;
            numHszT.Value = T;
        }
    }
}
