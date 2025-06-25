using MySql.Data.MySqlClient;
using Server.Data;
using Shared.Interfaces;
using Shared.Models;
using System.Data;
using System.Security.Cryptography;

namespace Server.Services
{
    public class AuctionService : IAuctionService
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private readonly DatabaseContext _dbContext;

        public AuctionService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Auction>> GetActiveAuctions()
        {
            var auctions = new List<Auction>();
            using var conn = _dbContext.GetConnection();
            await conn.OpenAsync();

            var sql = @"SELECT * FROM auctions WHERE status = 'Active' AND end_time > NOW()";
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                auctions.Add(new Auction
                {
                    Id = reader.GetInt32("id"),
                    LicensePlateNumber = reader.GetString("license_plate_number"),
                    StartingPrice = reader.GetDecimal("starting_price"),
                    CurrentPrice = reader.GetDecimal("current_price"),
                    StartTime = reader.GetDateTime("start_time"),
                    EndTime = reader.GetDateTime("end_time"),
                    WinnerId = reader.IsDBNull("winner_id") ? null : reader.GetInt32("winner_id"),
                    Status = reader.GetString("status")
                });
            }

            return auctions;
        }

        public async Task<List<Auction>> GetInactiveAuctions()
        {
            var auctions = new List<Auction>();
            using var conn = _dbContext.GetConnection();
            await conn.OpenAsync();

            var sql = @"SELECT * FROM auctions WHERE status IN ('Completed', 'Cancelled')  OR end_time < NOW()";
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                auctions.Add(new Auction
                {
                    Id = reader.GetInt32("id"),
                    LicensePlateNumber = reader.GetString("license_plate_number"),
                    StartingPrice = reader.GetDecimal("starting_price"),
                    CurrentPrice = reader.GetDecimal("current_price"),
                    StartTime = reader.GetDateTime("start_time"),
                    EndTime = reader.GetDateTime("end_time"),
                    WinnerId = reader.IsDBNull("winner_id") ? null : reader.GetInt32("winner_id"),
                    Status = reader.GetString("status")
                });
            }

            return auctions;
        }




        public async Task<string> GetStatus(int auctionId)
        {
            using var conn = _dbContext.GetConnection();
            await conn.OpenAsync();

            var sql = @"SELECT status FROM auctions WHERE id = @auctionId";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@auctionId", auctionId);

            var status = await cmd.ExecuteScalarAsync();
            return status?.ToString(); // Tr? v? tr?ng thái ho?c null n?u không t́m th?y
        }




    }
}
