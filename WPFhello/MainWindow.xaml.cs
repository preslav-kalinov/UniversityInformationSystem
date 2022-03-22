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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            var s="";
            foreach (var item in MyGUI.Children)
            {
                if (item is TextBox)
                {
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
                }
            }
            if (txtName.Text.Length <= 1)
            {
                MessageBox.Show("Invalid input! Enter 2 or more symbols.");
            }
            else
                MessageBox.Show("Здрасти " + txtName.Text + "!!!\nТова е твоята първа програма на Visual Studio 2019!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();

            textBlock1.Text = DateTime.Now.ToString();
        }

        private void greetingBtn_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();
            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}
