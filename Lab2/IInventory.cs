using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IInventory
    {
        public void PrintAllThings();
        public void UpgradeItem();
        public void ThrowOutItem();
        public void TakeItem(Things item);
        public void useItem(); 
    }
}
