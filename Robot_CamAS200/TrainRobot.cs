﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SampleApplication;

namespace WindowsFormsApp4
{
    public partial class Form1
    {
           
      
        
        private async Task TrainVisionPoint()
        {

            double.TryParse(txtX.Text, out double x);
            double.TryParse(txtY.Text, out double y);
            double.TryParse(txtZ2.Text, out double z);
            double.TryParse(txtRx2.Text, out double rx);
            double.TryParse(txtRy2.Text, out double ry);
            double.TryParse(txtRz.Text, out double rz);

            var Feature = cbFeature.Text;

            var command = $"TT,{Feature},{x},{y},{z},{rz},{ry},{rx}";

            await cameraController.SendCommand(command);
            
           
        }

        private async Task TrainRobotPickPlace()
        {
            double.TryParse(txtX.Text, out double x);
            double.TryParse(txtY.Text, out double y);
            double.TryParse(txtZ2.Text, out double z);
            double.TryParse(txtRx2.Text, out double rx);
            double.TryParse(txtRy2.Text, out double ry);
            double.TryParse(txtRz.Text, out double rz);
            string Feature = cbFeature.Text;

            var command = $"TTR,{Feature},{x},{y},{z},{rz},{ry},{rx}";
            await cameraController.SendCommand(command);
        }

        private async void btnTrainVisionPoint_Click(object sender, EventArgs e)
        {
            if (!cameraController.IsConnected)
            {
                MessageBox.Show("Camera not connected");
                return;
            }
            if (cbFeature.SelectedIndex == -1)
            {
                MessageBox.Show("Select features before training", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnTrainVisionPoint.Enabled = false;
            await TrainVisionPoint();
            var DataReceive = await cameraController.ReceiveData();
            if (DataReceive.Contains("TT,1"))
            {
                MessageBox.Show("Train Success", "Thông báo", MessageBoxButtons.OK);
               
            }
            else
            {
                MessageBox.Show("Train Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnTrainVisionPoint.Enabled = true;
        }

        private async void btnTrainPickPlace_Click(object sender, EventArgs e)
        {

            if (!cameraController.IsConnected)
            {
                MessageBox.Show("Camera not connected");
                return;
            }

            if (cbFeature.SelectedIndex == -1)
            {
                MessageBox.Show("Select features before training", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnTrainPickPlace.Enabled = false;
            await TrainRobotPickPlace();

            
            var DataReceive = await cameraController.ReceiveData();
            if (DataReceive.Contains("TTR,1"))
            {
                MessageBox.Show("Train Success", "Thông báo", MessageBoxButtons.OK);
               
               
            }
            else
            {
                MessageBox.Show("Train Fail", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnTrainPickPlace.Enabled = true;

        }

       
        private bool isToolOn = false;
        private bool isRelease = false;

        private async void btnOnOffTool_Click(object sender, EventArgs e)
        {
            if (!robotController.IsConnected)
            {
                MessageBox.Show("Robot chưa kết nối");
                return;
            }

            if (!isToolOn)
            {
                await robotController.SendCommand("OnNha");
                isToolOn = true;
                btnOnOffTool.Text = "OFF Tool";
                btnOnOffTool.BackColor = Color.Red;
            }
            else
            {
                await robotController.SendCommand("OffNha");
                isToolOn = false;
                btnOnOffTool.Text = "ON Tool";
                btnOnOffTool.BackColor = Color.Green;

            }

        }
        private async void btnReleaseTool_Click(object sender, EventArgs e)
        {
            if (!robotController.IsConnected)
            {
                MessageBox.Show("Robot not connected");
                return;
            }

            if (!isRelease)
            {
                await robotController.SendCommand("OnNha");
                isRelease = true;
                btnReleaseTool.Text = "OFF Release";
                btnReleaseTool.BackColor = Color.Red;
            }
            else
            {
                await robotController.SendCommand("OffNha");
                isRelease = false;
                btnReleaseTool.Text = "Release";
                btnReleaseTool.BackColor = Color.Green;

            }
        }

        public event Action<string, Color> TestStatusUpdated;

        private async void btnTestRobot_Click(object sender, EventArgs e)
        {
            if (!cameraController.IsConnected)
            {
                MessageBox.Show("Camera not connected");
                return;
            }
            if (cbFeature.SelectedIndex == -1)
            {
                MessageBox.Show("Select features before Test", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if(!isTT || !isTTR)
            //{
            //    MessageBox.Show("Chưa Train Robot");
            //    return;
            //}    
            var feature = cbFeature.Text;
            var command = $"XT,{feature},1,{x},{y},{z},{rz},{ry},{rx}";
            await cameraController.SendCommand(command);
            var Camrespon = await cameraController.ReceiveData();
           
            if (!Camrespon.Contains("XT,1"))
            {
                lbTestStatus.Text = "Find Feature Fail";
                lbTestStatus.BackColor = Color.Red;
                TestStatusUpdated?.Invoke("Find Feature Fail", Color.Red);
                return;
            }
            TestStatusUpdated?.Invoke("OK", Color.Green);
            lbTestStatus.Text = "OK";
            lbTestStatus.BackColor = Color.Green;
            Camrespon = Camrespon.Substring(5).Replace("\r\n", "");
            Camrespon = ChangeDataFromCamToPosRobot(Camrespon); 
            var CommandPosRobot = $"{Camrespon},{fig}";
            await robotController.SendCommand("TESTPICK");
            await Task.Delay(20);
            await robotController.SendCommand(CommandPosRobot);
        }
    }
}
