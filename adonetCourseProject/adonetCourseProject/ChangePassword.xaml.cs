using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            if (tbLogin.Text.Length == 0 || pbPassword.Text.Length == 0 || pbТNewPassword.Text.Length == 0)
            {
                MessageBox.Show("Поля логин,пароль и новый пароль не могут быть пустыми", "Error");
                return;
            }
            var pswdHashed = MD5Hash.GetMD5Hash(pbPassword.Text);
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var exists = ctx.Accounts.ToList().Where(a => a.Login == tbLogin.Text && a.Password == pswdHashed).Count() > 0;


                if (exists)
                {
                    Account account = ctx.Accounts.Where(a => a.Login == tbLogin.Text && a.Password == pswdHashed).First();
                    Employee employee = ctx.Employees.Where(em => em.Account.Id == account.Id).First();
                    account.Password = MD5Hash.GetMD5Hash(pbТNewPassword.Text);
                    ctx.SaveChanges();


                    MainWindow mw = new MainWindow(employee);
                    mw.Show();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль", "Error");
                }
            }
            /*
            ThreadPool.QueueUserWorkItem((args) =>
            {
                var acc = args as Account;
                using (DatabaseContext ctx = new DatabaseContext())
                {
                   
                    var exists = ctx.Accounts.ToList().Where(a => a.Login == acc.Login && a.Password == pswdHashed).Count() > 0;


                    if (exists)
                    {
                        Account account = ctx.Accounts.Where(a => a.Login == acc.Login && a.Password == pswdHashed).First();
                        Employee employee = ctx.Employees.Where(em => em.Account.Id == account.Id).First();
                        account.Password = MD5Hash.GetMD5Hash(pbТNewPassword.Text);
                        ctx.SaveChanges();

                        Dispatcher.Invoke(new Action(() =>
                        {
                            MainWindow mw = new MainWindow(employee);
                            mw.Show();

                            this.Close();
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Error");
                    }



                }
            }, new Account
            {
                Login = tbLogin.Text,
                Password = pbPassword.Text
            });*/



           

        }
    }


}
