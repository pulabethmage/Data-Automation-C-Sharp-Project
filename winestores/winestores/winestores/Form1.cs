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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Sales f1 = new Add_Sales(this,salesToolStripMenuItem);
            f1.MdiParent = this;
            f1.Show();

            salesToolStripMenuItem.Visible = false;

        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice f2 = new Invoice(this,invoiceToolStripMenuItem);
            f2.MdiParent = this;
            f2.Show();

            invoiceToolStripMenuItem.Visible = false;
        }

        private void cashDepositsToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            Deposits f3 = new Deposits(this,cashDepositsToolStripMenuItem1);
            f3.MdiParent = this;
            f3.Show();

            cashDepositsToolStripMenuItem1.Visible = false;

           

        }

        

        private void chequeDepositsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheqDeposits f4 = new CheqDeposits(this,chequeDepositsToolStripMenuItem);
            f4.MdiParent = this;
            f4.Show();

            chequeDepositsToolStripMenuItem.Visible = false;

           
        }

        private void expencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expences f5 = new Expences(this, expencesToolStripMenuItem);
            f5.MdiParent = this;
            f5.Show();

            expencesToolStripMenuItem.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product f6 = new Product(this, exitToolStripMenuItem);
            f6.MdiParent = this;
            f6.Show();

            exitToolStripMenuItem.Visible = false;

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Banks f7 = new Banks(this, exitToolStripMenuItem1);
            f7.MdiParent = this;
            f7.Show();

            exitToolStripMenuItem1.Visible = false;
        }

        private void eXITToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 r1 = new Report1();
            r1.MdiParent = this;
            r1.Show();
        }

        private void weeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateRange dr = new DateRange();
            dr.MdiParent = this;
            dr.Show();
        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details sd = new Stock_Details();
            sd.MdiParent = this;
            sd.Show();
        }

        private void emptyBottlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empty_Bottles mpty = new Empty_Bottles(this, emptyBottlesToolStripMenuItem);
            mpty.MdiParent = this;
            mpty.Show();
            emptyBottlesToolStripMenuItem.Visible = false;

        }

        private void invoiceSetOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice_Set_Off invstoff = new Invoice_Set_Off(this, invoiceSetOffToolStripMenuItem);
            invstoff.MdiParent = this;
            invstoff.Show();
            invoiceSetOffToolStripMenuItem.Visible = false;

        }

        private void outstandingInvoicesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outinvoice oi = new outinvoice(this , outstandingInvoicesToolStripMenuItem1);
            oi.MdiParent = this;
            oi.Show();
            outstandingInvoicesToolStripMenuItem1.Visible = false;
        }

       

       
    }
}
