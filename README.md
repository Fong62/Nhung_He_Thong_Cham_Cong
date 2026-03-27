# 🕰️ Hệ Thống Chấm Công Tự Động

## 📌 Giới thiệu dự án
Đây là kho lưu trữ mã nguồn cho đồ án môn học **Lập trình nhúng** (Mã học phần: COMP1709). Dự án nghiên cứu, thiết kế và lắp ráp hoàn chỉnh một **"Hệ thống chấm công tự động"** sử dụng thẻ từ/RFID. 

Hệ thống là sự kết hợp chặt chẽ giữa thiết bị phần cứng (vi điều khiển, module đọc thẻ) và phần mềm điều khiển (code Python) để thu thập dữ liệu điểm danh, góp phần số hóa quy trình quản lý nhân sự và hướng tới tự động hóa trong môi trường thực tế.

## ⚙️ Tính năng hệ thống
* **Quét và nhận diện thẻ:** Sử dụng module phần cứng để đọc thông tin từ thẻ RFID/NFC của nhân viên một cách nhanh chóng.
* **Xử lý dữ liệu qua Serial:** Phần cứng truyền dữ liệu thời gian thực qua cổng Serial lên máy tính.
* **Xử lý bằng Python:** Chạy script Python để lắng nghe cổng Serial, đọc dữ liệu thẻ và đối chiếu/ghi nhận thời gian chấm công.

## 🛠️ Công nghệ & Linh kiện
* **Ngôn ngữ lập trình:** C/C++ (Cho vi điều khiển), Python (Xử lý dữ liệu trên máy tính).
* **Phần cứng:** Mạch vi điều khiển, Module đọc thẻ RFID, Thẻ từ.
* **Giao thức:** Serial Communication.

## 📂 Cấu trúc thư mục
- `ChamCong_SourceCode` : Chứa mã nguồn C/C++ nạp vào vi điều khiển.
- `Kết nối Arduino` : Chứa script Python dùng để đọc và xử lý dữ liệu chấm công.
- `ChamCong` : Hệ thống Winform theo dõi dữ liệu chấm công.
- `README.md` : Tài liệu hướng dẫn.

## 🚀 Hướng dẫn cài đặt & Chạy dự án
1. **Clone repository về máy tính:**
    git clone https://github.com/Fong62/Nhung_He_Thong_Cham_Cong.git

2. **Setup Phần cứng:** Lắp ráp mạch theo sơ đồ, kết nối vi điều khiển với máy tính và nạp mã nguồn từ thư mục `ChamCong_SourceCode`.

3. **Chạy Phần mềm:**
    Cài đặt thư viện Python cần thiết. Mở terminal và chạy script xử lý dữ liệu:
    
    python main.py

## 🔮 Hướng phát triển tương lai (Future Work)
Nhóm đã xác định các định hướng nâng cấp hệ thống để khắc phục những hạn chế hiện tại:
* Nâng cấp phần cứng sử dụng **ESP32** hoặc **Raspberry Pi 4** để đẩy dữ liệu trực tiếp lên Web Server thông qua WiFi/Internet (Không phụ thuộc vào script Python chạy cục bộ).
* Đồng bộ dữ liệu lên hệ thống **Cloud Server** để theo dõi và quản lý thời gian thực.
* Xây dựng hệ sinh thái đa nền tảng (Cross-platform) bao gồm Website và Ứng dụng di động để xem báo cáo chấm công.

## 📞 Liên hệ
**Nguyễn Hoàng Phong**
* **Email:** nguyenhoangphongsupham@gmail.com
* **LinkedIn:** [Nguyễn Hoàng Phong](https://www.linkedin.com/in/fong62/)
* **GitHub:** [Fong62](https://github.com/Fong62)
