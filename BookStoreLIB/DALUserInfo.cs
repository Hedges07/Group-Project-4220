using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace BookStoreLIB
{
    internal class DALUserInfo
    {

        public int UserCheck(string userName)
        {
            var conn = new SqlConnection(Properties.Settings.Default.asConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select UserID from UserData where " + "UserName = @UserName";
                cmd.Parameters.AddWithValue("@UserName", userName);
                conn.Open();
                int userId = (int)cmd.ExecuteScalar();

                if (userId > 0) return userId;
                else return -1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public bool LogIn(int userID, string password)
        {
            var conn = new SqlConnection(Properties.Settings.Default.asConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select UserID from UserData where " + "userID = @UserId and Password = @Password";
                cmd.Parameters.AddWithValue("@UserId", userID);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                int userId = (int)cmd.ExecuteScalar();//if the password is wrong, it will go to the catch statement anyway.

                if (userId > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }

}