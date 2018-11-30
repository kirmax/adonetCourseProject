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
            using (DatabaseContext ctx = new DatabaseContext())
            {
                
                
            }

        }

        /*[Function(Name = "IsAuthenticate")]
        [return: Parameter(DbType = "int")]
        public int Authenticate([Parameter(Name = "login", DbType = "nvarchar(50)")] string login,
                                 [Parameter(Name = "password", DbType = "nvarchar(50)")] string password)
        {
            //Получение информации о текущем методе
            MethodInfo methodInfo = (MethodInfo)MethodInfo.GetCurrentMethod();

            //Вызов функции
            IExecuteResult res = ExecuteMethodCall(this, methodInfo, login, password);
            return (int)res.ReturnValue;
        }*/
    }
}
