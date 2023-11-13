using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registration = new Form1();
            registration.MdiParent = this;
            registration.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculator = new Form2();
            calculator.MdiParent = this;
            calculator.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
