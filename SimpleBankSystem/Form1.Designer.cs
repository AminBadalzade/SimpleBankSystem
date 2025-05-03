namespace SimpleBankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            Deposit = new Button();
            Withdraw = new Button();
            CreateAccountBtn = new Button();
            InterestNum = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 265);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OwnerTxt.Location = new Point(103, 36);
            OwnerTxt.Margin = new Padding(3, 2, 3, 2);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(153, 29);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountNum.Location = new Point(103, 263);
            AmountNum.Margin = new Padding(3, 2, 3, 2);
            AmountNum.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(153, 29);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BankAccountGrid.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BankAccountGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            BankAccountGrid.DefaultCellStyle = dataGridViewCellStyle4;
            BankAccountGrid.Location = new Point(322, 36);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.Size = new Size(409, 211);
            BankAccountGrid.TabIndex = 4;
            // 
            // Deposit
            // 
            Deposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Deposit.Location = new Point(322, 263);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(194, 40);
            Deposit.TabIndex = 5;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            Deposit.Click += Deposit_Click;
            // 
            // Withdraw
            // 
            Withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Withdraw.Location = new Point(522, 263);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(209, 40);
            Withdraw.TabIndex = 6;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += Withdraw_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccountBtn.Location = new Point(103, 130);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(153, 34);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // InterestNum
            // 
            InterestNum.AutoSize = true;
            InterestNum.Font = new Font("Segoe UI", 12F);
            InterestNum.Location = new Point(35, 81);
            InterestNum.Name = "InterestNum";
            InterestNum.Size = new Size(123, 21);
            InterestNum.TabIndex = 8;
            InterestNum.Text = "Interest rate (%):";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InterestRateNum.Location = new Point(157, 79);
            InterestRateNum.Margin = new Padding(3, 2, 3, 2);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(99, 29);
            InterestRateNum.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 321);
            Controls.Add(InterestRateNum);
            Controls.Add(InterestNum);
            Controls.Add(CreateAccountBtn);
            Controls.Add(Withdraw);
            Controls.Add(Deposit);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += CreateAccountBtn_Click;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button Deposit;
        private Button Withdraw;
        private Button CreateAccountBtn;
        private Label InterestNum;
        private NumericUpDown InterestRateNum;
    }
}
