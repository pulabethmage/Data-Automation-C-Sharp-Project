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
    public partial class Add_Sales : Form
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



        public Add_Sales()
        {
            InitializeComponent();
        }
        public Add_Sales(Form1 p1)
        {
            parent = p1;
            InitializeComponent();
        }
        public Add_Sales(Form1 p1,ToolStripMenuItem t1)
        {
            tool1 = t1;
            //parent = p1;
            InitializeComponent();
        }

        private void Add_Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void Add_Sales_Load(object sender, EventArgs e)
        {

            //try
            //{
            string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command1 = conn.CreateCommand();
            SqlDataReader reader1;




            command1.CommandText = "SELECT productname FROM product ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
            
                da.InsertCommand = new SqlCommand("insert into sales(sumno,date,productname,qty,price,total)values (@sumno,@date,@productname,@qty,@price,@total)", connString);

                da.InsertCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = textBox1.Text;
                da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString(); ;
               
            productname12 = comboBox1.SelectedItem.ToString();
            da.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = productname12;
                
            qty1 = Int32.Parse(textBox2.Text);
            da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty1;

            salreduse(productname12,qty1);

                da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = float.Parse(price12.ToString());
                da.InsertCommand.Parameters.Add("@total", SqlDbType.VarChar).Value = float.Parse(total.ToString());

                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();



                //MessageBox.Show("Successfully added to the DB","GALBOTAL");


                
///////////////////////////////////////////////////////////////////////////

                string sumno123 = textBox1.Text;


                connString.Open();
                da = new SqlDataAdapter("select sumno ,date,productname AS Product_Name,qty AS Quantity,price,total,autosales from sales where  sumno = @sumno123", connString);
                da.SelectCommand.Parameters.Add("@sumno123", SqlDbType.VarChar).Value = sumno123;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].ReadOnly= true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;


                connString.Close();




                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

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
            catch (NullReferenceException)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Summery Number");

                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Choose a Product");
                }

                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity");
                }
                else

                    MessageBox.Show("Incorrect Product");


                textBox2.Clear();

                connString.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity is not in correct format");
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //----------------------------------------







        }



        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
            

            SqlConnection conn = new SqlConnection(connString1);

            SqlCommand command1 = conn.CreateCommand();
            SqlDataReader reader1;

            productname12 = comboBox1.SelectedItem.ToString();

            command1.CommandText = "select (price) from product where  productname = '" + productname12 + "';";
            conn.Open();
            reader1 = command1.ExecuteReader();
            reader1.Read();

            double qq = reader1.GetDouble(0);
            price12 = qq;
            conn.Close();

            qty1 = Int32.Parse(textBox2.Text);

            total = qty1 * price12;
            textBox3.Text = price12.ToString();
            textBox4.Text = total.ToString();


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

                //if (se.Message.StartsWith("Input String was not in correct format"))
                //{
                //    MessageBox.Show("Phone numbers are Invalid");
                //    connstring.Close();
                //}
            }
            catch (NullReferenceException)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Summery Number");
                    
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Choose a Product"); 
                }
                
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity");
                }
                else

                    MessageBox.Show("Incorrect Product");


                textBox2.Clear();

                connString.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity is not in correct format");
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //----------------------------------------
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{


            string sumno123= textBox6.Text;
                

            connString.Open();
            da = new SqlDataAdapter("select sumno ,date,productname AS Product_Name,qty AS Quantity,price,total,autosales from sales where  sumno = @sumno123", connString);
            da.SelectCommand.Parameters.Add("@sumno123", SqlDbType.VarChar).Value = sumno123;
            sqlCommandBuilder = new SqlCommandBuilder(da);



            dt = new DataTable();
            da.Fill(dt);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dt;

            dataGridView1.DataSource = bindingSource;


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



           // string msg = String.Format("Row:{0},cOLUMN :{1}", dataGridView1.CurrentCell.RowIndex,dataGridView1.CurrentCell.ColumnIndex);
            int colno = dataGridView1.CurrentCell.ColumnIndex;
            int rowno = dataGridView1.CurrentCell.RowIndex;

            int qtyy = Int32.Parse(dataGridView1.CurrentCell.Value.ToString());
            
            int pricecolom  = colno + 1;
            int totalcolom = colno + 2;

            int conproname = colno - 1;


            double priceval = double.Parse(dataGridView1.Rows[rowno].Cells[pricecolom].Value.ToString());

            double totalprice = qtyy * priceval;

            dataGridView1.Rows[rowno].Cells[totalcolom].Value = totalprice ;


            string proname = dataGridView1.Rows[rowno].Cells[conproname].Value.ToString();

            updatestock(proname, qtyy);


            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }



        public void salreduse(string proname,int quan)
        {
            string proname1 = proname;
            int quan1 = quan;
          
            int salestock12;

            int bal12;

            SqlConnection conn = new SqlConnection(connString1);

            SqlCommand command10 = conn.CreateCommand();
            SqlDataReader reader10;

            SqlCommand command11 = conn.CreateCommand();
            SqlDataReader reader11;
            //productname12 = comboBox1.SelectedItem.ToString();

            command10.CommandText = "select initialstock,salesstock,balancestock from stocktable where  productname  = '" + proname1 + "';";
            conn.Open();
            reader10 = command10.ExecuteReader();
            reader10.Read();

            int inistock = reader10.GetInt32(0);
            inistock123 = inistock;

            int salestock1 = reader10.GetInt32(1);
            salestock12 = salestock1;

            int bal1 = reader10.GetInt32(2);
            bal12 = bal1;
            

            conn.Close();

            balstock = bal12 - quan1;
            //MessageBox.Show(salestock12.ToString());
            int salestock123 = salestock12 + quan1;

            command11.CommandText = "UPDATE stocktable SET balancestock = " + balstock + " ,salesstock = " + salestock123 + "   WHERE productname = '" + proname1 + "'";
            conn.Open();
            reader11 = command11.ExecuteReader();
            conn.Close();





 
        }


        public void updatestock(string proname, int quan)
        {
            string proname1 = proname;
            int quan1 = quan;//100

            int invoicestock12;
            int invoicestock123;
            int newbalstock;
            int bal12;


            SqlConnection conn = new SqlConnection(connString1);

            SqlCommand command10 = conn.CreateCommand();
            SqlDataReader reader10;
            SqlCommand command11 = conn.CreateCommand();
            SqlDataReader reader11;


            command10.CommandText = "select initialstock,salesstock,balancestock from stocktable where  productname  = '" + proname1 + "';";
            conn.Open();
            reader10 = command10.ExecuteReader();
            reader10.Read();

            int inistock = reader10.GetInt32(0);
            inistock123 = inistock;

            int invoicestock1 = reader10.GetInt32(1);
            invoicestock12 = invoicestock1;//120    

            int bal1 = reader10.GetInt32(2);
            bal12 = bal1;//450

            conn.Close();

            int newinvoicestock1;
            int newinvoicestock2 = quan1 - invoicestock12;//100 - 120 = -20   //130-120 = 10   

            if (newinvoicestock2 < 0)
            {
                newinvoicestock1 = -1 * newinvoicestock2;
                invoicestock123 = quan1;
                newbalstock = bal12 + newinvoicestock1;
            }
            else
            {
                newinvoicestock1 = newinvoicestock2;
                invoicestock123 = quan1;
                newbalstock = bal12 - newinvoicestock1;
            }



            command11.CommandText = "UPDATE stocktable SET balancestock = " + newbalstock + " ,salesstock = " + invoicestock123 + "   WHERE productname = '" + proname1 + "'";
            conn.Open();
            reader11 = command11.ExecuteReader();
            conn.Close();









        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
               


      
    }
}
