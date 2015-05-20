using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
   public class Item
    {
       public int ItemId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Item()
        { }
        public Item(int id, string name, string type, decimal price, int quantity)
        {
            this.ItemId = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
