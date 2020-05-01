using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public interface ILibrarianManager
    {
        void ShowLibrarians();

        void AddLibrarian(Librarian l);
        Librarian GetLibrarian(string name, string surname);
    }
}
