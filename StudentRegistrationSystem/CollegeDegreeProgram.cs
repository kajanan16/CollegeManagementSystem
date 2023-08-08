using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class CollegeDegreeProgram : CollegeProgram
    {
        private string degreeType;

        public CollegeDegreeProgram(string programCode, string programName,string degreeType, string credentials) : base(programCode, programName, credentials)
        {
            DegreeType = degreeType;
        }

        public string DegreeType { get => degreeType; set => degreeType = value; }


        public override string ToString()
        {
            return base.ToString() + $"Degree Type: {degreeType}\n";
        }
    }
}
