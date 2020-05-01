using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public interface IItemManager
    {
        void ShowItems();
        Item FindItemByID(int id);
        Item FindItemByTitle(string title);
    }
}
