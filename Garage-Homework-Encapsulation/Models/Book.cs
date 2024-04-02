namespace Garage_Homework_Encapsulation.Models;

public class Book
{
    string _title;
    string _author;
    string _publisher;
    int _availableCopies;

    public string Title { get {return _title; } set { _title = value; } }
    public string Author { get {return _author;} set { _author = value; } }
    public string Publisher { get { return _publisher; } set { _publisher = value; } }
    public int AvailableCopies { get { return _availableCopies; } set { _availableCopies = value; } }

    public Book(string title, string author, string publisher, int availableCopies)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        AvailableCopies = availableCopies;
    }
    public void BookInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Publisher: {Publisher}, Aviable Copies: {AvailableCopies}");
    }
    public void Increase()
    {
        Console.WriteLine("Artir plusda yeti");
        Console.WriteLine(AvailableCopies + int.Parse(Console.ReadLine()));
        Console.WriteLine("Elave edildi");
    }
    public void Decrease()
    {
        Console.WriteLine("azaldirsan Minusdasan yeti");
        Console.WriteLine(AvailableCopies - int.Parse(Console.ReadLine()));
        Console.WriteLine("Say azaldi");
    }
}
