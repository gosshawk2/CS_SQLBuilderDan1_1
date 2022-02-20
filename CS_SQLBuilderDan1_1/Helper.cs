using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

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
            
            string MySQLCon = "";
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
