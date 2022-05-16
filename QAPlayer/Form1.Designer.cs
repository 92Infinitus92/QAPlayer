namespace QAPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.listFile = new System.Windows.Forms.ListBox();
            this.btnAddFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnNowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnHelp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeftNavbar = new System.Windows.Forms.Panel();
            this.slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnBackward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trbPlaySpeed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTime2 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.volumeControl2 = new QAPlayer.VolumeControl();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLeftNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPlaySpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = false;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuLabel1.Location = new System.Drawing.Point(47, 88);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(136, 31);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Galaxy Player";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // listFile
            // 
            this.listFile.BackColor = System.Drawing.Color.Black;
            this.listFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(499, 78);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(183, 13);
            this.listFile.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.listFile, "");
            this.bunifuToolTip1.SetToolTipIcon(this.listFile, null);
            this.bunifuToolTip1.SetToolTipTitle(this.listFile, "");
            this.listFile.Visible = false;
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.AllowAnimations = true;
            this.btnAddFiles.AllowMouseEffects = true;
            this.btnAddFiles.AllowToggling = false;
            this.btnAddFiles.AnimationSpeed = 200;
            this.btnAddFiles.AutoGenerateColors = false;
            this.btnAddFiles.AutoRoundBorders = false;
            this.btnAddFiles.AutoSizeLeftIcon = true;
            this.btnAddFiles.AutoSizeRightIcon = true;
            this.btnAddFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFiles.BackgroundImage")));
            this.btnAddFiles.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.ButtonText = "ADD FILES";
            this.btnAddFiles.ButtonTextMarginLeft = 0;
            this.btnAddFiles.ColorContrastOnClick = 45;
            this.btnAddFiles.ColorContrastOnHover = 45;
            this.btnAddFiles.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddFiles.CustomizableEdges = borderEdges1;
            this.btnAddFiles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddFiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFiles.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddFiles.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddFiles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFiles.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.IconLeft = null;
            this.btnAddFiles.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFiles.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddFiles.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddFiles.IconMarginLeft = 11;
            this.btnAddFiles.IconPadding = 10;
            this.btnAddFiles.IconRight = null;
            this.btnAddFiles.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFiles.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddFiles.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddFiles.IconSize = 25;
            this.btnAddFiles.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddFiles.IdleBorderRadius = 0;
            this.btnAddFiles.IdleBorderThickness = 0;
            this.btnAddFiles.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddFiles.IdleIconLeftImage = null;
            this.btnAddFiles.IdleIconRightImage = null;
            this.btnAddFiles.IndicateFocus = false;
            this.btnAddFiles.Location = new System.Drawing.Point(232, 64);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFiles.OnDisabledState.BorderRadius = 1;
            this.btnAddFiles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnDisabledState.BorderThickness = 1;
            this.btnAddFiles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddFiles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddFiles.OnDisabledState.IconLeftImage = null;
            this.btnAddFiles.OnDisabledState.IconRightImage = null;
            this.btnAddFiles.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.onHoverState.BorderRadius = 1;
            this.btnAddFiles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.onHoverState.BorderThickness = 1;
            this.btnAddFiles.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnAddFiles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddFiles.onHoverState.IconLeftImage = null;
            this.btnAddFiles.onHoverState.IconRightImage = null;
            this.btnAddFiles.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.OnIdleState.BorderRadius = 1;
            this.btnAddFiles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnIdleState.BorderThickness = 1;
            this.btnAddFiles.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.OnIdleState.IconLeftImage = null;
            this.btnAddFiles.OnIdleState.IconRightImage = null;
            this.btnAddFiles.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddFiles.OnPressedState.BorderRadius = 1;
            this.btnAddFiles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnPressedState.BorderThickness = 1;
            this.btnAddFiles.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.btnAddFiles.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddFiles.OnPressedState.IconLeftImage = null;
            this.btnAddFiles.OnPressedState.IconRightImage = null;
            this.btnAddFiles.Size = new System.Drawing.Size(150, 39);
            this.btnAddFiles.TabIndex = 11;
            this.btnAddFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFiles.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddFiles.TextMarginLeft = 0;
            this.btnAddFiles.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnAddFiles, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAddFiles, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAddFiles, "");
            this.btnAddFiles.UseDefaultRadiusAndThickness = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoEllipsis = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(175, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(31, 17);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTime, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTime, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTime, "");
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AllowParentOverrides = false;
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.AutoEllipsis = false;
            this.lblTotalTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalTime.Location = new System.Drawing.Point(514, 25);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalTime.Size = new System.Drawing.Size(31, 17);
            this.lblTotalTime.TabIndex = 12;
            this.lblTotalTime.Text = "00:00";
            this.lblTotalTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTotalTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblTotalTime, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTotalTime, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTotalTime, "");
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(235, 166);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(830, 297);
            this.player.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.player, "");
            this.bunifuToolTip1.SetToolTipIcon(this.player, null);
            this.bunifuToolTip1.SetToolTipTitle(this.player, "");
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowBuffering = false;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.AllowZooming = true;
            this.btnMinimize.AllowZoomingOnFocus = false;
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 20;
            this.btnMinimize.ImageSize = new System.Drawing.Size(29, 28);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(49, 48);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(742, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.btnMinimize, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMinimize, null);
            this.btnMinimize.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnMinimize, "");
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(29, 28);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(49, 48);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(784, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.btnClose.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.bunifuLabel3);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(232, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(833, 58);
            this.panelHeader.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panelHeader, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelHeader, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelHeader, "");
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "File";
            this.bunifuToolTip1.SetToolTip(this.lblTitle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTitle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTitle, "");
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(3, 37);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(69, 15);
            this.bunifuLabel3.TabIndex = 9;
            this.bunifuLabel3.Text = "bunifuLabel3";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel3, "");
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuLabel2.Location = new System.Drawing.Point(10, 12);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(40, 31);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "File:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.AllowAnimations = true;
            this.btnNowPlaying.AllowMouseEffects = true;
            this.btnNowPlaying.AllowToggling = true;
            this.btnNowPlaying.AnimationSpeed = 200;
            this.btnNowPlaying.AutoGenerateColors = false;
            this.btnNowPlaying.AutoRoundBorders = false;
            this.btnNowPlaying.AutoSizeLeftIcon = true;
            this.btnNowPlaying.AutoSizeRightIcon = true;
            this.btnNowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNowPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNowPlaying.BackgroundImage")));
            this.btnNowPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.ButtonText = "Now Playing...";
            this.btnNowPlaying.ButtonTextMarginLeft = 0;
            this.btnNowPlaying.ColorContrastOnClick = 45;
            this.btnNowPlaying.ColorContrastOnHover = 45;
            this.btnNowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnNowPlaying.CustomizableEdges = borderEdges4;
            this.btnNowPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNowPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNowPlaying.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNowPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNowPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNowPlaying.ForeColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.IconLeft = null;
            this.btnNowPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNowPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNowPlaying.IconMarginLeft = 11;
            this.btnNowPlaying.IconPadding = 10;
            this.btnNowPlaying.IconRight = null;
            this.btnNowPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNowPlaying.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNowPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNowPlaying.IconSize = 25;
            this.btnNowPlaying.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.IdleBorderRadius = 0;
            this.btnNowPlaying.IdleBorderThickness = 0;
            this.btnNowPlaying.IdleFillColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.IdleIconLeftImage = null;
            this.btnNowPlaying.IdleIconRightImage = null;
            this.btnNowPlaying.IndicateFocus = true;
            this.btnNowPlaying.Location = new System.Drawing.Point(12, 140);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnDisabledState.BorderRadius = 1;
            this.btnNowPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnDisabledState.BorderThickness = 1;
            this.btnNowPlaying.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnDisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnDisabledState.IconLeftImage = null;
            this.btnNowPlaying.OnDisabledState.IconRightImage = null;
            this.btnNowPlaying.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.onHoverState.BorderRadius = 1;
            this.btnNowPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.onHoverState.BorderThickness = 1;
            this.btnNowPlaying.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnNowPlaying.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNowPlaying.onHoverState.IconLeftImage = null;
            this.btnNowPlaying.onHoverState.IconRightImage = null;
            this.btnNowPlaying.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.BorderRadius = 1;
            this.btnNowPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnIdleState.BorderThickness = 1;
            this.btnNowPlaying.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.IconLeftImage = null;
            this.btnNowPlaying.OnIdleState.IconRightImage = null;
            this.btnNowPlaying.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnPressedState.BorderRadius = 1;
            this.btnNowPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnPressedState.BorderThickness = 1;
            this.btnNowPlaying.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.btnNowPlaying.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNowPlaying.OnPressedState.IconLeftImage = null;
            this.btnNowPlaying.OnPressedState.IconRightImage = null;
            this.btnNowPlaying.Size = new System.Drawing.Size(214, 43);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNowPlaying.TextMarginLeft = 0;
            this.btnNowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnNowPlaying, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnNowPlaying, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnNowPlaying, "");
            this.btnNowPlaying.UseDefaultRadiusAndThickness = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.AutoGenerateColors = false;
            this.btnSettings.AutoRoundBorders = false;
            this.btnSettings.AutoSizeLeftIcon = true;
            this.btnSettings.AutoSizeRightIcon = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.ColorContrastOnClick = 45;
            this.btnSettings.ColorContrastOnHover = 45;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges3;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSettings.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSettings.IconLeft = null;
            this.btnSettings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSettings.IconMarginLeft = 11;
            this.btnSettings.IconPadding = 10;
            this.btnSettings.IconRight = null;
            this.btnSettings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSettings.IconSize = 25;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleBorderRadius = 0;
            this.btnSettings.IdleBorderThickness = 0;
            this.btnSettings.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSettings.IdleIconLeftImage = null;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.IndicateFocus = true;
            this.btnSettings.Location = new System.Drawing.Point(54, 449);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSettings.OnDisabledState.BorderRadius = 1;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.Red;
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSettings.onHoverState.BorderRadius = 1;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnIdleState.BorderRadius = 1;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSettings.OnIdleState.IconLeftImage = null;
            this.btnSettings.OnIdleState.IconRightImage = null;
            this.btnSettings.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.OnPressedState.BorderRadius = 1;
            this.btnSettings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnPressedState.BorderThickness = 1;
            this.btnSettings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSettings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnPressedState.IconLeftImage = null;
            this.btnSettings.OnPressedState.IconRightImage = null;
            this.btnSettings.Size = new System.Drawing.Size(74, 43);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.TextMarginLeft = 0;
            this.btnSettings.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnSettings, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSettings, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSettings, "");
            this.btnSettings.UseDefaultRadiusAndThickness = true;
            this.btnSettings.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.AllowAnimations = true;
            this.btnHelp.AllowMouseEffects = true;
            this.btnHelp.AllowToggling = false;
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.AnimationSpeed = 200;
            this.btnHelp.AutoGenerateColors = false;
            this.btnHelp.AutoRoundBorders = false;
            this.btnHelp.AutoSizeLeftIcon = true;
            this.btnHelp.AutoSizeRightIcon = true;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.ButtonText = "Help";
            this.btnHelp.ButtonTextMarginLeft = 0;
            this.btnHelp.ColorContrastOnClick = 45;
            this.btnHelp.ColorContrastOnHover = 45;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnHelp.CustomizableEdges = borderEdges2;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHelp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHelp.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnHelp.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnHelp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.IconLeft = null;
            this.btnHelp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHelp.IconMarginLeft = 11;
            this.btnHelp.IconPadding = 10;
            this.btnHelp.IconRight = null;
            this.btnHelp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHelp.IconSize = 25;
            this.btnHelp.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnHelp.IdleBorderRadius = 0;
            this.btnHelp.IdleBorderThickness = 0;
            this.btnHelp.IdleFillColor = System.Drawing.Color.Empty;
            this.btnHelp.IdleIconLeftImage = null;
            this.btnHelp.IdleIconRightImage = null;
            this.btnHelp.IndicateFocus = true;
            this.btnHelp.Location = new System.Drawing.Point(12, 492);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHelp.OnDisabledState.BorderRadius = 1;
            this.btnHelp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnDisabledState.BorderThickness = 1;
            this.btnHelp.OnDisabledState.FillColor = System.Drawing.Color.Red;
            this.btnHelp.OnDisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnHelp.OnDisabledState.IconLeftImage = null;
            this.btnHelp.OnDisabledState.IconRightImage = null;
            this.btnHelp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHelp.onHoverState.BorderRadius = 1;
            this.btnHelp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.onHoverState.BorderThickness = 1;
            this.btnHelp.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnHelp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHelp.onHoverState.IconLeftImage = null;
            this.btnHelp.onHoverState.IconRightImage = null;
            this.btnHelp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHelp.OnIdleState.BorderRadius = 1;
            this.btnHelp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnIdleState.BorderThickness = 1;
            this.btnHelp.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnHelp.OnIdleState.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.OnIdleState.IconLeftImage = null;
            this.btnHelp.OnIdleState.IconRightImage = null;
            this.btnHelp.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHelp.OnPressedState.BorderRadius = 1;
            this.btnHelp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnPressedState.BorderThickness = 1;
            this.btnHelp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.btnHelp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHelp.OnPressedState.IconLeftImage = null;
            this.btnHelp.OnPressedState.IconRightImage = null;
            this.btnHelp.Size = new System.Drawing.Size(214, 43);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHelp.TextMarginLeft = 0;
            this.btnHelp.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnHelp, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHelp, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnHelp, "");
            this.btnHelp.UseDefaultRadiusAndThickness = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // panelLeftNavbar
            // 
            this.panelLeftNavbar.BackColor = System.Drawing.Color.Black;
            this.panelLeftNavbar.Controls.Add(this.pictureBox1);
            this.panelLeftNavbar.Controls.Add(this.btnHelp);
            this.panelLeftNavbar.Controls.Add(this.btnSettings);
            this.panelLeftNavbar.Controls.Add(this.btnNowPlaying);
            this.panelLeftNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavbar.ForeColor = System.Drawing.Color.Black;
            this.panelLeftNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftNavbar.Name = "panelLeftNavbar";
            this.panelLeftNavbar.Size = new System.Drawing.Size(232, 547);
            this.panelLeftNavbar.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panelLeftNavbar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelLeftNavbar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelLeftNavbar, "");
            // 
            // slider
            // 
            this.slider.AllowCursorChanges = true;
            this.slider.AllowHomeEndKeysDetection = false;
            this.slider.AllowIncrementalClickMoves = false;
            this.slider.AllowMouseDownEffects = false;
            this.slider.AllowMouseHoverEffects = false;
            this.slider.AllowScrollingAnimations = true;
            this.slider.AllowScrollKeysDetection = true;
            this.slider.AllowScrollOptionsMenu = true;
            this.slider.AllowShrinkingOnFocusLost = false;
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slider.BackgroundImage")));
            this.slider.BindingContainer = null;
            this.slider.BorderRadius = 2;
            this.slider.BorderThickness = 1;
            this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider.DrawThickBorder = false;
            this.slider.DurationBeforeShrink = 2000;
            this.slider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.slider.LargeChange = 10;
            this.slider.Location = new System.Drawing.Point(174, -1);
            this.slider.Maximum = 100;
            this.slider.Minimum = 0;
            this.slider.MinimumSize = new System.Drawing.Size(0, 31);
            this.slider.MinimumThumbLength = 18;
            this.slider.Name = "slider";
            this.slider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.slider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.slider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.slider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.slider.ScrollBarColor = System.Drawing.Color.White;
            this.slider.ShrinkSizeLimit = 3;
            this.slider.Size = new System.Drawing.Size(368, 31);
            this.slider.SliderColor = System.Drawing.Color.White;
            this.slider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.slider.SmallChange = 1;
            this.slider.TabIndex = 0;
            this.slider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.slider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.slider.ThumbLength = 36;
            this.slider.ThumbMargin = 1;
            this.slider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.slider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.slider, "");
            this.bunifuToolTip1.SetToolTipIcon(this.slider, null);
            this.bunifuToolTip1.SetToolTipTitle(this.slider, "");
            this.slider.Value = 0;
            this.slider.MouseHover += new System.EventHandler(this.slider_MouseHover);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // btnBackward
            // 
            this.btnBackward.ActiveImage = null;
            this.btnBackward.AllowAnimations = true;
            this.btnBackward.AllowBuffering = false;
            this.btnBackward.AllowToggling = false;
            this.btnBackward.AllowZooming = true;
            this.btnBackward.AllowZoomingOnFocus = false;
            this.btnBackward.BackColor = System.Drawing.Color.Transparent;
            this.btnBackward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.ErrorImage")));
            this.btnBackward.FadeWhenInactive = false;
            this.btnBackward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageActive = null;
            this.btnBackward.ImageLocation = null;
            this.btnBackward.ImageMargin = 20;
            this.btnBackward.ImageSize = new System.Drawing.Size(30, 33);
            this.btnBackward.ImageZoomSize = new System.Drawing.Size(50, 53);
            this.btnBackward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.InitialImage")));
            this.btnBackward.Location = new System.Drawing.Point(0, 0);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Rotation = 0;
            this.btnBackward.ShowActiveImage = true;
            this.btnBackward.ShowCursorChanges = true;
            this.btnBackward.ShowImageBorders = true;
            this.btnBackward.ShowSizeMarkers = false;
            this.btnBackward.Size = new System.Drawing.Size(50, 53);
            this.btnBackward.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.btnBackward, "Prev");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBackward, null);
            this.btnBackward.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnBackward, "");
            this.btnBackward.WaitOnLoad = false;
            this.btnBackward.Zoom = 20;
            this.btnBackward.ZoomSpeed = 10;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = true;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = global::QAPlayer.Properties.Resources.pause_30px;
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 20;
            this.btnPlay.ImageSize = new System.Drawing.Size(30, 33);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(50, 53);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(50, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(50, 53);
            this.btnPlay.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.btnPlay, "Play");
            this.bunifuToolTip1.SetToolTipIcon(this.btnPlay, null);
            this.btnPlay.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnPlay, "");
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 20;
            this.btnPlay.ZoomSpeed = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnForward
            // 
            this.btnForward.ActiveImage = null;
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBuffering = false;
            this.btnForward.AllowToggling = false;
            this.btnForward.AllowZooming = true;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = false;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 20;
            this.btnForward.ImageSize = new System.Drawing.Size(30, 33);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(50, 53);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(100, 0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(50, 53);
            this.btnForward.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Next");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.btnForward.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 20;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(593, 7);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(83, 15);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume: 100%";
            this.bunifuToolTip1.SetToolTip(this.lblVolume, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblVolume, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblVolume, "");
            // 
            // trbPlaySpeed
            // 
            this.trbPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbPlaySpeed.Location = new System.Drawing.Point(242, 28);
            this.trbPlaySpeed.Name = "trbPlaySpeed";
            this.trbPlaySpeed.Size = new System.Drawing.Size(211, 45);
            this.trbPlaySpeed.TabIndex = 8;
            this.trbPlaySpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.bunifuToolTip1.SetToolTip(this.trbPlaySpeed, "");
            this.bunifuToolTip1.SetToolTipIcon(this.trbPlaySpeed, null);
            this.bunifuToolTip1.SetToolTipTitle(this.trbPlaySpeed, "");
            this.trbPlaySpeed.Value = 5;
            this.trbPlaySpeed.ValueChanged += new System.EventHandler(this.trbPlaySpeed_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalTime2);
            this.panel1.Controls.Add(this.lblTime2);
            this.panel1.Controls.Add(this.trbPlaySpeed);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.volumeControl2);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBackward);
            this.panel1.Controls.Add(this.slider);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(228, 492);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 55);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // lblTotalTime2
            // 
            this.lblTotalTime2.BackColor = System.Drawing.Color.Black;
            this.lblTotalTime2.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime2.Location = new System.Drawing.Point(509, 25);
            this.lblTotalTime2.Name = "lblTotalTime2";
            this.lblTotalTime2.Size = new System.Drawing.Size(40, 22);
            this.lblTotalTime2.TabIndex = 14;
            this.bunifuToolTip1.SetToolTip(this.lblTotalTime2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTotalTime2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTotalTime2, "");
            // 
            // lblTime2
            // 
            this.lblTime2.BackColor = System.Drawing.Color.Black;
            this.lblTime2.ForeColor = System.Drawing.Color.White;
            this.lblTime2.Location = new System.Drawing.Point(163, 25);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(51, 22);
            this.lblTime2.TabIndex = 13;
            this.bunifuToolTip1.SetToolTip(this.lblTime2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblTime2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblTime2, "");
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // volumeControl2
            // 
            this.volumeControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeControl2.BackColor = System.Drawing.Color.Black;
            this.volumeControl2.Bar_color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.volumeControl2.Location = new System.Drawing.Point(556, 24);
            this.volumeControl2.Max = 100;
            this.volumeControl2.Min = 0;
            this.volumeControl2.Name = "volumeControl2";
            this.volumeControl2.Size = new System.Drawing.Size(273, 17);
            this.volumeControl2.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.volumeControl2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.volumeControl2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.volumeControl2, "");
            this.volumeControl2.Value = 100;
            this.volumeControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeControl2_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1065, 547);
            this.ControlBox = false;
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeftNavbar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLeftNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbPlaySpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddFiles;
        private System.Windows.Forms.ListBox listFile;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel panelLeftNavbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHelp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNowPlaying;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalTime;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trbPlaySpeed;
        private System.Windows.Forms.Label lblVolume;
        private VolumeControl volumeControl2;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackward;
        private Bunifu.UI.WinForms.BunifuHSlider slider;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTotalTime2;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}

