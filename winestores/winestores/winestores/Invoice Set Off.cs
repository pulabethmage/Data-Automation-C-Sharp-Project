using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winestores
{
    public partial class Invoice_Set_Off : Form
    {

        private Form1 f1;
        private ToolStripMenuItem tool1;

        private SqlConnection connString = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True");
        string connString1 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";



        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        private SqlDataAdapter da3 = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dt = null;
        private BindingSource bindingSource = null;
        string paymthd,chkno,manufactcash,invoicecash,bankcash,accountcash,manfact,invo;
        double invotot;
        double otstngamt;
        double totoutstanding;
        double ball;

        public Invoice_Set_Off()
        {
            InitializeComponent();
        }


        public Invoice_Set_Off(Form1 p1)
        {
            f1 = p1;
            InitializeComponent();
        }





        public Invoice_Set_Off(Form1 p1, ToolStripMenuItem t1)
        {
            f1 = p1;
            tool1 = t1;
            InitializeComponent();
        }






        private void Invoice_Set_Off_Load(object sender, EventArgs e)
        {
            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            SqlCommand command1 = conn.CreateCommand();
            SqlCommand command2 = conn.CreateCommand();
            SqlCommand command3 = conn.CreateCommand();
            SqlCommand command4 = conn.CreateCommand();
            SqlCommand command5 = conn.CreateCommand();
            SqlDataReader reader1;
            SqlDataReader reader2;
            SqlDataReader reader3;
            SqlDataReader reader4;
            SqlDataReader reader5;




            command1.CommandText = "SELECT manufact FROM invoice ";
            conn.Open();
            reader1 = command1.ExecuteReader();


            cmbmanufact.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbmanufact.AutoCompleteSource = AutoCompleteSource.ListItems;

            while (reader1.Read())
            {
                cmbmanufact.Items.Add(reader1.GetString(0));
                
            }
            


            conn.Close();




///////////////////////////////////////////////////////////////////////////////////

            command3.CommandText = "SELECT bankname FROM banks ";
            conn.Open();
            reader3 = command3.ExecuteReader();


            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbbxchkbank.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbbxchkbank.AutoCompleteSource = AutoCompleteSource.ListItems;

            while (reader3.Read())
            {
                comboBox1.Items.Add(reader3.GetString(0));
                cmbbxchkbank.Items.Add(reader3.GetString(0));

            }


            conn.Close();
/////////////////////////////////////////////////////////////////////////////////////////////



            command4.CommandText = "SELECT accno FROM cashde ";
            conn.Open();
            reader4 = command4.ExecuteReader();


            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;

            while (reader4.Read())
            {
                comboBox2.Items.Add(reader4.GetString(0));
                comboBox4.Items.Add(reader4.GetString(0));

            }


            conn.Close();
//////////////////////////////////////////////////////////////////////////////////////////////////

            command5.CommandText = "SELECT checkno FROM checkd ";
            conn.Open();
            reader5 = command5.ExecuteReader();


            comboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;

            while (reader5.Read())
            {
                comboBox5.Items.Add(reader5.GetString(0));

            }


            conn.Close();
/////////////////////////////////////////////////////////////////////////////////////////////////






        }

        private void Invoice_Set_Off_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            SqlDataReader reader2;
            SqlCommand command2 = conn.CreateCommand();

            try
            {

                da.InsertCommand = new SqlCommand("insert into invoicesetoff(manufacturer,invoiceno,Date,paymethod,bank,accno,amt,chequeno)values (@manufacturer,@invoiceno,@Date,@paymethod,@bank,@accno,@amt,@chequeno)", connString);
                manufactcash = cmbmanufact.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@manufacturer", SqlDbType.VarChar).Value = manufactcash;
                invoicecash = cmbinvoice.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@invoiceno", SqlDbType.VarChar).Value = invoicecash;
                da.InsertCommand.Parameters.Add("@Date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString(); ;

                paymthd = "Cash";

                da.InsertCommand.Parameters.Add("@paymethod", SqlDbType.VarChar).Value = paymthd;
                bankcash = comboBox1.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@bank", SqlDbType.VarChar).Value = bankcash;
                accountcash = comboBox2.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@accno", SqlDbType.VarChar).Value = accountcash;
                da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = textBox1.Text;
                chkno = "";
                da.InsertCommand.Parameters.Add("@chequeno", SqlDbType.VarChar).Value = chkno;


                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();
                //textBox1.Clear();

                float totalamt = float.Parse(textBox4.Text);
                float balamt = totalamt - float.Parse(textBox1.Text);

                command2.CommandText = "UPDATE invoice SET total = " + balamt + " WHERE invoceno = '" + invoicecash + "'";
                conn.Open();
                reader2 = command2.ExecuteReader();
                conn.Close();




                //MessageBox.Show("elakiri");
                cal_outstanding(invoicecash);

                string invoice123 = cmbinvoice.SelectedItem.ToString();

                connString.Open();
                da = new SqlDataAdapter("select manufacturer,invoiceno ,Date,paymethod,bank,accno,amt,chequeno,invoicesetauto from invoicesetoff where invoiceno  = @invoice123", connString);
                da.SelectCommand.Parameters.Add("@invoice123", SqlDbType.VarChar).Value = invoice123;
                //da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);

                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                dataGridView1.Columns[8].Visible = false;

                connString.Close();

                cmbinvoice.Items.Clear();
                cmbinvoice.SelectedIndex = -1;


            }
            
            //catch (Exception)
            //{
            //    MessageBox.Show("Inserting Error....!!!!");
            //}

            catch (SqlException se)
            {
                if (se.Message.StartsWith("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("User Already Registered ... !!!");
                    connString.Close();
                }
                else MessageBox.Show(se.ToString());

                //if (se.Message.StartsWith("Input String was not in correct format"))
                //{
                //    MessageBox.Show("Phone numbers are Invalid");
                //    connstring.Close();
                //}
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Please Enter Values");
                connString.Close();
            }
            catch (FormatException )
            {
                MessageBox.Show("Input values are not in correct format");
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //finally { cmd.Connection.Close(); }
            
            
        }
        

        private void rdocash_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void rdocheque_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
        }

        private void btnsubmit2_Click(object sender, EventArgs e)
        {
            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            SqlDataReader reader2;
            SqlCommand command2 = conn.CreateCommand();



            try
            {
                da.InsertCommand = new SqlCommand("insert into invoicesetoff(manufacturer,invoiceno,Date,paymethod,bank,accno,amt,chequeno)values (@manufacturer,@invoiceno,@Date,@paymethod,@bank,@accno,@amt,@chequeno)", connString);
                manufactcash = cmbmanufact.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@manufacturer", SqlDbType.VarChar).Value = manufactcash;

                invoicecash = cmbinvoice.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@invoiceno", SqlDbType.VarChar).Value = invoicecash;

                da.InsertCommand.Parameters.Add("@Date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString(); ;

                paymthd = "Cheque";
                da.InsertCommand.Parameters.Add("@paymethod", SqlDbType.VarChar).Value = paymthd;

                bankcash = cmbbxchkbank.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@bank", SqlDbType.VarChar).Value = bankcash;

                accountcash = comboBox4.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@accno", SqlDbType.VarChar).Value = accountcash;

                da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value =float.Parse(textBox2.Text);

                chkno = comboBox5.SelectedItem.ToString();
                da.InsertCommand.Parameters.Add("@chequeno", SqlDbType.VarChar).Value = chkno;


                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();
               // textBox2.Clear();


                float totalamt = float.Parse(textBox4.Text);
                float balamt = totalamt - float.Parse(textBox2.Text);

                command2.CommandText = "UPDATE invoice SET total = " + balamt + " WHERE invoceno = '" + invoicecash + "'";
                conn.Open();
                reader2 = command2.ExecuteReader();
                conn.Close();
                


                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                string invoice123 = cmbinvoice.SelectedItem.ToString();


                connString.Open();
                da = new SqlDataAdapter("select manufacturer,invoiceno ,Date,paymethod,bank,accno,amt,chequeno,invoicesetauto from invoicesetoff where invoiceno  = @invoice123", connString);
                da.SelectCommand.Parameters.Add("@invoice123", SqlDbType.VarChar).Value = invoice123;
                //da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;

                dataGridView1.Columns[8].Visible = false;

                connString.Close();



            }
            
            //catch (Exception)
            //{
            //    MessageBox.Show("Inserting Error....!!!!");
            //}

            catch (SqlException se)
            {
                if (se.Message.StartsWith("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("User Already Registered ... !!!");
                    connString.Close();
                }
                else MessageBox.Show(se.ToString());

                //if (se.Message.StartsWith("Input String was not in correct format"))
                //{
                //    MessageBox.Show("Phone numbers are Invalid");
                //    connstring.Close();
                //}
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Please Enter Values");
                connString.Close();
            }
            catch (FormatException )
            {
                MessageBox.Show("Input values are not in correct format");
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //finally { cmd.Connection.Close(); }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Invoice number");

            }
            else
            {
                try
                {
                    string invoice123 = textBox3.Text;


                    connString.Open();
                    da = new SqlDataAdapter("select manufacturer,invoiceno ,Date,paymethod,bank,accno,amt,chequeno,invoicesetauto from invoicesetoff where invoiceno  = @invoice123", connString);
                    da.SelectCommand.Parameters.Add("@invoice123", SqlDbType.VarChar).Value = invoice123;
                    sqlCommandBuilder = new SqlCommandBuilder(da);



                    dt = new DataTable();
                    da.Fill(dt);
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dt;

                    dataGridView1.DataSource = bindingSource;


                    //dataGridView1.Columns[0].Visible = false;
                    //dataGridView1.Columns[1].Visible = false;
                    //dataGridView1.Columns[2].ReadOnly = true;
                    //dataGridView1.Columns[4].Visible = false;
                    //dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    
                    //dataGridView1.Columns[7].Visible = false;


                    connString.Close();
                    textBox3.Clear();
                }
                catch (Exception exceptionObj)
                {
                    MessageBox.Show(exceptionObj.Message.ToString());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(dt);

            }

            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void cmbmanufact_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            conn.Open();
            SqlDataReader reader2;
            SqlCommand command2 = conn.CreateCommand();
            manfact = cmbmanufact.SelectedItem.ToString();
            command2.CommandText = "SELECT invoceno FROM invoice WHERE manufact = '" + manfact + "'";
                       
            
            reader2 = command2.ExecuteReader();
            
            cmbinvoice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbinvoice.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbinvoice.Items.Clear();
            cmbinvoice.Text = "";

            while (reader2.Read())
            {
                
                cmbinvoice.Items.Add(reader2.GetString(0));                

            }
            conn.Close();
        }

        private void cmbinvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string invo = cmbinvoice.SelectedItem.ToString();
            string man = cmbmanufact.SelectedItem.ToString();
            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            SqlCommand command20 = conn.CreateCommand();
            SqlDataReader reader20;

            //manfact = cmbmanufact.SelectedItem.ToString();
           // invo = cmbinvoice.SelectedItem.ToString();
            ///manufact = '" + manfact + "' AND
            ///

            command20.CommandText = "SELECT total FROM invoice WHERE  invoceno = '" + invo + "' AND manufact = '" + man + "' ";
            conn.Open();
            reader20 = command20.ExecuteReader();
            //float b = reader20.GetFloat(0);
            while (reader20.Read())
            {
                double b = reader20.GetDouble(0);
                textBox4.Text = b.ToString();
               

            }      
            
            conn.Close();
           

            

            

            
        }

        void cal_outstanding(string totinvostring)//, string tototstandstring)
        {           
           


            string connString11 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString11);
            conn.Open();
            SqlDataReader reader2;
            SqlDataReader reader3;

            SqlCommand command2 = conn.CreateCommand();
            SqlCommand command3 = conn.CreateCommand();
            //manfact = cmbmanufact.SelectedItem.ToString();
            command2.CommandText = "SELECT total FROM invoice WHERE invoceno = '" + totinvostring + "'";
            

            reader2 = command2.ExecuteReader();
            
            while (reader2.Read())
            {

                invotot = reader2.GetDouble(0);

            }


            conn.Close();

            //MessageBox.Show(invotot.ToString());

            


        }

        private void cmbinvoice_Click(object sender, EventArgs e)
        {
           
        }

       

        
    }
}
