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
    public partial class ADMIN_REGISTER : Form
    {
        public ADMIN_REGISTER()
        {
            InitializeComponent();
        }

        String reg_id = null, reg_password=null, reg_type=null;

        MySqlConnection product_mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand product_mcd;







        private void USER_REGISTRATION_BUTTON_Click(object sender, EventArgs e)
        {
            reg_id = USER_REGISTRATION_ID.Text;
            reg_password = USER_REGISTRATION_PASSWORD.Text;
            reg_type = USER_REGISTRATION_TYPE.Text;

            String q = "insert into 370_project.employee(USER_ID,USER_PASSWORD,E_TYPE) VALUES('"+reg_id+"','"+reg_password+"','"+reg_type+"')";
            ExecuteQuery(q);
            product_mcon.Close();
        }

        private void USER_REGISTRATION_ID_TextChanged(object sender, EventArgs e)
        {

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




    }
}
