using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public abstract class CollegeProgram
    {

        private string programCode;

        private string programName;

        private string credentials;

        protected CollegeProgram(string programCode, string programName, string credentials)
        {
            ProgramCode = programCode;
            ProgramName = programName;
            Credentials = credentials;
        }

        public string ProgramCode { get => programCode; set => programCode = value; }
        public string ProgramName { get => programName; set => programName = value; }
        public string Credentials { get => credentials; set => credentials = value; }


        public override string ToString()
        {
            return $"Program Code: {ProgramCode}\nProgram Name: {ProgramName}\nCredentials: {Credentials}\n";
        }
    }
}
