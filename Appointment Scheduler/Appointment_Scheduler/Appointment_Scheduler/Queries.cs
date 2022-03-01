
namespace Appointment_Scheduler
{
    static class Queries
    {
        public static string GetAppointmentQuery(int userID, ref string start, ref string end)
        {
            return "SELECT start, end, customer.customerName, title, description, type, location, contact, url, appointmentId, appointment.customerId" +
                " FROM appointment INNER JOIN customer ON customer.customerId = appointment.customerId AND appointment.start" +
                $" BETWEEN '{start}' AND '{end}' WHERE EXISTS(SELECT appointmentId FROM appointment WHERE appointment.userID = '{userID}');";
        }

        public static string GetOverlappingAppointmentQuery(string start, string end) => $"SELECT EXISTS(SELECT * FROM appointment WHERE start BETWEEN '{start}' AND '{end}' OR end BETWEEN '{start}' AND '{end}');";
        
        public static string GetCustomerListQuery() 
        {
            return "SELECT c.customerId, c.customerName, c.active, c.addressId, a.address, a.address2, a.postalCode, a.phone, a.cityId, ci.city, ci.countryId, co.country" +
                " FROM customer AS c INNER JOIN address AS a ON c.addressId = a.addressId INNER JOIN city AS ci ON a.cityId = ci.cityId" +
                " INNER JOIN country AS co ON ci.countryId = co.countryId;";
        }
        
        public static string GetLoginQuery(ref string userName, ref string password) => $"SELECT userName, userId FROM user WHERE EXISTS(SELECT userName FROM user WHERE user.userName = '{userName}' AND user.password = '{password}');";
        
        public static string GetAppointmentsReportQuery(string rangeBegin, string rangeEnd) => $"SELECT type, COUNT(type) FROM appointment WHERE start BETWEEN '{rangeBegin}' AND '{rangeEnd}' GROUP BY type;";

        public static string GetScheduleReportQuery() => "SELECT start, end, user.userName, appointment.userId FROM appointment, user ORDER BY start, userId ASC";

        public static string GetPrimeTimeReport() => "SELECT DISTINCT dayname(start) as DayName, AVG(extract(hour FROM start)) AS Hour FROM appointment GROUP BY DayName ORDER BY COUNT(*) DESC;";
    }
}
