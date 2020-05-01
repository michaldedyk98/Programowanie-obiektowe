using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Catalog : IItemManager
    {
        private string thematicSection;
        private IList<Item> items;

        public string ThematicSection { get => thematicSection; set => thematicSection = value; }
        public IList<Item> Items { get => items; }

        public Catalog(string thematicSection, IList<Item> items)
        {
            this.thematicSection = thematicSection;
            this.items = items;
        }

        public Catalog(string thematicSection)
        {
            this.thematicSection = thematicSection;
            items = new List<Item>();
        }
        public Catalog()
        {
            thematicSection = "None";
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            string str = $"Catalog, thematic section {thematicSection}\r\n[Items]\r\n";

            foreach (Item x in items)
                str += x + "\r\n";

            return str;
        }

        public void ShowItems()
        {
            string str = "Items: \r\n";
            foreach (Item x in items)
                str += x + "\r\n";

            Console.WriteLine(str);
        }

        public Item FindItemByID(int id)
        {
            foreach (Item x in items)
                if (x.Id == id)
                    return x;
            return null;
        }

        public Item FindItemByTitle(string title)
        {
            foreach (Item x in items)
                if (x.Title.Equals(title))
                    return x;
            return null;
        }
    }
}
