using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using CsvHelper;
using System.IO;
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;

using System.Globalization;
namespace eLibrary_System
{
    public partial class books : Form
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader readData;
        string IDDDC;
        public books()
        {
            con = new SqlConnection(crud.connection);
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_addBooks newAdd = new frm_addBooks(this);
            newAdd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadBooks()
        {
            try
            {
                dgviewBook.Rows.Clear();
                con.Open();
                com = new SqlCommand(@"SELECT * FROM BOOKS WHERE ASESSION_NUM LIKE @ASESSION_NUM OR  TITLE LIKE @TITLE OR PUBLICATION LIKE @PUBLICATION OR AUTHOR LIKE @AUTHOR ", con);
                com.Parameters.AddWithValue("@ASESSION_NUM", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@TITLE", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@PUBLICATION", $"%{txtSearchBooks.Text}%");
                com.Parameters.AddWithValue("@AUTHOR", $"%{txtSearchBooks.Text}%");

                readData = com.ExecuteReader();
                while (readData.Read())
                {
                    dgviewBook.Rows.Add(readData["ASESSION_NUM"].ToString(), readData["TITLE"].ToString(), readData["PUBLICATION"].ToString(), readData["AUTHOR"].ToString(), DateTime.Parse(readData["RELEASE_DATE"].ToString()).ToShortDateString(), readData["SUBJECT_AREA"].ToString(), readData["PAGES"].ToString(), readData["DDC_NUM"].ToString());
                }
                con.Close();
                readData.Close();
            }catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void editBooks(string assesion)
        {
            try
            {
                con.Open();
                com = new SqlCommand("SELECT * FROM BOOKS WHERE ASESSION_NUM=@ASSESION", con);
                com.Parameters.AddWithValue("@ASSESION", assesion);
                readData = com.ExecuteReader();

                if (readData.Read())
                {
                    frm_addBooks newUpdate = new frm_addBooks(this);
                    newUpdate.txtAssesion.Text = readData["ASESSION_NUM"].ToString();
                    newUpdate.txtTitle.Text = readData["TITLE"].ToString();
                    newUpdate.txtAuthor.Text = readData["AUTHOR"].ToString();
                    newUpdate.dtrD.Value = Convert.ToDateTime(readData["RELEASE_DATE"]);
                    newUpdate.txtPub.Text = readData["PUBLICATION"].ToString();
                    newUpdate.txtSubArea.Text = readData["SUBJECT_AREA"].ToString();
                    newUpdate.txtPageNum.Text = readData["PAGES"].ToString();
                    newUpdate.txtddcNo.Text = readData["DDC_NUM"].ToString();
                    newUpdate.btnUpdate.Enabled = true;
                    newUpdate.button1.Enabled = false;
                    newUpdate.txtAssesion.ReadOnly = true;
                    readData.Close();
                    con.Close();

                    newUpdate.ShowDialog();
                }
                else
                {
                    readData.Close();
                    con.Close();
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void DeleteBook(string asession)
        {
            try
            {
                con.Open();
                com = new SqlCommand("DELETE FROM BOOKS WHERE ASESSION_NUM=@ASSESION", con);
                com.Parameters.AddWithValue("@ASSESION", asession);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book record deleted successfully.", "eLibrary System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadBooks();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void DisplayBooks()
        {
            try
            {
                dgviewBook.Rows.Clear();
                var NewBookList = BookInfo.GetBooks(txtSearchBooks.Text);
                foreach (var bookinfos in NewBookList) {
                    dgviewBook.Rows.Add(bookinfos.SessionNumber, bookinfos.Title, bookinfos.Publication, bookinfos.Author,bookinfos.ReleaseDate.ToShortDateString(), bookinfos.SubjectArea, bookinfos.Pages, bookinfos.DdcNumber);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ ERROR ]",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void dgviewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgviewBook.Columns[e.ColumnIndex].Name;
            
            switch (col_name)
            {
                case "edit":
                    editBooks(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    break;
                case "delete":
                    DialogResult deleteQ = MessageBox.Show("Do you want to Delete this book?","eLibrary System!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(deleteQ == DialogResult.Yes)
                    {
                        DeleteBook(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    break;
            }
        }

        private void txtSearchBooks_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            loadBooks();
        }


        private void ImportExcel(string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = null;
            Worksheet excelWorksheet = null;

            try
            {
                con.Open();
                excelWorkbook = excelApp.Workbooks.Open(filePath);

                excelWorksheet = excelWorkbook.Sheets[1];

                Range excelRange = excelWorksheet.UsedRange;

                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                for (int row = 2; row <= rowCount; row++)
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;

                    string asession = excelRange.Cells[row, 1].Value?.ToString();
                    string title = excelRange.Cells[row, 2].Value?.ToString();
                    string author = excelRange.Cells[row, 3].Value?.ToString();

                    DateTime releaseDate;
                    if (!DateTime.TryParseExact(excelRange.Cells[row, 4].Value?.ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate))
                    {
                        MessageBox.Show($"Error parsing date in row {row}.");
                        continue; 
                    }

                    string ddcNum = excelRange.Cells[row, 5].Value?.ToString();
                    string publication = excelRange.Cells[row, 6].Value?.ToString();
                    string subjectArea = excelRange.Cells[row, 7].Value?.ToString();
                    int pages = int.Parse(excelRange.Cells[row, 8].Value?.ToString());
                    string location = excelRange.Cells[row, 9].Value?.ToString();

                    com.CommandText = @"INSERT INTO BOOKS (ASESSION_NUM, TITLE, AUTHOR, RELEASE_DATE, DDC_NUM, PUBLICATION, SUBJECT_AREA, PAGES, LOCATION)
                               VALUES (@ASESSION_NUM, @TITLE, @AUTHOR, @RELEASE_DATE, @DDC_NUM, @PUBLICATION, @SUBJECT_AREA, @PAGES, @LOCATION)";

                    com.Parameters.AddWithValue("@ASESSION_NUM", asession);
                    com.Parameters.AddWithValue("@TITLE", title);
                    com.Parameters.AddWithValue("@AUTHOR", author);
                    com.Parameters.AddWithValue("@RELEASE_DATE", releaseDate);
                    com.Parameters.AddWithValue("@DDC_NUM", ddcNum);
                    com.Parameters.AddWithValue("@PUBLICATION", publication);
                    com.Parameters.AddWithValue("@SUBJECT_AREA", subjectArea);
                    com.Parameters.AddWithValue("@PAGES", pages);
                    com.Parameters.AddWithValue("@LOCATION", location);

                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Import completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during import: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                excelWorkbook.Close(false);
                excelApp.Quit();

                ReleaseComObject(excelWorksheet);
                ReleaseComObject(excelWorkbook);
                ReleaseComObject(excelApp);

                con.Close();
            }
        }




        private void ReleaseComObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show($"Error releasing COM object: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileDialogImportCSV.Filter = "Excel Files|*.xlsx;*.xls";
            FileDialogImportCSV.Title = "Select an Excel File";

            if (FileDialogImportCSV.ShowDialog() == DialogResult.OK)
            {
                string filePath = FileDialogImportCSV.FileName;

                try
                {
                    ImportExcel(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during import: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class Book
        {
            public string Assesion { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string DdcNum { get; set; }
            public string Publication { get; set; }
            public string SubjectArea { get; set; }
            public int Pages { get; set; }
            public string Location { get; set; }
        }

       



        public void addddc()
        {
            try
            {
                DDCInfo newDDcInfo = new DDCInfo()
                {
                    Category = txtCategory.Text,
                    deweyDecimal = txtdewey.Text
                };
                BookInfo.InsertDDc(newDDcInfo);
                MessageBox.Show("The data has been added on database", "PNS eLMS [ System ]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "" || txtdewey.Text == "")
            {
                MessageBox.Show("Please fill all fields", "PNS eLMS [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                addddc();
                dsplayddc(kryptonTextBox1.Text);
                cleartxt();
            }
        }

        public void UpdateDDC()
        {
            try
            {
                DDCInfo newDDcInfo = new DDCInfo()
                {
                    DDCID = IDDDC,
                    Category = txtCategory.Text,
                    deweyDecimal = txtdewey.Text
                };

                BookInfo bookInfo = new BookInfo();

                bookInfo.ddcUpdate(newDDcInfo);

                MessageBox.Show("The data has been added to the database", "PNS eLMS [ System ]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            frm_addBooks newAddbook = new frm_addBooks(this);
            newAddbook.ShowDialog();

        }

        private void dgviewBook_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgviewBook.Columns[e.ColumnIndex].Name;

            switch (col_name)
            {
                case "edit":
                    editBooks(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    break;
                case "delete":
                    DialogResult deleteQ = MessageBox.Show("Do you want to Delete this book?", "eLibrary System!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (deleteQ == DialogResult.Yes)
                    {
                        DeleteBook(dgviewBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                    break;
            }
        }

        private void txtSearchBooks_Click_1(object sender, EventArgs e)
        {
           
        }

        private void txtSearchBooks_TextChanged_1(object sender, EventArgs e)
        {
            loadBooks();
        }
        public void dsplayddc(string sQ) {
            try
            {
                dataGridView1.Rows.Clear();
                var ddcLoad = BookInfo.LoadDDC(sQ);

                foreach(var ddc in ddcLoad)
                {
                    dataGridView1.Rows.Add(ddc.DDCID,ddc.Category,ddc.deweyDecimal);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLMS [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                IDDDC = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtdewey.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            dsplayddc(kryptonTextBox1.Text);
        }

        private void btncl_Click(object sender, EventArgs e)
        {
            txtCategory.Text = "";
            txtdewey.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }
        public void cleartxt()
        {
            txtCategory.Text = "";
            txtdewey.Text = "";
            IDDDC = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "" || txtdewey.Text == "")
            {
                MessageBox.Show("Please fill all fields", "PNS eLMS [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UpdateDDC();
                dsplayddc(kryptonTextBox1.Text);
                cleartxt();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

