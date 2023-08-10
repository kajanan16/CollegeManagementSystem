using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem
{
    //faculty class
    public class Faculty
    {
//declaring variables for storing faculty id ,first name,last name email and phone
        private string faultyId;

        private string firstName;

        private string lastName;

        private string email;

        private string phone;
//constructor for the faculty class
        public Faculty(string faultyId, string firstName, string lastName, string email, string phone)
        {
            this.FaultyId = faultyId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
        }
//property for the faculty id ,first name,last name email and phone.
        public string FaultyId { get => faultyId; set => faultyId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
//overriding the ToString method
        public override string ToString()
        {
            return $"Faculty ID: {FaultyId}\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nPhone: {Phone}\n";
        }
    }




}
