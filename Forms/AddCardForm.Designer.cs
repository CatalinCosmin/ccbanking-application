
using System.Windows.Forms;

namespace CCBANKING.Forms
{
    partial class AddCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CardNumberInput = new System.Windows.Forms.TextBox();
            this.CardPinInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CardCCVInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // CardNumberInput
            // 
            this.CardNumberInput.Location = new System.Drawing.Point(133, 12);
            this.CardNumberInput.MaxLength = 16;
            this.CardNumberInput.Name = "CardNumberInput";
            this.CardNumberInput.Size = new System.Drawing.Size(180, 20);
            this.CardNumberInput.TabIndex = 1;
            // 
            // CardPinInput
            // 
            this.CardPinInput.Location = new System.Drawing.Point(133, 77);
            this.CardPinInput.MaxLength = 4;
            this.CardPinInput.Name = "CardPinInput";
            this.CardPinInput.PasswordChar = '*';
            this.CardPinInput.Size = new System.Drawing.Size(180, 20);
            this.CardPinInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // CardCCVInput
            // 
            this.CardCCVInput.Location = new System.Drawing.Point(133, 44);
            this.CardCCVInput.MaxLength = 3;
            this.CardCCVInput.Name = "CardCCVInput";
            this.CardCCVInput.PasswordChar = '*';
            this.CardCCVInput.Size = new System.Drawing.Size(180, 20);
            this.CardCCVInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "CCV";
            // 
            // AddCardButton
            // 
            this.AddCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddCardButton.Location = new System.Drawing.Point(175, 110);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(150, 40);
            this.AddCardButton.TabIndex = 6;
            this.AddCardButton.Text = "ADD CARD";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "text";
            this.label4.Visible = false;
            // 
            // AddCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.CardCCVInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardPinInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardNumberInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCardForm";
            this.Text = "ADD CARD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void UpdateComponents()
        {
            this.CardNumberInput.KeyPress += UserInput_KeyPress;
        }

        private Label label1;
        private TextBox CardNumberInput;
        private TextBox CardPinInput;
        private Label label2;
        private TextBox CardCCVInput;
        private Label label3;
        private Button AddCardButton;
        private Label label4;
    }
}