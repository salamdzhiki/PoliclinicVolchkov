using PoliclinicVolchkov.ClassPro;
using PoliclinicVolchkov.Views.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PoliclinicVolchkov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

        }



        public void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text;
            string password = PassTb.Password;

            if (login == string.Empty || password == string.Empty)
            {
                MessageBoxHelpers.Error("Не все поля для ввода были заполнены.");
                
            }

            if (password != "2" || login != "1")
            {
                MessageBoxHelpers.Error("Не правильный логин или пороль.");
            }

            if (password == "2" && login == "1")
            {
                MessageBoxHelpers.Information("Вы успешно вошли");
                ManagerWindow managerWindow = new ManagerWindow();
                managerWindow.Show();
                Close();
                
            }

            

        }
    }
}
