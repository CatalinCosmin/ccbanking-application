
namespace CCBANKING.Forms
{
    partial class SelectCardForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CardPinInput = new System.Windows.Forms.TextBox();
            this.SelectCardButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(227, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 35);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Selected";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(146, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN";
            // 
            // CardPinInput
            // 
            this.CardPinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.CardPinInput.Location = new System.Drawing.Point(227, 72);
            this.CardPinInput.MaxLength = 4;
            this.CardPinInput.Name = "CardPinInput";
            this.CardPinInput.PasswordChar = '*';
            this.CardPinInput.Size = new System.Drawing.Size(222, 33);
            this.CardPinInput.TabIndex = 3;
            // 
            // SelectCardButton
            // 
            this.SelectCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SelectCardButton.Location = new System.Drawing.Point(227, 136);
            this.SelectCardButton.Name = "SelectCardButton";
            this.SelectCardButton.Size = new System.Drawing.Size(222, 41);
            this.SelectCardButton.TabIndex = 4;
            this.SelectCardButton.Text = "SELECT CARD";
            this.SelectCardButton.UseVisualStyleBackColor = true;
            this.SelectCardButton.Click += new System.EventHandler(this.SelectCardButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "PIN is incorrect";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(250, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Click on the card to select it";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "There is no selected card.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // SelectCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectCardButton);
            this.Controls.Add(this.CardPinInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectCardForm";
            this.Text = "SELECT CARD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void UpdateComponents()
        {
            this.CardPinInput.KeyPress += UserInput_KeyPress;
        }

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CardPinInput;
        private System.Windows.Forms.Button SelectCardButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}