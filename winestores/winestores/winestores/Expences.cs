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
    public partial class Expences : Form
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


        public Expences()
        {
            InitializeComponent();
        }
        public Expences(Form1 p1)
        {
            parent = p1;
            InitializeComponent();
        }
        public Expences(Form1 p1,ToolStripMenuItem t1)
        {
            tool1 = t1;
            InitializeComponent();
        }

        private void Expences_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

            da.InsertCommand = new SqlCommand("insert into expences(date,exptype,expamt,total)values (@date,@exptype,@expamt,@total)", connString);

            da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();
            da.InsertCommand.Parameters.Add("@exptype", SqlDbType.VarChar).Value = textBox1.Text;
            da.InsertCommand.Parameters.Add("@expamt", SqlDbType.VarChar).Value = float.Parse(textBox2.Text);

            da.InsertCommand.Parameters.Add("@total", SqlDbType.VarChar).Value = float.Parse(textBox2.Text);

            textBox3.Text = textBox2.Text.ToString(); ;

            
            

            connString.Open();
            da.InsertCommand.ExecuteNonQuery();
            connString.Close();
            



            ///////////////////////////////////////////////////////////////////////////

           

            connString.Open();
            da = new SqlDataAdapter("select * from expences", connString);
            sqlCommandBuilder = new SqlCommandBuilder(da);



            dt = new DataTable();
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].ReadOnly= true;
            dataGridView1.Columns[3].ReadOnly = true;
            

            connString.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
            dateTimePicker1.Value = DateTime.Now.AddDays(0);


            }

                       //---------------------------------------------------------------------------------------------------
            catch (SqlException se)
            {
                if (se.Message.StartsWith("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("User Already Registered ... !!!");
                    connString.Close();
                }
                else MessageBox.Show(se.ToString());


            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show(ne.ToString());

                connString.Close();
            }
            catch (FormatException)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Expense Type");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Amount");
                }
                else
                MessageBox.Show("Amount is not in correct format");
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
            try
            {
                da.Update(dt);

            }

            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            
            int colno = dataGridView1.CurrentCell.ColumnIndex;
            int rowno = dataGridView1.CurrentCell.RowIndex;

            double amtcol = double.Parse(dataGridView1.CurrentCell.Value.ToString());
                        
            int totalcol = colno + 1;
            dataGridView1.Rows[rowno].Cells[totalcol].Value = amtcol;



            //}

            //catch (Exception)
            //{

            //}
        }
    }
}
