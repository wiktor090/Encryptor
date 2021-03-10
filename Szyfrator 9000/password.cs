namespace Szyfrator_9000
{
    public class password
    {
        private static string pwd = "";

        public static string getPassword()
        {
            return pwd;
        }

        public static bool setPassword(string pass)
        {
            pwd = pass;
            return true;
        }
        public int id 
        {
            get;
            set;
        }
        
        public string Name
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }


        public string Email
        {
            get;
            set;
        }

        public string Notes
        {
            get;
            set;
        }

        

    }
}