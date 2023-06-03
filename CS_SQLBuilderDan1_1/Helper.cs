namespace CS_SQLBuilderDan
{
    public static class Helper
    {
        public static clsLoginDetails MS_LoginDetails = new clsLoginDetails();
        public static clsLoginDetails my_LoginDetails = new clsLoginDetails();
        public static string conn(string ConnName, string ServerName, string ServerInstance, string DBName)
        {
            string ODBCDriver = "{ODBC Driver 17 for SQL Server}";
            string FullServerName = ServerName;
            if (ServerInstance != string.Empty)
            {
                FullServerName = ServerName + "\\" + ServerInstance;
            }
            // string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-F63E7OI";
            //string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-FLF11K6";
            string SQLOLECon = $"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog={DBName};Data Source={FullServerName}";
            //string SQLODBCCon = "DRIVER={ODBC Driver 17 for SQL Server}; Server=desktop-flf11k6\\mssqlserverdev; Database=SQLBuilderDG;Trusted_Connection=yes;";
            string SQLODBCCon = $"Driver={ODBCDriver}; Server={FullServerName}; Database={DBName};Trusted_Connection=yes;";
            string ConString2 = "user id = username; password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30";
            //ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)

            string MySQLCon = $"Server={FullServerName}; user id={FullServerName}; Database={DBName};Trusted_Connection=yes;";
            if (ConnName == "SQLOLE")
            {
                return SQLOLECon;
            }
            else if (ConnName == "SQLODBC")
            {
                return SQLODBCCon;
            }
            else if (ConnName == "MySQL")
            {
                return MySQLCon;
            }
            return null;
        }

        public static string conn2(string ConnName, string ServerName, string ServerInstance, string DBName,
            string Username, string Password, string Port, string DataSourceIP)
        {
            string ODBCDriver = "{ODBC Driver 17 for SQL Server}";
            string FullServerName = ServerName;
            string SQLOLECon = string.Empty;
            string SQLODBCCon = string.Empty;
            if (ServerInstance != string.Empty)
            {
                FullServerName = ServerName + "\\" + ServerInstance;
            }
            if (Port != string.Empty)
            {
                FullServerName += "," + Port;
            }
            //Driver ={ SQL Server}; Server = myServerName,myPortNumber; Database = myDataBase; Uid = myUsername; Pwd = myPassword;
            // string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-F63E7OI";
            //string SQLOLECon = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SQLBuilderDG;Data Source=DESKTOP-FLF11K6";
            //Provider=sqloledb;Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;
            if (DataSourceIP != string.Empty)
            {
                SQLOLECon = $"Provider=SQLOLEDB.1;Data Source={DataSourceIP};Integrated Security=SSPI;Persist Security Info=False;Initial Catalog={DBName};Data Source={FullServerName};User Id={Username};Password={Password}";
            }
            else
            {
                SQLOLECon = $"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog={DBName};Data Source={FullServerName};User Id={Username};Password={Password}";
            }
            
            //string SQLODBCCon = "DRIVER={ODBC Driver 17 for SQL Server}; Server=desktop-flf11k6\\mssqlserverdev; Database=SQLBuilderDG;Trusted_Connection=yes;";
            //Driver ={ SQL Server}; Server = myServerName,myPortNumber; Database = myDataBase; Uid = myUsername; Pwd = myPassword;
            SQLODBCCon = $"Driver={ODBCDriver}; Server={FullServerName}; Database={DBName};Uid={Username}; Pwd={Password};";
            string ConString2 = "user id = username; password=password;server=serverurl;Trusted_Connection=yes;database=database;connection timeout=30";
            //ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)

            string MySQLCon = $"Server={FullServerName}; user id={FullServerName}; Password={Password};Database={DBName};Trusted_Connection=yes;";
            if (ConnName == "SQLOLE")
            {
                return SQLOLECon;
            }
            else if (ConnName == "SQLODBC")
            {
                return SQLODBCCon;
            }
            else if (ConnName == "MySQL")
            {
                return MySQLCon;
            }
            return null;
        }

        public static clsLoginDetails Store_myLoginDetails(string server,string database,string port,
            string username,string password, string ip4, string ip6, string computername)
        {
            my_LoginDetails.ServerName = server;
            my_LoginDetails.DatabaseName = database;
            my_LoginDetails.Port = port;
            my_LoginDetails.Username = username;
            my_LoginDetails.Password = password;
            my_LoginDetails.IPv4Addr = ip4;
            my_LoginDetails.IPv6Addr = ip6;
            my_LoginDetails.ComputerName = computername;
            my_LoginDetails.connString = conn2("MYSQL",server,"",database,username,password,port,"");

            return my_LoginDetails;
        }

        public static clsLoginDetails Store_MSLoginDetails(string server, string instance,string database, string port,
            string username, string password, string ip4, string ip6,string computername)
        {
            MS_LoginDetails.ServerName = server;
            MS_LoginDetails.ServerInstance = instance;
            MS_LoginDetails.DatabaseName = database;
            MS_LoginDetails.Port = port;
            MS_LoginDetails.Username = username;
            MS_LoginDetails.Password = password;
            MS_LoginDetails.IPv4Addr = ip4;
            MS_LoginDetails.IPv6Addr = ip6;
            MS_LoginDetails.ComputerName = computername;
            MS_LoginDetails.connString = conn2("", server, instance, database, username, password, port, "");

            return MS_LoginDetails;
        }

        public static string GetmyServerName()
        {
            return my_LoginDetails.ServerName;
        }

        public static string GetmyDatabase()
        {
            return my_LoginDetails.DatabaseName;
        }

        public static string GetmyUsername()
        {
            return my_LoginDetails.Username;
        }

        public static string GetmyPassword()
        {
            return my_LoginDetails.Password;
        }
        
        public static string GetmyPort()
        {
            return my_LoginDetails.Port;
        }

        public static string Getmyip4addr()
        {
            return my_LoginDetails.IPv4Addr;
        }

        public static string Getmyip6addr()
        {
            return my_LoginDetails.IPv6Addr;
        }

        public static string GetmyComputerName()
        {
            return my_LoginDetails.ComputerName;
        }

        public static string GetMSServerName()
        {
            return MS_LoginDetails.ServerName;
        }

        public static string GetMSInstance()
        {
            return MS_LoginDetails.ServerInstance;
        }

        public static string GetMSDatabase()
        {
            return MS_LoginDetails.DatabaseName;
        }

        public static string GetMSUsername()
        {
            return MS_LoginDetails.Username;
        }

        public static string GetMSPassword()
        {
            return MS_LoginDetails.Password;
        }

        public static string GetMSPort()
        {
            return MS_LoginDetails.Port;
        }

        public static string GetMSip4addr()
        {
            return MS_LoginDetails.IPv4Addr;
        }

        public static string GetMSip6addr()
        {
            return MS_LoginDetails.IPv6Addr;
        }

        public static string GetMSComputerName()
        {
            return MS_LoginDetails.ComputerName;
        }
    }
}
