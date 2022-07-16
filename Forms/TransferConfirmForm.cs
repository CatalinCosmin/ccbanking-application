using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCBANKING.Entities;
using Npgsql;

namespace CCBANKING.Forms
{
    public partial class TransferConfirmForm : Form
    {
        public TransferConfirmForm()
        {
            InitializeComponent();
            CenterToParent();
            UpdateComponents();
            label1.Text = $"Selected card: * * {UserData.SelectedCard.number.Substring(12)}";
            label2.Text = $"Amount to transfer: {TransferAmountForm.AmountToTransfer} RON";
        }

        private int card_id;
        private int BalanceToExtract, BalanceToInsert;
        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            var pinok = false;
            var reccard = false;
            if (PINTextBox.Text == UserData.SelectedCard.pin)
                pinok = true;
            else
            {
                label6.Visible = true;
                pinok = false;
            }
            card_id = CardExists(ReceiverTextBox.Text);
            if (card_id != -1)
                reccard = true;
            else
            {
                label5.Visible = true;
                reccard = false;
            }
            if (pinok && reccard)
                Transfer();
        }

        private void SendMoney(int amountToTransfer)
        {
            using (var connection = new NpgsqlConnection(UserData.db))
            {
                connection.Open();
                var sqlcmd = $"UPDATE card SET balance = {BalanceToInsert + amountToTransfer} WHERE card_id = {card_id}; " +
                    $"UPDATE card SET balance = {BalanceToExtract - amountToTransfer} WHERE card_id = {UserData.SelectedCard.card_id};" +
                    $"INSERT INTO payment(source_card_id, source_user_id, destination_card_id, amount, payment_date) VALUES({UserData.SelectedCard.card_id}, {UserData.user.id}, {card_id}, {amountToTransfer}, CURRENT_TIMESTAMP)";
                using (var cmd = new NpgsqlCommand(sqlcmd, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Transfer()
        {
            BalanceToExtract = UserData.SelectedCard.balance;
            SendMoney(TransferAmountForm.AmountToTransfer);
            UserData.UpdateCardBalance(card_id);
            Close();
        }

        private int CardExists(string number)
        {
            using (var connection = new NpgsqlConnection(UserData.db))
            {
                connection.Open();
                var sqlcmd = $"SELECT card_id, balance FROM view_cards WHERE number = '{number}'";
                using(var cmd = new NpgsqlCommand(sqlcmd, connection))
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();
                            BalanceToInsert = reader.GetInt32(1);
                            return reader.GetInt32(0);
                        }
                    }
                }
            }
            return -1;
        }
    }
}
