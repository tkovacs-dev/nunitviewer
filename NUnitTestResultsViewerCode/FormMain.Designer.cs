namespace NUnitTestResultsViewerCode
{
  partial class FormMain
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormMain ) );
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testCasesTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.detailedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.failuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.invalidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.skippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ignoredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inconclusiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.successToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.trvResults = new System.Windows.Forms.TreeView();
      this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip( this.components );
      this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolstrip = new System.Windows.Forms.StatusStrip();
      this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblFailure = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblerrors = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblInvalid = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLoaded = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripMain = new System.Windows.Forms.ToolStrip();
      this.tsbOpen = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbErrors = new System.Windows.Forms.ToolStripButton();
      this.tsbFailures = new System.Windows.Forms.ToolStripButton();
      this.tsbInvalid = new System.Windows.Forms.ToolStripButton();
      this.tsbSkipped = new System.Windows.Forms.ToolStripButton();
      this.tsbIgnored = new System.Windows.Forms.ToolStripButton();
      this.tsbInconclusive = new System.Windows.Forms.ToolStripButton();
      this.tsbSucceed = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbFind = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbAbout = new System.Windows.Forms.ToolStripButton();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.menuStrip1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.cmsTreeView.SuspendLayout();
      this.toolstrip.SuspendLayout();
      this.toolStripMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem} );
      this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size( 864, 24 );
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem} );
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size( 35, 20 );
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.open;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
      this.openToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
      this.openToolStripMenuItem.Text = "&Open..";
      this.openToolStripMenuItem.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.testCasesTreeToolStripMenuItem,
            this.detailedInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.itemsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.findToolStripMenuItem} );
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size( 41, 20 );
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // testCasesTreeToolStripMenuItem
      // 
      this.testCasesTreeToolStripMenuItem.Checked = true;
      this.testCasesTreeToolStripMenuItem.CheckOnClick = true;
      this.testCasesTreeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.testCasesTreeToolStripMenuItem.Name = "testCasesTreeToolStripMenuItem";
      this.testCasesTreeToolStripMenuItem.Size = new System.Drawing.Size( 172, 22 );
      this.testCasesTreeToolStripMenuItem.Text = "&Test Case\'s Tree";
      this.testCasesTreeToolStripMenuItem.Click += new System.EventHandler( this.testCasesTreeToolStripMenuItem_Click );
      // 
      // detailedInformationToolStripMenuItem
      // 
      this.detailedInformationToolStripMenuItem.Checked = true;
      this.detailedInformationToolStripMenuItem.CheckOnClick = true;
      this.detailedInformationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.detailedInformationToolStripMenuItem.Name = "detailedInformationToolStripMenuItem";
      this.detailedInformationToolStripMenuItem.Size = new System.Drawing.Size( 172, 22 );
      this.detailedInformationToolStripMenuItem.Text = "&Detailed Information";
      this.detailedInformationToolStripMenuItem.Click += new System.EventHandler( this.detailedInformationToolStripMenuItem_Click );
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size( 169, 6 );
      // 
      // itemsToolStripMenuItem
      // 
      this.itemsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.errorsToolStripMenuItem,
            this.failuresToolStripMenuItem,
            this.invalidToolStripMenuItem,
            this.skippedToolStripMenuItem,
            this.ignoredToolStripMenuItem,
            this.inconclusiveToolStripMenuItem,
            this.successToolStripMenuItem} );
      this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
      this.itemsToolStripMenuItem.Size = new System.Drawing.Size( 172, 22 );
      this.itemsToolStripMenuItem.Text = "&Items";
      // 
      // errorsToolStripMenuItem
      // 
      this.errorsToolStripMenuItem.Checked = true;
      this.errorsToolStripMenuItem.CheckOnClick = true;
      this.errorsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.errorsToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
      this.errorsToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1 ) ) );
      this.errorsToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.errorsToolStripMenuItem.Text = "&Errors";
      this.errorsToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // failuresToolStripMenuItem
      // 
      this.failuresToolStripMenuItem.Checked = true;
      this.failuresToolStripMenuItem.CheckOnClick = true;
      this.failuresToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.failuresToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.failuresToolStripMenuItem.Name = "failuresToolStripMenuItem";
      this.failuresToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2 ) ) );
      this.failuresToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.failuresToolStripMenuItem.Text = "&Failures";
      this.failuresToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // invalidToolStripMenuItem
      // 
      this.invalidToolStripMenuItem.Checked = true;
      this.invalidToolStripMenuItem.CheckOnClick = true;
      this.invalidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.invalidToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.invalidToolStripMenuItem.Name = "invalidToolStripMenuItem";
      this.invalidToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3 ) ) );
      this.invalidToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.invalidToolStripMenuItem.Text = "&Invalid";
      this.invalidToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // skippedToolStripMenuItem
      // 
      this.skippedToolStripMenuItem.Checked = true;
      this.skippedToolStripMenuItem.CheckOnClick = true;
      this.skippedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.skippedToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_orange;
      this.skippedToolStripMenuItem.Name = "skippedToolStripMenuItem";
      this.skippedToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4 ) ) );
      this.skippedToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.skippedToolStripMenuItem.Text = "&Skipped";
      this.skippedToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // ignoredToolStripMenuItem
      // 
      this.ignoredToolStripMenuItem.Checked = true;
      this.ignoredToolStripMenuItem.CheckOnClick = true;
      this.ignoredToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ignoredToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_orange;
      this.ignoredToolStripMenuItem.Name = "ignoredToolStripMenuItem";
      this.ignoredToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5 ) ) );
      this.ignoredToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.ignoredToolStripMenuItem.Text = "Ig&nored";
      this.ignoredToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // inconclusiveToolStripMenuItem
      // 
      this.inconclusiveToolStripMenuItem.Checked = true;
      this.inconclusiveToolStripMenuItem.CheckOnClick = true;
      this.inconclusiveToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.inconclusiveToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_blue;
      this.inconclusiveToolStripMenuItem.Name = "inconclusiveToolStripMenuItem";
      this.inconclusiveToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6 ) ) );
      this.inconclusiveToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.inconclusiveToolStripMenuItem.Text = "In&conclusive";
      this.inconclusiveToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // successToolStripMenuItem
      // 
      this.successToolStripMenuItem.Checked = true;
      this.successToolStripMenuItem.CheckOnClick = true;
      this.successToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.successToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_green;
      this.successToolStripMenuItem.Name = "successToolStripMenuItem";
      this.successToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7 ) ) );
      this.successToolStripMenuItem.Size = new System.Drawing.Size( 171, 22 );
      this.successToolStripMenuItem.Text = "&Success";
      this.successToolStripMenuItem.CheckedChanged += new System.EventHandler( this.errorsToolStripMenuItem_CheckedChanged );
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size( 169, 6 );
      // 
      // findToolStripMenuItem
      // 
      this.findToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.find;
      this.findToolStripMenuItem.Name = "findToolStripMenuItem";
      this.findToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F ) ) );
      this.findToolStripMenuItem.Size = new System.Drawing.Size( 172, 22 );
      this.findToolStripMenuItem.Text = "&Find...";
      this.findToolStripMenuItem.Click += new System.EventHandler( this.findToolStripMenuItem_Click );
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem} );
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size( 40, 20 );
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Image = global::NUnitTestResultsViewerCode.Properties.Resources.Information;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler( this.aboutToolStripMenuItem_Click );
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                  | System.Windows.Forms.AnchorStyles.Left )
                  | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.Location = new System.Drawing.Point( 0, 52 );
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add( this.trvResults );
      this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding( 3, 0, 0, 0 );
      this.splitContainer1.Size = new System.Drawing.Size( 864, 361 );
      this.splitContainer1.SplitterDistance = 469;
      this.splitContainer1.TabIndex = 3;
      // 
      // trvResults
      // 
      this.trvResults.ContextMenuStrip = this.cmsTreeView;
      this.trvResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trvResults.HideSelection = false;
      this.trvResults.Indent = 16;
      this.trvResults.ItemHeight = 18;
      this.trvResults.Location = new System.Drawing.Point( 3, 0 );
      this.trvResults.Name = "trvResults";
      this.trvResults.ShowNodeToolTips = true;
      this.trvResults.Size = new System.Drawing.Size( 466, 361 );
      this.trvResults.TabIndex = 0;
      this.trvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.trvResults_AfterSelect );
      // 
      // cmsTreeView
      // 
      this.cmsTreeView.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.cmsTreeView.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.collapseAllToolStripMenuItem,
            this.expandAllToolStripMenuItem} );
      this.cmsTreeView.Name = "cmsTreeView";
      this.cmsTreeView.Size = new System.Drawing.Size( 129, 48 );
      // 
      // collapseAllToolStripMenuItem
      // 
      this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
      this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
      this.collapseAllToolStripMenuItem.Text = "Collapse All";
      this.collapseAllToolStripMenuItem.Click += new System.EventHandler( this.collapseAllToolStripMenuItem_Click );
      // 
      // expandAllToolStripMenuItem
      // 
      this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
      this.expandAllToolStripMenuItem.Size = new System.Drawing.Size( 128, 22 );
      this.expandAllToolStripMenuItem.Text = "Expand All";
      this.expandAllToolStripMenuItem.Click += new System.EventHandler( this.expandAllToolStripMenuItem_Click );
      // 
      // toolstrip
      // 
      this.toolstrip.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.toolstrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.lblTotal,
            this.lblFailure,
            this.lblerrors,
            this.lblInvalid,
            this.lblLoaded} );
      this.toolstrip.Location = new System.Drawing.Point( 0, 416 );
      this.toolstrip.Name = "toolstrip";
      this.toolstrip.Size = new System.Drawing.Size( 864, 22 );
      this.toolstrip.TabIndex = 4;
      this.toolstrip.Text = "statusStrip1";
      // 
      // lblTotal
      // 
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size( 31, 17 );
      this.lblTotal.Text = "Total";
      // 
      // lblFailure
      // 
      this.lblFailure.Name = "lblFailure";
      this.lblFailure.Size = new System.Drawing.Size( 39, 17 );
      this.lblFailure.Text = "Failure";
      // 
      // lblerrors
      // 
      this.lblerrors.Name = "lblerrors";
      this.lblerrors.Size = new System.Drawing.Size( 36, 17 );
      this.lblerrors.Text = "Errors";
      // 
      // lblInvalid
      // 
      this.lblInvalid.Name = "lblInvalid";
      this.lblInvalid.Size = new System.Drawing.Size( 39, 17 );
      this.lblInvalid.Text = "Invalid";
      // 
      // lblLoaded
      // 
      this.lblLoaded.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblLoaded.Name = "lblLoaded";
      this.lblLoaded.Size = new System.Drawing.Size( 704, 17 );
      this.lblLoaded.Spring = true;
      this.lblLoaded.Text = "Location";
      this.lblLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // toolStripMain
      // 
      this.toolStripMain.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.toolStripMain.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbErrors,
            this.tsbFailures,
            this.tsbInvalid,
            this.tsbSkipped,
            this.tsbIgnored,
            this.tsbInconclusive,
            this.tsbSucceed,
            this.toolStripSeparator2,
            this.tsbFind,
            this.toolStripSeparator3,
            this.tsbAbout} );
      this.toolStripMain.Location = new System.Drawing.Point( 0, 24 );
      this.toolStripMain.Name = "toolStripMain";
      this.toolStripMain.Size = new System.Drawing.Size( 864, 25 );
      this.toolStripMain.TabIndex = 5;
      // 
      // tsbOpen
      // 
      this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbOpen.Image = global::NUnitTestResultsViewerCode.Properties.Resources.open;
      this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbOpen.Name = "tsbOpen";
      this.tsbOpen.Size = new System.Drawing.Size( 23, 22 );
      this.tsbOpen.Text = "Open...";
      this.tsbOpen.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size( 6, 25 );
      // 
      // tsbErrors
      // 
      this.tsbErrors.Checked = true;
      this.tsbErrors.CheckOnClick = true;
      this.tsbErrors.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbErrors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbErrors.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.tsbErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbErrors.Name = "tsbErrors";
      this.tsbErrors.Size = new System.Drawing.Size( 23, 22 );
      this.tsbErrors.Text = "Errors";
      this.tsbErrors.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbFailures
      // 
      this.tsbFailures.Checked = true;
      this.tsbFailures.CheckOnClick = true;
      this.tsbFailures.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbFailures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbFailures.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.tsbFailures.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFailures.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbFailures.Name = "tsbFailures";
      this.tsbFailures.Size = new System.Drawing.Size( 23, 22 );
      this.tsbFailures.Text = "Failures";
      this.tsbFailures.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbInvalid
      // 
      this.tsbInvalid.Checked = true;
      this.tsbInvalid.CheckOnClick = true;
      this.tsbInvalid.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbInvalid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbInvalid.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_red;
      this.tsbInvalid.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbInvalid.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbInvalid.Name = "tsbInvalid";
      this.tsbInvalid.Size = new System.Drawing.Size( 23, 22 );
      this.tsbInvalid.Text = "Invalid";
      this.tsbInvalid.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbSkipped
      // 
      this.tsbSkipped.Checked = true;
      this.tsbSkipped.CheckOnClick = true;
      this.tsbSkipped.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbSkipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSkipped.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_orange;
      this.tsbSkipped.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSkipped.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbSkipped.Name = "tsbSkipped";
      this.tsbSkipped.Size = new System.Drawing.Size( 23, 22 );
      this.tsbSkipped.Text = "Skipped";
      this.tsbSkipped.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbIgnored
      // 
      this.tsbIgnored.Checked = true;
      this.tsbIgnored.CheckOnClick = true;
      this.tsbIgnored.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbIgnored.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbIgnored.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_orange;
      this.tsbIgnored.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbIgnored.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbIgnored.Name = "tsbIgnored";
      this.tsbIgnored.Size = new System.Drawing.Size( 23, 22 );
      this.tsbIgnored.Text = "Ignored";
      this.tsbIgnored.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbInconclusive
      // 
      this.tsbInconclusive.Checked = true;
      this.tsbInconclusive.CheckOnClick = true;
      this.tsbInconclusive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbInconclusive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbInconclusive.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_blue;
      this.tsbInconclusive.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbInconclusive.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbInconclusive.Name = "tsbInconclusive";
      this.tsbInconclusive.Size = new System.Drawing.Size( 23, 22 );
      this.tsbInconclusive.Text = "Inconclusive";
      this.tsbInconclusive.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // tsbSucceed
      // 
      this.tsbSucceed.Checked = true;
      this.tsbSucceed.CheckOnClick = true;
      this.tsbSucceed.CheckState = System.Windows.Forms.CheckState.Checked;
      this.tsbSucceed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbSucceed.Image = global::NUnitTestResultsViewerCode.Properties.Resources.circle_green;
      this.tsbSucceed.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbSucceed.Margin = new System.Windows.Forms.Padding( 1, 1, 0, 2 );
      this.tsbSucceed.Name = "tsbSucceed";
      this.tsbSucceed.Size = new System.Drawing.Size( 23, 22 );
      this.tsbSucceed.Text = "Success";
      this.tsbSucceed.CheckedChanged += new System.EventHandler( this.tsbErrors_CheckedChanged );
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size( 6, 25 );
      // 
      // tsbFind
      // 
      this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbFind.Image = global::NUnitTestResultsViewerCode.Properties.Resources.find;
      this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFind.Name = "tsbFind";
      this.tsbFind.Size = new System.Drawing.Size( 23, 22 );
      this.tsbFind.Text = "Find";
      this.tsbFind.Click += new System.EventHandler( this.findToolStripMenuItem_Click );
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size( 6, 25 );
      // 
      // tsbAbout
      // 
      this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbAbout.Image = global::NUnitTestResultsViewerCode.Properties.Resources.Information;
      this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAbout.Name = "tsbAbout";
      this.tsbAbout.Size = new System.Drawing.Size( 23, 22 );
      this.tsbAbout.Text = "About..";
      this.tsbAbout.Click += new System.EventHandler( this.aboutToolStripMenuItem_Click );
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X ) ) );
      this.exitToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
      this.exitToolStripMenuItem.Text = "&Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size( 149, 6 );
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 864, 438 );
      this.Controls.Add( this.toolStripMain );
      this.Controls.Add( this.toolstrip );
      this.Controls.Add( this.splitContainer1 );
      this.Controls.Add( this.menuStrip1 );
      this.Font = new System.Drawing.Font( "Tahoma", 8.25F );
      this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NUnit Test Results Viewer";
      this.Load += new System.EventHandler( this.FormMain_Load );
      this.menuStrip1.ResumeLayout( false );
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout( false );
      this.splitContainer1.ResumeLayout( false );
      this.cmsTreeView.ResumeLayout( false );
      this.toolstrip.ResumeLayout( false );
      this.toolstrip.PerformLayout();
      this.toolStripMain.ResumeLayout( false );
      this.toolStripMain.PerformLayout();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView trvResults;
    private System.Windows.Forms.ToolStripMenuItem detailedInformationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem testCasesTreeToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip cmsTreeView;
    private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
    private System.Windows.Forms.StatusStrip toolstrip;
    private System.Windows.Forms.ToolStripStatusLabel lblLoaded;
    private System.Windows.Forms.ToolStripStatusLabel lblTotal;
    private System.Windows.Forms.ToolStripStatusLabel lblerrors;
    private System.Windows.Forms.ToolStripStatusLabel lblFailure;
    private System.Windows.Forms.ToolStripStatusLabel lblInvalid;
    private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem failuresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem invalidToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inconclusiveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem skippedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem successToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ignoredToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStripMain;
    private System.Windows.Forms.ToolStripButton tsbOpen;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbErrors;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tsbAbout;
    private System.Windows.Forms.ToolStripButton tsbInvalid;
    private System.Windows.Forms.ToolStripButton tsbFailures;
    private System.Windows.Forms.ToolStripButton tsbSkipped;
    private System.Windows.Forms.ToolStripButton tsbIgnored;
    private System.Windows.Forms.ToolStripButton tsbInconclusive;
    private System.Windows.Forms.ToolStripButton tsbSucceed;
    private System.Windows.Forms.ToolStripButton tsbFind;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}