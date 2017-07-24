using System.Windows;

namespace OMTestTask
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public string EmployeeName
        {
            get { return tbNameEmployee.Text; }
        }

        public string EmployeePassword
        {
            get { return tbPasswordEmployee.Password; }
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void On_btnLoginEmployee_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
