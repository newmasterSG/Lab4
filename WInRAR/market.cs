using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace WInRAR
{
    class market
    {
        private string Goods;
        private int Number;
        public string goods
        {
            get
            {
                return Goods;
            }
            set
            {
                this.Goods = value;
            }
        }
        public int number
        {
            get
            {
                return Number;
            }
            set
            {
                this.Number = value;
            }
        }

        public market(string goods, int number)
        {
            this.Goods = goods;
            this.Number = number;
        }

    }

    class Customers : market
    {
        public Customers(string customers, string goods, int number) : base(goods, number)
        {
            Debug.Indent();
            Console.WriteLine("Your name");
            customers = Console.ReadLine();
            Console.WriteLine("You choice goods?");
            goods = Console.ReadLine();
            Console.WriteLine("Number what you want");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You : {customers} , your purchase : {goods} and numbers of this goods : {number}");
            Debug.WriteLine($"You : {customers} , your purchase : {goods} and numbers of this goods : {number}");
        }
    }

    class Seller : market
    {
        public Seller(string seller, string goods, int number) : base(goods, number)
        {
            Debug.Indent();
            seller = "Ivan Kurka";
            number = 191889;
            Console.WriteLine($"Served you by {seller} and his number {number}");
            Debug.WriteLine($"Served you by {seller} and his number {number}");
        }
    }
}
