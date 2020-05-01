using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Library : IItemManager, ILibrarianManager
    {
        private string address;
        private IList<Librarian> librarians;
        private IList<Catalog> catalogs;

        public string Address { get => address; set => address = value; }
        public IList<Librarian> Librarians { get => librarians; }
        public IList<Catalog> Catalogs { get => catalogs; }
        public Library()
        {
            address = "None";
            librarians = new List<Librarian>();
            catalogs = new List<Catalog>();
        }

        public Library(string address)
        {
            this.address = address;
            librarians = new List<Librarian>();
            catalogs = new List<Catalog>();
        }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            this.address = address;
            this.librarians = librarians;
            this.catalogs = catalogs;
        }

        public Item FindItemByID(int id)
        {
            foreach (Catalog catalog in catalogs)
            {
                Item item = catalog.FindItemByID(id);
                if (item != null) return item;
            }

            return null;
        }

        public Item FindItemByTitle(string title)
        {
            foreach (Catalog catalog in catalogs)
            {
                Item item = catalog.FindItemByTitle(title);
                if (item != null) return item;
            }

            return null;
        }

        public void ShowItems()
        {
            foreach (Catalog catalog in catalogs)
                catalog.ShowItems();
        }

        public void AddCatalog(Catalog catalog)
        {
            if (catalog != null)
                catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicSection)
        {
            if (item == null || string.IsNullOrEmpty(thematicSection)) return;

            foreach (Catalog catalog in catalogs)
                if (catalog.ThematicSection.Equals(thematicSection))
                    catalog?.AddItem(item);
        }

        public void ShowLibrarians()
        {
            string str = "Librarians: \r\n";

            foreach (Librarian x in librarians)
                str += x + "\r\n";

            Console.WriteLine(str);
        }

        public void AddLibrarian(Librarian librarian)
        {
            if (librarian != null)
                librarians.Add(librarian);
        }

        public Librarian GetLibrarian(string name, string surname)
        {
            foreach (Librarian x in librarians)
                if (x.Name.Equals(name) && x.Surname.Equals(surname))
                    return x;

            return null;
        }

        public override string ToString()
        {
            string str = $"Library {address}: \r\nLibrarians:\r\n";

            foreach (Librarian librarian in Librarians)
                str += librarian;

            str += "\r\nCatalogs:\r\n";

            foreach (Catalog catalog in catalogs)
                str += catalog;

            return str;
        }
    }
}
