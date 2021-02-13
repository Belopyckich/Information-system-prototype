using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_system_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> Departments = new List<Department>();
            Departments.Add(new Department("Unatco", new DateTime(2021, 2, 11, 23, 13, 0), 200));
            List<Employee> Employes = new List<Employee>();
            Employes.Add(new Employee(1, "Jack", "Demidov", 22, Departments.Print, 20000));
            Employes.Add(new Employee(1, "Jack", "Demidov", 22, Unatco, 20000));
            Employes.Add(new Employee(2, "Kostya", "Ravkov", 22, Unatco, 30000));
            Employes.Add(new Employee(3, "Maksim", "Klimashenok", 22, Unatco, 34000));
            Employes.Add(new Employee(4, "Alex", "Mamai", 22, Unatco, 25000));
            Employes.Add(new Employee(5, "Nikolai", "Mamai", 22, Unatco, 46000));
            foreach(var item in Employes)
            {
                Console.WriteLine(item.Print());
            }

        }
    }
}