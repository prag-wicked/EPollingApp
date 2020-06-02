using System;
using System.Collections.Generic;

namespace EPollingApp
{
    public class RegistrationUserData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool Offence { get; set; }
        public string UserPreferredTool { get; set; }
        public Guid Id { get; set; }
        public string ToolName { get; set; }
    }
}
