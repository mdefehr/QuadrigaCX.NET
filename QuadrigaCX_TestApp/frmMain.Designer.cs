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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSellLimit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.btnLookupOrder = new System.Windows.Forms.Button();
            this.btnBuyLimit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(93, 12);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(279, 22);
            this.txtClientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Secret:";
            // 
            // txtAPISecret
            // 
            this.txtAPISecret.Location = new System.Drawing.Point(93, 68);
            this.txtAPISecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAPISecret.Name = "txtAPISecret";
            this.txtAPISecret.Size = new System.Drawing.Size(279, 22);
            this.txtAPISecret.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "API Key:";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(93, 39);
            this.txtAPIKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(279, 22);
            this.txtAPIKey.TabIndex = 4;
            // 
            // btnGetAccountBalance
            // 
            this.btnGetAccountBalance.Location = new System.Drawing.Point(93, 108);
            this.btnGetAccountBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetAccountBalance.Name = "btnGetAccountBalance";
            this.btnGetAccountBalance.Size = new System.Drawing.Size(221, 31);
            this.btnGetAccountBalance.TabIndex = 6;
            this.btnGetAccountBalance.Text = "Account Balance";
            this.btnGetAccountBalance.UseVisualStyleBackColor = true;
            this.btnGetAccountBalance.Click += new System.EventHandler(this.btnGetAccountBalance_Click);
            // 
            // btnUserTransactions
            // 
            this.btnUserTransactions.Location = new System.Drawing.Point(93, 149);
            this.btnUserTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserTransactions.Name = "btnUserTransactions";
            this.btnUserTransactions.Size = new System.Drawing.Size(221, 87);
            this.btnUserTransactions.TabIndex = 7;
            this.btnUserTransactions.Text = "User Transactions";
            this.btnUserTransactions.UseVisualStyleBackColor = true;
            this.btnUserTransactions.Click += new System.EventHandler(this.btnUserTransactions_Click);
            // 
            // btnCurrentTradingInfo
            // 
            this.btnCurrentTradingInfo.Location = new System.Drawing.Point(652, 107);
            this.btnCurrentTradingInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrentTradingInfo.Name = "btnCurrentTradingInfo";
            this.btnCurrentTradingInfo.Size = new System.Drawing.Size(264, 31);
            this.btnCurrentTradingInfo.TabIndex = 8;
            this.btnCurrentTradingInfo.Text = "Current Trading Information";
            this.btnCurrentTradingInfo.UseVisualStyleBackColor = true;
            this.btnCurrentTradingInfo.Click += new System.EventHandler(this.btnCurrentTradingInfo_Click);
            // 
            // btnOrderBook
            // 
            this.btnOrderBook.Location = new System.Drawing.Point(652, 148);
            this.btnOrderBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderBook.Name = "btnOrderBook";
            this.btnOrderBook.Size = new System.Drawing.Size(264, 31);
            this.btnOrderBook.TabIndex = 9;
            this.btnOrderBook.Text = "Order Book";
            this.btnOrderBook.UseVisualStyleBackColor = true;
            this.btnOrderBook.Click += new System.EventHandler(this.btnOrderBook_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(652, 183);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(264, 31);
            this.btnTransactions.TabIndex = 10;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order Book:";
            // 
            // txtOrderBook
            // 
            this.txtOrderBook.Location = new System.Drawing.Point(652, 11);
            this.txtOrderBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderBook.Name = "txtOrderBook";
            this.txtOrderBook.Size = new System.Drawing.Size(279, 22);
            this.txtOrderBook.TabIndex = 11;
            this.txtOrderBook.Text = "btc_cad";
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Checked = true;
            this.chkGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroup.Location = new System.Drawing.Point(972, 153);
            this.chkGroup.Margin = new System.Windows.Forms.Padding(4);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(195, 21);
            this.chkGroup.TabIndex = 13;
            this.chkGroup.Text = "Group Order Book Orders";
            this.chkGroup.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(956, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Timeframe:";
            // 
            // txtTimeFrame
            // 
            this.txtTimeFrame.Location = new System.Drawing.Point(1057, 187);
            this.txtTimeFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimeFrame.Name = "txtTimeFrame";
            this.txtTimeFrame.Size = new System.Drawing.Size(149, 22);
            this.txtTimeFrame.TabIndex = 14;
            this.txtTimeFrame.Text = "hour";
            // 
            // chkUseLocalTime
            // 
            this.chkUseLocalTime.AutoSize = true;
            this.chkUseLocalTime.Checked = true;
            this.chkUseLocalTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseLocalTime.Location = new System.Drawing.Point(652, 42);
            this.chkUseLocalTime.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseLocalTime.Name = "chkUseLocalTime";
            this.chkUseLocalTime.Size = new System.Drawing.Size(188, 21);
            this.chkUseLocalTime.TabIndex = 16;
            this.chkUseLocalTime.Text = "Use Local Time (vs UTC)";
            this.chkUseLocalTime.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "offset:";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(435, 157);
            this.txtOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(149, 22);
            this.txtOffset.TabIndex = 17;
            this.txtOffset.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "limit:";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(435, 186);
            this.txtLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(149, 22);
            this.txtLimit.TabIndex = 19;
            this.txtLimit.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "sort:";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(435, 216);
            this.txtSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(149, 22);
            this.txtSort.TabIndex = 21;
            this.txtSort.Text = "desc";
            // 
            // btnOpenOrders
            // 
            this.btnOpenOrders.Location = new System.Drawing.Point(93, 255);
            this.btnOpenOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenOrders.Name = "btnOpenOrders";
            this.btnOpenOrders.Size = new System.Drawing.Size(221, 31);
            this.btnOpenOrders.TabIndex = 23;
            this.btnOpenOrders.Text = "Open Orders";
            this.btnOpenOrders.UseVisualStyleBackColor = true;
            this.btnOpenOrders.Click += new System.EventHandler(this.btnOpenOrders_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "order id:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(435, 305);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(149, 22);
            this.txtOrderID.TabIndex = 25;
            // 
            // btnSellLimit
            // 
            this.btnSellLimit.Location = new System.Drawing.Point(212, 346);
            this.btnSellLimit.Name = "btnSellLimit";
            this.btnSellLimit.Size = new System.Drawing.Size(102, 51);
            this.btnSellLimit.TabIndex = 27;
            this.btnSellLimit.Text = "Sell Order (Limit)";
            this.btnSellLimit.UseVisualStyleBackColor = true;
            this.btnSellLimit.Click += new System.EventHandler(this.btnSellLimit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "amount:";
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(435, 346);
            this.txtOrderAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(149, 22);
            this.txtOrderAmount.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "price:";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(435, 372);
            this.txtOrderPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(149, 22);
            this.txtOrderPrice.TabIndex = 30;
            // 
            // btnLookupOrder
            // 
            this.btnLookupOrder.Location = new System.Drawing.Point(93, 300);
            this.btnLookupOrder.Name = "btnLookupOrder";
            this.btnLookupOrder.Size = new System.Drawing.Size(113, 32);
            this.btnLookupOrder.TabIndex = 32;
            this.btnLookupOrder.Text = "Lookup Order";
            this.btnLookupOrder.UseVisualStyleBackColor = true;
            this.btnLookupOrder.Click += new System.EventHandler(this.btnLookupOrder_Click);
            // 
            // btnBuyLimit
            // 
            this.btnBuyLimit.Location = new System.Drawing.Point(93, 346);
            this.btnBuyLimit.Name = "btnBuyLimit";
            this.btnBuyLimit.Size = new System.Drawing.Size(113, 51);
            this.btnBuyLimit.TabIndex = 33;
            this.btnBuyLimit.Text = "Buy Order (Limit)";
            this.btnBuyLimit.UseVisualStyleBackColor = true;
            this.btnBuyLimit.Click += new System.EventHandler(this.btnBuyLimit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 598);
            this.Controls.Add(this.btnBuyLimit);
            this.Controls.Add(this.btnLookupOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(this.btnSellLimit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnCancel);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSellLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.Button btnLookupOrder;
        private System.Windows.Forms.Button btnBuyLimit;
    }
}

