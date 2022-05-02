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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = userNameBox.Text.ToString();
            string password = passwordBox.Password.ToString();
            foreach (Student student in StudentData.TestStudents)
            {
                if (username == student.username && password == student.password)
                {
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
            }
        }
    }
}
