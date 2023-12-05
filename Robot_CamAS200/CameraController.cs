using AS200_RobotDenso_Control;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace WindowsFormsApp4
{
    public class CameraController
    {
        private static CameraController _instance;
        private static readonly object _lock = new object();
        public static CameraController GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new CameraController();
                    }
                }
            }
            return _instance;
        }
        SimpleTcpClient camClient;
        bool isConnected;
        string data;
        CameraController()
        {
            camClient = new SimpleTcpClient("192.168.0.102:5001");
            // set events
            camClient.Events.Connected += Connected;
            camClient.Events.Disconnected += Disconnected;
            camClient.Events.DataReceived += DataReceived;

            isConnected = false;
            data = String.Empty;
        }
         void Connected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} connected");
            isConnected = true;
        }

        void Disconnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} disconnected");
            isConnected = false;
        }

        void DataReceived(object sender, SuperSimpleTcp.DataReceivedEventArgs e)
        {
            if(e.Data != null)
            {
                data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
                Console.WriteLine($"[{e.IpPort}] {data}");
            }
            else
            {
                Console.WriteLine("data null");
                return;
            }
        }
        public void SendData(string data)
        {
            try
            {
                camClient.Send(data + "\r\n");
                MyLib.AddLogAuto(data, eDevice.Cam);
                Console.WriteLine($"send data to client");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string GetData()
        {
            MyLib.AddLogAuto(data,eDevice.Cam);
            return data;
        }
        public void ClearData()
        {
            data = String.Empty;

        }

        public bool Connect()
        {
            try
            {
                camClient.ConnectWithRetries(10000); // try for up to 10000 milliseconds

            }
            catch (Exception ex)
            {
                isConnected = false;
                
            }
            return isConnected;
        }

        public bool Disconnect()
        {
            camClient?.Disconnect();
            return true;
        }

        public bool IsConnected()
        {
            return isConnected;
        }


        //private TcpClient cameraClient;
        //public TextBox TextReceivedData { get; set; }
        //public bool IsConnected { get { return cameraClient != null && cameraClient.Connected; } }

        //public void ConnectCamera(string ipAddress, int port)
        //{
        //    try
        //    {
        //        if (!IsConnected)
        //        {
        //            cameraClient = new TcpClient();
        //            cameraClient.Connect(ipAddress, port);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can n't connect Cam . Error: " + ex.Message);

        //    }
        //}

        //public void DisconnectCamera()
        //{
        //    if (IsConnected)
        //    {
        //        cameraClient.Close();
        //        cameraClient = null;

        //    }

        //}

        //public async Task SendCommand(string command)
        //{
        //    if (!IsConnected)
        //    { 
        //        MessageBox.Show("Camera not connected !");
        //        return; 
        //    }
        //        try
        //        {
        //            string commandWithNewLine = command + "\r\n";
        //            byte[] dataCam = Encoding.ASCII.GetBytes(commandWithNewLine);
        //            TextReceivedData.Invoke((MethodInvoker)(() =>
        //            {
        //                TextReceivedData.AppendText(">>>> Camera: " + commandWithNewLine + Environment.NewLine);
        //            }));
        //        MyLib.AddLogAuto(commandWithNewLine, eDevice.Cam);
        //            await cameraClient.GetStream().WriteAsync(dataCam, 0, dataCam.Length);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Can n't send command to Cam. Error: " + ex.Message);
        //        }


        //}

        //public async Task<string> ReceiveData()
        //{
        //    if (IsConnected)
        //    {
        //        try
        //        {
        //            StringBuilder dataBuilder = new StringBuilder();
        //            byte[] buffer = new byte[1024];

        //            int bytesReadCam = await cameraClient.GetStream().ReadAsync(buffer, 0, buffer.Length);
        //            Console.WriteLine("bytesReadCam = " + bytesReadCam);
        //            if (bytesReadCam > 0)
        //            {
        //                string receivedDataCam = Encoding.ASCII.GetString(buffer, 0, bytesReadCam);
        //                dataBuilder.Append(receivedDataCam);

        //                TextReceivedData.Invoke((MethodInvoker)(() =>
        //                {
        //                    TextReceivedData.AppendText("<<<< Camera: " + receivedDataCam + Environment.NewLine);
        //                }));
        //                MyLib.AddLogAuto(receivedDataCam, eDevice.Cam);

        //                return receivedDataCam;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Can n't received data Cam. Error:  " + ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Camera not connected!");
        //    }

        //    return string.Empty;
        //}
    }
}
