using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EF_CreateDataBase_Default.Entities
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Book> Books { get; set; }
    }
}
