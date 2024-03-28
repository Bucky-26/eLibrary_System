
namespace eLibrary_System
{
    partial class books
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgviewBook = new System.Windows.Forms.DataGridView();
            this.ass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchBooks = new MetroFramework.Controls.MetroTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnImportcsv = new System.Windows.Forms.Button();
            this.FileDialogImportCSV = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewBook)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(822, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgviewBook);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 482);
            this.panel2.TabIndex = 1;
            // 
            // dgviewBook
            // 
            this.dgviewBook.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgviewBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewBook.BackgroundColor = System.Drawing.Color.White;
            this.dgviewBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgviewBook.CausesValidation = false;
            this.dgviewBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgviewBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewBook.ColumnHeadersHeight = 30;
            this.dgviewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgviewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ass,
            this.Title,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.PAGES,
            this.Column5,
            this.edit,
            this.delete});
            this.dgviewBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewBook.EnableHeadersVisualStyles = false;
            this.dgviewBook.Location = new System.Drawing.Point(0, 41);
            this.dgviewBook.Name = "dgviewBook";
            this.dgviewBook.ReadOnly = true;
            this.dgviewBook.RowHeadersVisible = false;
            this.dgviewBook.RowTemplate.Height = 30;
            this.dgviewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewBook.Size = new System.Drawing.Size(900, 441);
            this.dgviewBook.TabIndex = 1;
            this.dgviewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewBook_CellContentClick);
            // 
            // ass
            // 
            this.ass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ass.HeaderText = "Assesion No.";
            this.ass.Name = "ass";
            this.ass.ReadOnly = true;
            this.ass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ass.Width = 66;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Publication";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 63;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Author";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 42;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Release Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 68;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "SUBJECT AREA";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 82;
            // 
            // PAGES
            // 
            this.PAGES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PAGES.HeaderText = "PAGES";
            this.PAGES.Name = "PAGES";
            this.PAGES.ReadOnly = true;
            this.PAGES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PAGES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PAGES.Width = 47;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "DDC NO.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 50;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImportcsv);
            this.panel3.Controls.Add(this.txtSearchBooks);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 41);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearchBooks.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSearchBooks.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearchBooks.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchBooks.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtSearchBooks.CustomButton.Name = "";
            this.txtSearchBooks.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchBooks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBooks.CustomButton.TabIndex = 1;
            this.txtSearchBooks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBooks.CustomButton.UseCompatibleTextRendering = true;
            this.txtSearchBooks.CustomButton.UseCustomBackColor = true;
            this.txtSearchBooks.CustomButton.UseCustomForeColor = true;
            this.txtSearchBooks.CustomButton.UseSelectable = true;
            this.txtSearchBooks.CustomButton.UseStyleColors = true;
            this.txtSearchBooks.CustomButton.Visible = false;
            this.txtSearchBooks.DisplayIcon = true;
            this.txtSearchBooks.Lines = new string[0];
            this.txtSearchBooks.Location = new System.Drawing.Point(579, 12);
            this.txtSearchBooks.MaxLength = 32767;
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.PasswordChar = '\0';
            this.txtSearchBooks.PromptText = "Search";
            this.txtSearchBooks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBooks.SelectedText = "";
            this.txtSearchBooks.SelectionLength = 0;
            this.txtSearchBooks.SelectionStart = 0;
            this.txtSearchBooks.ShortcutsEnabled = true;
            this.txtSearchBooks.Size = new System.Drawing.Size(309, 23);
            this.txtSearchBooks.TabIndex = 2;
            this.txtSearchBooks.UseCustomBackColor = true;
            this.txtSearchBooks.UseCustomForeColor = true;
            this.txtSearchBooks.UseSelectable = true;
            this.txtSearchBooks.UseStyleColors = true;
            this.txtSearchBooks.WaterMark = "Search";
            this.txtSearchBooks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBooks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBooks.TextChanged += new System.EventHandler(this.txtSearchBooks_TextChanged);
            this.txtSearchBooks.Click += new System.EventHandler(this.txtSearchBooks_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "ADD BOOK";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnImportcsv
            // 
            this.btnImportcsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportcsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnImportcsv.FlatAppearance.BorderSize = 0;
            this.btnImportcsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportcsv.ForeColor = System.Drawing.Color.White;
            this.btnImportcsv.Location = new System.Drawing.Point(93, 9);
            this.btnImportcsv.Name = "btnImportcsv";
            this.btnImportcsv.Size = new System.Drawing.Size(103, 23);
            this.btnImportcsv.TabIndex = 3;
            this.btnImportcsv.Text = "IMPORT CSV";
            this.btnImportcsv.UseVisualStyleBackColor = false;
            this.btnImportcsv.Click += new System.EventHandler(this.button2_Click);
            // 
            // FileDialogImportCSV
            // 
            this.FileDialogImportCSV.FileName = "openFileDialog1";
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "books";
            this.Text = "books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewBook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgviewBook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private MetroFramework.Controls.MetroTextBox txtSearchBooks;
        private System.Windows.Forms.Button btnImportcsv;
        private System.Windows.Forms.OpenFileDialog FileDialogImportCSV;
    }
}