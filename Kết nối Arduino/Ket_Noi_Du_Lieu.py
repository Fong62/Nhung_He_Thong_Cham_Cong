import serial
import pyodbc
from datetime import datetime

# Thiết lập Serial với Arduino
arduino_port = "COM4"  # Thay COM4 bằng cổng của bạn
baud_rate = 9600
ser = serial.Serial(arduino_port, baud_rate, timeout=1)

# Chuỗi kết nối SQL Server
connString = (
    "DRIVER={SQL Server};"
    "SERVER=PHONG;"  # Thay bằng tên máy chủ của bạn
    "DATABASE=QUAN_LY_CHAM_CONG;"  # Thay bằng tên cơ sở dữ liệu của bạn
    "Trusted_Connection=yes;"
    "TrustServerCertificate=yes;"
    "Encrypt=no;"
)

try:
    # Kết nối SQL Server
    conn = pyodbc.connect(connString)
    cursor = conn.cursor()
    print("Kết nối thành công tới cơ sở dữ liệu!")

    while True:
        # Đọc dữ liệu từ Serial
        if ser.in_waiting > 0:
            rfid_id = ser.readline().decode('utf-8').strip()
            if rfid_id:
                print(f"Đọc được ID thẻ: {rfid_id}")

                # Kiểm tra nếu ID thẻ tồn tại trong bảng NHAN_VIEN
                cursor.execute("SELECT COUNT(*) FROM NHAN_VIEN WHERE ID_The = ?", (rfid_id,))
                exists = cursor.fetchone()[0]

                if exists == 0:
                    ser.write(b'0')
                    # Thẻ không tồn tại -> Thêm vào bảng NHAN_VIEN và CHAM_CONG
                    cursor.execute(
                        "INSERT INTO NHAN_VIEN (ID_The, Ten) VALUES (?, NULL)",
                        (rfid_id,)
                    )
                    conn.commit()
                    print("Thẻ mới đã được thêm vào bảng NHAN_VIEN.")
                else:
                    # Kiểm tra nếu Tên không phải NULL
                    cursor.execute("SELECT Ten FROM NHAN_VIEN WHERE ID_The = ?", (rfid_id,))
                    name = cursor.fetchone()[0]  # Lấy tên từ cơ sở dữ liệu

                    if name:  # Nếu Tên không NULL
                        print(f"Thẻ hợp lệ, tên: {name}")

                        date = datetime.now().date()
                        entry_time = datetime.now().time()
                        exit_time = datetime.now().time()
                        entry_time_format = entry_time.strftime("%H:%M:%S")
                        exit_time_format = exit_time.strftime("%H:%M:%S")

                        cursor.execute(
                            "SELECT COUNT(*) FROM CHAM_CONG WHERE ID_The = ? AND Ngay = ? AND Thoi_Gian_Vao IS NOT NULL AND Thoi_Gian_Ra IS NOT NULL",
                            (rfid_id, str(date))  # Convert date to string for SQL query
                        )
                        result = cursor.fetchone()[0]

                        if result == 0:
                            cursor.execute(
                            "SELECT COUNT(*) FROM CHAM_CONG WHERE ID_The = ? AND Ngay = ? AND Thoi_Gian_Vao IS NOT NULL",
                            (rfid_id, str(date))  # Convert date to string for SQL query
                            )
                            swipe_count = cursor.fetchone()[0]

                            print(f"Số lần quẹt thẻ: {swipe_count + 1}")

                            if swipe_count == 0:
                                # Quẹt lần đầu tiên: Thêm vào bảng CHAM_CONG với thời gian vào
                                cursor.execute(
                                    "INSERT INTO CHAM_CONG (ID_The, Ngay, Thoi_Gian_Vao) VALUES (?, ?, ?)",
                                    (rfid_id, str(date), str(entry_time_format))
                                )
                                conn.commit()
                                ser.write(b'1')
                                print(f"Quẹt lần đầu: Đã thêm thời gian vào cho {rfid_id}.")
                            
                            elif swipe_count == 1:
                                # Quẹt lần thứ hai: Cập nhật thời gian ra
                                cursor.execute(
                                    "UPDATE CHAM_CONG SET Thoi_Gian_Ra = ? WHERE ID_The = ? AND Ngay = ? AND Thoi_Gian_Ra IS NULL",
                                    (str(exit_time_format), rfid_id, str(date))
                                )
                                conn.commit()

                                cursor.execute(
                                    "UPDATE CHAM_CONG Set So_Cong = DateDiff(Hour,Thoi_Gian_Vao, Thoi_Gian_Ra) from Cham_Cong WHERE ID_The = ?",
                                    (rfid_id)
                                )
                                conn.commit()
                                ser.write(b'1')
                                print(f"Quẹt lần thứ hai: Đã thêm thời gian ra cho {rfid_id}.")
                                # Gửi '1' nếu thẻ hợp lệ và có tên
                        # Kiểm tra số lần quẹt thẻ của nhân viên trong bảng CHAM_CONG hôm nay
                        else:
                            ser.write(b'0')
                            print(f"Số lần quẹt thẻ: 3")
                            print(f"Quẹt lần thứ ba: Thẻ {rfid_id} đã được chấm công đầy đủ hôm nay. Từ chối.")
                    else:
                        ser.write(b'0')  # Gửi '0' nếu chưa có tên  
                        print("Thẻ hợp lệ nhưng chưa có tên.")
                                
except Exception as e:
    print(f"Lỗi: {e}")
finally:
    if conn:
        conn.close()
    if ser:
        ser.close()
