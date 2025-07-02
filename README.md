## Acknowledgments

- Đây là dự án phục vụ mục đích học tập, vẫn còn nhiều thiếu xót do các thành viên trong nhóm đây là lần đầu sử dụng .NET và dùng ngôn ngữ C# để làm WinForm, cũng như là lần đầu dùng GIT để push code lên nên có đôi lúc lỗi. Mong thầy thông cảm cho nhóm 7 của chúng em.

- Cảm ơn giảng viên: Bùi Dương Thế đã hướng dẫn tận tình và giúp đỡ chúng em trong môn học.
# Phần Mềm Đấu Giá Bảng Số Xe

Dự án phần mềm đấu giá bảng số xe là một ứng dụng client-server cho phép người dùng tham gia đấu giá biển số xe trực tuyến. Dự án được phát triển bằng C# với mục đích học tập về lập trình mạng.

## File chạy dự án trên Visual Studio
- auction.sln         #project để chạy bài

## Yêu Cầu Hệ Thống
- .NET 8.0 hoặc cao hơn
- MySQL
## Cài Đặt
Yêu cầu sửa đổi chuỗi kết nối trong file `Server/Data/DatabaseContext.cs` để kết nối với cơ sở dữ liệu MySQL.
thêm password của tài khoản root của bạn khi dùng mysql 
- ";password = *matkhaucuaban*" sau username ví dụ: "...;username=root;password=matkhaucuaban"
sau đó vô sql dùng câu lệnh: CREATE DATABASE auction_db để tạo 1 database 
## Chạy Ứng Dụng

1. Chạy Server:
```bash
cd Server
dotnet run
```

2. Chạy Client (trong terminal khác):

```bash
cd Client
dotnet run
```
## lƯu ý: 
- Trong lúc đấu giá phải giữ nguyên ko được quit thì hệ thống mới ghi nhận lại người thắng (cột winner_id trong bảng auctions) để thực hiện lệnh thanh toán
## Network Protocol
- Sử dụng TCP Socket cho giao tiếp client-server

