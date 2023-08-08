using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class Course
    {

        private string courseCode;

        private string courseName;

        private string facultyId;

        private double creditHours;

        public Course(string courseCode, string courseName, string facultyId, double creditHours)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            FacultyId = facultyId;
            CreditHours = creditHours;
        }

        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public string FacultyId { get => facultyId; set => facultyId = value; }
        public double CreditHours { get => creditHours; set => creditHours = value; }

        public override string ToString()
        {
            return $"Course Code: {CourseCode}\nCourse Name: {CourseName}\nFaculty ID: {FacultyId}\nCredit Hours: {CreditHours}\n";
        }

    }
}
