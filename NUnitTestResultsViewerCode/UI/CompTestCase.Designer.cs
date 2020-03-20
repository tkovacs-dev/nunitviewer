namespace NUnitTestResultsViewerCode.UI
{
  partial class CompTestCase
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabStackTrace = new System.Windows.Forms.TabPage();
            this.txtStackTrace = new System.Windows.Forms.TextBox();
            this.compTestResult = new NUnitTestResultsViewerCode.UI.CompTestResult();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabMessage.SuspendLayout();
            this.tabStackTrace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabMessage);
            this.tabControl.Controls.Add(this.tabStackTrace);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(447, 326);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.compTestResult);
            this.tabGeneral.Location = new System.Drawing.Point(4, 4);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(439, 300);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.txtMessage);
            this.tabMessage.Location = new System.Drawing.Point(4, 4);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Size = new System.Drawing.Size(439, 300);
            this.tabMessage.TabIndex = 1;
            this.tabMessage.Text = "Message";
            this.tabMessage.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(439, 300);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.WordWrap = false;
            // 
            // tabStackTrace
            // 
            this.tabStackTrace.Controls.Add(this.txtStackTrace);
            this.tabStackTrace.Location = new System.Drawing.Point(4, 4);
            this.tabStackTrace.Name = "tabStackTrace";
            this.tabStackTrace.Size = new System.Drawing.Size(439, 300);
            this.tabStackTrace.TabIndex = 2;
            this.tabStackTrace.Text = "Stack Trace";
            this.tabStackTrace.UseVisualStyleBackColor = true;
            // 
            // txtStackTrace
            // 
            this.txtStackTrace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStackTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStackTrace.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStackTrace.Location = new System.Drawing.Point(0, 0);
            this.txtStackTrace.Margin = new System.Windows.Forms.Padding(0);
            this.txtStackTrace.Multiline = true;
            this.txtStackTrace.Name = "txtStackTrace";
            this.txtStackTrace.ReadOnly = true;
            this.txtStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStackTrace.Size = new System.Drawing.Size(439, 300);
            this.txtStackTrace.TabIndex = 1;
            this.txtStackTrace.WordWrap = false;
            // 
            // compTestResult
            // 
            this.compTestResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compTestResult.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.compTestResult.Location = new System.Drawing.Point(0, 0);
            this.compTestResult.Name = "compTestResult";
            this.compTestResult.Size = new System.Drawing.Size(439, 300);
            this.compTestResult.TabIndex = 0;
            // 
            // CompTestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "CompTestCase";
            this.Size = new System.Drawing.Size(447, 326);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabMessage.ResumeLayout(false);
            this.tabMessage.PerformLayout();
            this.tabStackTrace.ResumeLayout(false);
            this.tabStackTrace.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabGeneral;
    private System.Windows.Forms.TabPage tabMessage;
    private System.Windows.Forms.TabPage tabStackTrace;
    private CompTestResult compTestResult;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.TextBox txtStackTrace;
  }
}
