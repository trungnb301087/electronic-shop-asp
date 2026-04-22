# WEBSITE BÁN LINH KIỆN ĐIỆN TỬ - ASP.NET CORE MVC

## 1. Thông tin sinh viên

- **Sinh viên thực hiện:** Nguyễn Bảo Trung
- **Mã số sinh viên:** 170124487
- **Lớp:** DK24TTC5
- **Email:** itbenhvien@gmail.com
- **Số điện thoại:** 0916221287

---

## 2. Giới thiệu đề tài

Đây là đồ án môn học với đề tài **xây dựng website bán linh kiện điện tử** sử dụng **ASP.NET Core MVC**.  
Website cho phép người dùng xem sản phẩm, tìm kiếm, lọc theo danh mục, thêm vào giỏ hàng, thêm vào danh sách yêu thích, đặt hàng và quản lý thông tin cá nhân.

Hệ thống được xây dựng theo mô hình **MVC**, sử dụng **Entity Framework Core** và **SQL Server** để quản lý dữ liệu. Ngoài khu vực dành cho người dùng, website còn có trang quản trị riêng dành cho tài khoản **Admin** để quản lý sản phẩm, danh mục, người dùng và đơn hàng.

---

## 3. Mục tiêu của đề tài

- Xây dựng website bán linh kiện điện tử có giao diện thân thiện, dễ sử dụng.
- Hỗ trợ người dùng xem danh sách sản phẩm và thông tin chi tiết sản phẩm.
- Hỗ trợ tìm kiếm sản phẩm theo tên.
- Hỗ trợ lọc sản phẩm theo danh mục.
- Xây dựng chức năng giỏ hàng và danh sách yêu thích.
- Xây dựng chức năng đặt hàng và theo dõi đơn hàng.
- Xây dựng khu vực quản trị để quản lý sản phẩm, danh mục, người dùng và đơn hàng.
- Kết nối cơ sở dữ liệu SQL Server để lưu trữ và quản lý dữ liệu.
- Vận dụng kiến thức về ASP.NET Core MVC, Entity Framework Core và SQL Server vào bài toán thực tế.

---

## 4. Công nghệ sử dụng

- **Ngôn ngữ lập trình:** C#
- **Framework:** ASP.NET Core MVC
- **ORM:** Entity Framework Core
- **Cơ sở dữ liệu:** SQL Server
- **Giao diện:** HTML, CSS, Bootstrap 5, Razor View
- **Ngôn ngữ hỗ trợ:** JavaScript
- **Công cụ phát triển:** Visual Studio 2022

---

## 5. Chức năng đã thực hiện

### 5.1. Người dùng

- Xem danh sách sản phẩm
- Lọc sản phẩm theo danh mục
- Tìm kiếm sản phẩm
- Xem chi tiết sản phẩm
- Thêm vào giỏ hàng
- Danh sách yêu thích (Wishlist)
- Đăng ký / đăng nhập
- Quản lý thông tin cá nhân
- Đổi mật khẩu
- Đặt hàng
- Xem lịch sử đơn hàng
- Xem chi tiết đơn hàng

### 5.2. Giỏ hàng

- Thêm sản phẩm vào giỏ
- Cập nhật số lượng
- Xóa sản phẩm
- Hiển thị tổng tiền
- Hiển thị số lượng sản phẩm trên icon

### 5.3. Wishlist

- Thêm sản phẩm vào danh sách yêu thích
- Xóa khỏi wishlist
- Hiển thị số lượng wishlist trên layout

### 5.4. Đơn hàng

- Tạo đơn hàng
- Lưu thông tin `Order` và `OrderDetail`
- Xem danh sách đơn hàng
- Xem chi tiết đơn hàng
- Theo dõi trạng thái đơn hàng

### 5.5. Danh mục

- Hiển thị danh mục sản phẩm
- Lọc sản phẩm theo danh mục

### 5.6. Quản trị viên

- Đăng nhập với quyền Admin
- Truy cập trang quản trị với giao diện riêng
- Quản lý sản phẩm (thêm / sửa / xóa)
- Quản lý danh mục (thêm / sửa / xóa)
- Quản lý người dùng
- Quản lý đơn hàng
- Cập nhật trạng thái đơn hàng
- Xem dashboard thống kê cơ bản

---

## 6. Các đối tượng dữ liệu chính

Hệ thống sử dụng các bảng dữ liệu chính như:

- **Category**: lưu danh mục sản phẩm
- **Product**: lưu thông tin sản phẩm
- **Customer/User**: lưu thông tin tài khoản người dùng
- **CartItem**: lưu thông tin giỏ hàng
- **Wishlist**: lưu danh sách yêu thích
- **Order**: lưu thông tin đơn hàng
- **OrderDetail**: lưu chi tiết từng sản phẩm trong đơn hàng

---

## 7. Giao diện chính của hệ thống

Một số giao diện chính của website gồm có:

- Trang chủ
- Trang danh sách sản phẩm
- Trang chi tiết sản phẩm
- Trang giỏ hàng
- Trang wishlist
- Trang đăng ký / đăng nhập
- Trang thông tin cá nhân
- Trang lịch sử đơn hàng
- Trang quản lý sản phẩm
- Trang quản lý danh mục
- Trang quản lý đơn hàng
- Dashboard quản trị

---

## 8. Cấu trúc project

```text

├── README.md
├── setup/
│   ├── huong-dan-cai-dat.docx
│   └── database/
│
├── src/
│   └── electronic-shop-asp/
│       ├── Areas/
│       │   └── Admin/
│       ├── Controllers/
│       ├── Models/
│       ├── Views/
│       ├── Data/
│       ├── Migrations/
│       ├── wwwroot/
│       ├── Program.cs
│       ├── appsettings.json
│       └── electronic-shop-asp.csproj
│
├── progress-report/
│   ├── week1.docx
│   ├── week2.docx
│   ├── week3.docx
│   └── week4.docx
│
├── thesis/
│   ├── doc/
│   ├── pdf/
│   └── refs/
```
