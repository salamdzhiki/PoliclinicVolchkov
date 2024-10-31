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
    /// Логика взаимодействия для profileWindow.xaml
    /// </summary>
    public partial class profileWindow : Window
    {
        public profileWindow()
        {
            InitializeComponent();
        }

        private void ChangePasswordCb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            Close();
        }
    }
}
