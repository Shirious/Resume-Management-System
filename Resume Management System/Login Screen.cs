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
    public partial class Login_Screen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");

        public Login_Screen()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Enter Your Username")
            {
                txt_username.Clear();
            }
            
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Enter Your Password")
            {
                txt_password.Clear();
                txt_password.PasswordChar = '*' ;
                btn_pass_show.Text = "Show";
            }
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_username.Text = "Enter Your Username";
            txt_password.Text = "Enter Your Password";
            txt_password.PasswordChar = '\0';
            btn_pass_show.Text = "Hide";
        }

        private void btn_pass_show_Click(object sender, EventArgs e )
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
                btn_pass_show.Text = "Hide";
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn_pass_show.Text = "Show";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text == "" || txt_username.Text == "Enter Your Username" ) && (txt_password.Text == "" || txt_password.Text == "Enter Your Password"))
            {
                MessageBox.Show("Please Enter Username and Password");
            }
            else if (txt_username.Text == "" || txt_username.Text == "Enter Your Username")
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (txt_password.Text == "" || txt_password.Text == "Enter Your Password")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if ( txt_username.Text != "Enter Your Username" && txt_password.Text != "Enter Your Password")
            {
                SqlCommand cmd;
                Boolean isAdmin = false ;
                try
                {
                    cmd = new SqlCommand("Select * from Login_Details where username = @username and password = @password and designation = 'admin' ", con);
                    isAdmin = true;
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    cmd = new SqlCommand("Select * from Login_Details where username = @username and password = @password ", con);
                    isAdmin = false;
                }
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader dr = cmd.ExecuteReader();

                if (chkbx_isAdmin.Checked == true && isAdmin == false)
                {
                    MessageBox.Show("You are not Admin !!!");
                }
                else if (dr.HasRows)
                {
                    //MessageBox.Show(isAdmin.ToString());
                    User_Home ah = new User_Home(isAdmin);
                    this.Visible = false;
                    ah.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password !!!");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Username and Password");
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (btn_pass_show.Text != "Show")
            {
                txt_password.PasswordChar = '*';
                btn_pass_show.Text = "Show";
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
