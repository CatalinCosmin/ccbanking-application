using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCBANKING.Entities;

namespace CCBANKING.Forms
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
            this.CenterToParent();
            UpdateComponents();
        }
        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));
        }

        private void AddCardButton_Click(object sender, EventArgs e)
        {
            if (CardNumberInput.Text.Length == 16 && CardPinInput.Text.Length == 4 && CardCCVInput.Text.Length == 3)
            {
                if (UserData.AddCard(CardNumberInput.Text, CardPinInput.Text, CardCCVInput.Text))
                {
                    label3.Visible = false;
                    this.Close();
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "The PIN/CCV are invalid or someone is already using this card.";
                }
            }
            else
            {
                label4.Visible = true;
                label4.Text = "The fields are not completed correctly.";
            }
        }
    }
}
