using System;
using System.Windows.Forms;
using CCBANKING.Entities;
using CCBANKING.Forms;

namespace CCBANKING
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitAppButton_Click(object sender, EventArgs e) // Exit button from bar
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e) // Load LoginContainer
        {
            LoginContainer.Visible = true;
        }

        private void LoginInputButton_Click(object sender, EventArgs e)
        {
            var username = UsernameInputBox.Text;
            var password = PasswordInputBox.Text;
            var InputValid = UserData.GetData(username, password); // check if the inputs are valid; if they are, UserData.user stores our data
            if(InputValid) // if the inputs are valid
            {
                ErrorMessageLabel.Visible = false;
                LoginContainer.Visible = false;
                MainContainer.Visible = true;
                InitializeMainContainer();
            }
            else
            {
                ErrorMessageLabel.Visible = true; // throw an error "Username or password is invalid"
            }
        }

        private void InitializeMainContainer()
        {
            label5.Text = $"Welcome, {UserData.user.username}"; // modify username logged on
            label6.Text = "Selected card: none";
            label7.Visible = false;
            label8.Visible = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e) // Logout
        {
            MainContainer.Visible = false;
            LoginContainer.Visible = true;
            UserData.SelectedCard = null;
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            Form form = new AddCardForm();
            form.ShowDialog();
            if (UserData.cards.Count > 0)
            {
                label7.Visible = false;
                label8.Visible = false;
            }
        }

        private void SelectCardButton_Click(object sender, EventArgs e)
        {
            if(UserData.cards.Count > 0)
            {
                label7.Visible = false;
                Form form = new SelectCardForm();
                form.ShowDialog();
                if (UserData.SelectedCard != null)
                    label6.Text = $"Selected card: {UserData.SelectedCard.number.Substring(12)}";
            }
            else
            {
                label7.Visible = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Form form = new RegisterUserForm();
            form.ShowDialog();
        }

        private void RemoveCardButton_Click(object sender, EventArgs e)
        {
            if (UserData.cards.Count > 0)
            {
                label8.Visible = false;
                Form form = new RemoveCardForm();
                form.ShowDialog();
                if(UserData.cards.Count == 0)
                    label6.Text = "Selected card: none";
            }
            else
                label8.Visible = true;
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            Form form = new DepositAmountForm();
            form.ShowDialog();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if(UserData.SelectedCard != null)
            {
                Form form = new TransferAmountForm();
                form.ShowDialog();
            }
        }
    }
}
