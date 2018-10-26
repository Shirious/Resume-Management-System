using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SqlClient;

namespace Resume_Management_System
{
    public partial class User_Home : Form
    {
        Image DefaultImage ;
        public int ID = 0 ;
        Byte[] ImageByteArray;
        string strFilePath = "" ;
        int val;
        string[] temp;
        string tempstr;
        

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Shreyas\\Documents\\Projects\\Resume Management System\\Resume Management System\\Resume_Management_DB.mdf';Integrated Security=True");

        public User_Home(bool isAdmin)
        {
           
            InitializeComponent();

            adminToolStripMenuItem.Visible = isAdmin ;
            DefaultImage = pbx_user_image.Image;
        }

        private void User_Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resume_Management_DBDataSet2.ResumeTable' table. You can move, or remove it, as needed.
            this.resumeTableTableAdapter.Fill(this.resume_Management_DBDataSet2.ResumeTable);
            
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_generate_resume.Enabled = false;

            refreshToolStripMenuItem_Click(sender , e);


        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_new_user cr = new Create_new_user();
            cr.Show();
            this.Visible = false;
        }

        private void aboutTheDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resume_Software_About_Box ab = new Resume_Software_About_Box();
            ab.Show();
        }

        private void updateUserDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Login_User ah = new Update_Login_User();
            ah.Show();
            this.Visible = false;
        }

       

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Login_User_Data ah = new Delete_Login_User_Data();
            ah.Show();
            this.Visible = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Screen ah = new Login_Screen();
            ah.Show();
            this.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_qualification.Text.Trim() != "")
            {
                qualList.Items.Add(txt_qualification.Text.ToString());
                qualList.Refresh();
                txt_qualification.Clear();
            }
        }

        private void txt_qualification_Enter(object sender, EventArgs e)
        {
            
        }

        private void qualList_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_qualification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_hobby_Click(sender, e);   
            }
        }

        private void btn_hobby_Click(object sender, EventArgs e)
        {
            if (txt_hobby.Text.Trim() != "")
            {
                hobbyList.Items.Add(txt_hobby.Text.ToString());
                hobbyList.Refresh();
                txt_hobby.Clear();
            }
        }

        private void qualList_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void qualList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DialogResult x = MessageBox.Show("Do you want to delete Selected Qualification  from the list ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x.Equals(DialogResult.Yes))
                {
                    qualList.Items.Remove(qualList.Items[qualList.SelectedIndex]);
                }
            }
        }

        private void hobbyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hobbyList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DialogResult x = MessageBox.Show("Do you want to delete Selected Hobby from the list ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x.Equals(DialogResult.Yes))
                {
                    hobbyList.Items.Remove(hobbyList.Items[hobbyList.SelectedIndex]);
                }
            }
        }

        private void trkbr_age_Scroll(object sender, EventArgs e)
        {
            lbl_age.Text = trkbr_age.Value.ToString() ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.* ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                pbx_user_image.Image = new Bitmap(strFilePath);

            }
        }

        private bool FormIsFilled()
        {
            if (txt_fullname.Text.Trim() == ""  || cmbx_gender.Text.Trim() == "" || lbl_age.Text == "Age" || qualList.Items.Count == 0 || hobbyList.Items.Count == 0 ||  pbx_user_image.Image.Equals(DefaultImage) )
            {
                string msg = "";
                int i = 0;
                if(txt_fullname.Text.Trim() == "")
                {
                    i++;
                    msg += i.ToString() + ". Fill Full Name\n";
                }
                if (lbl_age.Text == "Age")
                {
                    i++;
                    msg += i.ToString() + ". Scroll Age\n";
                }
                if (cmbx_gender.Text.Trim() == "")
                {
                    i++;
                    msg += i.ToString() + ". Choose Gender\n";
                }
                if (txt_address.Text.Trim() == "")
                {
                    i++;
                    msg += i.ToString() + ". Fill Address\n";
                }
                if(qualList.Items.Count == 0)
                {
                    i++;
                    msg += i.ToString() + ". Fill atleast one Qualification\n";
                }
                if (hobbyList.Items.Count == 0)
                {
                    i++;
                    msg += i.ToString() + ". Fill atleast one Hobby\n";
                }
                if(pbx_user_image.Image.Equals(DefaultImage) )
                {
                    i++;
                    msg += i.ToString() + ". Add an Image\n";
                }
                MessageBox.Show(msg, i.ToString() + " Values missing ...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else
            {
                return true;
            }
        }

        private string GetStringfromListbox(ListBox lbx)
        {
            string output = "";
            int count = lbx.Items.Count;
            for (int i = 0; i< count; i++)
            {
                output += lbx.Items[i].ToString() + " , " ;
            }
            return output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormIsFilled())
            {
                Image temp;
                MemoryStream strm = new MemoryStream();
                temp = pbx_user_image.Image;
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageByteArray = strm.ToArray();
                SqlCommand cmd = new SqlCommand("insert into ResumeTable(full_name , address , age , gender , qualifications , hobbies , image ) values (@full_name , @address , @age , @gender , @qualifications , @hobbies , @image  )", con);
                cmd.Parameters.AddWithValue("@full_name", txt_fullname.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@age", trkbr_age.Value);
                cmd.Parameters.AddWithValue("@gender", cmbx_gender.Text);
                cmd.Parameters.AddWithValue("@image", ImageByteArray);
                cmd.Parameters.AddWithValue("@qualifications", GetStringfromListbox( qualList));
                cmd.Parameters.AddWithValue("@hobbies", GetStringfromListbox( hobbyList));

                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                

                MessageBox.Show("Data Saved !!!");

                refreshToolStripMenuItem_Click(sender, e);
                btn_Clear_Click(sender, e);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_fullname.Clear();
            txt_address.Clear();
            txt_hobby.Clear();
            txt_qualification.Clear();
            cmbx_gender.ResetText();
            trkbr_age.Value = trkbr_age.Minimum ;
            lbl_age.Text = "Age";
            strFilePath = "";
            pbx_user_image.Image = DefaultImage;
            qualList.Items.Clear();
            hobbyList.Items.Clear();
            btn_insert.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_generate_resume.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (FormIsFilled())
            {
                Image temp;
                MemoryStream strm = new MemoryStream();
                temp = pbx_user_image.Image;
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImageByteArray = strm.ToArray();
                SqlCommand cmd = new SqlCommand("Update ResumeTable SET full_name = @full_name , address = @address , age = @age , gender = @gender, qualifications = @qualifications , hobbies = @hobbies, image = @image where ResumeID = "+ID+"", con);
                cmd.Parameters.AddWithValue("@full_name", txt_fullname.Text);
                cmd.Parameters.AddWithValue("@address", txt_address.Text);
                cmd.Parameters.AddWithValue("@age", trkbr_age.Value);
                cmd.Parameters.AddWithValue("@gender", cmbx_gender.Text);
                cmd.Parameters.AddWithValue("@image", ImageByteArray);
                cmd.Parameters.AddWithValue("@qualifications", GetStringfromListbox(qualList));
                cmd.Parameters.AddWithValue("@hobbies", GetStringfromListbox(hobbyList));

                if (con.State == ConnectionState.Closed) con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Updated !!!");

                refreshToolStripMenuItem_Click(sender, e);
                btn_Clear_Click(sender , e);
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void mSAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("msaccess");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void mSExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("excel");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void mSPowerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                string path = Path.Combine(Environment.SystemDirectory, "C:\\Program Files\\GIMP 2\\bin\\gimp-2.10.exe");
                p.StartInfo.FileName = path;
                p.Start();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Winword");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mspaint");
            }
            catch(Exception exp)
            {
                MessageBox.Show("Following Program may not be installed on your computer !!!" , "Notice" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
                Console.WriteLine(exp.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed) con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from ResumeTable" , con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            datadisplay.DataSource = dt;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void datadisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datadisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btn_Clear_Click(sender, e);
            btn_insert.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            btn_generate_resume.Enabled = true;
            int id;
            int.TryParse(datadisplay.CurrentRow.Cells[0].Value.ToString(), out id) ;
            ID = id ;
            txt_fullname.Text = datadisplay.CurrentRow.Cells[1].Value.ToString();
            txt_address.Text = datadisplay.CurrentRow.Cells[2].Value.ToString();
            txt_hobby.Clear();
            txt_qualification.Clear();
            cmbx_gender.Text = datadisplay.CurrentRow.Cells[4].Value.ToString();
            
            int.TryParse(datadisplay.CurrentRow.Cells[3].Value.ToString(), out val );
            if (val >= trkbr_age.Minimum || val <= trkbr_age.Maximum) trkbr_age.Value = val;
            else trkbr_age.Value = trkbr_age.Minimum;
            lbl_age.Text = trkbr_age.Value.ToString() ;
            
            byte[] ImageByteArray = (byte[])datadisplay.CurrentRow.Cells[7].Value;
            pbx_user_image.Image = Image.FromStream(new MemoryStream(ImageByteArray));

            temp = datadisplay.CurrentRow.Cells[5].Value.ToString().Split(" , ".ToCharArray());
            int n = temp.Count();
            for(int i = 0; i< n; i++)
            {
                tempstr = temp[i].ToString().TrimEnd();
                if(tempstr != "") qualList.Items.Add(tempstr);
            }
            temp = datadisplay.CurrentRow.Cells[6].Value.ToString().Split(" , ".ToCharArray());
            int n2 = temp.Count();
            for (int i = 0; i < n2; i++)
            {

                tempstr = temp[i].ToString().TrimEnd();
                if (tempstr != "") hobbyList.Items.Add(tempstr);

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (FormIsFilled())
            {
                SqlCommand cmd = new SqlCommand("Delete from ResumeTable where ResumeID = " + ID + "", con);
               
                DialogResult x = MessageBox.Show("Do you want to delete the Resume Information Permanently ?\n\nRemember it cannot be undone !!!", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (x.Equals(DialogResult.Yes))
                {
                    if(con.State == ConnectionState.Closed )con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


                refreshToolStripMenuItem_Click(sender, e);
                btn_Clear_Click(sender, e);
            }
        }

        private void btn_generate_resume_Click(object sender, EventArgs e)
        {
            ResumeReport rp = new ResumeReport(ID);
            this.Visible = false;
            rp.Show();
        }
    }
}
