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
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();


        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text.Length == 0 || pbPassword.Password.Length == 0)
            {
                MessageBox.Show("Поля login и password не могут быть пустыми", "Error");
                return;
            }

            using (DatabaseContext ctx = new DatabaseContext())
            {
                if (ctx.Accounts.Where(a => a.Login == tbLogin.Text && a.Password == pbPassword.Password).Count() > 0)
                {
                    Account account = ctx.Accounts.Where(a => a.Login == tbLogin.Text && a.Password == pbPassword.Password).First();
                    Employee employee = ctx.Employees.Where(em => em.Account.Id == account.Id).First();
                    MainWindow mw = new MainWindow(employee);
                    mw.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "User not found");
                }

            }

        }

        
    }
}
