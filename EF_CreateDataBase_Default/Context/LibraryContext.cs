using EF_CreateDataBase_Default.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EF_CreateDataBase_Default.Context
{
    internal class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string str = "Data Source=DESKTOP-SDREM5J\\SQLEXPRESS;Initial Catalog=Libraryy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;";
            optionsBuilder.UseSqlServer(str);
            base.OnConfiguring(optionsBuilder);
        }

        // Tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Operation> Operations { get; set; }
    }
}
