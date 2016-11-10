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
    public partial class SEARCH : Form
    {
        public SEARCH()
        {
            InitializeComponent();
        }

        MySqlConnection product_mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand product_mcd;

        String by_brand, by_model, by_cat,min_price,max_price;

      

        double min_price_Integer, max_price_Integer;


        private void BY_BRAND_Click(object sender, EventArgs e)
        {
            by_brand = SEARCH_NAME.Text;
            min_price = SEARCH_MIN_PRICE.Text;
            max_price = SEARCH_MAX_PRICE.Text;
            min_price_Integer = Convert.ToDouble(min_price);
            max_price_Integer = Convert.ToDouble(max_price);
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
                MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE BRAND='"+by_brand+"' AND PRICE BETWEEN '"+min_price_Integer+"' AND '"+max_price_Integer+"'  ", mcon);
           // MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE BRAND='" + by_brand + "' ", mcon);

        mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "product");
            SEARCH_VIEW.DataSource = ds.Tables["product"];

            mcon.Close();
        }

        //BY MODEL BUTTON SEARCH
        private void button1_Click(object sender, EventArgs e)
        {
            by_model = SEARCH_NAME.Text;
            min_price = SEARCH_MIN_PRICE.Text;
            max_price = SEARCH_MAX_PRICE.Text;
            min_price_Integer = Convert.ToDouble(min_price);
            max_price_Integer = Convert.ToDouble(max_price);
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE MODEL='" + by_model + "' AND PRICE BETWEEN '" + min_price_Integer + "' AND '" + max_price_Integer + "'  ", mcon);
            // MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE BRAND='" + by_brand + "' ", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "product");
            SEARCH_VIEW.DataSource = ds.Tables["product"];

            mcon.Close();
        }
        
        
        
        //BY CATAGORY
        private void button2_Click(object sender, EventArgs e)
        {
            by_cat = SEARCH_NAME.Text;
            min_price = SEARCH_MIN_PRICE.Text;
            max_price = SEARCH_MAX_PRICE.Text;
            min_price_Integer = Convert.ToDouble(min_price);
            max_price_Integer = Convert.ToDouble(max_price);
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
            MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE CATAGORY='" + by_cat + "' AND PRICE BETWEEN '" + min_price_Integer + "' AND '" + max_price_Integer + "'  ", mcon);
            // MySqlDataAdapter mda = new MySqlDataAdapter("SELECT * from 370_project.product WHERE BRAND='" + by_brand + "' ", mcon);

            mcon.Open();
            DataSet ds = new DataSet();
            mda.Fill(ds, "product");
            SEARCH_VIEW.DataSource = ds.Tables["product"];

            mcon.Close();
        }


        private void SEARCH_NAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
