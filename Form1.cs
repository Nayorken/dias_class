using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diasdevida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Class1 minhaclass = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            minhaclass.recebe = textBox1.Text;
            label1.Text = minhaclass.envia;
        }
    }
}
