using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;//Pingreply

namespace ProjectNhom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private string IP = "127.0.0.1";
        TcpListener listener;
        TcpClient client;
        Socket socketForClient;

        private Thread FindPC;
        private Thread ServerThread;

        private bool ServerRunning = false;// Biến kiểm tra trạng thái hoạt động của server
        private bool isConnected = false;//Biến kiểm tra kết nối

        string TargetIP;
        string TargetName;
        string SenderIP;
        string SenderMachineName;
        string SavePath;
        string FileName = "";

        int flag = 0;
        int FileReceived = 0;//biến để xác định có file nào gửi đến không

        private void listPConline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //StartServer
        void startServer()
        {
            try
            {
                // Đặt cờ trạng thái server đang chạy
                ServerRunning = true;
                // Khởi tạo TcpListener với địa chỉ IP và cổng 11000
                listener = new TcpListener(IPAddress.Parse(IP), 11000);
                // Bắt đầu lắng nghe kết nối đến
                listener.Start();
                // Tạo và bắt đầu một luồng mới để thực hiện các công việc của server
                ServerThread = new Thread(new ThreadStart(serverTasks));
                ServerThread.Start();
                // Đợi cho đến khi luồng server thực sự bắt đầu
                while (!ServerThread.IsAlive) ;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //ServerTasks
        void serverTasks()
        {
            try
            {
                while (true)
                {
                    if (FileReceived == 1)  // Kiểm tra xem đã nhận được file chưa
                    {
                        // Hiển thị hộp thoại hỏi người dùng có muốn lưu file không
                        if (MessageBox.Show("Save File?", "File received", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            // Nếu người dùng chọn "Không", xóa file đã lưu tạm
                            File.Delete(SavePath);
                            FileReceived = 0;
                        }
                        else
                        {
                            // Nếu người dùng chọn "Có", đặt cờ fileReceived về 0 để tiếp tục nhận file mới
                            FileReceived = 0;
                        }
                    }
                    client = listener.AcceptTcpClient(); // Chấp nhận kết nối từ client
                                                         // Thực hiện hiển thị thông báo cho người dùng thông qua UI
                    Invoke((MethodInvoker)delegate
                    {
                        NotificationFileSending.Text = "File Coming from " + SenderIP + " " + SenderMachineName;
                    });
                    isConnected = true; // Đặt cờ trạng thái kết nối
                    NetworkStream stream = client.GetStream();  // Nhận dữ liệu từ stream
                    if (flag == 1 && isConnected)//flag = 1 và kết nối đang mở thì:
                    {
                        SavePath = SaveFileLabel.Text + "\\" + FileName;//xác định đường dẫn để lưu file
                        using (var output = File.Create(SavePath))//tạo file mới để lưu dữ liệu
                        {
                            // read the file divided by 1KB
                            var buffer = new byte[1024];//tạo buffer 1KB
                            int bytesRead;//biến lưu số byte đã đọc
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)//tiến hành đọc dữ liệu từ stream
                            {
                                output.Write(buffer, 0, bytesRead);//ghi dữ liệu vào file
                            }
                            flag = 0;//reset lại cờ = 0
                            client.Close();
                            isConnected = false;//reset lại trạng thái chưa kết nối
                            FileName = "";//xóa tên file 
                            Invoke((MethodInvoker)delegate//cập nhật UI
                            {
                                NotificationFileSending.Text = "";//xóa thông báo
                            });
                            FileReceived = 1;
                        }
                    }
                    else if (flag == 0 && isConnected)//flag = 0 và kết nối đang mở
                    {
                        Byte[] bytes = new Byte[256];//tạo buffer 256 byte để nhận dữ liệu
                        String data = "";//chuỗi lưu dữ liệu đã nhận
                        int i;
                        // Vòng lặp nhận dữ liệu từ client
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)//đọc dữ liệu từ strean
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);//chuyển đổi dữ liệu thành chuỗi
                        }
                        string[] msg = data.Split('@');
                        FileName = msg[0];//lấy tên file
                        SenderIP = msg[1];//lấy tên địa chỉ IP người gửi
                        SenderMachineName = msg[2];//lấy tên máy người gửi
                        client.Close();
                        isConnected = false;
                        flag = 1;
                    }
                }
            }
            catch (Exception)
            {
                flag = 0;
                isConnected = false;
                if (client != null)
                    client.Close();
            }
        }


        //Địa chỉ lưu trữ file khi nhận được file
        private void btn_FileLocation_Click(object sender, EventArgs e)
        {
            //địa chỉ lưu file sẽ được cập nhật
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string SavePath = folderBrowserDialog.SelectedPath;
                SaveFileLabel.Text = SavePath;//hiển thị địa chỉ lưu file mới
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            //Reset giá trị IP và tên máy đã chọn
            TargetIP = "";
            TargetName = "";
            //Kiểm tra điều kiện để gửi file
            //File đã được mở và (có máy tính đã được chọn hoặc IP đã được nhập) và server đang chạy
            if (FileNameLabel.Text != "." && (listPConline.SelectedIndices.Count > 0 || textBox_IP.Text != "") && ServerRunning)
            {
                // Nếu ô nhập IP không trống, sử dụng IP từ ô nhập
                if (textBox_IP.Text != "")
                {
                    TargetIP = textBox_IP.Text;
                    TargetName = "";// Không có tên máy nếu nhập IP thủ công
                }
                else
                {
                    // Nếu chọn từ danh sách các máy online, lấy IP và tên máy từ danh sách
                    TargetIP = listPConline.SelectedItems[0].Text;
                    TargetName = listPConline.SelectedItems[0].SubItems[1].Text;
                }
                try
                {
                    // Ping kiểm tra xem máy đã chọn có hoạt động không
                    Ping p = new Ping();
                    PingReply r;
                    r = p.Send(TargetIP);
                    if (!(r.Status == IPStatus.Success))
                    {
                        // Nếu không thành công, hiển thị thông báo lỗi
                        MessageBox.Show("Target computer is not available.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Hiển thị thông báo đang gửi file
                        NotificationFileSending.Text = "Please don't do other tasks. File sending to " + TargetIP + " " + TargetName + "...";

                        //Đóng server
                        listener.Stop();

                        ServerThread.Join();
                        ServerRunning = false;

                        // Chuyển chương trình thành client để gửi file
                        socketForClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socketForClient.Connect(new IPEndPoint(IPAddress.Parse(TargetIP), 11000));

                        // Gửi tên file cùng với thông tin IP và tên máy gửi
                        string fileName = FileNameLabel.Tag.ToString();
                        byte[] fileNameData = Encoding.Default.GetBytes(fileName + "@" + this.IP + "@" + Environment.MachineName);
                        socketForClient.Send(fileNameData);

                        // Đóng kết nối và khởi tạo kết nối mới để gửi file
                        socketForClient.Shutdown(SocketShutdown.Both);
                        socketForClient.Close();
                        socketForClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socketForClient.Connect(new IPEndPoint(IPAddress.Parse(TargetIP), 11000));
                        socketForClient.SendFile(FileNameLabel.Text);

                        // Đóng kết nối sau khi gửi xong
                        socketForClient.Shutdown(SocketShutdown.Both);
                        socketForClient.Close();

                        // Thêm tên file vào ListBox sau khi gửi thành công
                        ListFileSent.Items.Add(Path.GetFileName(FileNameLabel.Text));

                        // Hiển thị thông báo đã gửi file thành công
                        MessageBox.Show("File sent to " + TargetIP + " " + TargetName, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (socketForClient != null)
                    {
                        socketForClient.Shutdown(SocketShutdown.Both);
                        socketForClient.Close();
                    }
                }
                finally
                {
                    // Bỏ chọn các máy tính trong danh sách đã chọn
                    for (int i = 0; i < listPConline.SelectedIndices.Count; i++)
                    {
                        listPConline.Items[this.listPConline.SelectedIndices[i]].Selected = false;
                    }
                    // Đặt lại thông báo về trạng thái ban đầu
                    NotificationFileSending.Text = ".";
                    // Chuyển chương trình lại thành server
                    startServer();
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (ServerRunning)
            {
                ServerRunning = false;
                listPConline.Items.Clear();
                if (listener != null)
                    listener.Stop();
                if (ServerThread != null)
                {

                    ServerThread.Join();
                }

                NotificationLabel.ForeColor = Color.Red;
                NotificationLabel.Text = "Application is Offline";
                InfoLabel.Text = "";
                FileNameLabel.Text = ".";
            }
        }
        //Hiển thị thông báo ứng dụng đang offline
        private void Home_Load(object sender, EventArgs e)
        {
            NotificationLabel.ForeColor = Color.Red;
            NotificationLabel.Text = "Application is offline";
        }

        //Nút để mở file( chọn 1 file từ máy )
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "Select a File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileNameLabel.Text = openFileDialog1.FileName;  //Đường dẫn file
                FileNameLabel.Tag = openFileDialog1.SafeFileName; //tên file
            }
        }
        // Hàm xử lý sự kiện ping, để tìm máy tính online
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
                    listPConline.Items.Add(item);  // Thêm mục vào danh sách các máy tính online
                });
            }
        }
        void SearchPC()  // Hàm tìm kiếm các máy tính trong mạng LAN
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
                    InfoLabel.Text = "My IP: " + this.IP;
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
                    NotificationLabel.ForeColor = Color.Green;
                    NotificationLabel.Text = "Application is Online";
                });

                // Nếu server chưa chạy, thì bắt đầu chạy server
                if (!ServerRunning)
                    startServer();
            }
            else  // Nếu mạng không hoạt động
            {
                Invoke((MethodInvoker)delegate  // Cập nhật giao diện để báo hiệu ứng dụng đang offline
                {
                    NotificationLabel.ForeColor = Color.Red;
                    NotificationLabel.Text = "Application is Offline";
                });
                MessageBox.Show("Not connected to LAN");  // Hiển thị thông báo không kết nối được đến LAN
            }
        }


        //Nút Find/Start để khởi động và tìm kiếm máy online
        private void btn_Find_Click(object sender, EventArgs e)
        {
            //Khởi động
            //Clear ô địa chỉ IP
            textBox_IP.Text = "";
            //Clear danh sách các PC đang online
            listPConline.Items.Clear();
            //Hiển thị thông báo đang tìm máy có cùng mạng
            NotificationLabel.ForeColor = Color.Green;
            NotificationLabel.Text = "Finding...";
            //Tìm kiếm máy
            try
            {
                FindPC = new Thread(new ThreadStart(SearchPC));//luồng mới FindPC được tạo ra để chạy phương thức SearchPC
                FindPC.Start();//bắt đầu luồng FindPC
                while (!FindPC.IsAlive) ;//true nếu luồng chưa bắt đầu chạy
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_ReceiverIP_TextChanged(object sender, EventArgs e)
        {

        }

        //Nút bỏ file đã mở (clear)
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            FileNameLabel.Text = ".";
        }

        private void NotificationLabel_Click(object sender, EventArgs e)
        {

        }

        private void ListFileSent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
