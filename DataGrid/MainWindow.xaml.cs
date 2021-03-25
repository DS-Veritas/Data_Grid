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

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create a new Employee Record
            // Initiate a new Employee object and give it some information
            Employee johnSmith = new Employee();

            // Add some details about "John Smith"
            johnSmith.employeeName = "John Smith";
            johnSmith.employeeID = "001";
            johnSmith.employeeCity = "Camden";
            johnSmith.employeeState = "New Jersey";
            johnSmith.employeeAddress = "122 Made Up Lane";

            DataGridXAML.Items.Add(johnSmith);
        }

        public class Employee
        {
            public string employeeID { get; set; }
            public string employeeName { get; set; }
            public string employeeAddress { get; set; }
            public string employeeCity { get; set; }
            public string employeeState { get; set; }

        }

        private void AddNewEmployeeBN_Clicked(object sender, RoutedEventArgs e)
        {
            Employee tempEmployee = new Employee();
            tempEmployee.employeeID = TextBoxID.Text;
            tempEmployee.employeeName = TextBoxName.Text;
            tempEmployee.employeeAddress = TextBoxAddress.Text;
            tempEmployee.employeeState = TextBoxState.Text;
            tempEmployee.employeeCity = TextBoxCity.Text;

            DataGridXAML.Items.Add(tempEmployee);
        }

        private void TextBoxID_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "ID" || txtBox.Text == "Name" || txtBox.Text == "Address" || txtBox.Text == "State" || txtBox.Text == "City")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBoxName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Name")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBoxState_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "State")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBoxCity_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "City")
            {
                txtBox.Text = string.Empty;
            }
        }

        private void TextBoxAddress_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Address")
            {
                txtBox.Text = string.Empty;
            }
        }
    }
}
