namespace winestores
{
    partial class Invoice_Set_Off
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbinvoice = new System.Windows.Forms.ComboBox();
            this.cmbmanufact = new System.Windows.Forms.ComboBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblmanfact = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdocheque = new System.Windows.Forms.RadioButton();
            this.rdocash = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblamt = new System.Windows.Forms.Label();
            this.lblaccountno = new System.Windows.Forms.Label();
            this.lblbank = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsubmit2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cmbbxchkbank = new System.Windows.Forms.ComboBox();
            this.iblamt2 = new System.Windows.Forms.Label();
            this.lblchqno = new System.Windows.Forms.Label();
            this.lblaccno2 = new System.Windows.Forms.Label();
            this.lblbname2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbinvoice);
            this.groupBox1.Controls.Add(this.cmbmanufact);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblInvoice);
            this.groupBox1.Controls.Add(this.lblmanfact);
            this.groupBox1.Location = new System.Drawing.Point(53, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Set Off";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 10;
            //this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Balance Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbinvoice
            // 
            this.cmbinvoice.FormattingEnabled = true;
            this.cmbinvoice.Location = new System.Drawing.Point(153, 55);
            this.cmbinvoice.Name = "cmbinvoice";
            this.cmbinvoice.Size = new System.Drawing.Size(247, 21);
            this.cmbinvoice.TabIndex = 4;
            this.cmbinvoice.SelectedIndexChanged += new System.EventHandler(this.cmbinvoice_SelectedIndexChanged);
            this.cmbinvoice.Click += new System.EventHandler(this.cmbinvoice_Click);
            // 
            // cmbmanufact
            // 
            this.cmbmanufact.FormattingEnabled = true;
            this.cmbmanufact.Location = new System.Drawing.Point(153, 14);
            this.cmbmanufact.Name = "cmbmanufact";
            this.cmbmanufact.Size = new System.Drawing.Size(247, 21);
            this.cmbmanufact.TabIndex = 3;
            this.cmbmanufact.SelectedIndexChanged += new System.EventHandler(this.cmbmanufact_SelectedIndexChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(6, 101);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(6, 63);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(59, 13);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "Invoice No";
            // 
            // lblmanfact
            // 
            this.lblmanfact.AutoSize = true;
            this.lblmanfact.Location = new System.Drawing.Point(6, 23);
            this.lblmanfact.Name = "lblmanfact";
            this.lblmanfact.Size = new System.Drawing.Size(70, 13);
            this.lblmanfact.TabIndex = 0;
            this.lblmanfact.Text = "Manufacturer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdocheque);
            this.groupBox2.Controls.Add(this.rdocash);
            this.groupBox2.Location = new System.Drawing.Point(53, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Type";
            // 
            // rdocheque
            // 
            this.rdocheque.AutoSize = true;
            this.rdocheque.Location = new System.Drawing.Point(237, 28);
            this.rdocheque.Name = "rdocheque";
            this.rdocheque.Size = new System.Drawing.Size(62, 17);
            this.rdocheque.TabIndex = 1;
            this.rdocheque.TabStop = true;
            this.rdocheque.Text = "Cheque";
            this.rdocheque.UseVisualStyleBackColor = true;
            this.rdocheque.CheckedChanged += new System.EventHandler(this.rdocheque_CheckedChanged);
            // 
            // rdocash
            // 
            this.rdocash.AutoSize = true;
            this.rdocash.Location = new System.Drawing.Point(33, 28);
            this.rdocash.Name = "rdocash";
            this.rdocash.Size = new System.Drawing.Size(49, 17);
            this.rdocash.TabIndex = 0;
            this.rdocash.TabStop = true;
            this.rdocash.Text = "Cash";
            this.rdocash.UseVisualStyleBackColor = true;
            this.rdocash.CheckedChanged += new System.EventHandler(this.rdocash_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnsubmit);
            this.groupBox3.Controls.Add(this.lblamt);
            this.groupBox3.Controls.Add(this.lblaccountno);
            this.groupBox3.Controls.Add(this.lblbank);
            this.groupBox3.Location = new System.Drawing.Point(53, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 198);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cash Payment";
            this.groupBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(153, 169);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblamt
            // 
            this.lblamt.AutoSize = true;
            this.lblamt.Location = new System.Drawing.Point(6, 127);
            this.lblamt.Name = "lblamt";
            this.lblamt.Size = new System.Drawing.Size(43, 13);
            this.lblamt.TabIndex = 2;
            this.lblamt.Text = "Amount";
            // 
            // lblaccountno
            // 
            this.lblaccountno.AutoSize = true;
            this.lblaccountno.Location = new System.Drawing.Point(6, 86);
            this.lblaccountno.Name = "lblaccountno";
            this.lblaccountno.Size = new System.Drawing.Size(64, 13);
            this.lblaccountno.TabIndex = 1;
            this.lblaccountno.Text = "Account No";
            // 
            // lblbank
            // 
            this.lblbank.AutoSize = true;
            this.lblbank.Location = new System.Drawing.Point(6, 40);
            this.lblbank.Name = "lblbank";
            this.lblbank.Size = new System.Drawing.Size(32, 13);
            this.lblbank.TabIndex = 0;
            this.lblbank.Text = "Bank";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnsubmit2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.comboBox5);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.cmbbxchkbank);
            this.groupBox4.Controls.Add(this.iblamt2);
            this.groupBox4.Controls.Add(this.lblchqno);
            this.groupBox4.Controls.Add(this.lblaccno2);
            this.groupBox4.Controls.Add(this.lblbname2);
            this.groupBox4.Location = new System.Drawing.Point(53, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 247);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cheque Payments";
            this.groupBox4.Visible = false;
            // 
            // btnsubmit2
            // 
            this.btnsubmit2.Location = new System.Drawing.Point(77, 199);
            this.btnsubmit2.Name = "btnsubmit2";
            this.btnsubmit2.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit2.TabIndex = 8;
            this.btnsubmit2.Text = "Submit";
            this.btnsubmit2.UseVisualStyleBackColor = true;
            this.btnsubmit2.Click += new System.EventHandler(this.btnsubmit2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 7;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(77, 118);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(202, 21);
            this.comboBox5.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(77, 76);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(202, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // cmbbxchkbank
            // 
            this.cmbbxchkbank.FormattingEnabled = true;
            this.cmbbxchkbank.Location = new System.Drawing.Point(77, 32);
            this.cmbbxchkbank.Name = "cmbbxchkbank";
            this.cmbbxchkbank.Size = new System.Drawing.Size(202, 21);
            this.cmbbxchkbank.TabIndex = 4;
            // 
            // iblamt2
            // 
            this.iblamt2.AutoSize = true;
            this.iblamt2.Location = new System.Drawing.Point(6, 165);
            this.iblamt2.Name = "iblamt2";
            this.iblamt2.Size = new System.Drawing.Size(43, 13);
            this.iblamt2.TabIndex = 3;
            this.iblamt2.Text = "Amount";
            // 
            // lblchqno
            // 
            this.lblchqno.AutoSize = true;
            this.lblchqno.Location = new System.Drawing.Point(6, 126);
            this.lblchqno.Name = "lblchqno";
            this.lblchqno.Size = new System.Drawing.Size(61, 13);
            this.lblchqno.TabIndex = 2;
            this.lblchqno.Text = "Cheque No";
            // 
            // lblaccno2
            // 
            this.lblaccno2.AutoSize = true;
            this.lblaccno2.Location = new System.Drawing.Point(6, 85);
            this.lblaccno2.Name = "lblaccno2";
            this.lblaccno2.Size = new System.Drawing.Size(64, 13);
            this.lblaccno2.TabIndex = 1;
            this.lblaccno2.Text = "Account No";
            // 
            // lblbname2
            // 
            this.lblbname2.AutoSize = true;
            this.lblbname2.Location = new System.Drawing.Point(6, 40);
            this.lblbname2.Name = "lblbname2";
            this.lblbname2.Size = new System.Drawing.Size(32, 13);
            this.lblbname2.TabIndex = 0;
            this.lblbname2.Text = "Bank";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(527, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 513);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Outstanding Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(13, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(505, 63);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // Invoice_Set_Off
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 567);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Invoice_Set_Off";
            this.Text = "Invoice Set Off";
            this.Load += new System.EventHandler(this.Invoice_Set_Off_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invoice_Set_Off_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblmanfact;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbinvoice;
        private System.Windows.Forms.ComboBox cmbmanufact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdocheque;
        private System.Windows.Forms.RadioButton rdocash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblamt;
        private System.Windows.Forms.Label lblaccountno;
        private System.Windows.Forms.Label lblbank;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblchqno;
        private System.Windows.Forms.Label lblaccno2;
        private System.Windows.Forms.Label lblbname2;
        private System.Windows.Forms.Button btnsubmit2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox cmbbxchkbank;
        private System.Windows.Forms.Label iblamt2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
    }
}