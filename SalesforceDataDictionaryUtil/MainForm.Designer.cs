namespace SalesforceDataDictionaryUtil
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxObjects = new System.Windows.Forms.CheckedListBox();
            this.ButtonGenerateReport = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblToken);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credientals";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(42, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login and Retrieve sObjects";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(6, 142);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(82, 13);
            this.lblToken.TabIndex = 5;
            this.lblToken.Text = "Security Token:";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(9, 158);
            this.txtToken.MaxLength = 50;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(240, 20);
            this.txtToken.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(9, 105);
            this.txtPassword.MaxLength = 120;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(6, 50);
            this.txtUserName.MaxLength = 120;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(243, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBoxObjects);
            this.groupBox2.Location = new System.Drawing.Point(282, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sObjects Selection";
            // 
            // checkedListBoxObjects
            // 
            this.checkedListBoxObjects.CheckOnClick = true;
            this.checkedListBoxObjects.FormattingEnabled = true;
            this.checkedListBoxObjects.Location = new System.Drawing.Point(23, 35);
            this.checkedListBoxObjects.Name = "checkedListBoxObjects";
            this.checkedListBoxObjects.Size = new System.Drawing.Size(545, 184);
            this.checkedListBoxObjects.TabIndex = 0;
            // 
            // ButtonGenerateReport
            // 
            this.ButtonGenerateReport.Location = new System.Drawing.Point(681, 268);
            this.ButtonGenerateReport.Name = "ButtonGenerateReport";
            this.ButtonGenerateReport.Size = new System.Drawing.Size(169, 30);
            this.ButtonGenerateReport.TabIndex = 2;
            this.ButtonGenerateReport.Text = "Generate Data Dictionary";
            this.ButtonGenerateReport.UseVisualStyleBackColor = true;
            this.ButtonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 275);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 315);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ButtonGenerateReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Salesforce sObject Data Dictionary Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBoxObjects;
        private System.Windows.Forms.Button ButtonGenerateReport;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblStatus;
    }
}

