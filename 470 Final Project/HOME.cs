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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }


        MySqlConnection product_mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        MySqlCommand product_mcd;
        String login_id = null, login_password = null;


















        private void MANAGER_BUTTON_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from 370_project.employee", product_mcon);


            product_mcon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            login_id = USER_LOGIN_ID.Text;
            login_password = USER_LOGIN_PASSWORD.Text;
            String type ="manager";
            int msg= 0;

            while (reader.Read())
            {
                if (login_id.Equals(reader.GetString("USER_ID")) && login_password.Equals(reader.GetString("USER_PASSWORD")) && type.Equals(reader.GetString("E_TYPE")))
                {

                    Form1 f = new Form1();
                    f.Show();
                    msg = 1;
                    break;

                }

            }

            MessageBox.Show(msg==1?"WELCOME":"LOGIN ERROR");
            reader.Close();
            product_mcon.Close();

        }

        private void OTHERS_BUTTON_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from 370_project.employee", product_mcon);


            product_mcon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            login_id = USER_LOGIN_ID.Text;
            login_password = USER_LOGIN_PASSWORD.Text;
            String type = "others";
            int msg = 0;
            while (reader.Read())
            {
                if (login_id.Equals(reader.GetString("USER_ID")) && login_password.Equals(reader.GetString("USER_PASSWORD")) && type.Equals(reader.GetString("E_TYPE")))
                {
                    msg = 1;
                    OTHERS o = new OTHERS();
                    o.Show();
                    break;
                }

            }
            MessageBox.Show(msg == 1 ? "WELCOME" : "LOGIN ERROR");
            reader.Close();
            product_mcon.Close();

        }







        private void ADMIN_BUTTON_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from 370_project.employee", product_mcon);


            product_mcon.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            login_id = USER_LOGIN_ID.Text;
            login_password = USER_LOGIN_PASSWORD.Text;
            String type = "admin";
            int msg = 0;

            while (reader.Read())
            {
                if (login_id.Equals(reader.GetString("USER_ID")) && login_password.Equals(reader.GetString("USER_PASSWORD")) && type.Equals(reader.GetString("E_TYPE")) )
                {
                    msg = 1;
                    ADMIN_VIEWcs a = new ADMIN_VIEWcs();
                    a.Show();
                    break;
                }

            }
            MessageBox.Show(msg == 1 ? "WELCOME" : "LOGIN ERROR");
            reader.Close();
            product_mcon.Close();

        }
    }
}

