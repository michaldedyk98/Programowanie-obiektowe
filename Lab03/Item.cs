using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public abstract class Item
    {
        private string title;
        private int id;
        private DateTime dateOfPublication;
        private string publisher;

        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Id { get => id; set => id = value; }
        public DateTime PublicationDate { get => dateOfPublication; set => dateOfPublication = value; }

        protected Item(string title, int id, DateTime publicationYear, string publisher)
        {
            this.title = title;
            this.id = id;
            this.dateOfPublication = publicationYear;
            this.publisher = publisher;
        }

        public Item()
        {
            title = "None";
            publisher = "None";
            id = 0;
            dateOfPublication = new DateTime();
        }

        public override string ToString()
        {
            return $"ID: {id} title: {title} publisher: {Publisher} publication date: {dateOfPublication}";
        }

        public abstract void PrintInfo();
    }
}
