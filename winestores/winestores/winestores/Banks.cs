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
    public partial class Banks : Form
    {
        private Form1 parent;
        private ToolStripMenuItem tool1;

        private SqlConnection connString = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True");

        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        private SqlDataAdapter da3 = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dt = null;
        private BindingSource bindingSource = null;


        public Banks()
        {
            InitializeComponent();
        }
        public Banks(Form1 p1)
        {
            parent = p1;
            InitializeComponent();
        }
        public Banks(Form1 p1, ToolStripMenuItem t1)
        {
            tool1 = t1;
            InitializeComponent();
        }

        private void Banks_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter a Bank Name");
            }
            else
            {

                da.InsertCommand = new SqlCommand("insert into banks (bankname) values (@bankname)", connString);
                da.InsertCommand.Parameters.Add("@bankname", SqlDbType.VarChar).Value = textBox1.Text;

                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();

                ///////////////////////////////////////

                connString.Open();
                da = new SqlDataAdapter("select bankauto,bankname AS Bank_Name  from banks", connString);
                //da.SelectCommand.Parameters.Add("@invoceno ", SqlDbType.VarChar).Value = textBox2.Text;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                //dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                //dataGridView1.Columns[5].ReadOnly = true;
                //dataGridView1.Columns[6].ReadOnly = true;
                //dataGridView1.Columns[7].Visible = false;
                // dataGridView1.Columns[8].Visible = false;

                connString.Close();
            }






            //}
            //catch (Exception)
            //{
 
            //}
        }

       
    }
}
