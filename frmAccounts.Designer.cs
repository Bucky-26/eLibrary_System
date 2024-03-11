
namespace eLibrary_System
{
    partial class frmAccounts
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
            this.frmAcc_pns_header = new System.Windows.Forms.Panel();
            this.frmAcc_btnClose = new System.Windows.Forms.Button();
            this.frmAcc_pnl_body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmAcc_btnCreateAcc = new System.Windows.Forms.Button();
            this.frmAcc_pns_header.SuspendLayout();
            this.frmAcc_pnl_body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmAcc_pns_header
            // 
            this.frmAcc_pns_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.frmAcc_pns_header.Controls.Add(this.frmAcc_btnClose);
            this.frmAcc_pns_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmAcc_pns_header.Location = new System.Drawing.Point(0, 0);
            this.frmAcc_pns_header.Name = "frmAcc_pns_header";
            this.frmAcc_pns_header.Size = new System.Drawing.Size(933, 38);
            this.frmAcc_pns_header.TabIndex = 0;
            // 
            // frmAcc_btnClose
            // 
            this.frmAcc_btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.frmAcc_btnClose.FlatAppearance.BorderSize = 0;
            this.frmAcc_btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmAcc_btnClose.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAcc_btnClose.ForeColor = System.Drawing.Color.White;
            this.frmAcc_btnClose.Location = new System.Drawing.Point(852, 6);
            this.frmAcc_btnClose.Name = "frmAcc_btnClose";
            this.frmAcc_btnClose.Size = new System.Drawing.Size(75, 26);
            this.frmAcc_btnClose.TabIndex = 0;
            this.frmAcc_btnClose.Text = "CLOSE";
            this.frmAcc_btnClose.UseVisualStyleBackColor = false;
            this.frmAcc_btnClose.Click += new System.EventHandler(this.frmAcc_btnClose_Click);
            // 
            // frmAcc_pnl_body
            // 
            this.frmAcc_pnl_body.Controls.Add(this.panel1);
            this.frmAcc_pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmAcc_pnl_body.Location = new System.Drawing.Point(0, 38);
            this.frmAcc_pnl_body.Name = "frmAcc_pnl_body";
            this.frmAcc_pnl_body.Size = new System.Drawing.Size(933, 493);
            this.frmAcc_pnl_body.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.frmAcc_btnCreateAcc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 45);
            this.panel1.TabIndex = 0;
            // 
            // frmAcc_btnCreateAcc
            // 
            this.frmAcc_btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.frmAcc_btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.frmAcc_btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frmAcc_btnCreateAcc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAcc_btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.frmAcc_btnCreateAcc.Location = new System.Drawing.Point(12, 5);
            this.frmAcc_btnCreateAcc.Name = "frmAcc_btnCreateAcc";
            this.frmAcc_btnCreateAcc.Size = new System.Drawing.Size(202, 33);
            this.frmAcc_btnCreateAcc.TabIndex = 0;
            this.frmAcc_btnCreateAcc.Text = "CREATE NEW ACCOUNT";
            this.frmAcc_btnCreateAcc.UseVisualStyleBackColor = false;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 531);
            this.ControlBox = false;
            this.Controls.Add(this.frmAcc_pnl_body);
            this.Controls.Add(this.frmAcc_pns_header);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccounts";
            this.frmAcc_pns_header.ResumeLayout(false);
            this.frmAcc_pnl_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel frmAcc_pns_header;
        private System.Windows.Forms.Button frmAcc_btnClose;
        private System.Windows.Forms.Panel frmAcc_pnl_body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button frmAcc_btnCreateAcc;
    }
}