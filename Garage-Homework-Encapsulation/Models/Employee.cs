using System;

namespace Garage_Homework_Encapsulation.Models // Noktalı virgülü kaldırın
{
    public class Employee
    {
        int _id;
        string _name;
        string _position;
        double _salary;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Position { get { return _position; } set { _position = value; } }
        public double Salary { get { return _salary; } set { _salary = value; } }
        public Employee[] Arr = { };

        public void FullInfoEmployee(Employee employee)
        {
            Console.WriteLine($"Number: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}, Salary: {employee.Salary}");
        }
        public void CreateEmployee()
        {
            Employee employee = new Employee();
            _id++;
            employee.Id = _id;
            Console.WriteLine("Please enter your name");
            employee.Name = Console.ReadLine();
            while (string.IsNullOrEmpty(employee.Name))
            {
                Console.WriteLine("Enter is not correct");
                Console.WriteLine("Please enter your name the replay");
                employee.Name = Console.ReadLine();
            }
            Console.WriteLine("Please enter your Position");
            employee.Position = Console.ReadLine();
            while (string.IsNullOrEmpty(employee.Position))
            {
                Console.WriteLine("Enter is not correct");
                Console.WriteLine("Please enter your Position the replay");
                employee.Position = Console.ReadLine();
            }
            Console.WriteLine("Please enter your Salary");
            double salary;
            while (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Enter is not correct");
                Console.WriteLine("Please enter your Salary the replay");
            }
            employee.Salary = salary;
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = employee;
        }
        public void UpdateEmployee(Employee[] employees)
        {
            Console.WriteLine("Enter the ID of the employee you want to update:");
            int id = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    found = true;
                    Console.WriteLine("Enter the new name:");
                    string newName = Console.ReadLine();
                    employee.Name = newName;
                    Console.WriteLine("Employee name updated successfully.");
                    FullInfoEmployee(employee);
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Employee not found with the given ID.");
            }
        }
        public void GetEmploye()
        {
            foreach (Employee employee1 in Arr)
            {
                if (employee1 == null)
                {
                    Console.WriteLine("Employe Not Found");
                }
                else
                {
                    FullInfoEmployee(employee1);
                }
            }
        }
    }
}
