using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace InventoryManagementSystem
{
    public partial class Main : Form
    {
        Database db = new Database();

        public Main()
        {
            InitializeComponent();
            
            //Populate Stats and Data tables on Load
            StartAndRefresh();
        }

        #region Button Functions
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            // Create new item 
            Item item = new Item();


            try
            {
                // GET ALL ITEM DATA FROM RELATIVE FIELDS
                item.Name = productNameCombo.Text;
                item.Description = descriptionBox.Text;
                item.Category = categoryCombo.Text;

                if (!int.TryParse(quantityBox.Text, out int quantity))
                {
                    throw new InvalidOperationException("Invalid Quantity Value");
                }
                item.Quantity = quantity;

                if (!float.TryParse(priceBox.Text, out float price))
                {
                    throw new InvalidOperationException("Invalid Price Value");
                }
                item.Price = price;

                item.itemDate = dateBox.Value;

                if (categoryCombo.Text == "Purchase")
                {
                    // query database with purchase query
                    db.AddItemAsync(item.Name, item.Description, item.Category, item.Quantity, item.Price, item.itemDate, db.addPurchaseQuery);
                }
                else if (categoryCombo.Text == "Sale")
                {
                    // query database with sale query
                    db.AddItemAsync(item.Name, item.Description, item.Category, item.Quantity, item.Price, item.itemDate, db.addSaleQuery);

                    //Find item in stock list and subtract the sale quantity amount from available item stock quantity
                    db.SubtractSaleItemAsync(item.Name, item.Quantity);
                }
                
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void showFilterBtn_Click(object sender, EventArgs e)
        {
            transactionGrid.Rows.Clear();

            if (saleOnlyRadio.Checked)
            {
                db.PopulateSaleListAsync(transactionGrid, db.saleOnlyQuery);
            }
            else if (purchaseOnlyRadio.Checked)
            {
                db.PopulateSaleListAsync(transactionGrid, db.purchaseOnlyQuery);
            }
            else if (showAllRadio.Checked) 
            {
                db.PopulateSaleListAsync(transactionGrid, db.showAllQuery);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != string.Empty) 
            {
                // clear rows to avoid duplicating
                transactionGrid.Rows.Clear();
                db.SearchAsync(searchBox.Text, transactionGrid);
                searchBox.Text = string.Empty;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            StartAndRefresh();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // New Blank Data
            string newName = string.Empty;
            string newCategory = string.Empty;
            int newQuantity = 0;
            float newPrice = 0f;
            DateTime newDate = DateTime.Now;

            // Old Data
            string oldName = string.Empty;
            string oldCategory = string.Empty;
            int oldQuantity = 0;
            float oldPrice = 0f;
            DateTime oldDate = DateTime.Now;


            if (transactionGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select A Row To Edit First");
            }
            else 
            {
                try
                {
                    foreach (DataGridViewRow row in transactionGrid.SelectedRows)
                    {
                        if (row.Index == transactionGrid.NewRowIndex) continue;

                        //Get Variables From Data Cells
                        var nameCell = row.Cells[0];
                        var categoryCell = row.Cells[1];
                        var quantityCell = row.Cells[2];
                        var priceCell = row.Cells[3];
                        var dateCell = row.Cells[4];

                        //Check Validity Of Data & Assign Old and New Data To Variables
                        #region Check Variables For Proper Data Types
                        if (nameCell.Value != null)
                        {
                            newName = nameCell.Value.ToString();
                            oldName = newName;
                        }
                        else
                        {
                            MessageBox.Show("Name Cell Has Invalid DataType");
                        }

                        if (categoryCell.Value != null)
                        {
                            newCategory = categoryCell.Value.ToString();
                            oldCategory = newCategory;
                        }
                        else
                        {
                            MessageBox.Show("Category Cell Has Invalid DataType");
                        }

                        if (quantityCell.Value != null)
                        {
                            newQuantity = Convert.ToInt32(quantityCell.Value);
                            oldQuantity = newQuantity;
                        }
                        else
                        {
                            MessageBox.Show("Quantity Cell Has Invalid DataType");
                        }

                        if (priceCell.Value != null)
                        {
                            newPrice = Convert.ToSingle(priceCell.Value);
                            oldPrice = newPrice;
                        }
                        else
                        {
                            MessageBox.Show("Price Cell Has Invalid DataType");
                        }

                        if (dateCell.Value != null)
                        {
                            newDate = Convert.ToDateTime(dateCell.Value);
                            oldDate = newDate;
                        }
                        else
                        {
                            MessageBox.Show("Date Cell Has Invalid DataType");
                        }

                        #endregion

                        //Create Editable Form
                        newName = Interaction.InputBox("Change Product Name?", "Edit Data", newName);
                        newCategory = Interaction.InputBox("Change Product Category?", "Edit Data", newCategory);
                        newQuantity = Convert.ToInt32(Interaction.InputBox("Change Product Quantity?", "Edit Data", newQuantity.ToString()));
                        newPrice = Convert.ToSingle(Interaction.InputBox("Change Product Price Per Unit?", "Edit Data", (oldPrice / oldQuantity).ToString()));
                        newDate = Convert.ToDateTime(Interaction.InputBox("Change Product Date?", "Edit Data", newDate.ToString()));


                        //Query Database
                        if (newCategory == "Purchase")
                        {
                            db.EditDataAsync(db.editPurchaseQuery, newName, newCategory, newQuantity, newPrice,
                                        newDate, oldName, oldCategory, oldQuantity, oldPrice, oldDate);
                        }
                        else if (newCategory == "Sale")
                        {
                            db.EditDataAsync(db.editSaleQuery, newName, newCategory, newQuantity, newPrice,
                                        newDate, oldName, oldCategory, oldQuantity, oldPrice, oldDate);
                        }
                        else 
                        {
                            MessageBox.Show("Error: Category Must Contain 'Purchase' or 'Sale'");
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Blank Variables To Store The Data We Want To Delete
            string itemName = string.Empty;
            string itemCategory = string.Empty;
            int itemQuantity = 0;
            float itemPrice = 0f;
            DateTime itemDate = DateTime.Now;

            // Check if a row is selected and inform user if there is none selected
            if (transactionGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please Select A Row To Delete First");
            }
            else 
            {
                try
                {
                    foreach (DataGridViewRow row in transactionGrid.SelectedRows)
                    {
                        if (row.Index == transactionGrid.NewRowIndex) continue;

                        //get variables from cells
                        var name = row.Cells[0];
                        var category = row.Cells[1];
                        var quantity = row.Cells[2];
                        var price = row.Cells[3];
                        var date = row.Cells[4];

                        try
                        {
                            if (name.Value != null) itemName = name.Value.ToString();
                            if (category.Value != null) itemCategory = category.Value.ToString();
                            if (quantity.Value != null) itemQuantity = Convert.ToInt32(quantity.Value);
                            if (price.Value != null) itemPrice = Convert.ToSingle(price.Value);
                            if (date.Value != null) itemDate = Convert.ToDateTime(date.Value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error When Selecting Data: {ex.Message}");
                        }
                        
                    }

                    string confirmDeletion = Interaction.InputBox("Are You Sure You Want To Delete This Data?\nType Y To Confirm or N To Cancel", "Delete Data", "");
                    if (confirmDeletion != null) 
                    {
                        if (confirmDeletion.ToLower() == "y") 
                        {
                            if (itemCategory == "Sale")
                            {
                                db.DeleteRow(db.deleteSaleQuery, itemName, itemCategory, itemQuantity, itemPrice, itemDate);
                            }
                            else if (itemCategory == "Purchase")
                            {
                                db.DeleteRow(db.deletePurchaseQuery, itemName, itemCategory, itemQuantity, itemPrice, itemDate);
                            }
                        }
                    } 

                    
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        #endregion


        public async Task CalculateStockStats()
        {
            //Get stock list stats for inventory amount and quantity
            int[] stocklistStats = await db.CalculateInventoryStatsAsync();

            //Assign them to text counterparts
            inventoryQuantity.Text = stocklistStats[0].ToString();
            inventoryAmount.Text = stocklistStats[1].ToString();

            // Get stocklist stats for purchase total, sales total and profit total
            float saleTotal = await db.CalculateProfitStatsAsync(db.saleTotalQuery);
            float purchaseTotal = await db.CalculateProfitStatsAsync(db.purchaseTotalQuery);

            //Assign them to text counterparts
            totalSales.Text = $"${saleTotal.ToString()}";
            totalPurchases.Text = $"${purchaseTotal.ToString()}";
            totalProfit.Text = $"${(saleTotal - purchaseTotal)}";

            //Change background color of profit panel to match the current status of profit
            if ((saleTotal - purchaseTotal) < 0)
            {
                profitPanel.BackColor = Color.LightCoral;
            }
            else 
            {
                profitPanel.BackColor = Color.PaleGreen;
            }
        }

        public void StartAndRefresh() 
        {
            //reset radio button
            saleOnlyRadio.Checked = true;

            //clear lists before populating
            availableStocksGrid.Rows.Clear();
            transactionGrid.Rows.Clear();

            //Populate Data tables
            db.PopulateStockListAsync(availableStocksGrid);
            db.PopulateSaleListAsync(transactionGrid, db.saleOnlyQuery);

            //Get stock list stats
            CalculateStockStats();
        }

        
    }
}
