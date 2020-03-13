namespace ProjectPart2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbx_LenderDetails = new System.Windows.Forms.GroupBox();
            this.lbl_DaysLeft = new System.Windows.Forms.Label();
            this.lbl_NbrBooks = new System.Windows.Forms.Label();
            this.lbl_PersonalEmail = new System.Windows.Forms.Label();
            this.lbl_MobileNbr = new System.Windows.Forms.Label();
            this.lbl_NextReturnDate = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbx_LenderDetails = new System.Windows.Forms.ListBox();
            this.btn_SortID = new System.Windows.Forms.Button();
            this.btn_SortName = new System.Windows.Forms.Button();
            this.btn_SortReturnDate = new System.Windows.Forms.Button();
            this.btn_AddLender = new System.Windows.Forms.Button();
            this.btn_ViewAndEdit = new System.Windows.Forms.Button();
            this.btn_DeleteLender = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_LenderDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_LenderDetails
            // 
            this.gbx_LenderDetails.Controls.Add(this.lbl_DaysLeft);
            this.gbx_LenderDetails.Controls.Add(this.lbl_NbrBooks);
            this.gbx_LenderDetails.Controls.Add(this.lbl_PersonalEmail);
            this.gbx_LenderDetails.Controls.Add(this.lbl_MobileNbr);
            this.gbx_LenderDetails.Controls.Add(this.lbl_NextReturnDate);
            this.gbx_LenderDetails.Controls.Add(this.lbl_Name);
            this.gbx_LenderDetails.Controls.Add(this.lbl_ID);
            this.gbx_LenderDetails.Controls.Add(this.lbx_LenderDetails);
            this.gbx_LenderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_LenderDetails.Location = new System.Drawing.Point(12, 40);
            this.gbx_LenderDetails.Name = "gbx_LenderDetails";
            this.gbx_LenderDetails.Size = new System.Drawing.Size(1084, 455);
            this.gbx_LenderDetails.TabIndex = 0;
            this.gbx_LenderDetails.TabStop = false;
            this.gbx_LenderDetails.Text = "Lender Details";
            // 
            // lbl_DaysLeft
            // 
            this.lbl_DaysLeft.AutoSize = true;
            this.lbl_DaysLeft.Location = new System.Drawing.Point(412, 40);
            this.lbl_DaysLeft.Name = "lbl_DaysLeft";
            this.lbl_DaysLeft.Size = new System.Drawing.Size(93, 15);
            this.lbl_DaysLeft.TabIndex = 7;
            this.lbl_DaysLeft.Text = "Days Left / Late:";
            // 
            // lbl_NbrBooks
            // 
            this.lbl_NbrBooks.AutoSize = true;
            this.lbl_NbrBooks.Location = new System.Drawing.Point(532, 40);
            this.lbl_NbrBooks.Name = "lbl_NbrBooks";
            this.lbl_NbrBooks.Size = new System.Drawing.Size(64, 15);
            this.lbl_NbrBooks.TabIndex = 6;
            this.lbl_NbrBooks.Text = "Nbr Books";
            // 
            // lbl_PersonalEmail
            // 
            this.lbl_PersonalEmail.AutoSize = true;
            this.lbl_PersonalEmail.Location = new System.Drawing.Point(812, 39);
            this.lbl_PersonalEmail.Name = "lbl_PersonalEmail";
            this.lbl_PersonalEmail.Size = new System.Drawing.Size(91, 15);
            this.lbl_PersonalEmail.TabIndex = 5;
            this.lbl_PersonalEmail.Text = "Personal Email";
            // 
            // lbl_MobileNbr
            // 
            this.lbl_MobileNbr.AutoSize = true;
            this.lbl_MobileNbr.Location = new System.Drawing.Point(659, 39);
            this.lbl_MobileNbr.Name = "lbl_MobileNbr";
            this.lbl_MobileNbr.Size = new System.Drawing.Size(68, 15);
            this.lbl_MobileNbr.TabIndex = 4;
            this.lbl_MobileNbr.Text = "Mobile Nbr";
            // 
            // lbl_NextReturnDate
            // 
            this.lbl_NextReturnDate.AutoSize = true;
            this.lbl_NextReturnDate.Location = new System.Drawing.Point(267, 40);
            this.lbl_NextReturnDate.Name = "lbl_NextReturnDate";
            this.lbl_NextReturnDate.Size = new System.Drawing.Size(101, 15);
            this.lbl_NextReturnDate.TabIndex = 3;
            this.lbl_NextReturnDate.Text = "Next Return Date";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(99, 39);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(41, 15);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(27, 40);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(19, 15);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // lbx_LenderDetails
            // 
            this.lbx_LenderDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_LenderDetails.FormattingEnabled = true;
            this.lbx_LenderDetails.ItemHeight = 14;
            this.lbx_LenderDetails.Location = new System.Drawing.Point(22, 58);
            this.lbx_LenderDetails.Name = "lbx_LenderDetails";
            this.lbx_LenderDetails.Size = new System.Drawing.Size(1041, 368);
            this.lbx_LenderDetails.TabIndex = 0;
            this.lbx_LenderDetails.SelectedIndexChanged += new System.EventHandler(this.lbx_LenderDetails_SelectedIndexChanged);
            // 
            // btn_SortID
            // 
            this.btn_SortID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortID.Location = new System.Drawing.Point(42, 516);
            this.btn_SortID.Name = "btn_SortID";
            this.btn_SortID.Size = new System.Drawing.Size(152, 47);
            this.btn_SortID.TabIndex = 1;
            this.btn_SortID.Text = "Sort ID";
            this.btn_SortID.UseVisualStyleBackColor = true;
            this.btn_SortID.Click += new System.EventHandler(this.btn_SortID_Click);
            // 
            // btn_SortName
            // 
            this.btn_SortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortName.Location = new System.Drawing.Point(228, 516);
            this.btn_SortName.Name = "btn_SortName";
            this.btn_SortName.Size = new System.Drawing.Size(152, 47);
            this.btn_SortName.TabIndex = 2;
            this.btn_SortName.Text = "Sort Name";
            this.btn_SortName.UseVisualStyleBackColor = true;
            this.btn_SortName.Click += new System.EventHandler(this.btn_SortName_Click);
            // 
            // btn_SortReturnDate
            // 
            this.btn_SortReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SortReturnDate.Location = new System.Drawing.Point(414, 516);
            this.btn_SortReturnDate.Name = "btn_SortReturnDate";
            this.btn_SortReturnDate.Size = new System.Drawing.Size(152, 47);
            this.btn_SortReturnDate.TabIndex = 3;
            this.btn_SortReturnDate.Text = "Sort Date";
            this.btn_SortReturnDate.UseVisualStyleBackColor = true;
            this.btn_SortReturnDate.Click += new System.EventHandler(this.btn_SortReturnDate_Click);
            // 
            // btn_AddLender
            // 
            this.btn_AddLender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLender.Location = new System.Drawing.Point(1117, 98);
            this.btn_AddLender.Name = "btn_AddLender";
            this.btn_AddLender.Size = new System.Drawing.Size(152, 47);
            this.btn_AddLender.TabIndex = 4;
            this.btn_AddLender.Text = "Add Lender";
            this.btn_AddLender.UseVisualStyleBackColor = true;
            this.btn_AddLender.Click += new System.EventHandler(this.btn_AddLender_Click);
            // 
            // btn_ViewAndEdit
            // 
            this.btn_ViewAndEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAndEdit.Location = new System.Drawing.Point(1117, 167);
            this.btn_ViewAndEdit.Name = "btn_ViewAndEdit";
            this.btn_ViewAndEdit.Size = new System.Drawing.Size(152, 47);
            this.btn_ViewAndEdit.TabIndex = 5;
            this.btn_ViewAndEdit.Text = "View and Edit";
            this.btn_ViewAndEdit.UseVisualStyleBackColor = true;
            this.btn_ViewAndEdit.Click += new System.EventHandler(this.btn_ViewAndEdit_Click);
            // 
            // btn_DeleteLender
            // 
            this.btn_DeleteLender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteLender.Location = new System.Drawing.Point(1117, 236);
            this.btn_DeleteLender.Name = "btn_DeleteLender";
            this.btn_DeleteLender.Size = new System.Drawing.Size(152, 47);
            this.btn_DeleteLender.TabIndex = 6;
            this.btn_DeleteLender.Text = "Delete Lender";
            this.btn_DeleteLender.UseVisualStyleBackColor = true;
            this.btn_DeleteLender.Click += new System.EventHandler(this.btn_DeleteLender_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit      Ctrl + F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_File_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About ....";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutBox_Help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 590);
            this.Controls.Add(this.btn_DeleteLender);
            this.Controls.Add(this.btn_ViewAndEdit);
            this.Controls.Add(this.btn_AddLender);
            this.Controls.Add(this.btn_SortReturnDate);
            this.Controls.Add(this.btn_SortName);
            this.Controls.Add(this.btn_SortID);
            this.Controls.Add(this.gbx_LenderDetails);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gbx_LenderDetails.ResumeLayout(false);
            this.gbx_LenderDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_LenderDetails;
        private System.Windows.Forms.Label lbl_NbrBooks;
        private System.Windows.Forms.Label lbl_PersonalEmail;
        private System.Windows.Forms.Label lbl_MobileNbr;
        private System.Windows.Forms.Label lbl_NextReturnDate;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ListBox lbx_LenderDetails;
        private System.Windows.Forms.Button btn_SortID;
        private System.Windows.Forms.Button btn_SortName;
        private System.Windows.Forms.Button btn_SortReturnDate;
        private System.Windows.Forms.Button btn_AddLender;
        private System.Windows.Forms.Button btn_ViewAndEdit;
        private System.Windows.Forms.Button btn_DeleteLender;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_DaysLeft;
    }
}

