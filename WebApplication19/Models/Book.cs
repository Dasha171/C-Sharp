using System.Security.Cryptography.X509Certificates;

namespace WebApplication19.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Рricе { get; internal set; }
    }
}
