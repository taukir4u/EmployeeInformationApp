using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{

    
    public partial class EmployeeInfoUI : Form
    {
        Employee anEmployee = new Employee();
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            anEmployee.id = Convert.ToInt32(idTextBox.Text);
            anEmployee.name = nameTextBox.Text;
            anEmployee.salary = Convert.ToDouble(salaryTextBox.Text);
            ClearEmployeeInfoTextBox();
            MessageBox.Show("Employee Information: " + "\nId: " + anEmployee.id +
                "\nName: " + anEmployee.name + "\nSalary: " + anEmployee.salary);
        }

        private void ClearEmployeeInfoTextBox()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = anEmployee.id.ToString();
            nameTextBox.Text = anEmployee.name;
            salaryTextBox.Text = anEmployee.salary.ToString();
        }
    }
}
