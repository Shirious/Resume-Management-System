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
    public partial class Update_Login_User : Form
    {
        public Update_Login_User()
        {
            InitializeComponent();
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

        private void btn_show_p_Click(object sender, EventArgs e)
        {
            if(txt_password.PasswordChar == '*')
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_password.PasswordChar = '\0';
            btn_show_p.Text = "Hide";
            chkbx_isAdmin.Checked = false;
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "Enter Username") txt_username.Clear();
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Change Password") txt_password.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Home ah = new User_Home(true);
            ah.Show();
            this.Visible = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_username.Text == "Enter Username")
            {
                MessageBox.Show("Please Enter Username of User whose data to be updated");
            }
            else
            {
                SqlCommand cmd , cmd1 , cmd2 ;
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");
                cmd = new SqlCommand("Select * from Login_Details where username = @username", con);
                cmd2 = new SqlCommand("Update Login_Details set password = @password where username = @username ", con);
                cmd.Parameters.AddWithValue("@username" , txt_username.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (chkbx_isAdmin.Checked)
                    {
                        cmd1 = new SqlCommand("Update Login_Details set designation = 'admin' where username = @username ", con);
        
                    }
                    else
                    {
                        cmd1 = new SqlCommand("Update Login_Details set  designation = 'user' where username = @username ", con);
                    }

                    if (txt_password.Text != "Change Password" || txt_password.Text != "")
                    {
                        con.Close();
                        con.Open();
                        cmd2.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd2.Parameters.AddWithValue("@password", txt_password.Text);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd1.Parameters.AddWithValue("@username", txt_username.Text);
                        con.Close();
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Info Updated !!!");
                    
                }
                else
                {
                    MessageBox.Show("User Does Not Exist !!!");
                    con.Close();
                }
                btn_clear_Click(sender, e);
            }
        }

        private void chkbx_isAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Update_Login_User_Load(object sender, EventArgs e)
        {

        }
    }
}
