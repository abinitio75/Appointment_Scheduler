using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Appointment_Scheduler
{
    public class Common
    {
        public bool Login(string userName, string password, ref bool exception)
        {
            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            string sqlString = Queries.GetLoginQuery(ref userName, ref password);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);
            MySqlDataReader reader;
            bool login;

            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    User.SetUserID(reader.GetInt32("userId"));
                    User.SetUserName(reader.GetString("userName"));
                    WriteToLog(true);
                    login = true;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    login = false;
                }
            }
            catch (MySqlException dbEx)
            {
                connection.Close();
                exception = true;
                WriteToLog(dbEx.Message);
                MessageBox.Show("MySql : " + dbEx.Message);
                login = false;
            }
            catch(Exception e)
            {
                connection.Close();
                exception = true;
                WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
                login = false;
            }
            return login;
        }

        public static void WriteToLog(bool login)
        {
            System.IO.File.AppendAllText("Log.txt", " - "
            + (login ? "Login" : "Logout") + " by \"" + User.UserName + "\", UserID = "
            + User.UserID + " @ " + DateTime.Now + "\n");
        }

        public static void WriteToLog(string message) => System.IO.File.AppendAllText("ErrorLog.txt", $"{message}" + " : " + DateTime.Now + "\n");

        public static string ConvertTimeFormat(DateTime dt) => dt.ToString("yyyy-MM-dd HH:mm:ss");
    }
}