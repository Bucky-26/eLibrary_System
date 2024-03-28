using System;
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
    }
}
