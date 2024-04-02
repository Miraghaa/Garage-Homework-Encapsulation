using Garage_Homework_Encapsulation.Models;

//Book book = new Book("sss", "senan", "sdsd", 23);
//book.BookInfo();
//book.Increase();
//book.Decrease();

Employee employee = new Employee();


Console.WriteLine($"1: Create Employe");
Console.WriteLine($"2: Update Employe");
Console.WriteLine($"3: Fullinfo Employe");
Console.WriteLine($"0: Close");
int number = int.Parse(Console.ReadLine());
while( number != 0)
{
    switch (number)
    {
        case 1:
            employee.CreateEmployee();
            break;
            case 2: employee.UpdateEmployee(employee.Arr); break;
        case 3: employee.GetEmploye(); break;
        default: Console.WriteLine("Is not correct"); ; break;

    }
    Console.WriteLine($"1: Create Employe");
    Console.WriteLine($"2: Update Employe");
    Console.WriteLine($"3: Fullinfo Employe");
    Console.WriteLine($"0: Close");
    number = int.Parse(Console.ReadLine());
}
