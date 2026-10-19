namespace Buoi01_B3
{
    internal class program
    {
        static void Main(string[] args) //sửa: main -> Main 
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //sửa: thêm dấu chấm phẩy cuối dòng
            Console.WriteLine("Chương trình có lỗi"); //sửa: chữ C của Console viết hoa, thêm dấu nháy kép đóng
            Console.WriteLine(@"Đường dẫn: C:\Temp\new"); //sửa: chữ L của Writeline viết hoa và thêm @ để giữ nguyên dấub \ trong chuỗi
            Console.WriteLine("Kết thúc"); //sửa: đổi ' thành "
        }
    }
} // sửa: thêm dấu ngoặc 
