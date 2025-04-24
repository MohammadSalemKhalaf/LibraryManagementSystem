using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal abstract class AbstractPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> BorrowedBooks { get; set; }
    public abstract void DisplayInfo();

    protected AbstractPerson()
    {
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book b)
    {
        if (b.IsAvailable)
        {
            BorrowedBooks.Add(b);
            b.IsAvailable = false;
        }
    }

    public void ReturnBook(Book b)
    {
        if(!b.IsAvailable && BorrowedBooks.Contains(b))
        {
            BorrowedBooks.Remove(b);
            b.IsAvailable = true;
        }
    }

    public void DisplayBorrowedBooks()
    {
        foreach (var b in BorrowedBooks)
            Console.WriteLine(b);
    }


    public override string ToString()
    {
        return $"Id : {Id} , Name : {Name} ";
    }
}
