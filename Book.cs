using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal class Book
{
    public int Id { get; set; }
    public string Tittle { get; set; }
    public string AuthorName { get; set; }
    public bool IsAvailable { get; set; }
    public Book(int id , string Tittle , string AuthorName  )
    {
        this.Id = id;
        this.Tittle = Tittle;
        this.AuthorName = AuthorName;
        IsAvailable = true;
    }
    public void DisplayInfo()
    {
        this.ToString();
    }

    public override string ToString()
    {
        return  $"ID : {this.Id} , Tittle : {this.Tittle} , Author Name : {AuthorName} , Available : {IsAvailable}";
    }
}
