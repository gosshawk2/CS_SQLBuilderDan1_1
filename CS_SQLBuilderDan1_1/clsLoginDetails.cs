using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SQLBuilderDan
{
    public class clsLoginDetails
    {
        private string _servername = string.Empty;
        private string _serverinstance = string.Empty;
        private string _databasename = string.Empty;
        private string _port = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _ipv4addr = string.Empty;
        private string _ipv6addr = string.Empty;
        private string _computername = string.Empty;
        private string _connString = string.Empty;
        private string _DBType = string.Empty;

        public string ServerName
        {
            get => _servername; set { _servername = value; }
        }

        public string ServerInstance
        {
            get => _serverinstance; set { _serverinstance = value; }
        }

        public string DatabaseName
        {
            get => _databasename; set { _databasename = value; }
        }

        public string Port
        {
            get => _port; set { _port = value; }
        }

        public string Username
        {
            get => _username; set { _username = value; }
        }

        public string Password
        {
            get => _password; set { _password = value; }
        }

        public string IPv4Addr
        {
            get => _ipv4addr; set { _ipv4addr = value; }
        }

        public string IPv6Addr
        {
            get => _ipv6addr; set { _ipv6addr = value; }
        }

        public string ComputerName
        {
            get => _computername; set { _computername = value; }
        }

        public string connString
        {
            get => _connString; set { _connString = value; }
        }

        public string DBType
        {
            get => _DBType; set { _DBType = value; }
        }
    }
}
