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
    public partial class Delete_Login_User_Data : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");

        public Delete_Login_User_Data()
        {
            InitializeComponent();
           
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text == "" || txt_username.Text == "Enter Username") && (txt_password.Text == "" || txt_password.Text == "Enter Password"))
            {
                MessageBox.Show("Please Fill the Form");
            }
            else if (txt_username.Text == "" || txt_username.Text == "Enter Username")
            {
                MessageBox.Show("Please Enter Username of User whose data to be updated");
            }
            else if (txt_password.Text == "" || txt_password.Text == "Enter Password")
            {
                MessageBox.Show("Please Enter User  Password");
            }
            else
            {
                SqlCommand cmd , cmd1 ;
                cmd = new SqlCommand("Select * from Login_Details where username = @username", con);
                cmd1 = new SqlCommand("Delete Login_Details where username = @username and password = @password ", con);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    cmd1.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd1.Parameters.AddWithValue("@password", txt_password.Text);
                    con.Close();
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Deleted !!!");
                }
                else
                {
                    MessageBox.Show("User Does Not Exist or Incorrect Password !!!");
                    con.Close();
                }
                btn_clear_Click(sender, e);
            }
        }

        private void Delete_Login_User_Data_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "Enter Username";
            txt_password.Text = "Enter Password";
            txt_password.PasswordChar = '\0';
            btn_show_p.Text = "Hide";
            chkbx_revoke.Checked = false;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (btn_show_p.Text == "Hide")
            {
                txt_password.PasswordChar = '*';
                btn_show_p.Text = "Show";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Home ah = new User_Home(true);
            ah.Show();
            this.Visible = false;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Enter Password")
            {
                txt_password.Clear();
            }
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Enter Username")
            {
                txt_username.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Login_Details where username = @username and designation = 'admin' ", con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (chkbx_revoke.Checked)
                {
                    if (txt_username.Text == "" || txt_username.Text == "Enter Username")
                    {
                        MessageBox.Show("Please Enter Username of User whose data to be updated");
                    }
                    else
                    {
                       
                        con.Close();
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("Update Login_Details set designation = 'user' where username = @username ", con);
                        cmd1.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Admin permission revoked for " + txt_username.Text + " ");
                        btn_clear_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("User Does Not Exist or Not Admin !!!");
                btn_clear_Click(sender, e);
            }
            con.Close();
        }
    }
    
}
