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
using COMP5212.Model;

namespace COMP5212
{
}

    
    public partial class MainWindow : Window
    {



        private static void LoadDB()
        {
            List<Customer> CustomerDB = new List<Customer>();


            new Customer("Jaarna", "Kereopa", "123-2514");
            new Customer("Sue", "Stook", "123-1263");
            new Customer("Jamie", "Allom", "123-3658");
            new Customer("Brain", "Janes", "123-9898");

        }

        public MainWindow()
        {
            LoadDB();

            
        }
    }

