using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eLibrary_System
{
    public class BookInfo
    {
        public string SessionNumber { get; set; }
        public string Title { get; set; }
        public string Publication { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string SubjectArea { get; set; }
        public int Pages { get; set; }
        public string DdcNumber { get; set; }

        public string location { get; set; }

        public static List<DDCInfo> LoadDDC(string QQsearch)
        {
            var list = new List<DDCInfo>();
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                string sqlQ = @"SELECT * FROM DDCInfo WHERE Category like @sq OR DeweyDecimal like @sq";
                SqlCommand com = new SqlCommand(sqlQ, con);
                com.Parameters.AddWithValue("@sq",$"%{QQsearch}%");
                con.Open();

                SqlDataReader readd =  com.ExecuteReader();
                while (readd.Read())
                {
                    DDCInfo ddcI = new DDCInfo();
                    ddcI.Category = readd["Category"].ToString();
                    ddcI.deweyDecimal = readd["DeweyDecimal"].ToString();
                    ddcI.DDCID = readd["ID"].ToString();
                    list.Add(ddcI);
                }

                con.Close();
                readd.Close();   
            }
            return list;
        }
        public void deleteDDC(DDCInfo ddcI)
        {
            using(SqlConnection con = new SqlConnection())
            {
                string SQLQUERY = @"DELETE FROM DDCInfo WHERE ID= @ID";
                SqlCommand com = new SqlCommand(SQLQUERY, con);
                com.Parameters.AddWithValue("@ID", ddcI.DDCID);

                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch ( Exception ex)
                {
                    con.Close();
                    throw ex;
                }
                }
        }
        public void ddcUpdate(DDCInfo newddc)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                string sql = @"UPDATE DDCInfo 
                    SET Category = @cat, DeweyDecimal = @dewey
                    WHERE ID = @ID";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@cat", newddc.Category);
                com.Parameters.AddWithValue("@dewey", newddc.deweyDecimal);
                com.Parameters.AddWithValue("@ID", newddc.DDCID);

                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating DDCInfo: " + ex.Message);
                }
                finally
                {
                    if (con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }

        public static void InsertDDc(DDCInfo newddc)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
               
                try
                {
                    string sql = @"INSERT INTO DDCInfo(Category,DeweyDecimal) VALUES(@Category,@DeweyDecimal)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@Category", newddc.Category);
                    com.Parameters.AddWithValue("@DeweyDecimal", newddc.deweyDecimal);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
         
                
         
        }
        public static List<BookInfo> GetBooks(string searchQuery)
        {
            List<BookInfo> booksList = new List<BookInfo>();
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                string query = @"SELECT * FROM BOOKS WHERE ASESSION_NUM LIKE @ASESSION_NUM OR TITLE LIKE @TITLE OR PUBLICATION LIKE @PUBLICATION OR AUTHOR LIKE @AUTHOR";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@ASESSION_NUM", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@TITLE", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@PUBLICATION", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@AUTHOR", $"%{searchQuery}%");

                con.Open();
                SqlDataReader readData = com.ExecuteReader();
                while (readData.Read())
                {
                    BookInfo book = new BookInfo();
                    book.SessionNumber = readData["ASESSION_NUM"].ToString();
                    book.Title = readData["TITLE"].ToString();
                    book.Publication = readData["PUBLICATION"].ToString();
                    book.Author = readData["AUTHOR"].ToString();
                    book.ReleaseDate = Convert.ToDateTime(readData["RELEASE_DATE"]);
                    book.SubjectArea = readData["SUBJECT_AREA"].ToString();
                    book.Pages = Convert.ToInt32(readData["PAGES"]);
                    book.DdcNumber = readData["DDC_NUM"].ToString();

                    booksList.Add(book);
                }
            }
            return booksList;
        }

        public static void InsertNew(BookInfo book)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                string query = @"INSERT INTO BOOKS (ASESSION_NUM, TITLE, AUTHOR, RELEASE_DATE, DDC_NUM, PUBLICATION, SUBJECT_AREA, PAGES, LOCATION)
                                VALUES (@ASESSION_NUM, @TITLE, @AUTHOR, @RELEASE_DATE, @DDC_NUM, @PUBLICATION, @SUBJECT_AREA, @PAGES, @LOCATION)";
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.AddWithValue("@ASESSION_NUM", book.SessionNumber);
                com.Parameters.AddWithValue("@TITLE", book.Title);
                com.Parameters.AddWithValue("@AUTHOR", book.Author);
                com.Parameters.AddWithValue("@RELEASE_DATE", book.ReleaseDate);
                com.Parameters.AddWithValue("@DDC_NUM", book.DdcNumber);
                com.Parameters.AddWithValue("@PUBLICATION", book.Publication);
                com.Parameters.AddWithValue("@SUBJECT_AREA", book.SubjectArea);
                com.Parameters.AddWithValue("@PAGES", book.Pages);
                com.Parameters.AddWithValue("@LOCATION", book.location);

                con.Open();
                com.ExecuteNonQuery();
            }
            MessageBox.Show("Books has been updated in the database successfully", "PNS eLibrary [SYSTEM]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class DDCInfo
    {
        public string DDCID { get; set; }
        public string Category { get; set; }
        public string deweyDecimal { get; set; }
    }
}
