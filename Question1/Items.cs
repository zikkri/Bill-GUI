using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    enum types { Electronic, Book, Toy, Jewlery  };    

    internal class Items
    {        
        public string Name { get; set; }
        public double Price { get; set; }
        public types Type { get; set; }

        public static List<Items> BILL { get; set; } = new List<Items>();

        public Items(string name, double price, types type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public static List<Items> PopluateElectronics()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items("Xbox", 199.01, types.Electronic));
            list.Add(new Items("Playstation", 299.99, types.Electronic));
            list.Add(new Items("Macbook", 1499.99, types.Electronic));
            list.Add(new Items("Nintendo Switch", 499.99, types.Electronic));
            list.Add(new Items("iPhone", 799.99, types.Electronic));

            return list;
        }

        public static List<Items> PopluateBooks()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items("The Black Echo", 16.99, types.Book));
            list.Add(new Items("Trunk Music", 11.99, types.Book));
            list.Add(new Items("A Darkness More Than Night", 19.99, types.Book));
            list.Add(new Items("The Concrete Blonde", 9.99, types.Book));
            list.Add(new Items("Angel's Flight", 14.99, types.Book));

            return list;
        }

        public static List<Items> PopluateToys()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items("Bop-It", 19.99, types.Toy));
            list.Add(new Items("Twister", 24.99, types.Toy));
            list.Add(new Items("Nerf Gun", 39.99, types.Toy));
            list.Add(new Items("Splashpad", 99.99, types.Toy));
            list.Add(new Items("Yo-Yo", 4.99, types.Toy));

            return list;
        }

        public static List<Items> PopluateJewlery()
        {
            List<Items> list = new List<Items>();
            list.Add(new Items("Necklace", 199.99, types.Jewlery));
            list.Add(new Items("Bracelet", 99.99, types.Jewlery));
            list.Add(new Items("Earrings", 79.99, types.Jewlery));
            list.Add(new Items("Watch", 499.99, types.Jewlery));
            list.Add(new Items("Ring", 240.99, types.Jewlery));

            return list;
        }

        public static double CalculateSubtotal()
        {
            double subTotal = 0;


            foreach(Items x in BILL)
            {
                subTotal += x.Price;
            }

            return subTotal;
        }

        public static double CalculateTax()
        {
            double tax;
            double subTotal = 0;

            foreach(Items x in BILL)
            {
                subTotal += x.Price;
            }

            tax = subTotal * .18;            

            return Math.Round(tax, 2); 
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}