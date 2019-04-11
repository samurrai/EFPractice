using System.Collections.Generic;
using System.Data.Entity;

namespace EFPractice
{
    public class Visitor : Entity
    {
        public bool IsDebtor { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
