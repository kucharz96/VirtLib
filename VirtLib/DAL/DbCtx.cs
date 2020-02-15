using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtLib.DAL
{
    public class DbCtx : DbContext
    {
        public DbCtx() : base("VirtLibDB")
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
