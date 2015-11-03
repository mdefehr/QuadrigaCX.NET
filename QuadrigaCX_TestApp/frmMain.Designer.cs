namespace QuadrigaCX_TestApp
{
    partial class frmMain
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPISecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.btnGetAccountBalance = new System.Windows.Forms.Button();
            this.btnUserTransactions = new System.Windows.Forms.Button();
            this.btnCurrentTradingInfo = new System.Windows.Forms.Button();
            this.btnOrderBook = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderBook = new System.Windows.Forms.TextBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeFrame = new System.Windows.Forms.TextBox();
            this.chkUseLocalTime = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.btnOpenOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(70, 10);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(210, 20);
            this.txtClientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Secret:";
            // 
            // txtAPISecret
            // 
            this.txtAPISecret.Location = new System.Drawing.Point(70, 55);
            this.txtAPISecret.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPISecret.Name = "txtAPISecret";
            this.txtAPISecret.Size = new System.Drawing.Size(210, 20);
            this.txtAPISecret.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Key:";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(70, 32);
            this.txtAPIKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(210, 20);
            this.txtAPIKey.TabIndex = 4;
            // 
            // btnGetAccountBalance
            // 
            this.btnGetAccountBalance.Location = new System.Drawing.Point(70, 88);
            this.btnGetAccountBalance.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAccountBalance.Name = "btnGetAccountBalance";
            this.btnGetAccountBalance.Size = new System.Drawing.Size(142, 25);
            this.btnGetAccountBalance.TabIndex = 6;
            this.btnGetAccountBalance.Text = "Account Balance";
            this.btnGetAccountBalance.UseVisualStyleBackColor = true;
            this.btnGetAccountBalance.Click += new System.EventHandler(this.btnGetAccountBalance_Click);
            // 
            // btnUserTransactions
            // 
            this.btnUserTransactions.Location = new System.Drawing.Point(70, 121);
            this.btnUserTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserTransactions.Name = "btnUserTransactions";
            this.btnUserTransactions.Size = new System.Drawing.Size(142, 71);
            this.btnUserTransactions.TabIndex = 7;
            this.btnUserTransactions.Text = "User Transactions";
            this.btnUserTransactions.UseVisualStyleBackColor = true;
            this.btnUserTransactions.Click += new System.EventHandler(this.btnUserTransactions_Click);
            // 
            // btnCurrentTradingInfo
            // 
            this.btnCurrentTradingInfo.Location = new System.Drawing.Point(489, 87);
            this.btnCurrentTradingInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCurrentTradingInfo.Name = "btnCurrentTradingInfo";
            this.btnCurrentTradingInfo.Size = new System.Drawing.Size(198, 25);
            this.btnCurrentTradingInfo.TabIndex = 8;
            this.btnCurrentTradingInfo.Text = "Current Trading Information";
            this.btnCurrentTradingInfo.UseVisualStyleBackColor = true;
            this.btnCurrentTradingInfo.Click += new System.EventHandler(this.btnCurrentTradingInfo_Click);
            // 
            // btnOrderBook
            // 
            this.btnOrderBook.Location = new System.Drawing.Point(489, 120);
            this.btnOrderBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderBook.Name = "btnOrderBook";
            this.btnOrderBook.Size = new System.Drawing.Size(198, 25);
            this.btnOrderBook.TabIndex = 9;
            this.btnOrderBook.Text = "Order Book";
            this.btnOrderBook.UseVisualStyleBackColor = true;
            this.btnOrderBook.Click += new System.EventHandler(this.btnOrderBook_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(489, 149);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(198, 25);
            this.btnTransactions.TabIndex = 10;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order Book:";
            // 
            // txtOrderBook
            // 
            this.txtOrderBook.Location = new System.Drawing.Point(489, 9);
            this.txtOrderBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderBook.Name = "txtOrderBook";
            this.txtOrderBook.Size = new System.Drawing.Size(210, 20);
            this.txtOrderBook.TabIndex = 11;
            this.txtOrderBook.Text = "btc_cad";
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Checked = true;
            this.chkGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroup.Location = new System.Drawing.Point(729, 124);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(168, 19);
            this.chkGroup.TabIndex = 13;
            this.chkGroup.Text = "Group Order Book Orders";
            this.chkGroup.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Timeframe:";
            // 
            // txtTimeFrame
            // 
            this.txtTimeFrame.Location = new System.Drawing.Point(793, 152);
            this.txtTimeFrame.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeFrame.Name = "txtTimeFrame";
            this.txtTimeFrame.Size = new System.Drawing.Size(113, 20);
            this.txtTimeFrame.TabIndex = 14;
            this.txtTimeFrame.Text = "hour";
            // 
            // chkUseLocalTime
            // 
            this.chkUseLocalTime.AutoSize = true;
            this.chkUseLocalTime.Checked = true;
            this.chkUseLocalTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseLocalTime.Location = new System.Drawing.Point(489, 34);
            this.chkUseLocalTime.Name = "chkUseLocalTime";
            this.chkUseLocalTime.Size = new System.Drawing.Size(164, 19);
            this.chkUseLocalTime.TabIndex = 16;
            this.chkUseLocalTime.Text = "Use Local Time (vs UTC)";
            this.chkUseLocalTime.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "offset:";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(298, 124);
            this.txtOffset.Margin = new System.Windows.Forms.Padding(2);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(113, 20);
            this.txtOffset.TabIndex = 17;
            this.txtOffset.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "limit:";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(298, 148);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(113, 20);
            this.txtLimit.TabIndex = 19;
            this.txtLimit.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "sort:";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(298, 172);
            this.txtSort.Margin = new System.Windows.Forms.Padding(2);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(113, 20);
            this.txtSort.TabIndex = 21;
            this.txtSort.Text = "desc";
            // 
            // btnOpenOrders
            // 
            this.btnOpenOrders.Location = new System.Drawing.Point(70, 207);
            this.btnOpenOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenOrders.Name = "btnOpenOrders";
            this.btnOpenOrders.Size = new System.Drawing.Size(142, 25);
            this.btnOpenOrders.TabIndex = 23;
            this.btnOpenOrders.Text = "Open Orders";
            this.btnOpenOrders.UseVisualStyleBackColor = true;
            this.btnOpenOrders.Click += new System.EventHandler(this.btnOpenOrders_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 407);
            this.Controls.Add(this.btnOpenOrders);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.chkUseLocalTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimeFrame);
            this.Controls.Add(this.chkGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderBook);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnOrderBook);
            this.Controls.Add(this.btnCurrentTradingInfo);
            this.Controls.Add(this.btnUserTransactions);
            this.Controls.Add(this.btnGetAccountBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAPISecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "QuadrigaCX API Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAPISecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Button btnGetAccountBalance;
        private System.Windows.Forms.Button btnUserTransactions;
        private System.Windows.Forms.Button btnCurrentTradingInfo;
        private System.Windows.Forms.Button btnOrderBook;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderBook;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeFrame;
        private System.Windows.Forms.CheckBox chkUseLocalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Button btnOpenOrders;
    }
}

