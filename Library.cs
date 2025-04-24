using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal class Library
{
    List<Book> books { get; set; }
    List<AbstractPerson> Members { get; set; }
    public Library()
    {
        books = new List<Book>();
        Members = new List<AbstractPerson>();
    }


    public void AddBook(Book b) => books.Add(b);
    public void AddMember(AbstractPerson p)=> Members.Add(p);
    public Book FindBookById(int id)
    {
        foreach(var b in books)
        {
            if (b.Id==id)
            {
                return b;
            }
        }
        return null;
    }

    public AbstractPerson FindMemberById(int id) {
        foreach (var m in Members)
        {
            if (m.Id==id)
            {
                return m;
            }
        }
        return null;
    }

    public void DisplayAllBooks()
    {
        foreach (var b in books)
            Console.WriteLine(b);
    }
    public void DisplayAllMembers()
    {
        foreach (var mem in Members)
        {
            Console.WriteLine(mem);
        }
    }

}
