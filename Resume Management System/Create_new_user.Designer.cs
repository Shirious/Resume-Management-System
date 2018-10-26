namespace Resume_Management_System
{
    partial class Create_new_user
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password_c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbx_isAdmin = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_show_p = new System.Windows.Forms.Button();
            this.btn_show_cp = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Login User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username\r\n";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(267, 204);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(398, 31);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Set Password";
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txt_password_c
            // 
            this.txt_password_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_c.Location = new System.Drawing.Point(267, 270);
            this.txt_password_c.Name = "txt_password_c";
            this.txt_password_c.Size = new System.Drawing.Size(398, 31);
            this.txt_password_c.TabIndex = 4;
            this.txt_password_c.Text = "Retype to Confirm Password";
            this.txt_password_c.Click += new System.EventHandler(this.txt_password_c_Click);
            this.txt_password_c.TextChanged += new System.EventHandler(this.txt_password_c_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // chkbx_isAdmin
            // 
            this.chkbx_isAdmin.AutoSize = true;
            this.chkbx_isAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkbx_isAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_isAdmin.Location = new System.Drawing.Point(267, 337);
            this.chkbx_isAdmin.Name = "chkbx_isAdmin";
            this.chkbx_isAdmin.Size = new System.Drawing.Size(145, 28);
            this.chkbx_isAdmin.TabIndex = 6;
            this.chkbx_isAdmin.Text = "Make Admin";
            this.chkbx_isAdmin.UseVisualStyleBackColor = false;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(267, 419);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(145, 43);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_show_p
            // 
            this.btn_show_p.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show_p.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_p.Location = new System.Drawing.Point(688, 200);
            this.btn_show_p.Name = "btn_show_p";
            this.btn_show_p.Size = new System.Drawing.Size(90, 37);
            this.btn_show_p.TabIndex = 3;
            this.btn_show_p.Text = "Hide";
            this.btn_show_p.UseVisualStyleBackColor = false;
            this.btn_show_p.Click += new System.EventHandler(this.btn_show_p_Click);
            // 
            // btn_show_cp
            // 
            this.btn_show_cp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_show_cp.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_cp.Location = new System.Drawing.Point(688, 267);
            this.btn_show_cp.Name = "btn_show_cp";
            this.btn_show_cp.Size = new System.Drawing.Size(90, 37);
            this.btn_show_cp.TabIndex = 5;
            this.btn_show_cp.Text = "Hide";
            this.btn_show_cp.UseVisualStyleBackColor = false;
            this.btn_show_cp.Click += new System.EventHandler(this.btn_show_cp_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(267, 134);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(398, 31);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Enter New User Username";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(480, 419);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(145, 43);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(674, 419);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(145, 43);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Create_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 479);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_show_cp);
            this.Controls.Add(this.btn_show_p);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.chkbx_isAdmin);
            this.Controls.Add(this.txt_password_c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create_new_user";
            this.Text = "Create New Login User Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password_c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbx_isAdmin;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_show_p;
        private System.Windows.Forms.Button btn_show_cp;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}