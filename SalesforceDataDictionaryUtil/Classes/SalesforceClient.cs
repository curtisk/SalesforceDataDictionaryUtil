using SalesforceDataDictionaryUtil.SFPartnerAPIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Services.Protocols;

namespace SalesforceDataDictionaryUtil.Classes
{
    class SalesforceClient
    {
        String Username { get; set; }
        String Password { get; set; }
        String Token { get; set; }
        private Boolean _success;
        private SforceService _binding;
        readonly Log _log = new Log();

        public SalesforceClient(string username, string password, string token, string serverUrl)
        {
            Username = username;
            Password = password;
            Token = token;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _binding = new SforceService();
            _binding.Url = serverUrl;

        }

        public bool LoginToSalesforce()
        {
            _success = false;
            try
            {
                LoginResult lr = _binding.login(Username, Password + Token);
                //if good setup session and url details
                _binding.Url = lr.serverUrl;
                _binding.SessionHeaderValue = new SessionHeader();
                _binding.SessionHeaderValue.sessionId = lr.sessionId;    
                _success = true;
            }
            catch (SoapException e)
            {
                _log.WriteToErrorLog("An unexpected error has occurred: " +
                                           e.Message + "\n" + e.StackTrace);
            }
            catch (System.Net.WebException wex)
            {
                _log.WriteToErrorLog("An unexpected error has occurred: " +
                                           wex.Message + "\n" + wex.StackTrace);
            }
            return _success;
        }

        public List<DescribeSObjectResult> GetSObjectsByName(string[] objects)
        {
            List<DescribeSObjectResult> describeSObjectResults = new List<DescribeSObjectResult>();
            try
            {
                // Call describeSObjectResults and pass it an array with
                // the names of the objects to describe.
                describeSObjectResults = _binding.describeSObjects(objects).ToList();
            }
            catch (SoapException e)
            {
                _log.WriteToErrorLog("An unexpected error has occurred: " + e.Message
                    + "\n" + e.StackTrace);
            }
            return describeSObjectResults.OrderBy(o=>o.name).ToList();
        }

        public String ProcessSObjectsToCsvString(List<DescribeSObjectResult> objs)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Entity,Field,Size,Data Type,Description");
            foreach (DescribeSObjectResult o in objs.OrderBy(o => o.name).ToList())
            {
                string currentObject = o.name;

                foreach(Field f in o.fields)
                {
                    //First comes current object name, then current field data
                    /* For this use case we only care about:
                        * field name
                        * field size
                        * field type
                        * field description
                    */
                    //check for certain types
                    string desc = "";
                    switch (f.type.ToString())
                    {
                        case "picklist":
                            desc = "Picklist: " +  UnwrapToString(f.picklistValues);
                            break;
                        case "reference":
                            desc = f.label + " relates back to " + UnwrapToString(f.referenceTo);
                            break;
                        default:
                            desc = f.label;
                            break;
                    }
                    sb.AppendLine(currentObject + "," + f.name + "," + f.length + "," + f.type + "," + desc);
                }
                
            }
            return sb.ToString();
        }

        private static string UnwrapToString(PicklistEntry[] picklistEntry)
        {
            StringBuilder sb = new StringBuilder();
            if (picklistEntry != null)
            {
                foreach (var pickitem in picklistEntry)
                {
                    sb.Append(pickitem.label + "^");
                }
            }
            return sb.ToString();
        }

        private static string UnwrapToString(string[] strings)
        {
            String sb = String.Join(";", strings);
            return sb;
        }

        public List<DescribeGlobalSObjectResult> GetDescribeGlobalObjects()
        {
            List<DescribeGlobalSObjectResult> sObjResults = new List<DescribeGlobalSObjectResult>();
            try
            {
                // Make the describeGlobal() call 
                DescribeGlobalResult dgr = _binding.describeGlobal();

                // Get the sObjects to list
                sObjResults = dgr.sobjects.ToList();
            }
            catch (SoapException e)
            {
                _log.WriteToErrorLog("An unexpected error has occurred: " +
                    e.Message + "\n" + e.StackTrace);
            }
            return sObjResults;
        }

    }


}
