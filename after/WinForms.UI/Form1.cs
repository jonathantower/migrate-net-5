using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.UI
{
    public partial class Form1 : Form
    {
        private Demo.ClassLibrary.Math _math = new Demo.ClassLibrary.Math();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(txtNumber1.Text);
            var y = Convert.ToInt32(txtNumber2.Text);
            var z = _math.Add(x, y);
            MessageBox.Show(z.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
