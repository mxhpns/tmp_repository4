using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tmp_repository4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            lbAnswer.Text = $"{MyMath.add(a, b)}";
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            var alg = new Algebra();
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            lbAnswer.Text = $"{alg.Log(b, a)}";
        }
    }
}
