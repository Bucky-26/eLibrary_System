using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public static List<BookInfo> GetBooks(string searchQuery)
        {
            List<BookInfo> booksList = new List<BookInfo>();
            SqlConnection con = new SqlConnection(crud.connection);
            SqlCommand com = new SqlCommand();
            SqlDataReader readData;

            try
            {
                con.Open();
                com = new SqlCommand(@"SELECT * FROM BOOKS WHERE ASESSION_NUM LIKE @ASESSION_NUM OR TITLE LIKE @TITLE OR PUBLICATION LIKE @PUBLICATION OR AUTHOR LIKE @AUTHOR", con);
                com.Parameters.AddWithValue("@ASESSION_NUM", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@TITLE", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@PUBLICATION", $"%{searchQuery}%");
                com.Parameters.AddWithValue("@AUTHOR", $"%{searchQuery}%");

                readData = com.ExecuteReader();
                while (readData.Read())
                {
                    BookInfo book = new BookInfo();
                    book.SessionNumber = readData["ASESSION_NUM"].ToString();
                    book.Title = readData["TITLE"].ToString();
                    book.Publication = readData["PUBLICATION"].ToString();
                    book.Author = readData["AUTHOR"].ToString();
                    book.ReleaseDate = DateTime.Parse(readData["RELEASE_DATE"].ToString());
                    book.SubjectArea = readData["SUBJECT_AREA"].ToString();
                    book.Pages = Convert.ToInt32(readData["PAGES"]);
                    book.DdcNumber = readData["DDC_NUM"].ToString();

                    booksList.Add(book);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return booksList;
        }
    }
}
