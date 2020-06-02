using System;
using System.Collections.Generic;
using System.Linq;

namespace EPollingApp
{
    public class Database
    {
        List<RegistrationUserData> registrationDbs;
        public Database()
        {
            registrationDbs = new List<RegistrationUserData>();
        }
        public void Save(RegistrationUserData registrationUserData)
        {
            registrationDbs.Add(registrationUserData);
        }
        public string SavePoll(string userPreferredTool, Guid id)
        {
            var registrationUserData = registrationDbs.Find(x => x.Id == id);
            registrationUserData.ToolName = userPreferredTool;
            return userPreferredTool;
        }
        public List<string> DisplayResult()
        {
            List<string> ls = new List<string>();
            {
                var h1 = registrationDbs.Where(x => x.UserPreferredTool == "Splunk").Count().ToString();
                var h = registrationDbs.Where(x => x.UserPreferredTool == "Teams").Count().ToString();
                ls.Add(h1 + "is count for Splunk");
                ls.Add(h + "is count for Teams");                
            }
            return ls;
        }
    }
}
