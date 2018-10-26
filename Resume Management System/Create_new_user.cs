using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resume_Management_System
{
    public partial class Create_new_user : Form
    {
        public Create_new_user()
        {
            InitializeComponent();
        }

        private void txt_username_Click_1(object sender, EventArgs e)
        {
            if(txt_username.Text == "Enter New User Username")
            {
                txt_username.Clear();
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Set Password")
            {
                txt_password.Clear();
            }
        }

        private void txt_password_c_Click(object sender, EventArgs e)
        {
            if (txt_password_c.Text == "Retype to Confirm Password")
            {
                txt_password_c.Clear();
            }
        }

        private void btn_show_p_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
                btn_show_p.Text = "Hide";
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn_show_p.Text = "Show";
            }
        }

        private void btn_show_cp_Click(object sender, EventArgs e)
        {
            if (txt_password_c.PasswordChar == '*')
            {
                txt_password_c.PasswordChar = '\0';
                btn_show_cp.Text = "Hide";
            }
            else
            {
                txt_password_c.PasswordChar = '*';
                btn_show_cp.Text = "Show";
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if(btn_show_p.Text != "Show")
            {
                txt_password.PasswordChar = '*';
                btn_show_p.Text = "Show";
            }
        }

        private void txt_password_c_TextChanged(object sender, EventArgs e)
        {
            if (btn_show_cp.Text != "Show")
            {
                txt_password_c.PasswordChar = '*';
                btn_show_cp.Text = "Show";
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text == "" || txt_username.Text == "Enter New User Username") && (txt_password.Text == "" || txt_password.Text == "Set Password") && (txt_password_c.Text == "" || txt_password_c.Text == "Retype to Confirm Password"))
            {
                MessageBox.Show("Please Fill the Form");
            }
            else if (txt_username.Text == "" || txt_username.Text == "Enter New User Username")
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (txt_password.Text == "" || txt_password.Text == "Set Password")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (txt_password_c.Text == "" || txt_password_c.Text == "Retype to Confirm Password")
            {
                MessageBox.Show("Please Retype Password");
            }
            else if (txt_username.Text != "Enter Your Username" && txt_password.Text != "Enter Your Password" && txt_password.Text == txt_password_c.Text)
            {
                SqlCommand cmd;
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");
                if (chkbx_isAdmin.Checked)
                {
                    cmd = new SqlCommand("Insert into Login_Details(username,password,designation) values ('"+txt_username.Text+"','"+txt_password.Text+"' ,'admin')",con);
                    MessageBox.Show("Entry Added as Admin");   
                    
                }
                else
                {
                    cmd = new SqlCommand("Insert into Login_Details(username,password,designation) values ('" + txt_username.Text + "','" + txt_password.Text + "','user')",con);
                    MessageBox.Show("Entry Added as User");
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                btn_clear_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Password and Confirm Password Does not Match !!!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "Enter New User Username";
            txt_password.Text = "Set Password";
            txt_password_c.Text = "Retype to Confirm Password";
            btn_show_p.Text = "Hide";
            txt_password.PasswordChar = '\0';
            btn_show_cp.Text = "Hide";
            chkbx_isAdmin.Checked = false; 
            txt_password_c.PasswordChar = '\0';
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Home usr = new User_Home(true);
            usr.Show();
            this.Visible = false;
        }
    }
}
