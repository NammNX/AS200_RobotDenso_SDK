using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;         // for CancellationTokenSource
using System.Windows.Forms;
using System.Net;               // for IPAddress
using System.Diagnostics;
using Cognex.AlignmentSDK;
using Cognex.AlignmentSDK.Interfaces;
using Cognex.AlignmentSDK.Enumerations;
using Cognex.AlignmentSDK.Classes.Settings;
using Cognex.AlignmentSDK.Exceptions;

namespace WindowsFormsApp4
{
    public partial class Form1
    {
        IAlignSystemManager mAlignSystemManager = new AlignSystemManager();
        IAlignSystem mCurrentSystem = null;
        IAlignCamera mCamera1 = null;
        IAlignCamera mCamera2 = null;
        IAlignCameraCheckerboardCalibration mChecker = null;
        IAlignCameraFeature mFeature = null;
        IAlignCameraFeaturePatternSetting mPatSetting = null;
        IAlignCameraDisplay mCamDisp1 = null;
        IAlignCameraDisplay mCamDisp2 = null;
        IAlignCameraAutoExposureService mExpService1 = null;
        Button activeButton = null;        // to pass to Handler
        Label statusLabel = null;        // to pass to Handler

        
        private void btnConnectDisplay_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            try
            {
                mCurrentSystem = AlignSystemFactory.Create(IPAddress.Parse(txtCamIp.Text));
            }
            catch (ArgumentException ex)           //"The provided IP Address could not be resolved."
            {
                lvCam.Text = "Error : " + ex.Message;
                return;
            }
            catch (Cognex.AlignmentSDK.Exceptions.AlreadyConnectedException ex)
            {
                lvCam.Text = "Error : " + ex.Message;
                return;
            }
            catch (Exception ex)
            {
                lvCam.Text = "Error : " + ex.Message;
                return;
            }
            initForChangedSystem();
            ((Button)sender).BackColor = Color.Lime;
        }
        private void btnDisConnectDisplay_Click(object sender, EventArgs e)
        {
            if (mCurrentSystem != null)
            mCurrentSystem.Disconnect();
            mCurrentSystem = null;
        }
        private void initForChangedSystem()
        {
            if (mCurrentSystem?.IsConnected ?? true)    //when Selected Current System is notconnected
            {
                return;
            }

            // Update Movable Origin Info
            var sysSetting = mCurrentSystem.GetAlignSystemSettings();

            // Setup for Cameras, Displays, Features ---------------------------------------------
            //     Recipe is always exists.
            if (mCurrentSystem != null)
            {
                alignSystemDisplay.SetAlignSystem(mCurrentSystem);
            }


            mCamera1 = mCurrentSystem.Cameras[0];
            mCamDisp1 = alignSystemDisplay?.GetSubDisplay(mCamera1);
            // mCamDisp1.FileName = txtFileName.Text;


        }
    }
}
