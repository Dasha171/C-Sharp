using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BooksWpf
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public int SectionId { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
    }

}
