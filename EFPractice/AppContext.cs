using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice
{
    public class AppContext : DbContext
    {
        public AppContext() : base("appConfig"){}

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }
    }
}
