using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Information_system_prototype
{
    public class Employee
    {
        private int uniquenumber;
        private string name;
        private string surname;
        private int age;
        private Department department;
        private int salary;

        public int Uniquenumber { get { return this.uniquenumber; } set { this.uniquenumber = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Surname { get { return this.surname; } set { this.surname = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public Department _Department { get { return this.department; } set { this.department = value; } }
        public int Salary { get { return this.salary; } set { this.salary = value; } }

        public Employee(int Uniquenumber, string Name, string Surname, int Age, Department _Department, int Salary)
        {
            this.uniquenumber = Uniquenumber;
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
            this.department = _Department;
            this.salary = Salary;
        }

        public Employee(string Name, string Surname, int Age, Department _Department, int Salary): this (0,Name,Surname,Age,_Department,Salary)
        { }
        public Employee(int Uniquenumber, string Name, string Surname, int Age, Department _Department): this(Uniquenumber,Name,Surname,Age,_Department,0)
        { }

        public string Print()
        {
            return $"{uniquenumber} Employer name:{name} {surname},Age: {age},Department: {department}, salary: {salary} ";
        }

    }
}