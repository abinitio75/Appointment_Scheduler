
namespace Appointment_Scheduler
{
    static class Commands
    {
        public static string GetAddCountryCommand(ref string country, ref string now)
        {
            return "INSERT INTO country (country, createDate, createdBy, lastUpdateBy)" +
                   $" VALUES('{country}', '{now}', '{User.UserName}', '{User.UserName}');";
        }
        
        public static string GetAddCityCommand(int countryID, ref string city, ref string now)
        {
            return "INSERT INTO city(city, countryId, createDate, createdBy, lastUpdateBy)" +
                    $" VALUES('{city}', '{countryID}', '{now}', '{User.UserName}', '{User.UserName}');";
        }
        
        public static string GetAddAddressCommand(ref int cityID, ref string address, ref string address2, ref string postalCode, ref string phone, ref string now)
        {
            return "INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                    $" VALUES('{address}', '{address2}', '{cityID}','{postalCode}','{phone}', '{now}', '{User.UserName}', '{User.UserName}');";
        }
        
        public static string GetAddCustomerCommand(ref int addressID, ref string customerName, ref int active, ref string now)
        {
            return "INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                    $" VALUES('{customerName}', '{addressID}', '{active}', '{now}', '{User.UserName}', '{User.UserName}');";
        }
        
        public static string GetUpdateAddressCommand(int cityID, ref string address, ref string address2, ref string postalCode, ref string phone,
            ref string now, int addressID)
        {
            return $"UPDATE address SET address = '{address}', address2 = '{address2}', cityId = '{cityID}', postalCode = '{postalCode}'," +
                $" phone = '{phone}', lastUpdate = '{now}', lastUpdateBy = '{User.UserName}' WHERE addressId = '{addressID}';";
        }
        
        public static string GetUpdateCustomerCommand(int customerID, ref string customerName, ref int active, ref string now)
        {
            return $"UPDATE customer SET customerName = '{customerName}', active = '{active}', lastUpdate = '{now}'," +
                $" lastUpdateBy = '{User.UserName}' WHERE customer.customerId = '{customerID}'";
        }
        
        public static string GetDeleteCustomerCommand(ref int customerID) => $"DELETE FROM customer WHERE customerId = '{customerID}';";
        
        public static string GetAddAppointmentCommand(ref int customerID, ref string title, ref string description, ref string type,
            ref string location, ref string contact, ref string start, ref string end, ref string now)
        {
            return "INSERT INTO appointment (customerId, title, description, type, location, contact," +
                $" url, start, end, createDate, userId, createdBy, lastUpdateBy) VALUES('{customerID}', '{title}', '{description}'," +
                $" '{type}', '{location}', '{contact}', '{customerID}', '{start}', '{end}', '{now}', '{User.UserID}' , '{User.UserName}', '{User.UserName}');";
        }
        
        public static string GetUpdateAppointmentCommand(ref int appointmentID, ref int customerID, string title, string description, string type,
            string location, string contact, ref string start, ref string end)
        {
            return $"UPDATE appointment SET title = '{title}', description = '{description}'," +
                $"type = '{type}', location = '{location}', contact ='{contact}', url = '{customerID}', start = '{start}'," +
                $" end = '{end}', lastUpdateBy = '{User.UserName}' WHERE appointment.appointmentId = '{appointmentID}';";
        }
        
        public static string GetDeleteAppointmentCommand(ref int appointmentID) => $"DELETE FROM appointment WHERE appointmentId = '{appointmentID}';";
    }
}
