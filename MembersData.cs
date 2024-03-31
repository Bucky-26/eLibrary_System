using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace eLibrary_System
{
    public class MembersData
    {
        SqlConnection _newConnection;
        SqlCommand _command;

        public void NewMembers(membersInfo member, byte[] photoBytes)
        {
            _newConnection = new SqlConnection(crud.connection);

            try
            {
                _newConnection.Open();
                _command = new SqlCommand("INSERT INTO MEMBERS (LC_Num, LRN_Num, NAME, DATE_OF_BIRTH, GENDER, ADDRESS, CONTACT_NUMBER, GRADE_LEVEL, Section, ADVISER, PHOTO) VALUES(@LC_Num, @LRN_Num, @NAME, @DATE_OF_BIRTH, @GENDER, @ADDRESS, @CONTACT_NUM, @GRADE_LEVEL, @Section, @ADVISER, @PHOTO)", _newConnection);

                _command.Parameters.AddWithValue("@LC_Num", member.LC_Num);
                _command.Parameters.AddWithValue("@LRN_Num", member.LRN_Num);
                _command.Parameters.AddWithValue("@NAME", member.NAME);
                _command.Parameters.AddWithValue("@DATE_OF_BIRTH", member.DATE_OF_BIRTH);
                _command.Parameters.AddWithValue("@GENDER", member.GENDER);
                _command.Parameters.AddWithValue("@ADDRESS", member.ADDRESS);
                _command.Parameters.AddWithValue("@CONTACT_NUM", member.CONTACT_NUMBER);
                _command.Parameters.AddWithValue("@GRADE_LEVEL", member.GRADE_LEVEL);
                _command.Parameters.AddWithValue("@Section", member.Section);
                _command.Parameters.AddWithValue("@ADVISER", member.ADVISER);

                _command.Parameters.AddWithValue("@PHOTO", photoBytes);

                _command.ExecuteNonQuery();
                _newConnection.Close();
            }
            catch (Exception ex)
            {
                _newConnection.Close();
                throw ex;
            }
        }

        public List<membersInfo> LoadMembers(string searchQ)
        {
            List<membersInfo> membersList = new List<membersInfo>();
            _newConnection = new SqlConnection(crud.connection);

            try
            {
                _newConnection.Open();
                string query = @"SELECT LC_Num, LRN_Num, NAME, DATE_OF_BIRTH, GENDER, ADDRESS, CONTACT_NUMBER, GRADE_LEVEL, Section, ADVISER, PHOTO 
                         FROM MEMBERS 
                         WHERE LC_Num Like @SQUERY OR LRN_Num Like @SQUERY OR NAME Like @SQUERY OR GRADE_LEVEL Like @SQUERY OR ADVISER like @SQUERY";
                _command = new SqlCommand(query, _newConnection);
                _command.Parameters.AddWithValue("@SQUERY", "%" + searchQ + "%");
                SqlDataReader reader = _command.ExecuteReader();

                while (reader.Read())
                {
                    membersInfo member = new membersInfo();
                    member.LC_Num = reader["LC_Num"].ToString();
                    member.LRN_Num = reader["LRN_Num"].ToString();
                    member.NAME = reader["NAME"].ToString();
                    member.DATE_OF_BIRTH = Convert.ToDateTime(reader["DATE_OF_BIRTH"]);
                    member.GENDER = reader["GENDER"].ToString();
                    member.ADDRESS = reader["ADDRESS"].ToString();
                    member.CONTACT_NUMBER = reader["CONTACT_NUMBER"].ToString();
                    member.GRADE_LEVEL = reader["GRADE_LEVEL"].ToString();
                    member.Section = reader["Section"].ToString();
                    member.ADVISER = reader["ADVISER"].ToString();

                    if (reader["PHOTO"] != DBNull.Value)
                    {
                        member.PHOTO = (byte[])reader["PHOTO"];
                    }
                    else
                    {
                        member.PHOTO = null; 
                    }

                    membersList.Add(member);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw ex;
            }
            finally
            {
                if (_newConnection != null && _newConnection.State == ConnectionState.Open)
                {
                    _newConnection.Close();
                }
            }

            return membersList;
        }

    }
}
