using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_SQLBuilderDan
{
    public partial class Login : Form
    {
        private string _dbversion = string.Empty;

        public string DBVersion
        {
            get => _dbversion; set { _dbversion = value; }
        }

        public void HideControls(string[] Controls)
        {
            foreach (var txtControl in Controls)
            {
                if (txtControl.ToUpper() == "SERVER")
                {
                    lblServer.Visible = false;
                    txtServer.Visible = false;
                }

                if (txtControl.ToUpper() == "INSTANCE")
                {
                    lblInstance.Visible = false;
                    txtInstance.Visible = false;
                }

                if (txtControl.ToUpper() == "DATABASE")
                {
                    lblDatabase.Visible = false;
                    txtDatabase.Visible = false;
                }
                if (txtControl.ToUpper() == "USERNAME")
                {
                    lblUser.Visible = false;
                    txtUser.Visible = false;
                }
                if (txtControl.ToUpper() == "PASSWORD")
                {
                    lblPassword.Visible = false;
                    txtPassword.Visible = false;
                }
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        public void SetupForm()
        {
            txtDatabase.Text = "SQLBuilderDG";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //If MSSQL then
            //  Take Servername, set System.Database to "SQLBuilder" and List Databases in Import Table form.
            //If MYSQL then
            //  Take Servername - usually localhost or IP address, set System.Database to "SQLBuilder" and list
            //  all databases in MYSQL Schema matching Servername
            //If IBM then
            //  Take Servername - set System.Database to "SQLBuilder" and let user enter the library
            string servername = string.Empty;
            string instance = string.Empty;
            string database = string.Empty;
            string username = string.Empty;
            string password = string.Empty;
            string port = string.Empty;
            string computername = string.Empty;
            string ip4addr = string.Empty;
            string ip6addr = string.Empty;

            servername = txtServer.Text;
            instance = txtInstance.Text;
            database = txtDatabase.Text;
            port = txtPort.Text;
            username = txtUser.Text;
            password = txtPassword.Text;
            ip4addr = "IP4";
            ip6addr = "IP6";
            computername = txtComputerName.Text;

            if (this._dbversion.ToUpper() == "MSSQL")
            {
                Helper.Store_MSLoginDetails(servername, instance, database, port, username, password, ip4addr, ip6addr, computername);

            }

            if (this._dbversion.ToUpper() == "MYSQL")
            {
                Helper.Store_myLoginDetails(servername, database, port, username, password, ip4addr, ip6addr, computername);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close form:
            this.Close();
        }
    }
}
