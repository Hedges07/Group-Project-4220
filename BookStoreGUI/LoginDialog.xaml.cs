using System.Windows;

namespace BookStoreLIB
{

    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            //Boolean accurate = true;

            string usernm = this.nameTextBox.Text;
            string passwd = this.passwordTextBox.Password;

            if (usernm == "" || passwd == "")
            {
                MessageBox.Show("Please fill in all slots");
            }
            else
            {
                var userData = new UserData();
                //essentially if it never broke, then its all good!
                if (userData.LogIn(usernm, passwd) == true)
                {
                    MessageBox.Show("You are logged in as User #" + userData.UserID);
                    this.DialogResult = true;
                }
                else if (!userData.accurate)
                    MessageBox.Show("Password requirements not met. Please try again.");
                else if (userData.LoginName == usernm && userData.Password == passwd)
                {
                    MessageBox.Show("User name exists, password may be incorrect");
                }
                else
                    MessageBox.Show("You could not be verified. Please try again.");

            }
        }


        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

    }
}
