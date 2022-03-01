using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_Scheduler
{
    public class Customer
    {
        public int CustomerID { get; }
        public string CustomerName { get; }
        public int Active { get; }
        public int AddressID { get; set; }
        public string Address { get; }
        public int CityID { get; set; }
        public string City { get; }
        public int CountryID { get; set; }
        public string Country { get; }
        public string Phone { get; }
        public string Address2 { get; }
        public string PostalCode { get; }

        public Customer() { }

        public Customer(string customerName, int customerID, int active, string address, string address2, int addressID, string city, int cityID, string country,
            int countryID, string phone, string postalCode)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            Active = active;
            AddressID = addressID;
            Address = address;
            CityID = cityID;
            City = city;
            CountryID = countryID;
            Country = country;
            Phone = phone;
            Address2 = address2;
            PostalCode = postalCode;
        }

        public void Add(string country, string city, string address, string address2, string postalCode,
                string phone, string customerName, int active, ref List<Customer> customerList)
        {
            string now = Common.ConvertTimeFormat(DateTime.UtcNow);

            int countryID = customerList.Where(cust => cust.Country == country).Select(cust => cust.CountryID).DefaultIfEmpty<int>(0).FirstOrDefault<int>();
            int cityID = customerList.Where(cust => cust.City == city).Select(cust => cust.CityID).DefaultIfEmpty<int>(0).FirstOrDefault<int>();
            int lastInsertID = 0;

            if (countryID == 0)
            {
                ExecuteCommand(Commands.GetAddCountryCommand(ref country, ref now), ref lastInsertID);
                countryID = lastInsertID;
            }
                
            if (cityID == 0)
            {
                ExecuteCommand(Commands.GetAddCityCommand(countryID, ref city, ref now), ref lastInsertID);
                cityID = lastInsertID;
            }

            ExecuteCommand(Commands.GetAddAddressCommand(ref cityID, ref address, ref address2, ref postalCode, ref phone, ref now), ref lastInsertID);
            int addressID = lastInsertID;

            ExecuteCommand(Commands.GetAddCustomerCommand(ref addressID, ref customerName, ref active, ref now));
        }

        private void ExecuteCommand(string sqlString, ref int lastInsertID)
        {
            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);
            
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                lastInsertID = (int)sqlCommand.LastInsertedId;
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
        }

        private void ExecuteCommand(string sqlString)
        {
            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand = new MySqlCommand(sqlString, connection);
            
            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
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
        }

        public void Update(string country, string city, string address, string address2, string postalCode, string phone, string customerName,
            int active, ref Customer customer, ref List<Customer> customerList)
        {
            string now = Common.ConvertTimeFormat(DateTime.UtcNow);

            int countryID = customerList.Where(cust => cust.Country == country).Select(cust => cust.CountryID).DefaultIfEmpty<int>(0).FirstOrDefault<int>();
            int cityID = customerList.Where(cust => cust.City == city).Select(cust => cust.CityID).DefaultIfEmpty<int>(0).FirstOrDefault<int>();
            int lastInsertID = 0;

            if(countryID == 0)
            {
                ExecuteCommand(Commands.GetAddCountryCommand(ref country, ref now), ref lastInsertID);
                customer.CountryID = lastInsertID;
            }
            else
                customer.CountryID = countryID;
            
            if (cityID == 0)
            {
                ExecuteCommand(Commands.GetAddCityCommand(customer.CountryID, ref city, ref now), ref lastInsertID);
                customer.CityID = lastInsertID;
            }
            else
                customer.CityID = cityID;

            ExecuteCommand(Commands.GetUpdateAddressCommand(customer.CityID, ref address, ref address2, ref postalCode, ref phone, ref now, customer.AddressID));
            ExecuteCommand(Commands.GetUpdateCustomerCommand(customer.CustomerID, ref customerName, ref active, ref now));
        }

        public void Delete(int customerID) => ExecuteCommand(Commands.GetDeleteCustomerCommand(ref customerID));

        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();

            MySqlConnection connection = new MySqlConnection(
                ConfigurationManager.ConnectionStrings["MySqlConn"].ConnectionString);
            MySqlCommand sqlCommand;
            MySqlDataReader reader;

            string sqlString = Queries.GetCustomerListQuery();
            
            sqlCommand = new MySqlCommand(sqlString, connection);

            try
            {
                connection.Open();
                reader = sqlCommand.ExecuteReader();
                
                if (reader.HasRows)
                {   
                    while (reader.Read())
                    {
                        customerList.Add(new Customer(reader.GetString("customerName"), reader.GetInt32("customerId"), reader.GetInt32("active"),
                             reader.GetString("address"), reader.GetString("address2"), reader.GetInt32("addressId"), reader.GetString("city"),
                             reader.GetInt32("cityId"), reader.GetString("country"), reader.GetInt32("countryId"), reader.GetString("phone"),
                             reader.GetString("postalCode")));
                    }
                    customerList.Sort(new Comparison<Customer>((x, y) => string.Compare(x.CustomerName, y.CustomerName)));
                }
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
            return customerList;
        }
    }
}
