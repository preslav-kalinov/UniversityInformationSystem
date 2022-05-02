using System.Windows;


namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseReport.xaml
    /// </summary>
    public partial class ExpenseReport : Window
    {
        public ExpenseReport(object data) : this()
        {
            this.DataContext = data;
        }
        public ExpenseReport()
        {
            InitializeComponent();
        }
    }
}
