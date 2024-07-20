namespace InventoryManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.productNameCombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showFilterBtn = new System.Windows.Forms.Button();
            this.saleOnlyRadio = new System.Windows.Forms.RadioButton();
            this.purchaseOnlyRadio = new System.Windows.Forms.RadioButton();
            this.showAllRadio = new System.Windows.Forms.RadioButton();
            this.InvQuantityPanel = new System.Windows.Forms.Panel();
            this.inventoryQuantity = new System.Windows.Forms.Label();
            this.invPanel = new System.Windows.Forms.Panel();
            this.inventoryAmount = new System.Windows.Forms.Label();
            this.purchasePanel = new System.Windows.Forms.Panel();
            this.totalPurchases = new System.Windows.Forms.Label();
            this.salePanel = new System.Windows.Forms.Panel();
            this.totalSales = new System.Windows.Forms.Label();
            this.profitPanel = new System.Windows.Forms.Panel();
            this.totalProfit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.availableStocksGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InvQuantityPanel.SuspendLayout();
            this.invPanel.SuspendLayout();
            this.purchasePanel.SuspendLayout();
            this.salePanel.SuspendLayout();
            this.profitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableStocksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(237, 12);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(382, 36);
            this.searchBox.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(122, 12);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(104, 39);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 12);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(104, 39);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(625, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(90, 39);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.addItemBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.quantityBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.categoryCombo);
            this.panel1.Controls.Add(this.productNameCombo);
            this.panel1.Location = new System.Drawing.Point(237, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 184);
            this.panel1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Description:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(25, 73);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(209, 53);
            this.descriptionBox.TabIndex = 22;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(436, 29);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(92, 140);
            this.addItemBtn.TabIndex = 21;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date:";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(25, 149);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(209, 20);
            this.dateBox.TabIndex = 19;
            this.dateBox.Value = new System.DateTime(2024, 7, 18, 8, 21, 43, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price Per Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity:";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(259, 93);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(170, 20);
            this.priceBox.TabIndex = 16;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(259, 29);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(170, 20);
            this.quantityBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transaction Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name:";
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Purchase",
            "Sale"});
            this.categoryCombo.Location = new System.Drawing.Point(259, 148);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(170, 21);
            this.categoryCombo.TabIndex = 12;
            // 
            // productNameCombo
            // 
            this.productNameCombo.FormattingEnabled = true;
            this.productNameCombo.Items.AddRange(new object[] {
            "EcoClean Detergent",
            "FreshBreeze Air Freshener",
            "PureGlow Skincare Lotion",
            "TechFusion Wireless Charger",
            "AquaFlow Water Bottle",
            "CozyNest Blanket",
            "UrbanChic Backpack",
            "GreenLeaf Herbal Tea",
            "PowerMax Energy Bar",
            "SwiftMove Running Shoes",
            "NutriBoost Protein Shake",
            "SmartHome Thermostat",
            "BrightView LED Lamp"});
            this.productNameCombo.Location = new System.Drawing.Point(25, 29);
            this.productNameCombo.Name = "productNameCombo";
            this.productNameCombo.Size = new System.Drawing.Size(209, 21);
            this.productNameCombo.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.showFilterBtn);
            this.panel2.Controls.Add(this.saleOnlyRadio);
            this.panel2.Controls.Add(this.purchaseOnlyRadio);
            this.panel2.Controls.Add(this.showAllRadio);
            this.panel2.Location = new System.Drawing.Point(237, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 52);
            this.panel2.TabIndex = 7;
            // 
            // showFilterBtn
            // 
            this.showFilterBtn.Location = new System.Drawing.Point(453, 15);
            this.showFilterBtn.Name = "showFilterBtn";
            this.showFilterBtn.Size = new System.Drawing.Size(75, 23);
            this.showFilterBtn.TabIndex = 3;
            this.showFilterBtn.Text = "Show";
            this.showFilterBtn.UseVisualStyleBackColor = true;
            this.showFilterBtn.Click += new System.EventHandler(this.showFilterBtn_Click);
            // 
            // saleOnlyRadio
            // 
            this.saleOnlyRadio.AutoSize = true;
            this.saleOnlyRadio.Checked = true;
            this.saleOnlyRadio.Location = new System.Drawing.Point(332, 18);
            this.saleOnlyRadio.Name = "saleOnlyRadio";
            this.saleOnlyRadio.Size = new System.Drawing.Size(70, 17);
            this.saleOnlyRadio.TabIndex = 2;
            this.saleOnlyRadio.TabStop = true;
            this.saleOnlyRadio.Text = "Sale Only";
            this.saleOnlyRadio.UseVisualStyleBackColor = true;
            // 
            // purchaseOnlyRadio
            // 
            this.purchaseOnlyRadio.AutoSize = true;
            this.purchaseOnlyRadio.Location = new System.Drawing.Point(174, 18);
            this.purchaseOnlyRadio.Name = "purchaseOnlyRadio";
            this.purchaseOnlyRadio.Size = new System.Drawing.Size(94, 17);
            this.purchaseOnlyRadio.TabIndex = 1;
            this.purchaseOnlyRadio.TabStop = true;
            this.purchaseOnlyRadio.Text = "Purchase Only";
            this.purchaseOnlyRadio.UseVisualStyleBackColor = true;
            // 
            // showAllRadio
            // 
            this.showAllRadio.AutoSize = true;
            this.showAllRadio.Location = new System.Drawing.Point(22, 18);
            this.showAllRadio.Name = "showAllRadio";
            this.showAllRadio.Size = new System.Drawing.Size(66, 17);
            this.showAllRadio.TabIndex = 0;
            this.showAllRadio.Text = "Show All";
            this.showAllRadio.UseVisualStyleBackColor = true;
            // 
            // InvQuantityPanel
            // 
            this.InvQuantityPanel.BackColor = System.Drawing.SystemColors.Control;
            this.InvQuantityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvQuantityPanel.Controls.Add(this.inventoryQuantity);
            this.InvQuantityPanel.Location = new System.Drawing.Point(12, 72);
            this.InvQuantityPanel.Name = "InvQuantityPanel";
            this.InvQuantityPanel.Size = new System.Drawing.Size(134, 81);
            this.InvQuantityPanel.TabIndex = 9;
            // 
            // inventoryQuantity
            // 
            this.inventoryQuantity.AutoSize = true;
            this.inventoryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryQuantity.Location = new System.Drawing.Point(56, 31);
            this.inventoryQuantity.Name = "inventoryQuantity";
            this.inventoryQuantity.Size = new System.Drawing.Size(15, 16);
            this.inventoryQuantity.TabIndex = 26;
            this.inventoryQuantity.Text = "0";
            this.inventoryQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invPanel
            // 
            this.invPanel.BackColor = System.Drawing.SystemColors.Control;
            this.invPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invPanel.Controls.Add(this.inventoryAmount);
            this.invPanel.Location = new System.Drawing.Point(168, 72);
            this.invPanel.Name = "invPanel";
            this.invPanel.Size = new System.Drawing.Size(134, 81);
            this.invPanel.TabIndex = 10;
            // 
            // inventoryAmount
            // 
            this.inventoryAmount.AutoSize = true;
            this.inventoryAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAmount.Location = new System.Drawing.Point(53, 31);
            this.inventoryAmount.Name = "inventoryAmount";
            this.inventoryAmount.Size = new System.Drawing.Size(15, 16);
            this.inventoryAmount.TabIndex = 27;
            this.inventoryAmount.Text = "0";
            this.inventoryAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchasePanel
            // 
            this.purchasePanel.BackColor = System.Drawing.SystemColors.Control;
            this.purchasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchasePanel.Controls.Add(this.totalPurchases);
            this.purchasePanel.Location = new System.Drawing.Point(325, 72);
            this.purchasePanel.Name = "purchasePanel";
            this.purchasePanel.Size = new System.Drawing.Size(134, 81);
            this.purchasePanel.TabIndex = 10;
            // 
            // totalPurchases
            // 
            this.totalPurchases.AutoSize = true;
            this.totalPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPurchases.Location = new System.Drawing.Point(51, 31);
            this.totalPurchases.Name = "totalPurchases";
            this.totalPurchases.Size = new System.Drawing.Size(35, 16);
            this.totalPurchases.TabIndex = 28;
            this.totalPurchases.Text = "$0.0";
            this.totalPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salePanel
            // 
            this.salePanel.BackColor = System.Drawing.SystemColors.Control;
            this.salePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePanel.Controls.Add(this.totalSales);
            this.salePanel.Location = new System.Drawing.Point(485, 72);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(134, 81);
            this.salePanel.TabIndex = 10;
            // 
            // totalSales
            // 
            this.totalSales.AutoSize = true;
            this.totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSales.Location = new System.Drawing.Point(50, 31);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(35, 16);
            this.totalSales.TabIndex = 29;
            this.totalSales.Text = "$0.0";
            this.totalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profitPanel
            // 
            this.profitPanel.BackColor = System.Drawing.SystemColors.Control;
            this.profitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitPanel.Controls.Add(this.totalProfit);
            this.profitPanel.Location = new System.Drawing.Point(646, 72);
            this.profitPanel.Name = "profitPanel";
            this.profitPanel.Size = new System.Drawing.Size(137, 81);
            this.profitPanel.TabIndex = 10;
            // 
            // totalProfit
            // 
            this.totalProfit.AutoSize = true;
            this.totalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProfit.Location = new System.Drawing.Point(55, 31);
            this.totalProfit.Name = "totalProfit";
            this.totalProfit.Size = new System.Drawing.Size(35, 16);
            this.totalProfit.TabIndex = 30;
            this.totalProfit.Text = "$0.0";
            this.totalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(667, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Add";
            // 
            // transactionGrid
            // 
            this.transactionGrid.AllowUserToAddRows = false;
            this.transactionGrid.AllowUserToDeleteRows = false;
            this.transactionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn,
            this.typeColumn,
            this.quantityColumn,
            this.priceColumn,
            this.dateColumn});
            this.transactionGrid.Location = new System.Drawing.Point(237, 368);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.ReadOnly = true;
            this.transactionGrid.Size = new System.Drawing.Size(546, 156);
            this.transactionGrid.TabIndex = 23;
            // 
            // productNameColumn
            // 
            this.productNameColumn.HeaderText = "Product Name";
            this.productNameColumn.Name = "productNameColumn";
            this.productNameColumn.ReadOnly = true;
            this.productNameColumn.Width = 190;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Width = 75;
            // 
            // quantityColumn
            // 
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            this.quantityColumn.ReadOnly = true;
            this.quantityColumn.Width = 75;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 75;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Inventory Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Inventory Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Purchase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sale";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(700, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Profit";
            // 
            // availableStocksGrid
            // 
            this.availableStocksGrid.AllowUserToAddRows = false;
            this.availableStocksGrid.AllowUserToDeleteRows = false;
            this.availableStocksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.availableStocksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableStocksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.availableStocks});
            this.availableStocksGrid.Location = new System.Drawing.Point(12, 178);
            this.availableStocksGrid.Name = "availableStocksGrid";
            this.availableStocksGrid.ReadOnly = true;
            this.availableStocksGrid.Size = new System.Drawing.Size(219, 404);
            this.availableStocksGrid.TabIndex = 25;
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 90;
            // 
            // availableStocks
            // 
            this.availableStocks.HeaderText = "Available Stocks";
            this.availableStocks.Name = "availableStocks";
            this.availableStocks.ReadOnly = true;
            this.availableStocks.Width = 90;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(721, 9);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(62, 39);
            this.refreshBtn.TabIndex = 26;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.availableStocksGrid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.profitPanel);
            this.Controls.Add(this.salePanel);
            this.Controls.Add(this.purchasePanel);
            this.Controls.Add(this.invPanel);
            this.Controls.Add(this.InvQuantityPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Inventory Manager Pro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.InvQuantityPanel.ResumeLayout(false);
            this.InvQuantityPanel.PerformLayout();
            this.invPanel.ResumeLayout(false);
            this.invPanel.PerformLayout();
            this.purchasePanel.ResumeLayout(false);
            this.purchasePanel.PerformLayout();
            this.salePanel.ResumeLayout(false);
            this.salePanel.PerformLayout();
            this.profitPanel.ResumeLayout(false);
            this.profitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableStocksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button showFilterBtn;
        private System.Windows.Forms.RadioButton saleOnlyRadio;
        private System.Windows.Forms.RadioButton purchaseOnlyRadio;
        private System.Windows.Forms.RadioButton showAllRadio;
        private System.Windows.Forms.Panel InvQuantityPanel;
        private System.Windows.Forms.Panel invPanel;
        private System.Windows.Forms.Panel purchasePanel;
        private System.Windows.Forms.Panel salePanel;
        private System.Windows.Forms.Panel profitPanel;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.ComboBox productNameCombo;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView transactionGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView availableStocksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableStocks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label inventoryQuantity;
        private System.Windows.Forms.Label inventoryAmount;
        private System.Windows.Forms.Label totalPurchases;
        private System.Windows.Forms.Label totalSales;
        private System.Windows.Forms.Label totalProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

