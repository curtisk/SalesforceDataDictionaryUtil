using SalesforceDataDictionaryUtil.Classes;
using SalesforceDataDictionaryUtil.SFPartnerApi31Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SalesforceDataDictionaryUtil
{
    public partial class MainForm : Form
    {
        SalesforceClient sc;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtToken.Text))
            {
                lblStatus.Text = "You must provide a Username, Password and Token to continue...";
            }
            else
            {
                sc = new SalesforceClient(txtUserName.Text, txtPassword.Text, txtToken.Text);
                // login
                bool loginOk = sc.LoginToSalesforce();
                if (loginOk)
                {
                    // get objects to select from and populate listview
                    List<DescribeGlobalSObjectResult> allObjs = sc.GetDescribeGlobalObjects();
                    checkedListBoxObjects.Items.Clear();
                    // layoutable grabs all data objects we care about, so let's boil down List, feel free to adjust to needs
                    // for more details about other flags on sObjects check here: 
                    // http://www.salesforce.com/us/developer/docs/api/Content/sforce_api_calls_describesobjects_describesobjectresult.htm
                    allObjs = allObjs.Where(o => o.layoutable == true).ToList();
                    foreach (DescribeGlobalSObjectResult d in allObjs)
                    {
                        checkedListBoxObjects.Items.Add(d.name);
                    }
                }
                else
                {
                    lblStatus.Text = "There was an issue logging in, please double check your settings and try again...";
                }


            }
        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            List<DescribeSObjectResult> results = new List<DescribeSObjectResult>();
            // pass checked list items to getSObjectsByName....
            results = sc.GetSObjectsByName((from object item in checkedListBoxObjects.CheckedItems select item.ToString()).ToArray());
            String csvout = sc.ProcessSObjectsToCsvString(results);
            if (csvout.Length <= 0) return;
            // prompt for save
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() != DialogResult.OK) return;

                using (StreamWriter write = new StreamWriter(File.Create(dialog.FileName)))
                {
                    write.Write(csvout);
                }
            }
        }

    }
}
