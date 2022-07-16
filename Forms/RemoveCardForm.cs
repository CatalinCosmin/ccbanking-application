using System;
using System.Windows.Forms;
using CCBANKING.Entities;
using Npgsql;

namespace CCBANKING.Forms
{
    public partial class RemoveCardForm : Form
    {
        public RemoveCardForm()
        {
            InitializeComponent();
            Initializer();
        }

        private void Initializer()
        {
            this.CenterToParent();
            GenerateCardListBox();
        }

        private void GenerateCardListBox()
        {
            if (UserData.cards.Count > 0)
                foreach (var card in UserData.cards)
                {
                    listBox1.Items.Add("****" + card.number.Substring(12));
                }
        }

        private void SelectCardButton_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if(card == null)
            {
                label5.Visible = true;
                return;
            }
            UserData.RemoveCard(this, listBox1.SelectedIndex);
            this.Close();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            card = UserData.cards[listBox1.SelectedIndex];
        }

        public Card card;
    }
}
