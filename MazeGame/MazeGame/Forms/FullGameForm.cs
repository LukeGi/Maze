using BlueMonster.Utilities;
using MazeGame.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame.Forms
{
	public partial class GameForm : Form
	{
		#region ----- Variables -----

		private Page CurrentPage = Page.None;
		private Rectangle BBMazeImg = new Rectangle();
		private float ZoomMazeImg = 0.8F;
		private bool animationMazeImgGrow = false;
		private Color LightBG = Color.FromArgb(50, 50, 50);
		private Color DarkBG = Color.FromArgb(20, 20, 20);
		private MazeData m_MazeData = new MazeData();

		#endregion

		#region ----- Main Menu Methods -----

		private void ResizeBoundingBox()
		{
			int size = (int)(Math.Min(ClientSize.Width - (panelMainMenu.Right + 20), ClientSize.Height - (labelTitle.Bottom + 10)) * ZoomMazeImg);
			BBMazeImg.X = (panelMainMenu.Right + 20) + ((ClientSize.Width - (panelMainMenu.Right + 20) - size) / 2);
			BBMazeImg.Y = (labelTitle.Bottom + 10) + ((ClientSize.Height - (labelTitle.Bottom + 10) - size) / 2);
			BBMazeImg.Width = size;
			BBMazeImg.Height = size;
			Invalidate();
		}

		#endregion

		#region ----- Maze Creator Methods -----

		private void GenerateRandomSeed()
		{
			string s;
			Random rand = new Random();
			for (s = string.Empty; s.Length < txtSeed.MaxLength; s += rand.Next(9)) { }
			rand = null;
			txtSeed.Text = s;
			int.TryParse(s, out m_MazeData.Seed);
		}

		#endregion

		#region ----- State Machine -----

		private void SwitchToPage(Page target)
		{
			switch (CurrentPage)
			{
				case Page.MainMenu:
					panelMainMenu.Visible = false;
					labelTitle.Visible = false;
					Invalidate();
					break;
				case Page.MazeCreator:
					labelTitle.Visible = false;
					labelInstructions.Visible = false;
					tableMazeCreator.Visible = false;
					break;
			}
			CurrentPage = target;
			switch (CurrentPage)
			{
				case Page.MainMenu:
					labelTitle.Left = 377;
					labelTitle.Top = 12;
					panelMainMenu.Visible = true;
					labelTitle.Visible = true;
					ResizeBoundingBox();
					break;
				case Page.MazeCreator:
					labelTitle.Left = 219;
					labelTitle.Top = 12;
					labelTitle.Visible = true;
					labelInstructions.Visible = true;
					tableMazeCreator.Visible = true;
					break;
			}
		}

		#endregion

		#region ----- Override Methods -----

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			switch (CurrentPage)
			{
				case Page.MainMenu:
					e.Graphics.FillRectangle(Brushes.Black, panelMainMenu.Right, 0, 10, Height);
					e.Graphics.DrawImage(Resources.Maze, BBMazeImg);
					break;
			}

		}

		#endregion

		#region ----- Event Handlers -----

		#region --- Form Events ---

		private void EventLoad(object sender, EventArgs e)
		{
			for (int i = 0; i < Controls.Count; i++)
				Controls[i].Visible = false;
			GenerateRandomSeed();
			panelMainMenu.Left = 0;
			panelMainMenu.Top = 0;
			labelInstructions.Left = 360;
			labelInstructions.Top = 146;
			tableMazeCreator.Left = 5;
			tableMazeCreator.Top = 185;
			SwitchToPage(Page.MainMenu);
		}

		private void EventResize(object sender, EventArgs e)
		{
			ResizeBoundingBox();
		}

		private void EventMoveMouse(object sender, MouseEventArgs e)
		{
			switch (CurrentPage)
			{
				case Page.MainMenu:
					if (BBMazeImg.Contains(e.Location))
					{
						animationMazeImgGrow = true;
						if (!timerMazeImgAnimation.Enabled)
							timerMazeImgAnimation.Start();
					}
					else if (ZoomMazeImg > 0.8F)
					{
						animationMazeImgGrow = false;
						if (!timerMazeImgAnimation.Enabled)
							timerMazeImgAnimation.Start();
					}
					break;
			}
		}

		#endregion

		#region --- Timer Events ---

		private void EventAnimationTimerTick(object sender, EventArgs e)
		{
			if (CurrentPage != Page.MainMenu)
			{
				timerMazeImgAnimation.Stop();
				return;
			}
			if (animationMazeImgGrow)
				if (ZoomMazeImg < 0.95F)
				{
					ZoomMazeImg += 0.01F;
					ResizeBoundingBox();
				}
				else
				{
					timerMazeImgAnimation.Stop();
					return;
				}
			else
			{
				if (ZoomMazeImg > 0.8F)
				{
					ZoomMazeImg -= 0.01F;
					ResizeBoundingBox();
				}
				else
				{
					timerMazeImgAnimation.Stop();
					return;
				}
			}
		}

		#endregion

		#region --- Keyboard Events ---

		private void EventKeyPressInSeedTxt(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				case '	':
				case '\b':
					break;
				case '\n':
				case '\r':
					this.ActiveControl = null;
					e.Handled = true;
					break;
				default:
					e.Handled = true;
					break;
			}
		}

		#endregion

		#region --- Scroller Events ---

		private void EventSideScrollerChanged(object sender, EventArgs e)
		{
			switch (sliderSize.Value)
			{
				case 0:
					lblSizeDisplay.Text = "Chosen Size: 5x5";
					m_MazeData.Width = m_MazeData.Height = 5;
					break;
				case 1:
					lblSizeDisplay.Text = "Chosen Size: 8x8";
					m_MazeData.Width = m_MazeData.Height = 8;
					break;
				case 2:
					lblSizeDisplay.Text = "Chosen Size: 12x12";
					m_MazeData.Width = m_MazeData.Height = 12;
					break;
				case 3:
					lblSizeDisplay.Text = "Chosen Size: 15x15";
					m_MazeData.Width = m_MazeData.Height = 15;
					break;
				case 4:
					lblSizeDisplay.Text = "Chosen Size: 20x20";
					m_MazeData.Width = m_MazeData.Height = 20;
					break;
				case 5:
					lblSizeDisplay.Text = "Chosen Size: 25x25";
					m_MazeData.Width = m_MazeData.Height = 25;
					break;
				case 6:
					lblSizeDisplay.Text = "Chosen Size: 30x30";
					m_MazeData.Width = m_MazeData.Height = 30;
					break;
				case 7:
					lblSizeDisplay.Text = "Chosen Size: 40x40";
					m_MazeData.Width = m_MazeData.Height = 40;
					break;
				case 8:
					lblSizeDisplay.Text = "Chosen Size: 50x50";
					m_MazeData.Width = m_MazeData.Height = 50;
					break;
				case 9:
					lblSizeDisplay.Text = "Chosen Size: 60x60";
					m_MazeData.Width = m_MazeData.Height = 60;
					break;
				case 10:
					lblSizeDisplay.Text = "Chosen Size: 75x75";
					m_MazeData.Width = m_MazeData.Height = 75;
					break;
				case 11:
					lblSizeDisplay.Text = "Chosen Size: 100x100";
					m_MazeData.Width = m_MazeData.Height = 100;
					break;
			}
		}

		#endregion

		#region --- Button Events --- 

		#region - Main Menu Buttons -

		private void EventSPButtonClick(object sender, EventArgs e)
		{
			SwitchToPage(Page.MazeCreator);
		}

		private void EventMPButtonClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EventSettingsButtonClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EventExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region - Maze Creator Buttons -

		private void EventGenerateMazeButtonClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EventBackToMainMenuButtonClick(object sender, EventArgs e)
		{
			SwitchToPage(Page.MainMenu);
		}

		private void EventGenerateSeedButtonClick(object sender, EventArgs e)
		{
			GenerateRandomSeed();
		}

		private void EventSeedHelpButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("A Seed is a number used the the random number generator to choose how the maze is built. If you use the same seed and size you should get the same maze, everytime.", "What is a Seed?");
		}

		#endregion

		#endregion

		#endregion

		#region ----- Constructor -----

		public GameForm()
		{
			InitializeComponent();
			ResizeRedraw = true;


			MouseMove += EventMoveMouse;
			Resize += EventResize;

			txtSeed.KeyPress += EventKeyPressInSeedTxt;
		}

		#endregion
	}
}
