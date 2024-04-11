using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class EmployeeForm : Form
    {
        private GroupBox employeeDetailsGroupBox;
        private GroupBox passwordGroupBox;
        private ComboBox positionComboBox;
        private Button generatePasswordButton;
        private TextBox passwordTextBox;
        private NumericUpDown passwordLengthNumericUpDown;
        private Button confirmButton;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label passwordLabel;
        private Label passwordLengthLabel;
        private Label positionLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;

        private string generatedPassword = "";

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
        }
    }
}