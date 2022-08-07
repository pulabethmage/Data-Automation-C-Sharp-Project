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
    public partial class EmptyBottles : Form
    {
        double price12;
        double total;
        string productname12;
        int qty1;

        int balstock;

        int inistock123;


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


        public EmptyBottles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

            

            da.InsertCommand = new SqlCommand("insert into emptybottle(sumno,billno,date,emptyQty,bottleprice,totalamt)values (@sumno,@billno,@date,@emptyQty,@bottleprice,@totalamt)", connString);

            string sumnumber = textBox1.Text;
            da.InsertCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sumnumber;
            
            string billnumb = textBox2.Text;
            da.InsertCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = billnumb;

            da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();
            
            int emptyQty = textBox3.Text;
            da.InsertCommand.Parameters.Add("@emptyQty", SqlDbType.VarChar).Value = emptyQty;

            float pricebot = float.Parse(textBox4.Text);
            da.InsertCommand.Parameters.Add("@bottleprice", SqlDbType.VarChar).Value = pricebot;

            float totalpriceemp = pricebot * emptyQty;
            textBox5.Text = totalpriceemp.ToString();
            da.InsertCommand.Parameters.Add("@totalamt", SqlDbType.VarChar).Value = totalpriceemp;
            //salinvoice(prona, qtyIn);

            ///--------------


            SqlConnection conn = new SqlConnection(connString1);

            SqlCommand command1 = conn.CreateCommand();
            SqlDataReader reader1;

            //productname12 = comboBox2.SelectedItem.ToString();

            command1.CommandText = "select emptyQty from product where  sumno = '" + sumnumber + "' AND  billno = '" + billnumb + "' ;";
            conn.Open();
            reader1 = command1.ExecuteReader();
            reader1.Read();

            double qq = reader1.GetDouble(0);
            price12 = qq;
            conn.Close();

            qty1 = Int32.Parse(textBox4.Text);

            total = qty1 * price12;
            ///textBox5.Text = price12.ToString();
            ///textBox6.Text = total.ToString();




            ///---------------

            da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = float.Parse(price12.ToString());

            da.InsertCommand.Parameters.Add("@total", SqlDbType.VarChar).Value = float.Parse(total.ToString());

            connString.Open();
            da.InsertCommand.ExecuteNonQuery();
            connString.Close();



            //MessageBox.Show("Successfully added to the DB","GALBOTAL");



            ///////////////////////////////////////////////////////////////////////////

            //string sumno123 = textBox1.Text;


            connString.Open();
            da = new SqlDataAdapter("select manufact,invoceno,date,productname AS Product_Name,qty AS Quantity,price,total,invoauto from invoice where  invoceno = @invoceno ", connString);
            da.SelectCommand.Parameters.Add("@invoceno ", SqlDbType.VarChar).Value = textBox2.Text;
            sqlCommandBuilder = new SqlCommandBuilder(da);



            dt = new DataTable();
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].Visible = false;
            // dataGridView1.Columns[8].Visible = false;


            connString.Close();




            // textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            textBox4.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox5.Clear();

            dateTimePicker1.Value = DateTime.Now.AddDays(0);






            //}
            //catch (Exception)
            //{
 
            //}
        }

       
    }
}
