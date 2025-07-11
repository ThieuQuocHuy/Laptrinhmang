﻿using MySql.Data.MySqlClient;
using System.Data;

namespace Server.Data
{
    public class UserService
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
    public class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext()
        {
            _connectionString = Environment.GetEnvironmentVariable("DATABASE_URL") ??
                              "server=localhost;database=auction_db;user=root";

        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        /// <summary>
        /// Initializes the database by creating necessary tables if they don't exist and populating them with sample data.
        /// </summary>
        /// <remarks>
        /// Creates the following tables:
        /// - users: Stores user account information
        /// - user_info: Stores additional user details
        /// - auctions: Stores auction listings
        /// - bids: Stores bidding history
        /// - payment_history: Stores payment transactions
        /// 
        /// If the users table is empty, inserts sample users and auction data.
        /// </remarks>
        /// <returns>A task representing the asynchronous database initialization operation.</returns>
        public async Task InitializeDatabase()
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            // Create tables if they don't exist
            var createTables = @"
                CREATE TABLE IF NOT EXISTS users (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    username VARCHAR(50) UNIQUE NOT NULL,
                    password VARCHAR(100) NOT NULL,
                    email VARCHAR(100) NOT NULL,
                    role VARCHAR(20) NOT NULL DEFAULT 'users'
                );
                
                CREATE TABLE IF NOT EXISTS user_info (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    user_id INT NOT NULL,
                    full_name VARCHAR(100) NOT NULL,
                    date_of_birth DATE,
                    address VARCHAR(200),
                    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
                );


                CREATE TABLE IF NOT EXISTS auctions (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    license_plate_number VARCHAR(20) NOT NULL,
                    starting_price DECIMAL(10,2) NOT NULL,
                    current_price DECIMAL(10,2) NOT NULL,
                    start_time DATETIME NOT NULL,
                    end_time DATETIME NOT NULL,
                    winner_id INT,
                    status VARCHAR(20) NOT NULL,
                    FOREIGN KEY (winner_id) REFERENCES users(id)
                );

                CREATE TABLE IF NOT EXISTS bids (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    auction_id INT NOT NULL,
                    user_id INT NOT NULL,
                    amount DECIMAL(10,2) NOT NULL,
                    bid_time DATETIME NOT NULL,
                    FOREIGN KEY (auction_id) REFERENCES auctions(id),
                    FOREIGN KEY (user_id) REFERENCES users(id)
                );
                CREATE TABLE IF NOT EXISTS payment_history (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    history_username VARCHAR(50) NOT NULL,
                    history_license_plate VARCHAR(20) NOT NULL,
                    history_amount DECIMAL(10,2) NOT NULL,
                    payment_method VARCHAR(20) NOT NULL,
                    payment_time DATETIME NOT NULL,
                    status ENUM('Thành công', 'Th?t b?i') NOT NULL,
                    user_id INT,
                    auction_id INT,
                    FOREIGN KEY (user_id) REFERENCES users(id),
                    FOREIGN KEY (auction_id) REFERENCES auctions(id)
                );";

            using var cmd = new MySqlCommand(createTables, conn);
            await cmd.ExecuteNonQueryAsync();

            // Insert sample data if tables are empty
            if (!await TableHasData(conn, "users"))
            {
                var insertSampleData = @"
                    INSERT INTO users (username, password, email) VALUES
                    ('user1', 'password123', 'user1@example.com'),
                    ('user2', 'password123', 'user2@example.com');
                    INSERT INTO auctions (license_plate_number, starting_price, current_price, 
                                        start_time, end_time, status) VALUES
                    ('51F-123.45', 1000000, 1000000, NOW(), DATE_ADD(NOW(), INTERVAL 1 DAY), 'Active'),
                    ('51F-678.90', 2000000, 2000000, NOW(), DATE_ADD(NOW(), INTERVAL 1 DAY), 'Active');";

                using var cmdInsert = new MySqlCommand(insertSampleData, conn);
                await cmdInsert.ExecuteNonQueryAsync();
            }
        }

        private async Task<bool> TableHasData(MySqlConnection conn, string tableName)
        {
            using var cmd = new MySqlCommand($"SELECT COUNT(*) FROM {tableName}", conn);
            var count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
            return count > 0;
        }
        // Phương pháp lấy tên người dùng theo ID người dùng
        public async Task<string> GetUsernameById(int id)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            using var cmd = new MySqlCommand("SELECT username FROM users WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            var username = await cmd.ExecuteScalarAsync();
            return username?.ToString();
        }
        //Phương thức lấy id của một cuộc đấu giá mà người dùng đã thắng
        public async Task<int> GetAuctionIdByUserId(int id)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            using var cmd = new MySqlCommand("SELECT id FROM auctions WHERE winner_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            var result = await cmd.ExecuteScalarAsync();
            return result != null ? Convert.ToInt32(result) : -1;
        }

        //Phương thức lấy thông tin chi tiết của một cuộc đấu giá mà người dùng đã thắng, bao gồm biển số xe và tổng số tiền mà người dùng đã đặt 
        public async Task<(string licensePlateNumber, decimal totalAmount)> GetAuctionDetailsAndTotalAmount(int id)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            string licensePlateNumber = null;
            decimal totalAmount = 0;

            // Lay thong tin bien so cua cuoc dau gia ma nguoi dung da thang
            using (var cmd = new MySqlCommand("SELECT license_plate_number FROM auctions WHERE winner_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    // Kiểm tra xem giá trị có phải là DBNull không
                    if (!reader.IsDBNull(reader.GetOrdinal("license_plate_number")))
                    {
                        licensePlateNumber = reader.GetString("license_plate_number");
                    }
                }
            }

            // Tính tổng số tiền thanh toán 
            using (var cmd = new MySqlCommand("SELECT SUM(amount) FROM bids WHERE user_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                var result = await cmd.ExecuteScalarAsync();
                // Kiểmm tra xem giá trị có phải là DBNull không
                totalAmount = result != null && !Convert.IsDBNull(result) ? Convert.ToDecimal(result) : 0;
            }

            return (licensePlateNumber, totalAmount);
        }
        //Lưu lại lịch sử thanh toán 
        public async Task SavePaymentHistory(string username, string licensePlateNumber, decimal amount, string paymentMethod, string status, int userId, int auctionId)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            var query = @"
        INSERT INTO payment_history (history_username, history_license_plate, history_amount, payment_method, payment_time, status, user_id, auction_id)
        VALUES (@username, @licensePlateNumber, @amount, @paymentMethod, NOW(), @status, @userId, @auctionId);
    ";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@licensePlateNumber", licensePlateNumber);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@auctionId", auctionId);

            await cmd.ExecuteNonQueryAsync();
        }
        //Phương thức lấy thông tin lịch sử thanh toán theo id người dùng để hiển thị lịch sử thanh toán 

        public async Task<DataTable> GetPaymentHistoryByUserId(int id)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            string query = @"
            SELECT id, 
                   history_username, 
                   history_license_plate_number,
                   history_amount, 
                   history_payment_method, 
                   payment_time, 
                   history_status'
            FROM payment_history 
            WHERE user_id = @id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", id);

            using var adapter = new MySqlDataAdapter(cmd);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public async Task EndAuctionAndSetWinner(int auctionId)
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            // Tìm user có bid cao nhất cho auction này
            string getWinnerQuery = @"
                SELECT user_id
                FROM bids
                WHERE auction_id = @auctionId
                ORDER BY amount DESC, bid_time ASC
                LIMIT 1;
            ";

            int? winnerId = null;
            using (var cmd = new MySqlCommand(getWinnerQuery, conn))
            {
                cmd.Parameters.AddWithValue("@auctionId", auctionId);
                var result = await cmd.ExecuteScalarAsync();
                if (result != null && result != DBNull.Value)
                    winnerId = Convert.ToInt32(result);
            }

            // Cập nhật winner_id và status cho auction
            string updateAuctionQuery = @"
                UPDATE auctions
                SET winner_id = @winnerId, status = 'Ended'
                WHERE id = @auctionId;
            ";

            using (var cmd = new MySqlCommand(updateAuctionQuery, conn))
            {
                cmd.Parameters.AddWithValue("@winnerId", (object?)winnerId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@auctionId", auctionId);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task CheckAndEndAuctions()
        {
            using var conn = GetConnection();
            await conn.OpenAsync();

            string query = "SELECT id FROM auctions WHERE end_time <= NOW() AND status = 'Active'";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = await cmd.ExecuteReaderAsync();
            var endedAuctionIds = new List<int>();
            while (await reader.ReadAsync())
            {
                endedAuctionIds.Add(reader.GetInt32("id"));
            }

            foreach (var auctionId in endedAuctionIds)
            {
                await EndAuctionAndSetWinner(auctionId);
            }
        }
    }
}
