namespace SampleApplication
{
  partial class FormManualAlign
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
      this.label1 = new System.Windows.Forms.Label();
      this.cbSelectedEdge = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.numEdgeWidth = new System.Windows.Forms.NumericUpDown();
      this.cbEdgePolarity = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.numEdgeAcceptThresh = new System.Windows.Forms.NumericUpDown();
      this.cbEdgeFindBy = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.chkShowEdges = new System.Windows.Forms.CheckBox();
      this.btnSetNewPosition2 = new System.Windows.Forms.Button();
      this.btnSetEdge1 = new System.Windows.Forms.Button();
      this.btnSetEdge0 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gbSetPatMax = new System.Windows.Forms.GroupBox();
      this.btnChangeRunPos2 = new System.Windows.Forms.Button();
      this.btnSetNewPos1 = new System.Windows.Forms.Button();
      this.btnChangeRunPos1 = new System.Windows.Forms.Button();
      this.btnChangeTrainedPos2 = new System.Windows.Forms.Button();
      this.btnSetFeature = new System.Windows.Forms.Button();
      this.btnChangeTrainedPos1 = new System.Windows.Forms.Button();
      this.txtRunPos1 = new System.Windows.Forms.TextBox();
      this.chkSetFeatureAngle = new System.Windows.Forms.CheckBox();
      this.txtTrainedPos1 = new System.Windows.Forms.TextBox();
      this.chkShowPoints = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTrainedPos2 = new System.Windows.Forms.TextBox();
      this.txtRunPos2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.chkRetryManualAlign = new System.Windows.Forms.CheckBox();
      this.listMissingFeature = new System.Windows.Forms.ListView();
      this.btnMissingFeature = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnRestartComputation = new System.Windows.Forms.Button();
      this.gbSetCornerFinder = new System.Windows.Forms.GroupBox();
      this.alignCameraDisplay1 = new Cognex.AlignmentSDK.Controls.AlignCameraDisplay();
      ((System.ComponentModel.ISupportInitialize)(this.numEdgeWidth)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numEdgeAcceptThresh)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.gbSetPatMax.SuspendLayout();
      this.gbSetCornerFinder.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(187, 19);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 17);
      this.label1.TabIndex = 9;
      this.label1.Text = "Missing Feature";
      // 
      // cbSelectedEdge
      // 
      this.cbSelectedEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSelectedEdge.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.cbSelectedEdge.FormattingEnabled = true;
      this.cbSelectedEdge.Items.AddRange(new object[] {
            "Edge 0",
            "Edge 1"});
      this.cbSelectedEdge.Location = new System.Drawing.Point(84, 26);
      this.cbSelectedEdge.Margin = new System.Windows.Forms.Padding(2);
      this.cbSelectedEdge.Name = "cbSelectedEdge";
      this.cbSelectedEdge.Size = new System.Drawing.Size(133, 25);
      this.cbSelectedEdge.TabIndex = 49;
      this.cbSelectedEdge.SelectedIndexChanged += new System.EventHandler(this.cbSelectedEdge_SelectedIndexChanged);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(35, 29);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(41, 17);
      this.label10.TabIndex = 48;
      this.label10.Text = "Edge";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(21, 65);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(55, 17);
      this.label6.TabIndex = 39;
      this.label6.Text = "Polarity";
      // 
      // numEdgeWidth
      // 
      this.numEdgeWidth.Location = new System.Drawing.Point(84, 173);
      this.numEdgeWidth.Margin = new System.Windows.Forms.Padding(2);
      this.numEdgeWidth.Name = "numEdgeWidth";
      this.numEdgeWidth.Size = new System.Drawing.Size(63, 23);
      this.numEdgeWidth.TabIndex = 47;
      this.numEdgeWidth.ValueChanged += new System.EventHandler(this.numEdgeWidth_ValueChanged);
      // 
      // cbEdgePolarity
      // 
      this.cbEdgePolarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEdgePolarity.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.cbEdgePolarity.FormattingEnabled = true;
      this.cbEdgePolarity.Items.AddRange(new object[] {
            "Black to White",
            "White to Black",
            "Either"});
      this.cbEdgePolarity.Location = new System.Drawing.Point(84, 62);
      this.cbEdgePolarity.Margin = new System.Windows.Forms.Padding(2);
      this.cbEdgePolarity.Name = "cbEdgePolarity";
      this.cbEdgePolarity.Size = new System.Drawing.Size(133, 25);
      this.cbEdgePolarity.TabIndex = 40;
      this.cbEdgePolarity.SelectedIndexChanged += new System.EventHandler(this.cbEdgePolarity_SelectedIndexChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(32, 173);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(44, 34);
      this.label9.TabIndex = 46;
      this.label9.Text = "Edge\r\nWidth";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(21, 105);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(55, 17);
      this.label7.TabIndex = 41;
      this.label7.Text = "Find By";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbSelectedEdge);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.numEdgeWidth);
      this.groupBox1.Controls.Add(this.cbEdgePolarity);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.numEdgeAcceptThresh);
      this.groupBox1.Controls.Add(this.cbEdgeFindBy);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Location = new System.Drawing.Point(158, 19);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox1.Size = new System.Drawing.Size(223, 219);
      this.groupBox1.TabIndex = 48;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Setting Parameters";
      // 
      // numEdgeAcceptThresh
      // 
      this.numEdgeAcceptThresh.Location = new System.Drawing.Point(83, 140);
      this.numEdgeAcceptThresh.Margin = new System.Windows.Forms.Padding(2);
      this.numEdgeAcceptThresh.Name = "numEdgeAcceptThresh";
      this.numEdgeAcceptThresh.Size = new System.Drawing.Size(63, 23);
      this.numEdgeAcceptThresh.TabIndex = 45;
      this.numEdgeAcceptThresh.ValueChanged += new System.EventHandler(this.numEdgeAcceptThresh_ValueChanged);
      // 
      // cbEdgeFindBy
      // 
      this.cbEdgeFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbEdgeFindBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.cbEdgeFindBy.FormattingEnabled = true;
      this.cbEdgeFindBy.Items.AddRange(new object[] {
            "Best Score",
            "First Edge",
            "Last Edge"});
      this.cbEdgeFindBy.Location = new System.Drawing.Point(84, 98);
      this.cbEdgeFindBy.Margin = new System.Windows.Forms.Padding(2);
      this.cbEdgeFindBy.Name = "cbEdgeFindBy";
      this.cbEdgeFindBy.Size = new System.Drawing.Size(133, 25);
      this.cbEdgeFindBy.TabIndex = 42;
      this.cbEdgeFindBy.SelectedIndexChanged += new System.EventHandler(this.cbEdgeFindBy_SelectedIndexChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(4, 133);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(72, 34);
      this.label8.TabIndex = 43;
      this.label8.Text = "Accept\r\nThreshold";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // chkShowEdges
      // 
      this.chkShowEdges.AutoSize = true;
      this.chkShowEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkShowEdges.Location = new System.Drawing.Point(7, 144);
      this.chkShowEdges.Margin = new System.Windows.Forms.Padding(2);
      this.chkShowEdges.Name = "chkShowEdges";
      this.chkShowEdges.Size = new System.Drawing.Size(105, 21);
      this.chkShowEdges.TabIndex = 38;
      this.chkShowEdges.Text = "Show Edges";
      this.chkShowEdges.UseVisualStyleBackColor = true;
      this.chkShowEdges.CheckedChanged += new System.EventHandler(this.chkShowEdges_CheckedChanged);
      // 
      // btnSetNewPosition2
      // 
      this.btnSetNewPosition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetNewPosition2.Location = new System.Drawing.Point(4, 177);
      this.btnSetNewPosition2.Margin = new System.Windows.Forms.Padding(2);
      this.btnSetNewPosition2.Name = "btnSetNewPosition2";
      this.btnSetNewPosition2.Size = new System.Drawing.Size(148, 40);
      this.btnSetNewPosition2.TabIndex = 10;
      this.btnSetNewPosition2.Text = "4. Set New Position";
      this.btnSetNewPosition2.UseVisualStyleBackColor = true;
      this.btnSetNewPosition2.Click += new System.EventHandler(this.btnSetNewPosition2_Click);
      // 
      // btnSetEdge1
      // 
      this.btnSetEdge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetEdge1.Location = new System.Drawing.Point(4, 89);
      this.btnSetEdge1.Margin = new System.Windows.Forms.Padding(2);
      this.btnSetEdge1.Name = "btnSetEdge1";
      this.btnSetEdge1.Size = new System.Drawing.Size(148, 40);
      this.btnSetEdge1.TabIndex = 9;
      this.btnSetEdge1.Text = "3. Set Edge 1";
      this.btnSetEdge1.UseVisualStyleBackColor = true;
      this.btnSetEdge1.Click += new System.EventHandler(this.btnSetEdge1_Click);
      // 
      // btnSetEdge0
      // 
      this.btnSetEdge0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetEdge0.Location = new System.Drawing.Point(4, 35);
      this.btnSetEdge0.Margin = new System.Windows.Forms.Padding(2);
      this.btnSetEdge0.Name = "btnSetEdge0";
      this.btnSetEdge0.Size = new System.Drawing.Size(148, 40);
      this.btnSetEdge0.TabIndex = 8;
      this.btnSetEdge0.Text = "2. Set Edge 0";
      this.btnSetEdge0.UseVisualStyleBackColor = true;
      this.btnSetEdge0.Click += new System.EventHandler(this.btnSetEdge0_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
      this.groupBox2.Controls.Add(this.gbSetPatMax);
      this.groupBox2.Controls.Add(this.chkRetryManualAlign);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.listMissingFeature);
      this.groupBox2.Controls.Add(this.btnMissingFeature);
      this.groupBox2.Controls.Add(this.btnCancel);
      this.groupBox2.Controls.Add(this.btnRestartComputation);
      this.groupBox2.Controls.Add(this.gbSetCornerFinder);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(11, 11);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox2.Size = new System.Drawing.Size(394, 432);
      this.groupBox2.TabIndex = 123;
      this.groupBox2.TabStop = false;
      // 
      // gbSetPatMax
      // 
      this.gbSetPatMax.Controls.Add(this.btnChangeRunPos2);
      this.gbSetPatMax.Controls.Add(this.btnSetNewPos1);
      this.gbSetPatMax.Controls.Add(this.btnChangeRunPos1);
      this.gbSetPatMax.Controls.Add(this.btnChangeTrainedPos2);
      this.gbSetPatMax.Controls.Add(this.btnSetFeature);
      this.gbSetPatMax.Controls.Add(this.btnChangeTrainedPos1);
      this.gbSetPatMax.Controls.Add(this.txtRunPos1);
      this.gbSetPatMax.Controls.Add(this.chkSetFeatureAngle);
      this.gbSetPatMax.Controls.Add(this.txtTrainedPos1);
      this.gbSetPatMax.Controls.Add(this.chkShowPoints);
      this.gbSetPatMax.Controls.Add(this.label2);
      this.gbSetPatMax.Controls.Add(this.label5);
      this.gbSetPatMax.Controls.Add(this.txtTrainedPos2);
      this.gbSetPatMax.Controls.Add(this.txtRunPos2);
      this.gbSetPatMax.Controls.Add(this.label3);
      this.gbSetPatMax.Controls.Add(this.label4);
      this.gbSetPatMax.Cursor = System.Windows.Forms.Cursors.Default;
      this.gbSetPatMax.ForeColor = System.Drawing.SystemColors.InfoText;
      this.gbSetPatMax.Location = new System.Drawing.Point(3, 99);
      this.gbSetPatMax.Margin = new System.Windows.Forms.Padding(2);
      this.gbSetPatMax.Name = "gbSetPatMax";
      this.gbSetPatMax.Padding = new System.Windows.Forms.Padding(2);
      this.gbSetPatMax.Size = new System.Drawing.Size(385, 280);
      this.gbSetPatMax.TabIndex = 5;
      this.gbSetPatMax.TabStop = false;
      this.gbSetPatMax.Text = "Patmax Feature";
      // 
      // btnChangeRunPos2
      // 
      this.btnChangeRunPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangeRunPos2.Location = new System.Drawing.Point(271, 170);
      this.btnChangeRunPos2.Margin = new System.Windows.Forms.Padding(2);
      this.btnChangeRunPos2.Name = "btnChangeRunPos2";
      this.btnChangeRunPos2.Size = new System.Drawing.Size(106, 23);
      this.btnChangeRunPos2.TabIndex = 37;
      this.btnChangeRunPos2.Text = "Change";
      this.btnChangeRunPos2.UseVisualStyleBackColor = true;
      this.btnChangeRunPos2.Click += new System.EventHandler(this.btnChangeRunPos2_Click);
      // 
      // btnSetNewPos1
      // 
      this.btnSetNewPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetNewPos1.Location = new System.Drawing.Point(110, 228);
      this.btnSetNewPos1.Margin = new System.Windows.Forms.Padding(2);
      this.btnSetNewPos1.Name = "btnSetNewPos1";
      this.btnSetNewPos1.Size = new System.Drawing.Size(148, 40);
      this.btnSetNewPos1.TabIndex = 7;
      this.btnSetNewPos1.Text = "3. Set New Position";
      this.btnSetNewPos1.UseVisualStyleBackColor = true;
      this.btnSetNewPos1.Click += new System.EventHandler(this.btnSetNewPos1_Click);
      // 
      // btnChangeRunPos1
      // 
      this.btnChangeRunPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangeRunPos1.Location = new System.Drawing.Point(271, 143);
      this.btnChangeRunPos1.Margin = new System.Windows.Forms.Padding(2);
      this.btnChangeRunPos1.Name = "btnChangeRunPos1";
      this.btnChangeRunPos1.Size = new System.Drawing.Size(106, 23);
      this.btnChangeRunPos1.TabIndex = 36;
      this.btnChangeRunPos1.Text = "Change";
      this.btnChangeRunPos1.UseVisualStyleBackColor = true;
      this.btnChangeRunPos1.Click += new System.EventHandler(this.btnChangeRunPos1_Click);
      // 
      // btnChangeTrainedPos2
      // 
      this.btnChangeTrainedPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangeTrainedPos2.Location = new System.Drawing.Point(271, 112);
      this.btnChangeTrainedPos2.Margin = new System.Windows.Forms.Padding(2);
      this.btnChangeTrainedPos2.Name = "btnChangeTrainedPos2";
      this.btnChangeTrainedPos2.Size = new System.Drawing.Size(106, 23);
      this.btnChangeTrainedPos2.TabIndex = 35;
      this.btnChangeTrainedPos2.Text = "Change";
      this.btnChangeTrainedPos2.UseVisualStyleBackColor = true;
      this.btnChangeTrainedPos2.Click += new System.EventHandler(this.btnChangeTrainedPos2_Click);
      // 
      // btnSetFeature
      // 
      this.btnSetFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSetFeature.Location = new System.Drawing.Point(110, 16);
      this.btnSetFeature.Margin = new System.Windows.Forms.Padding(2);
      this.btnSetFeature.Name = "btnSetFeature";
      this.btnSetFeature.Size = new System.Drawing.Size(148, 40);
      this.btnSetFeature.TabIndex = 4;
      this.btnSetFeature.Text = "2. Set Feature Position";
      this.btnSetFeature.UseVisualStyleBackColor = true;
      this.btnSetFeature.Click += new System.EventHandler(this.btnSetFeature_Click);
      // 
      // btnChangeTrainedPos1
      // 
      this.btnChangeTrainedPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangeTrainedPos1.Location = new System.Drawing.Point(271, 84);
      this.btnChangeTrainedPos1.Margin = new System.Windows.Forms.Padding(2);
      this.btnChangeTrainedPos1.Name = "btnChangeTrainedPos1";
      this.btnChangeTrainedPos1.Size = new System.Drawing.Size(106, 23);
      this.btnChangeTrainedPos1.TabIndex = 34;
      this.btnChangeTrainedPos1.Text = "Change";
      this.btnChangeTrainedPos1.UseVisualStyleBackColor = true;
      this.btnChangeTrainedPos1.Click += new System.EventHandler(this.btnChangeTrainedPos1_Click);
      // 
      // txtRunPos1
      // 
      this.txtRunPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRunPos1.Location = new System.Drawing.Point(136, 142);
      this.txtRunPos1.Margin = new System.Windows.Forms.Padding(2);
      this.txtRunPos1.Name = "txtRunPos1";
      this.txtRunPos1.ReadOnly = true;
      this.txtRunPos1.Size = new System.Drawing.Size(123, 23);
      this.txtRunPos1.TabIndex = 29;
      // 
      // chkSetFeatureAngle
      // 
      this.chkSetFeatureAngle.AutoSize = true;
      this.chkSetFeatureAngle.Location = new System.Drawing.Point(26, 60);
      this.chkSetFeatureAngle.Margin = new System.Windows.Forms.Padding(2);
      this.chkSetFeatureAngle.Name = "chkSetFeatureAngle";
      this.chkSetFeatureAngle.Size = new System.Drawing.Size(141, 21);
      this.chkSetFeatureAngle.TabIndex = 24;
      this.chkSetFeatureAngle.Text = "Set Feature Angle";
      this.chkSetFeatureAngle.UseVisualStyleBackColor = true;
      this.chkSetFeatureAngle.CheckedChanged += new System.EventHandler(this.chkSetFeatureAngle_CheckedChanged);
      // 
      // txtTrainedPos1
      // 
      this.txtTrainedPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTrainedPos1.Location = new System.Drawing.Point(135, 85);
      this.txtTrainedPos1.Margin = new System.Windows.Forms.Padding(2);
      this.txtTrainedPos1.Name = "txtTrainedPos1";
      this.txtTrainedPos1.ReadOnly = true;
      this.txtTrainedPos1.Size = new System.Drawing.Size(123, 23);
      this.txtTrainedPos1.TabIndex = 25;
      // 
      // chkShowPoints
      // 
      this.chkShowPoints.AutoSize = true;
      this.chkShowPoints.Location = new System.Drawing.Point(26, 205);
      this.chkShowPoints.Margin = new System.Windows.Forms.Padding(2);
      this.chkShowPoints.Name = "chkShowPoints";
      this.chkShowPoints.Size = new System.Drawing.Size(104, 21);
      this.chkShowPoints.TabIndex = 33;
      this.chkShowPoints.Text = "Show Points";
      this.chkShowPoints.UseVisualStyleBackColor = true;
      this.chkShowPoints.CheckedChanged += new System.EventHandler(this.chkShowPoints_CheckedChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 88);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 17);
      this.label2.TabIndex = 26;
      this.label2.Text = "Trained Point 1";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(39, 171);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 17);
      this.label5.TabIndex = 32;
      this.label5.Text = "Run Point 2";
      // 
      // txtTrainedPos2
      // 
      this.txtTrainedPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTrainedPos2.Location = new System.Drawing.Point(135, 113);
      this.txtTrainedPos2.Margin = new System.Windows.Forms.Padding(2);
      this.txtTrainedPos2.Name = "txtTrainedPos2";
      this.txtTrainedPos2.ReadOnly = true;
      this.txtTrainedPos2.Size = new System.Drawing.Size(123, 23);
      this.txtTrainedPos2.TabIndex = 27;
      // 
      // txtRunPos2
      // 
      this.txtRunPos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRunPos2.Location = new System.Drawing.Point(136, 171);
      this.txtRunPos2.Margin = new System.Windows.Forms.Padding(2);
      this.txtRunPos2.Name = "txtRunPos2";
      this.txtRunPos2.ReadOnly = true;
      this.txtRunPos2.Size = new System.Drawing.Size(123, 23);
      this.txtRunPos2.TabIndex = 31;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 116);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(105, 17);
      this.label3.TabIndex = 28;
      this.label3.Text = "Trained Point 2";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(39, 143);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(82, 17);
      this.label4.TabIndex = 30;
      this.label4.Text = "Run Point 1";
      // 
      // chkRetryManualAlign
      // 
      this.chkRetryManualAlign.AutoSize = true;
      this.chkRetryManualAlign.Location = new System.Drawing.Point(6, 25);
      this.chkRetryManualAlign.Margin = new System.Windows.Forms.Padding(2);
      this.chkRetryManualAlign.Name = "chkRetryManualAlign";
      this.chkRetryManualAlign.Size = new System.Drawing.Size(151, 21);
      this.chkRetryManualAlign.TabIndex = 122;
      this.chkRetryManualAlign.Text = "Retry Manual Again";
      this.chkRetryManualAlign.UseVisualStyleBackColor = true;
      this.chkRetryManualAlign.CheckedChanged += new System.EventHandler(this.chkRetryManualAlign_CheckedChanged);
      // 
      // listMissingFeature
      // 
      this.listMissingFeature.HideSelection = false;
      this.listMissingFeature.Location = new System.Drawing.Point(189, 40);
      this.listMissingFeature.Margin = new System.Windows.Forms.Padding(8);
      this.listMissingFeature.MultiSelect = false;
      this.listMissingFeature.Name = "listMissingFeature";
      this.listMissingFeature.Size = new System.Drawing.Size(193, 56);
      this.listMissingFeature.TabIndex = 1;
      this.listMissingFeature.UseCompatibleStateImageBehavior = false;
      this.listMissingFeature.View = System.Windows.Forms.View.List;
      // 
      // btnMissingFeature
      // 
      this.btnMissingFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMissingFeature.Location = new System.Drawing.Point(6, 46);
      this.btnMissingFeature.Margin = new System.Windows.Forms.Padding(2);
      this.btnMissingFeature.Name = "btnMissingFeature";
      this.btnMissingFeature.Size = new System.Drawing.Size(167, 40);
      this.btnMissingFeature.TabIndex = 8;
      this.btnMissingFeature.Text = "1. Load Missing Features";
      this.btnMissingFeature.UseVisualStyleBackColor = true;
      this.btnMissingFeature.Click += new System.EventHandler(this.btnMissingFeature_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(339, 382);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(46, 40);
      this.btnCancel.TabIndex = 121;
      this.btnCancel.Text = "Close";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnRestartComputation
      // 
      this.btnRestartComputation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRestartComputation.Location = new System.Drawing.Point(3, 383);
      this.btnRestartComputation.Margin = new System.Windows.Forms.Padding(2);
      this.btnRestartComputation.Name = "btnRestartComputation";
      this.btnRestartComputation.Size = new System.Drawing.Size(233, 40);
      this.btnRestartComputation.TabIndex = 4;
      this.btnRestartComputation.Text = "Final. Restart Computation";
      this.btnRestartComputation.UseVisualStyleBackColor = true;
      this.btnRestartComputation.Click += new System.EventHandler(this.btnRestartComputation_Click);
      // 
      // gbSetCornerFinder
      // 
      this.gbSetCornerFinder.Controls.Add(this.groupBox1);
      this.gbSetCornerFinder.Controls.Add(this.chkShowEdges);
      this.gbSetCornerFinder.Controls.Add(this.btnSetNewPosition2);
      this.gbSetCornerFinder.Controls.Add(this.btnSetEdge1);
      this.gbSetCornerFinder.Controls.Add(this.btnSetEdge0);
      this.gbSetCornerFinder.Location = new System.Drawing.Point(3, 99);
      this.gbSetCornerFinder.Margin = new System.Windows.Forms.Padding(2);
      this.gbSetCornerFinder.Name = "gbSetCornerFinder";
      this.gbSetCornerFinder.Padding = new System.Windows.Forms.Padding(2);
      this.gbSetCornerFinder.Size = new System.Drawing.Size(385, 280);
      this.gbSetCornerFinder.TabIndex = 8;
      this.gbSetCornerFinder.TabStop = false;
      this.gbSetCornerFinder.Text = "Corner Feature";
      // 
      // alignCameraDisplay1
      // 
      this.alignCameraDisplay1.FileName = null;
      this.alignCameraDisplay1.FocusFeedbackEnabled = true;
      this.alignCameraDisplay1.FOVCenterCrossEnabled = false;
      this.alignCameraDisplay1.GiveFileNameEnabled = false;
      this.alignCameraDisplay1.Location = new System.Drawing.Point(411, 11);
      this.alignCameraDisplay1.Name = "alignCameraDisplay1";
      this.alignCameraDisplay1.SaveImageWithGraphicsEnabled = false;
      this.alignCameraDisplay1.ShowGraphics = true;
      this.alignCameraDisplay1.Size = new System.Drawing.Size(846, 667);
      this.alignCameraDisplay1.StatusBarVisibility = true;
      this.alignCameraDisplay1.TabIndex = 124;
      this.alignCameraDisplay1.ToolBarLiveVideoEnabled = true;
      this.alignCameraDisplay1.ToolBarLoadImageEnabled = true;
      this.alignCameraDisplay1.ToolBarSaveImageEnabled = true;
      this.alignCameraDisplay1.ToolBarVisibility = true;
      this.alignCameraDisplay1.UseAcceptCancelToolbarButtons = true;
      // 
      // FormManualAlign
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1277, 689);
      this.Controls.Add(this.alignCameraDisplay1);
      this.Controls.Add(this.groupBox2);
      this.Name = "FormManualAlign";
      this.Text = "FormManualAlign";
      ((System.ComponentModel.ISupportInitialize)(this.numEdgeWidth)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numEdgeAcceptThresh)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.gbSetPatMax.ResumeLayout(false);
      this.gbSetPatMax.PerformLayout();
      this.gbSetCornerFinder.ResumeLayout(false);
      this.gbSetCornerFinder.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbSelectedEdge;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown numEdgeWidth;
    private System.Windows.Forms.ComboBox cbEdgePolarity;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numEdgeAcceptThresh;
    private System.Windows.Forms.ComboBox cbEdgeFindBy;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.CheckBox chkShowEdges;
    private System.Windows.Forms.Button btnSetNewPosition2;
    private System.Windows.Forms.Button btnSetEdge1;
    private System.Windows.Forms.Button btnSetEdge0;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox gbSetPatMax;
    private System.Windows.Forms.Button btnChangeRunPos2;
    private System.Windows.Forms.Button btnSetNewPos1;
    private System.Windows.Forms.Button btnChangeRunPos1;
    private System.Windows.Forms.Button btnChangeTrainedPos2;
    private System.Windows.Forms.Button btnSetFeature;
    private System.Windows.Forms.Button btnChangeTrainedPos1;
    private System.Windows.Forms.TextBox txtRunPos1;
    private System.Windows.Forms.CheckBox chkSetFeatureAngle;
    private System.Windows.Forms.TextBox txtTrainedPos1;
    private System.Windows.Forms.CheckBox chkShowPoints;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTrainedPos2;
    private System.Windows.Forms.TextBox txtRunPos2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkRetryManualAlign;
    private System.Windows.Forms.ListView listMissingFeature;
    private System.Windows.Forms.Button btnMissingFeature;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnRestartComputation;
    private System.Windows.Forms.GroupBox gbSetCornerFinder;
    private Cognex.AlignmentSDK.Controls.AlignCameraDisplay alignCameraDisplay1;
  }
}