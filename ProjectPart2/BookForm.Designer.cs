namespace ProjectPart2
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.gbx_BookDetails = new System.Windows.Forms.GroupBox();
            this.lbl_AuthorLastName = new System.Windows.Forms.Label();
            this.tbx_AuthorLastName = new System.Windows.Forms.RichTextBox();
            this.lbl_DateToReturn = new System.Windows.Forms.Label();
            this.dtp_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_BookGenre = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_AuthorFirstName = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.cbx_BookType = new System.Windows.Forms.ComboBox();
            this.tbx_ISBN = new System.Windows.Forms.RichTextBox();
            this.tbx_Title = new System.Windows.Forms.RichTextBox();
            this.tbx_AuthorFirstName = new System.Windows.Forms.RichTextBox();
            this.gbx_BookManager = new System.Windows.Forms.GroupBox();
            this.lbl_BookGenre_BookM = new System.Windows.Forms.Label();
            this.lbl_Title_BookM = new System.Windows.Forms.Label();
            this.lbl_Author_BookM = new System.Windows.Forms.Label();
            this.lbl_ReturnDate_BookM = new System.Windows.Forms.Label();
            this.lbl_ISBN_BookM = new System.Windows.Forms.Label();
            this.lbx_BookList = new System.Windows.Forms.ListBox();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Unselect = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tp_ReturnDate = new System.Windows.Forms.ToolTip(this.components);
            this.gbx_BookDetails.SuspendLayout();
            this.gbx_BookManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_BookDetails
            // 
            this.gbx_BookDetails.Controls.Add(this.lbl_AuthorLastName);
            this.gbx_BookDetails.Controls.Add(this.tbx_AuthorLastName);
            this.gbx_BookDetails.Controls.Add(this.lbl_DateToReturn);
            this.gbx_BookDetails.Controls.Add(this.dtp_DateTimePicker);
            this.gbx_BookDetails.Controls.Add(this.lbl_BookGenre);
            this.gbx_BookDetails.Controls.Add(this.lbl_Title);
            this.gbx_BookDetails.Controls.Add(this.lbl_AuthorFirstName);
            this.gbx_BookDetails.Controls.Add(this.lbl_ISBN);
            this.gbx_BookDetails.Controls.Add(this.cbx_BookType);
            this.gbx_BookDetails.Controls.Add(this.tbx_ISBN);
            this.gbx_BookDetails.Controls.Add(this.tbx_Title);
            this.gbx_BookDetails.Controls.Add(this.tbx_AuthorFirstName);
            this.gbx_BookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_BookDetails.Location = new System.Drawing.Point(27, 28);
            this.gbx_BookDetails.Name = "gbx_BookDetails";
            this.gbx_BookDetails.Size = new System.Drawing.Size(978, 173);
            this.gbx_BookDetails.TabIndex = 0;
            this.gbx_BookDetails.TabStop = false;
            this.gbx_BookDetails.Text = "Book Details";
            // 
            // lbl_AuthorLastName
            // 
            this.lbl_AuthorLastName.AutoSize = true;
            this.lbl_AuthorLastName.Location = new System.Drawing.Point(455, 33);
            this.lbl_AuthorLastName.Name = "lbl_AuthorLastName";
            this.lbl_AuthorLastName.Size = new System.Drawing.Size(108, 15);
            this.lbl_AuthorLastName.TabIndex = 11;
            this.lbl_AuthorLastName.Text = "Author Last Name:";
            // 
            // tbx_AuthorLastName
            // 
            this.tbx_AuthorLastName.Location = new System.Drawing.Point(453, 58);
            this.tbx_AuthorLastName.Name = "tbx_AuthorLastName";
            this.tbx_AuthorLastName.Size = new System.Drawing.Size(205, 29);
            this.tbx_AuthorLastName.TabIndex = 2;
            this.tbx_AuthorLastName.Text = "";
            // 
            // lbl_DateToReturn
            // 
            this.lbl_DateToReturn.AutoSize = true;
            this.lbl_DateToReturn.Location = new System.Drawing.Point(207, 107);
            this.lbl_DateToReturn.Name = "lbl_DateToReturn";
            this.lbl_DateToReturn.Size = new System.Drawing.Size(76, 15);
            this.lbl_DateToReturn.TabIndex = 9;
            this.lbl_DateToReturn.Text = "Return Date:";
            // 
            // dtp_DateTimePicker
            // 
            this.dtp_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateTimePicker.Location = new System.Drawing.Point(210, 133);
            this.dtp_DateTimePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtp_DateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtp_DateTimePicker.Name = "dtp_DateTimePicker";
            this.dtp_DateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dtp_DateTimePicker.TabIndex = 5;
            // 
            // lbl_BookGenre
            // 
            this.lbl_BookGenre.AutoSize = true;
            this.lbl_BookGenre.Location = new System.Drawing.Point(15, 107);
            this.lbl_BookGenre.Name = "lbl_BookGenre";
            this.lbl_BookGenre.Size = new System.Drawing.Size(75, 15);
            this.lbl_BookGenre.TabIndex = 7;
            this.lbl_BookGenre.Text = "Book Genre:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(692, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(33, 15);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Title:";
            // 
            // lbl_AuthorFirstName
            // 
            this.lbl_AuthorFirstName.AutoSize = true;
            this.lbl_AuthorFirstName.Location = new System.Drawing.Point(207, 32);
            this.lbl_AuthorFirstName.Name = "lbl_AuthorFirstName";
            this.lbl_AuthorFirstName.Size = new System.Drawing.Size(108, 15);
            this.lbl_AuthorFirstName.TabIndex = 5;
            this.lbl_AuthorFirstName.Text = "Author First Name:";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(15, 32);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(38, 15);
            this.lbl_ISBN.TabIndex = 4;
            this.lbl_ISBN.Text = "ISBN:";
            // 
            // cbx_BookType
            // 
            this.cbx_BookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BookType.FormattingEnabled = true;
            this.cbx_BookType.Location = new System.Drawing.Point(14, 132);
            this.cbx_BookType.Name = "cbx_BookType";
            this.cbx_BookType.Size = new System.Drawing.Size(145, 23);
            this.cbx_BookType.TabIndex = 4;
            // 
            // tbx_ISBN
            // 
            this.tbx_ISBN.Location = new System.Drawing.Point(18, 58);
            this.tbx_ISBN.Name = "tbx_ISBN";
            this.tbx_ISBN.Size = new System.Drawing.Size(141, 29);
            this.tbx_ISBN.TabIndex = 0;
            this.tbx_ISBN.Text = "";
            // 
            // tbx_Title
            // 
            this.tbx_Title.Location = new System.Drawing.Point(695, 58);
            this.tbx_Title.Name = "tbx_Title";
            this.tbx_Title.Size = new System.Drawing.Size(205, 29);
            this.tbx_Title.TabIndex = 3;
            this.tbx_Title.Text = "";
            // 
            // tbx_AuthorFirstName
            // 
            this.tbx_AuthorFirstName.Location = new System.Drawing.Point(210, 58);
            this.tbx_AuthorFirstName.Name = "tbx_AuthorFirstName";
            this.tbx_AuthorFirstName.Size = new System.Drawing.Size(205, 29);
            this.tbx_AuthorFirstName.TabIndex = 1;
            this.tbx_AuthorFirstName.Text = "";
            // 
            // gbx_BookManager
            // 
            this.gbx_BookManager.Controls.Add(this.lbl_BookGenre_BookM);
            this.gbx_BookManager.Controls.Add(this.lbl_Title_BookM);
            this.gbx_BookManager.Controls.Add(this.lbl_Author_BookM);
            this.gbx_BookManager.Controls.Add(this.lbl_ReturnDate_BookM);
            this.gbx_BookManager.Controls.Add(this.lbl_ISBN_BookM);
            this.gbx_BookManager.Controls.Add(this.lbx_BookList);
            this.gbx_BookManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_BookManager.Location = new System.Drawing.Point(27, 219);
            this.gbx_BookManager.Name = "gbx_BookManager";
            this.gbx_BookManager.Size = new System.Drawing.Size(978, 421);
            this.gbx_BookManager.TabIndex = 1;
            this.gbx_BookManager.TabStop = false;
            this.gbx_BookManager.Text = "Book Manager";
            // 
            // lbl_BookGenre_BookM
            // 
            this.lbl_BookGenre_BookM.AutoSize = true;
            this.lbl_BookGenre_BookM.Location = new System.Drawing.Point(612, 30);
            this.lbl_BookGenre_BookM.Name = "lbl_BookGenre_BookM";
            this.lbl_BookGenre_BookM.Size = new System.Drawing.Size(75, 15);
            this.lbl_BookGenre_BookM.TabIndex = 10;
            this.lbl_BookGenre_BookM.Text = "Book Genre:";
            // 
            // lbl_Title_BookM
            // 
            this.lbl_Title_BookM.AutoSize = true;
            this.lbl_Title_BookM.Location = new System.Drawing.Point(410, 30);
            this.lbl_Title_BookM.Name = "lbl_Title_BookM";
            this.lbl_Title_BookM.Size = new System.Drawing.Size(33, 15);
            this.lbl_Title_BookM.TabIndex = 10;
            this.lbl_Title_BookM.Text = "Title:";
            // 
            // lbl_Author_BookM
            // 
            this.lbl_Author_BookM.AutoSize = true;
            this.lbl_Author_BookM.Location = new System.Drawing.Point(166, 30);
            this.lbl_Author_BookM.Name = "lbl_Author_BookM";
            this.lbl_Author_BookM.Size = new System.Drawing.Size(45, 15);
            this.lbl_Author_BookM.TabIndex = 10;
            this.lbl_Author_BookM.Text = "Author:";
            // 
            // lbl_ReturnDate_BookM
            // 
            this.lbl_ReturnDate_BookM.AutoSize = true;
            this.lbl_ReturnDate_BookM.Location = new System.Drawing.Point(810, 30);
            this.lbl_ReturnDate_BookM.Name = "lbl_ReturnDate_BookM";
            this.lbl_ReturnDate_BookM.Size = new System.Drawing.Size(76, 15);
            this.lbl_ReturnDate_BookM.TabIndex = 10;
            this.lbl_ReturnDate_BookM.Text = "Return Date:";
            // 
            // lbl_ISBN_BookM
            // 
            this.lbl_ISBN_BookM.AutoSize = true;
            this.lbl_ISBN_BookM.Location = new System.Drawing.Point(24, 30);
            this.lbl_ISBN_BookM.Name = "lbl_ISBN_BookM";
            this.lbl_ISBN_BookM.Size = new System.Drawing.Size(38, 15);
            this.lbl_ISBN_BookM.TabIndex = 10;
            this.lbl_ISBN_BookM.Text = "ISBN:";
            // 
            // lbx_BookList
            // 
            this.lbx_BookList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_BookList.FormattingEnabled = true;
            this.lbx_BookList.ItemHeight = 14;
            this.lbx_BookList.Location = new System.Drawing.Point(13, 57);
            this.lbx_BookList.Name = "lbx_BookList";
            this.lbx_BookList.Size = new System.Drawing.Size(947, 354);
            this.lbx_BookList.TabIndex = 0;
            this.lbx_BookList.SelectedIndexChanged += new System.EventHandler(this.lbx_BookList_SelectedIndexChanged);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBook.Location = new System.Drawing.Point(1038, 276);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(153, 44);
            this.btn_AddBook.TabIndex = 2;
            this.btn_AddBook.Text = "&Add";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(1038, 338);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(153, 44);
            this.btn_Change.TabIndex = 3;
            this.btn_Change.Text = "&Change";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(1038, 400);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 44);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "&Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Unselect
            // 
            this.btn_Unselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unselect.Location = new System.Drawing.Point(1038, 463);
            this.btn_Unselect.Name = "btn_Unselect";
            this.btn_Unselect.Size = new System.Drawing.Size(153, 44);
            this.btn_Unselect.TabIndex = 5;
            this.btn_Unselect.Text = "Unselect";
            this.btn_Unselect.UseVisualStyleBackColor = true;
            this.btn_Unselect.Click += new System.EventHandler(this.btn_Unselect_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(1038, 86);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(153, 44);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "&OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 652);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Unselect);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.gbx_BookManager);
            this.Controls.Add(this.gbx_BookDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.gbx_BookDetails.ResumeLayout(false);
            this.gbx_BookDetails.PerformLayout();
            this.gbx_BookManager.ResumeLayout(false);
            this.gbx_BookManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_BookDetails;
        private System.Windows.Forms.ComboBox cbx_BookType;
        private System.Windows.Forms.RichTextBox tbx_ISBN;
        private System.Windows.Forms.RichTextBox tbx_Title;
        private System.Windows.Forms.RichTextBox tbx_AuthorFirstName;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_AuthorFirstName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_BookGenre;
        private System.Windows.Forms.GroupBox gbx_BookManager;
        private System.Windows.Forms.ListBox lbx_BookList;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Unselect;
        private System.Windows.Forms.Label lbl_DateToReturn;
        private System.Windows.Forms.DateTimePicker dtp_DateTimePicker;
        private System.Windows.Forms.Label lbl_BookGenre_BookM;
        private System.Windows.Forms.Label lbl_Title_BookM;
        private System.Windows.Forms.Label lbl_Author_BookM;
        private System.Windows.Forms.Label lbl_ReturnDate_BookM;
        private System.Windows.Forms.Label lbl_ISBN_BookM;
        private System.Windows.Forms.Label lbl_AuthorLastName;
        private System.Windows.Forms.RichTextBox tbx_AuthorLastName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ToolTip tp_ReturnDate;
    }
}