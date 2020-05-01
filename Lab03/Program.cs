using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Book("Ksiazka A", 1, "Wydawnictwo 1", new DateTime(2010, 1, 1), 1100);
            Item item2 = new Journal("Czasopismo B", 2, "Wydawnictwo 2", new DateTime(1998, 1, 2), 127);


            ((Book)item1).AddAuthor(new Author("Jan", "Kowalski", "Polish"));

            IList<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);
            items.Add(new Book());
            Catalog catalog = new Catalog("Programowanie", items);
            Console.WriteLine(catalog);

            Console.WriteLine(catalog.FindItemByID(2));
            Console.WriteLine(catalog.FindItemByTitle("Ksiazka"));
            catalog.ShowItems();

            Console.WriteLine("---------------------------------------");

            Person librarian = new Librarian("Janusz", "Nowak", DateTime.Now.Date, 3500);
            Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());

            library.AddLibrarian((Librarian)librarian);
            library.ShowLibrarians();

            Catalog catalog2 = new Catalog("Dramat", new List<Item>());
            library.AddCatalog(catalog2);
            library.AddCatalog(catalog);

            Item newItem = new Book("Ksiazka C", 4, "Wydawnictwo 3", new DateTime(2006, 12, 1), 450);
            library.AddItem(newItem, "Dramat");
            Console.WriteLine(library);
            library.ShowItems();

            var findById = library.FindItemByID(1);
            var findByTitle = library.FindItemByTitle("Ksiazka C");
            Console.WriteLine(findById);
            Console.WriteLine(findByTitle);

            Console.ReadKey();
        }
    }
}
