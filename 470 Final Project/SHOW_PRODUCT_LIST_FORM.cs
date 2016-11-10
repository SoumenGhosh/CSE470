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
    public partial class SHOW_PRODUCT_LIST_FORM : Form
    {




        


        public SHOW_PRODUCT_LIST_FORM()
        {
            InitializeComponent();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlCommand cmd = new MySqlCommand("select * from 370_project.product", mcon);
            mcon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            String s;
            while (reader.Read())
            {
                s = reader.GetString("MODEL");
                MessageBox.Show(s);
                

            }
            

        }
    }
}
