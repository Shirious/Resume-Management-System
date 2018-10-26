namespace Resume_Management_System
{
    partial class Update_Login_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_show_p = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.chkbx_isAdmin = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(647, 458);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(145, 43);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(453, 458);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(145, 43);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(240, 113);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(398, 31);
            this.txt_username.TabIndex = 11;
            this.txt_username.Text = "Enter Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // btn_show_p
            // 
            this.btn_show_p.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show_p.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_p.Location = new System.Drawing.Point(663, 351);
            this.btn_show_p.Name = "btn_show_p";
            this.btn_show_p.Size = new System.Drawing.Size(90, 37);
            this.btn_show_p.TabIndex = 14;
            this.btn_show_p.Text = "Hide";
            this.btn_show_p.UseVisualStyleBackColor = false;
            this.btn_show_p.Click += new System.EventHandler(this.btn_show_p_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(240, 458);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(145, 43);
            this.btn_create.TabIndex = 20;
            this.btn_create.Text = "Update";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // chkbx_isAdmin
            // 
            this.chkbx_isAdmin.AutoSize = true;
            this.chkbx_isAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkbx_isAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_isAdmin.Location = new System.Drawing.Point(242, 305);
            this.chkbx_isAdmin.Name = "chkbx_isAdmin";
            this.chkbx_isAdmin.Size = new System.Drawing.Size(145, 28);
            this.chkbx_isAdmin.TabIndex = 19;
            this.chkbx_isAdmin.Text = "Make Admin";
            this.chkbx_isAdmin.UseVisualStyleBackColor = false;
            this.chkbx_isAdmin.CheckedChanged += new System.EventHandler(this.chkbx_isAdmin_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(242, 355);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(398, 31);
            this.txt_password.TabIndex = 13;
            this.txt_password.Text = "Change Password";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update Login User Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 35);
            this.label5.TabIndex = 26;
            this.label5.Text = "New User Data";
            // 
            // Update_Login_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_show_p);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.chkbx_isAdmin);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Login_User";
            this.Text = "Update Login User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Update_Login_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_show_p;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox chkbx_isAdmin;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}