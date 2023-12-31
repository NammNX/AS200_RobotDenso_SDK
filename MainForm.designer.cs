﻿namespace SampleApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Configured", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Unconfigured", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("On Different Network", System.Windows.Forms.HorizontalAlignment.Left);
      this.btn_Connect = new System.Windows.Forms.Button();
      this.btn_Cam1AcqImage = new System.Windows.Forms.Button();
      this.txtBox_IPAddress = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabSysMgmt = new System.Windows.Forms.TabPage();
      this.txtSpecialInternalDataFolder = new System.Windows.Forms.TextBox();
      this.chkUseSpecialInternalDataFolder = new System.Windows.Forms.CheckBox();
      this.btn_DisconnectSystem = new System.Windows.Forms.Button();
      this.btn_ConnectSystem = new System.Windows.Forms.Button();
      this.btn_RemoveSystem = new System.Windows.Forms.Button();
      this.gBox_SelectedCamNetInfo = new System.Windows.Forms.GroupBox();
      this.txtBox_SelectedCamMACAdd = new System.Windows.Forms.TextBox();
      this.label99 = new System.Windows.Forms.Label();
      this.txtBox_SelectedCamGateway = new System.Windows.Forms.TextBox();
      this.txtBox_SelectedCamDNS = new System.Windows.Forms.TextBox();
      this.txtBox_SelectedCamDomainName = new System.Windows.Forms.TextBox();
      this.txtBox_SelectedCamSubMask = new System.Windows.Forms.TextBox();
      this.txtBox_SelectedCamIPAdd = new System.Windows.Forms.TextBox();
      this.txtBox_SelectedCamName = new System.Windows.Forms.TextBox();
      this.btn_ChangeCamNetInfo = new System.Windows.Forms.Button();
      this.checkBox_IsDHCP = new System.Windows.Forms.CheckBox();
      this.label39 = new System.Windows.Forms.Label();
      this.label38 = new System.Windows.Forms.Label();
      this.label37 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.btn_RestoreSys = new System.Windows.Forms.Button();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.checkBox_LowerIsMaster = new System.Windows.Forms.CheckBox();
      this.label16 = new System.Windows.Forms.Label();
      this.txtBox_NewSysName = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.btn_CreateSys = new System.Windows.Forms.Button();
      this.txtBox_NewSysDescription = new System.Windows.Forms.TextBox();
      this.list_Cameras = new System.Windows.Forms.ListView();
      this.list_Camera_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_Camera_IPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_System_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_IsMaster = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_IsConnected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_IsCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.list_Model_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btn_SelectSystem = new System.Windows.Forms.Button();
      this.btn_BackupSys = new System.Windows.Forms.Button();
      this.label25 = new System.Windows.Forms.Label();
      this.btn_Update_CamList_CurrSysInfo = new System.Windows.Forms.Button();
      this.tabSysSetup = new System.Windows.Forms.TabPage();
      this.checkBox_RetainPoses = new System.Windows.Forms.CheckBox();
      this.comboBox_DispImgResolution2 = new System.Windows.Forms.ComboBox();
      this.label42 = new System.Windows.Forms.Label();
      this.label41 = new System.Windows.Forms.Label();
      this.comboBox_DispImgResolution1 = new System.Windows.Forms.ComboBox();
      this.label40 = new System.Windows.Forms.Label();
      this.groupBox15 = new System.Windows.Forms.GroupBox();
      this.gBox_AutoCalib_Cam2 = new System.Windows.Forms.GroupBox();
      this.chkCantilever2 = new System.Windows.Forms.CheckBox();
      this.numStepX2 = new System.Windows.Forms.NumericUpDown();
      this.numStepT2 = new System.Windows.Forms.NumericUpDown();
      this.numStepY2 = new System.Windows.Forms.NumericUpDown();
      this.numTmax2 = new System.Windows.Forms.NumericUpDown();
      this.chkAutoStep2 = new System.Windows.Forms.CheckBox();
      this.numTmin2 = new System.Windows.Forms.NumericUpDown();
      this.numXmin2 = new System.Windows.Forms.NumericUpDown();
      this.numYmax2 = new System.Windows.Forms.NumericUpDown();
      this.numXmax2 = new System.Windows.Forms.NumericUpDown();
      this.numYmin2 = new System.Windows.Forms.NumericUpDown();
      this.gBox_AutoCalib_Cam1 = new System.Windows.Forms.GroupBox();
      this.chkCantilever1 = new System.Windows.Forms.CheckBox();
      this.numStepX1 = new System.Windows.Forms.NumericUpDown();
      this.numStepT1 = new System.Windows.Forms.NumericUpDown();
      this.numStepY1 = new System.Windows.Forms.NumericUpDown();
      this.numTmax1 = new System.Windows.Forms.NumericUpDown();
      this.chkAutoStep1 = new System.Windows.Forms.CheckBox();
      this.numTmin1 = new System.Windows.Forms.NumericUpDown();
      this.numXmin1 = new System.Windows.Forms.NumericUpDown();
      this.numYmax1 = new System.Windows.Forms.NumericUpDown();
      this.numXmax1 = new System.Windows.Forms.NumericUpDown();
      this.numYmin1 = new System.Windows.Forms.NumericUpDown();
      this.label36 = new System.Windows.Forms.Label();
      this.label28 = new System.Windows.Forms.Label();
      this.label35 = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.label34 = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.label30 = new System.Windows.Forms.Label();
      this.label31 = new System.Windows.Forms.Label();
      this.label27 = new System.Windows.Forms.Label();
      this.label32 = new System.Windows.Forms.Label();
      this.groupBox13 = new System.Windows.Forms.GroupBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.numUpDown_PortNumber = new System.Windows.Forms.NumericUpDown();
      this.label20 = new System.Windows.Forms.Label();
      this.groupBox12 = new System.Windows.Forms.GroupBox();
      this.checkBox_ShuttledCamera = new System.Windows.Forms.CheckBox();
      this.checkBox_RunUncalibrated = new System.Windows.Forms.CheckBox();
      this.checkBox_MovableOrigin = new System.Windows.Forms.CheckBox();
      this.btn_ChangeSysSettings = new System.Windows.Forms.Button();
      this.tabRecipeMgmt = new System.Windows.Forms.TabPage();
      this.numRecipeID = new System.Windows.Forms.NumericUpDown();
      this.chkUseRecipeID = new System.Windows.Forms.CheckBox();
      this.btn_SaveCurrRecipe = new System.Windows.Forms.Button();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.txtBox_SaveCurrRecipeAsDescription = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.txtBox_SaveCurrRecipeAsName = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.btn_SaveCurrRecipeAs = new System.Windows.Forms.Button();
      this.btn_LoadRecipe = new System.Windows.Forms.Button();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.lbl_CurrRecipeName = new System.Windows.Forms.Label();
      this.lbl_CurrRecipeID = new System.Windows.Forms.Label();
      this.label95 = new System.Windows.Forms.Label();
      this.lbl_CurrRecipeMode = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.lbl_CurrRecipeDescription = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.btn_RemoveRecipe = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.txtBox_NewRecipeDescription = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.comboBox_NewRecipeMode = new System.Windows.Forms.ComboBox();
      this.txtBox_NewRecipeName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btn_NewRecipeCreate = new System.Windows.Forms.Button();
      this.btn_UpdateRecipeList = new System.Windows.Forms.Button();
      this.list_Recipes = new System.Windows.Forms.ListBox();
      this.tabRecipeSettings = new System.Windows.Forms.TabPage();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.numLCUpperLim = new System.Windows.Forms.NumericUpDown();
      this.numLCLowLim = new System.Windows.Forms.NumericUpDown();
      this.cbLCMode = new System.Windows.Forms.ComboBox();
      this.cbLCSelectedPartID = new System.Windows.Forms.ComboBox();
      this.label80 = new System.Windows.Forms.Label();
      this.label79 = new System.Windows.Forms.Label();
      this.label78 = new System.Windows.Forms.Label();
      this.label77 = new System.Windows.Forms.Label();
      this.btnSetLCheck = new System.Windows.Forms.Button();
      this.btnUpdateLCheck = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label87 = new System.Windows.Forms.Label();
      this.label86 = new System.Windows.Forms.Label();
      this.label85 = new System.Windows.Forms.Label();
      this.label84 = new System.Windows.Forms.Label();
      this.label82 = new System.Windows.Forms.Label();
      this.PartID5 = new System.Windows.Forms.ComboBox();
      this.PartID4 = new System.Windows.Forms.ComboBox();
      this.PartID3 = new System.Windows.Forms.ComboBox();
      this.PartID2 = new System.Windows.Forms.ComboBox();
      this.PartID1 = new System.Windows.Forms.ComboBox();
      this.btnSetMPs = new System.Windows.Forms.Button();
      this.btnUpdateMPs = new System.Windows.Forms.Button();
      this.tabCtrlOnDisp = new System.Windows.Forms.TabPage();
      this.checkBox_FOVCross = new System.Windows.Forms.CheckBox();
      this.checkBox_StatuslBar = new System.Windows.Forms.CheckBox();
      this.gBox_CtrlOnDisp_Cam2 = new System.Windows.Forms.GroupBox();
      this.checkBox_FocusFeedback2 = new System.Windows.Forms.CheckBox();
      this.checkBox_ShowStatusBar2 = new System.Windows.Forms.CheckBox();
      this.checkBox_ShowGraphics2 = new System.Windows.Forms.CheckBox();
      this.btn_StopLive2 = new System.Windows.Forms.Button();
      this.btn_SaveImg2 = new System.Windows.Forms.Button();
      this.btn_StartLive2 = new System.Windows.Forms.Button();
      this.btn_RotCCW2 = new System.Windows.Forms.Button();
      this.btn_RotCW2 = new System.Windows.Forms.Button();
      this.btn_LoadImg2 = new System.Windows.Forms.Button();
      this.btn_ZoomOut2 = new System.Windows.Forms.Button();
      this.btn_ZoomIn2 = new System.Windows.Forms.Button();
      this.btn_ZoomFit2 = new System.Windows.Forms.Button();
      this.checkBox_FovCross2 = new System.Windows.Forms.CheckBox();
      this.checkBox_LiveVideoBtnEnable = new System.Windows.Forms.CheckBox();
      this.checkBox_LoadImgBtnEnable = new System.Windows.Forms.CheckBox();
      this.checkBox_SaveImgBtnEnable = new System.Windows.Forms.CheckBox();
      this.checkBox_Graphics = new System.Windows.Forms.CheckBox();
      this.checkBox_AcceptCancelButton = new System.Windows.Forms.CheckBox();
      this.gBox_CtrlOnDisp_Cam1 = new System.Windows.Forms.GroupBox();
      this.gBox_imgFile = new System.Windows.Forms.GroupBox();
      this.chkGiveFileName = new System.Windows.Forms.CheckBox();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.chkImageSaveWithGraphics = new System.Windows.Forms.CheckBox();
      this.checkBox_FocusFeedback1 = new System.Windows.Forms.CheckBox();
      this.checkBox_ShowStatusBar1 = new System.Windows.Forms.CheckBox();
      this.checkBox_ShowGraphics1 = new System.Windows.Forms.CheckBox();
      this.btn_StopLive1 = new System.Windows.Forms.Button();
      this.btn_SaveImg1 = new System.Windows.Forms.Button();
      this.btn_StartLive1 = new System.Windows.Forms.Button();
      this.btn_RotCCW1 = new System.Windows.Forms.Button();
      this.btn_RotCW1 = new System.Windows.Forms.Button();
      this.btn_LoadImg1 = new System.Windows.Forms.Button();
      this.btn_ZoomOut1 = new System.Windows.Forms.Button();
      this.btn_ZoomIn1 = new System.Windows.Forms.Button();
      this.btn_ZoomFit1 = new System.Windows.Forms.Button();
      this.checkBox_FovCross1 = new System.Windows.Forms.CheckBox();
      this.checkBox_ToolBar = new System.Windows.Forms.CheckBox();
      this.tabCheckerCalib = new System.Windows.Forms.TabPage();
      this.groupBox14 = new System.Windows.Forms.GroupBox();
      this.groupBox17 = new System.Windows.Forms.GroupBox();
      this.btn_ChangeExpSetup_Checker = new System.Windows.Forms.Button();
      this.label93 = new System.Windows.Forms.Label();
      this.numUpDown_LightCrl_Checker = new System.Windows.Forms.NumericUpDown();
      this.label94 = new System.Windows.Forms.Label();
      this.numUpDown_Exposure_Checker = new System.Windows.Forms.NumericUpDown();
      this.checkBox_LightEn_Checker = new System.Windows.Forms.CheckBox();
      this.label90 = new System.Windows.Forms.Label();
      this.lbl_CheckerStatus = new System.Windows.Forms.Label();
      this.btn_CheckerSetRegion = new System.Windows.Forms.Button();
      this.btn_CheckerMaxRegion = new System.Windows.Forms.Button();
      this.label89 = new System.Windows.Forms.Label();
      this.numUpDown_Checker_CamID = new System.Windows.Forms.NumericUpDown();
      this.btn_CheckerCalibrate = new System.Windows.Forms.Button();
      this.numUpDown_CheckerXSpacing = new System.Windows.Forms.NumericUpDown();
      this.btn_CheckerUnCalibrate = new System.Windows.Forms.Button();
      this.label91 = new System.Windows.Forms.Label();
      this.label92 = new System.Windows.Forms.Label();
      this.numUpDown_CheckerYSpacing = new System.Windows.Forms.NumericUpDown();
      this.tabExposure = new System.Windows.Forms.TabPage();
      this.gBox_ExposureSetting_Cam2 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.numUpDown_ExposureID_Cam2 = new System.Windows.Forms.NumericUpDown();
      this.groupBox23 = new System.Windows.Forms.GroupBox();
      this.btn_ChangeExpSetup_Cam2 = new System.Windows.Forms.Button();
      this.label46 = new System.Windows.Forms.Label();
      this.numUpDown_LightCrl_Cam2 = new System.Windows.Forms.NumericUpDown();
      this.label50 = new System.Windows.Forms.Label();
      this.numUpDown_Exposure_Cam2 = new System.Windows.Forms.NumericUpDown();
      this.checkBox_LightEn_Cam2 = new System.Windows.Forms.CheckBox();
      this.gBox_ExposureSetting_Cam1 = new System.Windows.Forms.GroupBox();
      this.groupBox11 = new System.Windows.Forms.GroupBox();
      this.btn_AutoExpSetRegion_Cam1 = new System.Windows.Forms.Button();
      this.label88 = new System.Windows.Forms.Label();
      this.btn_AutoExpCancel_Cam1 = new System.Windows.Forms.Button();
      this.lbl_AutoExpStatus_Cam1 = new System.Windows.Forms.Label();
      this.btn_AutoExpStart_Cam1 = new System.Windows.Forms.Button();
      this.label83 = new System.Windows.Forms.Label();
      this.numUpDown_ExposureID_Cam1 = new System.Windows.Forms.NumericUpDown();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btn_ChangeExpSetup_Cam1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.numUpDown_LightCrl_Cam1 = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.numUpDown_Exposure_Cam1 = new System.Windows.Forms.NumericUpDown();
      this.checkBox_LightEn_Cam1 = new System.Windows.Forms.CheckBox();
      this.tabFeature = new System.Windows.Forms.TabPage();
      this.numUpDown_Feature_CamID = new System.Windows.Forms.NumericUpDown();
      this.btn_AcqImageAndRun = new System.Windows.Forms.Button();
      this.numUpDown_FeatureID = new System.Windows.Forms.NumericUpDown();
      this.label53 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox19 = new System.Windows.Forms.GroupBox();
      this.label59 = new System.Windows.Forms.Label();
      this.label58 = new System.Windows.Forms.Label();
      this.lbl_TrainHeight = new System.Windows.Forms.Label();
      this.label60 = new System.Windows.Forms.Label();
      this.lbl_TrainWidth = new System.Windows.Forms.Label();
      this.label62 = new System.Windows.Forms.Label();
      this.lbl_TrainY = new System.Windows.Forms.Label();
      this.label64 = new System.Windows.Forms.Label();
      this.lbl_TrainX = new System.Windows.Forms.Label();
      this.btn_GetTrainRegion = new System.Windows.Forms.Button();
      this.groupBox18 = new System.Windows.Forms.GroupBox();
      this.btn_ChangeSearchParams = new System.Windows.Forms.Button();
      this.checkBox_ClutterEn = new System.Windows.Forms.CheckBox();
      this.numUpDown_Contrast = new System.Windows.Forms.NumericUpDown();
      this.label48 = new System.Windows.Forms.Label();
      this.numUpDown_Angle = new System.Windows.Forms.NumericUpDown();
      this.label52 = new System.Windows.Forms.Label();
      this.label56 = new System.Windows.Forms.Label();
      this.numUpDown_Score = new System.Windows.Forms.NumericUpDown();
      this.numUpDown_Scale = new System.Windows.Forms.NumericUpDown();
      this.label54 = new System.Windows.Forms.Label();
      this.label57 = new System.Windows.Forms.Label();
      this.comboBox_Graphics = new System.Windows.Forms.ComboBox();
      this.checkBox_SearchInfoEn = new System.Windows.Forms.CheckBox();
      this.groupBox16 = new System.Windows.Forms.GroupBox();
      this.label51 = new System.Windows.Forms.Label();
      this.lbl_ResultScore = new System.Windows.Forms.Label();
      this.label49 = new System.Windows.Forms.Label();
      this.lbl_ResultAngle = new System.Windows.Forms.Label();
      this.label47 = new System.Windows.Forms.Label();
      this.lbl_ResultY = new System.Windows.Forms.Label();
      this.label45 = new System.Windows.Forms.Label();
      this.lbl_ResultX = new System.Windows.Forms.Label();
      this.btn_GetResult = new System.Windows.Forms.Button();
      this.btn_Cancel = new System.Windows.Forms.Button();
      this.btn_Accept = new System.Windows.Forms.Button();
      this.btn_PatternOrigin = new System.Windows.Forms.Button();
      this.btn_MaxSearchRegion = new System.Windows.Forms.Button();
      this.btn_TrainRegion = new System.Windows.Forms.Button();
      this.btn_SearchRegion = new System.Windows.Forms.Button();
      this.tabSNTP = new System.Windows.Forms.TabPage();
      this.lblSNTPVersion = new System.Windows.Forms.Label();
      this.btnSNTPSetting = new System.Windows.Forms.Button();
      this.txtUsedSNTPServerIP = new System.Windows.Forms.TextBox();
      this.label70 = new System.Windows.Forms.Label();
      this.numSNTPInterval = new System.Windows.Forms.NumericUpDown();
      this.label69 = new System.Windows.Forms.Label();
      this.label68 = new System.Windows.Forms.Label();
      this.txtSNTPServerIP = new System.Windows.Forms.TextBox();
      this.chkSummerTime = new System.Windows.Forms.CheckBox();
      this.label65 = new System.Windows.Forms.Label();
      this.cbTimeZone = new System.Windows.Forms.ComboBox();
      this.chkSNTP = new System.Windows.Forms.CheckBox();
      this.tabFTP = new System.Windows.Forms.TabPage();
      this.btnFTP = new System.Windows.Forms.Button();
      this.groupBox22 = new System.Windows.Forms.GroupBox();
      this.label76 = new System.Windows.Forms.Label();
      this.cbFTPImgSize = new System.Windows.Forms.ComboBox();
      this.chkFTPImgGraphics = new System.Windows.Forms.CheckBox();
      this.chkFTPImgFail = new System.Windows.Forms.CheckBox();
      this.chkFTPImgAlign = new System.Windows.Forms.CheckBox();
      this.chkFTPImgTrain = new System.Windows.Forms.CheckBox();
      this.groupBox21 = new System.Windows.Forms.GroupBox();
      this.chkFTPImgNameDate = new System.Windows.Forms.CheckBox();
      this.chkFTPImgNameTime = new System.Windows.Forms.CheckBox();
      this.chkFTPImage = new System.Windows.Forms.CheckBox();
      this.chkFTPLog = new System.Windows.Forms.CheckBox();
      this.chkFTPPassive = new System.Windows.Forms.CheckBox();
      this.txtFTPDefaultGateway = new System.Windows.Forms.TextBox();
      this.label75 = new System.Windows.Forms.Label();
      this.numFTPPort = new System.Windows.Forms.NumericUpDown();
      this.label74 = new System.Windows.Forms.Label();
      this.txtFTPPassword = new System.Windows.Forms.TextBox();
      this.txtFTPUser = new System.Windows.Forms.TextBox();
      this.txtFTPServer = new System.Windows.Forms.TextBox();
      this.label73 = new System.Windows.Forms.Label();
      this.label72 = new System.Windows.Forms.Label();
      this.label71 = new System.Windows.Forms.Label();
      this.chkFTPRecipe = new System.Windows.Forms.CheckBox();
      this.tabHeResults = new System.Windows.Forms.TabPage();
      this.label81 = new System.Windows.Forms.Label();
      this.btnGetHeResults = new System.Windows.Forms.Button();
      this.CameraIndex = new System.Windows.Forms.NumericUpDown();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.icon_Connected = new System.Windows.Forms.Button();
      this.label43 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.lbl_CurrSystemDescription = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.lbl_CurrSystemName = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.btn_Cam2AcqImage = new System.Windows.Forms.Button();
      this.btn_Disconnect = new System.Windows.Forms.Button();
      this.label44 = new System.Windows.Forms.Label();
      this.groupBox10 = new System.Windows.Forms.GroupBox();
      this.groupBox20 = new System.Windows.Forms.GroupBox();
      this.btn_DisconnectCommand = new System.Windows.Forms.Button();
      this.btn_SendCommand = new System.Windows.Forms.Button();
      this.label66 = new System.Windows.Forms.Label();
      this.txtBox_ReceivedResponse = new System.Windows.Forms.TextBox();
      this.label67 = new System.Windows.Forms.Label();
      this.txtBox_SentCommand = new System.Windows.Forms.TextBox();
      this.txtBox_PortNumber_Command = new System.Windows.Forms.TextBox();
      this.txtBox_IPAddress_Command = new System.Windows.Forms.TextBox();
      this.label63 = new System.Windows.Forms.Label();
      this.btn_ConnectCommand = new System.Windows.Forms.Button();
      this.label61 = new System.Windows.Forms.Label();
      this.btn_Auxiliary1 = new System.Windows.Forms.Button();
      this.groupBox26 = new System.Windows.Forms.GroupBox();
      this.btn_Auxiliary3 = new System.Windows.Forms.Button();
      this.btn_Auxiliary2 = new System.Windows.Forms.Button();
      this.label55 = new System.Windows.Forms.Label();
      this.btnLogging = new System.Windows.Forms.Button();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.alignSystemDisplay = new Cognex.AlignmentSDK.Controls.AlignSystemDisplay();
      this.btnManualAlign = new System.Windows.Forms.Button();
      this.chkAttachEvent = new System.Windows.Forms.CheckBox();
      this.label96 = new System.Windows.Forms.Label();
      this.label97 = new System.Windows.Forms.Label();
      this.lblRsltChangedCount = new System.Windows.Forms.Label();
      this.lblLoadCompletedCount = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabSysMgmt.SuspendLayout();
      this.gBox_SelectedCamNetInfo.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.tabSysSetup.SuspendLayout();
      this.groupBox15.SuspendLayout();
      this.gBox_AutoCalib_Cam2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStepX2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepT2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepY2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmax2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmin2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmin2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmax2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmax2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmin2)).BeginInit();
      this.gBox_AutoCalib_Cam1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStepX1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepT1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepY1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmax1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmin1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmin1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmax1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmax1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmin1)).BeginInit();
      this.groupBox13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PortNumber)).BeginInit();
      this.groupBox12.SuspendLayout();
      this.tabRecipeMgmt.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numRecipeID)).BeginInit();
      this.groupBox7.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.tabRecipeSettings.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numLCUpperLim)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numLCLowLim)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.tabCtrlOnDisp.SuspendLayout();
      this.gBox_CtrlOnDisp_Cam2.SuspendLayout();
      this.gBox_CtrlOnDisp_Cam1.SuspendLayout();
      this.gBox_imgFile.SuspendLayout();
      this.tabCheckerCalib.SuspendLayout();
      this.groupBox14.SuspendLayout();
      this.groupBox17.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Checker)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Checker)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Checker_CamID)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CheckerXSpacing)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CheckerYSpacing)).BeginInit();
      this.tabExposure.SuspendLayout();
      this.gBox_ExposureSetting_Cam2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ExposureID_Cam2)).BeginInit();
      this.groupBox23.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Cam2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Cam2)).BeginInit();
      this.gBox_ExposureSetting_Cam1.SuspendLayout();
      this.groupBox11.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ExposureID_Cam1)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Cam1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Cam1)).BeginInit();
      this.tabFeature.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Feature_CamID)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_FeatureID)).BeginInit();
      this.groupBox19.SuspendLayout();
      this.groupBox18.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Contrast)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Angle)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Score)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Scale)).BeginInit();
      this.groupBox16.SuspendLayout();
      this.tabSNTP.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numSNTPInterval)).BeginInit();
      this.tabFTP.SuspendLayout();
      this.groupBox22.SuspendLayout();
      this.groupBox21.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numFTPPort)).BeginInit();
      this.tabHeResults.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CameraIndex)).BeginInit();
      this.groupBox8.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.groupBox20.SuspendLayout();
      this.groupBox26.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_Connect
      // 
      this.btn_Connect.BackColor = System.Drawing.Color.Lime;
      this.btn_Connect.Location = new System.Drawing.Point(9, 45);
      this.btn_Connect.Name = "btn_Connect";
      this.btn_Connect.Size = new System.Drawing.Size(69, 21);
      this.btn_Connect.TabIndex = 1;
      this.btn_Connect.Text = "Connect";
      this.btn_Connect.UseVisualStyleBackColor = false;
      this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
      // 
      // btn_Cam1AcqImage
      // 
      this.btn_Cam1AcqImage.BackColor = System.Drawing.Color.Lime;
      this.btn_Cam1AcqImage.Location = new System.Drawing.Point(13, 18);
      this.btn_Cam1AcqImage.Name = "btn_Cam1AcqImage";
      this.btn_Cam1AcqImage.Size = new System.Drawing.Size(131, 21);
      this.btn_Cam1AcqImage.TabIndex = 2;
      this.btn_Cam1AcqImage.Text = "Cam1 Acquire Image";
      this.btn_Cam1AcqImage.UseVisualStyleBackColor = false;
      this.btn_Cam1AcqImage.Click += new System.EventHandler(this.btn_Cam1AcqImage_Click);
      // 
      // txtBox_IPAddress
      // 
      this.txtBox_IPAddress.Location = new System.Drawing.Point(77, 20);
      this.txtBox_IPAddress.Name = "txtBox_IPAddress";
      this.txtBox_IPAddress.Size = new System.Drawing.Size(82, 19);
      this.txtBox_IPAddress.TabIndex = 3;
      this.txtBox_IPAddress.Text = "192.168.0.2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 12);
      this.label1.TabIndex = 4;
      this.label1.Text = "IP Address";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabSysMgmt);
      this.tabControl1.Controls.Add(this.tabSysSetup);
      this.tabControl1.Controls.Add(this.tabRecipeMgmt);
      this.tabControl1.Controls.Add(this.tabRecipeSettings);
      this.tabControl1.Controls.Add(this.tabCtrlOnDisp);
      this.tabControl1.Controls.Add(this.tabCheckerCalib);
      this.tabControl1.Controls.Add(this.tabExposure);
      this.tabControl1.Controls.Add(this.tabFeature);
      this.tabControl1.Controls.Add(this.tabSNTP);
      this.tabControl1.Controls.Add(this.tabFTP);
      this.tabControl1.Controls.Add(this.tabHeResults);
      this.tabControl1.Location = new System.Drawing.Point(611, 109);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(525, 440);
      this.tabControl1.TabIndex = 5;
      // 
      // tabSysMgmt
      // 
      this.tabSysMgmt.Controls.Add(this.txtSpecialInternalDataFolder);
      this.tabSysMgmt.Controls.Add(this.chkUseSpecialInternalDataFolder);
      this.tabSysMgmt.Controls.Add(this.btn_DisconnectSystem);
      this.tabSysMgmt.Controls.Add(this.btn_ConnectSystem);
      this.tabSysMgmt.Controls.Add(this.btn_RemoveSystem);
      this.tabSysMgmt.Controls.Add(this.gBox_SelectedCamNetInfo);
      this.tabSysMgmt.Controls.Add(this.btn_RestoreSys);
      this.tabSysMgmt.Controls.Add(this.groupBox9);
      this.tabSysMgmt.Controls.Add(this.list_Cameras);
      this.tabSysMgmt.Controls.Add(this.btn_SelectSystem);
      this.tabSysMgmt.Controls.Add(this.btn_BackupSys);
      this.tabSysMgmt.Controls.Add(this.label25);
      this.tabSysMgmt.Controls.Add(this.btn_Update_CamList_CurrSysInfo);
      this.tabSysMgmt.Location = new System.Drawing.Point(4, 22);
      this.tabSysMgmt.Name = "tabSysMgmt";
      this.tabSysMgmt.Padding = new System.Windows.Forms.Padding(3);
      this.tabSysMgmt.Size = new System.Drawing.Size(517, 414);
      this.tabSysMgmt.TabIndex = 0;
      this.tabSysMgmt.Text = "Sys Mgmt";
      this.tabSysMgmt.UseVisualStyleBackColor = true;
      // 
      // txtSpecialInternalDataFolder
      // 
      this.txtSpecialInternalDataFolder.Location = new System.Drawing.Point(349, 10);
      this.txtSpecialInternalDataFolder.Name = "txtSpecialInternalDataFolder";
      this.txtSpecialInternalDataFolder.Size = new System.Drawing.Size(134, 19);
      this.txtSpecialInternalDataFolder.TabIndex = 28;
      this.txtSpecialInternalDataFolder.Text = "C:\\temp\\Test\\";
      this.txtSpecialInternalDataFolder.TextChanged += new System.EventHandler(this.txtSpecialInternalDataFolder_TextChanged);
      // 
      // chkUseSpecialInternalDataFolder
      // 
      this.chkUseSpecialInternalDataFolder.AutoSize = true;
      this.chkUseSpecialInternalDataFolder.Location = new System.Drawing.Point(227, 12);
      this.chkUseSpecialInternalDataFolder.Name = "chkUseSpecialInternalDataFolder";
      this.chkUseSpecialInternalDataFolder.Size = new System.Drawing.Size(122, 16);
      this.chkUseSpecialInternalDataFolder.TabIndex = 27;
      this.chkUseSpecialInternalDataFolder.Text = "Change App Folder";
      this.chkUseSpecialInternalDataFolder.UseVisualStyleBackColor = true;
      this.chkUseSpecialInternalDataFolder.CheckedChanged += new System.EventHandler(this.chkUseSpecialInternalDataFolder_CheckedChanged);
      // 
      // btn_DisconnectSystem
      // 
      this.btn_DisconnectSystem.BackColor = System.Drawing.Color.Lime;
      this.btn_DisconnectSystem.Location = new System.Drawing.Point(233, 228);
      this.btn_DisconnectSystem.Name = "btn_DisconnectSystem";
      this.btn_DisconnectSystem.Size = new System.Drawing.Size(91, 22);
      this.btn_DisconnectSystem.TabIndex = 26;
      this.btn_DisconnectSystem.Text = "Disconn Sys";
      this.btn_DisconnectSystem.UseVisualStyleBackColor = false;
      this.btn_DisconnectSystem.Click += new System.EventHandler(this.btn_DisconnectSystem_Click);
      // 
      // btn_ConnectSystem
      // 
      this.btn_ConnectSystem.BackColor = System.Drawing.Color.Lime;
      this.btn_ConnectSystem.Location = new System.Drawing.Point(233, 200);
      this.btn_ConnectSystem.Name = "btn_ConnectSystem";
      this.btn_ConnectSystem.Size = new System.Drawing.Size(91, 22);
      this.btn_ConnectSystem.TabIndex = 25;
      this.btn_ConnectSystem.Text = "Connect Sys";
      this.btn_ConnectSystem.UseVisualStyleBackColor = false;
      this.btn_ConnectSystem.Click += new System.EventHandler(this.btn_ConnectSystem_Click);
      // 
      // btn_RemoveSystem
      // 
      this.btn_RemoveSystem.BackColor = System.Drawing.Color.Lime;
      this.btn_RemoveSystem.Location = new System.Drawing.Point(330, 225);
      this.btn_RemoveSystem.Name = "btn_RemoveSystem";
      this.btn_RemoveSystem.Size = new System.Drawing.Size(126, 22);
      this.btn_RemoveSystem.TabIndex = 24;
      this.btn_RemoveSystem.Text = "Remove Selected Sys";
      this.btn_RemoveSystem.UseVisualStyleBackColor = false;
      this.btn_RemoveSystem.Click += new System.EventHandler(this.btn_RemoveSystem_Click);
      // 
      // gBox_SelectedCamNetInfo
      // 
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamMACAdd);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label99);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamGateway);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamDNS);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamDomainName);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamSubMask);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamIPAdd);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.txtBox_SelectedCamName);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.btn_ChangeCamNetInfo);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.checkBox_IsDHCP);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label39);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label38);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label37);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label26);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label21);
      this.gBox_SelectedCamNetInfo.Controls.Add(this.label18);
      this.gBox_SelectedCamNetInfo.Enabled = false;
      this.gBox_SelectedCamNetInfo.Location = new System.Drawing.Point(10, 200);
      this.gBox_SelectedCamNetInfo.Name = "gBox_SelectedCamNetInfo";
      this.gBox_SelectedCamNetInfo.Size = new System.Drawing.Size(209, 207);
      this.gBox_SelectedCamNetInfo.TabIndex = 23;
      this.gBox_SelectedCamNetInfo.TabStop = false;
      this.gBox_SelectedCamNetInfo.Text = "Selected Camera Network Info";
      // 
      // txtBox_SelectedCamMACAdd
      // 
      this.txtBox_SelectedCamMACAdd.Enabled = false;
      this.txtBox_SelectedCamMACAdd.Location = new System.Drawing.Point(90, 43);
      this.txtBox_SelectedCamMACAdd.Name = "txtBox_SelectedCamMACAdd";
      this.txtBox_SelectedCamMACAdd.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamMACAdd.TabIndex = 40;
      // 
      // label99
      // 
      this.label99.Location = new System.Drawing.Point(3, 43);
      this.label99.Name = "label99";
      this.label99.Size = new System.Drawing.Size(90, 18);
      this.label99.TabIndex = 39;
      this.label99.Text = "MAC Address  :";
      this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txtBox_SelectedCamGateway
      // 
      this.txtBox_SelectedCamGateway.Location = new System.Drawing.Point(90, 153);
      this.txtBox_SelectedCamGateway.Name = "txtBox_SelectedCamGateway";
      this.txtBox_SelectedCamGateway.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamGateway.TabIndex = 38;
      // 
      // txtBox_SelectedCamDNS
      // 
      this.txtBox_SelectedCamDNS.Location = new System.Drawing.Point(90, 131);
      this.txtBox_SelectedCamDNS.Name = "txtBox_SelectedCamDNS";
      this.txtBox_SelectedCamDNS.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamDNS.TabIndex = 37;
      // 
      // txtBox_SelectedCamDomainName
      // 
      this.txtBox_SelectedCamDomainName.Location = new System.Drawing.Point(90, 109);
      this.txtBox_SelectedCamDomainName.Name = "txtBox_SelectedCamDomainName";
      this.txtBox_SelectedCamDomainName.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamDomainName.TabIndex = 36;
      // 
      // txtBox_SelectedCamSubMask
      // 
      this.txtBox_SelectedCamSubMask.Location = new System.Drawing.Point(90, 87);
      this.txtBox_SelectedCamSubMask.Name = "txtBox_SelectedCamSubMask";
      this.txtBox_SelectedCamSubMask.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamSubMask.TabIndex = 35;
      // 
      // txtBox_SelectedCamIPAdd
      // 
      this.txtBox_SelectedCamIPAdd.Location = new System.Drawing.Point(90, 65);
      this.txtBox_SelectedCamIPAdd.Name = "txtBox_SelectedCamIPAdd";
      this.txtBox_SelectedCamIPAdd.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamIPAdd.TabIndex = 34;
      // 
      // txtBox_SelectedCamName
      // 
      this.txtBox_SelectedCamName.Location = new System.Drawing.Point(90, 21);
      this.txtBox_SelectedCamName.Name = "txtBox_SelectedCamName";
      this.txtBox_SelectedCamName.Size = new System.Drawing.Size(115, 19);
      this.txtBox_SelectedCamName.TabIndex = 33;
      // 
      // btn_ChangeCamNetInfo
      // 
      this.btn_ChangeCamNetInfo.Location = new System.Drawing.Point(79, 177);
      this.btn_ChangeCamNetInfo.Name = "btn_ChangeCamNetInfo";
      this.btn_ChangeCamNetInfo.Size = new System.Drawing.Size(126, 22);
      this.btn_ChangeCamNetInfo.TabIndex = 32;
      this.btn_ChangeCamNetInfo.Text = "Change Cam Net Info";
      this.btn_ChangeCamNetInfo.UseVisualStyleBackColor = true;
      this.btn_ChangeCamNetInfo.Click += new System.EventHandler(this.btn_ChangeCamNetInfo_Click);
      // 
      // checkBox_IsDHCP
      // 
      this.checkBox_IsDHCP.AutoSize = true;
      this.checkBox_IsDHCP.Enabled = false;
      this.checkBox_IsDHCP.Location = new System.Drawing.Point(4, 180);
      this.checkBox_IsDHCP.Name = "checkBox_IsDHCP";
      this.checkBox_IsDHCP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_IsDHCP.Size = new System.Drawing.Size(68, 16);
      this.checkBox_IsDHCP.TabIndex = 31;
      this.checkBox_IsDHCP.Text = "Is DHCP";
      this.checkBox_IsDHCP.UseVisualStyleBackColor = true;
      // 
      // label39
      // 
      this.label39.Location = new System.Drawing.Point(4, 154);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(90, 18);
      this.label39.TabIndex = 30;
      this.label39.Text = "Gateway IPAdd:";
      this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label38
      // 
      this.label38.Location = new System.Drawing.Point(4, 133);
      this.label38.Name = "label38";
      this.label38.Size = new System.Drawing.Size(80, 18);
      this.label38.TabIndex = 28;
      this.label38.Text = "DNS IP Add :";
      this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label37
      // 
      this.label37.Location = new System.Drawing.Point(4, 111);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(80, 18);
      this.label37.TabIndex = 26;
      this.label37.Text = "Domain Name:";
      this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label26
      // 
      this.label26.Location = new System.Drawing.Point(4, 89);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(80, 18);
      this.label26.TabIndex = 24;
      this.label26.Text = "Subnet Mask :";
      this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label21
      // 
      this.label21.Location = new System.Drawing.Point(4, 66);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(80, 18);
      this.label21.TabIndex = 22;
      this.label21.Text = "IP Address :";
      this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label18
      // 
      this.label18.Location = new System.Drawing.Point(3, 21);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(90, 18);
      this.label18.TabIndex = 20;
      this.label18.Text = "Camera Name :";
      this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_RestoreSys
      // 
      this.btn_RestoreSys.BackColor = System.Drawing.Color.Lime;
      this.btn_RestoreSys.Location = new System.Drawing.Point(358, 384);
      this.btn_RestoreSys.Name = "btn_RestoreSys";
      this.btn_RestoreSys.Size = new System.Drawing.Size(117, 21);
      this.btn_RestoreSys.TabIndex = 9;
      this.btn_RestoreSys.Text = "Restore Sys Setting";
      this.btn_RestoreSys.UseVisualStyleBackColor = false;
      this.btn_RestoreSys.Click += new System.EventHandler(this.btn_RestoreSys_Click);
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.checkBox_LowerIsMaster);
      this.groupBox9.Controls.Add(this.label16);
      this.groupBox9.Controls.Add(this.txtBox_NewSysName);
      this.groupBox9.Controls.Add(this.label17);
      this.groupBox9.Controls.Add(this.btn_CreateSys);
      this.groupBox9.Controls.Add(this.txtBox_NewSysDescription);
      this.groupBox9.Location = new System.Drawing.Point(237, 259);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(208, 120);
      this.groupBox9.TabIndex = 18;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Create System using Selected Cams";
      // 
      // checkBox_LowerIsMaster
      // 
      this.checkBox_LowerIsMaster.AutoSize = true;
      this.checkBox_LowerIsMaster.Location = new System.Drawing.Point(4, 92);
      this.checkBox_LowerIsMaster.Name = "checkBox_LowerIsMaster";
      this.checkBox_LowerIsMaster.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_LowerIsMaster.Size = new System.Drawing.Size(131, 16);
      this.checkBox_LowerIsMaster.TabIndex = 32;
      this.checkBox_LowerIsMaster.Text = "Lower cam is Master";
      this.checkBox_LowerIsMaster.UseVisualStyleBackColor = true;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Location = new System.Drawing.Point(6, 23);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(82, 12);
      this.label16.TabIndex = 7;
      this.label16.Text = "System Name :";
      // 
      // txtBox_NewSysName
      // 
      this.txtBox_NewSysName.Location = new System.Drawing.Point(98, 19);
      this.txtBox_NewSysName.Name = "txtBox_NewSysName";
      this.txtBox_NewSysName.Size = new System.Drawing.Size(104, 19);
      this.txtBox_NewSysName.TabIndex = 6;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(6, 45);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(111, 12);
      this.label17.TabIndex = 8;
      this.label17.Text = "System Description :";
      // 
      // btn_CreateSys
      // 
      this.btn_CreateSys.BackColor = System.Drawing.Color.Lime;
      this.btn_CreateSys.Location = new System.Drawing.Point(150, 87);
      this.btn_CreateSys.Name = "btn_CreateSys";
      this.btn_CreateSys.Size = new System.Drawing.Size(52, 26);
      this.btn_CreateSys.TabIndex = 15;
      this.btn_CreateSys.Text = "Create";
      this.btn_CreateSys.UseVisualStyleBackColor = false;
      this.btn_CreateSys.Click += new System.EventHandler(this.btn_CreateSys_Click);
      // 
      // txtBox_NewSysDescription
      // 
      this.txtBox_NewSysDescription.Location = new System.Drawing.Point(10, 62);
      this.txtBox_NewSysDescription.Name = "txtBox_NewSysDescription";
      this.txtBox_NewSysDescription.Size = new System.Drawing.Size(192, 19);
      this.txtBox_NewSysDescription.TabIndex = 9;
      // 
      // list_Cameras
      // 
      this.list_Cameras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_Camera_Name,
            this.list_Camera_IPAddress,
            this.list_System_Name,
            this.list_IsMaster,
            this.list_IsConnected,
            this.list_IsCurrent,
            this.list_Model_Number});
      this.list_Cameras.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.list_Cameras.FullRowSelect = true;
      this.list_Cameras.GridLines = true;
      listViewGroup1.Header = "Configured";
      listViewGroup1.Name = "Configured";
      listViewGroup2.Header = "Unconfigured";
      listViewGroup2.Name = "Unconfigured";
      listViewGroup3.Header = "On Different Network";
      listViewGroup3.Name = "On Different Network";
      this.list_Cameras.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
      this.list_Cameras.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.list_Cameras.HideSelection = false;
      this.list_Cameras.LabelWrap = false;
      this.list_Cameras.Location = new System.Drawing.Point(10, 36);
      this.list_Cameras.Name = "list_Cameras";
      this.list_Cameras.Size = new System.Drawing.Size(473, 158);
      this.list_Cameras.TabIndex = 17;
      this.list_Cameras.UseCompatibleStateImageBehavior = false;
      this.list_Cameras.View = System.Windows.Forms.View.Details;
      this.list_Cameras.SelectedIndexChanged += new System.EventHandler(this.list_Cameras_SelectedIndexChanged);
      // 
      // list_Camera_Name
      // 
      this.list_Camera_Name.Text = "Camera Name";
      this.list_Camera_Name.Width = 94;
      // 
      // list_Camera_IPAddress
      // 
      this.list_Camera_IPAddress.Text = "IP Address";
      this.list_Camera_IPAddress.Width = 86;
      // 
      // list_System_Name
      // 
      this.list_System_Name.Text = "Sys Name";
      this.list_System_Name.Width = 70;
      // 
      // list_IsMaster
      // 
      this.list_IsMaster.Text = "Master";
      this.list_IsMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.list_IsMaster.Width = 50;
      // 
      // list_IsConnected
      // 
      this.list_IsConnected.Text = "Conn";
      this.list_IsConnected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.list_IsConnected.Width = 38;
      // 
      // list_IsCurrent
      // 
      this.list_IsCurrent.Text = "Curr";
      this.list_IsCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.list_IsCurrent.Width = 38;
      // 
      // list_Model_Number
      // 
      this.list_Model_Number.Text = "Model Num";
      this.list_Model_Number.Width = 70;
      // 
      // btn_SelectSystem
      // 
      this.btn_SelectSystem.BackColor = System.Drawing.Color.Lime;
      this.btn_SelectSystem.Location = new System.Drawing.Point(330, 200);
      this.btn_SelectSystem.Name = "btn_SelectSystem";
      this.btn_SelectSystem.Size = new System.Drawing.Size(126, 22);
      this.btn_SelectSystem.TabIndex = 14;
      this.btn_SelectSystem.Text = "Set Current Sys";
      this.btn_SelectSystem.UseVisualStyleBackColor = false;
      this.btn_SelectSystem.Click += new System.EventHandler(this.btn_SetCurrentSystem_Click);
      // 
      // btn_BackupSys
      // 
      this.btn_BackupSys.BackColor = System.Drawing.Color.Lime;
      this.btn_BackupSys.Location = new System.Drawing.Point(236, 385);
      this.btn_BackupSys.Name = "btn_BackupSys";
      this.btn_BackupSys.Size = new System.Drawing.Size(116, 21);
      this.btn_BackupSys.TabIndex = 8;
      this.btn_BackupSys.Text = "Backup Sys Setting";
      this.btn_BackupSys.UseVisualStyleBackColor = false;
      this.btn_BackupSys.Click += new System.EventHandler(this.btn_BackupSys_Click);
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Location = new System.Drawing.Point(13, 13);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(73, 12);
      this.label25.TabIndex = 13;
      this.label25.Text = "Camera List :";
      // 
      // btn_Update_CamList_CurrSysInfo
      // 
      this.btn_Update_CamList_CurrSysInfo.BackColor = System.Drawing.Color.Lime;
      this.btn_Update_CamList_CurrSysInfo.Location = new System.Drawing.Point(88, 8);
      this.btn_Update_CamList_CurrSysInfo.Name = "btn_Update_CamList_CurrSysInfo";
      this.btn_Update_CamList_CurrSysInfo.Size = new System.Drawing.Size(80, 22);
      this.btn_Update_CamList_CurrSysInfo.TabIndex = 12;
      this.btn_Update_CamList_CurrSysInfo.Text = "Update List";
      this.btn_Update_CamList_CurrSysInfo.UseVisualStyleBackColor = false;
      this.btn_Update_CamList_CurrSysInfo.Click += new System.EventHandler(this.btn_Update_CamList_CurrSysInfo_Click);
      // 
      // tabSysSetup
      // 
      this.tabSysSetup.Controls.Add(this.checkBox_RetainPoses);
      this.tabSysSetup.Controls.Add(this.comboBox_DispImgResolution2);
      this.tabSysSetup.Controls.Add(this.label42);
      this.tabSysSetup.Controls.Add(this.label41);
      this.tabSysSetup.Controls.Add(this.comboBox_DispImgResolution1);
      this.tabSysSetup.Controls.Add(this.label40);
      this.tabSysSetup.Controls.Add(this.groupBox15);
      this.tabSysSetup.Controls.Add(this.groupBox13);
      this.tabSysSetup.Controls.Add(this.groupBox12);
      this.tabSysSetup.Controls.Add(this.btn_ChangeSysSettings);
      this.tabSysSetup.Location = new System.Drawing.Point(4, 22);
      this.tabSysSetup.Name = "tabSysSetup";
      this.tabSysSetup.Padding = new System.Windows.Forms.Padding(3);
      this.tabSysSetup.Size = new System.Drawing.Size(517, 414);
      this.tabSysSetup.TabIndex = 5;
      this.tabSysSetup.Text = "Sys Setup";
      this.tabSysSetup.UseVisualStyleBackColor = true;
      // 
      // checkBox_RetainPoses
      // 
      this.checkBox_RetainPoses.AutoSize = true;
      this.checkBox_RetainPoses.Location = new System.Drawing.Point(21, 277);
      this.checkBox_RetainPoses.Name = "checkBox_RetainPoses";
      this.checkBox_RetainPoses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_RetainPoses.Size = new System.Drawing.Size(92, 16);
      this.checkBox_RetainPoses.TabIndex = 44;
      this.checkBox_RetainPoses.Text = "Retain Poses";
      this.checkBox_RetainPoses.UseVisualStyleBackColor = true;
      // 
      // comboBox_DispImgResolution2
      // 
      this.comboBox_DispImgResolution2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_DispImgResolution2.FormattingEnabled = true;
      this.comboBox_DispImgResolution2.Items.AddRange(new object[] {
            "Optimized",
            "Full",
            "Half",
            "Quarter",
            "Eighth"});
      this.comboBox_DispImgResolution2.Location = new System.Drawing.Point(99, 235);
      this.comboBox_DispImgResolution2.Name = "comboBox_DispImgResolution2";
      this.comboBox_DispImgResolution2.Size = new System.Drawing.Size(83, 20);
      this.comboBox_DispImgResolution2.TabIndex = 43;
      // 
      // label42
      // 
      this.label42.AutoSize = true;
      this.label42.Location = new System.Drawing.Point(65, 239);
      this.label42.Name = "label42";
      this.label42.Size = new System.Drawing.Size(34, 12);
      this.label42.TabIndex = 42;
      this.label42.Text = "Cam2";
      // 
      // label41
      // 
      this.label41.AutoSize = true;
      this.label41.Location = new System.Drawing.Point(65, 213);
      this.label41.Name = "label41";
      this.label41.Size = new System.Drawing.Size(34, 12);
      this.label41.TabIndex = 41;
      this.label41.Text = "Cam1";
      // 
      // comboBox_DispImgResolution1
      // 
      this.comboBox_DispImgResolution1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_DispImgResolution1.FormattingEnabled = true;
      this.comboBox_DispImgResolution1.Items.AddRange(new object[] {
            "Optimized",
            "Full",
            "Half",
            "Quarter",
            "Eighth"});
      this.comboBox_DispImgResolution1.Location = new System.Drawing.Point(99, 209);
      this.comboBox_DispImgResolution1.Name = "comboBox_DispImgResolution1";
      this.comboBox_DispImgResolution1.Size = new System.Drawing.Size(83, 20);
      this.comboBox_DispImgResolution1.TabIndex = 40;
      // 
      // label40
      // 
      this.label40.AutoSize = true;
      this.label40.Location = new System.Drawing.Point(23, 194);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(123, 12);
      this.label40.TabIndex = 39;
      this.label40.Text = "Display Img Resolution";
      // 
      // groupBox15
      // 
      this.groupBox15.Controls.Add(this.gBox_AutoCalib_Cam2);
      this.groupBox15.Controls.Add(this.gBox_AutoCalib_Cam1);
      this.groupBox15.Controls.Add(this.label36);
      this.groupBox15.Controls.Add(this.label28);
      this.groupBox15.Controls.Add(this.label35);
      this.groupBox15.Controls.Add(this.label33);
      this.groupBox15.Controls.Add(this.label24);
      this.groupBox15.Controls.Add(this.label34);
      this.groupBox15.Controls.Add(this.label29);
      this.groupBox15.Controls.Add(this.label30);
      this.groupBox15.Controls.Add(this.label31);
      this.groupBox15.Controls.Add(this.label27);
      this.groupBox15.Controls.Add(this.label32);
      this.groupBox15.Location = new System.Drawing.Point(198, 6);
      this.groupBox15.Name = "groupBox15";
      this.groupBox15.Size = new System.Drawing.Size(233, 310);
      this.groupBox15.TabIndex = 38;
      this.groupBox15.TabStop = false;
      this.groupBox15.Text = "Auto Calibration";
      // 
      // gBox_AutoCalib_Cam2
      // 
      this.gBox_AutoCalib_Cam2.Controls.Add(this.chkCantilever2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numStepX2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numStepT2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numStepY2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numTmax2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.chkAutoStep2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numTmin2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numXmin2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numYmax2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numXmax2);
      this.gBox_AutoCalib_Cam2.Controls.Add(this.numYmin2);
      this.gBox_AutoCalib_Cam2.Location = new System.Drawing.Point(165, 11);
      this.gBox_AutoCalib_Cam2.Name = "gBox_AutoCalib_Cam2";
      this.gBox_AutoCalib_Cam2.Size = new System.Drawing.Size(60, 290);
      this.gBox_AutoCalib_Cam2.TabIndex = 37;
      this.gBox_AutoCalib_Cam2.TabStop = false;
      this.gBox_AutoCalib_Cam2.Text = "Cam2";
      // 
      // chkCantilever2
      // 
      this.chkCantilever2.AutoSize = true;
      this.chkCantilever2.Location = new System.Drawing.Point(10, 269);
      this.chkCantilever2.Name = "chkCantilever2";
      this.chkCantilever2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkCantilever2.Size = new System.Drawing.Size(15, 14);
      this.chkCantilever2.TabIndex = 33;
      this.chkCantilever2.UseVisualStyleBackColor = true;
      // 
      // numStepX2
      // 
      this.numStepX2.Location = new System.Drawing.Point(7, 16);
      this.numStepX2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepX2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepX2.Name = "numStepX2";
      this.numStepX2.Size = new System.Drawing.Size(45, 19);
      this.numStepX2.TabIndex = 15;
      this.numStepX2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numStepT2
      // 
      this.numStepT2.Location = new System.Drawing.Point(7, 234);
      this.numStepT2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepT2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepT2.Name = "numStepT2";
      this.numStepT2.Size = new System.Drawing.Size(45, 19);
      this.numStepT2.TabIndex = 32;
      this.numStepT2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numStepY2
      // 
      this.numStepY2.Location = new System.Drawing.Point(7, 38);
      this.numStepY2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepY2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepY2.Name = "numStepY2";
      this.numStepY2.Size = new System.Drawing.Size(45, 19);
      this.numStepY2.TabIndex = 17;
      this.numStepY2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numTmax2
      // 
      this.numTmax2.DecimalPlaces = 1;
      this.numTmax2.Location = new System.Drawing.Point(7, 209);
      this.numTmax2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numTmax2.Name = "numTmax2";
      this.numTmax2.Size = new System.Drawing.Size(45, 19);
      this.numTmax2.TabIndex = 30;
      this.numTmax2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // chkAutoStep2
      // 
      this.chkAutoStep2.AutoSize = true;
      this.chkAutoStep2.Location = new System.Drawing.Point(9, 71);
      this.chkAutoStep2.Name = "chkAutoStep2";
      this.chkAutoStep2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkAutoStep2.Size = new System.Drawing.Size(15, 14);
      this.chkAutoStep2.TabIndex = 18;
      this.chkAutoStep2.UseVisualStyleBackColor = true;
      // 
      // numTmin2
      // 
      this.numTmin2.DecimalPlaces = 1;
      this.numTmin2.Location = new System.Drawing.Point(7, 188);
      this.numTmin2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numTmin2.Name = "numTmin2";
      this.numTmin2.Size = new System.Drawing.Size(45, 19);
      this.numTmin2.TabIndex = 28;
      this.numTmin2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numXmin2
      // 
      this.numXmin2.DecimalPlaces = 1;
      this.numXmin2.Location = new System.Drawing.Point(7, 89);
      this.numXmin2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numXmin2.Name = "numXmin2";
      this.numXmin2.Size = new System.Drawing.Size(45, 19);
      this.numXmin2.TabIndex = 20;
      this.numXmin2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numYmax2
      // 
      this.numYmax2.DecimalPlaces = 1;
      this.numYmax2.Location = new System.Drawing.Point(7, 156);
      this.numYmax2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numYmax2.Name = "numYmax2";
      this.numYmax2.Size = new System.Drawing.Size(45, 19);
      this.numYmax2.TabIndex = 26;
      this.numYmax2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numXmax2
      // 
      this.numXmax2.DecimalPlaces = 1;
      this.numXmax2.Location = new System.Drawing.Point(7, 110);
      this.numXmax2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numXmax2.Name = "numXmax2";
      this.numXmax2.Size = new System.Drawing.Size(45, 19);
      this.numXmax2.TabIndex = 22;
      this.numXmax2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numYmin2
      // 
      this.numYmin2.DecimalPlaces = 1;
      this.numYmin2.Location = new System.Drawing.Point(7, 135);
      this.numYmin2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numYmin2.Name = "numYmin2";
      this.numYmin2.Size = new System.Drawing.Size(45, 19);
      this.numYmin2.TabIndex = 24;
      this.numYmin2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // gBox_AutoCalib_Cam1
      // 
      this.gBox_AutoCalib_Cam1.Controls.Add(this.chkCantilever1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numStepX1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numStepT1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numStepY1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numTmax1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.chkAutoStep1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numTmin1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numXmin1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numYmax1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numXmax1);
      this.gBox_AutoCalib_Cam1.Controls.Add(this.numYmin1);
      this.gBox_AutoCalib_Cam1.Location = new System.Drawing.Point(99, 11);
      this.gBox_AutoCalib_Cam1.Name = "gBox_AutoCalib_Cam1";
      this.gBox_AutoCalib_Cam1.Size = new System.Drawing.Size(60, 290);
      this.gBox_AutoCalib_Cam1.TabIndex = 34;
      this.gBox_AutoCalib_Cam1.TabStop = false;
      this.gBox_AutoCalib_Cam1.Text = "Cam1";
      // 
      // chkCantilever1
      // 
      this.chkCantilever1.AutoSize = true;
      this.chkCantilever1.Location = new System.Drawing.Point(10, 269);
      this.chkCantilever1.Name = "chkCantilever1";
      this.chkCantilever1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkCantilever1.Size = new System.Drawing.Size(15, 14);
      this.chkCantilever1.TabIndex = 33;
      this.chkCantilever1.UseVisualStyleBackColor = true;
      // 
      // numStepX1
      // 
      this.numStepX1.Location = new System.Drawing.Point(7, 16);
      this.numStepX1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepX1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepX1.Name = "numStepX1";
      this.numStepX1.Size = new System.Drawing.Size(45, 19);
      this.numStepX1.TabIndex = 15;
      this.numStepX1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numStepT1
      // 
      this.numStepT1.Location = new System.Drawing.Point(7, 233);
      this.numStepT1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepT1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepT1.Name = "numStepT1";
      this.numStepT1.Size = new System.Drawing.Size(45, 19);
      this.numStepT1.TabIndex = 32;
      this.numStepT1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numStepY1
      // 
      this.numStepY1.Location = new System.Drawing.Point(7, 38);
      this.numStepY1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numStepY1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStepY1.Name = "numStepY1";
      this.numStepY1.Size = new System.Drawing.Size(45, 19);
      this.numStepY1.TabIndex = 17;
      this.numStepY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numTmax1
      // 
      this.numTmax1.DecimalPlaces = 1;
      this.numTmax1.Location = new System.Drawing.Point(7, 208);
      this.numTmax1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numTmax1.Name = "numTmax1";
      this.numTmax1.Size = new System.Drawing.Size(45, 19);
      this.numTmax1.TabIndex = 30;
      this.numTmax1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // chkAutoStep1
      // 
      this.chkAutoStep1.AutoSize = true;
      this.chkAutoStep1.Location = new System.Drawing.Point(9, 71);
      this.chkAutoStep1.Name = "chkAutoStep1";
      this.chkAutoStep1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chkAutoStep1.Size = new System.Drawing.Size(15, 14);
      this.chkAutoStep1.TabIndex = 18;
      this.chkAutoStep1.UseVisualStyleBackColor = true;
      // 
      // numTmin1
      // 
      this.numTmin1.DecimalPlaces = 1;
      this.numTmin1.Location = new System.Drawing.Point(7, 187);
      this.numTmin1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numTmin1.Name = "numTmin1";
      this.numTmin1.Size = new System.Drawing.Size(45, 19);
      this.numTmin1.TabIndex = 28;
      this.numTmin1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numXmin1
      // 
      this.numXmin1.DecimalPlaces = 1;
      this.numXmin1.Location = new System.Drawing.Point(7, 88);
      this.numXmin1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numXmin1.Name = "numXmin1";
      this.numXmin1.Size = new System.Drawing.Size(45, 19);
      this.numXmin1.TabIndex = 20;
      this.numXmin1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numYmax1
      // 
      this.numYmax1.DecimalPlaces = 1;
      this.numYmax1.Location = new System.Drawing.Point(7, 155);
      this.numYmax1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numYmax1.Name = "numYmax1";
      this.numYmax1.Size = new System.Drawing.Size(45, 19);
      this.numYmax1.TabIndex = 26;
      this.numYmax1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numXmax1
      // 
      this.numXmax1.DecimalPlaces = 1;
      this.numXmax1.Location = new System.Drawing.Point(7, 109);
      this.numXmax1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numXmax1.Name = "numXmax1";
      this.numXmax1.Size = new System.Drawing.Size(45, 19);
      this.numXmax1.TabIndex = 22;
      this.numXmax1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numYmin1
      // 
      this.numYmin1.DecimalPlaces = 1;
      this.numYmin1.Location = new System.Drawing.Point(7, 134);
      this.numYmin1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numYmin1.Name = "numYmin1";
      this.numYmin1.Size = new System.Drawing.Size(45, 19);
      this.numYmin1.TabIndex = 24;
      this.numYmin1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // label36
      // 
      this.label36.AutoSize = true;
      this.label36.Location = new System.Drawing.Point(9, 281);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(90, 12);
      this.label36.TabIndex = 36;
      this.label36.Text = "Cantilever Comp";
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.Location = new System.Drawing.Point(61, 104);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(34, 12);
      this.label28.TabIndex = 19;
      this.label28.Text = "X min";
      // 
      // label35
      // 
      this.label35.AutoSize = true;
      this.label35.Location = new System.Drawing.Point(15, 82);
      this.label35.Name = "label35";
      this.label35.Size = new System.Drawing.Size(81, 12);
      this.label35.TabIndex = 35;
      this.label35.Text = "Auto Step Size";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Location = new System.Drawing.Point(40, 224);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(59, 12);
      this.label33.TabIndex = 29;
      this.label33.Text = "Theta max";
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(27, 29);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(66, 12);
      this.label24.TabIndex = 14;
      this.label24.Text = "Num Step X";
      // 
      // label34
      // 
      this.label34.AutoSize = true;
      this.label34.Location = new System.Drawing.Point(42, 202);
      this.label34.Name = "label34";
      this.label34.Size = new System.Drawing.Size(56, 12);
      this.label34.TabIndex = 27;
      this.label34.Text = "Theta min";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Location = new System.Drawing.Point(61, 125);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(37, 12);
      this.label29.TabIndex = 21;
      this.label29.Text = "X max";
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(62, 170);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(37, 12);
      this.label30.TabIndex = 25;
      this.label30.Text = "Y max";
      // 
      // label31
      // 
      this.label31.AutoSize = true;
      this.label31.Location = new System.Drawing.Point(62, 150);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(34, 12);
      this.label31.TabIndex = 23;
      this.label31.Text = "Y min";
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Location = new System.Drawing.Point(27, 52);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(66, 12);
      this.label27.TabIndex = 16;
      this.label27.Text = "Num Step Y";
      // 
      // label32
      // 
      this.label32.AutoSize = true;
      this.label32.Location = new System.Drawing.Point(11, 249);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(88, 12);
      this.label32.TabIndex = 31;
      this.label32.Text = "Num Step Theta";
      // 
      // groupBox13
      // 
      this.groupBox13.Controls.Add(this.checkBox1);
      this.groupBox13.Controls.Add(this.numUpDown_PortNumber);
      this.groupBox13.Controls.Add(this.label20);
      this.groupBox13.Location = new System.Drawing.Point(13, 15);
      this.groupBox13.Name = "groupBox13";
      this.groupBox13.Size = new System.Drawing.Size(169, 66);
      this.groupBox13.TabIndex = 13;
      this.groupBox13.TabStop = false;
      this.groupBox13.Text = "TCPIP Settings";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(10, 42);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox1.Size = new System.Drawing.Size(147, 16);
      this.checkBox1.TabIndex = 8;
      this.checkBox1.Text = "Message Length Header";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // numUpDown_PortNumber
      // 
      this.numUpDown_PortNumber.Location = new System.Drawing.Point(86, 18);
      this.numUpDown_PortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numUpDown_PortNumber.Name = "numUpDown_PortNumber";
      this.numUpDown_PortNumber.Size = new System.Drawing.Size(74, 19);
      this.numUpDown_PortNumber.TabIndex = 7;
      this.numUpDown_PortNumber.Value = new decimal(new int[] {
            7890,
            0,
            0,
            0});
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Location = new System.Drawing.Point(11, 20);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(69, 12);
      this.label20.TabIndex = 6;
      this.label20.Text = "Port Number";
      // 
      // groupBox12
      // 
      this.groupBox12.Controls.Add(this.checkBox_ShuttledCamera);
      this.groupBox12.Controls.Add(this.checkBox_RunUncalibrated);
      this.groupBox12.Controls.Add(this.checkBox_MovableOrigin);
      this.groupBox12.Location = new System.Drawing.Point(13, 97);
      this.groupBox12.Name = "groupBox12";
      this.groupBox12.Size = new System.Drawing.Size(147, 85);
      this.groupBox12.TabIndex = 12;
      this.groupBox12.TabStop = false;
      this.groupBox12.Text = "General Settings";
      // 
      // checkBox_ShuttledCamera
      // 
      this.checkBox_ShuttledCamera.AutoSize = true;
      this.checkBox_ShuttledCamera.Location = new System.Drawing.Point(11, 17);
      this.checkBox_ShuttledCamera.Name = "checkBox_ShuttledCamera";
      this.checkBox_ShuttledCamera.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_ShuttledCamera.Size = new System.Drawing.Size(125, 16);
      this.checkBox_ShuttledCamera.TabIndex = 11;
      this.checkBox_ShuttledCamera.Text = "    Shuttled Camera";
      this.checkBox_ShuttledCamera.UseVisualStyleBackColor = true;
      // 
      // checkBox_RunUncalibrated
      // 
      this.checkBox_RunUncalibrated.AutoSize = true;
      this.checkBox_RunUncalibrated.Location = new System.Drawing.Point(12, 61);
      this.checkBox_RunUncalibrated.Name = "checkBox_RunUncalibrated";
      this.checkBox_RunUncalibrated.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_RunUncalibrated.Size = new System.Drawing.Size(124, 16);
      this.checkBox_RunUncalibrated.TabIndex = 9;
      this.checkBox_RunUncalibrated.Text = "   Run Uncalibrated";
      this.checkBox_RunUncalibrated.UseVisualStyleBackColor = true;
      // 
      // checkBox_MovableOrigin
      // 
      this.checkBox_MovableOrigin.AutoSize = true;
      this.checkBox_MovableOrigin.Location = new System.Drawing.Point(12, 39);
      this.checkBox_MovableOrigin.Name = "checkBox_MovableOrigin";
      this.checkBox_MovableOrigin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_MovableOrigin.Size = new System.Drawing.Size(124, 16);
      this.checkBox_MovableOrigin.TabIndex = 10;
      this.checkBox_MovableOrigin.Text = "      Movable Origin";
      this.checkBox_MovableOrigin.UseVisualStyleBackColor = true;
      // 
      // btn_ChangeSysSettings
      // 
      this.btn_ChangeSysSettings.BackColor = System.Drawing.Color.Lime;
      this.btn_ChangeSysSettings.Location = new System.Drawing.Point(35, 321);
      this.btn_ChangeSysSettings.Name = "btn_ChangeSysSettings";
      this.btn_ChangeSysSettings.Size = new System.Drawing.Size(395, 23);
      this.btn_ChangeSysSettings.TabIndex = 0;
      this.btn_ChangeSysSettings.Text = "Change Sytem Settings";
      this.btn_ChangeSysSettings.UseVisualStyleBackColor = false;
      this.btn_ChangeSysSettings.Click += new System.EventHandler(this.btn_ChangeSysSettings_Click);
      // 
      // tabRecipeMgmt
      // 
      this.tabRecipeMgmt.Controls.Add(this.numRecipeID);
      this.tabRecipeMgmt.Controls.Add(this.chkUseRecipeID);
      this.tabRecipeMgmt.Controls.Add(this.btn_SaveCurrRecipe);
      this.tabRecipeMgmt.Controls.Add(this.groupBox7);
      this.tabRecipeMgmt.Controls.Add(this.btn_LoadRecipe);
      this.tabRecipeMgmt.Controls.Add(this.groupBox6);
      this.tabRecipeMgmt.Controls.Add(this.label9);
      this.tabRecipeMgmt.Controls.Add(this.btn_RemoveRecipe);
      this.tabRecipeMgmt.Controls.Add(this.groupBox5);
      this.tabRecipeMgmt.Controls.Add(this.btn_UpdateRecipeList);
      this.tabRecipeMgmt.Controls.Add(this.list_Recipes);
      this.tabRecipeMgmt.Location = new System.Drawing.Point(4, 22);
      this.tabRecipeMgmt.Name = "tabRecipeMgmt";
      this.tabRecipeMgmt.Padding = new System.Windows.Forms.Padding(3);
      this.tabRecipeMgmt.Size = new System.Drawing.Size(517, 414);
      this.tabRecipeMgmt.TabIndex = 1;
      this.tabRecipeMgmt.Text = "Recipe Mgmt";
      this.tabRecipeMgmt.UseVisualStyleBackColor = true;
      // 
      // numRecipeID
      // 
      this.numRecipeID.BackColor = System.Drawing.SystemColors.Window;
      this.numRecipeID.Location = new System.Drawing.Point(317, 16);
      this.numRecipeID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numRecipeID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numRecipeID.Name = "numRecipeID";
      this.numRecipeID.Size = new System.Drawing.Size(128, 19);
      this.numRecipeID.TabIndex = 14;
      this.numRecipeID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numRecipeID.ValueChanged += new System.EventHandler(this.numRecipeID_ValueChanged);
      // 
      // chkUseRecipeID
      // 
      this.chkUseRecipeID.AutoSize = true;
      this.chkUseRecipeID.Location = new System.Drawing.Point(236, 19);
      this.chkUseRecipeID.Name = "chkUseRecipeID";
      this.chkUseRecipeID.Size = new System.Drawing.Size(77, 16);
      this.chkUseRecipeID.TabIndex = 13;
      this.chkUseRecipeID.Text = "Specify ID";
      this.chkUseRecipeID.UseVisualStyleBackColor = true;
      this.chkUseRecipeID.CheckedChanged += new System.EventHandler(this.chkUseRecipeID_CheckedChanged);
      // 
      // btn_SaveCurrRecipe
      // 
      this.btn_SaveCurrRecipe.BackColor = System.Drawing.Color.Lime;
      this.btn_SaveCurrRecipe.Location = new System.Drawing.Point(7, 337);
      this.btn_SaveCurrRecipe.Name = "btn_SaveCurrRecipe";
      this.btn_SaveCurrRecipe.Size = new System.Drawing.Size(199, 23);
      this.btn_SaveCurrRecipe.TabIndex = 10;
      this.btn_SaveCurrRecipe.Text = "Save Changes of Current Recipe";
      this.btn_SaveCurrRecipe.UseVisualStyleBackColor = false;
      this.btn_SaveCurrRecipe.Click += new System.EventHandler(this.btn_SaveCurrRecipe_Click);
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.txtBox_SaveCurrRecipeAsDescription);
      this.groupBox7.Controls.Add(this.label15);
      this.groupBox7.Controls.Add(this.txtBox_SaveCurrRecipeAsName);
      this.groupBox7.Controls.Add(this.label14);
      this.groupBox7.Controls.Add(this.btn_SaveCurrRecipeAs);
      this.groupBox7.Location = new System.Drawing.Point(223, 223);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(227, 114);
      this.groupBox7.TabIndex = 9;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Save Recipe As";
      // 
      // txtBox_SaveCurrRecipeAsDescription
      // 
      this.txtBox_SaveCurrRecipeAsDescription.Location = new System.Drawing.Point(9, 59);
      this.txtBox_SaveCurrRecipeAsDescription.Name = "txtBox_SaveCurrRecipeAsDescription";
      this.txtBox_SaveCurrRecipeAsDescription.Size = new System.Drawing.Size(173, 19);
      this.txtBox_SaveCurrRecipeAsDescription.TabIndex = 12;
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(6, 44);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(108, 12);
      this.label15.TabIndex = 11;
      this.label15.Text = "Recipe Description :";
      // 
      // txtBox_SaveCurrRecipeAsName
      // 
      this.txtBox_SaveCurrRecipeAsName.Location = new System.Drawing.Point(86, 17);
      this.txtBox_SaveCurrRecipeAsName.Name = "txtBox_SaveCurrRecipeAsName";
      this.txtBox_SaveCurrRecipeAsName.Size = new System.Drawing.Size(101, 19);
      this.txtBox_SaveCurrRecipeAsName.TabIndex = 6;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(6, 21);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(79, 12);
      this.label14.TabIndex = 7;
      this.label14.Text = "Recipe Name :";
      // 
      // btn_SaveCurrRecipeAs
      // 
      this.btn_SaveCurrRecipeAs.BackColor = System.Drawing.Color.Lime;
      this.btn_SaveCurrRecipeAs.Location = new System.Drawing.Point(9, 83);
      this.btn_SaveCurrRecipeAs.Name = "btn_SaveCurrRecipeAs";
      this.btn_SaveCurrRecipeAs.Size = new System.Drawing.Size(175, 23);
      this.btn_SaveCurrRecipeAs.TabIndex = 4;
      this.btn_SaveCurrRecipeAs.Text = "Save Current Recipe As ...";
      this.btn_SaveCurrRecipeAs.UseVisualStyleBackColor = false;
      this.btn_SaveCurrRecipeAs.Click += new System.EventHandler(this.btn_SaveCurrRecipeAs_Click);
      // 
      // btn_LoadRecipe
      // 
      this.btn_LoadRecipe.BackColor = System.Drawing.Color.Lime;
      this.btn_LoadRecipe.Location = new System.Drawing.Point(7, 265);
      this.btn_LoadRecipe.Name = "btn_LoadRecipe";
      this.btn_LoadRecipe.Size = new System.Drawing.Size(148, 23);
      this.btn_LoadRecipe.TabIndex = 8;
      this.btn_LoadRecipe.Text = "Load Selected Recipe";
      this.btn_LoadRecipe.UseVisualStyleBackColor = false;
      this.btn_LoadRecipe.Click += new System.EventHandler(this.btn_LoadRecipe_Click);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.lbl_CurrRecipeName);
      this.groupBox6.Controls.Add(this.lbl_CurrRecipeID);
      this.groupBox6.Controls.Add(this.label95);
      this.groupBox6.Controls.Add(this.lbl_CurrRecipeMode);
      this.groupBox6.Controls.Add(this.label13);
      this.groupBox6.Controls.Add(this.label10);
      this.groupBox6.Controls.Add(this.lbl_CurrRecipeDescription);
      this.groupBox6.Controls.Add(this.label12);
      this.groupBox6.Controls.Add(this.label11);
      this.groupBox6.Location = new System.Drawing.Point(7, 9);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(205, 144);
      this.groupBox6.TabIndex = 7;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Current Recipe";
      // 
      // lbl_CurrRecipeName
      // 
      this.lbl_CurrRecipeName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrRecipeName.Location = new System.Drawing.Point(104, 15);
      this.lbl_CurrRecipeName.Name = "lbl_CurrRecipeName";
      this.lbl_CurrRecipeName.Size = new System.Drawing.Size(93, 19);
      this.lbl_CurrRecipeName.TabIndex = 6;
      this.lbl_CurrRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_CurrRecipeID
      // 
      this.lbl_CurrRecipeID.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrRecipeID.Location = new System.Drawing.Point(29, 14);
      this.lbl_CurrRecipeID.Name = "lbl_CurrRecipeID";
      this.lbl_CurrRecipeID.Size = new System.Drawing.Size(29, 19);
      this.lbl_CurrRecipeID.TabIndex = 14;
      this.lbl_CurrRecipeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label95
      // 
      this.label95.Location = new System.Drawing.Point(6, 15);
      this.label95.Name = "label95";
      this.label95.Size = new System.Drawing.Size(25, 17);
      this.label95.TabIndex = 13;
      this.label95.Text = "ID :";
      this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_CurrRecipeMode
      // 
      this.lbl_CurrRecipeMode.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrRecipeMode.Location = new System.Drawing.Point(6, 104);
      this.lbl_CurrRecipeMode.Name = "lbl_CurrRecipeMode";
      this.lbl_CurrRecipeMode.Size = new System.Drawing.Size(193, 20);
      this.lbl_CurrRecipeMode.TabIndex = 10;
      this.lbl_CurrRecipeMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label13
      // 
      this.label13.Location = new System.Drawing.Point(7, 81);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(82, 25);
      this.label13.TabIndex = 12;
      this.label13.Text = "Configuration :";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label10
      // 
      this.label10.Location = new System.Drawing.Point(65, 16);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(45, 16);
      this.label10.TabIndex = 11;
      this.label10.Text = "Name :";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_CurrRecipeDescription
      // 
      this.lbl_CurrRecipeDescription.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrRecipeDescription.Location = new System.Drawing.Point(6, 54);
      this.lbl_CurrRecipeDescription.Name = "lbl_CurrRecipeDescription";
      this.lbl_CurrRecipeDescription.Size = new System.Drawing.Size(193, 22);
      this.lbl_CurrRecipeDescription.TabIndex = 9;
      this.lbl_CurrRecipeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label12
      // 
      this.label12.Location = new System.Drawing.Point(6, 37);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(73, 16);
      this.label12.TabIndex = 8;
      this.label12.Text = "Description :";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(52, 20);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(0, 12);
      this.label11.TabIndex = 7;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 164);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(69, 12);
      this.label9.TabIndex = 6;
      this.label9.Text = "Recipe List :";
      // 
      // btn_RemoveRecipe
      // 
      this.btn_RemoveRecipe.BackColor = System.Drawing.Color.Lime;
      this.btn_RemoveRecipe.Location = new System.Drawing.Point(7, 292);
      this.btn_RemoveRecipe.Name = "btn_RemoveRecipe";
      this.btn_RemoveRecipe.Size = new System.Drawing.Size(148, 23);
      this.btn_RemoveRecipe.TabIndex = 5;
      this.btn_RemoveRecipe.Text = "Remove Selected Recipe";
      this.btn_RemoveRecipe.UseVisualStyleBackColor = false;
      this.btn_RemoveRecipe.Click += new System.EventHandler(this.btn_RemoveRecipe_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.txtBox_NewRecipeDescription);
      this.groupBox5.Controls.Add(this.label8);
      this.groupBox5.Controls.Add(this.label7);
      this.groupBox5.Controls.Add(this.comboBox_NewRecipeMode);
      this.groupBox5.Controls.Add(this.txtBox_NewRecipeName);
      this.groupBox5.Controls.Add(this.label6);
      this.groupBox5.Controls.Add(this.btn_NewRecipeCreate);
      this.groupBox5.Location = new System.Drawing.Point(223, 46);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(227, 171);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Create New Recipe";
      // 
      // txtBox_NewRecipeDescription
      // 
      this.txtBox_NewRecipeDescription.Location = new System.Drawing.Point(12, 67);
      this.txtBox_NewRecipeDescription.Name = "txtBox_NewRecipeDescription";
      this.txtBox_NewRecipeDescription.Size = new System.Drawing.Size(209, 19);
      this.txtBox_NewRecipeDescription.TabIndex = 10;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(10, 52);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(108, 12);
      this.label8.TabIndex = 9;
      this.label8.Text = "Recipe Description :";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(14, 95);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(79, 12);
      this.label7.TabIndex = 8;
      this.label7.Text = "Configuration :";
      // 
      // comboBox_NewRecipeMode
      // 
      this.comboBox_NewRecipeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_NewRecipeMode.FormattingEnabled = true;
      this.comboBox_NewRecipeMode.Items.AddRange(new object[] {
            "Default",
            "OneCamera_OneFeature",
            "OneCamera_TwoFeatures",
            "OneCamera_ThreeFeatures",
            "OneCamera_FourFeatures",
            "OneCamera_ShuttlingCamera",
            "OneCamera_ShuttledCamera",
            "OneCamera_ShuttlingPart",
            "TwoCameras_OneFeaturePerCamera",
            "TwoCameras_TwoFeaturesPerCamera"});
      this.comboBox_NewRecipeMode.Location = new System.Drawing.Point(12, 110);
      this.comboBox_NewRecipeMode.Name = "comboBox_NewRecipeMode";
      this.comboBox_NewRecipeMode.Size = new System.Drawing.Size(209, 20);
      this.comboBox_NewRecipeMode.TabIndex = 7;
      // 
      // txtBox_NewRecipeName
      // 
      this.txtBox_NewRecipeName.Location = new System.Drawing.Point(93, 20);
      this.txtBox_NewRecipeName.Name = "txtBox_NewRecipeName";
      this.txtBox_NewRecipeName.Size = new System.Drawing.Size(128, 19);
      this.txtBox_NewRecipeName.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(10, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(79, 12);
      this.label6.TabIndex = 5;
      this.label6.Text = "Recipe Name :";
      // 
      // btn_NewRecipeCreate
      // 
      this.btn_NewRecipeCreate.BackColor = System.Drawing.Color.Lime;
      this.btn_NewRecipeCreate.Location = new System.Drawing.Point(10, 143);
      this.btn_NewRecipeCreate.Name = "btn_NewRecipeCreate";
      this.btn_NewRecipeCreate.Size = new System.Drawing.Size(173, 23);
      this.btn_NewRecipeCreate.TabIndex = 3;
      this.btn_NewRecipeCreate.Text = "Create and Load";
      this.btn_NewRecipeCreate.UseVisualStyleBackColor = false;
      this.btn_NewRecipeCreate.Click += new System.EventHandler(this.btn_NewRecipeCreate_Click);
      // 
      // btn_UpdateRecipeList
      // 
      this.btn_UpdateRecipeList.BackColor = System.Drawing.Color.Lime;
      this.btn_UpdateRecipeList.Location = new System.Drawing.Point(81, 159);
      this.btn_UpdateRecipeList.Name = "btn_UpdateRecipeList";
      this.btn_UpdateRecipeList.Size = new System.Drawing.Size(80, 22);
      this.btn_UpdateRecipeList.TabIndex = 2;
      this.btn_UpdateRecipeList.Text = "Update List";
      this.btn_UpdateRecipeList.UseVisualStyleBackColor = false;
      this.btn_UpdateRecipeList.Click += new System.EventHandler(this.btn_UpdateRecipeList_Click);
      // 
      // list_Recipes
      // 
      this.list_Recipes.FormattingEnabled = true;
      this.list_Recipes.ItemHeight = 12;
      this.list_Recipes.Location = new System.Drawing.Point(8, 183);
      this.list_Recipes.Name = "list_Recipes";
      this.list_Recipes.Size = new System.Drawing.Size(204, 76);
      this.list_Recipes.TabIndex = 1;
      // 
      // tabRecipeSettings
      // 
      this.tabRecipeSettings.Controls.Add(this.groupBox3);
      this.tabRecipeSettings.Controls.Add(this.groupBox2);
      this.tabRecipeSettings.Location = new System.Drawing.Point(4, 22);
      this.tabRecipeSettings.Name = "tabRecipeSettings";
      this.tabRecipeSettings.Padding = new System.Windows.Forms.Padding(3);
      this.tabRecipeSettings.Size = new System.Drawing.Size(517, 414);
      this.tabRecipeSettings.TabIndex = 11;
      this.tabRecipeSettings.Text = "Recipe";
      this.tabRecipeSettings.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.numLCUpperLim);
      this.groupBox3.Controls.Add(this.numLCLowLim);
      this.groupBox3.Controls.Add(this.cbLCMode);
      this.groupBox3.Controls.Add(this.cbLCSelectedPartID);
      this.groupBox3.Controls.Add(this.label80);
      this.groupBox3.Controls.Add(this.label79);
      this.groupBox3.Controls.Add(this.label78);
      this.groupBox3.Controls.Add(this.label77);
      this.groupBox3.Controls.Add(this.btnSetLCheck);
      this.groupBox3.Controls.Add(this.btnUpdateLCheck);
      this.groupBox3.Location = new System.Drawing.Point(249, 7);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(223, 225);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "LCheck Settings";
      // 
      // numLCUpperLim
      // 
      this.numLCUpperLim.DecimalPlaces = 3;
      this.numLCUpperLim.Location = new System.Drawing.Point(99, 124);
      this.numLCUpperLim.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
      this.numLCUpperLim.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numLCUpperLim.Name = "numLCUpperLim";
      this.numLCUpperLim.Size = new System.Drawing.Size(120, 19);
      this.numLCUpperLim.TabIndex = 4;
      // 
      // numLCLowLim
      // 
      this.numLCLowLim.DecimalPlaces = 3;
      this.numLCLowLim.Location = new System.Drawing.Point(98, 88);
      this.numLCLowLim.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
      this.numLCLowLim.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numLCLowLim.Name = "numLCLowLim";
      this.numLCLowLim.Size = new System.Drawing.Size(120, 19);
      this.numLCLowLim.TabIndex = 4;
      // 
      // cbLCMode
      // 
      this.cbLCMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Absolute",
            "Difference",
            "Relative"});
      this.cbLCMode.FormattingEnabled = true;
      this.cbLCMode.Items.AddRange(new object[] {
            "Absolute",
            "Difference",
            "Relative"});
      this.cbLCMode.Location = new System.Drawing.Point(98, 52);
      this.cbLCMode.Name = "cbLCMode";
      this.cbLCMode.Size = new System.Drawing.Size(121, 20);
      this.cbLCMode.TabIndex = 3;
      // 
      // cbLCSelectedPartID
      // 
      this.cbLCSelectedPartID.FormattingEnabled = true;
      this.cbLCSelectedPartID.Location = new System.Drawing.Point(98, 15);
      this.cbLCSelectedPartID.Name = "cbLCSelectedPartID";
      this.cbLCSelectedPartID.Size = new System.Drawing.Size(121, 20);
      this.cbLCSelectedPartID.TabIndex = 2;
      this.cbLCSelectedPartID.SelectedIndexChanged += new System.EventHandler(this.cbLCSelectedPartID_SelectedIndexChanged);
      // 
      // label80
      // 
      this.label80.AutoSize = true;
      this.label80.Location = new System.Drawing.Point(6, 126);
      this.label80.Name = "label80";
      this.label80.Size = new System.Drawing.Size(64, 12);
      this.label80.TabIndex = 1;
      this.label80.Text = "Upper Limit";
      // 
      // label79
      // 
      this.label79.AutoSize = true;
      this.label79.Location = new System.Drawing.Point(6, 90);
      this.label79.Name = "label79";
      this.label79.Size = new System.Drawing.Size(64, 12);
      this.label79.TabIndex = 1;
      this.label79.Text = "Lower Limit";
      // 
      // label78
      // 
      this.label78.AutoSize = true;
      this.label78.Location = new System.Drawing.Point(6, 55);
      this.label78.Name = "label78";
      this.label78.Size = new System.Drawing.Size(74, 12);
      this.label78.TabIndex = 1;
      this.label78.Text = "LCheck Mode";
      // 
      // label77
      // 
      this.label77.AutoSize = true;
      this.label77.Location = new System.Drawing.Point(6, 18);
      this.label77.Name = "label77";
      this.label77.Size = new System.Drawing.Size(85, 12);
      this.label77.TabIndex = 1;
      this.label77.Text = "Selected PartID";
      // 
      // btnSetLCheck
      // 
      this.btnSetLCheck.BackColor = System.Drawing.Color.Lime;
      this.btnSetLCheck.Location = new System.Drawing.Point(98, 196);
      this.btnSetLCheck.Name = "btnSetLCheck";
      this.btnSetLCheck.Size = new System.Drawing.Size(75, 23);
      this.btnSetLCheck.TabIndex = 0;
      this.btnSetLCheck.Text = "Set";
      this.btnSetLCheck.UseVisualStyleBackColor = false;
      this.btnSetLCheck.Click += new System.EventHandler(this.btnSetLCheck_Click);
      // 
      // btnUpdateLCheck
      // 
      this.btnUpdateLCheck.BackColor = System.Drawing.Color.Lime;
      this.btnUpdateLCheck.Location = new System.Drawing.Point(7, 196);
      this.btnUpdateLCheck.Name = "btnUpdateLCheck";
      this.btnUpdateLCheck.Size = new System.Drawing.Size(84, 23);
      this.btnUpdateLCheck.TabIndex = 0;
      this.btnUpdateLCheck.Text = "Update Menu";
      this.btnUpdateLCheck.UseVisualStyleBackColor = false;
      this.btnUpdateLCheck.Click += new System.EventHandler(this.btnUpdateLCheck_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label87);
      this.groupBox2.Controls.Add(this.label86);
      this.groupBox2.Controls.Add(this.label85);
      this.groupBox2.Controls.Add(this.label84);
      this.groupBox2.Controls.Add(this.label82);
      this.groupBox2.Controls.Add(this.PartID5);
      this.groupBox2.Controls.Add(this.PartID4);
      this.groupBox2.Controls.Add(this.PartID3);
      this.groupBox2.Controls.Add(this.PartID2);
      this.groupBox2.Controls.Add(this.PartID1);
      this.groupBox2.Controls.Add(this.btnSetMPs);
      this.groupBox2.Controls.Add(this.btnUpdateMPs);
      this.groupBox2.Location = new System.Drawing.Point(8, 7);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(224, 225);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Multi Pattern Settings";
      // 
      // label87
      // 
      this.label87.AutoSize = true;
      this.label87.Location = new System.Drawing.Point(3, 174);
      this.label87.Name = "label87";
      this.label87.Size = new System.Drawing.Size(78, 12);
      this.label87.TabIndex = 10;
      this.label87.Text = "ExceptionTest";
      // 
      // label86
      // 
      this.label86.AutoSize = true;
      this.label86.Location = new System.Drawing.Point(8, 145);
      this.label86.Name = "label86";
      this.label86.Size = new System.Drawing.Size(43, 12);
      this.label86.TabIndex = 9;
      this.label86.Text = "PartID4";
      // 
      // label85
      // 
      this.label85.AutoSize = true;
      this.label85.Location = new System.Drawing.Point(6, 110);
      this.label85.Name = "label85";
      this.label85.Size = new System.Drawing.Size(43, 12);
      this.label85.TabIndex = 8;
      this.label85.Text = "PartID3";
      // 
      // label84
      // 
      this.label84.AutoSize = true;
      this.label84.Location = new System.Drawing.Point(6, 67);
      this.label84.Name = "label84";
      this.label84.Size = new System.Drawing.Size(43, 12);
      this.label84.TabIndex = 7;
      this.label84.Text = "PartID2";
      // 
      // label82
      // 
      this.label82.AutoSize = true;
      this.label82.Location = new System.Drawing.Point(8, 31);
      this.label82.Name = "label82";
      this.label82.Size = new System.Drawing.Size(43, 12);
      this.label82.TabIndex = 6;
      this.label82.Text = "PartID1";
      // 
      // PartID5
      // 
      this.PartID5.FormattingEnabled = true;
      this.PartID5.Location = new System.Drawing.Point(89, 168);
      this.PartID5.Name = "PartID5";
      this.PartID5.Size = new System.Drawing.Size(98, 20);
      this.PartID5.TabIndex = 5;
      // 
      // PartID4
      // 
      this.PartID4.FormattingEnabled = true;
      this.PartID4.Location = new System.Drawing.Point(89, 136);
      this.PartID4.Name = "PartID4";
      this.PartID4.Size = new System.Drawing.Size(98, 20);
      this.PartID4.TabIndex = 4;
      // 
      // PartID3
      // 
      this.PartID3.FormattingEnabled = true;
      this.PartID3.Location = new System.Drawing.Point(90, 102);
      this.PartID3.Name = "PartID3";
      this.PartID3.Size = new System.Drawing.Size(98, 20);
      this.PartID3.TabIndex = 3;
      // 
      // PartID2
      // 
      this.PartID2.FormattingEnabled = true;
      this.PartID2.Location = new System.Drawing.Point(89, 64);
      this.PartID2.Name = "PartID2";
      this.PartID2.Size = new System.Drawing.Size(98, 20);
      this.PartID2.TabIndex = 2;
      // 
      // PartID1
      // 
      this.PartID1.FormattingEnabled = true;
      this.PartID1.Location = new System.Drawing.Point(90, 29);
      this.PartID1.Name = "PartID1";
      this.PartID1.Size = new System.Drawing.Size(98, 20);
      this.PartID1.TabIndex = 1;
      // 
      // btnSetMPs
      // 
      this.btnSetMPs.BackColor = System.Drawing.Color.Lime;
      this.btnSetMPs.Location = new System.Drawing.Point(107, 196);
      this.btnSetMPs.Name = "btnSetMPs";
      this.btnSetMPs.Size = new System.Drawing.Size(75, 23);
      this.btnSetMPs.TabIndex = 0;
      this.btnSetMPs.Text = "Set";
      this.btnSetMPs.UseVisualStyleBackColor = false;
      this.btnSetMPs.Click += new System.EventHandler(this.btnSetMPs_Click);
      // 
      // btnUpdateMPs
      // 
      this.btnUpdateMPs.BackColor = System.Drawing.Color.Lime;
      this.btnUpdateMPs.Location = new System.Drawing.Point(10, 196);
      this.btnUpdateMPs.Name = "btnUpdateMPs";
      this.btnUpdateMPs.Size = new System.Drawing.Size(91, 23);
      this.btnUpdateMPs.TabIndex = 0;
      this.btnUpdateMPs.Text = "Update Menu";
      this.btnUpdateMPs.UseVisualStyleBackColor = false;
      this.btnUpdateMPs.Click += new System.EventHandler(this.btnUpdateMPs_Click);
      // 
      // tabCtrlOnDisp
      // 
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_FOVCross);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_StatuslBar);
      this.tabCtrlOnDisp.Controls.Add(this.gBox_CtrlOnDisp_Cam2);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_LiveVideoBtnEnable);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_LoadImgBtnEnable);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_SaveImgBtnEnable);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_Graphics);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_AcceptCancelButton);
      this.tabCtrlOnDisp.Controls.Add(this.gBox_CtrlOnDisp_Cam1);
      this.tabCtrlOnDisp.Controls.Add(this.checkBox_ToolBar);
      this.tabCtrlOnDisp.Location = new System.Drawing.Point(4, 22);
      this.tabCtrlOnDisp.Name = "tabCtrlOnDisp";
      this.tabCtrlOnDisp.Padding = new System.Windows.Forms.Padding(3);
      this.tabCtrlOnDisp.Size = new System.Drawing.Size(517, 414);
      this.tabCtrlOnDisp.TabIndex = 2;
      this.tabCtrlOnDisp.Text = "Ctrl on Disp";
      this.tabCtrlOnDisp.UseVisualStyleBackColor = true;
      // 
      // checkBox_FOVCross
      // 
      this.checkBox_FOVCross.AutoSize = true;
      this.checkBox_FOVCross.Location = new System.Drawing.Point(289, 7);
      this.checkBox_FOVCross.Name = "checkBox_FOVCross";
      this.checkBox_FOVCross.Size = new System.Drawing.Size(119, 16);
      this.checkBox_FOVCross.TabIndex = 10;
      this.checkBox_FOVCross.Text = "FOV Center Cross";
      this.checkBox_FOVCross.UseVisualStyleBackColor = true;
      this.checkBox_FOVCross.CheckedChanged += new System.EventHandler(this.checkBox_FOVCross_CheckedChanged);
      // 
      // checkBox_StatuslBar
      // 
      this.checkBox_StatuslBar.AutoSize = true;
      this.checkBox_StatuslBar.Checked = true;
      this.checkBox_StatuslBar.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_StatuslBar.Location = new System.Drawing.Point(74, 9);
      this.checkBox_StatuslBar.Name = "checkBox_StatuslBar";
      this.checkBox_StatuslBar.Size = new System.Drawing.Size(73, 16);
      this.checkBox_StatuslBar.TabIndex = 9;
      this.checkBox_StatuslBar.Text = "Statusbar";
      this.checkBox_StatuslBar.UseVisualStyleBackColor = true;
      this.checkBox_StatuslBar.CheckedChanged += new System.EventHandler(this.checkBox_StatuslBar_CheckedChanged);
      // 
      // gBox_CtrlOnDisp_Cam2
      // 
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.checkBox_FocusFeedback2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.checkBox_ShowStatusBar2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.checkBox_ShowGraphics2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_StopLive2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_SaveImg2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_StartLive2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_RotCCW2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_RotCW2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_LoadImg2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_ZoomOut2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_ZoomIn2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.btn_ZoomFit2);
      this.gBox_CtrlOnDisp_Cam2.Controls.Add(this.checkBox_FovCross2);
      this.gBox_CtrlOnDisp_Cam2.Location = new System.Drawing.Point(245, 115);
      this.gBox_CtrlOnDisp_Cam2.Name = "gBox_CtrlOnDisp_Cam2";
      this.gBox_CtrlOnDisp_Cam2.Size = new System.Drawing.Size(190, 225);
      this.gBox_CtrlOnDisp_Cam2.TabIndex = 8;
      this.gBox_CtrlOnDisp_Cam2.TabStop = false;
      this.gBox_CtrlOnDisp_Cam2.Text = "Camera2";
      // 
      // checkBox_FocusFeedback2
      // 
      this.checkBox_FocusFeedback2.Checked = true;
      this.checkBox_FocusFeedback2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_FocusFeedback2.Location = new System.Drawing.Point(6, 192);
      this.checkBox_FocusFeedback2.Name = "checkBox_FocusFeedback2";
      this.checkBox_FocusFeedback2.Size = new System.Drawing.Size(109, 21);
      this.checkBox_FocusFeedback2.TabIndex = 12;
      this.checkBox_FocusFeedback2.Text = "Focus Feedback";
      this.checkBox_FocusFeedback2.UseVisualStyleBackColor = true;
      this.checkBox_FocusFeedback2.CheckedChanged += new System.EventHandler(this.checkBox_FocusFeedback2_CheckedChanged);
      // 
      // checkBox_ShowStatusBar2
      // 
      this.checkBox_ShowStatusBar2.Checked = true;
      this.checkBox_ShowStatusBar2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_ShowStatusBar2.Location = new System.Drawing.Point(92, 136);
      this.checkBox_ShowStatusBar2.Name = "checkBox_ShowStatusBar2";
      this.checkBox_ShowStatusBar2.Size = new System.Drawing.Size(82, 22);
      this.checkBox_ShowStatusBar2.TabIndex = 11;
      this.checkBox_ShowStatusBar2.Text = "StatusBar";
      this.checkBox_ShowStatusBar2.UseVisualStyleBackColor = true;
      this.checkBox_ShowStatusBar2.CheckedChanged += new System.EventHandler(this.checkBox_StatusBarVisibility2_CheckedChanged);
      // 
      // checkBox_ShowGraphics2
      // 
      this.checkBox_ShowGraphics2.Checked = true;
      this.checkBox_ShowGraphics2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_ShowGraphics2.Location = new System.Drawing.Point(6, 168);
      this.checkBox_ShowGraphics2.Name = "checkBox_ShowGraphics2";
      this.checkBox_ShowGraphics2.Size = new System.Drawing.Size(74, 18);
      this.checkBox_ShowGraphics2.TabIndex = 10;
      this.checkBox_ShowGraphics2.Text = "Graphics";
      this.checkBox_ShowGraphics2.UseVisualStyleBackColor = true;
      this.checkBox_ShowGraphics2.CheckedChanged += new System.EventHandler(this.checkBox_ShowGraphics2_CheckedChanged);
      // 
      // btn_StopLive2
      // 
      this.btn_StopLive2.Location = new System.Drawing.Point(91, 106);
      this.btn_StopLive2.Name = "btn_StopLive2";
      this.btn_StopLive2.Size = new System.Drawing.Size(83, 22);
      this.btn_StopLive2.TabIndex = 8;
      this.btn_StopLive2.Text = "Stop Live";
      this.btn_StopLive2.UseVisualStyleBackColor = true;
      this.btn_StopLive2.Click += new System.EventHandler(this.btn_StopLive2_Click);
      // 
      // btn_SaveImg2
      // 
      this.btn_SaveImg2.Location = new System.Drawing.Point(6, 136);
      this.btn_SaveImg2.Name = "btn_SaveImg2";
      this.btn_SaveImg2.Size = new System.Drawing.Size(75, 22);
      this.btn_SaveImg2.TabIndex = 6;
      this.btn_SaveImg2.Text = "Save Image";
      this.btn_SaveImg2.UseVisualStyleBackColor = true;
      this.btn_SaveImg2.Click += new System.EventHandler(this.btn_SaveImg2_Click);
      // 
      // btn_StartLive2
      // 
      this.btn_StartLive2.Location = new System.Drawing.Point(91, 78);
      this.btn_StartLive2.Name = "btn_StartLive2";
      this.btn_StartLive2.Size = new System.Drawing.Size(83, 22);
      this.btn_StartLive2.TabIndex = 8;
      this.btn_StartLive2.Text = "Start Live";
      this.btn_StartLive2.UseVisualStyleBackColor = true;
      this.btn_StartLive2.Click += new System.EventHandler(this.btn_StartLive2_Click);
      // 
      // btn_RotCCW2
      // 
      this.btn_RotCCW2.Location = new System.Drawing.Point(91, 22);
      this.btn_RotCCW2.Name = "btn_RotCCW2";
      this.btn_RotCCW2.Size = new System.Drawing.Size(83, 22);
      this.btn_RotCCW2.TabIndex = 5;
      this.btn_RotCCW2.Text = "Rotate CCW";
      this.btn_RotCCW2.UseVisualStyleBackColor = true;
      this.btn_RotCCW2.Click += new System.EventHandler(this.btn_RotCCW2_Click);
      // 
      // btn_RotCW2
      // 
      this.btn_RotCW2.Location = new System.Drawing.Point(91, 50);
      this.btn_RotCW2.Name = "btn_RotCW2";
      this.btn_RotCW2.Size = new System.Drawing.Size(83, 22);
      this.btn_RotCW2.TabIndex = 8;
      this.btn_RotCW2.Text = "Rotate CW";
      this.btn_RotCW2.UseVisualStyleBackColor = true;
      this.btn_RotCW2.Click += new System.EventHandler(this.btn_RotCW2_Click);
      // 
      // btn_LoadImg2
      // 
      this.btn_LoadImg2.Location = new System.Drawing.Point(6, 106);
      this.btn_LoadImg2.Name = "btn_LoadImg2";
      this.btn_LoadImg2.Size = new System.Drawing.Size(75, 22);
      this.btn_LoadImg2.TabIndex = 7;
      this.btn_LoadImg2.Text = "Load Image";
      this.btn_LoadImg2.UseVisualStyleBackColor = true;
      this.btn_LoadImg2.Click += new System.EventHandler(this.btn_LoadImg2_Click);
      // 
      // btn_ZoomOut2
      // 
      this.btn_ZoomOut2.Location = new System.Drawing.Point(6, 78);
      this.btn_ZoomOut2.Name = "btn_ZoomOut2";
      this.btn_ZoomOut2.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomOut2.TabIndex = 4;
      this.btn_ZoomOut2.Text = "Zoom Out";
      this.btn_ZoomOut2.UseVisualStyleBackColor = true;
      this.btn_ZoomOut2.Click += new System.EventHandler(this.btn_ZoomOut2_Click);
      // 
      // btn_ZoomIn2
      // 
      this.btn_ZoomIn2.Location = new System.Drawing.Point(6, 50);
      this.btn_ZoomIn2.Name = "btn_ZoomIn2";
      this.btn_ZoomIn2.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomIn2.TabIndex = 3;
      this.btn_ZoomIn2.Text = "Zoom In";
      this.btn_ZoomIn2.UseVisualStyleBackColor = true;
      this.btn_ZoomIn2.Click += new System.EventHandler(this.btn_ZoomIn2_Click);
      // 
      // btn_ZoomFit2
      // 
      this.btn_ZoomFit2.Location = new System.Drawing.Point(6, 22);
      this.btn_ZoomFit2.Name = "btn_ZoomFit2";
      this.btn_ZoomFit2.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomFit2.TabIndex = 2;
      this.btn_ZoomFit2.Text = "Zoom Fit";
      this.btn_ZoomFit2.UseVisualStyleBackColor = true;
      this.btn_ZoomFit2.Click += new System.EventHandler(this.btn_ZoomFit2_Click);
      // 
      // checkBox_FovCross2
      // 
      this.checkBox_FovCross2.Location = new System.Drawing.Point(91, 163);
      this.checkBox_FovCross2.Name = "checkBox_FovCross2";
      this.checkBox_FovCross2.Size = new System.Drawing.Size(93, 29);
      this.checkBox_FovCross2.TabIndex = 1;
      this.checkBox_FovCross2.Text = "FOV Center Cross";
      this.checkBox_FovCross2.UseVisualStyleBackColor = true;
      this.checkBox_FovCross2.CheckedChanged += new System.EventHandler(this.checkBox_FovCross2_CheckedChanged);
      // 
      // checkBox_LiveVideoBtnEnable
      // 
      this.checkBox_LiveVideoBtnEnable.AutoSize = true;
      this.checkBox_LiveVideoBtnEnable.Checked = true;
      this.checkBox_LiveVideoBtnEnable.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_LiveVideoBtnEnable.Location = new System.Drawing.Point(6, 87);
      this.checkBox_LiveVideoBtnEnable.Name = "checkBox_LiveVideoBtnEnable";
      this.checkBox_LiveVideoBtnEnable.Size = new System.Drawing.Size(160, 16);
      this.checkBox_LiveVideoBtnEnable.TabIndex = 7;
      this.checkBox_LiveVideoBtnEnable.Text = "Live Video Button Enabled";
      this.checkBox_LiveVideoBtnEnable.UseVisualStyleBackColor = true;
      this.checkBox_LiveVideoBtnEnable.CheckedChanged += new System.EventHandler(this.checkBox_LiveVideoBtnEnable_CheckedChanged);
      // 
      // checkBox_LoadImgBtnEnable
      // 
      this.checkBox_LoadImgBtnEnable.AutoSize = true;
      this.checkBox_LoadImgBtnEnable.Checked = true;
      this.checkBox_LoadImgBtnEnable.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_LoadImgBtnEnable.Location = new System.Drawing.Point(6, 65);
      this.checkBox_LoadImgBtnEnable.Name = "checkBox_LoadImgBtnEnable";
      this.checkBox_LoadImgBtnEnable.Size = new System.Drawing.Size(164, 16);
      this.checkBox_LoadImgBtnEnable.TabIndex = 6;
      this.checkBox_LoadImgBtnEnable.Text = "Load Image Button Enabled";
      this.checkBox_LoadImgBtnEnable.UseVisualStyleBackColor = true;
      this.checkBox_LoadImgBtnEnable.CheckedChanged += new System.EventHandler(this.checkBox_LoadImgBtnEnable_CheckedChanged);
      // 
      // checkBox_SaveImgBtnEnable
      // 
      this.checkBox_SaveImgBtnEnable.AutoSize = true;
      this.checkBox_SaveImgBtnEnable.Checked = true;
      this.checkBox_SaveImgBtnEnable.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_SaveImgBtnEnable.Location = new System.Drawing.Point(6, 43);
      this.checkBox_SaveImgBtnEnable.Name = "checkBox_SaveImgBtnEnable";
      this.checkBox_SaveImgBtnEnable.Size = new System.Drawing.Size(165, 16);
      this.checkBox_SaveImgBtnEnable.TabIndex = 5;
      this.checkBox_SaveImgBtnEnable.Text = "Save Image Button Enabled";
      this.checkBox_SaveImgBtnEnable.UseVisualStyleBackColor = true;
      this.checkBox_SaveImgBtnEnable.CheckedChanged += new System.EventHandler(this.checkBox_SaveImgBtnEnable_CheckedChanged);
      // 
      // checkBox_Graphics
      // 
      this.checkBox_Graphics.AutoSize = true;
      this.checkBox_Graphics.Checked = true;
      this.checkBox_Graphics.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_Graphics.Location = new System.Drawing.Point(151, 8);
      this.checkBox_Graphics.Name = "checkBox_Graphics";
      this.checkBox_Graphics.Size = new System.Drawing.Size(130, 16);
      this.checkBox_Graphics.TabIndex = 3;
      this.checkBox_Graphics.Text = "All Overlay Graphics";
      this.checkBox_Graphics.UseVisualStyleBackColor = true;
      this.checkBox_Graphics.CheckedChanged += new System.EventHandler(this.checkBox_Graphics_CheckedChanged);
      // 
      // checkBox_AcceptCancelButton
      // 
      this.checkBox_AcceptCancelButton.Checked = true;
      this.checkBox_AcceptCancelButton.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_AcceptCancelButton.Location = new System.Drawing.Point(237, 55);
      this.checkBox_AcceptCancelButton.Name = "checkBox_AcceptCancelButton";
      this.checkBox_AcceptCancelButton.Size = new System.Drawing.Size(180, 37);
      this.checkBox_AcceptCancelButton.TabIndex = 2;
      this.checkBox_AcceptCancelButton.Text = "Accept/Cancel Button Visible during Edit on Display";
      this.checkBox_AcceptCancelButton.UseVisualStyleBackColor = true;
      this.checkBox_AcceptCancelButton.CheckedChanged += new System.EventHandler(this.checkBox_AcceptCancelButton_CheckedChanged);
      // 
      // gBox_CtrlOnDisp_Cam1
      // 
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.gBox_imgFile);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.checkBox_FocusFeedback1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.checkBox_ShowStatusBar1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.checkBox_ShowGraphics1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_StopLive1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_SaveImg1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_StartLive1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_RotCCW1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_RotCW1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_LoadImg1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_ZoomOut1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_ZoomIn1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.btn_ZoomFit1);
      this.gBox_CtrlOnDisp_Cam1.Controls.Add(this.checkBox_FovCross1);
      this.gBox_CtrlOnDisp_Cam1.Location = new System.Drawing.Point(7, 115);
      this.gBox_CtrlOnDisp_Cam1.Name = "gBox_CtrlOnDisp_Cam1";
      this.gBox_CtrlOnDisp_Cam1.Size = new System.Drawing.Size(225, 292);
      this.gBox_CtrlOnDisp_Cam1.TabIndex = 1;
      this.gBox_CtrlOnDisp_Cam1.TabStop = false;
      this.gBox_CtrlOnDisp_Cam1.Text = "Camera1";
      // 
      // gBox_imgFile
      // 
      this.gBox_imgFile.Controls.Add(this.chkGiveFileName);
      this.gBox_imgFile.Controls.Add(this.txtFileName);
      this.gBox_imgFile.Controls.Add(this.chkImageSaveWithGraphics);
      this.gBox_imgFile.Location = new System.Drawing.Point(6, 215);
      this.gBox_imgFile.Name = "gBox_imgFile";
      this.gBox_imgFile.Size = new System.Drawing.Size(210, 71);
      this.gBox_imgFile.TabIndex = 11;
      this.gBox_imgFile.TabStop = false;
      this.gBox_imgFile.Text = "Image File (.bmp) Path";
      // 
      // chkGiveFileName
      // 
      this.chkGiveFileName.AutoSize = true;
      this.chkGiveFileName.Location = new System.Drawing.Point(6, 21);
      this.chkGiveFileName.Name = "chkGiveFileName";
      this.chkGiveFileName.Size = new System.Drawing.Size(44, 16);
      this.chkGiveFileName.TabIndex = 30;
      this.chkGiveFileName.Text = "Use";
      this.chkGiveFileName.UseVisualStyleBackColor = true;
      this.chkGiveFileName.CheckedChanged += new System.EventHandler(this.chkGiveFileName_CheckedChanged);
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(56, 19);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(148, 19);
      this.txtFileName.TabIndex = 32;
      this.txtFileName.Text = "C:\\Temp\\image.bmp";
      this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
      // 
      // chkImageSaveWithGraphics
      // 
      this.chkImageSaveWithGraphics.AutoSize = true;
      this.chkImageSaveWithGraphics.Location = new System.Drawing.Point(6, 47);
      this.chkImageSaveWithGraphics.Name = "chkImageSaveWithGraphics";
      this.chkImageSaveWithGraphics.Size = new System.Drawing.Size(81, 16);
      this.chkImageSaveWithGraphics.TabIndex = 31;
      this.chkImageSaveWithGraphics.Text = "w Graphics";
      this.chkImageSaveWithGraphics.UseVisualStyleBackColor = true;
      this.chkImageSaveWithGraphics.CheckedChanged += new System.EventHandler(this.chkImageSaveWithGraphics_CheckedChanged);
      // 
      // checkBox_FocusFeedback1
      // 
      this.checkBox_FocusFeedback1.Checked = true;
      this.checkBox_FocusFeedback1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_FocusFeedback1.Location = new System.Drawing.Point(6, 191);
      this.checkBox_FocusFeedback1.Name = "checkBox_FocusFeedback1";
      this.checkBox_FocusFeedback1.Size = new System.Drawing.Size(111, 21);
      this.checkBox_FocusFeedback1.TabIndex = 11;
      this.checkBox_FocusFeedback1.Text = "Focus Feedback";
      this.checkBox_FocusFeedback1.UseVisualStyleBackColor = true;
      this.checkBox_FocusFeedback1.CheckedChanged += new System.EventHandler(this.checkBox_FocusFeedback1_CheckedChanged);
      // 
      // checkBox_ShowStatusBar1
      // 
      this.checkBox_ShowStatusBar1.Checked = true;
      this.checkBox_ShowStatusBar1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_ShowStatusBar1.Location = new System.Drawing.Point(90, 136);
      this.checkBox_ShowStatusBar1.Name = "checkBox_ShowStatusBar1";
      this.checkBox_ShowStatusBar1.Size = new System.Drawing.Size(83, 24);
      this.checkBox_ShowStatusBar1.TabIndex = 10;
      this.checkBox_ShowStatusBar1.Text = "StatusBar";
      this.checkBox_ShowStatusBar1.UseVisualStyleBackColor = true;
      this.checkBox_ShowStatusBar1.CheckedChanged += new System.EventHandler(this.checkBox_StatusBarVisibility1_CheckedChanged);
      // 
      // checkBox_ShowGraphics1
      // 
      this.checkBox_ShowGraphics1.Checked = true;
      this.checkBox_ShowGraphics1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_ShowGraphics1.Location = new System.Drawing.Point(6, 165);
      this.checkBox_ShowGraphics1.Name = "checkBox_ShowGraphics1";
      this.checkBox_ShowGraphics1.Size = new System.Drawing.Size(75, 23);
      this.checkBox_ShowGraphics1.TabIndex = 9;
      this.checkBox_ShowGraphics1.Text = "Graphics";
      this.checkBox_ShowGraphics1.UseVisualStyleBackColor = true;
      this.checkBox_ShowGraphics1.CheckedChanged += new System.EventHandler(this.checkBox_ShowGraphics1_CheckedChanged);
      // 
      // btn_StopLive1
      // 
      this.btn_StopLive1.Location = new System.Drawing.Point(90, 106);
      this.btn_StopLive1.Name = "btn_StopLive1";
      this.btn_StopLive1.Size = new System.Drawing.Size(83, 22);
      this.btn_StopLive1.TabIndex = 8;
      this.btn_StopLive1.Text = "Stop Live";
      this.btn_StopLive1.UseVisualStyleBackColor = true;
      this.btn_StopLive1.Click += new System.EventHandler(this.btn_StopLive1_Click);
      // 
      // btn_SaveImg1
      // 
      this.btn_SaveImg1.Location = new System.Drawing.Point(6, 136);
      this.btn_SaveImg1.Name = "btn_SaveImg1";
      this.btn_SaveImg1.Size = new System.Drawing.Size(75, 22);
      this.btn_SaveImg1.TabIndex = 6;
      this.btn_SaveImg1.Text = "Save Image";
      this.btn_SaveImg1.UseVisualStyleBackColor = true;
      this.btn_SaveImg1.Click += new System.EventHandler(this.btn_SaveImg1_Click);
      // 
      // btn_StartLive1
      // 
      this.btn_StartLive1.Location = new System.Drawing.Point(90, 78);
      this.btn_StartLive1.Name = "btn_StartLive1";
      this.btn_StartLive1.Size = new System.Drawing.Size(83, 22);
      this.btn_StartLive1.TabIndex = 8;
      this.btn_StartLive1.Text = "Start Live";
      this.btn_StartLive1.UseVisualStyleBackColor = true;
      this.btn_StartLive1.Click += new System.EventHandler(this.btn_StartLive1_Click);
      // 
      // btn_RotCCW1
      // 
      this.btn_RotCCW1.Location = new System.Drawing.Point(90, 22);
      this.btn_RotCCW1.Name = "btn_RotCCW1";
      this.btn_RotCCW1.Size = new System.Drawing.Size(83, 22);
      this.btn_RotCCW1.TabIndex = 5;
      this.btn_RotCCW1.Text = "Rotate CCW";
      this.btn_RotCCW1.UseVisualStyleBackColor = true;
      this.btn_RotCCW1.Click += new System.EventHandler(this.btn_RotCCW1_Click);
      // 
      // btn_RotCW1
      // 
      this.btn_RotCW1.Location = new System.Drawing.Point(90, 50);
      this.btn_RotCW1.Name = "btn_RotCW1";
      this.btn_RotCW1.Size = new System.Drawing.Size(83, 22);
      this.btn_RotCW1.TabIndex = 8;
      this.btn_RotCW1.Text = "Rotate CW";
      this.btn_RotCW1.UseVisualStyleBackColor = true;
      this.btn_RotCW1.Click += new System.EventHandler(this.btn_RotCW1_Click);
      // 
      // btn_LoadImg1
      // 
      this.btn_LoadImg1.Location = new System.Drawing.Point(6, 106);
      this.btn_LoadImg1.Name = "btn_LoadImg1";
      this.btn_LoadImg1.Size = new System.Drawing.Size(75, 22);
      this.btn_LoadImg1.TabIndex = 7;
      this.btn_LoadImg1.Text = "Load Image";
      this.btn_LoadImg1.UseVisualStyleBackColor = true;
      this.btn_LoadImg1.Click += new System.EventHandler(this.btn_LoadImg1_Click);
      // 
      // btn_ZoomOut1
      // 
      this.btn_ZoomOut1.Location = new System.Drawing.Point(6, 78);
      this.btn_ZoomOut1.Name = "btn_ZoomOut1";
      this.btn_ZoomOut1.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomOut1.TabIndex = 4;
      this.btn_ZoomOut1.Text = "Zoom Out";
      this.btn_ZoomOut1.UseVisualStyleBackColor = true;
      this.btn_ZoomOut1.Click += new System.EventHandler(this.btn_ZoomOut1_Click);
      // 
      // btn_ZoomIn1
      // 
      this.btn_ZoomIn1.Location = new System.Drawing.Point(6, 50);
      this.btn_ZoomIn1.Name = "btn_ZoomIn1";
      this.btn_ZoomIn1.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomIn1.TabIndex = 3;
      this.btn_ZoomIn1.Text = "Zoom In";
      this.btn_ZoomIn1.UseVisualStyleBackColor = true;
      this.btn_ZoomIn1.Click += new System.EventHandler(this.btn_ZoomIn1_Click);
      // 
      // btn_ZoomFit1
      // 
      this.btn_ZoomFit1.Location = new System.Drawing.Point(6, 22);
      this.btn_ZoomFit1.Name = "btn_ZoomFit1";
      this.btn_ZoomFit1.Size = new System.Drawing.Size(75, 22);
      this.btn_ZoomFit1.TabIndex = 2;
      this.btn_ZoomFit1.Text = "Zoom Fit";
      this.btn_ZoomFit1.UseVisualStyleBackColor = true;
      this.btn_ZoomFit1.Click += new System.EventHandler(this.btn_ZoomFit1_Click);
      // 
      // checkBox_FovCross1
      // 
      this.checkBox_FovCross1.Location = new System.Drawing.Point(90, 160);
      this.checkBox_FovCross1.Name = "checkBox_FovCross1";
      this.checkBox_FovCross1.Size = new System.Drawing.Size(92, 32);
      this.checkBox_FovCross1.TabIndex = 1;
      this.checkBox_FovCross1.Text = "FOV Center Cross";
      this.checkBox_FovCross1.UseVisualStyleBackColor = true;
      this.checkBox_FovCross1.CheckedChanged += new System.EventHandler(this.checkBox_FovCross1_CheckedChanged);
      // 
      // checkBox_ToolBar
      // 
      this.checkBox_ToolBar.AutoSize = true;
      this.checkBox_ToolBar.Checked = true;
      this.checkBox_ToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_ToolBar.Location = new System.Drawing.Point(6, 9);
      this.checkBox_ToolBar.Name = "checkBox_ToolBar";
      this.checkBox_ToolBar.Size = new System.Drawing.Size(62, 16);
      this.checkBox_ToolBar.TabIndex = 0;
      this.checkBox_ToolBar.Text = "Toolbar";
      this.checkBox_ToolBar.UseVisualStyleBackColor = true;
      this.checkBox_ToolBar.CheckedChanged += new System.EventHandler(this.checkBox_ToolBar_CheckedChanged);
      // 
      // tabCheckerCalib
      // 
      this.tabCheckerCalib.Controls.Add(this.groupBox14);
      this.tabCheckerCalib.Location = new System.Drawing.Point(4, 22);
      this.tabCheckerCalib.Name = "tabCheckerCalib";
      this.tabCheckerCalib.Size = new System.Drawing.Size(517, 414);
      this.tabCheckerCalib.TabIndex = 13;
      this.tabCheckerCalib.Text = "Checker";
      this.tabCheckerCalib.UseVisualStyleBackColor = true;
      // 
      // groupBox14
      // 
      this.groupBox14.Controls.Add(this.groupBox17);
      this.groupBox14.Controls.Add(this.label90);
      this.groupBox14.Controls.Add(this.lbl_CheckerStatus);
      this.groupBox14.Controls.Add(this.btn_CheckerSetRegion);
      this.groupBox14.Controls.Add(this.btn_CheckerMaxRegion);
      this.groupBox14.Controls.Add(this.label89);
      this.groupBox14.Controls.Add(this.numUpDown_Checker_CamID);
      this.groupBox14.Controls.Add(this.btn_CheckerCalibrate);
      this.groupBox14.Controls.Add(this.numUpDown_CheckerXSpacing);
      this.groupBox14.Controls.Add(this.btn_CheckerUnCalibrate);
      this.groupBox14.Controls.Add(this.label91);
      this.groupBox14.Controls.Add(this.label92);
      this.groupBox14.Controls.Add(this.numUpDown_CheckerYSpacing);
      this.groupBox14.Location = new System.Drawing.Point(18, 23);
      this.groupBox14.Name = "groupBox14";
      this.groupBox14.Size = new System.Drawing.Size(438, 261);
      this.groupBox14.TabIndex = 47;
      this.groupBox14.TabStop = false;
      this.groupBox14.Text = "Checkerboard Calibration";
      // 
      // groupBox17
      // 
      this.groupBox17.Controls.Add(this.btn_ChangeExpSetup_Checker);
      this.groupBox17.Controls.Add(this.label93);
      this.groupBox17.Controls.Add(this.numUpDown_LightCrl_Checker);
      this.groupBox17.Controls.Add(this.label94);
      this.groupBox17.Controls.Add(this.numUpDown_Exposure_Checker);
      this.groupBox17.Controls.Add(this.checkBox_LightEn_Checker);
      this.groupBox17.Location = new System.Drawing.Point(13, 63);
      this.groupBox17.Name = "groupBox17";
      this.groupBox17.Size = new System.Drawing.Size(175, 164);
      this.groupBox17.TabIndex = 48;
      this.groupBox17.TabStop = false;
      this.groupBox17.Text = "Current Exposure Setup";
      // 
      // btn_ChangeExpSetup_Checker
      // 
      this.btn_ChangeExpSetup_Checker.BackColor = System.Drawing.Color.Lime;
      this.btn_ChangeExpSetup_Checker.Location = new System.Drawing.Point(8, 129);
      this.btn_ChangeExpSetup_Checker.Name = "btn_ChangeExpSetup_Checker";
      this.btn_ChangeExpSetup_Checker.Size = new System.Drawing.Size(140, 23);
      this.btn_ChangeExpSetup_Checker.TabIndex = 7;
      this.btn_ChangeExpSetup_Checker.Text = "Change Exposure Setup";
      this.btn_ChangeExpSetup_Checker.UseVisualStyleBackColor = false;
      this.btn_ChangeExpSetup_Checker.Click += new System.EventHandler(this.btn_ChangeExpSetup_Checker_Click);
      // 
      // label93
      // 
      this.label93.AutoSize = true;
      this.label93.Location = new System.Drawing.Point(6, 25);
      this.label93.Name = "label93";
      this.label93.Size = new System.Drawing.Size(79, 12);
      this.label93.TabIndex = 0;
      this.label93.Text = "Exposure [ms]";
      // 
      // numUpDown_LightCrl_Checker
      // 
      this.numUpDown_LightCrl_Checker.Location = new System.Drawing.Point(91, 92);
      this.numUpDown_LightCrl_Checker.Name = "numUpDown_LightCrl_Checker";
      this.numUpDown_LightCrl_Checker.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_LightCrl_Checker.TabIndex = 6;
      // 
      // label94
      // 
      this.label94.AutoSize = true;
      this.label94.Location = new System.Drawing.Point(6, 97);
      this.label94.Name = "label94";
      this.label94.Size = new System.Drawing.Size(71, 12);
      this.label94.TabIndex = 2;
      this.label94.Text = "Light Control";
      // 
      // numUpDown_Exposure_Checker
      // 
      this.numUpDown_Exposure_Checker.DecimalPlaces = 2;
      this.numUpDown_Exposure_Checker.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numUpDown_Exposure_Checker.Location = new System.Drawing.Point(91, 23);
      this.numUpDown_Exposure_Checker.Name = "numUpDown_Exposure_Checker";
      this.numUpDown_Exposure_Checker.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Exposure_Checker.TabIndex = 5;
      // 
      // checkBox_LightEn_Checker
      // 
      this.checkBox_LightEn_Checker.AutoSize = true;
      this.checkBox_LightEn_Checker.Location = new System.Drawing.Point(6, 59);
      this.checkBox_LightEn_Checker.Name = "checkBox_LightEn_Checker";
      this.checkBox_LightEn_Checker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_LightEn_Checker.Size = new System.Drawing.Size(99, 16);
      this.checkBox_LightEn_Checker.TabIndex = 3;
      this.checkBox_LightEn_Checker.Text = "   Light Enable";
      this.checkBox_LightEn_Checker.UseVisualStyleBackColor = true;
      // 
      // label90
      // 
      this.label90.AutoSize = true;
      this.label90.Location = new System.Drawing.Point(150, 23);
      this.label90.Name = "label90";
      this.label90.Size = new System.Drawing.Size(38, 12);
      this.label90.TabIndex = 48;
      this.label90.Text = "Status";
      // 
      // lbl_CheckerStatus
      // 
      this.lbl_CheckerStatus.BackColor = System.Drawing.Color.Yellow;
      this.lbl_CheckerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_CheckerStatus.Location = new System.Drawing.Point(194, 18);
      this.lbl_CheckerStatus.Name = "lbl_CheckerStatus";
      this.lbl_CheckerStatus.Size = new System.Drawing.Size(92, 23);
      this.lbl_CheckerStatus.TabIndex = 47;
      this.lbl_CheckerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_CheckerSetRegion
      // 
      this.btn_CheckerSetRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_CheckerSetRegion.Location = new System.Drawing.Point(220, 169);
      this.btn_CheckerSetRegion.Name = "btn_CheckerSetRegion";
      this.btn_CheckerSetRegion.Size = new System.Drawing.Size(109, 23);
      this.btn_CheckerSetRegion.TabIndex = 45;
      this.btn_CheckerSetRegion.Text = "Set Calib Region";
      this.btn_CheckerSetRegion.UseVisualStyleBackColor = false;
      this.btn_CheckerSetRegion.Click += new System.EventHandler(this.btn_CheckerSetRegion_Click);
      // 
      // btn_CheckerMaxRegion
      // 
      this.btn_CheckerMaxRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_CheckerMaxRegion.Location = new System.Drawing.Point(220, 198);
      this.btn_CheckerMaxRegion.Name = "btn_CheckerMaxRegion";
      this.btn_CheckerMaxRegion.Size = new System.Drawing.Size(109, 23);
      this.btn_CheckerMaxRegion.TabIndex = 46;
      this.btn_CheckerMaxRegion.Text = "Max Calib Region";
      this.btn_CheckerMaxRegion.UseVisualStyleBackColor = false;
      this.btn_CheckerMaxRegion.Click += new System.EventHandler(this.btn_CheckerMaxRegion_Click);
      // 
      // label89
      // 
      this.label89.AutoSize = true;
      this.label89.Location = new System.Drawing.Point(11, 25);
      this.label89.Name = "label89";
      this.label89.Size = new System.Drawing.Size(59, 12);
      this.label89.TabIndex = 36;
      this.label89.Text = "Camera ID";
      // 
      // numUpDown_Checker_CamID
      // 
      this.numUpDown_Checker_CamID.Location = new System.Drawing.Point(80, 21);
      this.numUpDown_Checker_CamID.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numUpDown_Checker_CamID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_Checker_CamID.Name = "numUpDown_Checker_CamID";
      this.numUpDown_Checker_CamID.Size = new System.Drawing.Size(37, 19);
      this.numUpDown_Checker_CamID.TabIndex = 37;
      this.numUpDown_Checker_CamID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_Checker_CamID.ValueChanged += new System.EventHandler(this.numUpDown_Checker_CamID_ValueChanged);
      // 
      // btn_CheckerCalibrate
      // 
      this.btn_CheckerCalibrate.BackColor = System.Drawing.Color.Lime;
      this.btn_CheckerCalibrate.Location = new System.Drawing.Point(220, 127);
      this.btn_CheckerCalibrate.Name = "btn_CheckerCalibrate";
      this.btn_CheckerCalibrate.Size = new System.Drawing.Size(82, 23);
      this.btn_CheckerCalibrate.TabIndex = 44;
      this.btn_CheckerCalibrate.Text = "Calibrate";
      this.btn_CheckerCalibrate.UseVisualStyleBackColor = false;
      this.btn_CheckerCalibrate.Click += new System.EventHandler(this.btn_CheckerCalibrate_Click);
      // 
      // numUpDown_CheckerXSpacing
      // 
      this.numUpDown_CheckerXSpacing.DecimalPlaces = 2;
      this.numUpDown_CheckerXSpacing.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numUpDown_CheckerXSpacing.Location = new System.Drawing.Point(348, 59);
      this.numUpDown_CheckerXSpacing.Name = "numUpDown_CheckerXSpacing";
      this.numUpDown_CheckerXSpacing.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_CheckerXSpacing.TabIndex = 40;
      // 
      // btn_CheckerUnCalibrate
      // 
      this.btn_CheckerUnCalibrate.BackColor = System.Drawing.Color.Lime;
      this.btn_CheckerUnCalibrate.Location = new System.Drawing.Point(313, 127);
      this.btn_CheckerUnCalibrate.Name = "btn_CheckerUnCalibrate";
      this.btn_CheckerUnCalibrate.Size = new System.Drawing.Size(82, 23);
      this.btn_CheckerUnCalibrate.TabIndex = 43;
      this.btn_CheckerUnCalibrate.Text = "Uncalibrate";
      this.btn_CheckerUnCalibrate.UseVisualStyleBackColor = false;
      this.btn_CheckerUnCalibrate.Click += new System.EventHandler(this.btn_CheckerUnCalibrate_Click);
      // 
      // label91
      // 
      this.label91.AutoSize = true;
      this.label91.Location = new System.Drawing.Point(218, 63);
      this.label91.Name = "label91";
      this.label91.Size = new System.Drawing.Size(111, 12);
      this.label91.TabIndex = 39;
      this.label91.Text = "X Grid Spacing [mm]";
      // 
      // label92
      // 
      this.label92.AutoSize = true;
      this.label92.Location = new System.Drawing.Point(218, 92);
      this.label92.Name = "label92";
      this.label92.Size = new System.Drawing.Size(111, 12);
      this.label92.TabIndex = 41;
      this.label92.Text = "Y Grid Spacing [mm]";
      // 
      // numUpDown_CheckerYSpacing
      // 
      this.numUpDown_CheckerYSpacing.DecimalPlaces = 2;
      this.numUpDown_CheckerYSpacing.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numUpDown_CheckerYSpacing.Location = new System.Drawing.Point(348, 88);
      this.numUpDown_CheckerYSpacing.Name = "numUpDown_CheckerYSpacing";
      this.numUpDown_CheckerYSpacing.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_CheckerYSpacing.TabIndex = 42;
      // 
      // tabExposure
      // 
      this.tabExposure.Controls.Add(this.gBox_ExposureSetting_Cam2);
      this.tabExposure.Controls.Add(this.gBox_ExposureSetting_Cam1);
      this.tabExposure.Location = new System.Drawing.Point(4, 22);
      this.tabExposure.Name = "tabExposure";
      this.tabExposure.Size = new System.Drawing.Size(517, 414);
      this.tabExposure.TabIndex = 10;
      this.tabExposure.Text = " Exp";
      this.tabExposure.UseVisualStyleBackColor = true;
      // 
      // gBox_ExposureSetting_Cam2
      // 
      this.gBox_ExposureSetting_Cam2.Controls.Add(this.label5);
      this.gBox_ExposureSetting_Cam2.Controls.Add(this.numUpDown_ExposureID_Cam2);
      this.gBox_ExposureSetting_Cam2.Controls.Add(this.groupBox23);
      this.gBox_ExposureSetting_Cam2.Location = new System.Drawing.Point(251, 29);
      this.gBox_ExposureSetting_Cam2.Name = "gBox_ExposureSetting_Cam2";
      this.gBox_ExposureSetting_Cam2.Size = new System.Drawing.Size(225, 238);
      this.gBox_ExposureSetting_Cam2.TabIndex = 13;
      this.gBox_ExposureSetting_Cam2.TabStop = false;
      this.gBox_ExposureSetting_Cam2.Text = "Camera 2";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 27);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(149, 12);
      this.label5.TabIndex = 9;
      this.label5.Text = "Current Exposure Setting ID";
      // 
      // numUpDown_ExposureID_Cam2
      // 
      this.numUpDown_ExposureID_Cam2.BackColor = System.Drawing.Color.White;
      this.numUpDown_ExposureID_Cam2.Location = new System.Drawing.Point(175, 23);
      this.numUpDown_ExposureID_Cam2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam2.Name = "numUpDown_ExposureID_Cam2";
      this.numUpDown_ExposureID_Cam2.Size = new System.Drawing.Size(37, 19);
      this.numUpDown_ExposureID_Cam2.TabIndex = 10;
      this.numUpDown_ExposureID_Cam2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam2.ValueChanged += new System.EventHandler(this.numUpDown_ExposureID_Cam2_ValueChanged);
      // 
      // groupBox23
      // 
      this.groupBox23.Controls.Add(this.btn_ChangeExpSetup_Cam2);
      this.groupBox23.Controls.Add(this.label46);
      this.groupBox23.Controls.Add(this.numUpDown_LightCrl_Cam2);
      this.groupBox23.Controls.Add(this.label50);
      this.groupBox23.Controls.Add(this.numUpDown_Exposure_Cam2);
      this.groupBox23.Controls.Add(this.checkBox_LightEn_Cam2);
      this.groupBox23.Location = new System.Drawing.Point(31, 60);
      this.groupBox23.Name = "groupBox23";
      this.groupBox23.Size = new System.Drawing.Size(175, 164);
      this.groupBox23.TabIndex = 11;
      this.groupBox23.TabStop = false;
      this.groupBox23.Text = "Current Exposure Setup";
      // 
      // btn_ChangeExpSetup_Cam2
      // 
      this.btn_ChangeExpSetup_Cam2.BackColor = System.Drawing.Color.Lime;
      this.btn_ChangeExpSetup_Cam2.Location = new System.Drawing.Point(8, 129);
      this.btn_ChangeExpSetup_Cam2.Name = "btn_ChangeExpSetup_Cam2";
      this.btn_ChangeExpSetup_Cam2.Size = new System.Drawing.Size(140, 23);
      this.btn_ChangeExpSetup_Cam2.TabIndex = 7;
      this.btn_ChangeExpSetup_Cam2.Text = "Change Exposure Setup";
      this.btn_ChangeExpSetup_Cam2.UseVisualStyleBackColor = false;
      this.btn_ChangeExpSetup_Cam2.Click += new System.EventHandler(this.btn_ChangeExpSetup_Cam2_Click);
      // 
      // label46
      // 
      this.label46.AutoSize = true;
      this.label46.Location = new System.Drawing.Point(6, 25);
      this.label46.Name = "label46";
      this.label46.Size = new System.Drawing.Size(79, 12);
      this.label46.TabIndex = 0;
      this.label46.Text = "Exposure [ms]";
      // 
      // numUpDown_LightCrl_Cam2
      // 
      this.numUpDown_LightCrl_Cam2.Location = new System.Drawing.Point(91, 92);
      this.numUpDown_LightCrl_Cam2.Name = "numUpDown_LightCrl_Cam2";
      this.numUpDown_LightCrl_Cam2.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_LightCrl_Cam2.TabIndex = 6;
      // 
      // label50
      // 
      this.label50.AutoSize = true;
      this.label50.Location = new System.Drawing.Point(6, 97);
      this.label50.Name = "label50";
      this.label50.Size = new System.Drawing.Size(71, 12);
      this.label50.TabIndex = 2;
      this.label50.Text = "Light Control";
      // 
      // numUpDown_Exposure_Cam2
      // 
      this.numUpDown_Exposure_Cam2.DecimalPlaces = 2;
      this.numUpDown_Exposure_Cam2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numUpDown_Exposure_Cam2.Location = new System.Drawing.Point(91, 23);
      this.numUpDown_Exposure_Cam2.Name = "numUpDown_Exposure_Cam2";
      this.numUpDown_Exposure_Cam2.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Exposure_Cam2.TabIndex = 5;
      // 
      // checkBox_LightEn_Cam2
      // 
      this.checkBox_LightEn_Cam2.AutoSize = true;
      this.checkBox_LightEn_Cam2.Location = new System.Drawing.Point(6, 59);
      this.checkBox_LightEn_Cam2.Name = "checkBox_LightEn_Cam2";
      this.checkBox_LightEn_Cam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_LightEn_Cam2.Size = new System.Drawing.Size(99, 16);
      this.checkBox_LightEn_Cam2.TabIndex = 3;
      this.checkBox_LightEn_Cam2.Text = "   Light Enable";
      this.checkBox_LightEn_Cam2.UseVisualStyleBackColor = true;
      // 
      // gBox_ExposureSetting_Cam1
      // 
      this.gBox_ExposureSetting_Cam1.Controls.Add(this.groupBox11);
      this.gBox_ExposureSetting_Cam1.Controls.Add(this.label83);
      this.gBox_ExposureSetting_Cam1.Controls.Add(this.numUpDown_ExposureID_Cam1);
      this.gBox_ExposureSetting_Cam1.Controls.Add(this.groupBox1);
      this.gBox_ExposureSetting_Cam1.Location = new System.Drawing.Point(8, 29);
      this.gBox_ExposureSetting_Cam1.Name = "gBox_ExposureSetting_Cam1";
      this.gBox_ExposureSetting_Cam1.Size = new System.Drawing.Size(225, 343);
      this.gBox_ExposureSetting_Cam1.TabIndex = 12;
      this.gBox_ExposureSetting_Cam1.TabStop = false;
      this.gBox_ExposureSetting_Cam1.Text = "Camera 1";
      // 
      // groupBox11
      // 
      this.groupBox11.Controls.Add(this.btn_AutoExpSetRegion_Cam1);
      this.groupBox11.Controls.Add(this.label88);
      this.groupBox11.Controls.Add(this.btn_AutoExpCancel_Cam1);
      this.groupBox11.Controls.Add(this.lbl_AutoExpStatus_Cam1);
      this.groupBox11.Controls.Add(this.btn_AutoExpStart_Cam1);
      this.groupBox11.Location = new System.Drawing.Point(19, 238);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new System.Drawing.Size(200, 82);
      this.groupBox11.TabIndex = 14;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "Auto Exposure Setting";
      // 
      // btn_AutoExpSetRegion_Cam1
      // 
      this.btn_AutoExpSetRegion_Cam1.BackColor = System.Drawing.Color.Lime;
      this.btn_AutoExpSetRegion_Cam1.Location = new System.Drawing.Point(124, 22);
      this.btn_AutoExpSetRegion_Cam1.Name = "btn_AutoExpSetRegion_Cam1";
      this.btn_AutoExpSetRegion_Cam1.Size = new System.Drawing.Size(68, 23);
      this.btn_AutoExpSetRegion_Cam1.TabIndex = 30;
      this.btn_AutoExpSetRegion_Cam1.Text = "SetRegion";
      this.btn_AutoExpSetRegion_Cam1.UseVisualStyleBackColor = false;
      this.btn_AutoExpSetRegion_Cam1.Click += new System.EventHandler(this.btn_AutoExpSetRegion_Cam1_Click);
      // 
      // label88
      // 
      this.label88.AutoSize = true;
      this.label88.Location = new System.Drawing.Point(13, 56);
      this.label88.Name = "label88";
      this.label88.Size = new System.Drawing.Size(38, 12);
      this.label88.TabIndex = 28;
      this.label88.Text = "Status";
      // 
      // btn_AutoExpCancel_Cam1
      // 
      this.btn_AutoExpCancel_Cam1.BackColor = System.Drawing.Color.Lime;
      this.btn_AutoExpCancel_Cam1.Location = new System.Drawing.Point(61, 22);
      this.btn_AutoExpCancel_Cam1.Name = "btn_AutoExpCancel_Cam1";
      this.btn_AutoExpCancel_Cam1.Size = new System.Drawing.Size(54, 23);
      this.btn_AutoExpCancel_Cam1.TabIndex = 29;
      this.btn_AutoExpCancel_Cam1.Text = "Cancel";
      this.btn_AutoExpCancel_Cam1.UseVisualStyleBackColor = false;
      this.btn_AutoExpCancel_Cam1.Click += new System.EventHandler(this.btn_AutoExpCancel_Cam1_Click);
      // 
      // lbl_AutoExpStatus_Cam1
      // 
      this.lbl_AutoExpStatus_Cam1.BackColor = System.Drawing.Color.Yellow;
      this.lbl_AutoExpStatus_Cam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_AutoExpStatus_Cam1.Location = new System.Drawing.Point(51, 51);
      this.lbl_AutoExpStatus_Cam1.Name = "lbl_AutoExpStatus_Cam1";
      this.lbl_AutoExpStatus_Cam1.Size = new System.Drawing.Size(143, 23);
      this.lbl_AutoExpStatus_Cam1.TabIndex = 28;
      this.lbl_AutoExpStatus_Cam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_AutoExpStart_Cam1
      // 
      this.btn_AutoExpStart_Cam1.BackColor = System.Drawing.Color.Lime;
      this.btn_AutoExpStart_Cam1.Location = new System.Drawing.Point(11, 22);
      this.btn_AutoExpStart_Cam1.Name = "btn_AutoExpStart_Cam1";
      this.btn_AutoExpStart_Cam1.Size = new System.Drawing.Size(46, 23);
      this.btn_AutoExpStart_Cam1.TabIndex = 12;
      this.btn_AutoExpStart_Cam1.Text = "Start";
      this.btn_AutoExpStart_Cam1.UseVisualStyleBackColor = false;
      this.btn_AutoExpStart_Cam1.Click += new System.EventHandler(this.btn_AutoExpStart_Cam1_Click);
      // 
      // label83
      // 
      this.label83.AutoSize = true;
      this.label83.Location = new System.Drawing.Point(18, 27);
      this.label83.Name = "label83";
      this.label83.Size = new System.Drawing.Size(149, 12);
      this.label83.TabIndex = 9;
      this.label83.Text = "Current Exposure Setting ID";
      // 
      // numUpDown_ExposureID_Cam1
      // 
      this.numUpDown_ExposureID_Cam1.BackColor = System.Drawing.Color.White;
      this.numUpDown_ExposureID_Cam1.Location = new System.Drawing.Point(175, 23);
      this.numUpDown_ExposureID_Cam1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam1.Name = "numUpDown_ExposureID_Cam1";
      this.numUpDown_ExposureID_Cam1.Size = new System.Drawing.Size(37, 19);
      this.numUpDown_ExposureID_Cam1.TabIndex = 10;
      this.numUpDown_ExposureID_Cam1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_ExposureID_Cam1.ValueChanged += new System.EventHandler(this.numUpDown_ExposureID_Cam1_ValueChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btn_ChangeExpSetup_Cam1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.numUpDown_LightCrl_Cam1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.numUpDown_Exposure_Cam1);
      this.groupBox1.Controls.Add(this.checkBox_LightEn_Cam1);
      this.groupBox1.Location = new System.Drawing.Point(31, 60);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(175, 164);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Current Exposure Setup";
      // 
      // btn_ChangeExpSetup_Cam1
      // 
      this.btn_ChangeExpSetup_Cam1.BackColor = System.Drawing.Color.Lime;
      this.btn_ChangeExpSetup_Cam1.Location = new System.Drawing.Point(8, 129);
      this.btn_ChangeExpSetup_Cam1.Name = "btn_ChangeExpSetup_Cam1";
      this.btn_ChangeExpSetup_Cam1.Size = new System.Drawing.Size(140, 23);
      this.btn_ChangeExpSetup_Cam1.TabIndex = 7;
      this.btn_ChangeExpSetup_Cam1.Text = "Change Exposure Setup";
      this.btn_ChangeExpSetup_Cam1.UseVisualStyleBackColor = false;
      this.btn_ChangeExpSetup_Cam1.Click += new System.EventHandler(this.btn_ChangeExpSetup_Cam1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "Exposure [ms]";
      // 
      // numUpDown_LightCrl_Cam1
      // 
      this.numUpDown_LightCrl_Cam1.Location = new System.Drawing.Point(91, 92);
      this.numUpDown_LightCrl_Cam1.Name = "numUpDown_LightCrl_Cam1";
      this.numUpDown_LightCrl_Cam1.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_LightCrl_Cam1.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 97);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "Light Control";
      // 
      // numUpDown_Exposure_Cam1
      // 
      this.numUpDown_Exposure_Cam1.DecimalPlaces = 2;
      this.numUpDown_Exposure_Cam1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.numUpDown_Exposure_Cam1.Location = new System.Drawing.Point(91, 23);
      this.numUpDown_Exposure_Cam1.Name = "numUpDown_Exposure_Cam1";
      this.numUpDown_Exposure_Cam1.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Exposure_Cam1.TabIndex = 5;
      // 
      // checkBox_LightEn_Cam1
      // 
      this.checkBox_LightEn_Cam1.AutoSize = true;
      this.checkBox_LightEn_Cam1.Location = new System.Drawing.Point(6, 59);
      this.checkBox_LightEn_Cam1.Name = "checkBox_LightEn_Cam1";
      this.checkBox_LightEn_Cam1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_LightEn_Cam1.Size = new System.Drawing.Size(99, 16);
      this.checkBox_LightEn_Cam1.TabIndex = 3;
      this.checkBox_LightEn_Cam1.Text = "   Light Enable";
      this.checkBox_LightEn_Cam1.UseVisualStyleBackColor = true;
      // 
      // tabFeature
      // 
      this.tabFeature.Controls.Add(this.numUpDown_Feature_CamID);
      this.tabFeature.Controls.Add(this.btn_AcqImageAndRun);
      this.tabFeature.Controls.Add(this.numUpDown_FeatureID);
      this.tabFeature.Controls.Add(this.label53);
      this.tabFeature.Controls.Add(this.label4);
      this.tabFeature.Controls.Add(this.groupBox19);
      this.tabFeature.Controls.Add(this.groupBox18);
      this.tabFeature.Controls.Add(this.label57);
      this.tabFeature.Controls.Add(this.comboBox_Graphics);
      this.tabFeature.Controls.Add(this.checkBox_SearchInfoEn);
      this.tabFeature.Controls.Add(this.groupBox16);
      this.tabFeature.Controls.Add(this.btn_Cancel);
      this.tabFeature.Controls.Add(this.btn_Accept);
      this.tabFeature.Controls.Add(this.btn_PatternOrigin);
      this.tabFeature.Controls.Add(this.btn_MaxSearchRegion);
      this.tabFeature.Controls.Add(this.btn_TrainRegion);
      this.tabFeature.Controls.Add(this.btn_SearchRegion);
      this.tabFeature.Location = new System.Drawing.Point(4, 22);
      this.tabFeature.Name = "tabFeature";
      this.tabFeature.Padding = new System.Windows.Forms.Padding(3);
      this.tabFeature.Size = new System.Drawing.Size(517, 414);
      this.tabFeature.TabIndex = 3;
      this.tabFeature.Text = "Feature";
      this.tabFeature.UseVisualStyleBackColor = true;
      // 
      // numUpDown_Feature_CamID
      // 
      this.numUpDown_Feature_CamID.Location = new System.Drawing.Point(114, 17);
      this.numUpDown_Feature_CamID.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numUpDown_Feature_CamID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_Feature_CamID.Name = "numUpDown_Feature_CamID";
      this.numUpDown_Feature_CamID.Size = new System.Drawing.Size(37, 19);
      this.numUpDown_Feature_CamID.TabIndex = 35;
      this.numUpDown_Feature_CamID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_Feature_CamID.ValueChanged += new System.EventHandler(this.numUpDown_Feature_CamID_ValueChanged);
      // 
      // btn_AcqImageAndRun
      // 
      this.btn_AcqImageAndRun.BackColor = System.Drawing.Color.Lime;
      this.btn_AcqImageAndRun.Location = new System.Drawing.Point(12, 255);
      this.btn_AcqImageAndRun.Name = "btn_AcqImageAndRun";
      this.btn_AcqImageAndRun.Size = new System.Drawing.Size(173, 21);
      this.btn_AcqImageAndRun.TabIndex = 34;
      this.btn_AcqImageAndRun.Text = "Acquire Image and Run";
      this.btn_AcqImageAndRun.UseVisualStyleBackColor = false;
      this.btn_AcqImageAndRun.Click += new System.EventHandler(this.btn_AcqImageAndRun_Click);
      // 
      // numUpDown_FeatureID
      // 
      this.numUpDown_FeatureID.Location = new System.Drawing.Point(114, 45);
      this.numUpDown_FeatureID.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
      this.numUpDown_FeatureID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_FeatureID.Name = "numUpDown_FeatureID";
      this.numUpDown_FeatureID.Size = new System.Drawing.Size(37, 19);
      this.numUpDown_FeatureID.TabIndex = 33;
      this.numUpDown_FeatureID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numUpDown_FeatureID.ValueChanged += new System.EventHandler(this.numUpDown_FeatureID_ValueChanged);
      // 
      // label53
      // 
      this.label53.AutoSize = true;
      this.label53.Location = new System.Drawing.Point(13, 24);
      this.label53.Name = "label53";
      this.label53.Size = new System.Drawing.Size(59, 12);
      this.label53.TabIndex = 32;
      this.label53.Text = "Camera ID";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 12);
      this.label4.TabIndex = 32;
      this.label4.Text = "Select Feature ID";
      // 
      // groupBox19
      // 
      this.groupBox19.Controls.Add(this.label59);
      this.groupBox19.Controls.Add(this.label58);
      this.groupBox19.Controls.Add(this.lbl_TrainHeight);
      this.groupBox19.Controls.Add(this.label60);
      this.groupBox19.Controls.Add(this.lbl_TrainWidth);
      this.groupBox19.Controls.Add(this.label62);
      this.groupBox19.Controls.Add(this.lbl_TrainY);
      this.groupBox19.Controls.Add(this.label64);
      this.groupBox19.Controls.Add(this.lbl_TrainX);
      this.groupBox19.Controls.Add(this.btn_GetTrainRegion);
      this.groupBox19.Location = new System.Drawing.Point(14, 290);
      this.groupBox19.Name = "groupBox19";
      this.groupBox19.Size = new System.Drawing.Size(173, 114);
      this.groupBox19.TabIndex = 31;
      this.groupBox19.TabStop = false;
      this.groupBox19.Text = "Get Train Region (Pixels)";
      // 
      // label59
      // 
      this.label59.Location = new System.Drawing.Point(3, 42);
      this.label59.Name = "label59";
      this.label59.Size = new System.Drawing.Size(99, 21);
      this.label59.TabIndex = 24;
      this.label59.Text = "(X0,Y0) is top,left";
      this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label58
      // 
      this.label58.Location = new System.Drawing.Point(85, 68);
      this.label58.Name = "label58";
      this.label58.Size = new System.Drawing.Size(45, 18);
      this.label58.TabIndex = 23;
      this.label58.Text = "Height :";
      this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_TrainHeight
      // 
      this.lbl_TrainHeight.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_TrainHeight.Location = new System.Drawing.Point(131, 67);
      this.lbl_TrainHeight.Name = "lbl_TrainHeight";
      this.lbl_TrainHeight.Size = new System.Drawing.Size(33, 19);
      this.lbl_TrainHeight.TabIndex = 22;
      this.lbl_TrainHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label60
      // 
      this.label60.Location = new System.Drawing.Point(89, 88);
      this.label60.Name = "label60";
      this.label60.Size = new System.Drawing.Size(42, 18);
      this.label60.TabIndex = 21;
      this.label60.Text = "Width :";
      this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_TrainWidth
      // 
      this.lbl_TrainWidth.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_TrainWidth.Location = new System.Drawing.Point(131, 89);
      this.lbl_TrainWidth.Name = "lbl_TrainWidth";
      this.lbl_TrainWidth.Size = new System.Drawing.Size(33, 19);
      this.lbl_TrainWidth.TabIndex = 20;
      this.lbl_TrainWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label62
      // 
      this.label62.Location = new System.Drawing.Point(102, 41);
      this.label62.Name = "label62";
      this.label62.Size = new System.Drawing.Size(26, 18);
      this.label62.TabIndex = 19;
      this.label62.Text = "Y0 :";
      this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_TrainY
      // 
      this.lbl_TrainY.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_TrainY.Location = new System.Drawing.Point(131, 41);
      this.lbl_TrainY.Name = "lbl_TrainY";
      this.lbl_TrainY.Size = new System.Drawing.Size(33, 19);
      this.lbl_TrainY.TabIndex = 18;
      this.lbl_TrainY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label64
      // 
      this.label64.Location = new System.Drawing.Point(103, 21);
      this.label64.Name = "label64";
      this.label64.Size = new System.Drawing.Size(28, 18);
      this.label64.TabIndex = 17;
      this.label64.Text = "X0 :";
      this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_TrainX
      // 
      this.lbl_TrainX.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_TrainX.Location = new System.Drawing.Point(129, 20);
      this.lbl_TrainX.Name = "lbl_TrainX";
      this.lbl_TrainX.Size = new System.Drawing.Size(35, 19);
      this.lbl_TrainX.TabIndex = 16;
      this.lbl_TrainX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_GetTrainRegion
      // 
      this.btn_GetTrainRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_GetTrainRegion.Location = new System.Drawing.Point(6, 18);
      this.btn_GetTrainRegion.Name = "btn_GetTrainRegion";
      this.btn_GetTrainRegion.Size = new System.Drawing.Size(72, 23);
      this.btn_GetTrainRegion.TabIndex = 15;
      this.btn_GetTrainRegion.Text = "Get Region";
      this.btn_GetTrainRegion.UseVisualStyleBackColor = false;
      this.btn_GetTrainRegion.Click += new System.EventHandler(this.btn_GetTrainRegion_Click);
      // 
      // groupBox18
      // 
      this.groupBox18.Controls.Add(this.btn_ChangeSearchParams);
      this.groupBox18.Controls.Add(this.checkBox_ClutterEn);
      this.groupBox18.Controls.Add(this.numUpDown_Contrast);
      this.groupBox18.Controls.Add(this.label48);
      this.groupBox18.Controls.Add(this.numUpDown_Angle);
      this.groupBox18.Controls.Add(this.label52);
      this.groupBox18.Controls.Add(this.label56);
      this.groupBox18.Controls.Add(this.numUpDown_Score);
      this.groupBox18.Controls.Add(this.numUpDown_Scale);
      this.groupBox18.Controls.Add(this.label54);
      this.groupBox18.Location = new System.Drawing.Point(199, 128);
      this.groupBox18.Name = "groupBox18";
      this.groupBox18.Size = new System.Drawing.Size(157, 174);
      this.groupBox18.TabIndex = 30;
      this.groupBox18.TabStop = false;
      this.groupBox18.Text = "Search Parameters";
      // 
      // btn_ChangeSearchParams
      // 
      this.btn_ChangeSearchParams.BackColor = System.Drawing.Color.Lime;
      this.btn_ChangeSearchParams.Location = new System.Drawing.Point(9, 145);
      this.btn_ChangeSearchParams.Name = "btn_ChangeSearchParams";
      this.btn_ChangeSearchParams.Size = new System.Drawing.Size(140, 23);
      this.btn_ChangeSearchParams.TabIndex = 26;
      this.btn_ChangeSearchParams.Text = "Change Search Params";
      this.btn_ChangeSearchParams.UseVisualStyleBackColor = false;
      this.btn_ChangeSearchParams.Click += new System.EventHandler(this.btn_ChangeSearchParams_Click);
      // 
      // checkBox_ClutterEn
      // 
      this.checkBox_ClutterEn.AutoSize = true;
      this.checkBox_ClutterEn.Location = new System.Drawing.Point(9, 126);
      this.checkBox_ClutterEn.Name = "checkBox_ClutterEn";
      this.checkBox_ClutterEn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.checkBox_ClutterEn.Size = new System.Drawing.Size(117, 16);
      this.checkBox_ClutterEn.TabIndex = 25;
      this.checkBox_ClutterEn.Text = "   Clutter in Score";
      this.checkBox_ClutterEn.UseVisualStyleBackColor = true;
      // 
      // numUpDown_Contrast
      // 
      this.numUpDown_Contrast.DecimalPlaces = 1;
      this.numUpDown_Contrast.Location = new System.Drawing.Point(94, 24);
      this.numUpDown_Contrast.Name = "numUpDown_Contrast";
      this.numUpDown_Contrast.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Contrast.TabIndex = 18;
      // 
      // label48
      // 
      this.label48.AutoSize = true;
      this.label48.Location = new System.Drawing.Point(9, 26);
      this.label48.Name = "label48";
      this.label48.Size = new System.Drawing.Size(66, 12);
      this.label48.TabIndex = 17;
      this.label48.Text = "Contrast Th";
      // 
      // numUpDown_Angle
      // 
      this.numUpDown_Angle.DecimalPlaces = 1;
      this.numUpDown_Angle.Location = new System.Drawing.Point(94, 49);
      this.numUpDown_Angle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
      this.numUpDown_Angle.Name = "numUpDown_Angle";
      this.numUpDown_Angle.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Angle.TabIndex = 20;
      // 
      // label52
      // 
      this.label52.AutoSize = true;
      this.label52.Location = new System.Drawing.Point(9, 51);
      this.label52.Name = "label52";
      this.label52.Size = new System.Drawing.Size(70, 12);
      this.label52.TabIndex = 19;
      this.label52.Text = "Angle Range";
      // 
      // label56
      // 
      this.label56.AutoSize = true;
      this.label56.Location = new System.Drawing.Point(9, 103);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(78, 12);
      this.label56.TabIndex = 23;
      this.label56.Text = "Nominal Scale";
      // 
      // numUpDown_Score
      // 
      this.numUpDown_Score.DecimalPlaces = 1;
      this.numUpDown_Score.Location = new System.Drawing.Point(94, 76);
      this.numUpDown_Score.Name = "numUpDown_Score";
      this.numUpDown_Score.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Score.TabIndex = 22;
      // 
      // numUpDown_Scale
      // 
      this.numUpDown_Scale.DecimalPlaces = 1;
      this.numUpDown_Scale.Location = new System.Drawing.Point(94, 101);
      this.numUpDown_Scale.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
      this.numUpDown_Scale.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.numUpDown_Scale.Name = "numUpDown_Scale";
      this.numUpDown_Scale.Size = new System.Drawing.Size(57, 19);
      this.numUpDown_Scale.TabIndex = 24;
      this.numUpDown_Scale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
      // 
      // label54
      // 
      this.label54.AutoSize = true;
      this.label54.Location = new System.Drawing.Point(9, 78);
      this.label54.Name = "label54";
      this.label54.Size = new System.Drawing.Size(51, 12);
      this.label54.TabIndex = 21;
      this.label54.Text = "Score Th";
      // 
      // label57
      // 
      this.label57.AutoSize = true;
      this.label57.Location = new System.Drawing.Point(201, 13);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(56, 12);
      this.label57.TabIndex = 29;
      this.label57.Text = "Graphics :";
      // 
      // comboBox_Graphics
      // 
      this.comboBox_Graphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox_Graphics.FormattingEnabled = true;
      this.comboBox_Graphics.Items.AddRange(new object[] {
            "Disabled",
            "Cross",
            "Cross and SearchRegion",
            "All"});
      this.comboBox_Graphics.Location = new System.Drawing.Point(199, 28);
      this.comboBox_Graphics.Name = "comboBox_Graphics";
      this.comboBox_Graphics.Size = new System.Drawing.Size(136, 20);
      this.comboBox_Graphics.TabIndex = 28;
      this.comboBox_Graphics.SelectedIndexChanged += new System.EventHandler(this.comboBox_Graphics_SelectedIndexChanged);
      // 
      // checkBox_SearchInfoEn
      // 
      this.checkBox_SearchInfoEn.AutoSize = true;
      this.checkBox_SearchInfoEn.Checked = true;
      this.checkBox_SearchInfoEn.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox_SearchInfoEn.Location = new System.Drawing.Point(201, 53);
      this.checkBox_SearchInfoEn.Name = "checkBox_SearchInfoEn";
      this.checkBox_SearchInfoEn.Size = new System.Drawing.Size(119, 16);
      this.checkBox_SearchInfoEn.TabIndex = 27;
      this.checkBox_SearchInfoEn.Text = "Search Result Info";
      this.checkBox_SearchInfoEn.UseVisualStyleBackColor = true;
      this.checkBox_SearchInfoEn.CheckedChanged += new System.EventHandler(this.checkBox_SearchInfoEn_CheckedChanged);
      // 
      // groupBox16
      // 
      this.groupBox16.Controls.Add(this.label51);
      this.groupBox16.Controls.Add(this.lbl_ResultScore);
      this.groupBox16.Controls.Add(this.label49);
      this.groupBox16.Controls.Add(this.lbl_ResultAngle);
      this.groupBox16.Controls.Add(this.label47);
      this.groupBox16.Controls.Add(this.lbl_ResultY);
      this.groupBox16.Controls.Add(this.label45);
      this.groupBox16.Controls.Add(this.lbl_ResultX);
      this.groupBox16.Controls.Add(this.btn_GetResult);
      this.groupBox16.Location = new System.Drawing.Point(199, 316);
      this.groupBox16.Name = "groupBox16";
      this.groupBox16.Size = new System.Drawing.Size(173, 89);
      this.groupBox16.TabIndex = 16;
      this.groupBox16.TabStop = false;
      this.groupBox16.Text = "Get Latest Result (Pixels)";
      // 
      // label51
      // 
      this.label51.Location = new System.Drawing.Point(15, 43);
      this.label51.Name = "label51";
      this.label51.Size = new System.Drawing.Size(45, 18);
      this.label51.TabIndex = 23;
      this.label51.Text = "Score :";
      this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_ResultScore
      // 
      this.lbl_ResultScore.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_ResultScore.Location = new System.Drawing.Point(17, 60);
      this.lbl_ResultScore.Name = "lbl_ResultScore";
      this.lbl_ResultScore.Size = new System.Drawing.Size(45, 19);
      this.lbl_ResultScore.TabIndex = 22;
      this.lbl_ResultScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label49
      // 
      this.label49.Location = new System.Drawing.Point(74, 62);
      this.label49.Name = "label49";
      this.label49.Size = new System.Drawing.Size(42, 18);
      this.label49.TabIndex = 21;
      this.label49.Text = "Angle :";
      this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_ResultAngle
      // 
      this.lbl_ResultAngle.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_ResultAngle.Location = new System.Drawing.Point(119, 62);
      this.lbl_ResultAngle.Name = "lbl_ResultAngle";
      this.lbl_ResultAngle.Size = new System.Drawing.Size(45, 19);
      this.lbl_ResultAngle.TabIndex = 20;
      this.lbl_ResultAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label47
      // 
      this.label47.Location = new System.Drawing.Point(95, 41);
      this.label47.Name = "label47";
      this.label47.Size = new System.Drawing.Size(23, 18);
      this.label47.TabIndex = 19;
      this.label47.Text = "Y :";
      this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_ResultY
      // 
      this.lbl_ResultY.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_ResultY.Location = new System.Drawing.Point(119, 41);
      this.lbl_ResultY.Name = "lbl_ResultY";
      this.lbl_ResultY.Size = new System.Drawing.Size(45, 19);
      this.lbl_ResultY.TabIndex = 18;
      this.lbl_ResultY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label45
      // 
      this.label45.Location = new System.Drawing.Point(95, 20);
      this.label45.Name = "label45";
      this.label45.Size = new System.Drawing.Size(23, 18);
      this.label45.TabIndex = 17;
      this.label45.Text = "X :";
      this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_ResultX
      // 
      this.lbl_ResultX.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_ResultX.Location = new System.Drawing.Point(119, 20);
      this.lbl_ResultX.Name = "lbl_ResultX";
      this.lbl_ResultX.Size = new System.Drawing.Size(45, 19);
      this.lbl_ResultX.TabIndex = 16;
      this.lbl_ResultX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_GetResult
      // 
      this.btn_GetResult.BackColor = System.Drawing.Color.Lime;
      this.btn_GetResult.Location = new System.Drawing.Point(6, 18);
      this.btn_GetResult.Name = "btn_GetResult";
      this.btn_GetResult.Size = new System.Drawing.Size(75, 23);
      this.btn_GetResult.TabIndex = 15;
      this.btn_GetResult.Text = "Get Result";
      this.btn_GetResult.UseVisualStyleBackColor = false;
      this.btn_GetResult.Click += new System.EventHandler(this.btn_GetResult_Click);
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.Location = new System.Drawing.Point(284, 79);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.Size = new System.Drawing.Size(75, 37);
      this.btn_Cancel.TabIndex = 14;
      this.btn_Cancel.Text = "Cancel Edit on Display";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      // 
      // btn_Accept
      // 
      this.btn_Accept.Location = new System.Drawing.Point(199, 79);
      this.btn_Accept.Name = "btn_Accept";
      this.btn_Accept.Size = new System.Drawing.Size(75, 37);
      this.btn_Accept.TabIndex = 13;
      this.btn_Accept.Text = "Accept Edit on Display";
      this.btn_Accept.UseVisualStyleBackColor = true;
      // 
      // btn_PatternOrigin
      // 
      this.btn_PatternOrigin.BackColor = System.Drawing.Color.Lime;
      this.btn_PatternOrigin.Location = new System.Drawing.Point(14, 198);
      this.btn_PatternOrigin.Name = "btn_PatternOrigin";
      this.btn_PatternOrigin.Size = new System.Drawing.Size(94, 37);
      this.btn_PatternOrigin.TabIndex = 12;
      this.btn_PatternOrigin.Text = "Set Pattern Origin1";
      this.btn_PatternOrigin.UseVisualStyleBackColor = false;
      this.btn_PatternOrigin.Click += new System.EventHandler(this.btn_PatternOrigin_Click);
      // 
      // btn_MaxSearchRegion
      // 
      this.btn_MaxSearchRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_MaxSearchRegion.Location = new System.Drawing.Point(14, 159);
      this.btn_MaxSearchRegion.Name = "btn_MaxSearchRegion";
      this.btn_MaxSearchRegion.Size = new System.Drawing.Size(94, 35);
      this.btn_MaxSearchRegion.TabIndex = 11;
      this.btn_MaxSearchRegion.Text = "Maximize Search Region1";
      this.btn_MaxSearchRegion.UseVisualStyleBackColor = false;
      this.btn_MaxSearchRegion.Click += new System.EventHandler(this.btn_MaxSearchRegion_Click);
      // 
      // btn_TrainRegion
      // 
      this.btn_TrainRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_TrainRegion.Location = new System.Drawing.Point(14, 76);
      this.btn_TrainRegion.Name = "btn_TrainRegion";
      this.btn_TrainRegion.Size = new System.Drawing.Size(94, 37);
      this.btn_TrainRegion.TabIndex = 10;
      this.btn_TrainRegion.Text = "Set Train Region1";
      this.btn_TrainRegion.UseVisualStyleBackColor = false;
      this.btn_TrainRegion.Click += new System.EventHandler(this.btn_TrainRegion_Click);
      // 
      // btn_SearchRegion
      // 
      this.btn_SearchRegion.BackColor = System.Drawing.Color.Lime;
      this.btn_SearchRegion.Location = new System.Drawing.Point(14, 118);
      this.btn_SearchRegion.Name = "btn_SearchRegion";
      this.btn_SearchRegion.Size = new System.Drawing.Size(94, 37);
      this.btn_SearchRegion.TabIndex = 9;
      this.btn_SearchRegion.Text = "Set Search Region1";
      this.btn_SearchRegion.UseVisualStyleBackColor = false;
      this.btn_SearchRegion.Click += new System.EventHandler(this.btn_SearchRegion_Click);
      // 
      // tabSNTP
      // 
      this.tabSNTP.Controls.Add(this.lblSNTPVersion);
      this.tabSNTP.Controls.Add(this.btnSNTPSetting);
      this.tabSNTP.Controls.Add(this.txtUsedSNTPServerIP);
      this.tabSNTP.Controls.Add(this.label70);
      this.tabSNTP.Controls.Add(this.numSNTPInterval);
      this.tabSNTP.Controls.Add(this.label69);
      this.tabSNTP.Controls.Add(this.label68);
      this.tabSNTP.Controls.Add(this.txtSNTPServerIP);
      this.tabSNTP.Controls.Add(this.chkSummerTime);
      this.tabSNTP.Controls.Add(this.label65);
      this.tabSNTP.Controls.Add(this.cbTimeZone);
      this.tabSNTP.Controls.Add(this.chkSNTP);
      this.tabSNTP.Location = new System.Drawing.Point(4, 22);
      this.tabSNTP.Name = "tabSNTP";
      this.tabSNTP.Padding = new System.Windows.Forms.Padding(3);
      this.tabSNTP.Size = new System.Drawing.Size(517, 414);
      this.tabSNTP.TabIndex = 6;
      this.tabSNTP.Text = "SNTP";
      this.tabSNTP.UseVisualStyleBackColor = true;
      // 
      // lblSNTPVersion
      // 
      this.lblSNTPVersion.AutoSize = true;
      this.lblSNTPVersion.Location = new System.Drawing.Point(300, 238);
      this.lblSNTPVersion.Name = "lblSNTPVersion";
      this.lblSNTPVersion.Size = new System.Drawing.Size(85, 12);
      this.lblSNTPVersion.TabIndex = 11;
      this.lblSNTPVersion.Text = "lblSNTPVersion";
      // 
      // btnSNTPSetting
      // 
      this.btnSNTPSetting.BackColor = System.Drawing.Color.Lime;
      this.btnSNTPSetting.Location = new System.Drawing.Point(8, 226);
      this.btnSNTPSetting.Name = "btnSNTPSetting";
      this.btnSNTPSetting.Size = new System.Drawing.Size(75, 23);
      this.btnSNTPSetting.TabIndex = 10;
      this.btnSNTPSetting.Text = "Update";
      this.btnSNTPSetting.UseVisualStyleBackColor = false;
      this.btnSNTPSetting.Click += new System.EventHandler(this.btnSNTPSetting_Click);
      // 
      // txtUsedSNTPServerIP
      // 
      this.txtUsedSNTPServerIP.Location = new System.Drawing.Point(95, 196);
      this.txtUsedSNTPServerIP.Name = "txtUsedSNTPServerIP";
      this.txtUsedSNTPServerIP.Size = new System.Drawing.Size(100, 19);
      this.txtUsedSNTPServerIP.TabIndex = 9;
      // 
      // label70
      // 
      this.label70.AutoSize = true;
      this.label70.Location = new System.Drawing.Point(12, 204);
      this.label70.Name = "label70";
      this.label70.Size = new System.Drawing.Size(73, 12);
      this.label70.TabIndex = 8;
      this.label70.Text = "Used server :";
      // 
      // numSNTPInterval
      // 
      this.numSNTPInterval.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this.numSNTPInterval.Location = new System.Drawing.Point(96, 157);
      this.numSNTPInterval.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
      this.numSNTPInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this.numSNTPInterval.Name = "numSNTPInterval";
      this.numSNTPInterval.Size = new System.Drawing.Size(120, 19);
      this.numSNTPInterval.TabIndex = 7;
      this.numSNTPInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
      // 
      // label69
      // 
      this.label69.AutoSize = true;
      this.label69.Location = new System.Drawing.Point(10, 157);
      this.label69.Name = "label69";
      this.label69.Size = new System.Drawing.Size(79, 12);
      this.label69.TabIndex = 6;
      this.label69.Text = "Interval(min) : ";
      // 
      // label68
      // 
      this.label68.AutoSize = true;
      this.label68.Location = new System.Drawing.Point(10, 116);
      this.label68.Name = "label68";
      this.label68.Size = new System.Drawing.Size(65, 12);
      this.label68.TabIndex = 5;
      this.label68.Text = "IP address :";
      // 
      // txtSNTPServerIP
      // 
      this.txtSNTPServerIP.Location = new System.Drawing.Point(95, 110);
      this.txtSNTPServerIP.Name = "txtSNTPServerIP";
      this.txtSNTPServerIP.Size = new System.Drawing.Size(100, 19);
      this.txtSNTPServerIP.TabIndex = 4;
      this.txtSNTPServerIP.Text = "192.168.0.100";
      // 
      // chkSummerTime
      // 
      this.chkSummerTime.AutoSize = true;
      this.chkSummerTime.Location = new System.Drawing.Point(10, 76);
      this.chkSummerTime.Name = "chkSummerTime";
      this.chkSummerTime.Size = new System.Drawing.Size(94, 16);
      this.chkSummerTime.TabIndex = 3;
      this.chkSummerTime.Text = "Summer Time";
      this.chkSummerTime.UseVisualStyleBackColor = true;
      // 
      // label65
      // 
      this.label65.AutoSize = true;
      this.label65.Location = new System.Drawing.Point(8, 42);
      this.label65.Name = "label65";
      this.label65.Size = new System.Drawing.Size(65, 12);
      this.label65.TabIndex = 2;
      this.label65.Text = "TimeZone : ";
      // 
      // cbTimeZone
      // 
      this.cbTimeZone.FormattingEnabled = true;
      this.cbTimeZone.Items.AddRange(new object[] {
            "-12",
            "-11",
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10",
            "+11",
            "+12",
            "+13"});
      this.cbTimeZone.Location = new System.Drawing.Point(95, 39);
      this.cbTimeZone.Name = "cbTimeZone";
      this.cbTimeZone.Size = new System.Drawing.Size(121, 20);
      this.cbTimeZone.TabIndex = 1;
      // 
      // chkSNTP
      // 
      this.chkSNTP.AutoSize = true;
      this.chkSNTP.Location = new System.Drawing.Point(8, 7);
      this.chkSNTP.Name = "chkSNTP";
      this.chkSNTP.Size = new System.Drawing.Size(90, 16);
      this.chkSNTP.TabIndex = 0;
      this.chkSNTP.Text = "SNTP enable";
      this.chkSNTP.UseVisualStyleBackColor = true;
      // 
      // tabFTP
      // 
      this.tabFTP.Controls.Add(this.btnFTP);
      this.tabFTP.Controls.Add(this.groupBox22);
      this.tabFTP.Controls.Add(this.groupBox21);
      this.tabFTP.Controls.Add(this.chkFTPImage);
      this.tabFTP.Controls.Add(this.chkFTPLog);
      this.tabFTP.Controls.Add(this.chkFTPPassive);
      this.tabFTP.Controls.Add(this.txtFTPDefaultGateway);
      this.tabFTP.Controls.Add(this.label75);
      this.tabFTP.Controls.Add(this.numFTPPort);
      this.tabFTP.Controls.Add(this.label74);
      this.tabFTP.Controls.Add(this.txtFTPPassword);
      this.tabFTP.Controls.Add(this.txtFTPUser);
      this.tabFTP.Controls.Add(this.txtFTPServer);
      this.tabFTP.Controls.Add(this.label73);
      this.tabFTP.Controls.Add(this.label72);
      this.tabFTP.Controls.Add(this.label71);
      this.tabFTP.Controls.Add(this.chkFTPRecipe);
      this.tabFTP.Location = new System.Drawing.Point(4, 22);
      this.tabFTP.Name = "tabFTP";
      this.tabFTP.Padding = new System.Windows.Forms.Padding(3);
      this.tabFTP.Size = new System.Drawing.Size(517, 414);
      this.tabFTP.TabIndex = 7;
      this.tabFTP.Text = "FTP";
      this.tabFTP.UseVisualStyleBackColor = true;
      // 
      // btnFTP
      // 
      this.btnFTP.BackColor = System.Drawing.Color.Lime;
      this.btnFTP.Location = new System.Drawing.Point(232, 360);
      this.btnFTP.Name = "btnFTP";
      this.btnFTP.Size = new System.Drawing.Size(75, 23);
      this.btnFTP.TabIndex = 16;
      this.btnFTP.Text = "Update";
      this.btnFTP.UseVisualStyleBackColor = false;
      this.btnFTP.Click += new System.EventHandler(this.btnFTP_Click);
      // 
      // groupBox22
      // 
      this.groupBox22.Controls.Add(this.label76);
      this.groupBox22.Controls.Add(this.cbFTPImgSize);
      this.groupBox22.Controls.Add(this.chkFTPImgGraphics);
      this.groupBox22.Controls.Add(this.chkFTPImgFail);
      this.groupBox22.Controls.Add(this.chkFTPImgAlign);
      this.groupBox22.Controls.Add(this.chkFTPImgTrain);
      this.groupBox22.Location = new System.Drawing.Point(8, 272);
      this.groupBox22.Name = "groupBox22";
      this.groupBox22.Size = new System.Drawing.Size(200, 124);
      this.groupBox22.TabIndex = 15;
      this.groupBox22.TabStop = false;
      this.groupBox22.Text = "Image to save";
      // 
      // label76
      // 
      this.label76.AutoSize = true;
      this.label76.Location = new System.Drawing.Point(7, 86);
      this.label76.Name = "label76";
      this.label76.Size = new System.Drawing.Size(65, 12);
      this.label76.TabIndex = 5;
      this.label76.Text = "Resolution :";
      // 
      // cbFTPImgSize
      // 
      this.cbFTPImgSize.FormattingEnabled = true;
      this.cbFTPImgSize.Items.AddRange(new object[] {
            "Full",
            "Half",
            "Quarter"});
      this.cbFTPImgSize.Location = new System.Drawing.Point(78, 80);
      this.cbFTPImgSize.Name = "cbFTPImgSize";
      this.cbFTPImgSize.Size = new System.Drawing.Size(114, 20);
      this.cbFTPImgSize.TabIndex = 4;
      // 
      // chkFTPImgGraphics
      // 
      this.chkFTPImgGraphics.AutoSize = true;
      this.chkFTPImgGraphics.Location = new System.Drawing.Point(7, 102);
      this.chkFTPImgGraphics.Name = "chkFTPImgGraphics";
      this.chkFTPImgGraphics.Size = new System.Drawing.Size(94, 16);
      this.chkFTPImgGraphics.TabIndex = 3;
      this.chkFTPImgGraphics.Text = "with Graphics";
      this.chkFTPImgGraphics.UseVisualStyleBackColor = true;
      // 
      // chkFTPImgFail
      // 
      this.chkFTPImgFail.AutoSize = true;
      this.chkFTPImgFail.Location = new System.Drawing.Point(7, 62);
      this.chkFTPImgFail.Name = "chkFTPImgFail";
      this.chkFTPImgFail.Size = new System.Drawing.Size(43, 16);
      this.chkFTPImgFail.TabIndex = 2;
      this.chkFTPImgFail.Text = "Fail";
      this.chkFTPImgFail.UseVisualStyleBackColor = true;
      // 
      // chkFTPImgAlign
      // 
      this.chkFTPImgAlign.AutoSize = true;
      this.chkFTPImgAlign.Location = new System.Drawing.Point(7, 39);
      this.chkFTPImgAlign.Name = "chkFTPImgAlign";
      this.chkFTPImgAlign.Size = new System.Drawing.Size(75, 16);
      this.chkFTPImgAlign.TabIndex = 1;
      this.chkFTPImgAlign.Text = "Alignment";
      this.chkFTPImgAlign.UseVisualStyleBackColor = true;
      // 
      // chkFTPImgTrain
      // 
      this.chkFTPImgTrain.AutoSize = true;
      this.chkFTPImgTrain.Location = new System.Drawing.Point(7, 19);
      this.chkFTPImgTrain.Name = "chkFTPImgTrain";
      this.chkFTPImgTrain.Size = new System.Drawing.Size(50, 16);
      this.chkFTPImgTrain.TabIndex = 0;
      this.chkFTPImgTrain.Text = "Train";
      this.chkFTPImgTrain.UseVisualStyleBackColor = true;
      // 
      // groupBox21
      // 
      this.groupBox21.Controls.Add(this.chkFTPImgNameDate);
      this.groupBox21.Controls.Add(this.chkFTPImgNameTime);
      this.groupBox21.Location = new System.Drawing.Point(10, 195);
      this.groupBox21.Name = "groupBox21";
      this.groupBox21.Size = new System.Drawing.Size(169, 68);
      this.groupBox21.TabIndex = 14;
      this.groupBox21.TabStop = false;
      this.groupBox21.Text = "File Name";
      // 
      // chkFTPImgNameDate
      // 
      this.chkFTPImgNameDate.AutoSize = true;
      this.chkFTPImgNameDate.Location = new System.Drawing.Point(7, 42);
      this.chkFTPImgNameDate.Name = "chkFTPImgNameDate";
      this.chkFTPImgNameDate.Size = new System.Drawing.Size(97, 16);
      this.chkFTPImgNameDate.TabIndex = 1;
      this.chkFTPImgNameDate.Text = "Including Date";
      this.chkFTPImgNameDate.UseVisualStyleBackColor = true;
      // 
      // chkFTPImgNameTime
      // 
      this.chkFTPImgNameTime.AutoSize = true;
      this.chkFTPImgNameTime.Location = new System.Drawing.Point(7, 19);
      this.chkFTPImgNameTime.Name = "chkFTPImgNameTime";
      this.chkFTPImgNameTime.Size = new System.Drawing.Size(98, 16);
      this.chkFTPImgNameTime.TabIndex = 0;
      this.chkFTPImgNameTime.Text = "Including Time";
      this.chkFTPImgNameTime.UseVisualStyleBackColor = true;
      // 
      // chkFTPImage
      // 
      this.chkFTPImage.AutoSize = true;
      this.chkFTPImage.Location = new System.Drawing.Point(10, 172);
      this.chkFTPImage.Name = "chkFTPImage";
      this.chkFTPImage.Size = new System.Drawing.Size(120, 16);
      this.chkFTPImage.TabIndex = 13;
      this.chkFTPImage.Text = "Image Save enable";
      this.chkFTPImage.UseVisualStyleBackColor = true;
      // 
      // chkFTPLog
      // 
      this.chkFTPLog.AutoSize = true;
      this.chkFTPLog.Location = new System.Drawing.Point(10, 139);
      this.chkFTPLog.Name = "chkFTPLog";
      this.chkFTPLog.Size = new System.Drawing.Size(108, 16);
      this.chkFTPLog.TabIndex = 12;
      this.chkFTPLog.Text = "Log Save enable";
      this.chkFTPLog.UseVisualStyleBackColor = true;
      // 
      // chkFTPPassive
      // 
      this.chkFTPPassive.AutoSize = true;
      this.chkFTPPassive.Location = new System.Drawing.Point(229, 66);
      this.chkFTPPassive.Name = "chkFTPPassive";
      this.chkFTPPassive.Size = new System.Drawing.Size(108, 16);
      this.chkFTPPassive.TabIndex = 11;
      this.chkFTPPassive.Text = "Passive transfer";
      this.chkFTPPassive.UseVisualStyleBackColor = true;
      // 
      // txtFTPDefaultGateway
      // 
      this.txtFTPDefaultGateway.Location = new System.Drawing.Point(304, 32);
      this.txtFTPDefaultGateway.Name = "txtFTPDefaultGateway";
      this.txtFTPDefaultGateway.Size = new System.Drawing.Size(100, 19);
      this.txtFTPDefaultGateway.TabIndex = 10;
      // 
      // label75
      // 
      this.label75.AutoSize = true;
      this.label75.Location = new System.Drawing.Point(229, 35);
      this.label75.Name = "label75";
      this.label75.Size = new System.Drawing.Size(69, 12);
      this.label75.TabIndex = 9;
      this.label75.Text = "Default GW :";
      // 
      // numFTPPort
      // 
      this.numFTPPort.Location = new System.Drawing.Point(304, 7);
      this.numFTPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numFTPPort.Name = "numFTPPort";
      this.numFTPPort.Size = new System.Drawing.Size(57, 19);
      this.numFTPPort.TabIndex = 8;
      this.numFTPPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
      // 
      // label74
      // 
      this.label74.AutoSize = true;
      this.label74.Location = new System.Drawing.Point(227, 7);
      this.label74.Name = "label74";
      this.label74.Size = new System.Drawing.Size(36, 12);
      this.label74.TabIndex = 7;
      this.label74.Text = "Port : ";
      // 
      // txtFTPPassword
      // 
      this.txtFTPPassword.Location = new System.Drawing.Point(79, 64);
      this.txtFTPPassword.Name = "txtFTPPassword";
      this.txtFTPPassword.PasswordChar = '*';
      this.txtFTPPassword.Size = new System.Drawing.Size(100, 19);
      this.txtFTPPassword.TabIndex = 6;
      this.txtFTPPassword.Text = "Hogehoge123";
      // 
      // txtFTPUser
      // 
      this.txtFTPUser.Location = new System.Drawing.Point(81, 35);
      this.txtFTPUser.Name = "txtFTPUser";
      this.txtFTPUser.Size = new System.Drawing.Size(100, 19);
      this.txtFTPUser.TabIndex = 5;
      this.txtFTPUser.Text = "ftpuser";
      // 
      // txtFTPServer
      // 
      this.txtFTPServer.Location = new System.Drawing.Point(81, 7);
      this.txtFTPServer.Name = "txtFTPServer";
      this.txtFTPServer.Size = new System.Drawing.Size(100, 19);
      this.txtFTPServer.TabIndex = 4;
      this.txtFTPServer.Text = "192.168.0.100";
      // 
      // label73
      // 
      this.label73.AutoSize = true;
      this.label73.Location = new System.Drawing.Point(8, 64);
      this.label73.Name = "label73";
      this.label73.Size = new System.Drawing.Size(60, 12);
      this.label73.TabIndex = 3;
      this.label73.Text = "Password :";
      // 
      // label72
      // 
      this.label72.AutoSize = true;
      this.label72.Location = new System.Drawing.Point(8, 35);
      this.label72.Name = "label72";
      this.label72.Size = new System.Drawing.Size(35, 12);
      this.label72.TabIndex = 2;
      this.label72.Text = "User :";
      // 
      // label71
      // 
      this.label71.AutoSize = true;
      this.label71.Location = new System.Drawing.Point(8, 7);
      this.label71.Name = "label71";
      this.label71.Size = new System.Drawing.Size(44, 12);
      this.label71.TabIndex = 1;
      this.label71.Text = "Server :";
      // 
      // chkFTPRecipe
      // 
      this.chkFTPRecipe.AutoSize = true;
      this.chkFTPRecipe.Location = new System.Drawing.Point(10, 106);
      this.chkFTPRecipe.Name = "chkFTPRecipe";
      this.chkFTPRecipe.Size = new System.Drawing.Size(125, 16);
      this.chkFTPRecipe.TabIndex = 0;
      this.chkFTPRecipe.Text = "Recipe Save enable";
      this.chkFTPRecipe.UseVisualStyleBackColor = true;
      // 
      // tabHeResults
      // 
      this.tabHeResults.Controls.Add(this.label81);
      this.tabHeResults.Controls.Add(this.btnGetHeResults);
      this.tabHeResults.Controls.Add(this.CameraIndex);
      this.tabHeResults.Location = new System.Drawing.Point(4, 22);
      this.tabHeResults.Margin = new System.Windows.Forms.Padding(2);
      this.tabHeResults.Name = "tabHeResults";
      this.tabHeResults.Padding = new System.Windows.Forms.Padding(2);
      this.tabHeResults.Size = new System.Drawing.Size(517, 414);
      this.tabHeResults.TabIndex = 12;
      this.tabHeResults.Text = "HeResults";
      this.tabHeResults.UseVisualStyleBackColor = true;
      // 
      // label81
      // 
      this.label81.AutoSize = true;
      this.label81.Location = new System.Drawing.Point(5, 92);
      this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label81.Name = "label81";
      this.label81.Size = new System.Drawing.Size(71, 12);
      this.label81.TabIndex = 2;
      this.label81.Text = "CameraIndex";
      // 
      // btnGetHeResults
      // 
      this.btnGetHeResults.Location = new System.Drawing.Point(167, 82);
      this.btnGetHeResults.Margin = new System.Windows.Forms.Padding(2);
      this.btnGetHeResults.Name = "btnGetHeResults";
      this.btnGetHeResults.Size = new System.Drawing.Size(89, 29);
      this.btnGetHeResults.TabIndex = 1;
      this.btnGetHeResults.Text = "GetHeResults";
      this.btnGetHeResults.UseVisualStyleBackColor = true;
      this.btnGetHeResults.Click += new System.EventHandler(this.btnGetHeResults_Click);
      // 
      // CameraIndex
      // 
      this.CameraIndex.Location = new System.Drawing.Point(77, 89);
      this.CameraIndex.Margin = new System.Windows.Forms.Padding(2);
      this.CameraIndex.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.CameraIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.CameraIndex.Name = "CameraIndex";
      this.CameraIndex.Size = new System.Drawing.Size(70, 19);
      this.CameraIndex.TabIndex = 0;
      this.CameraIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // groupBox8
      // 
      this.groupBox8.BackColor = System.Drawing.Color.Transparent;
      this.groupBox8.Controls.Add(this.icon_Connected);
      this.groupBox8.Controls.Add(this.label43);
      this.groupBox8.Controls.Add(this.label19);
      this.groupBox8.Controls.Add(this.lbl_CurrSystemDescription);
      this.groupBox8.Controls.Add(this.label22);
      this.groupBox8.Controls.Add(this.label23);
      this.groupBox8.Controls.Add(this.lbl_CurrSystemName);
      this.groupBox8.Location = new System.Drawing.Point(897, 18);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(227, 84);
      this.groupBox8.TabIndex = 10;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Current System";
      // 
      // icon_Connected
      // 
      this.icon_Connected.BackColor = System.Drawing.Color.WhiteSmoke;
      this.icon_Connected.Location = new System.Drawing.Point(189, 55);
      this.icon_Connected.Name = "icon_Connected";
      this.icon_Connected.Size = new System.Drawing.Size(22, 23);
      this.icon_Connected.TabIndex = 13;
      this.icon_Connected.UseVisualStyleBackColor = false;
      // 
      // label43
      // 
      this.label43.Location = new System.Drawing.Point(167, 37);
      this.label43.Name = "label43";
      this.label43.Size = new System.Drawing.Size(60, 18);
      this.label43.TabIndex = 12;
      this.label43.Text = "Connected";
      this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label19
      // 
      this.label19.Location = new System.Drawing.Point(12, 16);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(45, 16);
      this.label19.TabIndex = 11;
      this.label19.Text = "Name :";
      this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_CurrSystemDescription
      // 
      this.lbl_CurrSystemDescription.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrSystemDescription.Location = new System.Drawing.Point(11, 54);
      this.lbl_CurrSystemDescription.Name = "lbl_CurrSystemDescription";
      this.lbl_CurrSystemDescription.Size = new System.Drawing.Size(162, 22);
      this.lbl_CurrSystemDescription.TabIndex = 9;
      this.lbl_CurrSystemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label22
      // 
      this.label22.Location = new System.Drawing.Point(11, 37);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(73, 16);
      this.label22.TabIndex = 8;
      this.label22.Text = "Description :";
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(52, 20);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(0, 12);
      this.label23.TabIndex = 7;
      // 
      // lbl_CurrSystemName
      // 
      this.lbl_CurrSystemName.BackColor = System.Drawing.Color.WhiteSmoke;
      this.lbl_CurrSystemName.Location = new System.Drawing.Point(55, 15);
      this.lbl_CurrSystemName.Name = "lbl_CurrSystemName";
      this.lbl_CurrSystemName.Size = new System.Drawing.Size(117, 19);
      this.lbl_CurrSystemName.TabIndex = 6;
      this.lbl_CurrSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelVersion});
      this.statusStrip1.Location = new System.Drawing.Point(0, 555);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1148, 22);
      this.statusStrip1.TabIndex = 6;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabelStatus
      // 
      this.toolStripStatusLabelStatus.AutoSize = false;
      this.toolStripStatusLabelStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.toolStripStatusLabelStatus.ForeColor = System.Drawing.Color.Red;
      this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
      this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(450, 17);
      this.toolStripStatusLabelStatus.Text = "toolStripStatusLabelStatus";
      this.toolStripStatusLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // toolStripStatusLabelVersion
      // 
      this.toolStripStatusLabelVersion.AutoSize = false;
      this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
      this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(150, 17);
      this.toolStripStatusLabelVersion.Text = "Version :";
      this.toolStripStatusLabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btn_Cam2AcqImage
      // 
      this.btn_Cam2AcqImage.BackColor = System.Drawing.Color.Lime;
      this.btn_Cam2AcqImage.Location = new System.Drawing.Point(12, 46);
      this.btn_Cam2AcqImage.Name = "btn_Cam2AcqImage";
      this.btn_Cam2AcqImage.Size = new System.Drawing.Size(131, 21);
      this.btn_Cam2AcqImage.TabIndex = 7;
      this.btn_Cam2AcqImage.Text = "Cam2 Acquire Image";
      this.btn_Cam2AcqImage.UseVisualStyleBackColor = false;
      this.btn_Cam2AcqImage.Click += new System.EventHandler(this.btn_Cam2AcqImage_Click);
      // 
      // btn_Disconnect
      // 
      this.btn_Disconnect.BackColor = System.Drawing.Color.Lime;
      this.btn_Disconnect.Location = new System.Drawing.Point(83, 43);
      this.btn_Disconnect.Name = "btn_Disconnect";
      this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
      this.btn_Disconnect.TabIndex = 10;
      this.btn_Disconnect.Text = "Disconnect";
      this.btn_Disconnect.UseVisualStyleBackColor = false;
      this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
      // 
      // label44
      // 
      this.label44.Location = new System.Drawing.Point(621, 4);
      this.label44.Name = "label44";
      this.label44.Size = new System.Drawing.Size(206, 27);
      this.label44.TabIndex = 11;
      this.label44.Text = "When using the Manual Connection, do not use Sys Mgmt Tab below";
      // 
      // groupBox10
      // 
      this.groupBox10.BackColor = System.Drawing.Color.PowderBlue;
      this.groupBox10.Controls.Add(this.lblLoadCompletedCount);
      this.groupBox10.Controls.Add(this.lblRsltChangedCount);
      this.groupBox10.Controls.Add(this.label97);
      this.groupBox10.Controls.Add(this.label96);
      this.groupBox10.Controls.Add(this.chkAttachEvent);
      this.groupBox10.Controls.Add(this.btn_Disconnect);
      this.groupBox10.Controls.Add(this.btn_Connect);
      this.groupBox10.Controls.Add(this.txtBox_IPAddress);
      this.groupBox10.Controls.Add(this.label1);
      this.groupBox10.Location = new System.Drawing.Point(615, 33);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new System.Drawing.Size(276, 70);
      this.groupBox10.TabIndex = 12;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "Manual Connection";
      // 
      // groupBox20
      // 
      this.groupBox20.Controls.Add(this.btn_DisconnectCommand);
      this.groupBox20.Controls.Add(this.btn_SendCommand);
      this.groupBox20.Controls.Add(this.label66);
      this.groupBox20.Controls.Add(this.txtBox_ReceivedResponse);
      this.groupBox20.Controls.Add(this.label67);
      this.groupBox20.Controls.Add(this.txtBox_SentCommand);
      this.groupBox20.Controls.Add(this.txtBox_PortNumber_Command);
      this.groupBox20.Controls.Add(this.txtBox_IPAddress_Command);
      this.groupBox20.Controls.Add(this.label63);
      this.groupBox20.Controls.Add(this.btn_ConnectCommand);
      this.groupBox20.Controls.Add(this.label61);
      this.groupBox20.Location = new System.Drawing.Point(12, 395);
      this.groupBox20.Name = "groupBox20";
      this.groupBox20.Size = new System.Drawing.Size(327, 120);
      this.groupBox20.TabIndex = 13;
      this.groupBox20.TabStop = false;
      this.groupBox20.Text = "TCP Connection to send command";
      // 
      // btn_DisconnectCommand
      // 
      this.btn_DisconnectCommand.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn_DisconnectCommand.Location = new System.Drawing.Point(243, 20);
      this.btn_DisconnectCommand.Name = "btn_DisconnectCommand";
      this.btn_DisconnectCommand.Size = new System.Drawing.Size(78, 23);
      this.btn_DisconnectCommand.TabIndex = 24;
      this.btn_DisconnectCommand.Text = "Disonnect";
      this.btn_DisconnectCommand.UseVisualStyleBackColor = false;
      this.btn_DisconnectCommand.Click += new System.EventHandler(this.btn_DisconnectCommand_Click);
      // 
      // btn_SendCommand
      // 
      this.btn_SendCommand.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn_SendCommand.Location = new System.Drawing.Point(266, 64);
      this.btn_SendCommand.Name = "btn_SendCommand";
      this.btn_SendCommand.Size = new System.Drawing.Size(55, 23);
      this.btn_SendCommand.TabIndex = 24;
      this.btn_SendCommand.Text = "Send";
      this.btn_SendCommand.UseVisualStyleBackColor = false;
      this.btn_SendCommand.Click += new System.EventHandler(this.btn_SendCommand_Click);
      // 
      // label66
      // 
      this.label66.AutoSize = true;
      this.label66.Location = new System.Drawing.Point(7, 73);
      this.label66.Name = "label66";
      this.label66.Size = new System.Drawing.Size(55, 12);
      this.label66.TabIndex = 23;
      this.label66.Text = "Command";
      // 
      // txtBox_ReceivedResponse
      // 
      this.txtBox_ReceivedResponse.Location = new System.Drawing.Point(74, 92);
      this.txtBox_ReceivedResponse.Name = "txtBox_ReceivedResponse";
      this.txtBox_ReceivedResponse.Size = new System.Drawing.Size(247, 19);
      this.txtBox_ReceivedResponse.TabIndex = 22;
      // 
      // label67
      // 
      this.label67.AutoSize = true;
      this.label67.Location = new System.Drawing.Point(7, 96);
      this.label67.Name = "label67";
      this.label67.Size = new System.Drawing.Size(55, 12);
      this.label67.TabIndex = 21;
      this.label67.Text = "Response";
      // 
      // txtBox_SentCommand
      // 
      this.txtBox_SentCommand.Location = new System.Drawing.Point(74, 68);
      this.txtBox_SentCommand.Name = "txtBox_SentCommand";
      this.txtBox_SentCommand.Size = new System.Drawing.Size(186, 19);
      this.txtBox_SentCommand.TabIndex = 19;
      this.txtBox_SentCommand.Text = "GS,1";
      // 
      // txtBox_PortNumber_Command
      // 
      this.txtBox_PortNumber_Command.Location = new System.Drawing.Point(74, 45);
      this.txtBox_PortNumber_Command.Name = "txtBox_PortNumber_Command";
      this.txtBox_PortNumber_Command.Size = new System.Drawing.Size(81, 19);
      this.txtBox_PortNumber_Command.TabIndex = 18;
      this.txtBox_PortNumber_Command.Text = "7890";
      // 
      // txtBox_IPAddress_Command
      // 
      this.txtBox_IPAddress_Command.Location = new System.Drawing.Point(74, 20);
      this.txtBox_IPAddress_Command.Name = "txtBox_IPAddress_Command";
      this.txtBox_IPAddress_Command.Size = new System.Drawing.Size(81, 19);
      this.txtBox_IPAddress_Command.TabIndex = 17;
      this.txtBox_IPAddress_Command.Text = "192.168.0.2";
      // 
      // label63
      // 
      this.label63.AutoSize = true;
      this.label63.Location = new System.Drawing.Point(6, 50);
      this.label63.Name = "label63";
      this.label63.Size = new System.Drawing.Size(67, 12);
      this.label63.TabIndex = 16;
      this.label63.Text = "Port number";
      // 
      // btn_ConnectCommand
      // 
      this.btn_ConnectCommand.BackColor = System.Drawing.Color.Lime;
      this.btn_ConnectCommand.Location = new System.Drawing.Point(161, 20);
      this.btn_ConnectCommand.Name = "btn_ConnectCommand";
      this.btn_ConnectCommand.Size = new System.Drawing.Size(78, 23);
      this.btn_ConnectCommand.TabIndex = 14;
      this.btn_ConnectCommand.Text = "Connect";
      this.btn_ConnectCommand.UseVisualStyleBackColor = false;
      this.btn_ConnectCommand.Click += new System.EventHandler(this.btn_Connect_Command_Click);
      // 
      // label61
      // 
      this.label61.AutoSize = true;
      this.label61.Location = new System.Drawing.Point(7, 23);
      this.label61.Name = "label61";
      this.label61.Size = new System.Drawing.Size(61, 12);
      this.label61.TabIndex = 15;
      this.label61.Text = "IP Address";
      // 
      // btn_Auxiliary1
      // 
      this.btn_Auxiliary1.BackColor = System.Drawing.Color.Lime;
      this.btn_Auxiliary1.Location = new System.Drawing.Point(13, 82);
      this.btn_Auxiliary1.Name = "btn_Auxiliary1";
      this.btn_Auxiliary1.Size = new System.Drawing.Size(131, 21);
      this.btn_Auxiliary1.TabIndex = 25;
      this.btn_Auxiliary1.Text = "Auxiliary Button1";
      this.btn_Auxiliary1.UseVisualStyleBackColor = false;
      this.btn_Auxiliary1.Click += new System.EventHandler(this.btn_Auxiliary1_Click);
      // 
      // groupBox26
      // 
      this.groupBox26.Controls.Add(this.btn_Auxiliary3);
      this.groupBox26.Controls.Add(this.btn_Auxiliary2);
      this.groupBox26.Controls.Add(this.btn_Auxiliary1);
      this.groupBox26.Controls.Add(this.btn_Cam1AcqImage);
      this.groupBox26.Controls.Add(this.btn_Cam2AcqImage);
      this.groupBox26.Location = new System.Drawing.Point(449, 388);
      this.groupBox26.Name = "groupBox26";
      this.groupBox26.Size = new System.Drawing.Size(154, 157);
      this.groupBox26.TabIndex = 26;
      this.groupBox26.TabStop = false;
      this.groupBox26.Text = "Misc.";
      // 
      // btn_Auxiliary3
      // 
      this.btn_Auxiliary3.BackColor = System.Drawing.Color.Lime;
      this.btn_Auxiliary3.Location = new System.Drawing.Point(13, 130);
      this.btn_Auxiliary3.Name = "btn_Auxiliary3";
      this.btn_Auxiliary3.Size = new System.Drawing.Size(131, 21);
      this.btn_Auxiliary3.TabIndex = 33;
      this.btn_Auxiliary3.Text = "Auxiliary Button3";
      this.btn_Auxiliary3.UseVisualStyleBackColor = false;
      this.btn_Auxiliary3.Click += new System.EventHandler(this.btn_Auxiliary3_Click);
      // 
      // btn_Auxiliary2
      // 
      this.btn_Auxiliary2.BackColor = System.Drawing.Color.Lime;
      this.btn_Auxiliary2.Location = new System.Drawing.Point(13, 106);
      this.btn_Auxiliary2.Name = "btn_Auxiliary2";
      this.btn_Auxiliary2.Size = new System.Drawing.Size(131, 21);
      this.btn_Auxiliary2.TabIndex = 26;
      this.btn_Auxiliary2.Text = "Auxiliary Button2";
      this.btn_Auxiliary2.UseVisualStyleBackColor = false;
      this.btn_Auxiliary2.Click += new System.EventHandler(this.btn_Auxiliary2_Click);
      // 
      // label55
      // 
      this.label55.AutoSize = true;
      this.label55.Location = new System.Drawing.Point(10, 543);
      this.label55.Name = "label55";
      this.label55.Size = new System.Drawing.Size(331, 12);
      this.label55.TabIndex = 27;
      this.label55.Text = "Note : For Acquiring images, Exposure Setting ID is hard coded.";
      // 
      // btnLogging
      // 
      this.btnLogging.BackColor = System.Drawing.Color.Lime;
      this.btnLogging.Location = new System.Drawing.Point(359, 492);
      this.btnLogging.Name = "btnLogging";
      this.btnLogging.Size = new System.Drawing.Size(75, 23);
      this.btnLogging.TabIndex = 31;
      this.btnLogging.Text = "Show Log";
      this.btnLogging.UseVisualStyleBackColor = false;
      this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
      // 
      // btnClearLog
      // 
      this.btnClearLog.BackColor = System.Drawing.Color.Lime;
      this.btnClearLog.Location = new System.Drawing.Point(359, 519);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(75, 23);
      this.btnClearLog.TabIndex = 32;
      this.btnClearLog.Text = "Clear Log";
      this.btnClearLog.UseVisualStyleBackColor = false;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // alignSystemDisplay
      // 
      this.alignSystemDisplay.Location = new System.Drawing.Point(2, 2);
      this.alignSystemDisplay.Margin = new System.Windows.Forms.Padding(4);
      this.alignSystemDisplay.Name = "alignSystemDisplay";
      this.alignSystemDisplay.Size = new System.Drawing.Size(601, 379);
      this.alignSystemDisplay.TabIndex = 0;
      this.alignSystemDisplay.ToolBarLiveVideoEnabled = true;
      this.alignSystemDisplay.ToolBarLoadImageEnabled = true;
      this.alignSystemDisplay.ToolBarSaveImageEnabled = true;
      this.alignSystemDisplay.ToolBarVisibility = true;
      this.alignSystemDisplay.UseAcceptCancelToolbarButtons = true;
      // 
      // btnManualAlign
      // 
      this.btnManualAlign.BackColor = System.Drawing.Color.Lime;
      this.btnManualAlign.Location = new System.Drawing.Point(86, 516);
      this.btnManualAlign.Name = "btnManualAlign";
      this.btnManualAlign.Size = new System.Drawing.Size(120, 23);
      this.btnManualAlign.TabIndex = 33;
      this.btnManualAlign.Text = "Manual Align";
      this.btnManualAlign.UseVisualStyleBackColor = false;
      this.btnManualAlign.Click += new System.EventHandler(this.btnManualAlign_Click);
      // 
      // chkAttachEvent
      // 
      this.chkAttachEvent.AutoSize = true;
      this.chkAttachEvent.Location = new System.Drawing.Point(164, 10);
      this.chkAttachEvent.Name = "chkAttachEvent";
      this.chkAttachEvent.Size = new System.Drawing.Size(116, 16);
      this.chkAttachEvent.TabIndex = 11;
      this.chkAttachEvent.Text = "Attach Event Hdlr";
      this.chkAttachEvent.UseVisualStyleBackColor = true;
      // 
      // label96
      // 
      this.label96.AutoSize = true;
      this.label96.Location = new System.Drawing.Point(166, 33);
      this.label96.Name = "label96";
      this.label96.Size = new System.Drawing.Size(72, 12);
      this.label96.TabIndex = 12;
      this.label96.Text = "RsltChanged:";
      // 
      // label97
      // 
      this.label97.AutoSize = true;
      this.label97.Location = new System.Drawing.Point(166, 51);
      this.label97.Name = "label97";
      this.label97.Size = new System.Drawing.Size(85, 12);
      this.label97.TabIndex = 13;
      this.label97.Text = "LoadCompleted:";
      // 
      // lblRsltChangedCount
      // 
      this.lblRsltChangedCount.AutoSize = true;
      this.lblRsltChangedCount.Location = new System.Drawing.Point(259, 33);
      this.lblRsltChangedCount.Name = "lblRsltChangedCount";
      this.lblRsltChangedCount.Size = new System.Drawing.Size(11, 12);
      this.lblRsltChangedCount.TabIndex = 14;
      this.lblRsltChangedCount.Text = "0";
      this.lblRsltChangedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // lblLoadCompletedCount
      // 
      this.lblLoadCompletedCount.AutoSize = true;
      this.lblLoadCompletedCount.Location = new System.Drawing.Point(259, 51);
      this.lblLoadCompletedCount.Name = "lblLoadCompletedCount";
      this.lblLoadCompletedCount.Size = new System.Drawing.Size(11, 12);
      this.lblLoadCompletedCount.TabIndex = 14;
      this.lblLoadCompletedCount.Text = "0";
      this.lblLoadCompletedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1148, 577);
      this.Controls.Add(this.btnManualAlign);
      this.Controls.Add(this.btnClearLog);
      this.Controls.Add(this.btnLogging);
      this.Controls.Add(this.label55);
      this.Controls.Add(this.groupBox26);
      this.Controls.Add(this.groupBox20);
      this.Controls.Add(this.groupBox10);
      this.Controls.Add(this.label44);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.groupBox8);
      this.Controls.Add(this.alignSystemDisplay);
      this.Name = "MainForm";
      this.Text = "Sample Application";
      this.tabControl1.ResumeLayout(false);
      this.tabSysMgmt.ResumeLayout(false);
      this.tabSysMgmt.PerformLayout();
      this.gBox_SelectedCamNetInfo.ResumeLayout(false);
      this.gBox_SelectedCamNetInfo.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.tabSysSetup.ResumeLayout(false);
      this.tabSysSetup.PerformLayout();
      this.groupBox15.ResumeLayout(false);
      this.groupBox15.PerformLayout();
      this.gBox_AutoCalib_Cam2.ResumeLayout(false);
      this.gBox_AutoCalib_Cam2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStepX2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepT2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepY2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmax2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmin2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmin2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmax2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmax2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmin2)).EndInit();
      this.gBox_AutoCalib_Cam1.ResumeLayout(false);
      this.gBox_AutoCalib_Cam1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numStepX1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepT1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStepY1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmax1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTmin1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmin1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmax1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numXmax1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numYmin1)).EndInit();
      this.groupBox13.ResumeLayout(false);
      this.groupBox13.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_PortNumber)).EndInit();
      this.groupBox12.ResumeLayout(false);
      this.groupBox12.PerformLayout();
      this.tabRecipeMgmt.ResumeLayout(false);
      this.tabRecipeMgmt.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numRecipeID)).EndInit();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.tabRecipeSettings.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numLCUpperLim)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numLCLowLim)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tabCtrlOnDisp.ResumeLayout(false);
      this.tabCtrlOnDisp.PerformLayout();
      this.gBox_CtrlOnDisp_Cam2.ResumeLayout(false);
      this.gBox_CtrlOnDisp_Cam1.ResumeLayout(false);
      this.gBox_imgFile.ResumeLayout(false);
      this.gBox_imgFile.PerformLayout();
      this.tabCheckerCalib.ResumeLayout(false);
      this.groupBox14.ResumeLayout(false);
      this.groupBox14.PerformLayout();
      this.groupBox17.ResumeLayout(false);
      this.groupBox17.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Checker)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Checker)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Checker_CamID)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CheckerXSpacing)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_CheckerYSpacing)).EndInit();
      this.tabExposure.ResumeLayout(false);
      this.gBox_ExposureSetting_Cam2.ResumeLayout(false);
      this.gBox_ExposureSetting_Cam2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ExposureID_Cam2)).EndInit();
      this.groupBox23.ResumeLayout(false);
      this.groupBox23.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Cam2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Cam2)).EndInit();
      this.gBox_ExposureSetting_Cam1.ResumeLayout(false);
      this.gBox_ExposureSetting_Cam1.PerformLayout();
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_ExposureID_Cam1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_LightCrl_Cam1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Exposure_Cam1)).EndInit();
      this.tabFeature.ResumeLayout(false);
      this.tabFeature.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Feature_CamID)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_FeatureID)).EndInit();
      this.groupBox19.ResumeLayout(false);
      this.groupBox18.ResumeLayout(false);
      this.groupBox18.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Contrast)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Angle)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Score)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Scale)).EndInit();
      this.groupBox16.ResumeLayout(false);
      this.tabSNTP.ResumeLayout(false);
      this.tabSNTP.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numSNTPInterval)).EndInit();
      this.tabFTP.ResumeLayout(false);
      this.tabFTP.PerformLayout();
      this.groupBox22.ResumeLayout(false);
      this.groupBox22.PerformLayout();
      this.groupBox21.ResumeLayout(false);
      this.groupBox21.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numFTPPort)).EndInit();
      this.tabHeResults.ResumeLayout(false);
      this.tabHeResults.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CameraIndex)).EndInit();
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      this.groupBox20.ResumeLayout(false);
      this.groupBox20.PerformLayout();
      this.groupBox26.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Cognex.AlignmentSDK.Controls.AlignSystemDisplay alignSystemDisplay;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Cam1AcqImage;
        private System.Windows.Forms.TextBox txtBox_IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSysMgmt;
        private System.Windows.Forms.TabPage tabRecipeMgmt;
        private System.Windows.Forms.TabPage tabCtrlOnDisp;
        private System.Windows.Forms.TabPage tabFeature;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.Button btn_Cam2AcqImage;
        private System.Windows.Forms.Button btn_SearchRegion;
        private System.Windows.Forms.Button btn_TrainRegion;
        private System.Windows.Forms.Button btn_MaxSearchRegion;
        private System.Windows.Forms.Button btn_PatternOrigin;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox checkBox_ToolBar;
        private System.Windows.Forms.GroupBox gBox_CtrlOnDisp_Cam1;
        private System.Windows.Forms.CheckBox checkBox_FovCross1;
        private System.Windows.Forms.CheckBox checkBox_AcceptCancelButton;
        private System.Windows.Forms.CheckBox checkBox_Graphics;
        private System.Windows.Forms.CheckBox checkBox_SaveImgBtnEnable;
        private System.Windows.Forms.CheckBox checkBox_LoadImgBtnEnable;
        private System.Windows.Forms.CheckBox checkBox_LiveVideoBtnEnable;
        private System.Windows.Forms.Button btn_ZoomFit1;
        private System.Windows.Forms.Button btn_StopLive1;
        private System.Windows.Forms.Button btn_StartLive1;
        private System.Windows.Forms.Button btn_RotCW1;
        private System.Windows.Forms.Button btn_SaveImg1;
        private System.Windows.Forms.Button btn_RotCCW1;
        private System.Windows.Forms.Button btn_LoadImg1;
        private System.Windows.Forms.Button btn_ZoomOut1;
        private System.Windows.Forms.Button btn_ZoomIn1;
        private System.Windows.Forms.GroupBox gBox_CtrlOnDisp_Cam2;
        private System.Windows.Forms.Button btn_StopLive2;
        private System.Windows.Forms.Button btn_SaveImg2;
        private System.Windows.Forms.Button btn_StartLive2;
        private System.Windows.Forms.Button btn_RotCCW2;
        private System.Windows.Forms.Button btn_RotCW2;
        private System.Windows.Forms.Button btn_LoadImg2;
        private System.Windows.Forms.Button btn_ZoomOut2;
        private System.Windows.Forms.Button btn_ZoomIn2;
        private System.Windows.Forms.Button btn_ZoomFit2;
        private System.Windows.Forms.CheckBox checkBox_FovCross2;
        private System.Windows.Forms.Button btn_BackupSys;
        private System.Windows.Forms.Button btn_RestoreSys;
        private System.Windows.Forms.Button btn_UpdateRecipeList;
        private System.Windows.Forms.ListBox list_Recipes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_NewRecipeName;
        private System.Windows.Forms.Button btn_NewRecipeCreate;
        private System.Windows.Forms.ComboBox comboBox_NewRecipeMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_RemoveRecipe;
        private System.Windows.Forms.TextBox txtBox_NewRecipeDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_CurrRecipeMode;
        private System.Windows.Forms.Label lbl_CurrRecipeDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_CurrRecipeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_LoadRecipe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBox_SaveCurrRecipeAsName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_SaveCurrRecipeAs;
        private System.Windows.Forms.TextBox txtBox_SaveCurrRecipeAsDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBox_NewSysDescription;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBox_NewSysName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_CurrSystemDescription;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbl_CurrSystemName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_Update_CamList_CurrSysInfo;
        private System.Windows.Forms.Button btn_CreateSys;
        private System.Windows.Forms.Button btn_SelectSystem;
        private System.Windows.Forms.ListView list_Cameras;
        private System.Windows.Forms.ColumnHeader list_Camera_Name;
        private System.Windows.Forms.ColumnHeader list_Camera_IPAddress;
        private System.Windows.Forms.TabPage tabSysSetup;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gBox_SelectedCamNetInfo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numUpDown_PortNumber;
        private System.Windows.Forms.Button btn_ChangeSysSettings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox_MovableOrigin;
        private System.Windows.Forms.CheckBox checkBox_RunUncalibrated;
        private System.Windows.Forms.CheckBox checkBox_ShuttledCamera;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox gBox_AutoCalib_Cam2;
        private System.Windows.Forms.CheckBox chkCantilever2;
        private System.Windows.Forms.NumericUpDown numStepX2;
        private System.Windows.Forms.NumericUpDown numStepT2;
        private System.Windows.Forms.NumericUpDown numStepY2;
        private System.Windows.Forms.NumericUpDown numTmax2;
        private System.Windows.Forms.CheckBox chkAutoStep2;
        private System.Windows.Forms.NumericUpDown numTmin2;
        private System.Windows.Forms.NumericUpDown numXmin2;
        private System.Windows.Forms.NumericUpDown numYmax2;
        private System.Windows.Forms.NumericUpDown numXmax2;
        private System.Windows.Forms.NumericUpDown numYmin2;
        private System.Windows.Forms.GroupBox gBox_AutoCalib_Cam1;
        private System.Windows.Forms.CheckBox chkCantilever1;
        private System.Windows.Forms.NumericUpDown numStepX1;
        private System.Windows.Forms.NumericUpDown numStepT1;
        private System.Windows.Forms.NumericUpDown numStepY1;
        private System.Windows.Forms.NumericUpDown numTmax1;
        private System.Windows.Forms.CheckBox chkAutoStep1;
        private System.Windows.Forms.NumericUpDown numTmin1;
        private System.Windows.Forms.NumericUpDown numXmin1;
        private System.Windows.Forms.NumericUpDown numYmax1;
        private System.Windows.Forms.NumericUpDown numXmax1;
        private System.Windows.Forms.NumericUpDown numYmin1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBox_IsDHCP;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btn_ChangeCamNetInfo;
        private System.Windows.Forms.TextBox txtBox_SelectedCamSubMask;
        private System.Windows.Forms.TextBox txtBox_SelectedCamIPAdd;
        private System.Windows.Forms.TextBox txtBox_SelectedCamName;
        private System.Windows.Forms.TextBox txtBox_SelectedCamGateway;
        private System.Windows.Forms.TextBox txtBox_SelectedCamDNS;
        private System.Windows.Forms.TextBox txtBox_SelectedCamDomainName;
        private System.Windows.Forms.Button btn_RemoveSystem;
        private System.Windows.Forms.ColumnHeader list_System_Name;
        private System.Windows.Forms.ColumnHeader list_IsMaster;
        private System.Windows.Forms.CheckBox checkBox_LowerIsMaster;
        private System.Windows.Forms.ComboBox comboBox_DispImgResolution1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox comboBox_DispImgResolution2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ColumnHeader list_IsConnected;
        private System.Windows.Forms.ColumnHeader list_IsCurrent;
        private System.Windows.Forms.Button btn_DisconnectSystem;
        private System.Windows.Forms.Button btn_ConnectSystem;
        private System.Windows.Forms.Button icon_Connected;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btn_GetResult;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label lbl_ResultScore;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label lbl_ResultAngle;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lbl_ResultY;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label lbl_ResultX;
        private System.Windows.Forms.CheckBox checkBox_SearchInfoEn;
        private System.Windows.Forms.CheckBox checkBox_ClutterEn;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown numUpDown_Scale;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown numUpDown_Score;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown numUpDown_Angle;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numUpDown_Contrast;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox comboBox_Graphics;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btn_ChangeSearchParams;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label lbl_TrainHeight;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label lbl_TrainWidth;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label lbl_TrainY;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label lbl_TrainX;
        private System.Windows.Forms.Button btn_GetTrainRegion;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox txtBox_PortNumber_Command;
        private System.Windows.Forms.TextBox txtBox_IPAddress_Command;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button btn_ConnectCommand;
        private System.Windows.Forms.TextBox txtBox_ReceivedResponse;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txtBox_SentCommand;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btn_DisconnectCommand;
        private System.Windows.Forms.Button btn_SendCommand;
        private System.Windows.Forms.Button btn_Auxiliary1;
    private System.Windows.Forms.TabPage tabSNTP;
    private System.Windows.Forms.Button btnSNTPSetting;
    private System.Windows.Forms.TextBox txtUsedSNTPServerIP;
    private System.Windows.Forms.Label label70;
    private System.Windows.Forms.NumericUpDown numSNTPInterval;
    private System.Windows.Forms.Label label69;
    private System.Windows.Forms.Label label68;
    private System.Windows.Forms.TextBox txtSNTPServerIP;
    private System.Windows.Forms.CheckBox chkSummerTime;
    private System.Windows.Forms.Label label65;
    private System.Windows.Forms.ComboBox cbTimeZone;
    private System.Windows.Forms.CheckBox chkSNTP;
    private System.Windows.Forms.TabPage tabFTP;
    private System.Windows.Forms.Label lblSNTPVersion;
    private System.Windows.Forms.Button btnFTP;
    private System.Windows.Forms.GroupBox groupBox22;
    private System.Windows.Forms.Label label76;
    private System.Windows.Forms.ComboBox cbFTPImgSize;
    private System.Windows.Forms.CheckBox chkFTPImgGraphics;
    private System.Windows.Forms.CheckBox chkFTPImgFail;
    private System.Windows.Forms.CheckBox chkFTPImgAlign;
    private System.Windows.Forms.CheckBox chkFTPImgTrain;
    private System.Windows.Forms.GroupBox groupBox21;
    private System.Windows.Forms.CheckBox chkFTPImgNameDate;
    private System.Windows.Forms.CheckBox chkFTPImgNameTime;
    private System.Windows.Forms.CheckBox chkFTPImage;
    private System.Windows.Forms.CheckBox chkFTPLog;
    private System.Windows.Forms.CheckBox chkFTPPassive;
    private System.Windows.Forms.TextBox txtFTPDefaultGateway;
    private System.Windows.Forms.Label label75;
    private System.Windows.Forms.NumericUpDown numFTPPort;
    private System.Windows.Forms.Label label74;
    private System.Windows.Forms.TextBox txtFTPPassword;
    private System.Windows.Forms.TextBox txtFTPUser;
    private System.Windows.Forms.TextBox txtFTPServer;
    private System.Windows.Forms.Label label73;
    private System.Windows.Forms.Label label72;
    private System.Windows.Forms.Label label71;
    private System.Windows.Forms.CheckBox chkFTPRecipe;
        private System.Windows.Forms.TextBox txtBox_SelectedCamMACAdd;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.CheckBox checkBox_StatuslBar;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.TabPage tabExposure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChangeExpSetup_Cam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDown_LightCrl_Cam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDown_Exposure_Cam1;
        private System.Windows.Forms.CheckBox checkBox_LightEn_Cam1;
        private System.Windows.Forms.NumericUpDown numUpDown_ExposureID_Cam1;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.NumericUpDown numUpDown_FeatureID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_ShowStatusBar2;
        private System.Windows.Forms.CheckBox checkBox_ShowGraphics2;
        private System.Windows.Forms.CheckBox checkBox_ShowStatusBar1;
        private System.Windows.Forms.CheckBox checkBox_ShowGraphics1;
        private System.Windows.Forms.CheckBox checkBox_FOVCross;
        private System.Windows.Forms.Button btn_AcqImageAndRun;
        private System.Windows.Forms.Button btn_Auxiliary2;
        private System.Windows.Forms.Button btn_SaveCurrRecipe;
        private System.Windows.Forms.GroupBox gBox_ExposureSetting_Cam2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUpDown_ExposureID_Cam2;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button btn_ChangeExpSetup_Cam2;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numUpDown_LightCrl_Cam2;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.NumericUpDown numUpDown_Exposure_Cam2;
        private System.Windows.Forms.CheckBox checkBox_LightEn_Cam2;
        private System.Windows.Forms.GroupBox gBox_ExposureSetting_Cam1;
        private System.Windows.Forms.NumericUpDown numUpDown_Feature_CamID;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label55;
    private System.Windows.Forms.TabPage tabRecipeSettings;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.NumericUpDown numLCUpperLim;
    private System.Windows.Forms.NumericUpDown numLCLowLim;
    private System.Windows.Forms.ComboBox cbLCMode;
    private System.Windows.Forms.ComboBox cbLCSelectedPartID;
    private System.Windows.Forms.Label label80;
    private System.Windows.Forms.Label label79;
    private System.Windows.Forms.Label label78;
    private System.Windows.Forms.Label label77;
    private System.Windows.Forms.Button btnUpdateLCheck;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnUpdateMPs;
    private System.Windows.Forms.Button btnSetLCheck;
    private System.Windows.Forms.Button btnSetMPs;
    private System.Windows.Forms.Button btnLogging;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.TabPage tabHeResults;
    private System.Windows.Forms.Label label81;
    private System.Windows.Forms.Button btnGetHeResults;
    private System.Windows.Forms.NumericUpDown CameraIndex;
    private System.Windows.Forms.ComboBox PartID5;
    private System.Windows.Forms.ComboBox PartID4;
    private System.Windows.Forms.ComboBox PartID3;
    private System.Windows.Forms.ComboBox PartID2;
    private System.Windows.Forms.ComboBox PartID1;
    private System.Windows.Forms.Label label87;
    private System.Windows.Forms.Label label86;
    private System.Windows.Forms.Label label85;
    private System.Windows.Forms.Label label84;
    private System.Windows.Forms.Label label82;
        private System.Windows.Forms.CheckBox checkBox_FocusFeedback2;
        private System.Windows.Forms.CheckBox checkBox_FocusFeedback1;
        private System.Windows.Forms.CheckBox checkBox_RetainPoses;
        private System.Windows.Forms.CheckBox chkGiveFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.CheckBox chkImageSaveWithGraphics;
        private System.Windows.Forms.GroupBox gBox_imgFile;
        private System.Windows.Forms.Button btn_AutoExpStart_Cam1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lbl_AutoExpStatus_Cam1;
        private System.Windows.Forms.Button btn_AutoExpCancel_Cam1;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Button btn_AutoExpSetRegion_Cam1;
        private System.Windows.Forms.TabPage tabCheckerCalib;
        private System.Windows.Forms.NumericUpDown numUpDown_Checker_CamID;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Button btn_CheckerMaxRegion;
        private System.Windows.Forms.Button btn_CheckerSetRegion;
        private System.Windows.Forms.Button btn_CheckerCalibrate;
        private System.Windows.Forms.Button btn_CheckerUnCalibrate;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.NumericUpDown numUpDown_CheckerYSpacing;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.NumericUpDown numUpDown_CheckerXSpacing;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label lbl_CheckerStatus;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btn_ChangeExpSetup_Checker;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.NumericUpDown numUpDown_LightCrl_Checker;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.NumericUpDown numUpDown_Exposure_Checker;
        private System.Windows.Forms.CheckBox checkBox_LightEn_Checker;
        private System.Windows.Forms.TextBox txtSpecialInternalDataFolder;
        private System.Windows.Forms.CheckBox chkUseSpecialInternalDataFolder;
        private System.Windows.Forms.Button btn_Auxiliary3;
        private System.Windows.Forms.Label lbl_CurrRecipeID;
        private System.Windows.Forms.Label label95;
    private System.Windows.Forms.Button btnManualAlign;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.ColumnHeader list_Model_Number;
    private System.Windows.Forms.NumericUpDown numRecipeID;
    private System.Windows.Forms.CheckBox chkUseRecipeID;
    private System.Windows.Forms.Label lblLoadCompletedCount;
    private System.Windows.Forms.Label lblRsltChangedCount;
    private System.Windows.Forms.Label label97;
    private System.Windows.Forms.Label label96;
    private System.Windows.Forms.CheckBox chkAttachEvent;
  }
}

