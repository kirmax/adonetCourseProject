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
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
            pbPassword.Text = "ceo";
            tbLogin.Text = "ceo";

            
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text.Length == 0 || pbPassword.Text.Length == 0)
            {
                MessageBox.Show("Поля login и password не могут быть пустыми", "Error");
                return;
            }

            btnLogin.IsEnabled = false;
            Title = "Подключение к БД";

            ThreadPool.QueueUserWorkItem((args) =>
            {
                var acc = args as Account;

                using (DatabaseContext ctx = new DatabaseContext())
                {

                    string pswdHashed = MD5Hash.GetMD5Hash(acc.Password);
                    var res = ctx.Accounts.ToList();
                    var exists = res.Where(a => a.Login == acc.Login && a.Password == pswdHashed).Count() > 0;

                    if (exists)
                    {
                        Account account = ctx.Accounts.Where(a => a.Login == acc.Login && a.Password == pswdHashed).First();
                        Employee employee = ctx.Employees.Where(em => em.Account.Id == account.Id).First();

                        
                        Dispatcher.Invoke(new Action(() =>
                        {
                            MainWindow mw = new MainWindow(employee);
                            mw.Show();

                            this.Close();
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Error", "User not found");
                    }
                }
            }, new Account
            {
                Login = tbLogin.Text,
                Password = pbPassword.Text
            });
          // await Task.Run(new Action(() => ThreadParams(tbLogin.Text, pbPassword.Text)));
        }

        private void lbPswdChange_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            ChangePassword wndChangePswd = new ChangePassword();
            wndChangePswd.Show();
            this.Close();
        }
    }

}
