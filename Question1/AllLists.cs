using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Question1
{
    internal class AllLists 
    {
        public List<Items> Electronics { get; set; } = new List<Items>();
        public List<Items> Books { get; set; } = new List<Items>();
        public List<Items> Toys { get; set; } = new List<Items>();        
        public List<Items> Jewlery { get; set; } = new List<Items>();
        public List<Items> Bill { get; set; } = new List<Items>();


        public int Quantity { get; set; }
        public double Cost { get; set; }


        public double Total { get; set; }
        public double Subtotal { get; set; } 
        public double Tax { get; set; } 

        public event PropertyChangedEventHandler PropertyChanged;

        public AllLists()
        {
            Electronics = new List<Items>(Items.PopluateElectronics());
            Books = new List<Items>(Items.PopluateBooks());
            Toys = new List<Items>(Items.PopluateToys());
            Jewlery = new List<Items>(Items.PopluateJewlery());

            //these ones need to update dynamically
            Total = Subtotal + Tax; 
            Tax = Items.CalculateTax();
            Subtotal = Items.CalculateSubtotal();
            Bill = Items.BILL; 
        }
    }
}
