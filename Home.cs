using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private string IP = "127.0.0.1";
        TcpListener tcpListener;
        TcpClient tcpClient;
        Socket socketCilent;
    }


    //For starting this program as a server
    //StartServer
    void startServer()
    {
        try
        {
            // Đặt cờ trạng thái server đang chạy
            serverRunning = true;

            // Khởi tạo TcpListener với địa chỉ IP và cổng 11000
            listener = new TcpListener(IPAddress.Parse(IP), 11000);

            // Bắt đầu lắng nghe kết nối đến
            listener.Start();

            // Tạo và bắt đầu một luồng mới để thực hiện các công việc của server
            serverThread = new Thread(new ThreadStart(serverTasks)); 
            serverThread.Start();

            // Đợi cho đến khi luồng server thực sự bắt đầu
            while (!serverThread.IsAlive) ;
        }

            // Hiển thị thông báo lỗi nếu có ngoại lệ
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    //thread: waiting for client request and receiving data two times and resets.
    //ServerTasks
    void serverTasks()
    {
        try
        {
            while (true)
            {
                if (fileReceived == 1)  // Kiểm tra xem đã nhận được file chưa
                {
                    // Hiển thị hộp thoại hỏi người dùng có muốn lưu file không
                    if (MessageBox.Show("Save File?", "File received", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        // Nếu người dùng chọn "Không", xóa file đã lưu tạm
                        File.Delete(savePath);
                        fileReceived = 0;
                    }
                    else
                    {
                        // Nếu người dùng chọn "Có", đặt cờ fileReceived về 0 để tiếp tục nhận file mới
                        fileReceived = 0;
                    }
                }

                client = listener.AcceptTcpClient(); // Chấp nhận kết nối từ client

                // Thực hiện hiển thị thông báo cho người dùng thông qua UI
                Invoke((MethodInvoker)delegate
                {
                    notificationPanel.Visible = true;
                    notificationTempLabel.Text = "File coming..." + "\n" + fileName + "\n" + "From: " + senderIP + " " + senderMachineName;
                    fileNotificationLabel.Text = "File Coming from " + senderIP + " " + senderMachineName;
                });
                isConnected = true; // Đặt cờ trạng thái kết nối
                NetworkStream stream = client.GetStream();  // Nhận dữ liệu từ stream
                if (flag == 1 && isConnected)
                {
                    savePath = savePathLabel.Text + "\\" + fileName;
                    using (var output = File.Create(savePath))
                    {
                        // read the file divided by 1KB
                        var buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, bytesRead);
                        }
                        //MessageBox.Show("ok");
                        flag = 0;
                        client.Close();
                        isConnected = false;
                        fileName = "";
                        Invoke((MethodInvoker)delegate
                        {
                            notificationTempLabel.Text = "";
                            notificationPanel.Visible = false;
                            fileNotificationLabel.Text = "";
                        });
                        fileReceived = 1;
                    }
                }
                else if (flag == 0 && isConnected)
                {
                    Byte[] bytes = new Byte[256];
                    String data = null;
                    int i;
                    // Loop to receive all the data sent by the client.
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    }
                    string[] msg = data.Split('@');
                    fileName = msg[0];
                    senderIP = msg[1];
                    senderMachineName = msg[2];
                    client.Close();
                    isConnected = false;
                    flag = 1;
                }
            }
        }
        catch (Exception)
        {
            //MessageBox.Show(ex.Message);
            flag = 0;
            isConnected = false;
            if (client != null)
                client.Close();
        }
    }

    //MainForm_FormClosing
    private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (serverRunning)
        {
            listener.Stop();
            if (serverThread != null)
            {
                serverThread.Abort();
                serverThread.Join();
            }

        }
    }


    //StopButton_Click
    private void stopButton_Click(object sender, EventArgs e)
    {
        if (serverRunning)
        {
            serverRunning = false;
            onlinePCList.Items.Clear();
            if (listener != null)
                listener.Stop();
            if (serverThread != null)
            {
                serverThread.Abort();
                serverThread.Join();
            }

            notificationLabel.ForeColor = Color.Red;
            notificationLabel.Text = "Application is Offline";
            infoLabel.Text = "";
            fileNameLabel.Text = ".";
        }
    }
                            // Kiểm tra trạng thái và kết nối
                        if (flag == 1 && isConnected)
                        {
                            // Đường dẫn lưu file
                            savePath = savePathLabel.Text + "\\" + fileName;

                            // Lưu dữ liệu nhận được vào file
                            using (var output = File.Create(savePath))
                            {
                                var buffer = new byte[1024];
    int bytesRead;

                                // Ghi dữ liệu vào file
                                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    output.Write(buffer, 0, bytesRead);
                                }

// Đặt lại cờ trạng thái và đóng kết nối
flag = 0;
client.Close();
isConnected = false;
fileName = "";

// Cập nhật UI thông báo hoàn tất
Invoke((MethodInvoker)delegate
{
    notificationTempLabel.Text = "";
    notificationPanel.Visible = false;
    fileNotificationLabel.Text = "";
});

// Đánh dấu file đã nhận
fileReceived = 1;
                            }
                        }
                        else if (flag == 0 && isConnected)
{
    // Đọc tên file và thông tin người gửi
    Byte[] bytes = new Byte[256];
    String data = null;
    int i;

    // Nhận dữ liệu từ client
    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
    {
        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
    }

    // Phân tích dữ liệu nhận được
    string[] msg = data.Split('@');
    fileName = msg[0];
    senderIP = msg[1];
    senderMachineName = msg[2];

    // Đóng kết nối và đặt cờ trạng thái
    client.Close();
    isConnected = false;
    flag = 1;
}
                    }
                }
                catch (Exception)
                {
    // Xử lý ngoại lệ và đặt lại cờ trạng thái
    flag = 0;
    isConnected = false;

    // Đóng kết nối nếu có lỗi
    if (client != null)
        client.Close();
}
            }

            // Xử lý khi Form đóng
            private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
{
    if (serverRunning)
    {
        listener.Stop();

        if (serverThread != null)
        {
            serverThread.Abort();
            serverThread.Join();
        }
    }
}

// Xử lý khi nhấn nút Stop
private void stopButton_Click(object sender, EventArgs e)
{
    if (serverRunning)
    {
        serverRunning = false;

        // Xóa danh sách máy tính trực tuyến
        onlinePCList.Items.Clear();

        if (listener != null)
            listener.Stop();

        if (serverThread != null)
        {
            serverThread.Abort();
            serverThread.Join();
        }

        // Cập nhật trạng thái server
        notificationLabel.ForeColor = Color.Red;
        notificationLabel.Text = "Ứng dụng đang Offline";
        infoLabel.Text = "";
        fileNameLabel.Text = ".";
    }
}
        }
}
