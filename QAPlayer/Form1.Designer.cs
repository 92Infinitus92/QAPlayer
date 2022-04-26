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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelLeftNavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.indicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.btnHelp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnExplore = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAddFiles = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.listFile = new System.Windows.Forms.ListBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgEqualizer = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuHSlider2 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBackward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.slider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panelLeftNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftNavbar
            // 
            this.panelLeftNavbar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLeftNavbar.Controls.Add(this.pictureBox1);
            this.panelLeftNavbar.Controls.Add(this.bunifuLabel1);
            this.panelLeftNavbar.Controls.Add(this.indicator);
            this.panelLeftNavbar.Controls.Add(this.btnHelp);
            this.panelLeftNavbar.Controls.Add(this.btnSettings);
            this.panelLeftNavbar.Controls.Add(this.btnExplore);
            this.panelLeftNavbar.Controls.Add(this.btnNowPlaying);
            this.panelLeftNavbar.Controls.Add(this.bunifuShapes1);
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
            // indicator
            // 
            this.indicator.Angle = 0F;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.BorderColor = System.Drawing.Color.Purple;
            this.indicator.BorderThickness = 3;
            this.indicator.FillColor = System.Drawing.Color.Transparent;
            this.indicator.FillShape = true;
            this.indicator.Location = new System.Drawing.Point(26, 161);
            this.indicator.Name = "indicator";
            this.indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.indicator.Sides = 5;
            this.indicator.Size = new System.Drawing.Size(15, 15);
            this.indicator.TabIndex = 2;
            this.indicator.Text = "bunifuShapes1";
            this.bunifuToolTip1.SetToolTip(this.indicator, "");
            this.bunifuToolTip1.SetToolTipIcon(this.indicator, null);
            this.bunifuToolTip1.SetToolTipTitle(this.indicator, "");
            // 
            // btnHelp
            // 
            this.btnHelp.AllowAnimations = true;
            this.btnHelp.AllowMouseEffects = true;
            this.btnHelp.AllowToggling = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnHelp.CustomizableEdges = borderEdges1;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges2;
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
            // btnExplore
            // 
            this.btnExplore.AllowAnimations = true;
            this.btnExplore.AllowMouseEffects = true;
            this.btnExplore.AllowToggling = true;
            this.btnExplore.AnimationSpeed = 200;
            this.btnExplore.AutoGenerateColors = false;
            this.btnExplore.AutoRoundBorders = false;
            this.btnExplore.AutoSizeLeftIcon = true;
            this.btnExplore.AutoSizeRightIcon = true;
            this.btnExplore.BackColor = System.Drawing.Color.Transparent;
            this.btnExplore.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnExplore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExplore.BackgroundImage")));
            this.btnExplore.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.ButtonText = "Explore";
            this.btnExplore.ButtonTextMarginLeft = 0;
            this.btnExplore.ColorContrastOnClick = 45;
            this.btnExplore.ColorContrastOnHover = 45;
            this.btnExplore.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnExplore.CustomizableEdges = borderEdges3;
            this.btnExplore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExplore.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExplore.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnExplore.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnExplore.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExplore.ForeColor = System.Drawing.Color.Gray;
            this.btnExplore.IconLeft = null;
            this.btnExplore.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExplore.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExplore.IconMarginLeft = 11;
            this.btnExplore.IconPadding = 10;
            this.btnExplore.IconRight = null;
            this.btnExplore.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExplore.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExplore.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExplore.IconSize = 25;
            this.btnExplore.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnExplore.IdleBorderRadius = 0;
            this.btnExplore.IdleBorderThickness = 0;
            this.btnExplore.IdleFillColor = System.Drawing.Color.Empty;
            this.btnExplore.IdleIconLeftImage = null;
            this.btnExplore.IdleIconRightImage = null;
            this.btnExplore.IndicateFocus = true;
            this.btnExplore.Location = new System.Drawing.Point(68, 288);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExplore.OnDisabledState.BorderRadius = 1;
            this.btnExplore.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnDisabledState.BorderThickness = 1;
            this.btnExplore.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExplore.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExplore.OnDisabledState.IconLeftImage = null;
            this.btnExplore.OnDisabledState.IconRightImage = null;
            this.btnExplore.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnExplore.onHoverState.BorderRadius = 1;
            this.btnExplore.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.onHoverState.BorderThickness = 1;
            this.btnExplore.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnExplore.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExplore.onHoverState.IconLeftImage = null;
            this.btnExplore.onHoverState.IconRightImage = null;
            this.btnExplore.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnExplore.OnIdleState.BorderRadius = 1;
            this.btnExplore.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnIdleState.BorderThickness = 1;
            this.btnExplore.OnIdleState.FillColor = System.Drawing.Color.Gainsboro;
            this.btnExplore.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnExplore.OnIdleState.IconLeftImage = null;
            this.btnExplore.OnIdleState.IconRightImage = null;
            this.btnExplore.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnExplore.OnPressedState.BorderRadius = 1;
            this.btnExplore.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExplore.OnPressedState.BorderThickness = 1;
            this.btnExplore.OnPressedState.FillColor = System.Drawing.Color.Violet;
            this.btnExplore.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExplore.OnPressedState.IconLeftImage = null;
            this.btnExplore.OnPressedState.IconRightImage = null;
            this.btnExplore.Size = new System.Drawing.Size(129, 43);
            this.btnExplore.TabIndex = 1;
            this.btnExplore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExplore.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExplore.TextMarginLeft = 0;
            this.btnExplore.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnExplore, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnExplore, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnExplore, "");
            this.btnExplore.UseDefaultRadiusAndThickness = true;
            this.btnExplore.Click += new System.EventHandler(this.bunifuButtonExplore_Click);
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
            this.btnNowPlaying.Location = new System.Drawing.Point(68, 145);
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
            this.btnNowPlaying.Size = new System.Drawing.Size(129, 43);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNowPlaying.TextMarginLeft = 0;
            this.btnNowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.btnNowPlaying, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnNowPlaying, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnNowPlaying, "");
            this.btnNowPlaying.UseDefaultRadiusAndThickness = true;
            this.btnNowPlaying.Click += new System.EventHandler(this.bunifuButtonNowPlaying_Click);
            // 
            // bunifuShapes1
            // 
            this.bunifuShapes1.Angle = 90F;
            this.bunifuShapes1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuShapes1.BorderThickness = 2;
            this.bunifuShapes1.FillColor = System.Drawing.Color.Transparent;
            this.bunifuShapes1.FillShape = true;
            this.bunifuShapes1.Location = new System.Drawing.Point(5, 172);
            this.bunifuShapes1.Name = "bunifuShapes1";
            this.bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.bunifuShapes1.Sides = 5;
            this.bunifuShapes1.Size = new System.Drawing.Size(57, 149);
            this.bunifuShapes1.TabIndex = 2;
            this.bunifuShapes1.Text = "bunifuShapes1";
            this.bunifuToolTip1.SetToolTip(this.bunifuShapes1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuShapes1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuShapes1, "");
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
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
            this.bunifuPages1.Size = new System.Drawing.Size(1076, 468);
            this.bunifuPages1.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.bunifuPages1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPages1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPages1, "");
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.player);
            this.tabPage1.Controls.Add(this.btnAddFiles);
            this.tabPage1.Controls.Add(this.listFile);
            this.tabPage1.Controls.Add(this.bunifuPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Playing";
            this.bunifuToolTip1.SetToolTip(this.tabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage1, "");
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(-36, 383);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(294, 130);
            this.player.TabIndex = 12;
            this.bunifuToolTip1.SetToolTip(this.player, "");
            this.bunifuToolTip1.SetToolTipIcon(this.player, null);
            this.bunifuToolTip1.SetToolTipTitle(this.player, "");
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            this.player.KeyUpEvent += new AxWMPLib._WMPOCXEvents_KeyUpEventHandler(this.spacePauseEvent);
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAddFiles.CustomizableEdges = borderEdges5;
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
            this.btnAddFiles.Location = new System.Drawing.Point(46, 18);
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
            // listFile
            // 
            this.listFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFile.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFile.ForeColor = System.Drawing.Color.White;
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 17;
            this.listFile.Location = new System.Drawing.Point(360, 89);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(549, 255);
            this.listFile.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.listFile, "");
            this.bunifuToolTip1.SetToolTipIcon(this.listFile, null);
            this.bunifuToolTip1.SetToolTipTitle(this.listFile, "");
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged_1);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.imgEqualizer);
            this.bunifuPanel1.Location = new System.Drawing.Point(46, 99);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(278, 228);
            this.bunifuPanel1.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel1, "");
            // 
            // imgEqualizer
            // 
            this.imgEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("imgEqualizer.Image")));
            this.imgEqualizer.Location = new System.Drawing.Point(0, -10);
            this.imgEqualizer.Name = "imgEqualizer";
            this.imgEqualizer.Size = new System.Drawing.Size(339, 251);
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
            this.tabPage2.Size = new System.Drawing.Size(1068, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explore";
            this.bunifuToolTip1.SetToolTip(this.tabPage2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage2, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.bunifuHSlider2);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBackward);
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.bunifuImageButton5);
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(232, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 49);
            this.panel1.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
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
            this.lblTime.Location = new System.Drawing.Point(708, 16);
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
            // bunifuHSlider2
            // 
            this.bunifuHSlider2.AllowCursorChanges = true;
            this.bunifuHSlider2.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider2.AllowIncrementalClickMoves = true;
            this.bunifuHSlider2.AllowMouseDownEffects = false;
            this.bunifuHSlider2.AllowMouseHoverEffects = false;
            this.bunifuHSlider2.AllowScrollingAnimations = true;
            this.bunifuHSlider2.AllowScrollKeysDetection = true;
            this.bunifuHSlider2.AllowScrollOptionsMenu = true;
            this.bunifuHSlider2.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuHSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider2.BackgroundImage")));
            this.bunifuHSlider2.BindingContainer = null;
            this.bunifuHSlider2.BorderRadius = 2;
            this.bunifuHSlider2.BorderThickness = 1;
            this.bunifuHSlider2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider2.DrawThickBorder = false;
            this.bunifuHSlider2.DurationBeforeShrink = 2000;
            this.bunifuHSlider2.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuHSlider2.LargeChange = 10;
            this.bunifuHSlider2.Location = new System.Drawing.Point(830, 9);
            this.bunifuHSlider2.Maximum = 100;
            this.bunifuHSlider2.Minimum = 0;
            this.bunifuHSlider2.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider2.MinimumThumbLength = 18;
            this.bunifuHSlider2.Name = "bunifuHSlider2";
            this.bunifuHSlider2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider2.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider2.ScrollBarBorderColor = System.Drawing.Color.White;
            this.bunifuHSlider2.ScrollBarColor = System.Drawing.Color.White;
            this.bunifuHSlider2.ShrinkSizeLimit = 3;
            this.bunifuHSlider2.Size = new System.Drawing.Size(177, 31);
            this.bunifuHSlider2.SliderColor = System.Drawing.Color.White;
            this.bunifuHSlider2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider2.SmallChange = 1;
            this.bunifuHSlider2.TabIndex = 5;
            this.bunifuHSlider2.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider2.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider2.ThumbLength = 18;
            this.bunifuHSlider2.ThumbMargin = 1;
            this.bunifuHSlider2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.bunifuHSlider2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuHSlider2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuHSlider2, "");
            this.bunifuHSlider2.Value = 50;
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
            this.btnForward.ImageSize = new System.Drawing.Size(30, 29);
            this.btnForward.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.btnForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnForward.InitialImage")));
            this.btnForward.Location = new System.Drawing.Point(150, 0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Rotation = 0;
            this.btnForward.ShowActiveImage = true;
            this.btnForward.ShowCursorChanges = true;
            this.btnForward.ShowImageBorders = true;
            this.btnForward.ShowSizeMarkers = false;
            this.btnForward.Size = new System.Drawing.Size(50, 49);
            this.btnForward.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Next");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.btnForward.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.WaitOnLoad = false;
            this.btnForward.Zoom = 20;
            this.btnForward.ZoomSpeed = 10;
            // 
            // btnPause
            // 
            this.btnPause.ActiveImage = null;
            this.btnPause.AllowAnimations = true;
            this.btnPause.AllowBuffering = false;
            this.btnPause.AllowToggling = false;
            this.btnPause.AllowZooming = true;
            this.btnPause.AllowZoomingOnFocus = false;
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPause.ErrorImage")));
            this.btnPause.FadeWhenInactive = false;
            this.btnPause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.ImageLocation = null;
            this.btnPause.ImageMargin = 20;
            this.btnPause.ImageSize = new System.Drawing.Size(30, 29);
            this.btnPause.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.btnPause.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPause.InitialImage")));
            this.btnPause.Location = new System.Drawing.Point(100, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Rotation = 0;
            this.btnPause.ShowActiveImage = true;
            this.btnPause.ShowCursorChanges = true;
            this.btnPause.ShowImageBorders = true;
            this.btnPause.ShowSizeMarkers = false;
            this.btnPause.Size = new System.Drawing.Size(50, 49);
            this.btnPause.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.btnPause, "Pause");
            this.bunifuToolTip1.SetToolTipIcon(this.btnPause, null);
            this.btnPause.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnPause, "");
            this.btnPause.WaitOnLoad = false;
            this.btnPause.Zoom = 20;
            this.btnPause.ZoomSpeed = 10;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
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
            this.btnPlay.ImageSize = new System.Drawing.Size(30, 29);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(50, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(50, 49);
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
            this.btnBackward.ImageSize = new System.Drawing.Size(30, 29);
            this.btnBackward.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.btnBackward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackward.InitialImage")));
            this.btnBackward.Location = new System.Drawing.Point(0, 0);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Rotation = 0;
            this.btnBackward.ShowActiveImage = true;
            this.btnBackward.ShowCursorChanges = true;
            this.btnBackward.ShowImageBorders = true;
            this.btnBackward.ShowSizeMarkers = false;
            this.btnBackward.Size = new System.Drawing.Size(50, 49);
            this.btnBackward.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.btnBackward, "Prev");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBackward, null);
            this.btnBackward.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnBackward, "");
            this.btnBackward.WaitOnLoad = false;
            this.btnBackward.Zoom = 20;
            this.btnBackward.ZoomSpeed = 10;
            // 
            // slider
            // 
            this.slider.AllowCursorChanges = true;
            this.slider.AllowHomeEndKeysDetection = false;
            this.slider.AllowIncrementalClickMoves = true;
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
            this.slider.Location = new System.Drawing.Point(222, 9);
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
            this.slider.Size = new System.Drawing.Size(447, 31);
            this.slider.SliderColor = System.Drawing.Color.White;
            this.slider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.slider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.slider.SmallChange = 1;
            this.slider.TabIndex = 0;
            this.slider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.slider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.slider.ThumbLength = 44;
            this.slider.ThumbMargin = 1;
            this.slider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.slider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.slider, "");
            this.bunifuToolTip1.SetToolTipIcon(this.slider, null);
            this.bunifuToolTip1.SetToolTipTitle(this.slider, "");
            this.slider.Value = 50;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowBuffering = false;
            this.bunifuImageButton5.AllowToggling = false;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.AllowZoomingOnFocus = false;
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.ErrorImage")));
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 20;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(30, 26);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(50, 46);
            this.bunifuImageButton5.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.InitialImage")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(791, 0);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = true;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(50, 46);
            this.bunifuImageButton5.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "Mute");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton5, null);
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton5, "");
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 20;
            this.bunifuImageButton5.ZoomSpeed = 10;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.ActiveImage = null;
            this.bunifuImageButton6.AllowAnimations = true;
            this.bunifuImageButton6.AllowBuffering = false;
            this.bunifuImageButton6.AllowToggling = false;
            this.bunifuImageButton6.AllowZooming = true;
            this.bunifuImageButton6.AllowZoomingOnFocus = false;
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.ErrorImage")));
            this.bunifuImageButton6.FadeWhenInactive = false;
            this.bunifuImageButton6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.ImageLocation = null;
            this.bunifuImageButton6.ImageMargin = 20;
            this.bunifuImageButton6.ImageSize = new System.Drawing.Size(30, 26);
            this.bunifuImageButton6.ImageZoomSize = new System.Drawing.Size(50, 46);
            this.bunifuImageButton6.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.InitialImage")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(997, 0);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Rotation = 0;
            this.bunifuImageButton6.ShowActiveImage = true;
            this.bunifuImageButton6.ShowCursorChanges = true;
            this.bunifuImageButton6.ShowImageBorders = true;
            this.bunifuImageButton6.ShowSizeMarkers = false;
            this.bunifuImageButton6.Size = new System.Drawing.Size(50, 46);
            this.bunifuImageButton6.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton6, "MaxVol");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton6, null);
            this.bunifuImageButton6.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton6, "");
            this.bunifuImageButton6.WaitOnLoad = false;
            this.bunifuImageButton6.Zoom = 20;
            this.bunifuImageButton6.ZoomSpeed = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftNavbar.ResumeLayout(false);
            this.panelLeftNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEqualizer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftNavbar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExplore;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNowPlaying;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHelp;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuHSlider slider;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuImageButton btnPause;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackward;
        private Bunifu.UI.WinForms.BunifuImageButton btnForward;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton6;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private System.Windows.Forms.PictureBox imgEqualizer;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listFile;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddFiles;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

