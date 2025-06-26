using Shared.Models;

namespace Shared.Interfaces
{
    /// <summary>
    /// /// <summary>
    /// Interface cung cấp các phương thức để tương tác với hệ thống đấu giá
    /// </summary>
    public interface IAuctionService
    {
        /// <summary>
        /// Lấy trạng thái của một phiên đấu giá
        /// /// <summary>
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
        /// /// <summary>
        /// Lấy danh sách tất cả các phiên đấu giá đã kết thúc
        /// </summary>
        /// /// <summary>
        /// <returns>Danh sách các phiên đấu giá đã kết thúc</returns>
        Task<List<Auction>> GetInactiveAuctions();

        /// <summary>
        /// Đặt giá cho một phiên đấu giá
        /// /// <summary>
        /// </summary>
        /// <param name="auctionId">ID của phiên đấu giá</param>
        /// <param name="userId">ID của người đặt giá</param>
        /// <param name="amount">Số tiền đặt giá</param>
        /// <returns>True nếu đặt giá thành công, ngược lại là False</returns>
        Task<bool> PlaceBid(int auctionId, int userId, decimal amount);

        /// <summary>
<<<<<<< HEAD
=======
        /// /// <summary>
        /// /// <summary>
>>>>>>> 1d5b037f2a55061f8047cad0d58333221eeea5cd
        /// Lấy danh sách các lượt đặt giá của một phiên đấu giá
        /// </summary>
        /// <param name="auctionId">ID của phiên đấu giá</param>
        /// <returns>Danh sách các lượt đặt giá</returns>
        Task<List<Bid>> GetAuctionBids(int auctionId);

        /// <summary>
<<<<<<< HEAD
        /// Đăng ký người dùng mới
        /// </summary>
=======
        /// <summary>
        /// Đăng ký người dùng mới
        /// </summary>
        /// /// <summary>
>>>>>>> 1d5b037f2a55061f8047cad0d58333221eeea5cd
        /// <param name="user">Thông tin người dùng cần đăng ký</param>
        /// <returns>True nếu đăng ký thành công, ngược lại là False</returns>
        Task<bool> RegisterUser(User user);

        /// <summary>
<<<<<<< HEAD
        /// Đăng nhập vào hệ thống
        /// </summary>
=======
        /// /// <summary>
        /// Đăng nhập vào hệ thống
        /// </summary>
        /// /// <summary>
>>>>>>> 1d5b037f2a55061f8047cad0d58333221eeea5cd
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="password">Mật khẩu</param>
        /// <returns>Thông tin người dùng nếu đăng nhập thành công</returns>
        Task<User> Login(string username, string password);
        Task<bool> UpdateAuction(Auction updatedAuction);
        Task<bool> DeleteAuction(int auctionId);
        Task<bool> AddAuction(Auction newAuction);
    }
}
