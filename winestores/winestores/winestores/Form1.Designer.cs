namespace winestores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashDepositsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashDepositsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeDepositsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyBottlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceSetOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingInvoicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.emptyBottlesToolStripMenuItem,
            this.setOffToolStripMenuItem,
            this.outstandingInvoicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.cashDepositsToolStripMenuItem,
            this.expencesToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.eXITToolStripMenuItem2});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // cashDepositsToolStripMenuItem
            // 
            this.cashDepositsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashDepositsToolStripMenuItem1,
            this.chequeDepositsToolStripMenuItem});
            this.cashDepositsToolStripMenuItem.Name = "cashDepositsToolStripMenuItem";
            this.cashDepositsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cashDepositsToolStripMenuItem.Text = "Deposits";
            // 
            // cashDepositsToolStripMenuItem1
            // 
            this.cashDepositsToolStripMenuItem1.Name = "cashDepositsToolStripMenuItem1";
            this.cashDepositsToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.cashDepositsToolStripMenuItem1.Text = "Cash Deposits";
            this.cashDepositsToolStripMenuItem1.Click += new System.EventHandler(this.cashDepositsToolStripMenuItem1_Click);
            // 
            // chequeDepositsToolStripMenuItem
            // 
            this.chequeDepositsToolStripMenuItem.Name = "chequeDepositsToolStripMenuItem";
            this.chequeDepositsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.chequeDepositsToolStripMenuItem.Text = "Cheque Deposits";
            this.chequeDepositsToolStripMenuItem.Click += new System.EventHandler(this.chequeDepositsToolStripMenuItem_Click);
            // 
            // expencesToolStripMenuItem
            // 
            this.expencesToolStripMenuItem.Name = "expencesToolStripMenuItem";
            this.expencesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.expencesToolStripMenuItem.Text = "Expenses";
            this.expencesToolStripMenuItem.Click += new System.EventHandler(this.expencesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Products";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem1.Text = "Banks";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // eXITToolStripMenuItem2
            // 
            this.eXITToolStripMenuItem2.Name = "eXITToolStripMenuItem2";
            this.eXITToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.eXITToolStripMenuItem2.Text = "EXIT";
            this.eXITToolStripMenuItem2.Click += new System.EventHandler(this.eXITToolStripMenuItem2_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.weeklyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem,
            this.annualReportToolStripMenuItem,
            this.stockDetailsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dailyReportToolStripMenuItem.Text = "Daily Report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // weeklyReportToolStripMenuItem
            // 
            this.weeklyReportToolStripMenuItem.Name = "weeklyReportToolStripMenuItem";
            this.weeklyReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.weeklyReportToolStripMenuItem.Text = "Weekly Report";
            this.weeklyReportToolStripMenuItem.Click += new System.EventHandler(this.weeklyReportToolStripMenuItem_Click);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            // 
            // annualReportToolStripMenuItem
            // 
            this.annualReportToolStripMenuItem.Name = "annualReportToolStripMenuItem";
            this.annualReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.annualReportToolStripMenuItem.Text = "Annual Report";
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // emptyBottlesToolStripMenuItem
            // 
            this.emptyBottlesToolStripMenuItem.Name = "emptyBottlesToolStripMenuItem";
            this.emptyBottlesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.emptyBottlesToolStripMenuItem.Text = "Empty Bottles";
            this.emptyBottlesToolStripMenuItem.Click += new System.EventHandler(this.emptyBottlesToolStripMenuItem_Click);
            // 
            // setOffToolStripMenuItem
            // 
            this.setOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceSetOffToolStripMenuItem});
            this.setOffToolStripMenuItem.Name = "setOffToolStripMenuItem";
            this.setOffToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.setOffToolStripMenuItem.Text = "Set Off";
            // 
            // invoiceSetOffToolStripMenuItem
            // 
            this.invoiceSetOffToolStripMenuItem.Name = "invoiceSetOffToolStripMenuItem";
            this.invoiceSetOffToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.invoiceSetOffToolStripMenuItem.Text = "Invoice Set Off";
            this.invoiceSetOffToolStripMenuItem.Click += new System.EventHandler(this.invoiceSetOffToolStripMenuItem_Click);
            // 
            // outstandingInvoicesToolStripMenuItem
            // 
            this.outstandingInvoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outstandingInvoicesToolStripMenuItem1});
            this.outstandingInvoicesToolStripMenuItem.Name = "outstandingInvoicesToolStripMenuItem";
            this.outstandingInvoicesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.outstandingInvoicesToolStripMenuItem.Text = "Outstanding ";
            // 
            // outstandingInvoicesToolStripMenuItem1
            // 
            this.outstandingInvoicesToolStripMenuItem1.Name = "outstandingInvoicesToolStripMenuItem1";
            this.outstandingInvoicesToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.outstandingInvoicesToolStripMenuItem1.Text = "Outstanding Invoices";
            this.outstandingInvoicesToolStripMenuItem1.Click += new System.EventHandler(this.outstandingInvoicesToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 597);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Winestore Automation System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashDepositsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashDepositsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chequeDepositsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyBottlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceSetOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingInvoicesToolStripMenuItem1;
    }
}

