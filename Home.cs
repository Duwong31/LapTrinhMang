using System;  // Thư viện chứa các kiểu dữ liệu cơ bản và các phương thức hỗ trợ
using System.Collections.Generic;  // Thư viện chứa các cấu trúc dữ liệu tổng quát (generic collections)
using System.ComponentModel;  // Thư viện hỗ trợ lập trình với các thành phần (component) và điều khiển (control)
using System.Data;  // Thư viện hỗ trợ làm việc với cơ sở dữ liệu
using System.Drawing;  // Thư viện hỗ trợ xử lý đồ họa
using System.Linq;  // Thư viện hỗ trợ các truy vấn dữ liệu với LINQ
using System.Net;  // Thư viện hỗ trợ các chức năng mạng
using System.Net.NetworkInformation;  // Thư viện hỗ trợ làm việc với thông tin mạng
using System.Net.Sockets;  // Thư viện hỗ trợ làm việc với các socket
using System.Text;  // Thư viện hỗ trợ xử lý văn bản
using System.Threading.Tasks;  // Thư viện hỗ trợ lập trình bất đồng bộ (asynchronous programming)
using System.Windows.Forms;  // Thư viện hỗ trợ tạo giao diện người dùng (UI) trên Windows

namespace ProjectNhom  // Khai báo không gian tên của chương trình
{
    public partial class Home : Form  // Khai báo lớp Home kế thừa từ Form (một loại cửa sổ trong Windows)
    {
        private string IP = "127.0.0.1";  // Khởi tạo biến lưu địa chỉ IP của máy tính hiện tại
        TcpListener tcpListener;  // Đối tượng lắng nghe các kết nối TCP đến
        TcpClient tcpClient;  // Đối tượng đại diện cho một client TCP kết nối tới server
        Socket socketCilent;  // Đối tượng socket dùng để giao tiếp qua mạng
        private bool serverRunning = false;  // Biến kiểm tra trạng thái hoạt động của server

        public Home()  // Hàm khởi tạo của lớp Home
        {
            InitializeComponent();  // Khởi tạo các thành phần của form
        }

        private void listPConline_SelectedIndexChanged(object sender, EventArgs e)  // Sự kiện khi danh sách máy tính online được chọn
        {
        }

        private void button2_Click(object sender, EventArgs e)  // Sự kiện khi button2 được nhấn
        {
        }

        private void label1_Click(object sender, EventArgs e)  // Sự kiện khi label1 được nhấn
        {
        }

        private void button7_Click(object sender, EventArgs e)  // Sự kiện khi button7 được nhấn
        {
        }

        private void btn__Click(object sender, EventArgs e)  // Sự kiện khi một nút bấm không rõ được nhấn
        {
        }

        private void Home_Load(object sender, EventArgs e)  // Sự kiện khi form Home được tải
        {
        }

        void searchPC()  // Hàm tìm kiếm các máy tính trong mạng LAN
        {
            bool isNetworkUp = NetworkInterface.GetIsNetworkAvailable();  // Kiểm tra kết nối mạng có sẵn không
            if (isNetworkUp)  // Nếu mạng hoạt động
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());  // Lấy thông tin về host (máy tính hiện tại)
                foreach (var ip in host.AddressList)  // Duyệt qua danh sách các địa chỉ IP của host
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)  // Kiểm tra địa chỉ IP là IPv4
                    {
                        this.IP = ip.ToString();  // Lưu địa chỉ IP của máy tính hiện tại
                    }
                }
                Invoke((MethodInvoker)delegate  // Cập nhật giao diện để hiển thị IP của máy tính
                {
                    infoLabel.Text = "This Computer: " + this.IP;
                });

                string[] ipRange = IP.Split('.');  // Chia địa chỉ IP thành các phần (octet)
                for (int i = 100; i < 255; i++)  // Lặp qua dải IP từ 100 đến 254 để tìm kiếm các máy tính trong mạng
                {
                    Ping ping = new Ping();  // Tạo đối tượng Ping để gửi tín hiệu
                    string testIP = ipRange[0] + '.' + ipRange[1] + '.' + ipRange[2] + '.' + i.ToString();  // Xây dựng địa chỉ IP cần kiểm tra
                    if (testIP != this.IP)  // Nếu địa chỉ IP không phải của máy tính hiện tại
                    {
                        ping.PingCompleted += new PingCompletedEventHandler(pingCompletedEvent);  // Đăng ký sự kiện hoàn thành ping
                        ping.SendAsync(testIP, 100, testIP);  // Gửi tín hiệu ping không đồng bộ tới địa chỉ IP
                    }
                }

                Invoke((MethodInvoker)delegate  // Cập nhật giao diện để báo hiệu ứng dụng đang online
                {
                    notificationLabel.ForeColor = Color.Green;
                    notificationLabel.Text = "Application is Online";
                });

                // Nếu server chưa chạy, thì bắt đầu chạy server
                if (!serverRunning)
                    startServer();
            }
            else  // Nếu mạng không hoạt động
            {
                Invoke((MethodInvoker)delegate  // Cập nhật giao diện để báo hiệu ứng dụng đang offline
                {
                    notificationLabel.ForeColor = Color.Red;
                    notificationLabel.Text = "Application is Offline";
                });
                MessageBox.Show("Not connected to LAN");  // Hiển thị thông báo không kết nối được đến LAN
            }
        }

        // Hàm xử lý sự kiện hoàn thành ping, để tìm máy tính online
        void pingCompletedEvent(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;  // Lấy địa chỉ IP từ trạng thái người dùng
            if (e.Reply.Status == IPStatus.Success)  // Nếu ping thành công (có phản hồi từ máy tính đó)
            {
                string name;
                try
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(ip);  // Lấy thông tin host từ địa chỉ IP
                    name = hostEntry.HostName;  // Lưu tên host
                }
                catch (SocketException ex)  // Nếu có lỗi khi lấy thông tin host
                {
                    name = ex.Message;  // Lưu thông báo lỗi
                }
                Invoke((MethodInvoker)delegate  // Cập nhật giao diện để thêm máy tính online vào danh sách
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ip;  // Đặt địa chỉ IP vào danh sách
                    item.SubItems.Add(name);  // Đặt tên host vào danh sách
                    onlinePCList.Items.Add(item);  // Thêm mục vào danh sách các máy tính online
                });
            }
        }
    }
}
