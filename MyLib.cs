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
        // public static Form1 form1 = null;
        public static Form1 myForm = new Form1();
        public static void AddLog(string logMessage, ListView listview)
        {
            if (listview.InvokeRequired)
            {
                listview.Invoke(new Action(() => AddLog(logMessage, listview)));
            }
            else
            {
                ListViewItem item = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));
                item.SubItems.Add(logMessage);
                listview.Items.Add(item);
            }
        }

    }
}
