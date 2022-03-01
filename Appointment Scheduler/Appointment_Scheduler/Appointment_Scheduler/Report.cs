using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduler
{
    public class Report
    {
        private readonly MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
        private MySqlCommand sqlCommand;
        private MySqlDataReader reader;
        private string sqlString;

        public List<object> GetScheduleReport()
        {
            List<object> scheduleReport = new List<object>();

            sqlString = Queries.GetScheduleReportQuery();
            sqlCommand = new MySqlCommand(sqlString, connection);
            
            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        scheduleReport.Add(new
                        {
                            Start = reader.GetDateTime("start").ToLocalTime(),
                            End = reader.GetDateTime("end").ToLocalTime(),
                            UserName = reader.GetString("userName"),
                            UserID = reader.GetInt32("userId")
                        });
                    }
                    reader.Close();
                }
                connection.Close();
            }
            catch (MySqlException dbEx)
            {
                connection.Close();
                Common.WriteToLog(dbEx.Message);
                MessageBox.Show("MySql : " + dbEx.Message);
            }
            catch (Exception e)
            {
                connection.Close();
                Common.WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
            }
            return scheduleReport;
        }

        public SortedDictionary<string, int> GetAppointmentsReport(DateTime start, DateTime end)
        {
            SortedDictionary<string, int> apptReport = new SortedDictionary<string, int>();

            sqlString = Queries.GetAppointmentsReportQuery(
                Common.ConvertTimeFormat(start),
                Common.ConvertTimeFormat(end));

            sqlCommand = new MySqlCommand(sqlString, connection);

            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        apptReport.Add(reader.GetString("type"), reader.GetInt32("COUNT(type)"));
                    }
                    reader.Close();
                }
                connection.Close();
            }
            catch (MySqlException dbEx)
            {
                connection.Close();
                Common.WriteToLog(dbEx.Message);
                MessageBox.Show("MySql : " + dbEx.Message);
            }
            catch (Exception e)
            {
                connection.Close();
                Common.WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
            }
            return apptReport;
        }

        public List<object> GetPrimeTimeReport()
        {
            List<object> primeTimeReport = new List<object>();

            sqlString = Queries.GetPrimeTimeReport();

            sqlCommand = new MySqlCommand(sqlString, connection);
            
            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime dt = new DateTime(DateTime.Now.Year, 1, 1, (int)reader.GetDouble("Hour"), 0, 0).ToLocalTime();
                        string hour = dt.ToString("t", System.Globalization.CultureInfo.CurrentCulture);
                        
                        primeTimeReport.Add(new
                        {
                            Day = reader.GetString("DayName"),
                            AvgHour = hour
                        });
                    }
                    reader.Close();
                }
                connection.Close();
            }
            catch (MySqlException dbEx)
            {
                connection.Close();
                Common.WriteToLog(dbEx.Message);
                MessageBox.Show("MySql : " + dbEx.Message);
            }
            catch (Exception e)
            {
                connection.Close();
                Common.WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
            }
            return primeTimeReport;
        }
    }
}
