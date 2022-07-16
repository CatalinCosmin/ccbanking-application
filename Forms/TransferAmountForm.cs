using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCBANKING.Entities;

namespace CCBANKING.Forms
{
    public partial class TransferAmountForm : Form
    {
        
        public TransferAmountForm()
        {
            InitializeComponent();
            CenterToParent();
            label1.Text = $"Selected card: * * {UserData.SelectedCard.number.Substring(12)}";
            label2.Text = $"Amount to transfer: 0 RON";
        }
        
        public static int AmountToTransfer;

        private void button6_Click(object sender, EventArgs e)
        {
            AmountToTransfer = 50;
            label2.Text = $"Amount to transfer: {AmountToTransfer} RON";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmountToTransfer = 100;
            label2.Text = $"Amount to transfer: {AmountToTransfer} RON";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmountToTransfer = 500;
            label2.Text = $"Amount to transfer: {AmountToTransfer} RON";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new ChangeTransferAmount();
            form.ShowDialog();
            label2.Text = $"Amount to transfer: {AmountToTransfer} RON";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form = new BalanceInquiryForm();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(UserData.SelectedCard.balance >= AmountToTransfer && AmountToTransfer > 0)
            {
                label3.Visible = false;
                Form form = new TransferConfirmForm();
                form.ShowDialog();
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
