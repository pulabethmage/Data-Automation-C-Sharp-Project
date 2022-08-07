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
    public partial class Product : Form
    {
        private Form1 parent;
        private ToolStripMenuItem tool1;

        private SqlConnection connString = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=winestoresdb;Integrated Security=True");

        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        private SqlDataAdapter da3 = new SqlDataAdapter();
        private SqlDataAdapter da4 = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dt = null;
        private BindingSource bindingSource = null;

        


        public Product()
        {
            InitializeComponent();
        }
        public Product(Form1 p1)
        {
            parent = p1;

            InitializeComponent();
        }
        public Product(Form1 p1,ToolStripMenuItem t1)
        {
            tool1 = t1;
            InitializeComponent();
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            tool1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Manufacturer");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Product Name ");
                }
                else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                {
                    MessageBox.Show("Please Select Atleast One Category");
                }

                else
                {


                string proname;

                string pronamesub;
                string pronamesub1;
                string pronamesub2;
                string pronamesub3;
                string pronamesub4;

                string typeselect;
                string sele1;
                string sele2;
                string sele3;
                string sele4;

                float pricesele;
                float price1;
                float price2;
                float price3;
                float price4;

                string manu1;
                string manu2;
                string manu3;
                string manu4;
                
                
                int qtyy;
                int qty1;
                int qty2;
                int qty3;
                int qty4;



                

                proname = textBox2.Text;
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "P";
                    price2 = float.Parse(textBox4.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    sele3 = "N";
                    price3 = float.Parse(textBox5.Text);
                    pronamesub3 = string.Concat(proname, sele3);

                    sele4 = "Can";
                    price4 = float.Parse(textBox6.Text);
                    pronamesub4 = string.Concat(proname, sele4);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2 + "\r\n" + pronamesub3 + "\r\n" + pronamesub4;
                    MessageBox.Show(p, "Wine");

                    qty1 = Int32.Parse(textBox7.Text);
                    qty2 = Int32.Parse(textBox8.Text);
                    qty3 = Int32.Parse(textBox9.Text);
                    qty4 = Int32.Parse(textBox10.Text);
                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty1;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty1);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty2;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty2);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da2.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact3,@productname3,@type3,@price3,@qty,@amt,@date3)", connString);
                    da2.InsertCommand.Parameters.Add("@manufact3", SqlDbType.VarChar).Value = textBox1.Text;
                    da2.InsertCommand.Parameters.Add("@productname3", SqlDbType.VarChar).Value = pronamesub3;
                    da2.InsertCommand.Parameters.Add("@type3", SqlDbType.VarChar).Value = sele3;
                    da2.InsertCommand.Parameters.Add("@price3", SqlDbType.VarChar).Value = price3;
                    da2.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da2.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da2.InsertCommand.Parameters.Add("@date3", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub3,qty3);

                    connString.Open();
                    da2.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da3.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact4,@productname4,@type4,@price4,@qty,@amt,@date4)", connString);
                    da3.InsertCommand.Parameters.Add("@manufact4", SqlDbType.VarChar).Value = textBox1.Text;
                    da3.InsertCommand.Parameters.Add("@productname4", SqlDbType.VarChar).Value = pronamesub4;
                    da3.InsertCommand.Parameters.Add("@type4", SqlDbType.VarChar).Value = sele4;
                    da3.InsertCommand.Parameters.Add("@price4", SqlDbType.VarChar).Value = price4;
                    da3.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da3.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da3.InsertCommand.Parameters.Add("@date4", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub4,qty4);

                    connString.Open();
                    da3.InsertCommand.ExecuteNonQuery();
                    connString.Close();










                }
                ////////////////////////////////////////////////////////////////////
                else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "P";
                    price2 = float.Parse(textBox4.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    sele3 = "N";
                    price3 = float.Parse(textBox5.Text);
                    pronamesub3 = string.Concat(proname, sele3);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2 + "\r\n" + pronamesub3;
                    MessageBox.Show(p);

                    qty2 = Int32.Parse(textBox7.Text);
                    qty3 = Int32.Parse(textBox8.Text);
                    qty4 = Int32.Parse(textBox9.Text);
                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty2;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty2);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty3);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da2.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact3,@productname3,@type3,@price3,@qty,@amt,@date3)", connString);
                    da2.InsertCommand.Parameters.Add("@manufact3", SqlDbType.VarChar).Value = textBox1.Text;
                    da2.InsertCommand.Parameters.Add("@productname3", SqlDbType.VarChar).Value = pronamesub3;
                    da2.InsertCommand.Parameters.Add("@type3", SqlDbType.VarChar).Value = sele3;
                    da2.InsertCommand.Parameters.Add("@price3", SqlDbType.VarChar).Value = price3;
                    da2.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da2.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da2.InsertCommand.Parameters.Add("@date3", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub3,qty4);

                    connString.Open();
                    da2.InsertCommand.ExecuteNonQuery();
                    connString.Close();






                }

                else if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "P";
                    price2 = float.Parse(textBox4.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    sele3 = "Can";
                    price3 = float.Parse(textBox6.Text);
                    pronamesub3 = string.Concat(proname, sele3);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2 + "\r\n" + pronamesub3;
                    MessageBox.Show(p);

                    qty2 = Int32.Parse(textBox7.Text);
                    qty3 = Int32.Parse(textBox8.Text);
                    qty4 = Int32.Parse(textBox10.Text);
                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty2;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty2);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty3);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da2.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact3,@productname3,@type3,@price3,@qty,@amt,@date3)", connString);
                    da2.InsertCommand.Parameters.Add("@manufact3", SqlDbType.VarChar).Value = textBox1.Text;
                    da2.InsertCommand.Parameters.Add("@productname3", SqlDbType.VarChar).Value = pronamesub3;
                    da2.InsertCommand.Parameters.Add("@type3", SqlDbType.VarChar).Value = sele3;
                    da2.InsertCommand.Parameters.Add("@price3", SqlDbType.VarChar).Value = price3;
                    da2.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da2.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da2.InsertCommand.Parameters.Add("@date3", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub3,qty4);

                    connString.Open();
                    da2.InsertCommand.ExecuteNonQuery();
                    connString.Close();






                }

                else if (checkBox1.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "N";
                    price2 = float.Parse(textBox5.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    sele3 = "Can";
                    price3 = float.Parse(textBox6.Text);
                    pronamesub3 = string.Concat(proname, sele3);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2 + "\r\n" + pronamesub3;
                    MessageBox.Show(p);

                    qty2 = Int32.Parse(textBox7.Text);
                    qty3 = Int32.Parse(textBox9.Text);
                    qty4 = Int32.Parse(textBox10.Text);
                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty2;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty2);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty3);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da2.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact3,@productname3,@type3,@price3,@qty,@amt,@date3)", connString);
                    da2.InsertCommand.Parameters.Add("@manufact3", SqlDbType.VarChar).Value = textBox1.Text;
                    da2.InsertCommand.Parameters.Add("@productname3", SqlDbType.VarChar).Value = pronamesub3;
                    da2.InsertCommand.Parameters.Add("@type3", SqlDbType.VarChar).Value = sele3;
                    da2.InsertCommand.Parameters.Add("@price3", SqlDbType.VarChar).Value = price3;
                    da2.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da2.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da2.InsertCommand.Parameters.Add("@date3", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub3,qty4);

                    connString.Open();
                    da2.InsertCommand.ExecuteNonQuery();
                    connString.Close();






                }

                else if (checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
                {
                    sele1 = "P";
                    price1 = float.Parse(textBox4.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "N";
                    price2 = float.Parse(textBox5.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    sele3 = "Can";
                    price3 = float.Parse(textBox6.Text);
                    pronamesub3 = string.Concat(proname, sele3);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2 + "\r\n" + pronamesub3;
                    MessageBox.Show(p);


                    qty2 = Int32.Parse(textBox8.Text);
                    qty3 = Int32.Parse(textBox9.Text);
                    qty4 = Int32.Parse(textBox10.Text);


                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty2;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty2);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty3);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                    da2.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact3,@productname3,@type3,@price3,@qty,@amt,@date3)", connString);
                    da2.InsertCommand.Parameters.Add("@manufact3", SqlDbType.VarChar).Value = textBox1.Text;
                    da2.InsertCommand.Parameters.Add("@productname3", SqlDbType.VarChar).Value = pronamesub3;
                    da2.InsertCommand.Parameters.Add("@type3", SqlDbType.VarChar).Value = sele3;
                    da2.InsertCommand.Parameters.Add("@price3", SqlDbType.VarChar).Value = price3;
                    da2.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da2.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da2.InsertCommand.Parameters.Add("@date3", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub3,qty4);

                    connString.Open();
                    da2.InsertCommand.ExecuteNonQuery();
                    connString.Close();










                }
                /////////////////////////////////////////////////////////////////////////////////////    

                else if (checkBox1.Checked && checkBox2.Checked)
                {

                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "P";
                    price2 = float.Parse(textBox4.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);


                    qty3 = Int32.Parse(textBox7.Text);
                    qty4 = Int32.Parse(textBox8.Text);
                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                }
                else if (checkBox1.Checked && checkBox3.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "N";
                    price2 = float.Parse(textBox5.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);

                    qty3 = Int32.Parse(textBox7.Text);
                    qty4 = Int32.Parse(textBox9.Text);


                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                }
                else if (checkBox1.Checked && checkBox4.Checked)
                {
                    sele1 = "Q";
                    price1 = float.Parse(textBox3.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "Can";
                    price2 = float.Parse(textBox6.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);

                    qty3 = Int32.Parse(textBox7.Text);
                    qty4 = Int32.Parse(textBox10.Text);

                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                }
                else if (checkBox2.Checked && checkBox3.Checked)
                {
                    sele1 = "P";
                    price1 = float.Parse(textBox4.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "N";
                    price2 = float.Parse(textBox5.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);

                    qty3 = Int32.Parse(textBox8.Text);
                    qty4 = Int32.Parse(textBox9.Text);

                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                }
                else if (checkBox2.Checked && checkBox4.Checked)
                {
                    sele1 = "P";
                    price1 = float.Parse(textBox4.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "Can";
                    price2 = float.Parse(textBox6.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);

                    qty3 = Int32.Parse(textBox8.Text);
                    qty4 = Int32.Parse(textBox10.Text);

                    //manu1 = textBox1.Text;
                    //manu2 = textBox1.Text;
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1,qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();


                }
                else if (checkBox3.Checked && checkBox4.Checked)
                {
                    sele1 = "N";
                    price1 = float.Parse(textBox5.Text);
                    pronamesub1 = string.Concat(proname, sele1);

                    sele2 = "Can";
                    price2 = float.Parse(textBox6.Text);
                    pronamesub2 = string.Concat(proname, sele2);

                    string p;
                    p = pronamesub1 + "\r\n" + pronamesub2;
                    MessageBox.Show(p);


                    qty3 = Int32.Parse(textBox9.Text);
                    qty4 = Int32.Parse(textBox10.Text);

                    
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact1,@productname1,@type1,@price1,@qty,@amt,@date1)", connString);
                    da.InsertCommand.Parameters.Add("@manufact1", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname1", SqlDbType.VarChar).Value = pronamesub1;
                    da.InsertCommand.Parameters.Add("@type1", SqlDbType.VarChar).Value = sele1;
                    da.InsertCommand.Parameters.Add("@price1", SqlDbType.VarChar).Value = price1;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty3;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date1", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub1, qty3);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                    da1.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact2,@productname2,@type2,@price2,@qty,@amt,@date2)", connString);
                    da1.InsertCommand.Parameters.Add("@manufact2", SqlDbType.VarChar).Value = textBox1.Text;
                    da1.InsertCommand.Parameters.Add("@productname2", SqlDbType.VarChar).Value = pronamesub2;
                    da1.InsertCommand.Parameters.Add("@type2", SqlDbType.VarChar).Value = sele2;
                    da1.InsertCommand.Parameters.Add("@price2", SqlDbType.VarChar).Value = price2;
                    da1.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qty4;
                    da1.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da1.InsertCommand.Parameters.Add("@date2", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub2,qty4);

                    connString.Open();
                    da1.InsertCommand.ExecuteNonQuery();
                    connString.Close();
                }


/////////////////////////////////////////////////////////////////////////////
                else if (checkBox1.Checked)
                {
                    typeselect = "Q";
                    pricesele = float.Parse(textBox3.Text);
                    pronamesub = string.Concat(proname, typeselect);
                    MessageBox.Show(pronamesub);
                    
                    qtyy = Int32.Parse(textBox7.Text);
                    //qtyy = "";
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact,@productname,@type,@price,@qty,@amt,@date)", connString);
                    da.InsertCommand.Parameters.Add("@manufact", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = pronamesub;
                    da.InsertCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = typeselect;
                    da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = pricesele;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qtyy;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub, qtyy);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();
                }
                else if (checkBox2.Checked)
                {
                    typeselect = "P";
                    pricesele = float.Parse(textBox4.Text);
                    pronamesub = string.Concat(proname, typeselect);
                    MessageBox.Show(pronamesub);
                    
                    qtyy = Int32.Parse(textBox8.Text);
                    //qtyy = "";
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact,@productname,@type,@price,@qty,@amt,@date)", connString);
                    da.InsertCommand.Parameters.Add("@manufact", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = pronamesub;
                    da.InsertCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = typeselect;
                    da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = pricesele;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qtyy;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub, qtyy);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();
                }
                else if (checkBox3.Checked)
                {
                    typeselect = "N";
                    pricesele = float.Parse(textBox5.Text);
                    pronamesub = string.Concat(proname, typeselect);
                    MessageBox.Show(pronamesub);
                    qtyy = Int32.Parse(textBox9.Text);
                    //qtyy = "";
                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact,@productname,@type,@price,@qty,@amt,@date)", connString);
                    da.InsertCommand.Parameters.Add("@manufact", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = pronamesub;
                    da.InsertCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = typeselect;
                    da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = pricesele;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qtyy;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub, qtyy);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                }
                else if (checkBox4.Checked)
                {
                    typeselect = "Can";
                    pricesele = float.Parse(textBox6.Text);
                    pronamesub = string.Concat(proname, typeselect);
                    MessageBox.Show(pronamesub);
                    qtyy = Int32.Parse(textBox10.Text);
                    //qtyy = "";

                    da.InsertCommand = new SqlCommand("insert into product(manufact,productname,type,price,qty,amt,date)values (@manufact,@productname,@type,@price,@qty,@amt,@date)", connString);
                    da.InsertCommand.Parameters.Add("@manufact", SqlDbType.VarChar).Value = textBox1.Text;
                    da.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = pronamesub;
                    da.InsertCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = typeselect;
                    da.InsertCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = pricesele;
                    da.InsertCommand.Parameters.Add("@qty", SqlDbType.VarChar).Value = qtyy;
                    da.InsertCommand.Parameters.Add("@amt", SqlDbType.VarChar).Value = "";
                    da.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = DateTime.Now.ToShortDateString();

                    storedb(pronamesub,qtyy);

                    connString.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    connString.Close();

                }

                //////////////////////////////////////////////////////////////////////                

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();


                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }






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
              


                connString.Close();
            }
            catch (FormatException fe)
            {

                MessageBox.Show(fe.ToString());


                connString.Close();
            }

            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                connString.Close();
            }
            //----------------------------------------




        }


        public void storedb(string productname1,int quantity)
        {
            string proname = productname1;
            int qty = quantity;
            int salezero = 0;
            float inistock = float.Parse(qty.ToString());

            da4.InsertCommand = new SqlCommand("insert into stocktable(productname,initialstock,salesstock,invoicestock	,balancestock)values (@productname,@initialstock,@salesstock,@invoicestock,@balancestock)", connString);

            da4.InsertCommand.Parameters.Add("@productname", SqlDbType.VarChar).Value = productname1;
            da4.InsertCommand.Parameters.Add("@initialstock", SqlDbType.VarChar).Value = inistock;
            da4.InsertCommand.Parameters.Add("@salesstock", SqlDbType.VarChar).Value = salezero;
            da4.InsertCommand.Parameters.Add("@invoicestock", SqlDbType.VarChar).Value = salezero;
            da4.InsertCommand.Parameters.Add("@balancestock", SqlDbType.VarChar).Value = inistock;
            

            connString.Open();
            da4.InsertCommand.ExecuteNonQuery();
            connString.Close();
 
        }

       
       
    }
}
