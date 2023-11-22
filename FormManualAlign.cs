using Cognex.AlignmentSDK;
using Cognex.AlignmentSDK.Interfaces;
using Cognex.AlignmentSDK.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication
{
  public partial class FormManualAlign : Form
  {
    #region constant
    private const string PositionFormat = "[{0:0.00},{1:0.00}]";
    #endregion

    #region members
    private IAlignSystem mCurrentSystem;
    private IAlignCamera mCamera;
    private bool ChangeBtnSelected = false;
    private int WhichChangeBtnSelected = 1;
    #endregion 

    #region constructor
    public FormManualAlign(IAlignSystem currSystem, IAlignCamera cam)
    {
      InitializeComponent();

      mCurrentSystem = currSystem;
      mCamera = cam;
      alignCameraDisplay1.SetAlignCamera(mCamera);
      alignCameraDisplay1.ZoomFit();

      InitManualAlign();
    }
    private FormManualAlign()
    {
      InitializeComponent();
    }
    #endregion 

    #region properties
    public FeatureElement selectedFeature { get; set; }
    #endregion 

    #region HMI event
    private void btnMissingFeature_Click(object sender, EventArgs e)
    {
      UpdateMissingFeatureList();
    }

    private void chkRetryManualAlign_CheckedChanged(object sender, EventArgs e)
    {
      RefreshMissingFeatureList();
      mCurrentSystem.GetManualAlignSettings().ForceManualAlign = chkRetryManualAlign.Checked;
      if (chkRetryManualAlign.Checked)
      {
        listMissingFeature.Clear();
        UpdateMissingFeatureList();
      }
      else
      {
        listMissingFeature.Clear();
      }
    }

    private void btnRestartComputation_Click(object sender, EventArgs e)
    {
      SetEmptyCell();
      mCurrentSystem.GetManualAlignSettings().ClickRestartComputation();
      chkRetryManualAlign.Checked = false;
      mCurrentSystem.GetManualAlignSettings().ManualAlignEnable = false;
      // Close manuala align
      CloseManualMode();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      CloseManualMode();
    }

    #region Pattern
    private void btnSetFeature_Click(object sender, EventArgs e)
    {
      if (alignCameraDisplay1.State == 0 /* normal state */)
      {
        ButtonEnable(false);
        alignCameraDisplay1.EditGraphicsCompleted += DisplayImage_EditGraphicsCompleted;

        alignCameraDisplay1.EditCellGraphic(mCurrentSystem.GetManualAlignSettings().EditPointTag);
      }

    }
    private void DisplayImage_EditGraphicsCompleted(object sender, IEditGraphicsCompletedInfo e)
    {
      Cursor = Cursors.WaitCursor;

      // unregister event
      alignCameraDisplay1.EditGraphicsCompleted -= DisplayImage_EditGraphicsCompleted;

      ControlsEnabled(gbSetPatMax, null, true);
      ControlsEnabled(gbSetCornerFinder, null, true);

      // show buttons
      ButtonEnable(true);

      Cursor = Cursors.Default;
    }

    private void chkSetFeatureAngle_CheckedChanged(object sender, EventArgs e)
    {
      if (chkSetFeatureAngle.Checked)
      {
        alignCameraDisplay1.SetCurrentCell(selectedFeature.TrainedCellRow, selectedFeature.TrainedCellCol);
        selectedFeature.ListPointToAngle = new List<PointF>();
        alignCameraDisplay1.MouseClick += evMouseClickSetAngles;
        chkShowPoints.Checked = true;
      }
      else
      {
        ClearGraphics();

        selectedFeature.ListPointToAngle = new List<PointF>();
        var nullRslt = String.Format(PositionFormat, 0, 0);
        txtTrainedPos1.Text = nullRslt;
        txtTrainedPos2.Text = nullRslt;
        txtRunPos1.Text = nullRslt;
        txtRunPos2.Text = nullRslt;
        alignCameraDisplay1.MouseClick -= evMouseClickSetAngles;
      }
      EnableChangeButton(!chkSetFeatureAngle.Checked);
    }

    private void evMouseClickSetAngles(object sender, MouseEventArgs e)
    {
      if (selectedFeature.ListPointToAngle.Count < 4 && !ChangeBtnSelected)
      {
        var col = e.Location.X / alignCameraDisplay1.ImageScale + alignCameraDisplay1.ImageOffset.X;
        var row = e.Location.Y / alignCameraDisplay1.ImageScale + alignCameraDisplay1.ImageOffset.Y;

        selectedFeature.ListPointToAngle.Add(new PointF((float)row, (float)col));

        TextBox txt = null;
        switch (selectedFeature.ListPointToAngle.Count)
        {
          case 1: txt = txtTrainedPos1; break;
          case 2: txt = txtTrainedPos2; break;
          case 3: txt = txtRunPos1; break;
          case 4: txt = txtRunPos2; break;
        }
        mCurrentSystem.GetManualAlignSettings().SetAnglePoint(selectedFeature.ListPointToAngle.Count, row, col);
        txt.Text = String.Format(PositionFormat, row, col);
        if (selectedFeature.ListPointToAngle.Count == 2)
          alignCameraDisplay1.SetCurrentCell(
            mCurrentSystem.GetManualAlignSettings().EmptyCellRow,
            mCurrentSystem.GetManualAlignSettings().EmptyCellCol);
        if (selectedFeature.ListPointToAngle.Count == 4)
        {
          alignCameraDisplay1.MouseClick -= evMouseClickSetAngles;
          EnableChangeButton(true);
        }
      }
    }

    private void btnChangeTrainedPos1_Click(object sender, EventArgs e)
    {
      ChangeBtnSelected = true;
      WhichChangeBtnSelected = 1;

      EnableChangeButton(false, WhichChangeBtnSelected);
      alignCameraDisplay1.SetCurrentCell(
        selectedFeature.TrainedCellRow, 
        selectedFeature.TrainedCellCol);
      this.alignCameraDisplay1.Cursor = Cursors.Cross;
      alignCameraDisplay1.MouseClick += evMouseClickSetAngle;
    }

    private void btnChangeTrainedPos2_Click(object sender, EventArgs e)
    {
      ChangeBtnSelected = true;
      WhichChangeBtnSelected = 2;

      EnableChangeButton(false, WhichChangeBtnSelected);
      alignCameraDisplay1.SetCurrentCell(
        selectedFeature.TrainedCellRow, 
        selectedFeature.TrainedCellCol);
      this.alignCameraDisplay1.Cursor = Cursors.Cross;
      alignCameraDisplay1.MouseClick += evMouseClickSetAngle;
    }

    private void btnChangeRunPos1_Click(object sender, EventArgs e)
    {
      ChangeBtnSelected = true;
      WhichChangeBtnSelected = 3;

      EnableChangeButton(false, WhichChangeBtnSelected);
      this.alignCameraDisplay1.Cursor = Cursors.Cross;
      alignCameraDisplay1.MouseClick += evMouseClickSetAngle;
    }

    private void btnChangeRunPos2_Click(object sender, EventArgs e)
    {
      ChangeBtnSelected = true;
      WhichChangeBtnSelected = 4;

      EnableChangeButton(false, WhichChangeBtnSelected);
      this.alignCameraDisplay1.Cursor = Cursors.Cross;
      alignCameraDisplay1.MouseClick += evMouseClickSetAngle;
    }

    private void evMouseClickSetAngle(object sender, MouseEventArgs e)
    {
      var col = e.Location.X / alignCameraDisplay1.ImageScale + alignCameraDisplay1.ImageOffset.X;
      var row = e.Location.Y / alignCameraDisplay1.ImageScale + alignCameraDisplay1.ImageOffset.Y;

      TextBox txt = null;
      switch (WhichChangeBtnSelected)
      {
        case 1: txt = txtTrainedPos1; break;
        case 2: txt = txtTrainedPos2; break;
        case 3: txt = txtRunPos1; break;
        case 4: txt = txtRunPos2; break;
      }
      mCurrentSystem.GetManualAlignSettings().SetAnglePoint(WhichChangeBtnSelected, row, col);
      txt.Text = String.Format(PositionFormat, row, col);

      ClearGraphics();
      ChangeBtnSelected = false;
      alignCameraDisplay1.MouseClick -= evMouseClickSetAngle;
      EnableChangeButton(true);
      RefreshShowPoint();
    }

    private void chkShowPoints_CheckedChanged(object sender, EventArgs e)
    {
     mCurrentSystem.GetManualAlignSettings().ShowPoint = chkShowPoints.Checked;
    }

    private void btnSetNewPos1_Click(object sender, EventArgs e)
    {
      var dialogResult = MessageBox.Show(
        "Are you sure to set the new Point?" + mCurrentSystem.GetManualAlignSettings().PatternStringDisplay,
        "Confirmation", MessageBoxButtons.YesNo);

      if (dialogResult == DialogResult.Yes)
      {
        mCurrentSystem.GetManualAlignSettings().ClickSetPointPose();
        mCurrentSystem.GetManualAlignSettings().ShowPoint = false;
        chkShowPoints.Checked = false;
        ClearGraphics();
      }
    }
    #endregion 

    #region corner finder
    private void btnSetEdge0_Click(object sender, EventArgs e)
    {
      alignCameraDisplay1.SetCurrentCell(selectedFeature.TrainedEdge0Row, selectedFeature.TrainedEdgeCol);
      DialogResult dialogResult = MessageBox.Show(
        String.Format("Have you seen the trained box direction for Edge{0}?", 0),
        String.Format("Edge {0} direction", 0), MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        if (alignCameraDisplay1.State == 0 /* normal state */)
        {
          ButtonEnable(false);
          alignCameraDisplay1.EditGraphicsCompleted += DisplayImage_EditGraphicsCompleted;
          alignCameraDisplay1.EditCellGraphic(mCurrentSystem.GetManualAlignSettings().EditEdgeRegionTag(0));
        }
      }
      SetEmptyCell();
    }

    private void btnSetEdge1_Click(object sender, EventArgs e)
    {
      alignCameraDisplay1.SetCurrentCell(selectedFeature.TrainedEdge1Row, selectedFeature.TrainedEdgeCol);
      DialogResult dialogResult = MessageBox.Show(
        String.Format("Have you seen the trained box direction for Edge{0}?", 1),
        String.Format("Edge {0} direction", 1), MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        if (alignCameraDisplay1.State == 0 /* normal state */)
        {
          ButtonEnable(false);
          alignCameraDisplay1.EditGraphicsCompleted += DisplayImage_EditGraphicsCompleted;
          alignCameraDisplay1.EditCellGraphic(mCurrentSystem.GetManualAlignSettings().EditEdgeRegionTag(1));
        }
      }
      SetEmptyCell();
    }
  

    private void chkShowEdges_CheckedChanged(object sender, EventArgs e)
    {
      mCurrentSystem.GetManualAlignSettings().ShowEdge = chkShowEdges.Checked;
    }

    private void btnSetNewPosition2_Click(object sender, EventArgs e)
    {
      SetEmptyCell();
      var dialogResult = MessageBox.Show(
        "Are you sure to set the new corner?" + mCurrentSystem.GetManualAlignSettings().CrossStringDisplay,
        "Confirmation", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.Yes)
      {
        mCurrentSystem.GetManualAlignSettings().ClickSetCornerPose();
        mCurrentSystem.GetManualAlignSettings().ShowEdge = false;
        chkShowEdges.Checked = false;
      }
    }

    private void cbSelectedEdge_SelectedIndexChanged(object sender, EventArgs e)
    {
      ReadEdgesParams(selectedFeature);
    }

    private void cbEdgePolarity_SelectedIndexChanged(object sender, EventArgs e)
    {
      WriteEdgeParams();
    }

    private void cbEdgeFindBy_SelectedIndexChanged(object sender, EventArgs e)
    {
      WriteEdgeParams();
    }

    private void numEdgeAcceptThresh_ValueChanged(object sender, EventArgs e)
    {
      WriteEdgeParams();
    }

    private void numEdgeWidth_ValueChanged(object sender, EventArgs e)
    {
      WriteEdgeParams();
    }
    #endregion


    #endregion

    #region HMI state 
    private void EnableSetPatMax(bool bEnable)
    {
      gbSetPatMax.Visible = bEnable;
      gbSetPatMax.Enabled = bEnable;
    }

    private void EnableSetCornerFinder(bool bEnable)
    {
      gbSetCornerFinder.Visible = bEnable;
      gbSetCornerFinder.Enabled = bEnable;
    }
    #endregion 

    private void UpdateMissingFeatureList()
    {
      listMissingFeature.Clear();
      foreach (var elem in mCurrentSystem.GetManualAlignSettings().UpdateMissingFeatureList())
      {
        listMissingFeature.Items.Add(elem.FeatName);
      }
    }
    private void RefreshMissingFeatureList()
    {
      mCurrentSystem.GetManualAlignSettings().ManualAlignEnable = false;
      mCurrentSystem.GetManualAlignSettings().ManualAlignEnable = true;
    }

    private void ClearGraphics()
    {
      mCurrentSystem.GetManualAlignSettings().ShowPoint = false;
      mCurrentSystem.GetManualAlignSettings().ShowEdge = false;
    }
    private void InitManualAlign()
    {
      RefreshMissingFeatureList();
      ClearGraphics();

      EnableSetPatMax(false);
      EnableSetCornerFinder(false);

      listMissingFeature.ItemSelectionChanged += UpdateFeaturePostionAndCalculate;
    }

    private void UpdateFeaturePostionAndCalculate(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      ClearGraphics();

      var itemsSelected = listMissingFeature.SelectedItems;
      if (itemsSelected.Count > 0)
      {
        foreach (var item in mCurrentSystem.GetManualAlignSettings().missingFeatureList)
        {
          if (item.FeatName.Equals(itemsSelected[0].Text))
          {
            selectedFeature = item;
            UpdateFeatureHMI(selectedFeature);
          }
        }
      }
      chkSetFeatureAngle.Checked = false;
      chkShowPoints.Checked = false;
    }
    private void UpdateFeatureHMI(FeatureElement featureSelected)
    {
      if (featureSelected.FeatType == FeatureTypes.Pattern)
      {
        mCurrentSystem.GetManualAlignSettings().PointFeatureSelector = featureSelected.FeatId;
        EnableSetPatMax(true);
        EnableSetCornerFinder(false);
        chkShowPoints.Checked = mCurrentSystem.GetManualAlignSettings().ShowPoint;
      }
      else if (featureSelected.FeatType == FeatureTypes.FixtureAndCorner)
      {
        mCurrentSystem.GetManualAlignSettings().CornerFeatureSelector = featureSelected.FeatId;
        EnableSetPatMax(false);
        EnableSetCornerFinder(true);
        mCurrentSystem.GetManualAlignSettings().ShowEdge = true;
        chkShowEdges.Checked = true;

        cbSelectedEdge.SelectedIndex = 0;
        ReadEdgesParams(featureSelected);
      }
    }
    /// <summary>
    /// Read Edge parames from SpreadSheet
    /// </summary>
    /// <param name="featureSelected"></param>
    private void ReadEdgesParams(FeatureElement featureSelected)
    {
      if (cbSelectedEdge.SelectedIndex != 0 && cbSelectedEdge.SelectedIndex != 1)
        return;

      var edge = cbSelectedEdge.SelectedIndex;
      int feature = 0;
      switch (featureSelected.FeatName)
      {
        case "Feature1": feature = 1; break;
        case "Feature2": feature = 2; break;
        case "Feature3": feature = 3; break;
        case "Feature4": feature = 4; break;
      }
      cbEdgePolarity.SelectedIndex = mCurrentSystem.GetManualAlignSettings().GetEdgePolarity(edge, feature);
      cbEdgeFindBy.SelectedIndex = mCurrentSystem.GetManualAlignSettings().GetEdgeFindBy(edge, feature);
      numEdgeAcceptThresh.Value = mCurrentSystem.GetManualAlignSettings().GetEdgeAcceptThresh(edge, feature);
      numEdgeWidth.Value = mCurrentSystem.GetManualAlignSettings().GetEdgeWidth(edge, feature);
    }

    /// <summary>
    /// Write Edge parames to SpreadSheet
    /// </summary>
    public void WriteEdgeParams()
    {
      int edge = cbSelectedEdge.SelectedIndex;
      int feature = selectedFeature.FeatId;
      mCurrentSystem.GetManualAlignSettings().SetEdgePolarity(edge, feature, cbEdgePolarity.SelectedIndex);
      mCurrentSystem.GetManualAlignSettings().SetEdgeFindBy(edge, feature, cbEdgeFindBy.SelectedIndex);
      mCurrentSystem.GetManualAlignSettings().SetEdgeAcceptThresh(edge, feature, (int)numEdgeAcceptThresh.Value);
      mCurrentSystem.GetManualAlignSettings().SetEdgeWidth(edge, feature, (int)numEdgeWidth.Value);
    }

    private void SetEmptyCell()
    {
      alignCameraDisplay1.SetCurrentCell(
        mCurrentSystem.GetManualAlignSettings().EmptyCellRow,
        mCurrentSystem.GetManualAlignSettings().EmptyCellCol);
    }
    private void CloseManualMode()
    {
      ClearGraphics();
      System.Threading.Thread.Sleep(100);
      Close();
    }
    private void ButtonEnable(bool enable)
    {
      EnableButton(btnMissingFeature, enable);
      chkRetryManualAlign.Enabled = enable;
      EnableButton(btnRestartComputation, enable);
      EnableButton(btnCancel, enable);

      EnableButton(btnSetFeature, enable);
      EnableChangeButton(enable);
      EnableButton(btnSetNewPos1, enable);

      EnableButton(btnSetNewPosition2, enable);
      EnableButton(btnSetEdge0, enable);
      EnableButton(btnSetEdge1, enable);
    }
    private void EnableButton(Button btn, bool bEnable)
    {
      btn.Enabled = bEnable;
      btn.BackColor = bEnable ? Color.White : Color.DarkGray;
    }
    private void EnableChangeButton(bool bEnable, int idx = 0)
    {
      EnableButton(btnChangeTrainedPos1, bEnable);
      EnableButton(btnChangeTrainedPos2, bEnable);
      EnableButton(btnChangeRunPos1, bEnable);
      EnableButton(btnChangeRunPos2, bEnable);
      switch (idx)
      {
        case 0: break;
        case 1: EnableButton(btnChangeTrainedPos1, !bEnable); break;
        case 2: EnableButton(btnChangeTrainedPos2, !bEnable); break;
        case 3: EnableButton(btnChangeRunPos1, !bEnable); break;
        case 4: EnableButton(btnChangeRunPos2, !bEnable); break;
      }
    }
    private void ControlsEnabled(GroupBox groupBox, Control activeControl, bool enable)
    {
      foreach (Control ctrl in groupBox.Controls)
      {
        if (ctrl is TableLayoutPanel)
        {
          TableLayoutPanel tbl = ctrl as TableLayoutPanel;
          foreach (Control c in tbl.Controls)
          {
            if (c != activeControl)
              c.Enabled = enable;
          }
        }
      }
    }
    private void RefreshShowPoint()
    {
      if (chkShowPoints.Checked == true)
      {
        mCurrentSystem.GetManualAlignSettings().ShowPoint = false;
        mCurrentSystem.GetManualAlignSettings().ShowPoint = true;
      }
    }


  }
}
