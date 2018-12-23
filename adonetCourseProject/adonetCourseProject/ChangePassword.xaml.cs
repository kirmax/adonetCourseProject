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

namespace adonetCourseProject
{
    /// <summary>
    /// Логика взаимодействия для ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbLogin.Text != "")
                pbPassword.IsEnabled = true;
            else
                pbPassword.IsEnabled = false;
            
        }

        private void pbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (pbPassword.Text != "")
                pbТNewPassword.IsEnabled = true;
            else
                pbТNewPassword.IsEnabled = false;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var pswdHashed = MD5Hash.GetMD5Hash(pbPassword.Text);
                Account accToChangePswd = ctx.Accounts.Where(a => a.Login == tbLogin.Text && a.Password == pswdHashed).First();

                try
                {
                    if (pbТNewPassword.Text != "")
                    {
                        accToChangePswd.Password = MD5Hash.GetMD5Hash(pbТNewPassword.Text);
                        ctx.SaveChanges();
                    }

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Неверный логин или пароль", "Error");
                }
            }
            this.Close();

        }
    }

    
}
