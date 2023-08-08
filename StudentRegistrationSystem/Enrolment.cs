using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class Enrolment
    {
        private int studentId;

        private string courseCode;

        private string sectionNumber;

        public Enrolment(int studentId, string courseCode, string sectionNumber)
        {
            StudentId = studentId;
            CourseCode = courseCode;
            SectionNumber = sectionNumber;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public string SectionNumber { get => sectionNumber; set => sectionNumber = value; }

        public override string ToString()
        {
            return $"Student ID: {StudentId}\nCourse Code: {CourseCode}\nSection Number: {SectionNumber}\n";
        }
    }


}
