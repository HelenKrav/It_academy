using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademyFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExitStripButton1.Click += ExitStripButton1_Click;
        }


        private void ExitStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
