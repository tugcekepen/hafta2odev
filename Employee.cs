using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2odev
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public List<Employee> employees;


        public Employee()
        {
            employees = new List<Employee>();
        }

        public Employee(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
            employees = new List<Employee>();

        }

        public void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void Remove(int id)
        {
            var emp = employees
                .Where(i => i.Id == id)
                .FirstOrDefault();

            if (emp==null)
            {
                Console.WriteLine("Silinmek istenen çalışan bulunamadı.");
            }
            else
            {
                employees.Remove(emp);
            }
        }

        public override string? ToString()
        {
            return $"{Id, -10} {FullName, 20}";
        }

    }
}
