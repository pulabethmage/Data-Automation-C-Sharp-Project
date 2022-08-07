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
    public partial class Empty_Bottles : Form
    {

        private SqlConnection connString = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True");
        string connString1 = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True";
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        private SqlDataAdapter da3 = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dt = null;
        private DataTable dt2 = null;
        private BindingSource bindingSource = null;
        private ToolStripMenuItem tool1;
        private Form1 f1;
        float price, total;
        int qty, kindqty, kindbal, kindbal2, kindrcvd, rowno, colno, cellkindval;
        string bno, sno;
        string kindst,kindname;
        string billno;


        public Empty_Bottles()
        {
            
            InitializeComponent();

        }

        
        public Empty_Bottles(Form1 p1)
        {
            f1 = p1;
            InitializeComponent();

        }



        public Empty_Bottles(Form1 p1, ToolStripMenuItem t1)
        {


            tool1 = t1;
            InitializeComponent();
        }

        private void Empty_Bottles_Load(object sender, EventArgs e)
        {




        }

        private void Empty_Bottles_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {


                da.InsertCommand = new SqlCommand("insert into emptybottle(sumno,billno,date,kind,emptyQty,bottleprice,totalamt,received,balance)values (@sumno,@billno,@date,@kind,@emptyQty,@bottleprice,@totalamt,@received,@balance)", connString);

                sno = textBox1.Text;
                da.InsertCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;


                bno = textBox2.Text;
                da.InsertCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();

                qty = Int32.Parse(textBox3.Text);
                ///////////////////

                if (radioButton1.Checked)
                {
                    kindst = radioButton1.Text;
                    price = 35;
                }
                else if (radioButton2.Checked)
                {
                    kindst = radioButton2.Text;
                    price = 35;
                }
                else if (radioButton3.Checked)
                {
                    kindst = radioButton3.Text;
                    price = 25;
                }
                else if (radioButton4.Checked)
                {
                    kindst = radioButton4.Text;
                    price = 25;
                }
                else if (radioButton5.Checked)
                {
                    kindst = radioButton5.Text;
                    price = 20;
                }
                else if (radioButton6.Checked)
                {
                    kindst = radioButton6.Text;
                    price = 20;
                }
                else if (radioButton7.Checked)
                {
                    kindst = radioButton7.Text;
                    price = 20;
                }
                else
                {
                    MessageBox.Show("Please Select a Bottle type");
                }


                total = qty * price;

                //textBox5.Text = total.ToString();


                //////////////////
                da.InsertCommand.Parameters.Add("@kind", SqlDbType.VarChar).Value = kindst;
                da.InsertCommand.Parameters.Add("@emptyQty", SqlDbType.VarChar).Value = qty;

                //price = float.Parse(textBox4.Text);
                da.InsertCommand.Parameters.Add("@bottleprice", SqlDbType.VarChar).Value = price;



                total = qty * price;
                da.InsertCommand.Parameters.Add("@totalamt", SqlDbType.VarChar).Value = total;
                da.InsertCommand.Parameters.Add("@received", SqlDbType.VarChar).Value = 0;
                da.InsertCommand.Parameters.Add("@balance", SqlDbType.VarChar).Value = 0;


                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();







                connString.Open();
                da = new SqlDataAdapter("select sumno,billno AS Bill_No ,date,emptyQty AS Empty_Bottle_Quantity,bottleprice AS Price,totalamt AS Total_Amount,emptyauto from emptybottle where billno  = @billno AND sumno= @sumno", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[2].Visible = false;
                //dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;


                connString.Close();
            }
            else if (radioButton9.Checked)
            {
                da.InsertCommand = new SqlCommand("insert into emptycrates(sumno,billno,date,cratestype,emptyQty,crateprice,totalamt,received,balance)values (@sumno,@billno,@date,@cratestype,@emptyQty,@crateprice,@totalamt,@received,@balance)", connString);

                sno = textBox1.Text;
                da.InsertCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;


                bno = textBox2.Text;
                da.InsertCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = dateTimePicker1.Value.ToShortDateString();

                qty = Int32.Parse(textBox3.Text);
                ///////////////////

                if (radioButton10.Checked)
                {
                    kindst = radioButton10.Text;
                    price = 35;
                }
                else if (radioButton11.Checked)
                {
                    kindst = radioButton11.Text;
                    price = 35;
                }
                else if (radioButton12.Checked)
                {
                    kindst = radioButton12.Text;
                    price = 25;
                }
                else if (radioButton13.Checked)
                {
                    kindst = radioButton13.Text;
                    price = 25;
                }
                else if (radioButton14.Checked)
                {
                    kindst = radioButton14.Text;
                    price = 20;
                }



                total = qty * price;

                //textBox5.Text = total.ToString();


                //////////////////
                da.InsertCommand.Parameters.Add("@cratestype", SqlDbType.VarChar).Value = kindst;
                da.InsertCommand.Parameters.Add("@emptyQty", SqlDbType.VarChar).Value = qty;

                //price = float.Parse(textBox4.Text);
                da.InsertCommand.Parameters.Add("@crateprice", SqlDbType.VarChar).Value = price;



                total = qty * price;
                da.InsertCommand.Parameters.Add("@totalamt", SqlDbType.VarChar).Value = total;
                da.InsertCommand.Parameters.Add("@received", SqlDbType.VarChar).Value = 0;
                da.InsertCommand.Parameters.Add("@balance", SqlDbType.VarChar).Value = 0;


                connString.Open();
                da.InsertCommand.ExecuteNonQuery();
                connString.Close();







                connString.Open();
                da = new SqlDataAdapter("select sumno,billno AS Bill_No ,date,emptyQty AS Empty_Crates_Quantity,crateprice AS Price,totalamt AS Total_Amount,cratesauto from emptycrates where billno  = @billno AND sumno= @sumno", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[2].Visible = false;
                //dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;


                connString.Close();

            }
            else
            {
                MessageBox.Show("Please Select a Type");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                qty = Int32.Parse(textBox3.Text);

                if (radioButton1.Checked)
                {
                    price = 35;
                }
                else if (radioButton2.Checked)
                {
                    price = 35;
                }
                else if (radioButton3.Checked)
                {
                    price = 25;
                }
                else if (radioButton4.Checked)
                {
                    price = 25;
                }
                else if (radioButton5.Checked)
                {
                    price = 20;
                }
                else if (radioButton6.Checked)
                {
                    price = 20;
                }
                else if (radioButton7.Checked)
                {
                    price = 20;
                }
                else
                {
                    MessageBox.Show("Please Select a Crate type");
                }


                total = qty * price;

                textBox4.Text = price.ToString();
                textBox5.Text = total.ToString();
            }
            else if (radioButton9.Checked)
            {
                qty = Int32.Parse(textBox3.Text);

                if (radioButton10.Checked)
                {
                    price = 15;
                }
                if (radioButton11.Checked)
                {
                    price = 20;
                }
                if (radioButton12.Checked)
                {
                    price = 20;
                }
                if (radioButton13.Checked)
                {
                    price = 20;
                }
                if (radioButton14.Checked)
                {
                    price = 20;
                }

                total = qty * price;
                textBox4.Text = price.ToString();
                textBox5.Text = total.ToString();


            }
            else
            {
                MessageBox.Show("Please Select empty type");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {



                connString.Open();
                da = new SqlDataAdapter("select sumno,billno AS Bill_No ,date,emptyQty AS Empty_Bottle_Quantity,bottleprice AS Price,totalamt AS Total_Amount,emptyauto from emptybottle where sumno= @sumno", connString);
                //da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = textBox6.Text;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[2].Visible = false;
                //dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;


                connString.Close();
            }
            else if (radioButton9.Checked)
            {
                connString.Open();
                da = new SqlDataAdapter("select sumno,billno AS Bill_No ,date,emptyQty AS Empty_Crates_Quantity,crateprice AS Price,totalamt AS Total_Amount,cratesauto from emptycrates where sumno= @sumno", connString);
                //da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = bno;
                da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = textBox6.Text;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt = new DataTable();
                da.Fill(dt);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridView1.DataSource = bindingSource;


                dataGridView1.Columns[0].Visible = false;
                //dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[2].Visible = false;
                //dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;


                connString.Close();

            }
            else
            {
                MessageBox.Show("Please Select a Type");
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

                int pricecolom = colno + 1;
                int totalcolom = colno + 2;

                //int conproname = colno - 1;


                double priceval = double.Parse(dataGridView1.Rows[rowno].Cells[pricecolom].Value.ToString());

                double totalprice = qtyy * priceval;

                dataGridView1.Rows[rowno].Cells[totalcolom].Value = totalprice;


               // string proname = dataGridView1.Rows[rowno].Cells[conproname].Value.ToString();

               // updatestock(proname, qtyy);


            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                billno = textBox7.Text;

                connString.Open();
                da = new SqlDataAdapter("select sumno,billno ,date,kind AS Kind,emptyQty AS Empty_Bottles,bottleprice AS Bottle_Price,totalamt AS Total_Amount,received AS Received,balance AS Balance,emptyauto from emptybottle where billno  = @billno AND received != emptyQty ", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = billno;
                //da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt2 = new DataTable();
                da.Fill(dt2);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt2;

                dataGridView2.DataSource = bindingSource;


                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[3].ReadOnly = true;
                dataGridView2.Columns[7].ReadOnly = true;
                dataGridView2.Columns[4].ReadOnly = true;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[9].Visible = false;

                //int rowco = dataGridView2.Rows.Count;
                //dataGridView2.Rows[4].Visible = false;

                //MessageBox.Show(rowco.ToString());


                connString.Close();

            }
            else if (radioButton16.Checked)
            {
                billno = textBox7.Text;

                connString.Open();
                da = new SqlDataAdapter("select sumno,billno ,date,cratestype AS Crates_Type,emptyQty AS Empty_Crates,crateprice AS Crate_Price,totalamt AS Total_Amount,received AS Received,balance AS Balance,cratesauto from emptycrates where billno  = @billno AND received != emptyQty ", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = billno;
                //da.SelectCommand.Parameters.Add("@sumno", SqlDbType.VarChar).Value = sno;
                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt2 = new DataTable();
                da.Fill(dt2);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt2;

                dataGridView2.DataSource = bindingSource;


                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[3].ReadOnly = true;
                dataGridView2.Columns[7].ReadOnly = true;
                dataGridView2.Columns[4].ReadOnly = true;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[9].Visible = false;

                //int rowco = dataGridView2.Rows.Count;
                //dataGridView2.Rows[4].Visible = false;

                //MessageBox.Show(rowco.ToString());


                connString.Close();

            }
            else
            {
                MessageBox.Show("Please Select Empty Type");
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int kindcol;
             colno = dataGridView2.CurrentCell.ColumnIndex;
             rowno = dataGridView2.CurrentCell.RowIndex;
            if (colno == 3 || colno == 4 || colno == 7 || colno == 8)
            {
                kindcol = 3;
                kindname = dataGridView2.Rows[rowno].Cells[kindcol].Value.ToString();
                kindqty = Int32.Parse(dataGridView2.Rows[rowno].Cells[4].Value.ToString());
                textBox14.Text = kindname;
                textBox8.Text = kindqty.ToString();

                cellkindval = Int32.Parse(dataGridView2.Rows[rowno].Cells[7].Value.ToString());
                //kindbal2 = kindqty;
            }       

            


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                SqlConnection conn = new SqlConnection(connString1);

                SqlCommand command11 = conn.CreateCommand();
                SqlDataReader reader11;


                kindrcvd = Int32.Parse(textBox13.Text);

                int sumkind = kindrcvd + cellkindval;
                kindbal2 = kindqty - sumkind;

                if (kindqty < kindrcvd)
                {
                    MessageBox.Show("Please Recheck the Input Quantity..rrrrrrrrrrrrrrrrrr...");
                    int qq = Int32.Parse(dataGridView2.Rows[rowno].Cells[7].Value.ToString());
                    int ww = Int32.Parse(dataGridView2.Rows[rowno].Cells[8].Value.ToString());
                    sumkind = qq;
                    kindbal2 = ww;

                }
                else if (kindbal2 < 0)
                {
                    MessageBox.Show("Please Recheck the Input Quantity.....");

                    sumkind = sumkind - kindrcvd;
                    kindbal2 = kindqty - cellkindval;
                }





                dataGridView2.Rows[rowno].Cells[7].Value = kindrcvd.ToString();
                dataGridView2.Rows[rowno].Cells[8].Value = kindbal2.ToString();



                command11.CommandText = "UPDATE emptybottle SET received = " + sumkind + " ,balance = " + kindbal2 + "   WHERE kind = '" + kindname + "'";
                conn.Open();
                reader11 = command11.ExecuteReader();
                conn.Close();

                dataGridView2.Refresh();
                textBox13.Clear();
                textBox14.Clear();

                textBox8.Clear();

                connString.Open();
                da = new SqlDataAdapter("select sumno,billno ,date,kind AS Kind,emptyQty AS Empty_Bottles,bottleprice AS Bottle_Price,totalamt AS Total_Amount,received AS Received,balance AS Balance,emptyauto from emptybottle where billno  = @billno AND received != emptyQty", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = billno;

                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt2 = new DataTable();
                da.Fill(dt2);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt2;

                dataGridView2.DataSource = bindingSource;


                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[3].ReadOnly = true;
                dataGridView2.Columns[7].ReadOnly = true;
                dataGridView2.Columns[4].ReadOnly = true;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[9].Visible = false;


                connString.Close();


            }
            else if (radioButton16.Checked)
            {
                SqlConnection conn = new SqlConnection(connString1);

                SqlCommand command11 = conn.CreateCommand();
                SqlDataReader reader11;


                kindrcvd = Int32.Parse(textBox13.Text);

                int sumkind = kindrcvd + cellkindval;
                kindbal2 = kindqty - sumkind;

                if (kindqty < kindrcvd)
                {
                    MessageBox.Show("Please Recheck the Input Quantity..rrrrrrrrrrrrrrrrrr...");
                    int qq = Int32.Parse(dataGridView2.Rows[rowno].Cells[7].Value.ToString());
                    int ww = Int32.Parse(dataGridView2.Rows[rowno].Cells[8].Value.ToString());
                    sumkind = qq;
                    kindbal2 = ww;

                }
                else if (kindbal2 < 0)
                {
                    MessageBox.Show("Please Recheck the Input Quantity.....");

                    sumkind = sumkind - kindrcvd;
                    kindbal2 = kindqty - cellkindval;
                }





                dataGridView2.Rows[rowno].Cells[7].Value = kindrcvd.ToString();
                dataGridView2.Rows[rowno].Cells[8].Value = kindbal2.ToString();



                command11.CommandText = "UPDATE emptycrates SET received = " + sumkind + " ,balance = " + kindbal2 + "   WHERE cratestype = '" + kindname + "'";
                conn.Open();
                reader11 = command11.ExecuteReader();
                conn.Close();

                dataGridView2.Refresh();
                textBox13.Clear();
                textBox14.Clear();

                textBox8.Clear();

                connString.Open();
                da = new SqlDataAdapter("select sumno,billno ,date,cratestype AS Crate_Type,emptyQty AS Empty_Crates,crateprice AS Crate_Price,totalamt AS Total_Amount,received AS Received,balance AS Balance,cratesauto from emptycrates where billno  = @billno AND received != emptyQty", connString);
                da.SelectCommand.Parameters.Add("@billno", SqlDbType.VarChar).Value = billno;

                sqlCommandBuilder = new SqlCommandBuilder(da);



                dt2 = new DataTable();
                da.Fill(dt2);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dt2;

                dataGridView2.DataSource = bindingSource;


                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[3].ReadOnly = true;
                dataGridView2.Columns[7].ReadOnly = true;
                dataGridView2.Columns[4].ReadOnly = true;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[9].Visible = false;


                connString.Close();
            }

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox8.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Visible = true;
            groupBox6.Visible = false;
        }

        

        
       

       
    }
}
