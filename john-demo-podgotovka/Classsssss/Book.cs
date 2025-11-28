using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace john_demo_podgotovka
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
        public Guid AuthorId { get; set; } 
    }
}
