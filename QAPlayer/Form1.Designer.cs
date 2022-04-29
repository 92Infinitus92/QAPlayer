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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelLeftNavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnHelp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.listFile = new System.Windows.Forms.ListBox();
            this.btnAddFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.imgEqualizer = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.volumeControl2 = new QAPlayer.VolumeControl();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBackward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trbPlaySpeed = new System.Windows.Forms.TrackBar();
            this.panelLeftNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPlaySpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftNavbar
            // 
            this.panelLeftNavbar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeftNavbar.Controls.Add(this.pictureBox1);
            this.panelLeftNavbar.Controls.Add(this.bunifuLabel1);
            this.panelLeftNavbar.Controls.Add(this.btnHelp);
            this.panelLeftNavbar.Controls.Add(this.btnSettings);
            this.panelLeftNavbar.Controls.Add(this.btnNowPlaying);
            this.panelLeftNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavbar.Name = "panelLeftNavbar";
            this.panelLeftNavbar.Size = new System.Drawing.Size(232, 575);
            this.panelLeftNavbar.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.panelLeftNavbar, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelLeftNavbar, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelLeftNavbar, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.bunifuLabel1.Location = new System.Drawing.Point(26, 88);
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnHelp.CustomizableEdges = borderEdges5;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHelp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHelp.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnHelp.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnHelp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.Gray;
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
            this.btnHelp.Location = new System.Drawing.Point(54, 520);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHelp.OnDisabledState.BorderRadius = 1;
            this.btnHelp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnDisabledState.BorderThickness = 1;
            this.btnHelp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHelp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHelp.OnDisabledState.IconLeftImage = null;
            this.btnHelp.OnDisabledState.IconRightImage = null;
            this.btnHelp.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHelp.onHoverState.BorderRadius = 1;
            this.btnHelp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.onHoverState.BorderThickness = 1;
            this.btnHelp.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnHelp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHelp.onHoverState.IconLeftImage = null;
            this.btnHelp.onHoverState.IconRightImage = null;
            this.btnHelp.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHelp.OnIdleState.BorderRadius = 1;
            this.btnHelp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnIdleState.BorderThickness = 1;
            this.btnHelp.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnHelp.OnIdleState.IconLeftImage = null;
            this.btnHelp.OnIdleState.IconRightImage = null;
            this.btnHelp.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.OnPressedState.BorderRadius = 1;
            this.btnHelp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHelp.OnPressedState.BorderThickness = 1;
            this.btnHelp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHelp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHelp.OnPressedState.IconLeftImage = null;
            this.btnHelp.OnPressedState.IconRightImage = null;
            this.btnHelp.Size = new System.Drawing.Size(74, 43);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHelp.TextMarginLeft = 0;
            this.btnHelp.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnHelp, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnHelp, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnHelp, "");
            this.btnHelp.UseDefaultRadiusAndThickness = true;
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges6;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSettings.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.Gray;
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
            this.btnSettings.Location = new System.Drawing.Point(54, 477);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.OnDisabledState.BorderRadius = 1;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSettings.onHoverState.BorderRadius = 1;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnIdleState.BorderRadius = 1;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.Gray;
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
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnNowPlaying.CustomizableEdges = borderEdges7;
            this.btnNowPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNowPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNowPlaying.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNowPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNowPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNowPlaying.ForeColor = System.Drawing.Color.Gray;
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
            this.btnNowPlaying.Location = new System.Drawing.Point(42, 140);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNowPlaying.OnDisabledState.BorderRadius = 1;
            this.btnNowPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnDisabledState.BorderThickness = 1;
            this.btnNowPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNowPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNowPlaying.OnDisabledState.IconLeftImage = null;
            this.btnNowPlaying.OnDisabledState.IconRightImage = null;
            this.btnNowPlaying.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.onHoverState.BorderRadius = 1;
            this.btnNowPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.onHoverState.BorderThickness = 1;
            this.btnNowPlaying.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnNowPlaying.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNowPlaying.onHoverState.IconLeftImage = null;
            this.btnNowPlaying.onHoverState.IconRightImage = null;
            this.btnNowPlaying.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.BorderRadius = 1;
            this.btnNowPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnIdleState.BorderThickness = 1;
            this.btnNowPlaying.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnNowPlaying.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnNowPlaying.OnIdleState.IconLeftImage = null;
            this.btnNowPlaying.OnIdleState.IconRightImage = null;
            this.btnNowPlaying.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnPressedState.BorderRadius = 1;
            this.btnNowPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnPressedState.BorderThickness = 1;
            this.btnNowPlaying.OnPressedState.FillColor = System.Drawing.Color.Violet;
            this.btnNowPlaying.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNowPlaying.OnPressedState.IconLeftImage = null;
            this.btnNowPlaying.OnPressedState.IconRightImage = null;
            this.btnNowPlaying.Size = new System.Drawing.Size(120, 43);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNowPlaying.TextMarginLeft = 0;
            this.btnNowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnNowPlaying, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnNowPlaying, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnNowPlaying, "");
            this.btnNowPlaying.UseDefaultRadiusAndThickness = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.bunifuLabel2);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(232, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1076, 58);
            this.panelHeader.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panelHeader, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelHeader, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelHeader, "");
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
            this.btnMinimize.Location = new System.Drawing.Point(985, 4);
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
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 17F);
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
            this.btnClose.Location = new System.Drawing.Point(1027, 4);
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
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.Gainsboro;
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
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.panelHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(232, 58);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage1;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "tabPage1";
            this.bunifuPages1.PageTitle = "Playing";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1076, 462);
            this.bunifuPages1.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.bunifuPages1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPages1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPages1, "");
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation2;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.bunifuPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Playing";
            this.bunifuToolTip1.SetToolTip(this.tabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage1, "");
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.player);
            this.bunifuPanel1.Controls.Add(this.listFile);
            this.bunifuPanel1.Controls.Add(this.btnAddFiles);
            this.bunifuPanel1.Controls.Add(this.imgEqualizer);
            this.bunifuPanel1.Location = new System.Drawing.Point(34, 6);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(982, 433);
            this.bunifuPanel1.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel1, "");
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-38, 43);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1064, 390);
            this.player.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.player, "");
            this.bunifuToolTip1.SetToolTipIcon(this.player, null);
            this.bunifuToolTip1.SetToolTipTitle(this.player, "");
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(479, 20);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(183, 17);
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
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnAddFiles.CustomizableEdges = borderEdges8;
            this.btnAddFiles.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddFiles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFiles.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddFiles.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddFiles.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFiles.ForeColor = System.Drawing.Color.Gray;
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
            this.btnAddFiles.Location = new System.Drawing.Point(12, 12);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddFiles.OnDisabledState.BorderRadius = 1;
            this.btnAddFiles.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnDisabledState.BorderThickness = 1;
            this.btnAddFiles.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddFiles.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddFiles.OnDisabledState.IconLeftImage = null;
            this.btnAddFiles.OnDisabledState.IconRightImage = null;
            this.btnAddFiles.onHoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAddFiles.onHoverState.BorderRadius = 1;
            this.btnAddFiles.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.onHoverState.BorderThickness = 1;
            this.btnAddFiles.onHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAddFiles.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddFiles.onHoverState.IconLeftImage = null;
            this.btnAddFiles.onHoverState.IconRightImage = null;
            this.btnAddFiles.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFiles.OnIdleState.BorderRadius = 1;
            this.btnAddFiles.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnIdleState.BorderThickness = 1;
            this.btnAddFiles.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFiles.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnAddFiles.OnIdleState.IconLeftImage = null;
            this.btnAddFiles.OnIdleState.IconRightImage = null;
            this.btnAddFiles.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddFiles.OnPressedState.BorderRadius = 1;
            this.btnAddFiles.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddFiles.OnPressedState.BorderThickness = 1;
            this.btnAddFiles.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
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
            // imgEqualizer
            // 
            this.imgEqualizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("imgEqualizer.Image")));
            this.imgEqualizer.Location = new System.Drawing.Point(88, 57);
            this.imgEqualizer.Name = "imgEqualizer";
            this.imgEqualizer.Size = new System.Drawing.Size(766, 344);
            this.imgEqualizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEqualizer.TabIndex = 0;
            this.imgEqualizer.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgEqualizer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.imgEqualizer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.imgEqualizer, "");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explore";
            this.bunifuToolTip1.SetToolTip(this.tabPage2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage2, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trbPlaySpeed);
            this.panel1.Controls.Add(this.lblTotalTime);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.volumeControl2);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBackward);
            this.panel1.Controls.Add(this.slider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(232, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 55);
            this.panel1.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
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
            this.lblTotalTime.Location = new System.Drawing.Point(698, 25);
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
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(812, 7);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(83, 15);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume: 100%";
            this.bunifuToolTip1.SetToolTip(this.lblVolume, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblVolume, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblVolume, "");
            // 
            // volumeControl2
            // 
            this.volumeControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeControl2.BackColor = System.Drawing.Color.Purple;
            this.volumeControl2.Bar_color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.volumeControl2.Location = new System.Drawing.Point(775, 25);
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
            // lblTime
            // 
            this.lblTime.AllowParentOverrides = false;
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoEllipsis = false;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(206, 25);
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
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
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
            this.slider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.slider.LargeChange = 10;
            this.slider.Location = new System.Drawing.Point(206, 0);
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
            this.slider.Size = new System.Drawing.Size(523, 31);
            this.slider.SliderColor = System.Drawing.Color.White;
            this.slider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.slider.SmallChange = 1;
            this.slider.TabIndex = 0;
            this.slider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.slider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.slider.ThumbLength = 51;
            this.slider.ThumbMargin = 1;
            this.slider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.slider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.slider, "");
            this.bunifuToolTip1.SetToolTipIcon(this.slider, null);
            this.bunifuToolTip1.SetToolTipTitle(this.slider, "");
            this.slider.Value = 0;
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
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
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
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
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trbPlaySpeed
            // 
            this.trbPlaySpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbPlaySpeed.Location = new System.Drawing.Point(344, 25);
            this.trbPlaySpeed.Name = "trbPlaySpeed";
            this.trbPlaySpeed.Size = new System.Drawing.Size(243, 45);
            this.trbPlaySpeed.TabIndex = 8;
            this.trbPlaySpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.bunifuToolTip1.SetToolTip(this.trbPlaySpeed, "");
            this.bunifuToolTip1.SetToolTipIcon(this.trbPlaySpeed, null);
            this.bunifuToolTip1.SetToolTipTitle(this.trbPlaySpeed, "");
            this.trbPlaySpeed.Value = 5;
            this.trbPlaySpeed.ValueChanged += new System.EventHandler(this.trbPlaySpeed_ValueChanged);
            //this.trbPlaySpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trbPlaySpeed_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1308, 575);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeftNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.panelLeftNavbar.ResumeLayout(false);
            this.panelLeftNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPlaySpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftNavbar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNowPlaying;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHelp;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackward;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private System.Windows.Forms.PictureBox imgEqualizer;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddFiles;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ListBox listFile;
        private VolumeControl volumeControl2;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuHSlider slider;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalTime;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private System.Windows.Forms.TrackBar trbPlaySpeed;
    }
}

