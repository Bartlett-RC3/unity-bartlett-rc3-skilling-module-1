using System;
namespace RC3Students
{
    public class Student
    {
        // Properties
        public string FirstName;
        private string MiddleName;
        public string LastName;

        private int age;
        public string HomeCountry;

        // Constructor
        public Student(string _FirstName, string _MiddleName, string _LastName, int _age, string _HomeCountry)
        {
            FirstName = _FirstName;
            MiddleName = _MiddleName;
            LastName = _LastName;
            age = _age;
            HomeCountry = _HomeCountry;
        }

        // Functions
        public string GetStudentName(){
            return FirstName + LastName;
        }

        public string GetHomeCountry(){
            return HomeCountry;
        }
    }
}
