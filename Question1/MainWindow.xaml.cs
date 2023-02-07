using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {            
            DataContext = new AllLists();
            InitializeComponent();
        }

        private void cbElectronics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items i  = (Items)cbElectronics.SelectedValue;
            Items.BILL.Add(i);            
            Bill.Items.Add(i);
            
            double subT = Items.CalculateSubtotal();
            double taxxxxx = Items.CalculateTax();
            double total = subT + taxxxxx;

            Subtotal.Text = String.Format($"{subT:C}");
            Tax.Text = String.Format($"{taxxxxx:C}");
            Total.Text = String.Format($"{total:C}");                        
        }

        private void cbBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items i = (Items)cbBooks.SelectedValue;
            Items.BILL.Add(i);
            Bill.Items.Add(i);                        

            double subT = Items.CalculateSubtotal();
            double taxxxxx = Items.CalculateTax();
            double total = subT + taxxxxx;

            Subtotal.Text = String.Format($"{subT:C}");
            Tax.Text = String.Format($"{taxxxxx:C}");
            Total.Text = String.Format($"{total:C}");
        }

        private void cbToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items i = (Items)cbToys.SelectedValue;
            Items.BILL.Add(i);
            Bill.Items.Add(i);

            double subT = Items.CalculateSubtotal();
            double taxxxxx = Items.CalculateTax();
            double total = subT + taxxxxx;

            Subtotal.Text = String.Format($"{subT:C}");
            Tax.Text = String.Format($"{taxxxxx:C}");
            Total.Text = String.Format($"{total:C}");
        }
        private void cbJewlery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Items i = (Items)cbJewlery.SelectedValue;
            Items.BILL.Add(i);
            Bill.Items.Add(i);

            double subT = Items.CalculateSubtotal();
            double taxxxxx = Items.CalculateTax();
            double total = subT + taxxxxx;

            Subtotal.Text = String.Format($"{subT:C}");
            Tax.Text = String.Format($"{taxxxxx:C}");
            Total.Text = String.Format($"{total:C}");
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Items i = (Items)Bill.SelectedItem;                        
            Items.BILL.Remove(i);

            double subT = Items.CalculateSubtotal();
            double taxxxxx = Items.CalculateTax();
            double total = subT + taxxxxx;

            Subtotal.Text = String.Format($"{subT:C}");
            Tax.Text = String.Format($"{taxxxxx:C}");
            Total.Text = String.Format($"{total:C}");

            
            Bill.Items.Remove(Bill.SelectedItem);                         
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Bill.Items.Clear();
            Items.BILL.Clear();
            Subtotal.Text = "";
            Tax.Text = "";
            Total.Text = "";               
        }
    }
}
