using System;
using System.Collections.Generic;

namespace EPollingApp
{
    public class UserForm
    {
        List<RegistrationUserData> registrationDbs;
        RegistrationUserData regst;
        Guid uniqueId;
        Database db;
        public UserForm(Database db)
        {
            regst = new RegistrationUserData();           
            registrationDbs = new List<RegistrationUserData>();
            this.db = db;
        }

        public void UserRegistartionForm()
        {
            Console.WriteLine("Enter first name:");
            regst.FirstName = Console.ReadLine();
            
            uniqueId = Guid.NewGuid();
            regst.Id = uniqueId;

            db.Save(regst);
            
            Console.WriteLine("uniqueId:" + uniqueId);
            #region
            //while (!string.IsNullOrEmpty(Console.ReadLine()))
            //{
            //    string FirstName = Console.ReadLine();
            //    regst.FirstName = Console.ReadLine();
            //}

            //Console.WriteLine("Enter last name:");
            ////string lName = Console.ReadLine();
            //regst.LastName = Console.ReadLine();

            //Console.WriteLine("Enter address:");
            //regst.Address = Console.ReadLine();

            //Console.WriteLine("Enter age:");
            //regst.Age = int.Parse(Console.ReadLine());           
            //if(regst.Age <= 18)
            //{
            //    Console.WriteLine("Under 18 years of age user doesnt qualify to poll");
            //}

            //Console.WriteLine("Any criminal offence:");
            //regst.Offence = Convert.ToBoolean(Console.ReadLine());
            //if (regst.Offence)
            //{
            //    Console.WriteLine("if committed any criminal offence, user doesnt qualify to poll ");                
            //}
            #endregion
        }

        public string PollOptions()
        {           
            List<string> toolname = new List<string>();
            toolname.Add("Splunk");
            toolname.Add("Teams");
            Console.WriteLine("Which tool is best? Select One");
            foreach(string tool in toolname)
            {
                Console.WriteLine(tool);
            }
            Console.WriteLine("Type one below:");
            string userPreferredTool = Console.ReadLine();
            regst.UserPreferredTool = userPreferredTool;            
            if(!toolname.Contains(userPreferredTool))
            {
                Console.WriteLine("user input is not in the list of tools");
            }

            string userPreferrredTool = db.SavePoll(userPreferredTool, uniqueId);
            return userPreferrredTool;
        }             
    }
}
