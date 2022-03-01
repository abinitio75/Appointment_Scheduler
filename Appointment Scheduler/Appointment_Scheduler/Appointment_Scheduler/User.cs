
using System;

namespace Appointment_Scheduler
{
    static class User
    {
        private static int userID;
        private static string userName;
        public static int UserID => userID;
        public static void SetUserID(int id) => userID = id;
        public static string UserName => userName;
        public static void SetUserName(string name) => userName = name;
    }
}
