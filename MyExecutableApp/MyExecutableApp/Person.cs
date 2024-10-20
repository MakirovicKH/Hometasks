using Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExecutableApp
{
    internal class Person
    {
        private string _username;
        private string _password;
        private string _firstName;
        private string _surname;
        private byte _age;
        private DateTime _birthDate;


        public string Username { get { return _username; } set
            {
                if (Validator.ValidatorForExecutable.ValidateUsername(value))
                    _username = value; 
                else
                    Console.WriteLine("Username must be at least 2 characters long.");
            } 
        }
        public string Password { get { return _password; } set
            {
                if (Validator.ValidatorForExecutable.ValidatePassword(value))
                    _password = value; 
                else
                    Console.WriteLine("Password must be at least 8 characters long and contain upper case, lower case, and digits.");
            } }
        public string FirstName { get { return _firstName; } set
            {
                if (Validator.ValidatorForExecutable.ValidateFirstName(value))
                    _firstName = value; 
                else
                    Console.WriteLine("First name must be at least 2 characters long.");
            } } // Adimiz
        public string Surname { get { return _surname; } set
            {
                if (Validator.ValidatorForExecutable.ValidateSurname(value))
                    _surname = value; 
                else
                    Console.WriteLine("Surname must be at least 2 characters long.");
            } }   // Soyadimiz
        public byte Age { get { return _age; } set
            {
                if (Validator.ValidatorForExecutable.ValidateAge(value))
                    _age = value; 
                else
                    Console.WriteLine("Age must be a non-negative number.");
            } }
        public DateTime BirthDate { get { return _birthDate; } set
            {
                if (Validator.ValidatorForExecutable.ValidateBirthDate(value))
                    _birthDate = value; 
                else
                    Console.WriteLine("Birth date must be later than 1970.");
            } }

        public Person(string username, string password, string firstName, string surname, byte age, DateTime birthDate)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            Surname = surname;
            Age = age;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Username: {Username}, Name: {FirstName} {Surname}, Age: {Age}, BirthDate: {BirthDate.ToShortDateString()}";
        }
    }
}