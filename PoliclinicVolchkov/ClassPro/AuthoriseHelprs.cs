using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using PoliclinicVolchkov.Views.Windows;

namespace PoliclinicVolchkov.ClassPro
{
    internal class AuthoriseHelprs
    {
        public static bool Authorise(string login, string password, string role)
        {
            if (login == string.Empty || password == string.Empty)
            {
                MessageBoxHelpers.Error("Не все поля для ввода были заполнены.");
                return false;
            }
            else
            {
                if (password == "2" && login == "1")
                {
                    MessageBoxHelpers.Information("Вы успешно вошли");
                    return true;
                }
                else if (password != "2" || login != "1")
                {
                    MessageBoxHelpers.Error("Не правильный логин или пороль.");
                    return false;
                }

                return false;
               
            }
        }
    }
}
