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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.listFile = new System.Windows.Forms.ListBox();
            this.btnAddFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnNowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnHelp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelLeftNavbar = new System.Windows.Forms.Panel();
            this.slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnBackward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trbPlaySpeed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTime2 = new System.Windows.Forms.Label();
            this.volumeControl2 = new QAPlayer.VolumeControl();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuToolTip2 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
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
            this.bunifuToolTip2.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip2.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip2.SetToolTipTitle(this.bunifuLabel1, "");
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
            this.bunifuToolTip2.SetToolTip(this.listFile, "");
            this.bunifuToolTip2.SetToolTipIcon(this.listFile, null);
            this.bunifuToolTip2.SetToolTipTitle(this.listFile, "");
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
            this.btnAddFiles.Location = new System.Drawing.Point(146, 64);
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
            this.bunifuToolTip2.SetToolTip(this.btnAddFiles, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnAddFiles, null);
            this.bunifuToolTip2.SetToolTipTitle(this.btnAddFiles, "");
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
            this.bunifuToolTip2.SetToolTip(this.lblTime, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblTime, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblTime, "");
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
            this.bunifuToolTip2.SetToolTip(this.lblTotalTime, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblTotalTime, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblTotalTime, "");
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(136, 109);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(596, 156);
            this.player.TabIndex = 12;
            this.bunifuToolTip2.SetToolTip(this.player, "");
            this.bunifuToolTip2.SetToolTipIcon(this.player, null);
            this.bunifuToolTip2.SetToolTipTitle(this.player, "");
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.player_CurrentItemChange);
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
            this.btnMinimize.Location = new System.Drawing.Point(633, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(49, 48);
            this.btnMinimize.TabIndex = 8;
            this.bunifuToolTip2.SetToolTip(this.btnMinimize, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnMinimize, null);
            this.btnMinimize.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnMinimize, "");
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
            this.btnClose.Location = new System.Drawing.Point(678, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(49, 48);
            this.btnClose.TabIndex = 0;
            this.bunifuToolTip2.SetToolTip(this.btnClose, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnClose, null);
            this.btnClose.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnClose, "");
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Location = new System.Drawing.Point(5, 7);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(727, 51);
            this.panelHeader.TabIndex = 1;
            this.bunifuToolTip2.SetToolTip(this.panelHeader, "");
            this.bunifuToolTip2.SetToolTipIcon(this.panelHeader, null);
            this.bunifuToolTip2.SetToolTipTitle(this.panelHeader, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip2.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip2.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip2.SetToolTipTitle(this.pictureBox1, "");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(141, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "File";
            this.bunifuToolTip2.SetToolTip(this.lblTitle, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblTitle, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblTitle, "");
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
            this.bunifuToolTip2.SetToolTip(this.bunifuLabel2, "");
            this.bunifuToolTip2.SetToolTipIcon(this.bunifuLabel2, null);
            this.bunifuToolTip2.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.AllowAnimations = true;
            this.btnNowPlaying.AllowMouseEffects = true;
            this.btnNowPlaying.AllowToggling = true;
            this.btnNowPlaying.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNowPlaying.CustomizableEdges = borderEdges2;
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
            this.btnNowPlaying.Location = new System.Drawing.Point(1, 73);
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
            this.btnNowPlaying.Size = new System.Drawing.Size(118, 37);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNowPlaying.TextMarginLeft = 0;
            this.btnNowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip2.SetToolTip(this.btnNowPlaying, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnNowPlaying, null);
            this.bunifuToolTip2.SetToolTipTitle(this.btnNowPlaying, "");
            this.btnNowPlaying.UseDefaultRadiusAndThickness = true;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnHelp.CustomizableEdges = borderEdges3;
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
            this.btnHelp.Location = new System.Drawing.Point(35, 120);
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
            this.btnHelp.Size = new System.Drawing.Size(43, 37);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHelp.TextMarginLeft = 0;
            this.btnHelp.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip2.SetToolTip(this.btnHelp, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnHelp, null);
            this.bunifuToolTip2.SetToolTipTitle(this.btnHelp, "");
            this.btnHelp.UseDefaultRadiusAndThickness = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelLeftNavbar
            // 
            this.panelLeftNavbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeftNavbar.BackColor = System.Drawing.Color.Black;
            this.panelLeftNavbar.Controls.Add(this.btnNowPlaying);
            this.panelLeftNavbar.Controls.Add(this.btnHelp);
            this.panelLeftNavbar.ForeColor = System.Drawing.Color.Black;
            this.panelLeftNavbar.Location = new System.Drawing.Point(5, 7);
            this.panelLeftNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftNavbar.Name = "panelLeftNavbar";
            this.panelLeftNavbar.Size = new System.Drawing.Size(128, 335);
            this.panelLeftNavbar.TabIndex = 0;
            this.bunifuToolTip2.SetToolTip(this.panelLeftNavbar, "");
            this.bunifuToolTip2.SetToolTipIcon(this.panelLeftNavbar, null);
            this.bunifuToolTip2.SetToolTipTitle(this.panelLeftNavbar, "");
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
            this.slider.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.slider.Location = new System.Drawing.Point(118, 4);
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
            this.slider.Size = new System.Drawing.Size(370, 31);
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
            this.bunifuToolTip2.SetToolTip(this.slider, "");
            this.bunifuToolTip2.SetToolTipIcon(this.slider, null);
            this.bunifuToolTip2.SetToolTipTitle(this.slider, "");
            this.slider.Value = 0;
            //this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // btnBackward
            // 
            this.btnBackward.ActiveImage = null;
            this.btnBackward.AllowAnimations = true;
            this.btnBackward.AllowBuffering = false;
            this.btnBackward.AllowToggling = false;
            this.btnBackward.AllowZooming = false;
            this.btnBackward.AllowZoomingOnFocus = false;
            this.btnBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackward.BackColor = System.Drawing.Color.Transparent;
            this.btnBackward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.ErrorImage")));
            this.btnBackward.FadeWhenInactive = false;
            this.btnBackward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBackward.Image = ((System.Drawing.Image)(resources.GetObject("btnBackward.Image")));
            this.btnBackward.ImageActive = null;
            this.btnBackward.ImageLocation = null;
            this.btnBackward.ImageMargin = 20;
            this.btnBackward.ImageSize = new System.Drawing.Size(22, 27);
            this.btnBackward.ImageZoomSize = new System.Drawing.Size(42, 47);
            this.btnBackward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.InitialImage")));
            this.btnBackward.Location = new System.Drawing.Point(0, 22);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Rotation = 0;
            this.btnBackward.ShowActiveImage = true;
            this.btnBackward.ShowCursorChanges = true;
            this.btnBackward.ShowImageBorders = false;
            this.btnBackward.ShowSizeMarkers = false;
            this.btnBackward.Size = new System.Drawing.Size(42, 47);
            this.btnBackward.TabIndex = 1;
            this.bunifuToolTip2.SetToolTip(this.btnBackward, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnBackward, null);
            this.btnBackward.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnBackward, "");
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
            this.btnPlay.AllowZooming = false;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = global::QAPlayer.Properties.Resources.play_30px;
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 20;
            this.btnPlay.ImageSize = new System.Drawing.Size(22, 27);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(42, 47);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(39, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = false;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(42, 47);
            this.btnPlay.TabIndex = 2;
            this.bunifuToolTip2.SetToolTip(this.btnPlay, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnPlay, null);
            this.btnPlay.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnPlay, "");
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
            this.btnForward.AllowZooming = false;
            this.btnForward.AllowZoomingOnFocus = false;
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnForward.ErrorImage")));
            this.btnForward.FadeWhenInactive = false;
            this.btnForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.ImageLocation = null;
            this.btnForward.ImageMargin = 20;
            this.btnForward.ImageSize = new System.Drawing.Size(22, 27);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(42, 47);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(78, 22);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = false;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(42, 47);
            this.btnForward.TabIndex = 4;
            this.bunifuToolTip2.SetToolTip(this.btnForward, "");
            this.bunifuToolTip2.SetToolTipIcon(this.btnForward, null);
            this.btnForward.ToolTipText = "";
            this.bunifuToolTip2.SetToolTipTitle(this.btnForward, "");
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 20;
            this.btnForward.ZoomSpeed = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(633, 28);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(83, 15);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume: 100%";
            this.bunifuToolTip2.SetToolTip(this.lblVolume, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblVolume, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblVolume, "");
            // 
            // trbPlaySpeed
            // 
            this.trbPlaySpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trbPlaySpeed.LargeChange = 1;
            this.trbPlaySpeed.Location = new System.Drawing.Point(177, 48);
            this.trbPlaySpeed.Name = "trbPlaySpeed";
            this.trbPlaySpeed.Size = new System.Drawing.Size(239, 45);
            this.trbPlaySpeed.SmallChange = 0;
            this.trbPlaySpeed.TabIndex = 8;
            this.trbPlaySpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.bunifuToolTip2.SetToolTip(this.trbPlaySpeed, "");
            this.bunifuToolTip2.SetToolTipIcon(this.trbPlaySpeed, null);
            this.bunifuToolTip2.SetToolTipTitle(this.trbPlaySpeed, "");
            this.trbPlaySpeed.Value = 5;
            this.trbPlaySpeed.ValueChanged += new System.EventHandler(this.trbPlaySpeed_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lblTime2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalTime2);
            this.panel1.Controls.Add(this.trbPlaySpeed);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.volumeControl2);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBackward);
            this.panel1.Controls.Add(this.slider);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(7, 264);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 78);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip2.SetToolTip(this.panel1, "");
            this.bunifuToolTip2.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip2.SetToolTipTitle(this.panel1, "");
            // 
            // lblTime2
            // 
            this.lblTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTime2.ForeColor = System.Drawing.Color.White;
            this.lblTime2.Location = new System.Drawing.Point(119, 45);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(51, 22);
            this.lblTime2.TabIndex = 13;
            this.bunifuToolTip2.SetToolTip(this.lblTime2, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblTime2, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblTime2, "");
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(391, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "1.5";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label11, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label11, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label11, "");
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(370, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "1.4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label10, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label10, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label10, "");
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(349, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "1.3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label9, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label9, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label9, "");
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(327, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "1.2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label8, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label8, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label8, "");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(306, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "1.1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label7, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label7, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label7, "");
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(285, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "1.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label6, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label6, "");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(264, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "0.9";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label5, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label5, "");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(243, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "0.8";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label4, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label4, "");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(221, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "0.7";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label3, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label3, "");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(200, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "0.6";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label2, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label2, "");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(179, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "0.5";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip2.SetToolTip(this.label1, "");
            this.bunifuToolTip2.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip2.SetToolTipTitle(this.label1, "");
            // 
            // lblTotalTime2
            // 
            this.lblTotalTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalTime2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTime2.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime2.Location = new System.Drawing.Point(423, 45);
            this.lblTotalTime2.Name = "lblTotalTime2";
            this.lblTotalTime2.Size = new System.Drawing.Size(54, 22);
            this.lblTotalTime2.TabIndex = 14;
            this.bunifuToolTip2.SetToolTip(this.lblTotalTime2, "");
            this.bunifuToolTip2.SetToolTipIcon(this.lblTotalTime2, null);
            this.bunifuToolTip2.SetToolTipTitle(this.lblTotalTime2, "");
            // 
            // volumeControl2
            // 
            this.volumeControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeControl2.BackColor = System.Drawing.Color.Black;
            this.volumeControl2.Bar_color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(118)))));
            this.volumeControl2.Location = new System.Drawing.Point(483, 47);
            this.volumeControl2.Max = 100;
            this.volumeControl2.Min = 0;
            this.volumeControl2.Name = "volumeControl2";
            this.volumeControl2.Size = new System.Drawing.Size(230, 16);
            this.volumeControl2.TabIndex = 10;
            this.bunifuToolTip2.SetToolTip(this.volumeControl2, "");
            this.bunifuToolTip2.SetToolTipIcon(this.volumeControl2, null);
            this.bunifuToolTip2.SetToolTipTitle(this.volumeControl2, "");
            this.volumeControl2.Value = 100;
            this.volumeControl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volumeControl2_MouseMove);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuToolTip2
            // 
            this.bunifuToolTip2.Active = true;
            this.bunifuToolTip2.AlignTextWithTitle = true;
            this.bunifuToolTip2.AllowAutoClose = false;
            this.bunifuToolTip2.AllowFading = true;
            this.bunifuToolTip2.AutoCloseDuration = 5000;
            this.bunifuToolTip2.BackColor = System.Drawing.Color.Black;
            this.bunifuToolTip2.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip2.ClickToShowDisplayControl = false;
            this.bunifuToolTip2.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip2.DisplayControl = null;
            this.bunifuToolTip2.EntryAnimationSpeed = 350;
            this.bunifuToolTip2.ExitAnimationSpeed = 200;
            this.bunifuToolTip2.GenerateAutoCloseDuration = false;
            this.bunifuToolTip2.IconMargin = 6;
            this.bunifuToolTip2.InitialDelay = 0;
            this.bunifuToolTip2.Name = "bunifuToolTip2";
            this.bunifuToolTip2.Opacity = 1D;
            this.bunifuToolTip2.OverrideToolTipTitles = false;
            this.bunifuToolTip2.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip2.ReshowDelay = 100;
            this.bunifuToolTip2.ShowAlways = true;
            this.bunifuToolTip2.ShowBorders = false;
            this.bunifuToolTip2.ShowIcons = true;
            this.bunifuToolTip2.ShowShadows = true;
            this.bunifuToolTip2.Tag = null;
            this.bunifuToolTip2.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip2.TextForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuToolTip2.TextMargin = 2;
            this.bunifuToolTip2.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip2.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuToolTip2.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip2.ToolTipTitle = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(737, 347);
            this.ControlBox = false;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panelLeftNavbar);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNowPlaying;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalTime;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVolume;
        private VolumeControl volumeControl2;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackward;
        private Bunifu.UI.WinForms.BunifuHSlider slider;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTotalTime2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TrackBar trbPlaySpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip2;
    }
}

