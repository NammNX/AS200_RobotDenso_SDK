using System;
using System.Collections.Generic;
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

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss:ffff");

        }
        //public static void ShowLogListview(ListView listview, string message)
        //{
        //    if (listview.InvokeRequired)
        //    {
        //        listview.BeginInvoke(new Action(() =>
        //        {
        //            if (listview.Items.Count >= 1000)
        //            {
        //                listview.Items.Clear();
        //            }

        //            listview.Items.Insert(0,
        //                new ListViewItem(new string[] { MyLib.GetTimestamp(DateTime.Now), $"{message}" }));
        //        }));
        //    }
        //    else
        //    {
        //        if (listview.Items.Count >= 1000)
        //        {
        //            listview.Items.Clear();
        //        }

        //        listview.Items.Insert(0,
        //                new ListViewItem(new string[] { MyLib.GetTimestamp(DateTime.Now), $"{message}" }));
        //    }
        //}
        public static void ShowLogListview(ListView listView, string message)
        {
            if (listView.InvokeRequired)
            {
                listView.BeginInvoke(new Action(() =>
                {
                    UpdateListView(listView, message);
                }));
            }
            else
            {
                UpdateListView(listView, message);
            }
        }

        private static void UpdateListView(ListView listView, string message)
        {
            if (listView.Items.Count >= 1000)
            {
                listView.Items.Clear();
            }

            ListViewItem logItem = new ListViewItem(new string[] { MyLib.GetTimestamp(DateTime.Now), message });
            listView.Items.Insert(0, logItem);
        }

        public static void AddLogAuto(string message, eDevice index = eDevice.Robot)
        {
            
            //if (!MyParam.autoForm.IsHandleCreated) return;
            switch (index)
            {
                case eDevice.Robot:
                    ShowLogListview(form1.lvLogRobot, message);
                    break;

                case eDevice.Cam:
                    ShowLogListview(form1.lvCam, message);
                    break;
                default:
                    break;
            }


        }
    }
}
