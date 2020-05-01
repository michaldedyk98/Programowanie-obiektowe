using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Book : Item
    {
        private IList<Author> authors;
        private int pages;

        public int Pages { get => pages; set => pages = value; }
        public IList<Author> Authors { get => authors; }

        public Book(string title, int id, string publisher, DateTime publicationDate, int pages) : base(title, id, publicationDate, publisher)
        {
            this.pages = pages;
            authors = new List<Author>();
        }

        public Book() : base()
        {
            pages = 0;
            authors = new List<Author>();
        }

        public void AddAuthor(Author author) { authors.Add(author); }

        public override string ToString()
        {
            string str = base.ToString() + $" number of pages: {pages} \r\nAuthors:\r\n";

            foreach(Author x in authors)
                str += x + "\n";

            return str;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
        }
    }
}
