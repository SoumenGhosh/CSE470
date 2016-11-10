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
    public partial class SELL : Form
    {
        
        public SELL()
        {
            InitializeComponent();
        }


        private void SELL_Load(object sender, EventArgs e)
        {

        }
        
        MySqlConnection product_mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand product_mcd;

        String product_id, sell_price, quantity, date, employee_id;

        String price_for_debit,price_from_debit,sum_of_the_debit,price_from_credit;
       

        
        private void SELL_OK_Click(object sender, EventArgs e)
        {
            product_id = SELL_PRODUCT_ID.Text;
            sell_price = SELL_PRICE.Text;
            quantity = SELL_QUANTITY.Text;
            date = SELL_DATE_BOX.Text;
            employee_id = SELL_EMPLOYEE_ID.Text;

            String q = "insert into 370_project.sell_info  (SID,S_PRICE,S_QUANTITY,DATETIME,S_UID) VALUES ('" + product_id + "','" + sell_price + "','" + quantity + "','" + date + "','" + employee_id +"'  )";

            ExecuteQuery(q);
           
           


            //Reading the last information from sell table to add in the Debit table
         ////   MySqlCommand cmd = new MySqlCommand("select * from 370_project.sell_info", product_mcon);
           // MySqlDataReader reader = cmd.ExecuteReader();
          // 
         //   while (reader.Read()) {
        //        price_for_debit = reader.GetString("S_PRICE");
     
       //     }
      //      reader.Close();
         //   product_mcon.Close();


            //Reading the last information from Deposit Table to add in the Debit table 
        //    MySqlCommand cmd2 = new MySqlCommand("select * from 370_project.deposit", product_mcon);
          //  MySqlDataReader reader2 = cmd2.ExecuteReader();
         //   while (reader2.Read())
       //     {
        //        price_from_debit = reader2.GetString("DEBIT");
       //         price_from_credit = reader2.GetString("CREDIT");
               
        //    }
       //     reader2.Close();
       //     product_mcon.Close();
//


            //Adding "price_for_debit" & "price_from_debit" to update the debit table 
            
           // int quantity_Integer = Convert.ToInt32(quantity);
           // double price_for_debit_Integer = Convert.ToDouble(price_for_debit);
          // double  price_from_debit_Integer = Convert.ToDouble(price_from_debit);
         //  double  price_from_credit_Integer = Convert.ToDouble(price_from_credit);
            
          //  double sum_result_debit = (price_for_debit_Integer*quantity_Integer) + price_from_debit_Integer;
         //   double sum_result_credit = (price_from_credit_Integer) - (price_for_debit_Integer * quantity_Integer);
         //   double profit;
          //  profit = sum_result_debit - sum_result_credit;

           

            //Update deposit table 



          //  String q2 = "insert into 370_project.deposit (CREDIT,DEBIT,PROFIT,DATETIME) VALUES ('" + sum_result_credit + "','" + sum_result_debit + "','"+profit+"','" + date + "')";
            
          //  ExecuteQuery(q2);
            
            
            product_mcon.Close();
         //   reader2.Close();

            quanity();

            deposit();


        }


        
















        public void deposit() {
            String id = SELL_PRODUCT_ID.Text;
            String datetime = SELL_DATE_BOX.Text;
            String sell_debit_price=null,sell_debit_quantity=null, sell_debit_id=null;
            String buy_credit_price=null, buy_credit_quantity=null,buy_credit_id=null;
            

            MySqlCommand cmd4 = new MySqlCommand("select * from 370_project.buy_info", product_mcon);
            product_mcon.Open();
            MySqlDataReader reader4 = cmd4.ExecuteReader();

            //temp credit
            String temp_buy_credit_price = null, temp_buy_credit_quantity = null;

            while (reader4.Read()) {
                buy_credit_price = reader4.GetString("B_PRICE");
                buy_credit_quantity = reader4.GetString("B_QUANTITY");
                buy_credit_id = reader4.GetString("BID");
                if (buy_credit_id.Equals(id)) {
                    temp_buy_credit_price = buy_credit_price;
                    temp_buy_credit_quantity = buy_credit_quantity;
                }
            }
            reader4.Close();
            product_mcon.Close();





            MySqlCommand cmd5 = new MySqlCommand("select * from 370_project.sell_info", product_mcon);
            product_mcon.Open();
            MySqlDataReader reader5 = cmd5.ExecuteReader();

            //temp debit
            String temp_sell_debit_price = null, temp_sell_debit_quantity = null;
            while (reader5.Read())
            {
                sell_debit_price = reader5.GetString("S_PRICE");
                sell_debit_quantity = reader5.GetString("S_QUANTITY");
                sell_debit_id = reader5.GetString("SID");
                if (sell_debit_id.Equals(id))
                {
                    temp_sell_debit_price = sell_debit_price;
                    temp_sell_debit_quantity = sell_debit_quantity;
                   
                }
            }
            reader5.Close();
            product_mcon.Close();



            double temp_buy_credit_Integer = Convert.ToDouble(buy_credit_price);
            double temp_sell_debit_Integer = Convert.ToDouble(sell_debit_price);
            int  temp_sell_quantity_Integer = Convert.ToInt32(sell_debit_quantity);
            double profit_result = (temp_sell_debit_Integer - temp_buy_credit_Integer) * temp_sell_quantity_Integer;

            MessageBox.Show(" "+profit_result);


            String q = "insert into 370_project.deposit(P_ID,D_QUANTITY,CREDIT,DEBIT,PROFIT,DATETIME) VALUES ('"+id+ "','" + quantity + "', '" + temp_buy_credit_Integer + "','"+ temp_sell_debit_Integer + "','"+ profit_result + "','"+datetime+"')";
            ExecuteQuery(q);
            product_mcon.Close();

        }












        public void quanity() {
            MySqlCommand cmd3 = new MySqlCommand("select * from 370_project.product", product_mcon);
            product_mcon.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();

            String pid_from_product_table, quantity_from_prouct_table = null;

            String pid = SELL_PRODUCT_ID.Text;
            String quantity = SELL_QUANTITY.Text;
            int updated_quantity_for_product_table;

            while (reader3.Read())
            {
                pid_from_product_table = reader3.GetString("PID");
                quantity_from_prouct_table = reader3.GetString("QUANTITY");
                if (pid_from_product_table.Equals(pid))
                {

                    break;

                }


            }

            reader3.Close();
            product_mcon.Close();


            int quantity_from_product_table_Integer = Convert.ToInt32(quantity_from_prouct_table);
            int new_quantity = Convert.ToInt32(quantity);
            updated_quantity_for_product_table = quantity_from_product_table_Integer - new_quantity;


            String q3 = "update 370_project.product SET QUANTITY ='" + updated_quantity_for_product_table + "' WHERE PID='" + pid + "' ";
            ExecuteQuery(q3);
            product_mcon.Close();

        }





        public void debit() {

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

        private void SELL_PRODUCT_ID_TextChanged(object sender, EventArgs e)
        {

        }





   






    }
}
