using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace AS200_RobotDenso_Control
{
    public enum eDevice
    {
        Robot,
        Cam

    }
    public static class MyLib
    {
        public static Form1 form1 = null;

        static MyLib()
        {
            form1 = Form1.GetInstance();
        }
        public static void ShowLog(string logMessage, ListView listview)
        {
            if (listview.InvokeRequired)
            {
                listview.Invoke(new Action(() => ShowLog(logMessage, listview)));
            }
            else
            {
                ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                item.SubItems.Add(logMessage);
                listview.Items.Add(item);
                listview.Update();
                Debug.WriteLine(logMessage);
            }
        }

        public static void AddLogAuto(string message, eDevice index = eDevice.Robot)
        {
            // Make sure the form and controls are created before attempting to update them
            if (form1 != null && form1.IsHandleCreated)
            {
                switch (index)
                {
                    case eDevice.Robot:
                        ShowLog(message, form1.lvLog);
                        break;

                    case eDevice.Cam:
                        ShowLog(message, form1.lvCam);
                        break;
                }
            }
            else
            {
                Debug.WriteLine("Form or controls not created.");
            }
        }
      
    }
}
