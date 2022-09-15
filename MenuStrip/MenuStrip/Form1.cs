using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        private const string V = "Lorem Ipsum";

        public Form1()
        {
            InitializeComponent();
        }

        private void maxMareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private ListBox GetListBox1()
        {
            return listBox1;
        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e, int v, int v1, int _, ListBox listBox1, int v, int v)
        {
            _ = _ = listBox1.Items.Add("MaxMare");
            richTextBox1.Text = V;
            listBox2.Items.Add(toolStripComboBox1.Text);


        }
    }
}
