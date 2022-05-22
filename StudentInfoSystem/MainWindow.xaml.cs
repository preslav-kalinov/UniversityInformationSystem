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
using System.Data;
using System.Data.SqlClient;


namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> StudStatusChoices { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FillStudStatusChoices();
            DataContext = this;

            /*if (TestStudentsIfEmpty())
            {
                CopyTestStudents();
            }*/
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
            txtBoxName.Text = String.Empty;
            txtBoxSurName.Text = String.Empty;
            txtBoxFamilyName.Text = String.Empty;
            txtBoxFaculty.Text = String.Empty;
            txtBoxSpecialty.Text = String.Empty;
            txtBoxStatus.Text = String.Empty;
            txtBoxFNum.Text = String.Empty;
            txtBoxEduLevel.Text = String.Empty;
            txtBoxCourse.Text = String.Empty;
            txtBoxStream.Text = String.Empty;
            txtBoxGroup.Text = String.Empty;
        }

        private void showInfo(Student student)
        {
            txtBoxName.Text = student.name;
            txtBoxSurName.Text = student.surname;
            txtBoxFamilyName.Text = student.lastName;
            txtBoxFaculty.Text = student.faculty;
            txtBoxSpecialty.Text = student.specialty;
            txtBoxStatus.Text = student.status;
            txtBoxFNum.Text = student.facNumber;
            txtBoxEduLevel.Text = student.educationLevel;
            txtBoxCourse.Text = student.course.ToString();
            txtBoxStream.Text = student.stream.ToString();
            txtBoxGroup.Text = student.group.ToString();
        }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr
                FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                 connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            int count = queryStudents.Count();

            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }

            context.SaveChanges();
        }
    }
}
