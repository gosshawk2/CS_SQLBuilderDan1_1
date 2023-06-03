using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CS_SQLBuilderDan
{
    public partial class Form_MAIN : Form
    {

        string FullUser = string.Empty;
        CS_SQLBuilderDAL DAL = new CS_SQLBuilderDAL();

        public string statusMSG1
        {
            get {return this.StsLabel1.Text; }
            set 
            {
                this.StsLabel1.Text = value;
                this.statusStrip1.Refresh();
            }
        }

        public Form_MAIN()
        {
            System.Security.Principal.WindowsPrincipal P;

            InitializeComponent();
        }

        private void tableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTableListForm();
        }

        private void Form_MAIN_Load(object sender, EventArgs e)
        {
            //var UserID = (System.Security.Principal.WindowsPrincipal)System.Threading.Thread.CurrentPrincipal;
            //System.Security.Principal.WindowsPrincipal P = (System.Security.Principal.WindowsPrincipal)System.Threading.Thread.CurrentPrincipal;
            FullUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Program.LoggedIn = false;
            //AUser = P.Identity.Name;
            Program.DBType = "MSSQL_ODBC";
            int SlashPos = FullUser.IndexOf("\\");
            if (SlashPos > 0)
            {
                Program.CurrentUser = FullUser.Substring(SlashPos + 1);
            }

            /*For Each c As Control In Controls
                AddHandler c.MouseClick, AddressOf ClickHandler
            Next */
            OpenLOGINForm();
        }

        public void PopulateStatusBar()
        {
            Program.SystemDatabase = "SQLBuilderDG";
            Program.CurrentServer = FullUser.Substring(0, 15);
            Program.CurrentServerInstance = DAL.GetSQLInstances(FullUser.Substring(0, 15));
            Program.ComputerName = FullUser.Substring(0, 15);
            Program.SystemServer = FullUser.Substring(0, 15);
            Program.SystemServerInstance = DAL.GetSQLInstances(FullUser.Substring(0, 15));
            Program.SystemHeaderTable = "tblHeaderlist";
            Program.SystemDetailTable = "tblTableDetails";
            Program.CurrentMode = "Live";
            Program.ParentHandle = this.Handle;
            Program.ParentForm = this;
            Program.MainForm = this;
            Program.DBType = "MSSQL_ODBC";
            Program.Theme = "DARK";

            StsLabel2.Spring = true;
            StsLabel1.ForeColor = Color.AliceBlue;
            StsLabel2.ForeColor = Color.AliceBlue;
            StsLabel3.ForeColor = Color.AliceBlue;
            StsLabel4.ForeColor = Color.AliceBlue;
            StsLabel5.ForeColor = Color.AliceBlue;
            StsLabel6.ForeColor = Color.AliceBlue;
            StsLabel1.Text = "";
            StsLabel3.Text = "    User: " + Program.CurrentUser + "   ";
            StsLabel4.Text = "    Server: " + Program.CurrentServer + "   ";
            StsLabel5.Text = "    Environment: " + Program.CurrentMode + "   ";
            StsLabel6.Text = String.Format("    Version {0}", Assembly.GetExecutingAssembly().GetName().Version) + "   ";

        }


        public void WriteMessage(string StatusMessage)
        {
            StsLabel1.Text = StatusMessage;
        }

        public void ClickHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BringToFront();
            }
        }

        private void OpenLOGINForm()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new Login();

            Cursor = Cursors.Default;
            StsLabel1.Text = "Please supply LOGIN details";
            statusMSG1 = "Open LOGIN form ...";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.StartPosition = FormStartPosition.CenterParent;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void OpenTableListForm()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new frmTableList();

            Cursor = Cursors.Default;
            StsLabel1.Text = "Loading List......";
            statusMSG1 = "Open Form: Table List...";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.StartPosition = FormStartPosition.CenterParent;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        public void OpenImportTables()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new FrmImportTable();

            Cursor = Cursors.Default;
            statusMSG1 = "Open Form: Import Table......";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void OpenWebBrowser2()
        {
            //Open child form to show tables imported in grid-like control:
            var App = new Form_WebView2_Browser();

            Cursor = Cursors.Default;
            statusMSG1 = "Open Form: Web Browser v2......";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            //App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            App.MdiParent = this;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set Dark Theme:
            Program.Theme = "DARK";
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set Normal Theme:
            Program.Theme = "NORMAL";
        }

        private void mSSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set MSSQL database:
            var App = new Login();

            Cursor = Cursors.Default;
            statusMSG1 = "Open Login Form: MSSQL";
            Cursor = Cursors.WaitCursor;
            //Refresh()
            //App.Visible = false;
            //App.GetParms(GlobalSession, GlobalParms)
            //App.PopulateForm()
            
            App.MdiParent = this;
            App.Show();
            StsLabel1.Text = "";
            Cursor = Cursors.Default;
        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set MYSQL database:
            Program.DBType = "MYSQL";

        }

        private void iBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set IBM database:
            Program.DBType = "IBM_ODBC";
        }

        private void oDBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DBType = "MSSQL_ODBC";
        }

        private void oLEDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DBType = "MSSQL_OLEDB";
        }

        private void importTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImportTables();
        }

        private void webView2BrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form_MAIN_Activated(object sender, EventArgs e)
        {
            if (Program.LoggedIn == true)
            {
                MessageBox.Show("LOGGED IN", "LOGGED IN OK", MessageBoxButtons.OK);
                OpenTableListForm();
            }
            
        }

        private void Form_MAIN_Enter(object sender, EventArgs e)
        {
            //OpenTableListForm();
            MessageBox.Show("Form Enter", "FORM ENTER EVENT", MessageBoxButtons.OK);
        }
    }
}
