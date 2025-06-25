using Shared.Models;
using System.Security.Cryptography;

namespace Shared.Interfaces
{
    /// <summary>
    /// Interface cung cấp các phương thức để tương tác với hệ thống đấu giá
    /// </summary>
    public interface IAuctionService
    {
        /// <summary>
        /// Lấy trạng thái của một phiên đấu giá
        /// </summary>
        /// <param name="auctionId">ID của phiên đấu giá</param>
        /// <returns>Chuỗi mô tả trạng thái của phiên đấu giá</returns>
        Task<string> GetStatus(int auctionId);

        /// <summary>
        /// Lấy danh sách tất cả các phiên đấu giá đang hoạt động
        /// </summary>
        /// <returns>Danh sách các phiên đấu giá đang hoạt động</returns>
        Task<List<Auction>> GetActiveAuctions();

        /// <summary>
        /// Lấy danh sách tất cả các phiên đấu giá đã kết thúc
        /// </summary>
        /// <returns>Danh sách các phiên đấu giá đã kết thúc</returns>
        Task<List<Auction>> GetInactiveAuctions();

        /// <summary>
        /// Đặt giá cho một phiên đấu giá
        /// </summary>
        /// <param name="auctionId">ID của phiên đấu giá</param>
        /// <param name="userId">ID của người đặt giá</param>
        /// <param name="amount">Số tiền đặt giá</param>
        /// <returns>True nếu đặt giá thành công, ngược lại là False</returns>

    }
}
