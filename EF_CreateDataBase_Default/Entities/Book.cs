using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CreateDataBase_Default.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        public int BookTypeId { get; set; }

        // Navigation Property
        public Author Author { get; set; }
        public BookType BookType { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
