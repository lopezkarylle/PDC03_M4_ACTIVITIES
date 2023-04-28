using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03Module04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Im Nayeon", Position = "Chief Executive Officer" });
            employees.Add(new Employee { DisplayName = "Yoo Jeongyeon", Position = "Chief Operating Officer" });
            employees.Add(new Employee { DisplayName = "Hirai Momo", Position = "Chief Financial Officer" });
            employees.Add(new Employee { DisplayName = "Minatozaki Sana", Position = "Chief Marketing Officer" });
            employees.Add(new Employee { DisplayName = "Park Jihyo", Position = "Marketing Manager" });
            employees.Add(new Employee { DisplayName = "Myoui Mina", Position = "Sales Manager" });
        
         }

        private void Add_Item(object sender, EventArgs e)
        {
            
        }
        private void Edit_Item(object sender, EventArgs e)
        {

        }
        private void Delete_Item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            { 
            
            }
        }
    }
}