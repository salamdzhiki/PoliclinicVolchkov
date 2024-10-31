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
using System.Windows.Shapes;

namespace PoliclinicVolchkov.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private void MyProfBtn_Click(object sender, RoutedEventArgs e)
        {
            profileWindow profileWindow = new profileWindow();
            profileWindow.Show();
            Close();
        }

        private void MerBtn_Click(object sender, RoutedEventArgs e)
        {
            CardsWindow cardWindow = new CardsWindow();
            cardWindow.ShowDialog();
            Close();
        }

        private void JurBtn_Click(object sender, RoutedEventArgs e)
        {
            Uval uval = new Uval();
            uval.ShowDialog();
            Close();
        }

        private void UchBtn_Click(object sender, RoutedEventArgs e)
        {
            Raspisanie raspisanie = new Raspisanie();
            raspisanie.ShowDialog();
            Close();
        }
    }
}
