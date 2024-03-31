using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary_System
{
    public class IssueBookInfo
    {
        public int Id { get; set; }
        public string assesion_number { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string card_number { get; set; }
        public string studentName { get; set; }
        public string GLevel { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateReturn { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string FineAmount { get; set; }
        public string Payment_Status { get; set; }
        public int DaysLate { get; set; }

        public static List<IssueBookInfo> DisplayIssuedBooks(string SearchQry)
        {
            var Info = new List<IssueBookInfo>();
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                try
                {
                    string sql = @"SELECT * FROM BorrowRecordsView WHERE ASESSION_NUM Like @SQ OR TITLE Like @SQ OR Lc_Num Like @SQ OR MemberName Like @SQ OR STATUS Like @SQ "; 
                    SqlCommand com = new SqlCommand(sql, con);
                    con.Open();
                    com.Parameters.AddWithValue("@SQ", $"%{SearchQry}%");
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        IssueBookInfo issueInfo = new IssueBookInfo();
                        issueInfo.Id = Convert.ToInt32(reader["BorrowID"]);
                        issueInfo.assesion_number = reader["ASESSION_NUM"].ToString();
                        issueInfo.title = reader["TITLE"].ToString();
                        issueInfo.card_number = reader["LC_Num"].ToString();
                        issueInfo.studentName = reader["MemberName"].ToString();
                        issueInfo.GLevel =reader["DATE_BORROWED"].ToString();

                        issueInfo.DateIssue = Convert.ToDateTime(reader["DATE_BORROWED"]);
                        issueInfo.DueDate = Convert.ToDateTime(reader["DUE_DATE"]);
                        issueInfo.Status = reader["STATUS"].ToString();
                        

                        Info.Add(issueInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Info;
        }

        /* ReturnBooks Display */

        public static List<IssueBookInfo> DisplayReturnBooks(string SearchQry)
        {
            var Info = new List<IssueBookInfo>();
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                try
                {
                    string sql = @"SELECT * FROM BorrowRecordsView WHERE ASESSION_NUM Like @SQ OR TITLE Like @SQ OR Lc_Num Like @SQ OR MemberName Like @SQ OR STATUS Like @SQ ";
                    SqlCommand com = new SqlCommand(sql, con);
                    con.Open();
                    com.Parameters.AddWithValue("@SQ", $"%{SearchQry}%");
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        IssueBookInfo issueInfo = new IssueBookInfo();
                        issueInfo.Id = Convert.ToInt32(reader["BorrowID"]);
                        issueInfo.assesion_number = reader["ASESSION_NUM"].ToString();
                        issueInfo.title = reader["TITLE"].ToString();
                        issueInfo.card_number = reader["LC_Num"].ToString();
                        issueInfo.studentName = reader["MemberName"].ToString();
                        issueInfo.GLevel = reader["DATE_BORROWED"].ToString();
                        issueInfo.Remarks = reader["REMARKS"].ToString();
                        issueInfo.DateIssue = Convert.ToDateTime(reader["DATE_BORROWED"]);
                        issueInfo.DueDate = Convert.ToDateTime(reader["DUE_DATE"]);


                        Info.Add(issueInfo);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Info;
        }


        // End
        public void IssueBook(IssueBookInfo newInfo)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                try
                {
                    string sql = @"INSERT INTO BorrowRecords (ASESSION_NUM, LC_Num, DATE_BORROWED, DUE_DATE, STATUS, REMARKS) VALUES (@ASESSION_NUM, @LC_Num, @DATE_BORROWED, @DUE_DATE, @STATUS, @REMARKS)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@ASESSION_NUM", newInfo.assesion_number);
                    com.Parameters.AddWithValue("@LC_Num", newInfo.card_number);
                    com.Parameters.AddWithValue("@DATE_BORROWED", newInfo.DateIssue);
                    com.Parameters.AddWithValue("@DUE_DATE", newInfo.DueDate);
                    com.Parameters.AddWithValue("@STATUS", newInfo.Status);
                    com.Parameters.AddWithValue("@REMARKS", newInfo.Remarks);

                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }


        //DeleteRecord 
        public void DeleteIssue(IssueBookInfo info)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))

            {
                try
                {
                    string sql = @"DELETE FROM BorrowRecords WHERE BorrowID=@ID";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.AddWithValue("@ID", info.Id);
                    
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public void returnIssue(IssueBookInfo newInfo)
        {
            using (SqlConnection con = new SqlConnection(crud.connection))
            {
                string sql = @"UPDATE BorrowRecords SET STATUS = @STATS, DATE_RETURN = @Rdate,  REMARKS = @remarks, DaysLate = @DayLate WHERE BorrowID = @ID";
                SqlCommand com = new SqlCommand(sql, con);

                // Add parameters
                com.Parameters.AddWithValue("@STATS", newInfo.Status);
                com.Parameters.AddWithValue("@Rdate", newInfo.DateReturn);
                com.Parameters.AddWithValue("@remarks", newInfo.Remarks);
                com.Parameters.AddWithValue("@DayLate", newInfo.DaysLate);
                com.Parameters.AddWithValue("@ID", newInfo.Id);

                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating BorrowRecords: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }


    }
}
