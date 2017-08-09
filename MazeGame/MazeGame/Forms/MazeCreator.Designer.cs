namespace MazeGame.Forms
{
	partial class MazeCreator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeCreator));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblInstr = new System.Windows.Forms.Label();
			this.pnlSize = new System.Windows.Forms.Panel();
			this.lblSizeDisplay = new System.Windows.Forms.Label();
			this.lblSizeTitle = new System.Windows.Forms.Label();
			this.lblSizeLarge = new System.Windows.Forms.Label();
			this.sliderSize = new System.Windows.Forms.TrackBar();
			this.lblSizeSmall = new System.Windows.Forms.Label();
			this.pnlSeed = new System.Windows.Forms.Panel();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnGenseed = new System.Windows.Forms.Button();
			this.txtSeed = new System.Windows.Forms.TextBox();
			this.lblSeedTitle = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.pnlSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSize)).BeginInit();
			this.pnlSeed.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(214, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(835, 128);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Blue\'s Maze Game";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTitle.Visible = false;
			// 
			// lblInstr
			// 
			this.lblInstr.AutoSize = true;
			this.lblInstr.BackColor = System.Drawing.Color.Transparent;
			this.lblInstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstr.ForeColor = System.Drawing.Color.Snow;
			this.lblInstr.Location = new System.Drawing.Point(346, 137);
			this.lblInstr.Name = "lblInstr";
			this.lblInstr.Size = new System.Drawing.Size(553, 33);
			this.lblInstr.TabIndex = 1;
			this.lblInstr.Text = "Please Select a Size and Choose a Seed.";
			this.lblInstr.Visible = false;
			// 
			// pnlSize
			// 
			this.pnlSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.pnlSize.Controls.Add(this.lblSizeDisplay);
			this.pnlSize.Controls.Add(this.lblSizeTitle);
			this.pnlSize.Controls.Add(this.lblSizeLarge);
			this.pnlSize.Controls.Add(this.sliderSize);
			this.pnlSize.Controls.Add(this.lblSizeSmall);
			this.pnlSize.Location = new System.Drawing.Point(29, 186);
			this.pnlSize.Name = "pnlSize";
			this.pnlSize.Padding = new System.Windows.Forms.Padding(5);
			this.pnlSize.Size = new System.Drawing.Size(457, 393);
			this.pnlSize.TabIndex = 2;
			this.pnlSize.Visible = false;
			// 
			// lblSizeDisplay
			// 
			this.lblSizeDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSizeDisplay.AutoSize = true;
			this.lblSizeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeDisplay.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblSizeDisplay.Location = new System.Drawing.Point(164, 148);
			this.lblSizeDisplay.Name = "lblSizeDisplay";
			this.lblSizeDisplay.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
			this.lblSizeDisplay.Size = new System.Drawing.Size(128, 62);
			this.lblSizeDisplay.TabIndex = 9;
			this.lblSizeDisplay.Text = "label2";
			this.lblSizeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSizeDisplay.Visible = false;
			// 
			// lblSizeTitle
			// 
			this.lblSizeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSizeTitle.AutoSize = true;
			this.lblSizeTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeTitle.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSizeTitle.Location = new System.Drawing.Point(169, 20);
			this.lblSizeTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lblSizeTitle.Name = "lblSizeTitle";
			this.lblSizeTitle.Size = new System.Drawing.Size(114, 64);
			this.lblSizeTitle.TabIndex = 7;
			this.lblSizeTitle.Text = "Size";
			this.lblSizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSizeTitle.Visible = false;
			// 
			// lblSizeLarge
			// 
			this.lblSizeLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSizeLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeLarge.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeLarge.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblSizeLarge.Location = new System.Drawing.Point(349, 292);
			this.lblSizeLarge.MinimumSize = new System.Drawing.Size(100, 45);
			this.lblSizeLarge.Name = "lblSizeLarge";
			this.lblSizeLarge.Padding = new System.Windows.Forms.Padding(3);
			this.lblSizeLarge.Size = new System.Drawing.Size(100, 45);
			this.lblSizeLarge.TabIndex = 6;
			this.lblSizeLarge.Text = "Large";
			this.lblSizeLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSizeLarge.Visible = false;
			// 
			// sliderSize
			// 
			this.sliderSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sliderSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.sliderSize.LargeChange = 1;
			this.sliderSize.Location = new System.Drawing.Point(8, 340);
			this.sliderSize.Maximum = 11;
			this.sliderSize.Name = "sliderSize";
			this.sliderSize.Size = new System.Drawing.Size(441, 45);
			this.sliderSize.TabIndex = 4;
			this.sliderSize.TabStop = false;
			this.sliderSize.TickFrequency = 11;
			this.sliderSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.sliderSize.Value = 4;
			this.sliderSize.Visible = false;
			this.sliderSize.Scroll += new System.EventHandler(this.sliderSize_Scroll);
			// 
			// lblSizeSmall
			// 
			this.lblSizeSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSizeSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.lblSizeSmall.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSizeSmall.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblSizeSmall.Location = new System.Drawing.Point(8, 292);
			this.lblSizeSmall.MinimumSize = new System.Drawing.Size(100, 45);
			this.lblSizeSmall.Name = "lblSizeSmall";
			this.lblSizeSmall.Padding = new System.Windows.Forms.Padding(3);
			this.lblSizeSmall.Size = new System.Drawing.Size(100, 45);
			this.lblSizeSmall.TabIndex = 5;
			this.lblSizeSmall.Text = "Small";
			this.lblSizeSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSizeSmall.Visible = false;
			// 
			// pnlSeed
			// 
			this.pnlSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.pnlSeed.Controls.Add(this.btnHelp);
			this.pnlSeed.Controls.Add(this.btnGenseed);
			this.pnlSeed.Controls.Add(this.txtSeed);
			this.pnlSeed.Controls.Add(this.lblSeedTitle);
			this.pnlSeed.Location = new System.Drawing.Point(661, 186);
			this.pnlSeed.Name = "pnlSeed";
			this.pnlSeed.Size = new System.Drawing.Size(550, 385);
			this.pnlSeed.TabIndex = 3;
			this.pnlSeed.Visible = false;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHelp.AutoSize = true;
			this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnHelp.Location = new System.Drawing.Point(508, 3);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(39, 41);
			this.btnHelp.TabIndex = 9;
			this.btnHelp.Text = "?";
			this.btnHelp.UseVisualStyleBackColor = false;
			this.btnHelp.Visible = false;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnGenseed
			// 
			this.btnGenseed.AutoSize = true;
			this.btnGenseed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnGenseed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenseed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenseed.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnGenseed.Location = new System.Drawing.Point(121, 230);
			this.btnGenseed.Name = "btnGenseed";
			this.btnGenseed.Size = new System.Drawing.Size(345, 43);
			this.btnGenseed.TabIndex = 11;
			this.btnGenseed.Text = "Generate Random Seed";
			this.btnGenseed.UseVisualStyleBackColor = false;
			this.btnGenseed.Visible = false;
			this.btnGenseed.Click += new System.EventHandler(this.btnGenseed_Click);
			// 
			// txtSeed
			// 
			this.txtSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.txtSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSeed.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.txtSeed.Location = new System.Drawing.Point(121, 175);
			this.txtSeed.MaxLength = 6;
			this.txtSeed.Name = "txtSeed";
			this.txtSeed.Size = new System.Drawing.Size(267, 49);
			this.txtSeed.TabIndex = 10;
			this.txtSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSeed.Visible = false;
			// 
			// lblSeedTitle
			// 
			this.lblSeedTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSeedTitle.AutoSize = true;
			this.lblSeedTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeedTitle.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblSeedTitle.Location = new System.Drawing.Point(214, 20);
			this.lblSeedTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lblSeedTitle.Name = "lblSeedTitle";
			this.lblSeedTitle.Size = new System.Drawing.Size(135, 64);
			this.lblSeedTitle.TabIndex = 10;
			this.lblSeedTitle.Text = "Seed";
			this.lblSeedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSeedTitle.Visible = false;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.Black;
			this.btnBack.Location = new System.Drawing.Point(641, 618);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(300, 60);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Main Menu";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Visible = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.ForestGreen;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnNext.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(335, 618);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(300, 60);
			this.btnNext.TabIndex = 7;
			this.btnNext.Text = "Generate Maze";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Visible = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// MazeCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.pnlSeed);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.pnlSize);
			this.Controls.Add(this.lblInstr);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblTitle);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Marshmallows and Chocolate", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "MazeCreator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MazeCreator";
			this.Load += new System.EventHandler(this.MazeCreator_Load);
			this.pnlSize.ResumeLayout(false);
			this.pnlSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sliderSize)).EndInit();
			this.pnlSeed.ResumeLayout(false);
			this.pnlSeed.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblInstr;
		private System.Windows.Forms.Panel pnlSize;
		private System.Windows.Forms.Panel pnlSeed;
		private System.Windows.Forms.Label lblSizeLarge;
		private System.Windows.Forms.TrackBar sliderSize;
		private System.Windows.Forms.Label lblSizeSmall;
		private System.Windows.Forms.Label lblSizeTitle;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblSizeDisplay;
		private System.Windows.Forms.Label lblSeedTitle;
		private System.Windows.Forms.TextBox txtSeed;
		private System.Windows.Forms.Button btnGenseed;
		private System.Windows.Forms.Button btnHelp;
	}
}