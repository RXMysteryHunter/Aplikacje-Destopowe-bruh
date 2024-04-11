namespace employes
{
    public partial class Form1 : Form
{

    public Form1()

    {
        InitializeComponent();
    }
    string lowercase_letters = "qwertyuiopasdfghjklzxcvbnm";

    string uppercase_letters = "QWERTYUIOPASDFGHJKLZXCVBNM";

    string numbers = "1234567890";

    string password = "";

    string special_characters = "!@#$%^&*()+-=";


    Random random = new Random();

    private void generatePassword_button_Click(object sender, EventArgs e)
    {
        password = "";
        int length = Convert.ToInt32(numberOfCharacters_textBox.Text);

        if (letters_checkBox.Checked)
        {
            password += uppercase_letters[random.Next(0, uppercase_letters.Length)];
        }
        if (numbers_checkBox.Checked)
        {
            password += numbers[random.Next(0, numbers.Length)];
        }
        if (specialCharacters_checkBox.Checked)
        {
            password += special_characters[random.Next(0, special_characters.Length)];
        }

        while (password.Length < length)
        {
            password += lowercase_letters[random.Next(0, lowercase_letters.Length)];
        }

        MessageBox.Show(password);
    }

    private void confirm_button_Click(object sender, EventArgs e)
        {
            string position = position_comboBox.Text;
            string firstName = firstName_textBox.Text;
            string lastName = lastName_textBox.Text;
        MessageBox.Show("Employee details: " + firstName + " " + lastName + ", Position: " + position + ", Password: " + password);
    }
}
}
