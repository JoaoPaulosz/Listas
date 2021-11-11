using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Listas {
    class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee() {

            }
        public Employee(int iD, string name) {
            ID = iD;
            Name = name;
            }

        public Employee(int id, string name, double salary) : this(id, name) {
            Salary = salary;
            }

        public void increaseSalary(double percentage) {
            double aumento = percentage / 100;
            Salary += Salary * aumento;
            }

        public override string ToString() {
            return ID + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
