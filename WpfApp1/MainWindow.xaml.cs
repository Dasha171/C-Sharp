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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //1 задание
       private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["buttonBrush"] = new SolidColorBrush(Colors.LimeGreen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        /*
       private void button1_Click(object sender, RoutedEventArgs e)
       {
           SolidColorBrush buttonBrash = (SolidColorBrush)this.TryFindResource("buttonBrush");
           buttonBrush.Color=Colors.LimeGreen;
       }*/
        
    }

    //6-7-8 задание 
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

}
