﻿using System;
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

    