using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Journal : Item
    {
        private int releaseNumber;

        public int ReleaseNumber { get => releaseNumber; set => releaseNumber = value; }

        public Journal() : base()
        {
            releaseNumber = 0;
        }

        public Journal(string title, int id, string publisher, DateTime publicationDate, int releaseNumber) : base(title, id, publicationDate, publisher)
        {
            this.releaseNumber = releaseNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $" relase number {releaseNumber}";
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
        }
    }
}
