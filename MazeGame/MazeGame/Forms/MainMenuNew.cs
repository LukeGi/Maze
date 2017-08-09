using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame.Forms
{
	public partial class MainMenuNew : Form
	{
		int imgzoom = 35;
		bool inImage = false;

		public MainMenuNew()
		{
			InitializeComponent();
			ClientSizeChanged += MainMenuNew_ClientSizeChanged;
			imgMaze.MouseEnter += ImgMaze_MouseEnter;
			imgMaze.MouseLeave += ImgMaze_MouseLeave;
		}

		#region --- Event Handlers ---

		private void MainMenuNew_ClientSizeChanged(object sender, EventArgs e)
		{
			ResizeControls();
		}

		private void MainMenuNew_Load(object sender, EventArgs e)
		{
			ResizeControls();
			timer1.Start();
		}

		private void ImgMaze_MouseLeave(object sender, EventArgs e)
		{
			inImage = false;
		}

		private void ImgMaze_MouseEnter(object sender, EventArgs e)
		{
			inImage = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (inImage)
			{
				if (imgzoom > 5)
					ResizeMaze(--imgzoom);
			}
			else if (imgzoom < 35)
			{
				ResizeMaze(++imgzoom);
			}
		}

		private void btnSP_Click(object sender, EventArgs e)
		{
			CreateSPSession();
		}

		private void btnMP_Click(object sender, EventArgs e)
		{
			CreateMPSession();
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			OpenOptions();
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region --- Resize Methods ---

		private void ResizeControls()
		{
			pnlOptions.Width = (int)(ClientSize.Width * 0.25);
			pnlOptions.Height = ClientSize.Height;
			pnlOptions.Top = 0;
			pnlOptions.Left = 0;

			pnlline.Width = 5;
			pnlline.Height = ClientSize.Height;
			pnlline.Left = pnlOptions.Right;
			pnlline.Top = 0;

			btnSP.Height = 50;
			btnMP.Height = 50;
			btnOptions.Height = 50;
			btnQuit.Height = 50;

			btnSP.Width = pnlOptions.ClientSize.Width - 20;
			btnMP.Width = pnlOptions.ClientSize.Width - 20;
			btnOptions.Width = pnlOptions.ClientSize.Width - 20;
			btnQuit.Width = pnlOptions.ClientSize.Width - 20;

			btnSP.Left = 10;
			btnMP.Left = 10;
			btnOptions.Left = 10;
			btnQuit.Left = 10;

			btnSP.Top = (pnlOptions.ClientSize.Height - btnSP.Height - btnMP.Height - 53) / 2;
			btnMP.Top = btnSP.Bottom + 2;
			btnOptions.Top = btnMP.Bottom + 3;
			btnQuit.Top = btnOptions.Bottom + 3;

			lblTitle.Left = (ClientSize.Width + pnlOptions.Right - lblTitle.Width) / 2;
			lblTitle.Top = 3;
			lblTitle.BackColor = Color.Transparent;

			ResizeMaze(35);
		}

		private void ResizeMaze(int edge)
		{
			int Smallest = Math.Min((ClientSize.Width - pnlOptions.Right - (edge * 2)), (ClientSize.Height - lblTitle.Bottom - (edge * 2)));
			imgMaze.Width = Smallest;
			imgMaze.Height = Smallest;
			imgMaze.Top = (ClientSize.Height + lblTitle.Bottom - imgMaze.Height) / 2;
			imgMaze.Left = (ClientSize.Width + pnlOptions.Right - imgMaze.Width) / 2;
		}

		#endregion

		#region --- Button Methods ---

		private void CreateSPSession()
		{
			using (MazeCreator form = new MazeCreator() { WindowState = this.WindowState, Par = this })
			{
				form.ShowDialog(this);
			}
		}

		private void CreateMPSession()
		{
			ShowError(btnMP);
		}

		private void OpenOptions()
		{
			ShowError(btnOptions);
		}

		#endregion

		#region --- Helper Methods ---

		private void ShowError(Button btn)
		{
			MessageBox.Show($"Sorry, but {btn.Text} is not yet implemented.", "Sad Times");
		}

		#endregion
	}
}
