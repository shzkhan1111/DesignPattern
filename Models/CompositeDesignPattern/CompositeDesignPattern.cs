using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CompositeDesignPattern
{
    public interface CompositeDesignPattern
    {
        decimal GetPrice();

    }

    public class Product : CompositeDesignPattern
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Product(string name , int price)
        {
            Name = name;
            Price = price;
        }
        public decimal GetPrice()
        {
            return Price;
        }
    }
    public class Items : CompositeDesignPattern
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Items(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public decimal GetPrice()
        {
            return Price;
        }
    }

    public class Box : CompositeDesignPattern
    {
        private List<CompositeDesignPattern> proditems = new List<CompositeDesignPattern>();

        public void AddItem(CompositeDesignPattern item)
        {
            proditems.Add(item);
        }
        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in proditems)
            {
                total += item.GetPrice();
            }
            return total;
        }

    }
}
