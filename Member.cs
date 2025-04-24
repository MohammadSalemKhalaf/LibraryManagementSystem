using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal class Member : AbstractPerson
{
    public override void DisplayInfo()
    {

    }

    public Member(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        this.BorrowedBooks = new List<Book>();
    }


}
