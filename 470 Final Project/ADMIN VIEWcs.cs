using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _370_Final_Project
{
    public partial class ADMIN_VIEWcs : Form
    {
        public ADMIN_VIEWcs()
        {
            InitializeComponent();
        }

        private void ADMIN_VIEWcs_Load(object sender, EventArgs e)
        {

        }




        //VIEW PRODUCT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from 370_project.product", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "product");
            dataGridView1.DataSource = ds.Tables["product"];

            mcon.Close();
        }

        //VIEW BUY INFO
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from 370_project.buy_info", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "buy_info");
            dataGridView1.DataSource = ds.Tables["buy_info"];

            mcon.Close();
        }



        //VIEW SELL INFO
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from 370_project.sell_info", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "sell_info");
            dataGridView1.DataSource = ds.Tables["sell_info"];

            mcon.Close();
        }



        //VIEW DEPOSIT INFO
        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from 370_project.deposit", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "deposit");
            dataGridView1.DataSource = ds.Tables["deposit"];

            mcon.Close();
        }
        //ADD PRODUCTS
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void ADMIN_SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            ADMIN_REGISTER ar = new ADMIN_REGISTER();
            ar.Show();
        }
    }
}
