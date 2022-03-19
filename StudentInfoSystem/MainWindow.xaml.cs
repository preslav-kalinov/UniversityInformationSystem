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

namespace StudentInfoSystem
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

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearText();
        }

        private void getStudentButton_Click(object sender, RoutedEventArgs e)
        {
            StudentData studentData = new StudentData();

            showInfo(studentData.GetTestStudents().First());
        }

        private void enableButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control box in StudentGrid.Children)
                box.IsEnabled = true;
        }

        private void disableButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Control box in StudentGrid.Children)
            {
                if (box.Name.Equals(enableButton.Name))
                    box.IsEnabled = true;
                else
                    box.IsEnabled = false;
            }
        }

        private void ClearText()
        {
            foreach (Control box in StudentGrid.Children)
            {
                if (box.GetType() == typeof(TextBox))
                    ((TextBox)box).Text = String.Empty;
            }
        }

        private void showInfo(Student student)
        {
            txtBoxName.Text = student.name;
            txtBoxSurName.Text = student.surname;
            txtBoxFamilyName.Text = student.lastName;
            txtBoxSpecialty.Text = student.specialty;
            txtBoxStatus.Text = student.status;
            txtBoxFNum.Text = student.facNumber;
            txtBoxEduLevel.Text = student.educationLevel;
            txtBoxCourse.Text = student.course.ToString();
            txtBoxStream.Text = student.stream.ToString();
            txtBoxGroup.Text = student.group.ToString();
        }
    }
}
