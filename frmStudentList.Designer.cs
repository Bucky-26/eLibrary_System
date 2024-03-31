namespace eLibrary_System
{
    partial class frmStudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgviewStudents = new System.Windows.Forms.DataGridView();
            this.txtBoxQSearch = new MetroFramework.Controls.MetroTextBox();
            this.ass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgviewStudents);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 458);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(852, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBoxQSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 36);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgviewStudents
            // 
            this.dgviewStudents.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgviewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgviewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgviewStudents.CausesValidation = false;
            this.dgviewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgviewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgviewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgviewStudents.ColumnHeadersHeight = 30;
            this.dgviewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgviewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ass,
            this.Title,
            this.Column1,
            this.Column4,
            this.PAGES,
            this.select});
            this.dgviewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgviewStudents.EnableHeadersVisualStyles = false;
            this.dgviewStudents.Location = new System.Drawing.Point(0, 36);
            this.dgviewStudents.Name = "dgviewStudents";
            this.dgviewStudents.ReadOnly = true;
            this.dgviewStudents.RowHeadersVisible = false;
            this.dgviewStudents.RowTemplate.Height = 30;
            this.dgviewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewStudents.Size = new System.Drawing.Size(881, 422);
            this.dgviewStudents.TabIndex = 7;
            this.dgviewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewStudents_CellContentClick);
            // 
            // txtBoxQSearch
            // 
            // 
            // 
            // 
            this.txtBoxQSearch.CustomButton.Image = null;
            this.txtBoxQSearch.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtBoxQSearch.CustomButton.Name = "";
            this.txtBoxQSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxQSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxQSearch.CustomButton.TabIndex = 1;
            this.txtBoxQSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxQSearch.CustomButton.UseSelectable = true;
            this.txtBoxQSearch.CustomButton.Visible = false;
            this.txtBoxQSearch.Lines = new string[0];
            this.txtBoxQSearch.Location = new System.Drawing.Point(588, 7);
            this.txtBoxQSearch.MaxLength = 32767;
            this.txtBoxQSearch.Name = "txtBoxQSearch";
            this.txtBoxQSearch.PasswordChar = '\0';
            this.txtBoxQSearch.PromptText = "Search";
            this.txtBoxQSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxQSearch.SelectedText = "";
            this.txtBoxQSearch.SelectionLength = 0;
            this.txtBoxQSearch.SelectionStart = 0;
            this.txtBoxQSearch.ShortcutsEnabled = true;
            this.txtBoxQSearch.Size = new System.Drawing.Size(281, 23);
            this.txtBoxQSearch.TabIndex = 0;
            this.txtBoxQSearch.UseSelectable = true;
            this.txtBoxQSearch.WaterMark = "Search";
            this.txtBoxQSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxQSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ass
            // 
            this.ass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ass.HeaderText = "LC NUMBER";
            this.ass.Name = "ass";
            this.ass.ReadOnly = true;
            this.ass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ass.Width = 73;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "LRN";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "FULLNAME";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 67;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "GRADE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 47;
            // 
            // PAGES
            // 
            this.PAGES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PAGES.HeaderText = "SECTION/BLOCK";
            this.PAGES.Name = "PAGES";
            this.PAGES.ReadOnly = true;
            this.PAGES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PAGES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PAGES.Width = 97;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.select.HeaderText = "";
            this.select.Image = ((System.Drawing.Image)(resources.GetObject("select.Image")));
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 5;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 489);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgviewStudents;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox txtBoxQSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGES;
        private System.Windows.Forms.DataGridViewImageColumn select;
    }
}