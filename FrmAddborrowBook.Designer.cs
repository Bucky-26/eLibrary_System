namespace eLibrary_System
{
    partial class FrmAddborrowBook
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
            this.txtbookAssesion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookDDC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.CLOSE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStuFullName = new System.Windows.Forms.TextBox();
            this.txtstuLcNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtStuBlock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtdateb = new System.Windows.Forms.DateTimePicker();
            this.dtdueDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assesion Number:";
            // 
            // txtbookAssesion
            // 
            this.txtbookAssesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbookAssesion.Location = new System.Drawing.Point(82, 189);
            this.txtbookAssesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbookAssesion.Name = "txtbookAssesion";
            this.txtbookAssesion.Size = new System.Drawing.Size(233, 23);
            this.txtbookAssesion.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(169)))), ((int)(((byte)(240)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(310, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbookTitle
            // 
            this.txtbookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbookTitle.Location = new System.Drawing.Point(82, 243);
            this.txtbookTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbookTitle.Name = "txtbookTitle";
            this.txtbookTitle.Size = new System.Drawing.Size(233, 23);
            this.txtbookTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title:";
            // 
            // txtBookDDC
            // 
            this.txtBookDDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookDDC.Location = new System.Drawing.Point(82, 301);
            this.txtBookDDC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookDDC.Name = "txtBookDDC";
            this.txtBookDDC.Size = new System.Drawing.Size(233, 23);
            this.txtBookDDC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DDC No.";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnl_top.Controls.Add(this.CLOSE);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1062, 34);
            this.pnl_top.TabIndex = 7;
            // 
            // CLOSE
            // 
            this.CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CLOSE.AutoSize = true;
            this.CLOSE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE.ForeColor = System.Drawing.Color.White;
            this.CLOSE.Location = new System.Drawing.Point(985, 9);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(65, 18);
            this.CLOSE.TabIndex = 8;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(123, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book Detail\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(435, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Borrower\'s Details";
            // 
            // txtStuFullName
            // 
            this.txtStuFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStuFullName.Location = new System.Drawing.Point(421, 243);
            this.txtStuFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStuFullName.Name = "txtStuFullName";
            this.txtStuFullName.Size = new System.Drawing.Size(233, 23);
            this.txtStuFullName.TabIndex = 11;
            // 
            // txtstuLcNum
            // 
            this.txtstuLcNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstuLcNum.Location = new System.Drawing.Point(421, 189);
            this.txtstuLcNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtstuLcNum.Name = "txtstuLcNum";
            this.txtstuLcNum.Size = new System.Drawing.Size(233, 23);
            this.txtstuLcNum.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "LC Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 227);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fullname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrade.Location = new System.Drawing.Point(421, 301);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(233, 23);
            this.txtGrade.TabIndex = 13;
            // 
            // txtStuBlock
            // 
            this.txtStuBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStuBlock.Location = new System.Drawing.Point(421, 364);
            this.txtStuBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStuBlock.Name = "txtStuBlock";
            this.txtStuBlock.Size = new System.Drawing.Size(233, 23);
            this.txtStuBlock.TabIndex = 17;
            this.txtStuBlock.TextChanged += new System.EventHandler(this.txtStuBlock_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Block/Section:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(693, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Issue And Return Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(775, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Date Borrowed:";
            // 
            // dtdateb
            // 
            this.dtdateb.Location = new System.Drawing.Point(720, 189);
            this.dtdateb.Name = "dtdateb";
            this.dtdateb.Size = new System.Drawing.Size(200, 23);
            this.dtdateb.TabIndex = 20;
            // 
            // dtdueDate
            // 
            this.dtdueDate.Location = new System.Drawing.Point(720, 243);
            this.dtdueDate.Name = "dtdueDate";
            this.dtdueDate.Size = new System.Drawing.Size(200, 23);
            this.dtdueDate.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(792, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Due Date";
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(711, 349);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(102, 38);
            this.btnBorrow.TabIndex = 23;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(827, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 38);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // FrmAddborrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dtdueDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtdateb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStuBlock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStuFullName);
            this.Controls.Add(this.txtstuLcNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.txtBookDDC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbookTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbookAssesion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddborrowBook";
            this.Load += new System.EventHandler(this.FrmAddborrowBook_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookAssesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookDDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label CLOSE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStuFullName;
        private System.Windows.Forms.TextBox txtstuLcNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtStuBlock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtdateb;
        private System.Windows.Forms.DateTimePicker dtdueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnClear;
    }
}