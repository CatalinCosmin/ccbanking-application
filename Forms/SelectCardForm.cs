using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCBANKING.Entities;

namespace CCBANKING.Forms
{
    public partial class SelectCardForm : Form
    {
        public SelectCardForm()
        {
            InitializeComponent();
            Initializer();
            UpdateComponents();
        }

        private void Initializer()
        {
            this.CenterToParent();
            if(UserData.cards.Count > 0)
                foreach(var card in UserData.cards)
                {
                    listBox1.Items.Add("****" + card.number.Substring(12));
                }
        }

        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            card = UserData.cards[listBox1.SelectedIndex];
        }

        private void SelectCardButton_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if(card == null)
            {
                label5.Visible = true;
                return;
            }
            if (CardPinInput.Text == card.pin)
            {
                label3.Visible = false;
                UserData.SelectedCard = card;
                this.Close();
            }
            else
            {
                label3.Visible = true;
            }
        }
        
        private Card card;
    }
}
