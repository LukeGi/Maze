using BlueMonster.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MazeGame.Forms
{
	public partial class MazeCreator : Form
	{
		private int i = 0;
		private int size = 20;
		private Random rand;

		public Form Par { get; set; }

		public MazeCreator()
		{
			InitializeComponent();

			ClientSizeChanged += ClientSize_Changed;
			Shown += HideParent;

			btnNext.MouseEnter += BtnNext_MouseEnter;
			btnNext.MouseLeave += BtnNext_MouseLeave;
			btnBack.MouseEnter += BtnBack_MouseEnter;
			btnBack.MouseLeave += BtnBack_MouseLeave;
			btnGenseed.MouseEnter += BtnGenseed_MouseEnter;
			btnGenseed.MouseLeave += BtnGenseed_MouseLeave;
			txtSeed.KeyPress += TextBox1_KeyPress;
		}

		#region --- Event Handlers ---

		private void MazeCreator_Load(object sender, EventArgs e)
		{
			ResizeControls();
			UpdateSizeDisplay();
			GenerateRandomSeed();
		}

		private void ClientSize_Changed(object sender, EventArgs e)
		{
			ResizeControls();
		}

		private void BtnNext_MouseLeave(object sender, EventArgs e)
		{
			btnNext.BackColor = Color.ForestGreen;
		}

		private void BtnNext_MouseEnter(object sender, EventArgs e)
		{
			btnNext.BackColor = Color.Lime;
		}

		private void BtnBack_MouseEnter(object sender, EventArgs e)
		{
			btnBack.BackColor = Color.FromArgb(238, 27, 36);
		}

		private void BtnBack_MouseLeave(object sender, EventArgs e)
		{
			btnBack.BackColor = Color.FromArgb(139, 34, 34);
		}

		private void sliderSize_Scroll(object sender, EventArgs e)
		{
			UpdateSizeDisplay();
		}

		private void BtnGenseed_MouseEnter(object sender, EventArgs e)
		{
			btnGenseed.BackColor = Color.FromArgb(75, 75, 75);
		}

		private void BtnGenseed_MouseLeave(object sender, EventArgs e)
		{
			btnGenseed.BackColor = Color.FromArgb(50, 50, 50);
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A Seed is a number used the the random number generator to choose how the maze is built. If you use the same seed and size you should get the same maze, everytime.", "What is a Seed?");
		}

		private void btnGenseed_Click(object sender, EventArgs e)
		{
			GenerateRandomSeed();
		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

		private void btnNext_Click(object sender, EventArgs e)
		{
			StartGameInstance();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Par.Show();
			this.Close();
		}

		private void HideParent(object sender, EventArgs e)
		{
			Par.Hide();
		}

		#endregion

		#region --- Resizing & Positioning Methods ---

		private void ResizeControls()
		{
			RepositionTitle();
			RepositionInstruction();
			RepositionButtons();
			RepositionPanels();
		}

		private void RepositionTitle()
		{
			lblTitle.Left = (ClientSize.Width - lblTitle.Width) / 2;
			lblTitle.Top = 3;
		}

		private void RepositionInstruction()
		{
			lblInstr.Left = (ClientSize.Width - lblInstr.Width) / 2;
			lblInstr.Top = lblTitle.Bottom + 3;
		}

		private void RepositionPanels()
		{
			// Size Panel
			pnlSize.Width = (ClientSize.Width / 2) - 4;
			pnlSize.Height = ClientSize.Height - (lblInstr.Bottom + btnNext.Height + 12);
			pnlSize.Left = 3;
			pnlSize.Top = lblInstr.Bottom + 6;

			lblSizeTitle.Top = 15;
			lblSizeTitle.Left = (pnlSize.ClientSize.Width - lblSizeTitle.Width) / 2;

			RepositionSizeDisplay();

			// Seed Panel
			pnlSeed.Width = (ClientSize.Width / 2) - 4;
			pnlSeed.Height = ClientSize.Height - (lblInstr.Bottom + btnBack.Height + 12);
			pnlSeed.Left = ClientSize.Width - (pnlSeed.Width + 3);
			pnlSeed.Top = lblInstr.Bottom + 6;

			lblSeedTitle.Top = 15;
			lblSeedTitle.Left = (pnlSeed.ClientSize.Width - lblSeedTitle.Width) / 2;

			txtSeed.Width = btnGenseed.Width;
			txtSeed.Top = ((pnlSeed.ClientSize.Height + lblSeedTitle.Bottom - txtSeed.Height) / 2) - btnGenseed.Height;
			txtSeed.Left = (pnlSeed.ClientSize.Width - txtSeed.Width) / 2; // TODO: Make this acknowledge the generate random seed button.

			btnGenseed.Top = txtSeed.Bottom + 3;
			btnGenseed.Left = txtSeed.Left;
		}

		private void RepositionSizeDisplay()
		{
			lblSizeDisplay.Top = (pnlSize.ClientSize.Height - sliderSize.Height - lblSizeLarge.Height - lblSizeDisplay.Height + lblSizeTitle.Bottom) / 2;
			lblSizeDisplay.Left = (pnlSize.ClientSize.Width - lblSizeDisplay.Width) / 2;
		}

		private void RepositionButtons()
		{
			btnNext.Left = (ClientSize.Width / 2) - btnNext.Width - 1;
			btnNext.Top = ClientSize.Height - btnNext.Height - 3;
			btnBack.Left = (ClientSize.Width / 2) + 1;
			btnBack.Top = ClientSize.Height - btnBack.Height - 3;
		}

		#endregion

		#region --- Utility Methods ---

		private void UpdateSizeDisplay()
		{
			switch (sliderSize.Value)
			{
				case 0:
					lblSizeDisplay.Text = "Chosen Size: 5x5";
					size = 5;
					break;
				case 1:
					lblSizeDisplay.Text = "Chosen Size: 8x8";
					size = 8;
					break;
				case 2:
					lblSizeDisplay.Text = "Chosen Size: 12x12";
					size = 12;
					break;
				case 3:
					lblSizeDisplay.Text = "Chosen Size: 15x15";
					size = 15;
					break;
				case 4:
					lblSizeDisplay.Text = "Chosen Size: 20x20";
					size = 20;
					break;
				case 5:
					lblSizeDisplay.Text = "Chosen Size: 25x25";
					size = 25;
					break;
				case 6:
					lblSizeDisplay.Text = "Chosen Size: 30x30";
					size = 30;
					break;
				case 7:
					lblSizeDisplay.Text = "Chosen Size: 40x40";
					size = 40;
					break;
				case 8:
					lblSizeDisplay.Text = "Chosen Size: 50x50";
					size = 50;
					break;
				case 9:
					lblSizeDisplay.Text = "Chosen Size: 60x60";
					size = 60;
					break;
				case 10:
					lblSizeDisplay.Text = "Chosen Size: 75x75";
					size = 75;
					break;
				case 11:
					lblSizeDisplay.Text = "Chosen Size: 100x100";
					size = 100;
					break;
			}
			RepositionSizeDisplay();
		}

		private void GenerateRandomSeed()
		{
			string s;
			Random rand = new Random();
			for (s = string.Empty; s.Length < txtSeed.MaxLength; s += rand.Next(9)) { }
			rand = null;
			txtSeed.Text = s;
		}

		#endregion

		#region --- Button Methods ---

		private void StartGameInstance()
		{
			int.TryParse(txtSeed.Text, out int seed);
			MazePlayForm form = new MazePlayForm()
			{
				Data = new MazeData
				{
					Width = size,
					Height = size,
					Seed = seed,
					StartPosition = 0,
					EndPosition = (size * size) - 1
				},
				Par = this
			};
			form.WindowState = this.WindowState;
			Par.WindowState = this.WindowState;
			form.Show();
		}

		#endregion
	}
}
