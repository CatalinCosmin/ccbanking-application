using System.Windows.Forms;
using CCBANKING.Entities;
using Npgsql;

namespace CCBANKING.Forms
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        public void Register(string username, string password, string email)
        {
            label4.Visible = false;
            {
                var connection = UserData.connection;
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    connection.Open();
                }
                var sqlcmd = $"INSERT INTO account(username, password, email, created_on)";
                sqlcmd += $"VALUES('{username}', '{password}', '{email}', CURRENT_TIMESTAMP)";
                try
                {
                    using (var cmd = new NpgsqlCommand(sqlcmd, connection))
                    {
                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                }
                catch (NpgsqlException)
                {
                    label4.Visible = true;
                }
            }
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if(textBox1.Text.Length >= 6 && textBox3.Text.Length >= 8 && (textBox2.Text.Contains("@gmail.") || textBox2.Text.Contains("@yahoo.")))
                Register(textBox1.Text, textBox3.Text, textBox2.Text);
            else
            {
                label4.Visible = true;
            }
        }
    }
}
