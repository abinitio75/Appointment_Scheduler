using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Appointment_Scheduler
{
    public class Appointment
    {
        public DateTime Start { get; }
        public DateTime End { get; }
        public string CustomerName { get; }
        public string Title { get; }
        public string Description { get; }
        public string Type{ get; }
        public string Location { get; }
        public string Contact { get; }
        public string Url { get; }
        public int AppointmentID { get; }
        public int CustomerID { get; }
        
        public Appointment() { }

        public Appointment(string customerName, DateTime start, DateTime end, string type, string title, string description,
            string location, string contact, int appointmentID, string url, int customerID)
        {
            Start = start;
            End = end;
            CustomerName = customerName;
            Type = type;
            Title = title;
            Description = description;
            AppointmentID = appointmentID;
            Location = location;
            Contact = contact;
            Url = url;
            CustomerID = customerID;
        }
        
        public void Add(int customerID, string title, string description,
             string type, string location, string contact, ref string start, ref string end)
        {   
            string now = Common.ConvertTimeFormat(DateTime.UtcNow);

            ExecuteCommand(Commands.GetAddAppointmentCommand(ref customerID, ref title,
                ref description, ref type, ref location, ref contact, ref start, ref end, ref now));
        }

        public void Update(int appointmentID, int customerID, string title, string description,
            string type, string location, string contact, ref string start, ref string end)
        {
            ExecuteCommand(Commands.GetUpdateAppointmentCommand(ref appointmentID, ref customerID, title, description,
                type, location, contact, ref start, ref end));
        }

        public void Delete(int appointmentID) => ExecuteCommand(Commands.GetDeleteAppointmentCommand(ref appointmentID));
        
        private void ExecuteCommand(string sqlString)
        {
            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);

            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException dbEx)
            {
                connection.Close();
                Common.WriteToLog(dbEx.Message);
                MessageBox.Show("MySql : " + dbEx.Message);
            }
            catch(Exception e)
            {
                connection.Close();
                Common.WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
            }
            connection.Close();
        }
        
        public SortedList<DateTime, Appointment> GetAppointments(bool month)
        {
            SortedList<DateTime, Appointment> appointmentList = new SortedList<DateTime, Appointment>();

            string dtBegin = Common.ConvertTimeFormat(DateTime.UtcNow);
            string dtEnd = month ? Common.ConvertTimeFormat(DateTime.UtcNow.AddMonths(1)) : Common.ConvertTimeFormat(DateTime.UtcNow.AddDays(7));
            string sqlString = Queries.GetAppointmentQuery(User.UserID, ref dtBegin, ref dtEnd);
            
            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        appointmentList.Add(Convert.ToDateTime(reader.GetDateTime("start")).ToLocalTime(),
                            new Appointment(reader.GetString("customerName"), Convert.ToDateTime(reader.GetDateTime("start")).ToLocalTime(),
                            Convert.ToDateTime(reader.GetDateTime("end")).ToLocalTime(), reader.GetString("type"),
                            reader.GetString("title"), reader.GetString("description"), reader.GetString("location"), reader.GetString("contact"),
                            reader.GetInt32("appointmentId"), reader.GetString("url"), reader.GetInt32("customerId")));
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
            catch(Exception e)
            {
                connection.Close();
                Common.WriteToLog(e.Message);
                MessageBox.Show("Application : " + e.Message);
            }
            return appointmentList;
        }
        
        public bool IsOverlappingAppointment(ref DateTime start, ref DateTime end)
        {   
            string sqlString = Queries.GetOverlappingAppointmentQuery(Common.ConvertTimeFormat(start), Common.ConvertTimeFormat(end));

            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);

            try
            {
                connection.Open();
                bool overlap = (bool)sqlCommand.ExecuteScalar();
                connection.Close();
                return overlap;
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
            return false;
        }
    }
}
