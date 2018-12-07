/* 
   This program is from a pluralsight course with Jesse Liberty:
   https://www.pluralsight.com/courses/csharp-from-scratch
   I modified the object initialization syntax for single line declaration.
   I included a foreach loop instead of for loop to iterate over List<T>.
   The program goes over key OOP topics. Inheritance, encapsulation, polymorphism. 
   Creates a few Employee types (Manager, Worker) and prints results.
   Trevor Heehs 
*/

using System;
using System.Collections.Generic;

namespace LibertyOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates 3 new Employee objects of type worker/manager and passes args.
            Employee bob = new Worker("Bob", 35.00);
            Employee joe = new Manager("Joe", true);
            Employee sally = new Worker("Sally", 27.50);

            // Creates a List of type Employeee containing 3 employee objects.
            // I altered by initializing on one line as opposed to multiples lines.
            List<Employee> employees = new List<Employee> { joe, bob, sally };

            /* Original code included for loop. I created a foreach loop.
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].TakeVacation();
                Console.WriteLine(employees[i]);
            }
            */

            foreach (var employee in employees)
            {
                employee.TakeVacation();
                Console.WriteLine($"{employee}");
            }

        }
    }

    // Using Employee class, define the Employee type...
    public class Employee
    {
        // Property with getter and setter. 
        public string Name { get; set; }

        // Public field?
        public double vacationDays;

        // Virtual Method declaration. No body provided. 
        // Method will be inherited by child class and provided with a body then.
        public virtual void TakeVacation() { }

        // Employee Constructor (constructors always have same name as type/class).
        // This "instance" constructor creates a new Employee object.
        public Employee(string name)
        {
            Name = name; // Gets and Sets Employee name and assigns to the Name property.
        }

        public override string ToString()
        // Define how employee should be presented when ToString is called.
        {
            return $"[Employee: Name = {Name}]";
        }
    }

    // The Worker class inherits from base (Employee) class
    public class Worker : Employee  // Inherits from base (Employee) class
    {
        public double HourlyWage { get; set; }  // Property

        // Instance Constructor creates a new worker object.
        // Inherits "name" from base (Employee) class. 
        // Assigns wage to HourlyWage property. This property is unique to worker class.

        public Worker(string name, double wage)
            : base(name)
        {
            HourlyWage = wage;
        }

        // Child Worker class overrides method inherited from Employee class.
        public override void TakeVacation()
        {
            vacationDays += 10;
        }

        // Define how Worker object should be presented when ToString is called.
        public override string ToString()
        {
            return $"[Worker Name: {Name} HourlyWage: {HourlyWage} Vacation: {vacationDays}]";
        }
    }

    // Child class Manager inherits from base (Employee) class.
    public class Manager : Employee
    {
        public bool CompanyCar { get; set; }  // Property

        // Manager constructor, creates manager object. 
        // Inherits "name" from base (Employee) class
        public Manager(string name, bool hasCar)
            : base(name)
        {
            CompanyCar = hasCar;
        }
        // Overrides vactation method in a different manner than for Employee
        public override void TakeVacation()
        {
            vacationDays += 15;
        }

        // Define how Manager should be presented when ToString is called.
        public override string ToString()
        {
            return $"[Manager Name: {Name} HasCar: {CompanyCar} Vacation: {vacationDays}]";
        }
    }
}