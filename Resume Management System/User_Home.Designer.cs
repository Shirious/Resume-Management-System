namespace Resume_Management_System
{
    partial class User_Home
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSPowerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbx_gender = new System.Windows.Forms.ComboBox();
            this.txt_qualification = new System.Windows.Forms.TextBox();
            this.qualList = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_hobby = new System.Windows.Forms.Button();
            this.hobbyList = new System.Windows.Forms.ListBox();
            this.txt_hobby = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbx_user_image = new System.Windows.Forms.PictureBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.trkbr_age = new System.Windows.Forms.TrackBar();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.datadisplay = new System.Windows.Forms.DataGridView();
            this.resumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.resumeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resume_Management_DBDataSet2 = new Resume_Management_System.Resume_Management_DBDataSet2();
            this.resumeTableTableAdapter = new Resume_Management_System.Resume_Management_DBDataSet2TableAdapters.ResumeTableTableAdapter();
            this.btn_generate_resume = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbr_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_Management_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.updateUserDataToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New Login User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete Login User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // updateUserDataToolStripMenuItem
            // 
            this.updateUserDataToolStripMenuItem.Name = "updateUserDataToolStripMenuItem";
            this.updateUserDataToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.updateUserDataToolStripMenuItem.Text = "Update Login User Data";
            this.updateUserDataToolStripMenuItem.Click += new System.EventHandler(this.updateUserDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.mSAccessToolStripMenuItem,
            this.mSExcelToolStripMenuItem,
            this.mSPowerPointToolStripMenuItem,
            this.mSWordToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.webBrowserToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.ToolTipText = "Starts Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // mSAccessToolStripMenuItem
            // 
            this.mSAccessToolStripMenuItem.Name = "mSAccessToolStripMenuItem";
            this.mSAccessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mSAccessToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mSAccessToolStripMenuItem.Text = "MS Access";
            this.mSAccessToolStripMenuItem.ToolTipText = "Starts MS Access";
            this.mSAccessToolStripMenuItem.Click += new System.EventHandler(this.mSAccessToolStripMenuItem_Click);
            // 
            // mSExcelToolStripMenuItem
            // 
            this.mSExcelToolStripMenuItem.Name = "mSExcelToolStripMenuItem";
            this.mSExcelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mSExcelToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mSExcelToolStripMenuItem.Text = "MS Excel";
            this.mSExcelToolStripMenuItem.ToolTipText = "Starts MS Excel";
            this.mSExcelToolStripMenuItem.Click += new System.EventHandler(this.mSExcelToolStripMenuItem_Click);
            // 
            // mSPowerPointToolStripMenuItem
            // 
            this.mSPowerPointToolStripMenuItem.Name = "mSPowerPointToolStripMenuItem";
            this.mSPowerPointToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.mSPowerPointToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mSPowerPointToolStripMenuItem.Text = "GIMP";
            this.mSPowerPointToolStripMenuItem.ToolTipText = "Starts GIMP";
            this.mSPowerPointToolStripMenuItem.Click += new System.EventHandler(this.mSPowerPointToolStripMenuItem_Click);
            // 
            // mSWordToolStripMenuItem
            // 
            this.mSWordToolStripMenuItem.Name = "mSWordToolStripMenuItem";
            this.mSWordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.mSWordToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mSWordToolStripMenuItem.Text = "MS Word";
            this.mSWordToolStripMenuItem.ToolTipText = "Starts MS Word";
            this.mSWordToolStripMenuItem.Click += new System.EventHandler(this.mSWordToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.ToolTipText = "Starts Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // webBrowserToolStripMenuItem
            // 
            this.webBrowserToolStripMenuItem.Name = "webBrowserToolStripMenuItem";
            this.webBrowserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.webBrowserToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.webBrowserToolStripMenuItem.Text = "Web Browser";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.aboutTheDeveloperToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // aboutTheDeveloperToolStripMenuItem
            // 
            this.aboutTheDeveloperToolStripMenuItem.Name = "aboutTheDeveloperToolStripMenuItem";
            this.aboutTheDeveloperToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutTheDeveloperToolStripMenuItem.Text = "About ";
            this.aboutTheDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDeveloperToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Resume Software";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(277, 127);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(398, 31);
            this.txt_fullname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txt_address.Location = new System.Drawing.Point(277, 280);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(398, 94);
            this.txt_address.TabIndex = 3;
            this.txt_address.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 75);
            this.label5.TabIndex = 19;
            this.label5.Text = "Qualifications\r\nand other \r\nSkills\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender";
            // 
            // cmbx_gender
            // 
            this.cmbx_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cmbx_gender.FormattingEnabled = true;
            this.cmbx_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbx_gender.Location = new System.Drawing.Point(277, 230);
            this.cmbx_gender.Name = "cmbx_gender";
            this.cmbx_gender.Size = new System.Drawing.Size(398, 33);
            this.cmbx_gender.TabIndex = 2;
            // 
            // txt_qualification
            // 
            this.txt_qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qualification.Location = new System.Drawing.Point(277, 390);
            this.txt_qualification.Name = "txt_qualification";
            this.txt_qualification.Size = new System.Drawing.Size(314, 31);
            this.txt_qualification.TabIndex = 4;
            this.txt_qualification.Enter += new System.EventHandler(this.txt_qualification_Enter);
            this.txt_qualification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qualification_KeyDown);
            // 
            // qualList
            // 
            this.qualList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.qualList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.qualList.FormattingEnabled = true;
            this.qualList.ItemHeight = 19;
            this.qualList.Location = new System.Drawing.Point(277, 432);
            this.qualList.Name = "qualList";
            this.qualList.Size = new System.Drawing.Size(398, 61);
            this.qualList.TabIndex = 24;
            this.qualList.SelectedIndexChanged += new System.EventHandler(this.qualList_SelectedIndexChanged);
            this.qualList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qualList_KeyDown);
            this.qualList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qualList_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_add.Location = new System.Drawing.Point(597, 389);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(78, 31);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_hobby
            // 
            this.btn_hobby.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_hobby.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_hobby.Location = new System.Drawing.Point(597, 514);
            this.btn_hobby.Name = "btn_hobby";
            this.btn_hobby.Size = new System.Drawing.Size(78, 31);
            this.btn_hobby.TabIndex = 29;
            this.btn_hobby.Text = "Add";
            this.btn_hobby.UseVisualStyleBackColor = false;
            this.btn_hobby.Click += new System.EventHandler(this.btn_hobby_Click);
            // 
            // hobbyList
            // 
            this.hobbyList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hobbyList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hobbyList.ForeColor = System.Drawing.SystemColors.InfoText;
            this.hobbyList.FormattingEnabled = true;
            this.hobbyList.ItemHeight = 19;
            this.hobbyList.Location = new System.Drawing.Point(277, 557);
            this.hobbyList.Name = "hobbyList";
            this.hobbyList.Size = new System.Drawing.Size(398, 61);
            this.hobbyList.TabIndex = 28;
            this.hobbyList.SelectedIndexChanged += new System.EventHandler(this.hobbyList_SelectedIndexChanged);
            this.hobbyList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hobbyList_KeyDown);
            // 
            // txt_hobby
            // 
            this.txt_hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hobby.Location = new System.Drawing.Point(277, 515);
            this.txt_hobby.Name = "txt_hobby";
            this.txt_hobby.Size = new System.Drawing.Size(314, 31);
            this.txt_hobby.TabIndex = 5;
            this.txt_hobby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Hobbies / Interests";
            // 
            // pbx_user_image
            // 
            this.pbx_user_image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_user_image.Image = global::Resume_Management_System.Properties.Resources._default;
            this.pbx_user_image.Location = new System.Drawing.Point(585, 45);
            this.pbx_user_image.Name = "pbx_user_image";
            this.pbx_user_image.Size = new System.Drawing.Size(200, 262);
            this.pbx_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_user_image.TabIndex = 30;
            this.pbx_user_image.TabStop = false;
            this.pbx_user_image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_insert.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_insert.Location = new System.Drawing.Point(815, 45);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(410, 45);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_update.Location = new System.Drawing.Point(815, 119);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(410, 45);
            this.btn_update.TabIndex = 34;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_delete.Location = new System.Drawing.Point(815, 194);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(410, 45);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // trkbr_age
            // 
            this.trkbr_age.Location = new System.Drawing.Point(277, 179);
            this.trkbr_age.Maximum = 50;
            this.trkbr_age.Minimum = 15;
            this.trkbr_age.Name = "trkbr_age";
            this.trkbr_age.Size = new System.Drawing.Size(284, 45);
            this.trkbr_age.TabIndex = 1;
            this.trkbr_age.Value = 15;
            this.trkbr_age.Scroll += new System.EventHandler(this.trkbr_age_Scroll);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_age.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(604, 181);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(52, 25);
            this.lbl_age.TabIndex = 37;
            this.lbl_age.Text = "Age";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Clear.Location = new System.Drawing.Point(493, 637);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(182, 45);
            this.btn_Clear.TabIndex = 38;
            this.btn_Clear.Text = "Clear ";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // datadisplay
            // 
            this.datadisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.datadisplay.AutoGenerateColumns = false;
            this.datadisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resumeIDDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.qualificationsDataGridViewTextBoxColumn,
            this.hobbiesDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.datadisplay.DataSource = this.resumeTableBindingSource;
            this.datadisplay.Location = new System.Drawing.Point(585, 330);
            this.datadisplay.Name = "datadisplay";
            this.datadisplay.Size = new System.Drawing.Size(640, 352);
            this.datadisplay.TabIndex = 39;
            this.datadisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadisplay_CellClick);
            this.datadisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadisplay_CellContentClick);
            // 
            // resumeIDDataGridViewTextBoxColumn
            // 
            this.resumeIDDataGridViewTextBoxColumn.DataPropertyName = "ResumeID";
            this.resumeIDDataGridViewTextBoxColumn.HeaderText = "ResumeID";
            this.resumeIDDataGridViewTextBoxColumn.Name = "resumeIDDataGridViewTextBoxColumn";
            this.resumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // qualificationsDataGridViewTextBoxColumn
            // 
            this.qualificationsDataGridViewTextBoxColumn.DataPropertyName = "qualifications";
            this.qualificationsDataGridViewTextBoxColumn.HeaderText = "qualifications";
            this.qualificationsDataGridViewTextBoxColumn.Name = "qualificationsDataGridViewTextBoxColumn";
            // 
            // hobbiesDataGridViewTextBoxColumn
            // 
            this.hobbiesDataGridViewTextBoxColumn.DataPropertyName = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.HeaderText = "hobbies";
            this.hobbiesDataGridViewTextBoxColumn.Name = "hobbiesDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // resumeTableBindingSource
            // 
            this.resumeTableBindingSource.DataMember = "ResumeTable";
            this.resumeTableBindingSource.DataSource = this.resume_Management_DBDataSet2;
            // 
            // resume_Management_DBDataSet2
            // 
            this.resume_Management_DBDataSet2.DataSetName = "Resume_Management_DBDataSet2";
            this.resume_Management_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resumeTableTableAdapter
            // 
            this.resumeTableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_generate_resume
            // 
            this.btn_generate_resume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generate_resume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_generate_resume.Font = new System.Drawing.Font("Verdana", 15.225F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_generate_resume.Location = new System.Drawing.Point(815, 262);
            this.btn_generate_resume.Name = "btn_generate_resume";
            this.btn_generate_resume.Size = new System.Drawing.Size(410, 45);
            this.btn_generate_resume.TabIndex = 40;
            this.btn_generate_resume.Text = "Generate Resume";
            this.btn_generate_resume.UseVisualStyleBackColor = false;
            this.btn_generate_resume.Click += new System.EventHandler(this.btn_generate_resume_Click);
            // 
            // User_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 702);
            this.Controls.Add(this.btn_generate_resume);
            this.Controls.Add(this.datadisplay);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.trkbr_age);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.pbx_user_image);
            this.Controls.Add(this.btn_hobby);
            this.Controls.Add(this.hobbyList);
            this.Controls.Add(this.txt_hobby);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.qualList);
            this.Controls.Add(this.txt_qualification);
            this.Controls.Add(this.cmbx_gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User_Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbr_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_Management_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_gender;
        private System.Windows.Forms.TextBox txt_qualification;
        private System.Windows.Forms.ListBox qualList;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_hobby;
        private System.Windows.Forms.ListBox hobbyList;
        private System.Windows.Forms.TextBox txt_hobby;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbx_user_image;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TrackBar trkbr_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSPowerPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView datadisplay;
        private Resume_Management_DBDataSet2 resume_Management_DBDataSet2;
        private System.Windows.Forms.BindingSource resumeTableBindingSource;
        private Resume_Management_DBDataSet2TableAdapters.ResumeTableTableAdapter resumeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn resumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripMenuItem webBrowserToolStripMenuItem;
        private System.Windows.Forms.Button btn_generate_resume;
    }
}