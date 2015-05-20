using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Store
    {
        private List<Item> items = new List<Item>();

        public Store()
        {
            items.Add(new Item(001,"Coca Cola", "Drink", 5.00M, 100));
            items.Add(new Item(002,"Diet Coca Cola", "Drink", 5.00M, 5));
            items.Add(new Item(003,"Red Bull", "Drink", 6.50M, 0));
            items.Add(new Item(004, "Water", "Drink", 3.50M, 0));
            items.Add(new Item(005,"Fanta", "Drink", 5.00M, 0));
            items.Add(new Item(006,"Sprite", "Drink", 5.00M, 0));
            items.Add(new Item(007,"Magners cider", "Liquer", 5.50M, 0));
            items.Add(new Item(008,"Jack Daniels", "Liquer", 8.50M, 0));
            items.Add(new Item(009,"Heineken", "Liquer", 6.50M, 0));
            items.Add(new Item(100,"Bavaria", "Liquer", 6.50M, 0));

        }
        public List<Item> GetAllItems() { return items; }
    }
}
