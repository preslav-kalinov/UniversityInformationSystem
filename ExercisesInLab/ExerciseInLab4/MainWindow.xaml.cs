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

namespace ExerciseInLab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int number;
            var text = Text1.Text;
            bool result = int.TryParse(text, out number);
            if (!result)
            {
                //ErrorLabel errLabel = new ErrorLabel();
                ErrorLabel.Border = BorderBrush.Crymson;
                ErrorLabel.Visibility = Visibility.Visible;
            }


        }
    }
}
