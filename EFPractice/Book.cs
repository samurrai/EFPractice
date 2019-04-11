using System.Collections.Generic;
using System.Data.Entity;

namespace EFPractice
{
    public class Book : Entity
    {
        public ICollection<Author> Authors = new List<Author>();
    }
}