using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winestores
{
    public partial class outinvoice : Form
    {

        private Form1 f1;
        private ToolStripMenuItem tool1;

        public outinvoice()
        {
            InitializeComponent();
        }
        public outinvoice(Form1 p1)
        {
            f1 = p1;
            InitializeComponent();
        }
        public outinvoice(Form1 f1 , ToolStripMenuItem t1)
        {
            tool1 = t1;
            InitializeComponent();
        }

        private void outinvoice_Load(object sender, EventArgs e)
        {

        }

        private void outinvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }
    }
}
