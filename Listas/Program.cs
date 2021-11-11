using System;
using System.Collections.Generic;
using System.Globalization;
namespace Listas {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many emplyees will be registred? ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= N; i++) {

                Console.WriteLine($"Emplyoee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employees.Add(new Employee(id, name, salary));
                }

            Console.Write("Enter the employee id that will have salay increase : ");
            int searchID = int.Parse(Console.ReadLine());

            Employee amp = employees.Find(x => x.ID == searchID);
            if (amp != null) {
                Console.Write("Enter the percenage: ");
                double incr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                amp.increaseSalary(incr);
                }
            else {
                Console.WriteLine("This id does not exist! ");
                }

            foreach (Employee obj in employees) {
                Console.WriteLine(obj);
                }
            }
        }
    }
