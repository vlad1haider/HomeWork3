using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HumanResourcesManagement
{
    public partial class EmployeeListPage : Page
    {
        private List<Employee> employees;

        public EmployeeListPage()
        {
            InitializeComponent();
            LoadEmployees();
            EmployeeDataGrid.ItemsSource = employees;
        }

        private void LoadEmployees()
        {
            employees = new List<Employee>
            {
                new Employee { Name = "John Doe", Position = "Manager" },
                new Employee { Name = "Jane Smith", Position = "Developer" }
            };
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = (Employee)((Button)sender).DataContext;
            NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
    }
}