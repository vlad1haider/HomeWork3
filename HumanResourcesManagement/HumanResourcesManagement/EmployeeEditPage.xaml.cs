using System.Windows;
using System.Windows.Controls;

namespace HumanResourcesManagement
{
    public partial class EmployeeEditPage : Page
    {
        private Employee _employee;

        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            NameTextBox.Text = _employee.Name;
            PositionTextBox.Text = _employee.Position;
        }

        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            
            _employee.Name = NameTextBox.Text;
            _employee.Position = PositionTextBox.Text;

            
            MessageBox.Show("Changes saved successfully!");
            NavigationService.GoBack(); 
        }
    }
}