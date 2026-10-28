//Bài 1
/*Console.WriteLine("Lab 1:");
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập họ tên: ");
string hoTen = Console.ReadLine();
Console.Write("Nhập điểm môn C#: ");
double diemC = double.Parse(Console.ReadLine());
Console.Write("Nhập điểm môn CSDL");
double diemCSDL = double.Parse(Console.ReadLine());
Console.Write("Nhập điểm môn TKWEB: ");
double diemTKWEB = double.Parse(Console.ReadLine());
double diemTrungBinh = (diemC + diemCSDL + diemTKWEB) / 3;
Console.WriteLine("Điểm trung bình: " +  diemTrungBinh);

if (diemTrungBinh >= 5)
{
    Console.WriteLine("Kết quả đạt");
}
else
{
    Console.WriteLine("Chưa đạt");
}*/
//Bài 2
using System;
using System.Text;
class program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập tên sản phẩm: ");
        string tenSP = Console.ReadLine();

        Console.Write("Nhập số lượng: ");
        double soLuong = double.Parse(Console.ReadLine());

        Console.Write("Nhập đơn giá: ");
        double donGia = double.Parse(Console.ReadLine());

        double tongTien = soLuong * donGia;

        double phanTramGiam = 0;
        if (tongTien >= 5000000)
        {
            phanTramGiam = 0.1;
        }
        else if (tongTien >= 1000000)
        {
            phanTramGiam = 0.05;
        }
        else {
            phanTramGiam = 0;
        }
        
        double tienGiam = tongTien * phanTramGiam;
        double tienThanhToan = tongTien - tienGiam;

        Console.WriteLine("Thông tin thanh toán: ");
        Console.WriteLine("Tên sản phẩm: " + tenSP);
        Console.WriteLine("Tổng tiền trước giảm: " + tienGiam);
        Console.WriteLine("Tiền thanh toán: " + tienThanhToan);
    }
}

//
/*Bài 3. Tính tiền điện theo bậc (2,5 điểm)
Yêu cầu: Nhập họ tên khách hàng và số kWh tiêu thụ trong tháng. Tính tiền điện lũy tiến
từng bậc theo bảng đơn giá giả định dành riêng cho bài tập:
Bậc Lượng điện áp dụng Đơn giá (VNĐ/kWh)
1 50 kWh đầu tiên 1.800
2 Từ kWh 51 đến 100 2.000
3 Từ kWh 101 đến 200 2.500
4 Phần vượt 200 kWh 3.000
4. Tính tiền điện cộng dồn theo các bậc đã sử dụng (không áp một mức giá cho toàn bộ
kWh).
5. Hiển thị họ tên, tổng kWh và tiền điện phải trả (chưa gồm thuế).
Ví dụ: 120 kWh → 50 × 1.800 + 50 × 2.000 + 20 × 2.500 = 240.000 VNĐ */

/*using System;
class program {
    static void Main()
    {
       Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập tên khách hàng: ");
        string hoTen = Console.ReadLine();
        Console.Write("Nhập số Kwh tiêu thụ trong tháng: ");
        double soKwh = double.Parse(Console.ReadLine());

        double tinhTien = 0;

        if (soKwh <=50)
        {
            tinhTien = soKwh * 1800;
        }
        else if (soKwh <=100)
        {
            tinhTien = (50 * 1800) + ((soKwh - 50) * 2000);
        }
        else if (soKwh <= 200)
        {
            tinhTien = (50 * 1800) + (50 * 2000) + ((soKwh - 100) * 2500);
        }
        else
        {
            tinhTien = (50 * 1800) + (50 * 2000) + (100 * 2500) + ((soKwh - 200) * 3000);
        }

        Console.WriteLine("Thanh toán: ");
        Console.WriteLine("Tên khách hàng: " + hoTen);
        Console.WriteLine("Tổng số Kwh: " + soKwh);
        Console.WriteLine("Tổng tiền phải trả: " + tinhTien);
    }
} */


/*Bài 4. Máy tính đơn giản (2,5 điểm)
Yêu cầu: Xây dựng ứng dụng Console cho phép nhập hai số và chọn phép tính bằng
switch hoặc switch expression.
6. Hiển thị menu: 1.Cộng; 2.Trừ; 3.Nhân; 4.Chia; 0.Thoát.
7.Hiển thị kết quả theo phép tính đã chọn.
8. Thông báo khi chọn menu không hợp lệ hoặc chia cho 0.
9. Dùng vòng lặp do...while để cho phép tính nhiều lần đến khi người dùng thoát.
Ví dụ: Chọn 4, nhập 20 và 5 → Kết quả: 20 / 5 = 4. */

/*g System;

class program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;

        do
        {
            Console.WriteLine("Máy tính đơn giản");
            Console.WriteLine("1. Cộng");
            Console.WriteLine("2. Trừ");
            Console.WriteLine("3. Nhân");
            Console.WriteLine("4. Chia");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");

            chon = int.Parse(Console.ReadLine());

            if (chon == 0)
            {
                Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình");
                break;
            }

            if (chon < 1 || chon > 4)
            {
                Console.WriteLine("Lựa chọn không hợp lệ");
                continue;
            }

            Console.Write("Nhập số thứ nhất: ");
            double so1 = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double so2 = double.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.WriteLine("Kết quả: " + so1 + " + " + so2 + " = " + (so1 + so2));
                    break;

                case 2:
                    Console.WriteLine("Kết quả: " + so1 + " - " + so2 + " = " + (so1 - so2));
                    break;

                case 3:
                    Console.WriteLine("Kết quả: " + so1 + " * " + so2 + " = " + (so1 * so2));
                    break;

                case 4:
                    if (so2 == 0)
                    {
                        Console.WriteLine("Không thể chia cho 0");
                    }
                    else
                    {
                        Console.WriteLine("Kết quả: " + so1 + " / " + so2 + " = " + (so1 / so2));
                    }
                    break;
            }

        } while (chon != 0);
    }
}*/