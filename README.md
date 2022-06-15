#NganHangPhanTan

+ Đồ án kết thúc học phần môn: Cơ Sở Dữ Liệu Phân Tán (PTITHCM)
+ Võ Quang Tường - N19DCCN185
+ Lê Hoàng Anh - N19DCCN005
+ Thẩm Ngọc Ánh - N19DCCN012
+ Đề tài : Ngân Hàng

#Ngôn ngữ
+ C#

#Công cụ
+ Visual Studio 2015 
+ Dev Express 16.1
+ Microsoft SQL Server 2014

#Chức năng chính
+ Quản lý nhân viên
+ Chuyển nhân viên
+ Tạo tài khoản đăng nhập
+ Quản lý khách hàng
+ Mở tài khoản khách hàng
+ Gửi và rút tiền
+ Chuyển khoản
+ Thống kê thông tin khách hàng
+ Danh sách tài khoản mở trong khoảng thời gian
+ Sao kê tài khoản

#Một số lỗi 
+ SP chuyển nhân viên không hợp lý : muốn chuyển nhân viên cũ từ chi nhánh mới về chi nhánh cũ phải nhớ mã nhân viên cũ
+ SP chuyển nhân viên thiếu phần dựa vào mã chi nhánh ở input để biết nên dùng LINK nào trong trường hợp có nhiều hơn 2 chi nhánh con 
+ SP báo cáo khách hàng của từng chi nhánh: phải sửa lại thành ưu tiên tìm ở site hiện tại table khách hàng trước, nếu không có thì về site chủ
