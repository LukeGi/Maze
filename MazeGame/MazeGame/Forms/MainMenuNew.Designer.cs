namespace MazeGame.Forms
{
	partial class MainMenuNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuNew));
			this.pnlOptions = new System.Windows.Forms.Panel();
			this.btnOptions = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnMP = new System.Windows.Forms.Button();
			this.btnSP = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.imgMaze = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlline = new System.Windows.Forms.Panel();
			this.pnlOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgMaze)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlOptions
			// 
			this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.pnlOptions.Controls.Add(this.pnlline);
			this.pnlOptions.Controls.Add(this.btnOptions);
			this.pnlOptions.Controls.Add(this.btnQuit);
			this.pnlOptions.Controls.Add(this.btnMP);
			this.pnlOptions.Controls.Add(this.btnSP);
			this.pnlOptions.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions.Name = "pnlOptions";
			this.pnlOptions.Size = new System.Drawing.Size(382, 682);
			this.pnlOptions.TabIndex = 0;
			// 
			// btnOptions
			// 
			this.btnOptions.AutoSize = true;
			this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnOptions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOptions.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnOptions.Location = new System.Drawing.Point(54, 321);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(276, 47);
			this.btnOptions.TabIndex = 3;
			this.btnOptions.Text = "Options";
			this.btnOptions.UseVisualStyleBackColor = false;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.AutoSize = true;
			this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnQuit.Location = new System.Drawing.Point(54, 374);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(276, 47);
			this.btnQuit.TabIndex = 4;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = false;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// btnMP
			// 
			this.btnMP.AutoSize = true;
			this.btnMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnMP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnMP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMP.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnMP.Location = new System.Drawing.Point(54, 268);
			this.btnMP.Name = "btnMP";
			this.btnMP.Size = new System.Drawing.Size(276, 47);
			this.btnMP.TabIndex = 2;
			this.btnMP.Text = "Multi Player";
			this.btnMP.UseVisualStyleBackColor = false;
			this.btnMP.Click += new System.EventHandler(this.btnMP_Click);
			// 
			// btnSP
			// 
			this.btnSP.AutoSize = true;
			this.btnSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.btnSP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSP.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.btnSP.Location = new System.Drawing.Point(54, 215);
			this.btnSP.Name = "btnSP";
			this.btnSP.Size = new System.Drawing.Size(276, 47);
			this.btnSP.TabIndex = 1;
			this.btnSP.Text = "Single Player";
			this.btnSP.UseVisualStyleBackColor = false;
			this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Marshmallows and Chocolate", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(417, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(835, 128);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Blue\'s Maze Game";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imgMaze
			// 
			this.imgMaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgMaze.BackgroundImage = global::MazeGame.Properties.Resources.Maze;
			this.imgMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.imgMaze.Location = new System.Drawing.Point(583, 173);
			this.imgMaze.Name = "imgMaze";
			this.imgMaze.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.imgMaze.Size = new System.Drawing.Size(450, 450);
			this.imgMaze.TabIndex = 2;
			this.imgMaze.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 5;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pnlline
			// 
			this.pnlline.BackColor = System.Drawing.Color.Black;
			this.pnlline.Location = new System.Drawing.Point(367, 0);
			this.pnlline.Name = "pnlline";
			this.pnlline.Size = new System.Drawing.Size(15, 682);
			this.pnlline.TabIndex = 0;
			this.pnlline.TabStop = true;
			// 
			// MainMenuNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.imgMaze);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.pnlOptions);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainMenuNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenuNew";
			this.Load += new System.EventHandler(this.MainMenuNew_Load);
			this.pnlOptions.ResumeLayout(false);
			this.pnlOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgMaze)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlOptions;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnMP;
		private System.Windows.Forms.Button btnSP;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox imgMaze;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel pnlline;
	}
}