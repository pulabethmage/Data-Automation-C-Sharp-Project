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
    public partial class CheqDeposits : Form
    {
        private Form1 parent;
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



        public CheqDeposits()
        {
            InitializeComponent();
        }
        public CheqDeposits(Form1 p1)
        {
            parent = p1;
            InitializeComponent();
        }
        public CheqDeposits(Form1 p1,ToolStripMenuItem t1)
        {
            tool1 = t1;
            InitializeComponent();
        }

        private void CheqDeposits_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

            da.InsertCommand = new SqlCommand("insert into checkd(date,bankname,branch,accno,checkno,checkamt)values (@date,@bankname,@branch,@accno,@checkno,@checkamt)", connString);

            da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();
            da.InsertCommand.Parameters.Add("@bankname", SqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();        
            da.InsertCommand.Parameters.Add("@branch", SqlDbType.VarChar).Value = textBox2.Text;           
            da.InsertCommand.Parameters.Add("@accno", SqlDbType.VarChar).Value = textBox3.Text;

            string checkno = textBox4.Text;

            da.InsertCommand.Parameters.Add("@checkno", SqlDbType.VarChar).Value = checkno;
            da.InsertCommand.Parameters.Add("@checkamt", SqlDbType.VarChar).Value = float.Parse(textBox6.Text);

            connString.Open();
            da.InsertCommand.ExecuteNonQuery();
            connString.Close();



            //MessageBox.Show("Successfully added to the DB","GALBOTAL");



            ///////////////////////////////////////////////////////////////////////////

            //string sumno123 = comboBox1.SelectedItem.ToString();


            connString.Open();
            da = new SqlDataAdapter("select date AS Date,bankname AS Bank_Name,branch AS Branch,accno AS Account_NO,checkno AS Cheque_NO,checkamt AS Cheque_Amount,checkauto from checkd where  checkno = @checkno", connString);
            da.SelectCommand.Parameters.Add("@checkno", SqlDbType.VarChar).Value = checkno;
            sqlCommandBuilder = new SqlCommandBuilder(da);



            dt = new DataTable();
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            connString.Close();




            //textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();

            dateTimePicker1.Value = DateTime.Now.AddDays(0);
            


            }
            //---------------------------------------------------------------------------------------------------
            catch (SqlException se)
            {
                if (se.Message.StartsWith("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("User Already Registered ... !!!");

                }
                else MessageBox.Show(se.ToString());
                connString.Close();

            }
            catch (NullReferenceException)
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Choose a Bank");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Branch");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Please Enter Account Number");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Please Enter Amount");
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show("Please Enter Amount");
                }
                else
                {
                    MessageBox.Show("Amount is not in correct format");
                }

                connString.Close();
            }
            catch (FormatException)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Branch");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Please Enter Account Number");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Please Enter Amount");
                }
                else if (textBox6.Text == "")
                {
                    MessageBox.Show("Please Enter Amount");
                }
                else
                MessageBox.Show("Amount is not in correct format");
                connString.Close();
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //----------------------------------------




        }

        private void button2_Click(object sender, EventArgs e)
        {

            //try
            //{


            string checkno1 = textBox5.Text;


            connString.Open();
            da = new SqlDataAdapter("select date AS Date,bankname AS Bank_Name,branch AS Branch,accno AS Account_NO,checkno AS Cheque_NO,checkamt AS Cheque_Amount,checkauto from checkd where  checkno = @checkno", connString);
            da.SelectCommand.Parameters.Add("@checkno", SqlDbType.VarChar).Value = checkno1;
            sqlCommandBuilder = new SqlCommandBuilder(da);



            dt = new DataTable();
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            connString.Close();


            //}

            //catch (Exception)
            //{

            //}




        }

        private void button3_Click(object sender, EventArgs e)
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

        private void CheqDeposits_Load(object sender, EventArgs e)
        {

            //try
            //{
            string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command1 = conn.CreateCommand();
            SqlDataReader reader1;




            command1.CommandText = "SELECT bankname FROM banks ";
            conn.Open();
            reader1 = command1.ExecuteReader();


            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            while (reader1.Read())
            {
                comboBox1.Items.Add(reader1.GetString(0));

            }


            conn.Close();

            //}

            //catch (Exception)
            //{

            //}
        }

       
        

        
    }
}
