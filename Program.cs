using System;
using System.Collections.Generic;
using System.Threading;

namespace EPollingApp
{
    public class Program
    {
        Database db;
        public Program()
        {
            db = new Database();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var program = new Program();
                program.CallUserForm();
                System.Console.WriteLine("Do you need an result? Y : N ");
                string value = Console.ReadLine();
                if (value.ToUpper() == "Y")
                {
                    List<string> lk = program.DisplayPollingResult();
                    foreach (var h in lk)
                    {
                        Console.WriteLine(h);
                    }
                }
            }
        }
        public void CallUserForm()
        {
            UserForm frm = new UserForm(db);
            frm.UserRegistartionForm();
            string userPreferredTool = frm.PollOptions();
        }
        public List<string> DisplayPollingResult()
        {
            return db.DisplayResult();
        }       
    }      
}

