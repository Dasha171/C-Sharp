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
    /// <summary>
    /// Логика взаимодействия для PhoneNum.xaml
    /// </summary>
    public partial class PhoneNum : Page
    {
        public PhoneNum()
        {
            InitializeComponent();
        }
        //6-7-8 лаба
        public class Phone
        {

            public string Title { get; set; }
            public string Company { get; set; }
            public int Price { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["nexusPhone"];
            phone.Company = "LG";
        }
    }
}
