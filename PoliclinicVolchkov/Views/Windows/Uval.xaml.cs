using PoliclinicVolchkov.ClassPro;
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
    /// Логика взаимодействия для Uval.xaml
    /// </summary>
    public partial class Uval : Window
    {
        public Uval()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxHelpers.Information("Сотрудник успешно уволен!");
            ManagerWindow managerWindow = new ManagerWindow();
            managerWindow.Show();
            Close();
        }
    }
}
