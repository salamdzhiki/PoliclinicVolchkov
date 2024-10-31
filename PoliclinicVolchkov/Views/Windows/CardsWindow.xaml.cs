using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PoliclinicVolchkov.Views.Windows;

namespace PoliclinicVolchkov.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для CardsWindow.xaml
    /// </summary>
    public partial class CardsWindow : Window
    {
            
        public CardsWindow()
        {
            
            InitializeComponent();
           
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            Close();
        }

        private void AddRowBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BolCmb_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void BolCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void PolCmb_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void PolCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
