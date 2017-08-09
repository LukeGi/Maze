namespace MazeGame.Forms
{
	partial class MazePlayForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazePlayForm));
			this.lblInfo = new System.Windows.Forms.Label();
			this.mazePanel1 = new MazeGame.Controls.MazePanel();
			this.zoom = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.zoom)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.Font = new System.Drawing.Font("Marshmallows and Chocolate", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.ForeColor = System.Drawing.Color.White;
			this.lblInfo.Location = new System.Drawing.Point(13, 8);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(600, 57);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "___ x ___ Maze | Seed: ";
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mazePanel1
			// 
			this.mazePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mazePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.mazePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mazePanel1.BackgroundImage")));
			this.mazePanel1.Location = new System.Drawing.Point(12, 69);
			this.mazePanel1.MazeBackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.mazePanel1.Name = "mazePanel1";
			this.mazePanel1.Size = new System.Drawing.Size(601, 601);
			this.mazePanel1.TabIndex = 3;
			this.mazePanel1.WallColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.mazePanel1.ZoomX = 0;
			this.mazePanel1.ZoomY = 0;
			// 
			// zoom
			// 
			this.zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.zoom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.zoom.LargeChange = 10;
			this.zoom.Location = new System.Drawing.Point(0, 39);
			this.zoom.Maximum = 100;
			this.zoom.MinimumSize = new System.Drawing.Size(0, 45);
			this.zoom.Name = "zoom";
			this.zoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.zoom.Size = new System.Drawing.Size(633, 45);
			this.zoom.TabIndex = 1;
			this.zoom.TickFrequency = 10;
			this.zoom.Value = 50;
			this.zoom.Scroll += new System.EventHandler(this.zoom_Scroll);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.MaximumSize = new System.Drawing.Size(0, 37);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(633, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zoom Level";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.zoom);
			this.panel1.Location = new System.Drawing.Point(619, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(633, 84);
			this.panel1.TabIndex = 5;
			// 
			// MazePlayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.mazePanel1);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MazePlayForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Maze Game - Game";
			this.Load += new System.EventHandler(this.MazePlayForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.zoom)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblInfo;
		private Controls.MazePanel mazePanel1;
		private System.Windows.Forms.TrackBar zoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}