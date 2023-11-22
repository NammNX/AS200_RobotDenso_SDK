namespace SampleApplication
{
    partial class FormPowerCycleDialog
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
      this.btn_DonePowerCycle = new System.Windows.Forms.Button();
      this.btn_CancelPowerCycle = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(33, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(291, 41);
      this.label1.TabIndex = 0;
      this.label1.Text = "Manually power cycle the camera then click one of the botton below.";
      // 
      // btn_DonePowerCycle
      // 
      this.btn_DonePowerCycle.Location = new System.Drawing.Point(12, 82);
      this.btn_DonePowerCycle.Name = "btn_DonePowerCycle";
      this.btn_DonePowerCycle.Size = new System.Drawing.Size(156, 43);
      this.btn_DonePowerCycle.TabIndex = 1;
      this.btn_DonePowerCycle.Text = "Power Cycle is done. (HMI waits until system is up.)";
      this.btn_DonePowerCycle.UseVisualStyleBackColor = true;
      this.btn_DonePowerCycle.Click += new System.EventHandler(this.btn_DonePowerCycle_Click);
      // 
      // btn_CancelPowerCycle
      // 
      this.btn_CancelPowerCycle.Location = new System.Drawing.Point(192, 82);
      this.btn_CancelPowerCycle.Name = "btn_CancelPowerCycle";
      this.btn_CancelPowerCycle.Size = new System.Drawing.Size(141, 43);
      this.btn_CancelPowerCycle.TabIndex = 2;
      this.btn_CancelPowerCycle.Text = "Power Cycle is done but not wait for system up.";
      this.btn_CancelPowerCycle.UseVisualStyleBackColor = true;
      this.btn_CancelPowerCycle.Click += new System.EventHandler(this.btn_CancelPowerCycle_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(345, 139);
      this.Controls.Add(this.btn_CancelPowerCycle);
      this.Controls.Add(this.btn_DonePowerCycle);
      this.Controls.Add(this.label1);
      this.Name = "Form2";
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DonePowerCycle;
        private System.Windows.Forms.Button btn_CancelPowerCycle;
    }
}