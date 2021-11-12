using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        class Employee
        {
            public string name { get; set; }
           public int id { get; set; }
            public string department { get; set; }

            public Employee(string name, int id, string department)
            {
                this.name = name;
                this.id = id;
                this.department = department;
            }
        }

        static List<int> FindMissingElement(int[] first, int[] second)
        {
            List<int> missingElement = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach(int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                    missingElement.Add(item);
            }

            return missingElement;
        }

        static void Main(string[] args)
        {
            //Dictionary
            Employee emp = new Employee("Bobby", 9415, "Technology");
            Employee emp2 = new Employee("Robby", 3827, "Marketing");
            Employee emp3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> empById = new Dictionary<int, Employee>();
            empById.Add(emp.id, emp);
            empById.Add(emp2.id, emp2);
            empById.Add(emp3.id, emp3);

            Employee e;
            if(empById.TryGetValue(9415, out e))
            {
                Console.WriteLine(e.name + ":" + e.department);
            }

            //HashSet
            HashSet<string> productCodes = new HashSet<string>();
            productCodes.Add("8F26B");
            productCodes.Add("OA43P");
            productCodes.Add("J2H762");

            Console.WriteLine($"Product Code 48DB9 exist - {productCodes.Contains("48DB9")}");
            Console.WriteLine($"Product Code J2H762 exist - {productCodes.Contains("J2H762")}");

            //Find item present in first array but not in second array - membership

            FindMissingElement(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 }).ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
