<h1>Inventory Management System</h1>

The Inventory Management System is a Windows Forms application developed in C# that allows users to manage and track inventory items, including purchases and sales. The application interacts with a MySQL database to perform various operations such as adding, editing, deleting, and retrieving data. The system provides functionality to calculate inventory statistics and profit margins, and it offers alerts for low stock items.

<h2>Features</h2>
<p>-Add Items: Add new purchases or sales to the database with details like name, description, category, quantity, price, and date.

-Asynchronous Database Operations: All database operations are performed asynchronously, ensuring a responsive UI.

-Edit Items: Update existing item details in the database.

-Delete Items: Remove items from the database.

-Stock Management: Track inventory stock levels and provide warnings for low stock items.

-Sales Management: Manage sales and ensure sufficient stock levels before processing.

-Statistics: Calculate inventory statistics and profit margins.

-Search: Search for items in the database by name.</p>
  
<h2><b>Installation</b></h2>


<b>Clone the Repository:</b>

<h3><p>git clone https://github.com/02scanks/inventory-management-software.git</p></h3>

<h2>Technologies Used</h2>

<p>-C#

-Windows Forms

-MySQL

-MySQL.Data.MySqlClient

-Asynchronous Programming (async/await)</p>


<h2>DATABASE SETUP</h2>

<h3>Set Up MySQL Database</h3>
Create a MySQL database with 2 tables called "purchases" and "sales" and then configure the connection string in the App.config file


<h2>Heres the SQL Commands For The 2 Tables:</h2>

CREATE TABLE sales (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    category VARCHAR(50),
    quantity INT,
    price FLOAT,
    itemDate DATE,
    UNIQUE(name)
);


CREATE TABLE purchases (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT,
    category VARCHAR(50),
    quantity INT,
    price FLOAT,
    itemDate DATE,
    UNIQUE(name)
);

<h2>String Example</h2>
name="DbConnectionString" connectionString="server=yourserver;database=yourdatabase;user=youruser;password=yourpassword;" providerName="MySql.Data.MySqlClient"

    
<h3>Install Dependencies</h3>
Ensure you have MySQL Connector installed for .NET.
And MySql.Data from the Nuget Manager
<h3>Run the Application</h3>
Open the project in Visual Studio and run the application.

<h2>Contributing</h2>
Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure your code follows the existing coding standards and include relevant tests for new features.

License
This project is licensed under the MIT License - see the LICENSE file for details.
