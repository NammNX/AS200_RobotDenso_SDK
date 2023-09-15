using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1
    {
        private async Task MouseUpPos()
        {
            await robotController.SendCommand("OK");
            await UpdateCurrentPos();
            UpdateUIComponents();

        }
        private async void HandleXYZButton(Button button, string command)
        {
            await robotController.SendCommand(command);
        }
        private void AssignXYZButton(Button button, string command)
        {
            button.MouseDown += (sender, e) => HandleXYZButton(button, command);
            button.MouseUp += async (sender, e) => await MouseUpPos();
        }

        private void RegisterXYZButton()
        {
            AssignXYZButton(btnXup, "X+");
            AssignXYZButton(btnXdown, "X-");
            AssignXYZButton(btnYup, "Y+");
            AssignXYZButton(btnYdown, "Y-");
            AssignXYZButton(btnZup, "Z+");
            AssignXYZButton(btnZdown, "Z-");
            AssignXYZButton(btnRzup, "RZ+");
            AssignXYZButton(btnRzdown, "RZ-");
        }

      
    }

}
