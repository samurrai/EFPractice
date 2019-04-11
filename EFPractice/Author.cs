using System.Collections.Generic;

namespace EFPractice
{
    public class Author : Entity
    {
        public ICollection<Book> Books = new List<Book>();
    }
}