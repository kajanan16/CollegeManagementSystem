using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    public class Faculty
    {

        private string faultyId;

        private string firstName;

        private string lastName;

        private string email;

        private string phone;

        public Faculty(string faultyId, string firstName, string lastName, string email, string phone)
        {
            this.FaultyId = faultyId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
        }

        public string FaultyId { get => faultyId; set => faultyId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public override string ToString()
        {
            return $"Faculty ID: {FaultyId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nPhone: {Phone}\n";
        }
    }




}
