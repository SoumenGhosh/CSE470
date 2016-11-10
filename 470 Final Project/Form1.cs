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
   
    public partial class Form1 : Form
    {

        MySqlConnection product_mcon= new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand product_mcd;




        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_PRODUCT_Click(object sender, EventArgs e)
        {
            String pid = PID.Text;
            String price = PRICE.Text;
            String model = MODEL.Text;
            String brand = BRAND.Text;
            String description = DESCRIPTION.Text;
            String image = IMAGE.Text;
            String category = CATEGORY.Text;
            String type = TYPE.Text;
            String quantity = QUANTITY.Text;
            String datetime = DATETIME.Text;

           
                String q = "insert into 370_project.product  (PID,PRICE,MODEL,BRAND,DESCRIPTION,IMAGE,CATAGORY,TYPE,QUANTITY) VALUES ('" + pid + "','" + price + "','" + model + "','" + brand + "','" + description + "','" + image + "','" + category + "','" + type + "','" + quantity + "'  )";

                ExecuteQuery(q);
                product_mcon.Close();
            
          //BUY_INFO
            String q2 = "insert into 370_project.buy_info(BID,B_PRICE,B_QUANTITY,B_DATETIME) VALUES ('" + pid + "','" + price + "','" + quantity + "','" + datetime + "')";
            ExecuteQuery(q2);
            product_mcon.Close();
           
        }

        //Quantity update method 




        private void UPDATE_PRODUCT_Click(object sender, EventArgs e)

        {
            MySqlCommand cmd3 = new MySqlCommand("select * from 370_project.product", product_mcon);
            product_mcon.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();

            String pid_from_product_table, quantity_from_prouct_table= null;
            
            String pid = PID.Text;
            String quantity = QUANTITY.Text;
            int updated_quantity_for_product_table;

            while (reader3.Read()) {
                pid_from_product_table = reader3.GetString("PID");
                quantity_from_prouct_table = reader3.GetString("QUANTITY");
                if (pid_from_product_table.Equals(pid))
                {
                 
                    break;

                }


            }
           
            reader3.Close();
            product_mcon.Close();

.
            int quantity_from_product_table_Integer = Convert.ToInt32(quantity_from_prouct_table);
            int new_quantity = Convert.ToInt32(quantity);
            updated_quantity_for_product_table = quantity_from_product_table_Integer + new_quantity;

            
            String q3 = "update 370_project.product SET QUANTITY ='" + updated_quantity_for_product_table + "' WHERE PID='" + pid + "' ";
            ExecuteQuery(q3);
            product_mcon.Close();

        }

        
        
        public void ExecuteQuery(String q)
        {

            try
            {
                product_mcon.Open();
                product_mcd = new MySqlCommand(q, product_mcon);
                if (product_mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            SHOW_PRODUCT_LIST_FORM s = new SHOW_PRODUCT_LIST_FORM();
            s.Show();
        }

        private void SEARCH_BUTTON_Click(object sender, EventArgs e)
        {
            SEARCH s = new SEARCH();
            s.Show();
            
        }
    }



}
