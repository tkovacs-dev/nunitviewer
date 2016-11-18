namespace NUnitTestResultsViewerCode.UI
{
  partial class FormFind
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
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtSearchFor = new System.Windows.Forms.TextBox();
      this.btnFindNext = new System.Windows.Forms.Button();
      this.chkMatchCase = new System.Windows.Forms.CheckBox();
      this.chkWholeWord = new System.Windows.Forms.CheckBox();
      this.btnHightlight = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point( 12, 20 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 62, 13 );
      this.label1.TabIndex = 0;
      this.label1.Text = "Test &Name:";
      // 
      // txtSearchFor
      // 
      this.txtSearchFor.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                  | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.txtSearchFor.Location = new System.Drawing.Point( 80, 17 );
      this.txtSearchFor.Name = "txtSearchFor";
      this.txtSearchFor.Size = new System.Drawing.Size( 316, 21 );
      this.txtSearchFor.TabIndex = 1;
      this.txtSearchFor.TextChanged += new System.EventHandler( this.txtSearchFor_TextChanged );
      this.txtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler( this.txtSearchFor_KeyDown );
      // 
      // btnFindNext
      // 
      this.btnFindNext.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.btnFindNext.Location = new System.Drawing.Point( 311, 119 );
      this.btnFindNext.Name = "btnFindNext";
      this.btnFindNext.Size = new System.Drawing.Size( 85, 23 );
      this.btnFindNext.TabIndex = 4;
      this.btnFindNext.Text = "&Find Next";
      this.btnFindNext.UseVisualStyleBackColor = true;
      this.btnFindNext.Click += new System.EventHandler( this.btnFindNext_Click );
      // 
      // chkMatchCase
      // 
      this.chkMatchCase.AutoSize = true;
      this.chkMatchCase.Location = new System.Drawing.Point( 15, 58 );
      this.chkMatchCase.Name = "chkMatchCase";
      this.chkMatchCase.Size = new System.Drawing.Size( 82, 17 );
      this.chkMatchCase.TabIndex = 2;
      this.chkMatchCase.Text = "Match &Case";
      this.chkMatchCase.UseVisualStyleBackColor = true;
      this.chkMatchCase.CheckedChanged += new System.EventHandler( this.chkMatchCase_CheckedChanged );
      // 
      // chkWholeWord
      // 
      this.chkWholeWord.AutoSize = true;
      this.chkWholeWord.Location = new System.Drawing.Point( 15, 81 );
      this.chkWholeWord.Name = "chkWholeWord";
      this.chkWholeWord.Size = new System.Drawing.Size( 142, 17 );
      this.chkWholeWord.TabIndex = 3;
      this.chkWholeWord.Text = "Match &Whole Test Name";
      this.chkWholeWord.UseVisualStyleBackColor = true;
      this.chkWholeWord.CheckedChanged += new System.EventHandler( this.chkWholeWord_CheckedChanged );
      // 
      // btnHightlight
      // 
      this.btnHightlight.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.btnHightlight.Location = new System.Drawing.Point( 12, 119 );
      this.btnHightlight.Name = "btnHightlight";
      this.btnHightlight.Size = new System.Drawing.Size( 85, 23 );
      this.btnHightlight.TabIndex = 5;
      this.btnHightlight.Text = "&Highlight All";
      this.btnHightlight.UseVisualStyleBackColor = true;
      this.btnHightlight.Click += new System.EventHandler( this.btnHightlight_Click );
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.btnClear.Location = new System.Drawing.Point( 103, 119 );
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size( 85, 23 );
      this.btnClear.TabIndex = 6;
      this.btnClear.Text = "C&lear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler( this.btnClear_Click );
      // 
      // FormFind
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 408, 154 );
      this.Controls.Add( this.btnClear );
      this.Controls.Add( this.btnHightlight );
      this.Controls.Add( this.chkWholeWord );
      this.Controls.Add( this.chkMatchCase );
      this.Controls.Add( this.btnFindNext );
      this.Controls.Add( this.txtSearchFor );
      this.Controls.Add( this.label1 );
      this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormFind";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Find Test";
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSearchFor;
    private System.Windows.Forms.Button btnFindNext;
    private System.Windows.Forms.CheckBox chkMatchCase;
    private System.Windows.Forms.CheckBox chkWholeWord;
    private System.Windows.Forms.Button btnHightlight;
    private System.Windows.Forms.Button btnClear;
  }
}