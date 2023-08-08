using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private string programCode;

        public Student(int id, string firstName, string lastName, string email, string phone, string programCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ProgramCode = programCode;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ProgramCode { get => programCode; set => programCode = value; }

        public override string ToString()
        {
            return $"Student ID: {Id}\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nPhone: {Phone}\nProgram Code: {ProgramCode}\n";
        }
    }
}
