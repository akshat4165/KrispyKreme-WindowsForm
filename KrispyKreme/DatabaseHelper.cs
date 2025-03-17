using System;
using MySql.Data.MySqlClient;

namespace KrispyKreme
{
    public static class DatabaseHelper
    {
        // Connection string (modify according to your MySQL setup)
        private static readonly string connectionString = "server=localhost;database=krispykreme;uid=root;pwd=1234;Charset=utf8mb4;";

        /// <summary>
        /// Validates user credentials against the database.
        /// </summary>
        public static bool ValidateUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    bool isValid = result != null && result.ToString() == password; // Hash password in real app

                    if (isValid)
                    {
                        // If user is valid, check and create their bill table if not exists
                        CreateBillTableForUser(username, conn);
                    }

                    return isValid;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error (ValidateUser): " + ex.Message);
                    return false;
                }
            }
        }

        public static void UpdateBillDetails(string username, int billID, string billDetails)
        {
            string tableName = $"bills_{username}";
            string query = $"UPDATE `{tableName}` SET items = @billDetails WHERE id = @billID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@billDetails", billDetails);
                        cmd.Parameters.AddWithValue("@billID", billID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error (UpdateBillDetails): " + ex.Message);
                }
            }
        }

        public static bool IsBillAlreadySaved(string username, int billID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM `bills_{username}` WHERE id = @billID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@billID", billID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;  // Returns true if bill exists
                }
            }
        }


        private static void CreateBillTableForUser(string username, MySqlConnection conn)
        {
            try
            {
                string tableName = $"bills_{username}";

                string query = $@"
            CREATE TABLE IF NOT EXISTS `{tableName}` (
                id INT AUTO_INCREMENT PRIMARY KEY,
                customer_name VARCHAR(255),
                phone_number VARCHAR(20),
                items TEXT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
                total_price DECIMAL(10,2),
                discount DECIMAL(10,2),
                final_price DECIMAL(10,2),
                created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            )CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error (CreateBillTableForUser): " + ex.Message);
            }
        }


        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        public static bool AddUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Hash in real app

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error (AddUser): " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Fetches the latest bill ID from the database.
        /// </summary>
        public static int GetLatestBillID(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string tableName = $"bills_{username}";

                    string query = $"SELECT MAX(id) FROM `{tableName}`";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    return (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error (GetLatestBillID): " + ex.Message);
                    return 0;
                }
            }
        }

        public static void DeleteLatestBill(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Find the latest bill ID for the user
                string getLatestBillQuery = $"SELECT MAX(id) FROM bills_{username}";
                MySqlCommand getCmd = new MySqlCommand(getLatestBillQuery, conn);
                object result = getCmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    int latestBillID = Convert.ToInt32(result);

                    // Delete the bill with the latest ID
                    string deleteQuery = $"DELETE FROM bills_{username} WHERE id = @billID";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@billID", latestBillID);
                    deleteCmd.ExecuteNonQuery();
                }
            }
        }

        public static void EnsureUserTableExists(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string tableName = $"bills_{username}"; // Example: Creating a unique table for the user

                string query = $@"
            CREATE TABLE IF NOT EXISTS `{tableName}` (
                BillID INT AUTO_INCREMENT PRIMARY KEY,
                CustomerName VARCHAR(255),
                CustomerPhone VARCHAR(15),
                TotalAmount DECIMAL(10,2),
                Discount DECIMAL(10,2),
                FinalPrice DECIMAL(10,2),
                BillDetails TEXT
            )";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }



        /// <summary>
        /// Saves a bill in the database.
        /// </summary>
        public static int SaveBill(string username, string customerName, string phone, string items, decimal total, decimal discount, decimal final)
        {
            int billID = -1; // Default value if the insert fails

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string tableName = $"bills_{username}";

                    string query = $@"
            INSERT INTO `{tableName}` (customer_name, phone_number, items, total_price, discount, final_price) 
            VALUES (@name, @phone, @items, @total, @discount, @final);
            SELECT LAST_INSERT_ID();";  // ✅ Returns the last inserted Bill ID

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@items", items);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@final", final);

                        object result = cmd.ExecuteScalar(); // ✅ Get the inserted bill ID
                        if (result != null)
                        {
                            billID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database Error (SaveBill): " + ex.Message);
                }
            }
            return billID; // ✅ Return the correct Bill ID
        }


    }
}
