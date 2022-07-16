using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CCBANKING.Forms
{
    public partial class ChangeTransferAmount : Form
    {
        public ChangeTransferAmount()
        {
            InitializeComponent();
            CenterToParent();
            UpdateComponents();
        }

        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.TextLength > 1)
            {
                label3.Visible = false;
                TransferAmountForm.AmountToTransfer = int.Parse(textBox1.Text);
                Close();
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
