namespace MazeGame.Forms
{
	partial class GameForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.panelMainMenu = new System.Windows.Forms.Panel();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonSP = new System.Windows.Forms.Button();
			this.buttonMP = new System.Windows.Forms.Button();
			this.buttonSettings = new System.Windows.Forms.Button();
			this.labelTitle = new System.Windows.Forms.Label();
			this.timerMazeImgAnimation = new System.Windows.Forms.Timer(this.components);
			this.panelSize = new System.Windows.Forms.Panel();
			this.lblSizeDisplay = new System.Windows.Forms.Label();
			this.lblSizeTitle = new System.Windows.Forms.Label();
			this.lblSizeLarge = new System.Windows.Forms.Label();
			this.sliderSize = new System.Windows.Forms.TrackBar();
			this.lblSizeSmall = new System.Windows.Forms.Label();
			this.buttonBackToMainMenu = new System.Windows.Forms.Button();
			this.buttonGenerateMaze = new System.Windows.Forms.Button();
			this.labelInstructions = new System.Windows.Forms.Label();
			this.panelSeed = new System.Windows.Forms.Panel();
			this.buttonSeedHelp = new System.Windows.Forms.Button();
			this.buttonGenerateSeed = new System.Windows.Forms.Button();
			this.txtSeed = new System.Windows.Forms.TextBox();
			this.lblSeedTitle = new System.Windows.Forms.Label();
			this.tableMazeCreator = new System.Windows.Forms.TableLayoutPanel();
			this.panelMainMenu.SuspendLayout();
			this.panelSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSize)).BeginInit();
			this.panelSeed.SuspendLayout();
			this.tableMazeCreator.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMainMenu
			// 
			this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panelMainMenu.Controls.Add(this.buttonExit);
			this.panelMainMenu.Controls.Add(this.buttonSP);
			this.panelMainMenu.Controls.Add(this.buttonMP);
			this.panelMainMenu.Controls.Add(this.buttonSettings);
			this.panelMainMenu.Location = new System.Drawing.Point(0, 990);
			this.panelMainMenu.Margin = new System.Windows.Forms.Padding(5);
			this.panelMainMenu.Name = "panelMainMenu";
			this.panelMainMenu.Size = new System.Drawing.Size(316, 682);
			this.panelMainMenu.TabIndex = 0;
			// 
			// buttonExit
			// 
			this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExit.ForeColor = System.Drawing.Color.DodgerBlue;
			this.buttonExit.Location = new System.Drawing.Point(5, 400);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(306, 50);
			this.buttonExit.TabIndex = 3;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = false;
			this.buttonExit.Click += new System.EventHandler(this.EventExitButtonClick);
			// 
			// buttonSP
			// 
			this.buttonSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonSP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSP.ForeColor = System.Drawing.Color.DodgerBlue;
			this.buttonSP.Location = new System.Drawing.Point(5, 220);
			this.buttonSP.Margin = new System.Windows.Forms.Padding(5);
			this.buttonSP.Name = "buttonSP";
			this.buttonSP.Size = new System.Drawing.Size(306, 50);
			this.buttonSP.TabIndex = 0;
			this.buttonSP.Text = "Single Player";
			this.buttonSP.UseVisualStyleBackColor = false;
			this.buttonSP.Click += new System.EventHandler(this.EventSPButtonClick);
			// 
			// buttonMP
			// 
			this.buttonMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonMP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMP.ForeColor = System.Drawing.Color.DodgerBlue;
			this.buttonMP.Location = new System.Drawing.Point(5, 280);
			this.buttonMP.Margin = new System.Windows.Forms.Padding(5);
			this.buttonMP.Name = "buttonMP";
			this.buttonMP.Size = new System.Drawing.Size(306, 50);
			this.buttonMP.TabIndex = 1;
			this.buttonMP.Text = "Multiplayer";
			this.buttonMP.UseVisualStyleBackColor = false;
			this.buttonMP.Visible = false;
			this.buttonMP.Click += new System.EventHandler(this.EventMPButtonClick);
			// 
			// buttonSettings
			// 
			this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSettings.ForeColor = System.Drawing.Color.DodgerBlue;
			this.buttonSettings.Location = new System.Drawing.Point(5, 340);
			this.buttonSettings.Margin = new System.Windows.Forms.Padding(5);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(306, 50);
			this.buttonSettings.TabIndex = 2;
			this.buttonSettings.Text = "Settings";
			this.buttonSettings.UseVisualStyleBackColor = false;
			this.buttonSettings.Visible = false;
			this.buttonSettings.Click += new System.EventHandler(this.EventSettingsButtonClick);
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(219, 1200);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(3);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(835, 128);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Blue\'s Maze Game";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timerMazeImgAnimation
			// 
			this.timerMazeImgAnimation.Interval = 10;
			this.timerMazeImgAnimation.Tick += new System.EventHandler(this.EventAnimationTimerTick);
			// 
			// panelSize
			// 
			this.panelSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panelSize.Controls.Add(this.lblSizeDisplay);
			this.panelSize.Controls.Add(this.lblSizeTitle);
			this.panelSize.Controls.Add(this.lblSizeLarge);
			this.panelSize.Controls.Add(this.sliderSize);
			this.panelSize.Controls.Add(this.lblSizeSmall);
			this.panelSize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSize.Location = new System.Drawing.Point(0, 0);
			this.panelSize.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
			this.panelSize.Name = "panelSize";
			this.panelSize.Padding = new System.Windows.Forms.Padding(5);
			this.panelSize.Size = new System.Drawing.Size(622, 424);
			this.panelSize.TabIndex = 3;
			// 
			// lblSizeDisplay
			// 
			this.lblSizeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSizeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeDisplay.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSizeDisplay.Location = new System.Drawing.Point(8, 177);
			this.lblSizeDisplay.Name = "lblSizeDisplay";
			this.lblSizeDisplay.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.lblSizeDisplay.Size = new System.Drawing.Size(606, 60);
			this.lblSizeDisplay.TabIndex = 9;
			this.lblSizeDisplay.Text = "Chosen Size: 20x20";
			this.lblSizeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSizeTitle
			// 
			this.lblSizeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSizeTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeTitle.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSizeTitle.Location = new System.Drawing.Point(252, 36);
			this.lblSizeTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lblSizeTitle.Name = "lblSizeTitle";
			this.lblSizeTitle.Size = new System.Drawing.Size(114, 64);
			this.lblSizeTitle.TabIndex = 7;
			this.lblSizeTitle.Text = "Size";
			this.lblSizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSizeLarge
			// 
			this.lblSizeLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSizeLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeLarge.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeLarge.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSizeLarge.Location = new System.Drawing.Point(514, 323);
			this.lblSizeLarge.MinimumSize = new System.Drawing.Size(100, 45);
			this.lblSizeLarge.Name = "lblSizeLarge";
			this.lblSizeLarge.Padding = new System.Windows.Forms.Padding(3);
			this.lblSizeLarge.Size = new System.Drawing.Size(100, 45);
			this.lblSizeLarge.TabIndex = 6;
			this.lblSizeLarge.Text = "Large";
			this.lblSizeLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sliderSize
			// 
			this.sliderSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sliderSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.sliderSize.LargeChange = 1;
			this.sliderSize.Location = new System.Drawing.Point(8, 371);
			this.sliderSize.Maximum = 11;
			this.sliderSize.Name = "sliderSize";
			this.sliderSize.Size = new System.Drawing.Size(606, 45);
			this.sliderSize.TabIndex = 4;
			this.sliderSize.TabStop = false;
			this.sliderSize.TickFrequency = 11;
			this.sliderSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.sliderSize.Value = 4;
			this.sliderSize.Scroll += new System.EventHandler(this.EventSideScrollerChanged);
			// 
			// lblSizeSmall
			// 
			this.lblSizeSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSizeSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeSmall.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeSmall.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSizeSmall.Location = new System.Drawing.Point(8, 323);
			this.lblSizeSmall.MinimumSize = new System.Drawing.Size(100, 45);
			this.lblSizeSmall.Name = "lblSizeSmall";
			this.lblSizeSmall.Padding = new System.Windows.Forms.Padding(3);
			this.lblSizeSmall.Size = new System.Drawing.Size(100, 45);
			this.lblSizeSmall.TabIndex = 5;
			this.lblSizeSmall.Text = "Small";
			this.lblSizeSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonBackToMainMenu
			// 
			this.buttonBackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.buttonBackToMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBackToMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonBackToMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
			this.buttonBackToMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
			this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBackToMainMenu.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Black;
			this.buttonBackToMainMenu.Location = new System.Drawing.Point(624, 427);
			this.buttonBackToMainMenu.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
			this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
			this.buttonBackToMainMenu.Size = new System.Drawing.Size(623, 57);
			this.buttonBackToMainMenu.TabIndex = 11;
			this.buttonBackToMainMenu.Text = "Main Menu";
			this.buttonBackToMainMenu.UseVisualStyleBackColor = false;
			this.buttonBackToMainMenu.Click += new System.EventHandler(this.EventBackToMainMenuButtonClick);
			// 
			// buttonGenerateMaze
			// 
			this.buttonGenerateMaze.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonGenerateMaze.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonGenerateMaze.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonGenerateMaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
			this.buttonGenerateMaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
			this.buttonGenerateMaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGenerateMaze.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerateMaze.ForeColor = System.Drawing.Color.Black;
			this.buttonGenerateMaze.Location = new System.Drawing.Point(0, 427);
			this.buttonGenerateMaze.Margin = new System.Windows.Forms.Padding(0, 3, 1, 0);
			this.buttonGenerateMaze.Name = "buttonGenerateMaze";
			this.buttonGenerateMaze.Size = new System.Drawing.Size(622, 57);
			this.buttonGenerateMaze.TabIndex = 10;
			this.buttonGenerateMaze.Text = "Generate Maze";
			this.buttonGenerateMaze.UseVisualStyleBackColor = false;
			this.buttonGenerateMaze.Click += new System.EventHandler(this.EventGenerateMazeButtonClick);
			// 
			// labelInstructions
			// 
			this.labelInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelInstructions.BackColor = System.Drawing.Color.Transparent;
			this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInstructions.ForeColor = System.Drawing.Color.Snow;
			this.labelInstructions.Location = new System.Drawing.Point(360, 1460);
			this.labelInstructions.Margin = new System.Windows.Forms.Padding(3);
			this.labelInstructions.Name = "labelInstructions";
			this.labelInstructions.Size = new System.Drawing.Size(553, 33);
			this.labelInstructions.TabIndex = 12;
			this.labelInstructions.Text = "Please Select a Size and Choose a Seed.";
			this.labelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelSeed
			// 
			this.panelSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panelSeed.Controls.Add(this.buttonSeedHelp);
			this.panelSeed.Controls.Add(this.buttonGenerateSeed);
			this.panelSeed.Controls.Add(this.txtSeed);
			this.panelSeed.Controls.Add(this.lblSeedTitle);
			this.panelSeed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSeed.Location = new System.Drawing.Point(624, 0);
			this.panelSeed.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.panelSeed.Name = "panelSeed";
			this.panelSeed.Size = new System.Drawing.Size(623, 424);
			this.panelSeed.TabIndex = 10;
			// 
			// buttonSeedHelp
			// 
			this.buttonSeedHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSeedHelp.AutoSize = true;
			this.buttonSeedHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonSeedHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonSeedHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonSeedHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonSeedHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonSeedHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSeedHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSeedHelp.ForeColor = System.Drawing.Color.White;
			this.buttonSeedHelp.Location = new System.Drawing.Point(579, 3);
			this.buttonSeedHelp.Name = "buttonSeedHelp";
			this.buttonSeedHelp.Size = new System.Drawing.Size(41, 43);
			this.buttonSeedHelp.TabIndex = 9;
			this.buttonSeedHelp.Text = "?";
			this.buttonSeedHelp.UseVisualStyleBackColor = false;
			this.buttonSeedHelp.Click += new System.EventHandler(this.EventSeedHelpButtonClick);
			// 
			// buttonGenerateSeed
			// 
			this.buttonGenerateSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerateSeed.AutoSize = true;
			this.buttonGenerateSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.buttonGenerateSeed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonGenerateSeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonGenerateSeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.buttonGenerateSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGenerateSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerateSeed.ForeColor = System.Drawing.Color.DodgerBlue;
			this.buttonGenerateSeed.Location = new System.Drawing.Point(133, 323);
			this.buttonGenerateSeed.Name = "buttonGenerateSeed";
			this.buttonGenerateSeed.Size = new System.Drawing.Size(350, 45);
			this.buttonGenerateSeed.TabIndex = 11;
			this.buttonGenerateSeed.Text = "Generate Random Seed";
			this.buttonGenerateSeed.UseVisualStyleBackColor = false;
			this.buttonGenerateSeed.Click += new System.EventHandler(this.EventGenerateSeedButtonClick);
			// 
			// txtSeed
			// 
			this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSeed.ForeColor = System.Drawing.Color.DodgerBlue;
			this.txtSeed.Location = new System.Drawing.Point(133, 184);
			this.txtSeed.MaxLength = 6;
			this.txtSeed.Name = "txtSeed";
			this.txtSeed.Size = new System.Drawing.Size(350, 49);
			this.txtSeed.TabIndex = 10;
			this.txtSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblSeedTitle
			// 
			this.lblSeedTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSeedTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeedTitle.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSeedTitle.Location = new System.Drawing.Point(250, 40);
			this.lblSeedTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lblSeedTitle.Name = "lblSeedTitle";
			this.lblSeedTitle.Size = new System.Drawing.Size(135, 64);
			this.lblSeedTitle.TabIndex = 10;
			this.lblSeedTitle.Text = "Seed";
			this.lblSeedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableMazeCreator
			// 
			this.tableMazeCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableMazeCreator.ColumnCount = 2;
			this.tableMazeCreator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableMazeCreator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableMazeCreator.Controls.Add(this.panelSize, 0, 0);
			this.tableMazeCreator.Controls.Add(this.panelSeed, 1, 0);
			this.tableMazeCreator.Controls.Add(this.buttonBackToMainMenu, 1, 1);
			this.tableMazeCreator.Controls.Add(this.buttonGenerateMaze, 0, 1);
			this.tableMazeCreator.Location = new System.Drawing.Point(5, 1850);
			this.tableMazeCreator.Name = "tableMazeCreator";
			this.tableMazeCreator.RowCount = 2;
			this.tableMazeCreator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableMazeCreator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableMazeCreator.Size = new System.Drawing.Size(1247, 484);
			this.tableMazeCreator.TabIndex = 13;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.tableMazeCreator);
			this.Controls.Add(this.labelInstructions);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.panelMainMenu);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Blue\'s Maze Game";
			this.Load += new System.EventHandler(this.EventLoad);
			this.panelMainMenu.ResumeLayout(false);
			this.panelSize.ResumeLayout(false);
			this.panelSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSize)).EndInit();
			this.panelSeed.ResumeLayout(false);
			this.panelSeed.PerformLayout();
			this.tableMazeCreator.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMainMenu;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSP;
		private System.Windows.Forms.Button buttonMP;
		private System.Windows.Forms.Button buttonSettings;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Timer timerMazeImgAnimation;
		private System.Windows.Forms.Panel panelSize;
		private System.Windows.Forms.Label lblSizeDisplay;
		private System.Windows.Forms.Label lblSizeTitle;
		private System.Windows.Forms.Label lblSizeLarge;
		private System.Windows.Forms.TrackBar sliderSize;
		private System.Windows.Forms.Label lblSizeSmall;
		private System.Windows.Forms.Button buttonBackToMainMenu;
		private System.Windows.Forms.Button buttonGenerateMaze;
		private System.Windows.Forms.Label labelInstructions;
		private System.Windows.Forms.Panel panelSeed;
		private System.Windows.Forms.Button buttonSeedHelp;
		private System.Windows.Forms.Button buttonGenerateSeed;
		private System.Windows.Forms.TextBox txtSeed;
		private System.Windows.Forms.Label lblSeedTitle;
		private System.Windows.Forms.TableLayoutPanel tableMazeCreator;
	}
}