using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

public class Database
{
    private static string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

    private const string PURCHASE = "Purchase";
    private const string SALE = "Sale";

    #region Queries
    //Populate Data Table Querys
    public string saleOnlyQuery = "SELECT name, quantity, category, price, itemDate FROM sales WHERE category = @Sale";
    public string purchaseOnlyQuery = "SELECT name, quantity, category, price, itemDate FROM purchases WHERE category = @Purchase";
    public string showAllQuery = "SELECT name, quantity, category, price, itemDate FROM purchases UNION SELECT name, quantity, category, price, itemDate FROM sales";


    //Calculate Profit Querys
    public string purchaseTotalQuery = "SELECT price FROM purchases WHERE category = @Profit";
    public string saleTotalQuery = "SELECT price FROM sales WHERE category = @Sale";

    //Sale / Purchase Querys
    public string addSaleQuery = @"
        INSERT INTO sales (name, description, category, quantity, price, itemDate)
        VALUES (@name, @description, @category, @quantity, @price, @itemDate)
        ON DUPLICATE KEY UPDATE
            description = VALUES(description),
            category = VALUES(category),
            quantity = quantity + VALUES(quantity),
            price = VALUES(price),
            itemDate = VALUES(itemDate);";

    public string addPurchaseQuery = @"
        INSERT INTO purchases (name, description, category, quantity, price, itemDate)
        VALUES (@name, @description, @category, @quantity, @price, @itemDate)
        ON DUPLICATE KEY UPDATE
            description = VALUES(description),
            category = VALUES(category),
            quantity = quantity + VALUES(quantity),
            price = VALUES(price),
            itemDate = VALUES(itemDate);";

    //Edit Item Queries
    public string editPurchaseQuery = @"
                    UPDATE purchases 
                    SET name = @newName, category = @newCategory, quantity = @newQuantity, price = @newPrice, itemDate = @newDate
                    WHERE name = @oldName AND category = @oldCategory AND quantity = @oldQuantity AND price = @oldPrice AND itemDate = @oldDate";

    public string editSaleQuery = @"
                    UPDATE sales 
                    SET name = @newName, category = @newCategory, quantity = @newQuantity, price = @newPrice, itemDate = @newDate
                    WHERE name = @oldName AND category = @oldCategory AND quantity = @oldQuantity AND price = @oldPrice AND itemDate = @oldDate";

    //Delete Item Query
    public string deletePurchaseQuery = "DELETE FROM purchases where name = @name AND category = @category AND quantity = @quantity AND price = @price AND itemDate = @date";
    public string deleteSaleQuery = "DELETE FROM sales where name = @name AND category = @category AND quantity = @quantity AND price = @price AND itemDate = @date";

    #endregion

        public async Task AddItemAsync(string name, string desc, string category, int quantity, float price, DateTime date, string query)
    {
        //Set Cursor To Wait Cursor To Show User A Task Is Running
        Cursor.Current = Cursors.WaitCursor;

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@description", desc);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price * quantity);
                command.Parameters.AddWithValue("@itemDate", date);


                // Open connection asynchronously
                await connection.OpenAsync();

                //check if result is successful
                int result = await command.ExecuteNonQueryAsync();
                if (result > 0)
                {
                    MessageBox.Show("Item Added");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }

        Cursor.Current = Cursors.Default;
    }

    public async Task SubtractSaleItemAsync(string itemName, int saleQuantity) 
    {
        string updateStockQuery = "UPDATE purchases SET quantity = quantity - @amountToSubtract WHERE name = @name";
        string checkStockQuery = "SELECT quantity FROM purchases WHERE name = @name";

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING)) 
            {
                // Open connection asynchronously
                await connection.OpenAsync();

                //Check if stock is available 
                using (var checkCommand = new MySqlCommand(checkStockQuery, connection)) 
                {
                    checkCommand.Parameters.AddWithValue("@name", itemName);

                    // Check for stock value asynchronously
                    var currentStock = (int?) await checkCommand.ExecuteScalarAsync();
                    
                    //checking if current stock is real and has a value greater then the sale amount
                    if (currentStock.HasValue && currentStock.Value >= saleQuantity)
                    {
                        // Update stock amount
                        using (var updateStockCommand = new MySqlCommand(updateStockQuery, connection))
                        {
                            // Add values into query
                            updateStockCommand.Parameters.AddWithValue("@amountToSubtract", saleQuantity);
                            updateStockCommand.Parameters.AddWithValue("@name", itemName);


                            //execute command
                            await updateStockCommand.ExecuteNonQueryAsync();

                        }
                    }
                    else 
                    {
                        MessageBox.Show("Error: Sale Quantity Is Greater Than Available Stock");
                    }

                }
            }
            
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }
    }

    public async Task PopulateStockListAsync(DataGridView dataTable)
    {
        //Set Cursor To Wait Cursor To Show User A Task Is Running
        Cursor.Current = Cursors.WaitCursor;

        List<string> lowQuantityItems = new List<string>();

        string query = "SELECT name, quantity FROM purchases WHERE category = @Purchase";

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@Purchase", PURCHASE);


                // Open connection asynchronously
                await connection.OpenAsync();

                //read data from db asynchronously
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));

                        // check if item quantity is low and if it is add to list
                        if (quantity < 50)
                        {
                            lowQuantityItems.Add(name);
                        }

                        //Append data to data grid table
                        dataTable.Rows.Add(name, quantity);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }

        // if there is stock that are running low then user will be warned upon start
        if (lowQuantityItems.Count > 0)
        {
            foreach (string item in lowQuantityItems)
            {
                MessageBox.Show($"STOCK QUANTITY WARNING\n{item} count is below 50 units");
            }

        }

        Cursor.Current = Cursors.Default;
    }

    public async Task PopulateSaleListAsync(DataGridView dataTable, string query)
    {
        //Set Cursor To Wait Cursor To Show User A Task Is Running
        Cursor.Current = Cursors.WaitCursor;

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@Sale", SALE);
                command.Parameters.AddWithValue("@Purchase", PURCHASE);


                // Open connection asynchronously
                await connection.OpenAsync();

                //read data from db asynchronously
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        string category = reader.GetString(reader.GetOrdinal("category"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                        float price = reader.GetFloat(reader.GetOrdinal("price"));
                        DateTime date = reader.GetDateTime(reader.GetOrdinal("itemDate"));

                        dataTable.Rows.Add(name, category, quantity, price, date);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }

        Cursor.Current = Cursors.Default;
    }

    public async Task<int[]> CalculateInventoryStatsAsync() 
    {
        int[] stats = new int[2];

        string query = "SELECT name, quantity FROM purchases WHERE category = @category";

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@category", PURCHASE);


                // Open connection asynchronously
                await connection.OpenAsync();

                //read data from db asynchronously
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));

                        stats[0]++;
                        stats[1] += quantity;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }

        return stats;
    }

    public async Task<float> CalculateProfitStatsAsync(string query)
    {
        float total = 0; 

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@Profit", PURCHASE);
                command.Parameters.AddWithValue("@Sale", SALE);

                // Open connection asynchronously
                await connection.OpenAsync();

                //read data from db asynchronously
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        float price = reader.GetFloat(reader.GetOrdinal("price"));
                        
                        total += price;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.Message}");
        }

        return total;
    }

    public async Task SearchAsync(string itemName, DataGridView dataTable) 
    {
        string query = @"SELECT name, category, quantity, price, itemDate FROM purchases WHERE name LIKE @name
                        UNION
                        SELECT name, category, quantity, price, itemDate FROM sales WHERE name LIKE @name";

        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // Add values into query
                command.Parameters.AddWithValue("@name", "%" + itemName + "%");

                // Open connection asynchronously
                await connection.OpenAsync();

                //read data from db asynchronously
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        // Get Data from reader
                        string name = reader.GetString(reader.GetOrdinal("name"));
                        string category = reader.GetString(reader.GetOrdinal("category"));
                        int quantity = reader.GetInt32(reader.GetOrdinal("quantity"));
                        float price = reader.GetFloat(reader.GetOrdinal("price"));
                        DateTime date = reader.GetDateTime(reader.GetOrdinal("itemDate"));

                        //add data to table
                        dataTable.Rows.Add(name, category, quantity, price, date);
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show(ex.Message);
        }
        
    }

    public async Task EditDataAsync(string query, string newName, string newCategory, int newQuantity, float newPrice, DateTime newDate,
                         string oldName, string oldCategory, int oldQuantity, float oldPrice, DateTime oldDate) 
    {
        
        try
        {
            using(var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                // New Values
                command.Parameters.AddWithValue("@newName", newName);
                command.Parameters.AddWithValue("@newCategory", newCategory);
                command.Parameters.AddWithValue("@newQuantity", newQuantity);
                command.Parameters.AddWithValue("@newPrice", newPrice * newQuantity);
                command.Parameters.AddWithValue("@newDate", newDate);

                // Old Values
                command.Parameters.AddWithValue("@oldName", oldName);
                command.Parameters.AddWithValue("@oldCategory", oldCategory);
                command.Parameters.AddWithValue("@oldQuantity", oldQuantity);
                command.Parameters.AddWithValue("@oldPrice", oldPrice);
                command.Parameters.AddWithValue("@oldDate", oldDate);

                //Open Connection asynchronously
                await connection.OpenAsync();

                int result = await command.ExecuteNonQueryAsync();
                if (result > 0) 
                {
                    MessageBox.Show("Data Successfully Edited");
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    public async Task DeleteRow(string query, string name, string category, int quantity, float price, DateTime date) 
    {
        try
        {
            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            using (var command = new MySqlCommand(query, connection))
            {
                //Open the connection asynchronously
                await connection.OpenAsync();

                //Add command parameters
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@date", date);

                //Execute command asynchronously and inform user of success
                int result = await command.ExecuteNonQueryAsync();
                if (result > 0) 
                {
                    MessageBox.Show("Data Deleted");
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
        
    }
}
}