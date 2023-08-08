using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class CollegeAdvancedDiplomaProgram : CollegeProgram
    {
        private string specialization;

        public CollegeAdvancedDiplomaProgram(string programCode, string programName, string credentials) : base(programCode, programName, credentials)
        {
            Specialization = specialization;
        }

        public string Specialization { get => specialization; set => specialization = value; }


        public override string ToString()
        {
            return base.ToString() + $"Specialization: {Specialization}\n";
        }
    }
}
