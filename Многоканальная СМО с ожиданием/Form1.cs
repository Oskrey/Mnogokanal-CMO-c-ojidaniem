//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Многоканальная_СМО_с_ожиданием
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            int ogr = Convert.ToInt32(textBox1.Text);
//            double lambda = Convert.ToDouble(textBoxTpost.Text);
//            double tobsl = Convert.ToDouble(textBoxTobsl.Text);
//            int n = Convert.ToInt32(textBoxN.Text);
//            double mu = 1 / tobsl;
//            double alpha = lambda / mu;
//            double temp = 0.0;
//            for (int k = 0; k < n; k++)
//            {
//                temp += (Math.Pow(alpha, k) / factorial(k));
//            }
//            List<double> P = new List<double>();

//            double p0 = 1 / (temp + (Math.Pow(alpha, n) / (factorial(n) * (1 - (alpha / n)))));
//            P.Add(p0);
//            for (int k = 1; k <= n; k++)
//            {
//                P.Add(p0 * (Math.Pow(alpha, k) / factorial(k)));
//            }
//            for (int k = n + 1; k <= ogr; k++)
//            {
//                P.Add(p0 * (Math.Pow(alpha, k) / (factorial(n) * Math.Pow(n, (k - n)))));
//            }

//            for (int i = 0; i <= ogr; i++)
//            {
//                listBox1.Items.Add("P" + i + " = " + P[i].ToString());
//            }

//            double lq = ((double)P[4]) * ((alpha * n) / (Math.Pow(n - alpha, 2)));

//            double wq = lq / lambda;
//            textBox2.Text = wq.ToString();
//        }
//        double factorial(double nn)
//        {
//            double res = 1;
//            for (int i = 2; i <= nn; i++)
//            {
//                res *= i;
//            }
//            return res;
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многоканальная_СМО_с_ожиданием
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBoxM.Text);
            double tpost = Convert.ToDouble(textBoxTpost.Text);
            double tobsl = Convert.ToDouble(textBoxTobsl.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            double lambda = 1 / tpost;
            double mu = 1 / tobsl;
            double alpha = lambda / mu;
            double temp = 0.0;
            for (int k = 0; k <= m; k++)
            {
                if (k <= n) temp += ( (factorial(m) * Math.Pow(alpha, k)) / (factorial(k) * factorial(m - k)));
                else temp += ( (factorial(m) * Math.Pow(alpha, k)) / (factorial(n) * Math.Pow(n, k - n) * factorial(m - k)) );
            }
            double p0 = 1 / temp;
            List<double> P = new List<double>();
            P.Add(p0);
            for (int k = 1; k <= n; k++)
            {
                P.Add((factorial(m) * Math.Pow(alpha, k)) / (factorial(k) * factorial(m - k)));
            }
            for (int k = n+1; k <= m; k++)
            {
                P.Add((factorial(m) * Math.Pow(alpha, k)) / (factorial(n) * Math.Pow(n, k - n) * factorial(m - k)));
            }
            double ls = 0;
            for (int k = n; k <= m; k++)
            {
                ls += P[k]*k;
            }
            textBoxLs.Text = ls.ToString();
            double lq = 0;
            for(int k = n; k<=m; k++)
            {
                lq+= (P[k]*(k-n)); 
            }
            textBoxLq.Text = lq.ToString();
            double kf = 1-(ls/m);
            textBoxK.Text = kf.ToString();
            for (int i = 0; i < P.Count; i++)
            {
                listBox1.Items.Add("P" + i + " = " + P[i].ToString());
            }
            double kisp = 1 - ls / m;
            double tq = 1 / lambda * ((1 - kisp) / kisp) - 1 / mu;
            textBoxTq.Text = tq.ToString();
            textBoxPn3.Text = P[n+1].ToString();
        }
        double factorial(double x)
        {
            double res = 1;
            for (int i = 2; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }
        

    }
}