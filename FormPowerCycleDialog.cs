using System;
using System.Windows.Forms;
using System.Threading;         // for CancellationTokenSource

namespace SampleApplication
{
  public partial class FormPowerCycleDialog : Form
  {
    CancellationTokenSource mCancelToken = null;

    public FormPowerCycleDialog(CancellationTokenSource cancelToken)
    {
      InitializeComponent();
      mCancelToken = cancelToken;
    }

    private void btn_DonePowerCycle_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_CancelPowerCycle_Click(object sender, EventArgs e)
    {
      mCancelToken.Cancel();
      this.Close();
    }
  }
}
