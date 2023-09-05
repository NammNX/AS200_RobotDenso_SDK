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
using WindowsFormsApp4;

namespace SampleApplication
{
    public partial class MainForm : Form
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
        private Form1 form1Instance;


        #region Constructor *********************************************************************
        public MainForm()
        {
            InitializeComponent();
            form1Instance = new Form1();
            form1Instance.TopLevel = false;
            toolStripStatusLabelStatus.Text = "";

            // Disable tabs before the current sensor is set
            tabSysSetup.Enabled = false;
            tabRecipeMgmt.Enabled = false;
            tabRecipeSettings.Enabled = false;
            tabCtrlOnDisp.Enabled = false;
            tabExposure.Enabled = false;

            tabFeature.Enabled = false;




            comboBox_NewRecipeMode.SelectedIndex = 0;
        }
        #endregion    // Constructor

        #region Handler ************************************************************************
        // Return the color of the buttonn after edit region is completed.
        private void Handler_EditRegionCompleted(object sender, IEditRegionCompletedInfo e)
        {
            activeButton.BackColor = Color.Lime;
        }

        private void Handler_EditAutoExpRegionCompleted(object sender, IEditRegionCompletedInfo e)
        {
            activeButton.BackColor = Color.Lime;
        }

        private void Handler_AutoExposureFinished(object sender, IAutoExposureResult e)
        {
            if (e.Error)
                statusLabel.Text = "Error: " + e.ErrorMessage;
            else if (e.ManuallyCancelled)
                statusLabel.Text = "Manually Cancelled";
            else
                statusLabel.Text = "Finished";

            updateExposureTab_Cam1();
        }

        private void Handler_CalibrationStatusChanged(object sender, bool e)  //This is fired by Calibrate(), UnCalibrate()
        {
            if (InvokeRequired)       //When called from another thread
            {
                this.Invoke(new MethodInvoker(() => Handler_CalibrationStatusChanged(sender, e)));
                return;
            }

            statusLabel.Text = mChecker.IsCalibrated ? "Calibrated" : "UnCalibrated";
        }

        private void Handler_CalibrationStarted(object sender, EventArgs e)     //This is fired by Calibrate()
        {
            activeButton.BackColor = Color.Red;
        }

        private void Handler_CalibrationFinished(object sender, string e)     //This is fired by Calibrate()
        {
            activeButton.BackColor = Color.Lime;
            if (e != "")
                MessageBox.Show("Error: " + e);
        }

        private void Handler_EditCheckerCalibRegionCompleted(object sender, IEditRegionCompletedInfo e)
        {
            activeButton.BackColor = Color.Lime;
        }

        #endregion    // Handler



        #region Misc Button ********************************************************************
        private void btn_Cam1AcqImage_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCamera1?.Acquire();              // current selected exposure setting is used.
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_Cam2AcqImage_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCamera2?.Acquire();
            ((Button)sender).BackColor = Color.Lime;
        }

        // Buttons for any function, test etc

        private void btn_Auxiliary1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            // Put any code for your purpose

            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_Auxiliary2_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            // Put any code for your purpose

            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_Auxiliary3_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            // Put any code for your purpose

            ((Button)sender).BackColor = Color.Lime;
        }

        #endregion

        #region Helper Functions for System Management ******************************************
        // Initialize after system is changed.
        private void initForChangedSystem()
        {
            if (mCurrentSystem?.IsConnected ?? false)    //when Selected Current System is connected
            {
                tabSysSetup.Enabled = true;
                tabRecipeMgmt.Enabled = true;
                tabRecipeSettings.Enabled = true;
                tabCtrlOnDisp.Enabled = true;
                tabExposure.Enabled = true;

                tabFeature.Enabled = true;



            }
            else
            {
                tabSysSetup.Enabled = false;
                tabRecipeMgmt.Enabled = false;
                tabRecipeSettings.Enabled = false;
                tabCtrlOnDisp.Enabled = false;
                tabExposure.Enabled = false;

                tabFeature.Enabled = false;



                return;
            }

            // Update Movable Origin Info
            var sysSetting = mCurrentSystem.GetAlignSystemSettings();

            // Setup for Cameras, Displays, Features ---------------------------------------------
            //     Recipe is always exists.
            if (mCurrentSystem != null)
            {
                alignSystemDisplay.SetAlignSystem(mCurrentSystem);
                alignSystemDisplay.BindRegionAcceptChanges(btn_Accept, "Enabled", "Click");
                alignSystemDisplay.BindRegionCancelChanges(btn_Cancel, "Enabled", "Click");
            }

            mCamera1 = mCurrentSystem.Cameras[0];
            mCamDisp1 = alignSystemDisplay?.GetSubDisplay(mCamera1);
            mCamDisp1.FileName = txtFileName.Text;

            if (mCurrentSystem.Cameras.Count == 2)
            {
                mCamera2 = mCurrentSystem.Cameras[1];
                mCamDisp2 = alignSystemDisplay.GetSubDisplay(mCamera2);
                btn_Cam2AcqImage.Visible = true;
                gBox_CtrlOnDisp_Cam2.Enabled = true;
                updateCtrlOnDisp_Cam2();
            }
            else
            {
                btn_Cam2AcqImage.Visible = false;
                gBox_CtrlOnDisp_Cam2.Enabled = false;
            }


            btn_PatternOrigin.Visible = sysSetting.UseMoveableOrigin;

            // Update Recipe Tab
            updateCurretRecipeInfo();
            updateRecipeList();

            // Update Other Tabs
            // Update of Ctrl on Disp tab for Cam1 is not required. alignSystemDisplay keeps settings.
            updateSystemSettingsTab();
            updateExposureTab();
            updateCheckerTab(1);
            updateFeatureTab(1, 1);     // (need to be after recipe setting) Here, show feature setting for CamID=1, Feature ID = 1




        }

        private void show_CurrentSystem_onHMI()
        {
            lbl_CurrSystemName.Text = mCurrentSystem?.Name ?? "";
            lbl_CurrSystemDescription.Text = mCurrentSystem?.Description ?? "";
            icon_Connected.BackColor = (bool)(mCurrentSystem?.IsConnected ?? false) ? Color.Blue : Color.WhiteSmoke;
            toolStripStatusLabelStatus.Text = (bool)(mCurrentSystem?.IsConnected ?? false) ? "Current System is set" : "Current System is disconnected";
            toolStripStatusLabelVersion.Text = "Version : " + ((bool)(mCurrentSystem?.IsConnected ?? false) ? mCurrentSystem.SelectedRecipeVersion : "");
        }

        private void show_SelectedCamNetInfo_onHMI()
        {
            var selectedCamNetInfo = get1stSelectedCamNetInfo();
            if (selectedCamNetInfo != null)
            {
                if (list_Cameras.SelectedItems[0].Group.Name == list_Cameras.Groups[0].Name)
                {
                    gBox_SelectedCamNetInfo.Enabled = false;
                    btn_ChangeCamNetInfo.BackColor = Color.Transparent;
                }
                else
                {
                    gBox_SelectedCamNetInfo.Enabled = true;
                    btn_ChangeCamNetInfo.BackColor = Color.Lime;
                }
            }
            else
            {
                gBox_SelectedCamNetInfo.Enabled = false;
                btn_ChangeCamNetInfo.BackColor = Color.Transparent;
            }

            txtBox_SelectedCamName.Text = selectedCamNetInfo?.Name ?? "";
            txtBox_SelectedCamMACAdd.Text = selectedCamNetInfo?.MACAddress ?? "";
            txtBox_SelectedCamIPAdd.Text = selectedCamNetInfo?.IPAddress.ToString() ?? "";
            txtBox_SelectedCamSubMask.Text = selectedCamNetInfo?.SubnetMask.ToString() ?? "";
            txtBox_SelectedCamDomainName.Text = selectedCamNetInfo?.Domain.ToString() ?? "";

            txtBox_SelectedCamDNS.Text = selectedCamNetInfo?.DNS.ToString() ?? "";
            txtBox_SelectedCamGateway.Text = selectedCamNetInfo?.Gateway.ToString() ?? "";
            checkBox_IsDHCP.Checked = (bool)(selectedCamNetInfo?.IsDHCP ?? false);
        }

        // Return network info of the selected camera (upper one if multiples are selected) on the camera list
        private ICameraNetworkInfo get1stSelectedCamNetInfo()
        {
            if (list_Cameras.SelectedItems.Count == 0)
                return null;
            else if (list_Cameras.SelectedItems[0].Group.Name == list_Cameras.Groups[0].Name)         //Group[0]=Configured    Need to be connected to show Camera Name on the Camera List
            {
                foreach (var alignSystem in mAlignSystemManager.AlignSystems)
                {
                    foreach (var camera in alignSystem.Cameras)
                    {
                        var camNetInfo = camera.CameraNetworkInfo;
                        if (camNetInfo.Name == list_Cameras.SelectedItems[0].Text)        // If not connected, SelectedItems[0].Text = ""
                            return camNetInfo;
                    }
                }
                return null;
            }
            else if (list_Cameras.SelectedItems[0].Group.Name == list_Cameras.Groups[1].Name)
                return mAlignSystemManager.GetUnusedCameraInfos().Where(camInfo => camInfo.Name == list_Cameras.SelectedItems[0].Text).FirstOrDefault();
            else
                return mAlignSystemManager.GetMisconfiguredCameraInfos().Where(camInfo => camInfo.Name == list_Cameras.SelectedItems[0].Text).FirstOrDefault();
        }

        private IAlignSystem get1stSelectedAlignSystem()
        {
            if (list_Cameras.SelectedItems.Count == 0)
                return null;
            else if (list_Cameras.SelectedItems[0].Group.Name == list_Cameras.Groups[0].Name)
            {
                foreach (var alignSystem in mAlignSystemManager.AlignSystems)
                {
                    if (alignSystem.Name == list_Cameras.SelectedItems[0].SubItems[2].Text)
                        return alignSystem;
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "Selected Camera is not configured.";
            }
            return null;
        }

        private void updateConfiguredCameraList()
        {
            foreach (ListViewItem item in list_Cameras.Items)
            {
                if (item.Group.Name == list_Cameras.Groups[0].Name)
                {
                    list_Cameras.Items.Remove(item);
                }
            }

            foreach (var alignSystem in mAlignSystemManager.AlignSystems)
            {
                if (alignSystem.IsConnected)
                {
                    foreach (var camera in alignSystem.Cameras)
                    {
                        var nameCam = camera.Name;
                        var ip = camera.IPAddress.ToString();
                        var nameSys = alignSystem.Name;
                        var isMaster = (camera.IsMaster) ? "X" : "";
                        var isConnected = (alignSystem.IsConnected) ? "X" : "";
                        var isCurrent = (alignSystem == mCurrentSystem) ? "X" : "";
                        var modelNumber = camera.ModelNumber;

                        ListViewItem lvi = new ListViewItem(new string[] { nameCam, ip, nameSys, isMaster, isConnected, isCurrent, modelNumber });
                        lvi.ForeColor = Color.Gray;
                        lvi.Group = list_Cameras.Groups[0];
                        list_Cameras.Items.Add(lvi);
                    }
                }
                else
                {
                    var nameSys = alignSystem.Name;
                    var isCurrent = (alignSystem == mCurrentSystem) ? "X" : "";
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", nameSys, "", "", isCurrent });
                    lvi.ForeColor = Color.Gray;
                    lvi.Group = list_Cameras.Groups[0];
                    list_Cameras.Items.Add(lvi);
                }
            }
        }
        #endregion     // Helper Functions for System Management

        #region System Management ***************************************************************
        // Change the default parent folder for template and recipe date (C:\ProgramData\Cognex)
        // Under the specified folder, \AlignSight\[version]\RecipeConfiguration,Template
        private void chkUseSpecialInternalDataFolder_CheckedChanged(object sender, EventArgs e)
        {
            mAlignSystemManager.UseSpecialInternalDataFolder = ((CheckBox)sender).Checked;
            //mCurrentSystem.UseSpecialInternalDataFolder = ((CheckBox)sender).Checked;             //in case to set from AlignSystem
        }

        private void txtSpecialInternalDataFolder_TextChanged(object sender, EventArgs e)
        {
            mAlignSystemManager.SpecialinternalDataFolderPath = txtSpecialInternalDataFolder.Text;
            //mCurrentSystem.SpecialinternalDataFolderPath = txtSpecialInternalDataFolder.Text;      //in case to set from AlignSystem
        }

        private void btn_Update_CamList_CurrSysInfo_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            list_Cameras.Items.Clear();
            //Searches the network and refreshes UnusedCameraInfos / MisconfiguredCameraInfos / AlignSystems lists 
            mAlignSystemManager.RefreshCameraLists();

            // Update Current System information
            mCurrentSystem = mAlignSystemManager.SelectedAlignSystem;
            show_CurrentSystem_onHMI();

            updateConfiguredCameraList();

            foreach (var camInfo in mAlignSystemManager.GetUnusedCameraInfos())
            {
                var name = camInfo.Name;
                var ip = camInfo.IPAddress.ToString();

                ListViewItem lvi = new ListViewItem(new string[] { name, ip });
                lvi.ForeColor = Color.Black;
                lvi.Group = list_Cameras.Groups[1];
                list_Cameras.Items.Add(lvi);
            }

            foreach (var camInfo in mAlignSystemManager.GetMisconfiguredCameraInfos())
            {
                var name = camInfo.Name;
                var ip = camInfo.IPAddress.ToString();

                ListViewItem lvi = new ListViewItem(new string[] { name, ip });
                lvi.ForeColor = Color.Red;
                lvi.Group = list_Cameras.Groups[2];
                list_Cameras.Items.Add(lvi);
            }

            initForChangedSystem();

            show_SelectedCamNetInfo_onHMI();      //initialize fields on HMI (none is selected on the list at this point)

            ((Button)sender).BackColor = Color.Lime;
        }

        // Event handler of this.list_Cameras.SelectedIndexChanged
        private void list_Cameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_SelectedCamNetInfo_onHMI();
        }

        private void btn_ChangeCamNetInfo_Click(object sender, EventArgs e)
        {
            var selectedCamNetInfo = get1stSelectedCamNetInfo();
            if (selectedCamNetInfo == null)
                return;

            ((Button)sender).BackColor = Color.Red;
            bool manualPowerCycle;
            mAlignSystemManager.ConfigureCameraInfo(selectedCamNetInfo, txtBox_SelectedCamName.Text,
                newIPAddress: IPAddress.Parse(txtBox_SelectedCamIPAdd.Text),
                newSubnetMask: IPAddress.Parse(txtBox_SelectedCamSubMask.Text),
                manualPowerCycleRequired: out manualPowerCycle,
                newDomainName: "",
                DNS: null,
                gateway: null,
                dhcp: false);

            if (manualPowerCycle)
            {
                CancellationTokenSource cancelToken = new CancellationTokenSource();



                try
                {
                    selectedCamNetInfo.WaitOnManualPowerCycleToComplete(cancelToken);
                }
                catch (AggregateException ae)
                {
                    foreach (Exception ie in ae.InnerExceptions)
                    {
                        if (ie is System.Threading.Tasks.TaskCanceledException)
                            MessageBox.Show("Waiting on Manual Power Cycle was aborted by the user. Wait on power cycle...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            btn_Update_CamList_CurrSysInfo.PerformClick();
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_ConnectSystem_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            var selectedAlignSystem = get1stSelectedAlignSystem();
            if (selectedAlignSystem != null)
            {
                selectedAlignSystem.Connect();
                updateConfiguredCameraList();
                show_CurrentSystem_onHMI();
                initForChangedSystem();
            }
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_DisconnectSystem_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            var selectedAlignSystem = get1stSelectedAlignSystem();
            if (selectedAlignSystem != null)
            {
                if (selectedAlignSystem == mCurrentSystem)
                {
                    mAlignSystemManager.SelectedAlignSystem = null;
                    mCurrentSystem = null;
                }
                selectedAlignSystem.Disconnect();

                updateConfiguredCameraList();
                show_CurrentSystem_onHMI();
            }
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_SetCurrentSystem_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mAlignSystemManager.SelectedAlignSystem = get1stSelectedAlignSystem();
            mCurrentSystem = mAlignSystemManager.SelectedAlignSystem;

            updateConfiguredCameraList();
            show_CurrentSystem_onHMI();
            initForChangedSystem();
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_RemoveSystem_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            var selectedAlignSystem = get1stSelectedAlignSystem();
            if (selectedAlignSystem != null)
            {
                mAlignSystemManager.RemoveAlignSystem(selectedAlignSystem);       // Automatically connect if not connected then remove the system
                btn_Update_CamList_CurrSysInfo.PerformClick();
            }
            ((Button)sender).BackColor = Color.Lime;
        }



        private void btn_BackupSys_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (mCurrentSystem.Backup(fbd.SelectedPath))
                {
                    toolStripStatusLabelStatus.Text = "Backup Succeeded.";
                    ((Button)sender).BackColor = Color.Lime;
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "Error : Backup failed.";
                }
            }
            else
                ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_RestoreSys_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (mCurrentSystem.Restore(fbd.SelectedPath))
                {
                    toolStripStatusLabelStatus.Text = "Restore Succeeded.";
                    ((Button)sender).BackColor = Color.Lime;
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "Error : Restore failed.";
                }
            }
            else
                ((Button)sender).BackColor = Color.Lime;
        }
        #endregion System Management

        #region System Settings Setup ***********************************************************************
        private int displayImageResolutionToIndex(DisplayImageResolutions displResolution)
        {
            //Enum : 0, 1, 2, 4, 8
            //Index: 0, 1, 2, 3, 4       Enum - (Enum/3)^2
            var idx = (int)displResolution - Math.Pow((int)displResolution / 3, 2);
            return (int)idx;
        }

        private void updateSystemSettingsTab()       //called by initForChangedSystem()
        {
            var currSysSettings = mCurrentSystem?.GetAlignSystemSettings();

            // General Settings


            comboBox_DispImgResolution1.SelectedIndex = displayImageResolutionToIndex(currSysSettings?.DisplayImageResolution[0].DisplayImageResolution ?? (DisplayImageResolutions)(-1));
            if (mCurrentSystem.Cameras.Count == 2)
            {
                comboBox_DispImgResolution2.Enabled = true;
                comboBox_DispImgResolution2.SelectedIndex = displayImageResolutionToIndex(currSysSettings?.DisplayImageResolution[1].DisplayImageResolution ?? (DisplayImageResolutions)(-1));
            }
            else
            {
                comboBox_DispImgResolution2.SelectedIndex = -1;
                comboBox_DispImgResolution2.Enabled = false;
            }

            checkBox_RetainPoses.Checked = currSysSettings?.RetainPoses.Enabled ?? false;

            // Autocalibration settings
            var cal1 = currSysSettings.AutoCalibration.GetAutoCalibrationSettingsForCameraID(mCamera1.CameraID);
            numStepX1.Value = cal1.NumStepsX;
            numStepY1.Value = cal1.NumStepsY;
            chkAutoStep1.Checked = cal1.AutoStepSize;
            numXmin1.Value = Convert.ToDecimal(cal1.MovingRangeMinX);
            numXmax1.Value = Convert.ToDecimal(cal1.MovingRangeMaxX);
            numYmin1.Value = Convert.ToDecimal(cal1.MovingRangeMinY);
            numYmax1.Value = Convert.ToDecimal(cal1.MovingRangeMaxY);
            numTmin1.Value = Convert.ToDecimal(cal1.AngleMin);
            numTmax1.Value = Convert.ToDecimal(cal1.AngleMax);
            numStepT1.Value = cal1.NumStepsRotation;
            chkCantilever1.Checked = cal1.CantileverCompensation;

            if (mCurrentSystem.Cameras.Count == 2)
            {
                gBox_AutoCalib_Cam2.Enabled = true;
                var cal2 = currSysSettings.AutoCalibration.GetAutoCalibrationSettingsForCameraID(mCamera2.CameraID);
                numStepX2.Value = cal2.NumStepsX;
                numStepY2.Value = cal2.NumStepsY;
                chkAutoStep2.Checked = cal2.AutoStepSize;
                numXmin2.Value = Convert.ToDecimal(cal2.MovingRangeMinX);
                numXmax2.Value = Convert.ToDecimal(cal2.MovingRangeMaxX);
                numYmin2.Value = Convert.ToDecimal(cal2.MovingRangeMinY);
                numYmax2.Value = Convert.ToDecimal(cal2.MovingRangeMaxY);
                numTmin2.Value = Convert.ToDecimal(cal2.AngleMin);
                numTmax2.Value = Convert.ToDecimal(cal2.AngleMax);
                numStepT2.Value = cal2.NumStepsRotation;
                chkCantilever2.Checked = cal2.CantileverCompensation;
            }
            else
                gBox_AutoCalib_Cam2.Enabled = false;

        }

        private void btn_ChangeSysSettings_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            var tmpSysSettings = mCurrentSystem.GetAlignSystemSettings();

            tmpSysSettings.DisplayImageResolution[0].DisplayImageResolution = (DisplayImageResolutions)Enum.Parse(typeof(DisplayImageResolutions), comboBox_DispImgResolution1.SelectedItem.ToString(), true);
            tmpSysSettings.RetainPoses.Enabled = checkBox_RetainPoses.Checked;

            // AutoCalibration settings
            var cal1 = tmpSysSettings.AutoCalibration.GetAutoCalibrationSettingsForCameraID(mCamera1.CameraID);
            cal1.NumStepsX = Decimal.ToInt32(numStepX1.Value);
            cal1.NumStepsY = Decimal.ToInt32(numStepY1.Value);
            cal1.AutoStepSize = chkAutoStep1.Checked;
            cal1.MovingRangeMinX = Decimal.ToDouble(numXmin1.Value);
            cal1.MovingRangeMaxX = Decimal.ToDouble(numXmax1.Value);
            cal1.MovingRangeMinY = Decimal.ToDouble(numYmin1.Value);
            cal1.MovingRangeMaxY = Decimal.ToDouble(numYmax1.Value);
            cal1.AngleMin = Decimal.ToDouble(numTmin1.Value);
            cal1.AngleMax = Decimal.ToDouble(numTmax1.Value);
            cal1.NumStepsRotation = Decimal.ToInt32(numStepT1.Value);
            cal1.CantileverCompensation = chkCantilever1.Checked;
            tmpSysSettings.AutoCalibration.SetAutoCalibrationSettingsForCameraID(cal1, mCamera1.CameraID);

            if (mCurrentSystem.Cameras.Count == 2)
            {
                gBox_AutoCalib_Cam2.Enabled = true;
                var cal2 = tmpSysSettings.AutoCalibration.GetAutoCalibrationSettingsForCameraID(mCamera2.CameraID);
                cal2.NumStepsX = Decimal.ToInt32(numStepX2.Value);
                cal2.NumStepsY = Decimal.ToInt32(numStepY2.Value);
                cal2.AutoStepSize = chkAutoStep2.Checked;
                cal2.MovingRangeMinX = Decimal.ToDouble(numXmin2.Value);
                cal2.MovingRangeMaxX = Decimal.ToDouble(numXmax2.Value);
                cal2.MovingRangeMinY = Decimal.ToDouble(numYmin2.Value);
                cal2.MovingRangeMaxY = Decimal.ToDouble(numYmax2.Value);
                cal2.AngleMin = Decimal.ToDouble(numTmin2.Value);
                cal2.AngleMax = Decimal.ToDouble(numTmax2.Value);
                cal2.NumStepsRotation = Decimal.ToInt32(numStepT2.Value);
                cal2.CantileverCompensation = chkCantilever2.Checked;
                tmpSysSettings.AutoCalibration.SetAutoCalibrationSettingsForCameraID(cal2, mCamera2.CameraID);
            }
            else
                gBox_AutoCalib_Cam2.Enabled = false;


            if (mCurrentSystem.IsConnected)
            {
                mCurrentSystem.SetAlignSystemSettings(tmpSysSettings);
            }
            else
            {
                MessageBox.Show("Not Connected");
            }

            btn_PatternOrigin.Visible = tmpSysSettings.UseMoveableOrigin;
            mCamera1.AcquireAsync();         // Async Acquire to activate changed display resolution

            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_Reboot_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCurrentSystem.Reboot();
            ((Button)sender).BackColor = Color.Lime;
        }
        #endregion System Setup

        #region Recipe Management **********************************************************************
        private void updateCurretRecipeInfo()
        {
            lbl_CurrRecipeID.Text = mCurrentSystem?.SelectedRecipe?.ID.ToString("D3") ?? "";
            lbl_CurrRecipeName.Text = mCurrentSystem?.SelectedRecipe?.Name ?? "";
            lbl_CurrRecipeDescription.Text = mCurrentSystem?.SelectedRecipe?.Description ?? "";
            lbl_CurrRecipeMode.Text = mCurrentSystem?.SelectedRecipe?.GetRecipeMode().ToString() ?? "";
            toolStripStatusLabelVersion.Text = "Version : " + mCurrentSystem.SelectedRecipeVersion;
        }

        private void updateRecipeList()
        {
            list_Recipes.Items.Clear();
            foreach (var recipeName in mCurrentSystem.RecipeNames)
            {
                list_Recipes.Items.Add(recipeName);
            }
        }

        private void btn_UpdateRecipeList_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            updateRecipeList();
            ((Button)sender).BackColor = Color.Lime;
        }



        private void btn_RemoveRecipe_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            if (list_Recipes.SelectedIndex >= 0)           //if nothing is selected, SelectedIndex is -1
            {
                if ((string)list_Recipes.SelectedItem != mCurrentSystem.SelectedRecipe.Name)
                {
                    mCurrentSystem.RemoveRecipe((string)list_Recipes.SelectedItem);
                    updateRecipeList();
                }
            }
          ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_SaveCurrRecipe_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCurrentSystem.SaveSelectedRecipe();
            ((Button)sender).BackColor = Color.Lime;
        }

        // Create a New Recipe and Load it
        private void btn_NewRecipeCreate_Click(object sender, EventArgs e)
        {
            if (mCurrentSystem.Cameras.Count == 1)
            {
                if ((comboBox_NewRecipeMode.SelectedIndex == 8) || (comboBox_NewRecipeMode.SelectedIndex == 9))     //Default=0
                {
                    toolStripStatusLabelStatus.Text = "Invalid Recipe Mode for 1 Camera Configuration.";
                    return;
                }
            }
            else        // Two Camera Configuration
            {
                if (!((comboBox_NewRecipeMode.SelectedIndex == 0) || (comboBox_NewRecipeMode.SelectedIndex == 8) || (comboBox_NewRecipeMode.SelectedIndex == 9)))     //Default=0
                {
                    toolStripStatusLabelStatus.Text = "Invalid Recipe Mode for 2 Camera Configuration.";
                    return;
                }
            }

          ((Button)sender).BackColor = Color.Red;
            if (txtBox_NewRecipeName.Text.Length > 0)
            {
                int calibIndex = 0;
                try
                {
                    if (chkUseRecipeID.Checked == true)
                        mCurrentSystem.NewRecipe((int)numRecipeID.Value, txtBox_NewRecipeName.Text, txtBox_NewRecipeDescription.Text, (RecipeConfigurations)comboBox_NewRecipeMode.SelectedIndex, null, null, calibIndex);
                    else
                        mCurrentSystem.NewRecipe(txtBox_NewRecipeName.Text, txtBox_NewRecipeDescription.Text, (RecipeConfigurations)comboBox_NewRecipeMode.SelectedIndex, null, null, calibIndex);
                }
                catch (OutOfRecipeStorageException ex)
                {
                    MessageBox.Show(ex.Message, "Error: Storage full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                updateCurretRecipeInfo();
                updateRecipeList();
                updateExposureTab();
                updateCheckerTab(1);
                updateFeatureTab(1, 1);
            }
            txtBox_NewRecipeName.Text = "";
            txtBox_NewRecipeDescription.Text = "";
            comboBox_NewRecipeMode.SelectedIndex = 0;
            //Disonnect TCPIP connection for command
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_SaveCurrRecipeAs_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            try
            {
                if (chkUseRecipeID.Checked == true)
                    mCurrentSystem.SaveSelectedRecipeAs((int)numRecipeID.Value, txtBox_SaveCurrRecipeAsName.Text, txtBox_SaveCurrRecipeAsDescription.Text);
                else
                    mCurrentSystem.SaveSelectedRecipeAs(txtBox_SaveCurrRecipeAsName.Text, txtBox_SaveCurrRecipeAsDescription.Text);
            }
            catch (OutOfRecipeStorageException ex)
            {
                MessageBox.Show(ex.Message, "Error: Storage full", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            updateCurretRecipeInfo();        // Current Recipe Name is changed to the new name.
            updateRecipeList();
            ((Button)sender).BackColor = Color.Lime;
        }
        #endregion Recipe Management

        #region RecipeSettings ****************************************************************************
        private void btnUpdateLCheck_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            cbLCSelectedPartID.Items.Clear();
            var settings = mCurrentSystem.GetAlignSystemSettings().LCheck;
            var IDs = settings.GetValidPartIDsInLCheck();
            if (IDs.Count > 0)
            {
                foreach (var id in IDs)
                {
                    cbLCSelectedPartID.Items.Add(id);
                }
                cbLCSelectedPartID.SelectedIndex = 0;
            }
            else
            {
                cbLCSelectedPartID.Text = "";
                cbLCMode.SelectedIndex = 0;
                numLCLowLim.Value = 0;
                numLCUpperLim.Value = 0;
            }

          ((Button)sender).BackColor = Color.Lime;
        }
        private void cbLCSelectedPartID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var settings = mCurrentSystem.GetAlignSystemSettings().LCheck;
            settings.PartID = (int)cbLCSelectedPartID.SelectedItem;
            cbLCMode.SelectedIndex = settings.LCheckResultMode - 1;
            numLCLowLim.Value = (Decimal)settings.LowerLimit;
            numLCUpperLim.Value = (Decimal)settings.UpperLimit;
        }

        private void btnUpdateMPs_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            try
            {
                var settings = mCurrentSystem.GetAlignSystemSettings().MPs;
                PartID1.Items.Clear();
                PartID2.Items.Clear();
                PartID3.Items.Clear();
                PartID4.Items.Clear();
                PartID5.Items.Clear();
                PartID1.Items.Add("");
                PartID2.Items.Add("");
                PartID3.Items.Add("");
                PartID4.Items.Add("");
                PartID5.Items.Add("");
                for (int idx = 1; idx < 12; idx++)
                {
                    PartID5.Items.Add(idx);
                }
                List<int> ValidPartIDs = settings.GetValidPartIDsInMPs();
                if (ValidPartIDs != null)
                {
                    foreach (var partID in ValidPartIDs)
                    {
                        if (ValidPartIDs.Count == 1)
                        {
                            PartID1.Items.Add(partID);
                        }
                        else if (ValidPartIDs.Count == 2)
                        {
                            PartID1.Items.Add(partID);
                            PartID2.Items.Add(partID);
                        }
                        else if (ValidPartIDs.Count == 3)
                        {
                            PartID1.Items.Add(partID);
                            PartID2.Items.Add(partID);
                            PartID3.Items.Add(partID);
                        }
                        else if (ValidPartIDs.Count >= 4)
                        {
                            PartID1.Items.Add(partID);
                            PartID2.Items.Add(partID);
                            PartID3.Items.Add(partID);
                            PartID4.Items.Add(partID);
                        }
                    }
                }
                if (settings.MPs != null && settings.MPs.Count > 0)
                {
                    for (int idx = 0; idx < settings.MPs.Count(); idx++)
                    {
                        switch (idx)
                        {
                            case 0:
                                PartID1.SelectedIndex = PartID1.FindString(settings.MPs[idx].ToString());
                                break;
                            case 1:
                                PartID2.SelectedIndex = PartID2.FindString(settings.MPs[idx].ToString());
                                break;
                            case 2:
                                PartID3.SelectedIndex = PartID3.FindString(settings.MPs[idx].ToString());
                                break;
                            case 3:
                                PartID4.SelectedIndex = PartID4.FindString(settings.MPs[idx].ToString());
                                break;
                            default:
                                break;
                        }
                    }
                    PartID5.SelectedIndex = 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
          ((Button)sender).BackColor = Color.Lime;
        }

        private void btnSetLCheck_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            var settings = mCurrentSystem.GetAlignSystemSettings().LCheck;
            settings.PartID = (int)cbLCSelectedPartID.SelectedItem;
            settings.LCheckResultMode = cbLCMode.SelectedIndex + 1;
            settings.LowerLimit = Decimal.ToDouble(numLCLowLim.Value);
            settings.UpperLimit = Decimal.ToDouble(numLCUpperLim.Value);
            mCurrentSystem.SetAlignSystemSettings(settings);
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btnSetMPs_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            try
            {
                List<int> LocalMPs = new List<int>();
                var settings = mCurrentSystem.GetAlignSystemSettings().MPs;
                if (PartID1.SelectedIndex > 0)
                    LocalMPs.Add((int)PartID1.SelectedItem);
                if (PartID2.SelectedIndex > 0)
                    LocalMPs.Add((int)PartID2.SelectedItem);
                if (PartID3.SelectedIndex > 0)
                    LocalMPs.Add((int)PartID3.SelectedItem);
                if (PartID4.SelectedIndex > 0)
                    LocalMPs.Add((int)PartID4.SelectedItem);
                if (PartID5.SelectedIndex > 0)
                    LocalMPs.Add((int)PartID5.SelectedItem);
                settings.MPs = LocalMPs;
                mCurrentSystem.SetAlignSystemSettings(settings);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
          ((Button)sender).BackColor = Color.Lime;
        }

        #endregion    //Recipe Settings

        #region Control on Display ***************************************************************
        private void checkBox_ToolBar_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.ToolBarVisibility = ((CheckBox)sender).Checked;
        }

        private void checkBox_StatuslBar_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.SetStatusBarVisibility(((CheckBox)sender).Checked);
        }
        private void checkBox_Graphics_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.SetShowGraphics(((CheckBox)sender).Checked);
        }

        private void checkBox_FOVCross_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.SetFOVCenterCrossEnabled(((CheckBox)sender).Checked);
        }

        private void checkBox_AcceptCancelButton_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.UseAcceptCancelToolbarButtons = ((CheckBox)sender).Checked;
        }

        private void checkBox_SaveImgBtnEnable_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.ToolBarSaveImageEnabled = ((CheckBox)sender).Checked;
        }

        private void checkBox_LoadImgBtnEnable_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.ToolBarLoadImageEnabled = ((CheckBox)sender).Checked;
        }

        private void checkBox_LiveVideoBtnEnable_CheckedChanged(object sender, EventArgs e)
        {
            alignSystemDisplay.ToolBarLiveVideoEnabled = ((CheckBox)sender).Checked;
        }

        // for Cam1 -----------------------------------------------------
        private void btn_ZoomFit1_Click(object sender, EventArgs e)
        {
            mCamDisp1.ZoomFit();
        }

        private void btn_ZoomIn1_Click(object sender, EventArgs e)
        {
            mCamDisp1.ZoomIn();
        }

        private void btn_ZoomOut1_Click(object sender, EventArgs e)
        {
            mCamDisp1.ZoomOut();
        }

        private void btn_LoadImg1_Click(object sender, EventArgs e)
        {
            mCamDisp1.LoadImage();
        }

        private void btn_SaveImg1_Click(object sender, EventArgs e)
        {
            mCamDisp1.SaveImage();
        }

        private void btn_RotCCW1_Click(object sender, EventArgs e)
        {
            mCamDisp1.RotateImageCCW();
        }

        private void btn_RotCW1_Click(object sender, EventArgs e)
        {
            mCamDisp1.RotateImageCW();
        }

        private void btn_StartLive1_Click(object sender, EventArgs e)
        {
            mCamDisp1.StartLiveAcquisition();
        }

        private void btn_StopLive1_Click(object sender, EventArgs e)
        {
            mCamDisp1.StopLiveAcquisition();
        }

        private void checkBox_StatusBarVisibility1_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.StatusBarVisibility = ((CheckBox)sender).Checked;
        }

        private void checkBox_ShowGraphics1_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.ShowGraphics = ((CheckBox)sender).Checked;
        }

        private void checkBox_FovCross1_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.FOVCenterCrossEnabled = ((CheckBox)sender).Checked;
        }

        private void checkBox_FocusFeedback1_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.FocusFeedbackEnabled = ((CheckBox)sender).Checked;
        }

        private void chkGiveFileName_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.GiveFileNameEnabled = ((CheckBox)sender).Checked;
        }

        private void chkImageSaveWithGraphics_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp1.SaveImageWithGraphicsEnabled = ((CheckBox)sender).Checked;
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            mCamDisp1.FileName = ((TextBox)sender).Text;
        }

        // for Cam2 -----------------------------------------------------
        private void updateCtrlOnDisp_Cam2()
        {
            checkBox_ShowStatusBar2.Checked = mCamDisp2.StatusBarVisibility;
            checkBox_ShowGraphics2.Checked = mCamDisp2.ShowGraphics;
            checkBox_FovCross2.Checked = mCamDisp2.FOVCenterCrossEnabled;
        }

        private void btn_ZoomFit2_Click(object sender, EventArgs e)
        {
            mCamDisp2.ZoomFit();
        }

        private void btn_ZoomIn2_Click(object sender, EventArgs e)
        {
            mCamDisp2.ZoomIn();
        }

        private void btn_ZoomOut2_Click(object sender, EventArgs e)
        {
            mCamDisp2.ZoomOut();
        }

        private void btn_LoadImg2_Click(object sender, EventArgs e)
        {
            mCamDisp2.LoadImage();
        }

        private void btn_SaveImg2_Click(object sender, EventArgs e)
        {
            mCamDisp2.SaveImage();
        }

        private void btn_RotCCW2_Click(object sender, EventArgs e)
        {
            mCamDisp2.RotateImageCCW();
        }

        private void btn_RotCW2_Click(object sender, EventArgs e)
        {
            mCamDisp2.RotateImageCW();
        }

        private void btn_StartLive2_Click(object sender, EventArgs e)
        {
            mCamDisp2.StartLiveAcquisition();
        }

        private void btn_StopLive2_Click(object sender, EventArgs e)
        {
            mCamDisp2.StopLiveAcquisition();
        }

        private void checkBox_StatusBarVisibility2_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp2.StatusBarVisibility = ((CheckBox)sender).Checked;
        }

        private void checkBox_ShowGraphics2_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp2.ShowGraphics = ((CheckBox)sender).Checked;
        }

        private void checkBox_FovCross2_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp2.FOVCenterCrossEnabled = ((CheckBox)sender).Checked;
        }

        private void checkBox_FocusFeedback2_CheckedChanged(object sender, EventArgs e)
        {
            mCamDisp2.FocusFeedbackEnabled = ((CheckBox)sender).Checked;
        }
        #endregion

        #region Checker Board Calibration ***************************************************
        private void updateCheckerTab(int camID)
        {
            numUpDown_Checker_CamID.Value = camID;

            if (mCurrentSystem.Cameras.Count == 1)
                numUpDown_Checker_CamID.Enabled = false;
            else
                numUpDown_Checker_CamID.Enabled = true;

            IAlignCameraExposureSetting exposureSetting;
            if (camID == 1)
            {
                exposureSetting = mCamera1.GetExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1);
                mChecker = mCamera1.GetCheckerboardCalibrationSettings();
            }
            else
            {
                exposureSetting = mCamera2.GetExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1);
                mChecker = mCamera2.GetCheckerboardCalibrationSettings();
            }

            // Exposure Settings
            numUpDown_Exposure_Checker.Value = (decimal)(exposureSetting?.ExposureTime ?? 0.0);
            checkBox_LightEn_Checker.Checked = exposureSetting?.LightEnable ?? true;
            numUpDown_LightCrl_Checker.Value = (decimal)(exposureSetting?.LightIntensity ?? 0);


            // Checker Calibration Settings
            mChecker.EditRegionCompleted += Handler_EditCheckerCalibRegionCompleted;
            mChecker.CalibrationStarted += Handler_CalibrationStarted;
            mChecker.CalibrationStatusChanged += Handler_CalibrationStatusChanged;
            mChecker.CalibrationFinished += Handler_CalibrationFinished;

            lbl_CheckerStatus.Text = mChecker.IsCalibrated ? "Calibrated" : "UnCalibrated";
            numUpDown_CheckerXSpacing.Value = (decimal)mChecker.GetXSpacing();
            numUpDown_CheckerYSpacing.Value = (decimal)mChecker.GetYSpacing();

            btn_CheckerCalibrate.BackColor = Color.Lime;
            btn_CheckerSetRegion.BackColor = Color.Lime;
        }

        private void numUpDown_Checker_CamID_ValueChanged(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).BackColor = Color.Red;
            updateCheckerTab((int)numUpDown_Checker_CamID.Value);
            ((NumericUpDown)sender).BackColor = Color.White;
        }

        private void btn_ChangeExpSetup_Checker_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            if (numUpDown_Checker_CamID.Value == 1)
            {
                mCamera1.SetExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1,
                 (float)numUpDown_Exposure_Checker.Value, (float)numUpDown_LightCrl_Checker.Value, checkBox_LightEn_Checker.Checked);
                mCamera1.SetSelectedExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1);
            }
            else
            {
                mCamera2.SetExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1,
                 (float)numUpDown_Exposure_Checker.Value, (float)numUpDown_LightCrl_Checker.Value, checkBox_LightEn_Checker.Checked);
                mCamera2.SetSelectedExposureSetting(ExposureSettingTypes.CheckerboardCalibration, 1);
            }
          ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_CheckerCalibrate_Click(object sender, EventArgs e)
        {
            mChecker.SetXSpacing((float)numUpDown_CheckerXSpacing.Value);
            mChecker.SetYSpacing((float)numUpDown_CheckerYSpacing.Value);
            statusLabel = lbl_CheckerStatus;
            activeButton = (Button)sender;
            mChecker.Calibrate();             //blocking method, Button color is changed in Started and Finished callback
                                              //lbl_CheckerStatus.Text = mChecker.IsCalibrated ? "Calibrated" : "UnCalibrated";
        }

        private void btn_CheckerUnCalibrate_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            statusLabel = lbl_CheckerStatus;
            mChecker.UnCalibrate();             //blocking method
            ((Button)sender).BackColor = Color.Lime;
            //lbl_CheckerStatus.Text = mChecker.IsCalibrated ? "Calibrated" : "UnCalibrated";
        }

        private void btn_CheckerSetRegion_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;                     //to reset button color
            mChecker.BeginEditCalibrationRegion();             //non blocking method
        }

        private void btn_CheckerMaxRegion_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;                    //to reset button color
            mChecker.MaximizeCalibrationRegion();             //non blocking method
        }

        #endregion

        #region Exposure Settings ***********************************************************
        private void updateExposureTab()
        {
            tabExposure.Enabled = true;
            updateExposureTab_Cam1();
            updateExposureTab_Cam2();

            mExpService1 = mCamera1.GetAutoExposureService();
            mExpService1.EditRegionCompleted += Handler_EditAutoExpRegionCompleted;
            mExpService1.Finished += Handler_AutoExposureFinished;
        }

        private void updateExposureTab_Cam1()
        {
            mCamera1.SetSelectedExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam1.Value);
            var exposureSetting = mCamera1.GetSelectedExposureSetting();

            numUpDown_Exposure_Cam1.Value = (decimal)(exposureSetting?.ExposureTime ?? 0.0);
            checkBox_LightEn_Cam1.Enabled = mCamera1.LightSupported;
            checkBox_LightEn_Cam1.Checked = exposureSetting?.LightEnable ?? true;
            numUpDown_LightCrl_Cam1.Value = (decimal)(exposureSetting?.LightIntensity ?? 0);

            lbl_AutoExpStatus_Cam1.BackColor = Color.Yellow;
        }

        private void updateExposureTab_Cam2()
        {
            if (mCurrentSystem.Cameras.Count == 2)
            {
                gBox_ExposureSetting_Cam2.Enabled = true;
                mCamera2.SetSelectedExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam1.Value);
                var exposureSetting = mCamera2.GetSelectedExposureSetting();

                numUpDown_Exposure_Cam2.Value = (decimal)(exposureSetting?.ExposureTime ?? 0.0);
                checkBox_LightEn_Cam2.Enabled = mCamera2.LightSupported;
                checkBox_LightEn_Cam2.Checked = exposureSetting?.LightEnable ?? true;
                numUpDown_LightCrl_Cam2.Value = (decimal)(exposureSetting?.LightIntensity ?? 0);
            }
            else
                gBox_ExposureSetting_Cam2.Enabled = false;
        }

        private void numUpDown_ExposureID_Cam1_ValueChanged(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).BackColor = Color.Red;
            updateExposureTab_Cam1();
            ((NumericUpDown)sender).BackColor = Color.White;
        }

        private void btn_ChangeExpSetup_Cam1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCamera1.SetExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam1.Value,
               (float)numUpDown_Exposure_Cam1.Value, (float)numUpDown_LightCrl_Cam1.Value, checkBox_LightEn_Cam1.Checked);
            mCamera1.SetSelectedExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam1.Value);
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_AutoExpStart_Cam1_Click(object sender, EventArgs e)
        {
            statusLabel = lbl_AutoExpStatus_Cam1;
            mExpService1.Start();
            lbl_AutoExpStatus_Cam1.Text = "Running";
            lbl_AutoExpStatus_Cam1.BackColor = Color.Red;
        }

        private void btn_AutoExpCancel_Cam1_Click(object sender, EventArgs e)
        {
            mExpService1.Cancel();
        }

        private void btn_AutoExpSetRegion_Cam1_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;                     //to reset button color
            mExpService1.BeginEditAutoExposureRegion();        //non blocking method
        }

        private void numUpDown_ExposureID_Cam2_ValueChanged(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).BackColor = Color.Red;
            updateExposureTab_Cam2();
            ((NumericUpDown)sender).BackColor = Color.White;
        }

        private void btn_ChangeExpSetup_Cam2_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            mCamera2.SetExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam2.Value,
               (float)numUpDown_Exposure_Cam2.Value, (float)numUpDown_LightCrl_Cam2.Value, checkBox_LightEn_Cam2.Checked);
            mCamera2.SetSelectedExposureSetting(ExposureSettingTypes.Feature, (int)numUpDown_ExposureID_Cam2.Value);
            ((Button)sender).BackColor = Color.Lime;
        }
        #endregion    // Exposure Settings

        #region Feature Setup ***************************************************************
        private void updateFeatureTab(int camID, int featureID)
        {
            tabFeature.Enabled = true;
            numUpDown_Feature_CamID.Value = camID;
            numUpDown_FeatureID.Value = featureID;

            if (mCurrentSystem.Cameras.Count == 1)
                numUpDown_Feature_CamID.Enabled = false;
            else
                numUpDown_Feature_CamID.Enabled = true;

            var currentRecipeMode = mCurrentSystem.SelectedRecipe.GetRecipeMode();
            switch (currentRecipeMode)
            {
                case RecipeConfigurations.Default:
                    numUpDown_FeatureID.Maximum = 1;
                    break;
                case RecipeConfigurations.OneCamera_OneFeature:
                    numUpDown_FeatureID.Maximum = 1;
                    break;
                case RecipeConfigurations.OneCamera_TwoFeatures:
                    numUpDown_FeatureID.Maximum = 2;
                    break;
                case RecipeConfigurations.OneCamera_ThreeFeatures:
                    numUpDown_FeatureID.Maximum = 3;
                    break;
                case RecipeConfigurations.OneCamera_FourFeatures:
                    numUpDown_FeatureID.Maximum = 4;
                    break;
                case RecipeConfigurations.OneCamera_ShuttlingCamera:
                    numUpDown_FeatureID.Maximum = 2;
                    break;
                case RecipeConfigurations.OneCamera_ShuttledCamera:
                    numUpDown_FeatureID.Maximum = 2;
                    break;
                case RecipeConfigurations.OneCamera_ShuttlingPart:
                    numUpDown_FeatureID.Maximum = 2;
                    break;
                case RecipeConfigurations.TwoCameras_OneFeaturePerCamera:
                    numUpDown_FeatureID.Maximum = 1;
                    break;
                case RecipeConfigurations.TwoCameras_TwoFeaturesPerCamera:
                    numUpDown_FeatureID.Maximum = 2;
                    break;
                default:
                    break;
            }

            // Retrieve Feature Info
            if (camID == 1)
                mFeature = mCamera1.GetFeatureByFeatureID(featureID);
            else
                mFeature = mCamera2.GetFeatureByFeatureID(featureID);
            if (mFeature != null)
                mFeature.EditRegionCompleted += Handler_EditRegionCompleted;       // change color back to Lime
            mPatSetting = mFeature?.GetPatternSetting();

            comboBox_Graphics.SelectedIndex = (int)mPatSetting.GetGraphicsEnabled();
            checkBox_SearchInfoEn.Checked = mPatSetting.GetInformationEnabled();

            // Show Search Parameters
            numUpDown_Contrast.Value = (decimal)mPatSetting.GetContrastThreshold();    // display is updated ?
            numUpDown_Angle.Value = (decimal)mPatSetting.GetAngleRange();
            numUpDown_Score.Value = (decimal)mPatSetting.GetAcceptThreshold();
            numUpDown_Scale.Value = (decimal)mPatSetting.GetNominalScale();
            checkBox_ClutterEn.Checked = mPatSetting.GetClutterInScoreEnabled();

            lbl_TrainX.Text = "";
            lbl_TrainY.Text = "";
            lbl_TrainWidth.Text = "";
            lbl_TrainHeight.Text = "";
            lbl_ResultX.Text = "";
            lbl_ResultY.Text = "";
            lbl_ResultAngle.Text = "";
            lbl_ResultScore.Text = "";
        }

        private void numUpDown_Feature_CamID_ValueChanged(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).BackColor = Color.Red;
            updateFeatureTab((int)numUpDown_Feature_CamID.Value, (int)numUpDown_FeatureID.Value);
            ((NumericUpDown)sender).BackColor = Color.White;
        }

        private void numUpDown_FeatureID_ValueChanged(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).BackColor = Color.Red;
            updateFeatureTab((int)numUpDown_Feature_CamID.Value, (int)numUpDown_FeatureID.Value);
            ((NumericUpDown)sender).BackColor = Color.White;
        }

        private void btn_TrainRegion_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;                     //to reset button color
            mPatSetting.BeginEditPatternTrainRegion();         //non blocking method
        }

        private void btn_SearchRegion_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;                     //to reset button color 
            mPatSetting.BeginEditPatternSearchRegion();        //non blocking method
        }

        private void btn_MaxSearchRegion_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;
            mPatSetting.BeginMaximizePatternSearchRegion();
        }

        private void btn_PatternOrigin_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
            activeButton = (Button)sender;
            mPatSetting.BeginEditPatternOrigin();
        }

        private void btn_AcqImageAndRun_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;

            if (numUpDown_Feature_CamID.Value == 1)
            {
                mCamera1.AcquireAndRun((int)numUpDown_FeatureID.Value);              // current selected exposure setting is used.
                                                                                     //  mCamera1.AcquireAndRun(mFeature);
                numUpDown_ExposureID_Cam1.Value = mCamera1.GetSelectedExposureSetting().ExposureSettingID;     // update selected exposure ID on exposure tab
            }
            else
            {
                mCamera2.AcquireAndRun((int)numUpDown_FeatureID.Value);
                numUpDown_ExposureID_Cam2.Value = mCamera2.GetSelectedExposureSetting().ExposureSettingID;
            }

          ((Button)sender).BackColor = Color.Lime;
        }

        private void comboBox_Graphics_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mode = (PatternGraphics)((ComboBox)sender).SelectedIndex;
            mPatSetting.SetGraphicsEnabled(mode);
        }

        private void checkBox_SearchInfoEn_CheckedChanged(object sender, EventArgs e)
        {
            mPatSetting.SetInformationEnabled(((CheckBox)sender).Checked);
        }

        private void btn_ChangeSearchParams_Click(object sender, EventArgs e)
        {
            //This reruns Feature Search
            ((Button)sender).BackColor = Color.Red;
            mPatSetting.SetContrastThreshold((float)numUpDown_Contrast.Value);
            mPatSetting.SetAngleRange((float)numUpDown_Angle.Value);
            mPatSetting.SetAcceptThreshold((float)numUpDown_Score.Value);
            mPatSetting.SetNominalScale((float)numUpDown_Scale.Value);
            mPatSetting.SetClutterInScoreEnabled(checkBox_ClutterEn.Checked);
            ((Button)sender).BackColor = Color.Lime;
        }

        private void btn_GetTrainRegion_Click(object sender, EventArgs e)
        {
            var rec = mPatSetting.GetPatternTrainRegion();
            lbl_TrainX.Text = rec.X.ToString();
            lbl_TrainY.Text = rec.Y.ToString();
            lbl_TrainHeight.Text = rec.Height.ToString();
            lbl_TrainWidth.Text = rec.Width.ToString();
        }

        private void btn_GetResult_Click(object sender, EventArgs e)
        {
            var result = mFeature.GetResult();
            lbl_ResultScore.Text = String.Format("{0:F1}", result.Score);
            lbl_ResultX.Text = String.Format("{0:F1}", result.PoseX);
            lbl_ResultY.Text = String.Format("{0:F1}", result.PoseY);
            lbl_ResultAngle.Text = String.Format("{0:F2}", result.Angle);
        }
        #endregion    // Feature Setup



        private void chkUseRecipeID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseRecipeID.Checked == true)
            {
                numRecipeID.Value = (Decimal)mCurrentSystem.FreeRecipeID;
            }
        }

        private void numRecipeID_ValueChanged(object sender, EventArgs e)
        {
            if (mCurrentSystem.IsUsedRecipeID((int)numRecipeID.Value) == true)
                numRecipeID.BackColor = Color.Red;
            else
                numRecipeID.BackColor = Color.White;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)  // nhúng form1 vào tab Control Robot
        {
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text == "Control Robot")
            {
                tabPage1.Controls.Add(form1Instance);
                form1Instance.FormBorderStyle = FormBorderStyle.None;
                form1Instance.Dock = DockStyle.Fill;
                form1Instance.Show();
            }
            else
            {
                // chuyển sang tab khác,  ẩn hoặc xóa form1Instance
                tabPage1.Controls.Remove(form1Instance);
            }
        }

        #region HeResults *********************************************************************************************
        private void btnGetHeResults_Click(object sender, EventArgs e)
        {
            // Get all HEResults from selected camera
            var HEResults = new List<IAlignCameraHandEyeCalibrationResult>();
            if (CameraIndex.Value == 1 && mCamera1 != null)
            {
                HEResults = mCamera1.GetHandEyeCalibrationResults();
            }
            else if (CameraIndex.Value == 2 && mCamera2 != null)
            {
                HEResults = mCamera2.GetHandEyeCalibrationResults();
            }
            if (HEResults != null && HEResults.Count() > 0)
            {
                foreach (IAlignCameraHandEyeCalibrationResult HECalibResult in HEResults)
                {
                    String msg = String.Format("CameraIndex:{0}\nCalibrationIndex:{1}\nRequiredCalibResult:{2}\nValid:{3}\nGrade:{4}\nRMS_Image2D:{5}\nRMS_Home2D :{6}\nPixelSize_X :{7}\nPixelSize_X:{8}\nFOV_X:{9}\nFOV_Y:{10}",
                    HECalibResult.CameraIndex,
                    HECalibResult.CalibrationIndex,
                    HECalibResult.RequiredCalibResult.ToString(),
                    HECalibResult.Valid.ToString(),
                    HECalibResult.Grade.ToString(),
                    HECalibResult.RMS_Image2D,
                    HECalibResult.RMS_Home2D,
                    HECalibResult.PixelSize_X,
                    HECalibResult.PixelSize_Y,
                    HECalibResult.FOV_X,
                    HECalibResult.FOV_Y);
                    MessageBox.Show(msg);
                }
            }
        }

        #endregion     //HeResults
    }
}
