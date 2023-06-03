
namespace CS_SQLBuilderDan
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.comDatabaseTypes = new System.Windows.Forms.ComboBox();
            this.lblDatabaseType = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.lblComputername = new System.Windows.Forms.Label();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.lblInstance = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMain.Controls.Add(this.comDatabaseTypes);
            this.pnlMain.Controls.Add(this.lblDatabaseType);
            this.pnlMain.Controls.Add(this.txtComputerName);
            this.pnlMain.Controls.Add(this.lblComputername);
            this.pnlMain.Controls.Add(this.txtInstance);
            this.pnlMain.Controls.Add(this.lblInstance);
            this.pnlMain.Controls.Add(this.txtServer);
            this.pnlMain.Controls.Add(this.txtPort);
            this.pnlMain.Controls.Add(this.lblPort);
            this.pnlMain.Controls.Add(this.txtDatabase);
            this.pnlMain.Controls.Add(this.lblDatabase);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtUser);
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Controls.Add(this.lblServer);
            this.pnlMain.Location = new System.Drawing.Point(2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(347, 383);
            this.pnlMain.TabIndex = 0;
            // 
            // comDatabaseTypes
            // 
            this.comDatabaseTypes.FormattingEnabled = true;
            this.comDatabaseTypes.Items.AddRange(new object[] {
            "IBM",
            "ORACLE",
            "MS SERVER",
            "MYSQL"});
            this.comDatabaseTypes.Location = new System.Drawing.Point(102, 20);
            this.comDatabaseTypes.Name = "comDatabaseTypes";
            this.comDatabaseTypes.Size = new System.Drawing.Size(207, 21);
            this.comDatabaseTypes.TabIndex = 18;
            this.comDatabaseTypes.SelectedIndexChanged += new System.EventHandler(this.comDatabaseTypes_SelectedIndexChanged);
            // 
            // lblDatabaseType
            // 
            this.lblDatabaseType.AutoSize = true;
            this.lblDatabaseType.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDatabaseType.Location = new System.Drawing.Point(10, 23);
            this.lblDatabaseType.Name = "lblDatabaseType";
            this.lblDatabaseType.Size = new System.Drawing.Size(83, 13);
            this.lblDatabaseType.TabIndex = 17;
            this.lblDatabaseType.Text = "Database Type:";
            // 
            // txtComputerName
            // 
            this.txtComputerName.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtComputerName.Location = new System.Drawing.Point(102, 89);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.ReadOnly = true;
            this.txtComputerName.Size = new System.Drawing.Size(207, 20);
            this.txtComputerName.TabIndex = 16;
            this.txtComputerName.Text = "DESKTOP-FLF11K6";
            // 
            // lblComputername
            // 
            this.lblComputername.AutoSize = true;
            this.lblComputername.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblComputername.Location = new System.Drawing.Point(10, 92);
            this.lblComputername.Name = "lblComputername";
            this.lblComputername.Size = new System.Drawing.Size(86, 13);
            this.lblComputername.TabIndex = 15;
            this.lblComputername.Text = "Computer Name:";
            // 
            // txtInstance
            // 
            this.txtInstance.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtInstance.Location = new System.Drawing.Point(72, 157);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(237, 20);
            this.txtInstance.TabIndex = 14;
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblInstance.Location = new System.Drawing.Point(10, 160);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(51, 13);
            this.lblInstance.TabIndex = 13;
            this.lblInstance.Text = "Instance:";
            // 
            // txtServer
            // 
            this.txtServer.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtServer.Location = new System.Drawing.Point(72, 122);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(237, 20);
            this.txtServer.TabIndex = 12;
            // 
            // txtPort
            // 
            this.txtPort.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtPort.Location = new System.Drawing.Point(72, 311);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(237, 20);
            this.txtPort.TabIndex = 11;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPort.Location = new System.Drawing.Point(10, 314);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtDatabase.Location = new System.Drawing.Point(72, 196);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(237, 20);
            this.txtDatabase.TabIndex = 9;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDatabase.Location = new System.Drawing.Point(10, 199);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(56, 13);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(192, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.Location = new System.Drawing.Point(72, 349);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtPassword.Location = new System.Drawing.Point(72, 276);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPassword.Location = new System.Drawing.Point(10, 279);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtUser.Location = new System.Drawing.Point(72, 234);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(237, 20);
            this.txtUser.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblUser.Location = new System.Drawing.Point(10, 237);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblServer.Location = new System.Drawing.Point(10, 125);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 389);
            this.Controls.Add(this.pnlMain);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.Label lblComputername;
        private System.Windows.Forms.ComboBox comDatabaseTypes;
        private System.Windows.Forms.Label lblDatabaseType;
    }
}