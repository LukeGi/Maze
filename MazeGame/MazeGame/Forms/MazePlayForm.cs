using BlueMonster.Utilities;
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
	public partial class MazePlayForm : Form
	{
		public MazeData Data { get { return mazePanel1.MazeData; } set { mazePanel1.MazeData = value; } }
		public Form Par { get; set; }

		public MazePlayForm()
		{
			InitializeComponent();

			Resize += MazePlayForm_Resize;
			Shown += ShownEvent;
			FormClosed += FormClosedEvent;
		}

		private void FormClosedEvent(object sender, FormClosedEventArgs e)
		{
			Par.Show();
		}

		private void ShownEvent(object sender, EventArgs e)
		{
			if(Par is MazeCreator)
			{
				using (MazeCreator mc = Par as MazeCreator)
				{
					Par = mc.Par;
				}
			}
		}

		private void MazePlayForm_Resize(object sender, EventArgs e)
		{
			lblInfo.Width = mazePanel1.Width;
		}

		private void MazePlayForm_Load(object sender, EventArgs e)
		{
			lblInfo.Text = $"{mazePanel1.MazeData.Width} x {mazePanel1.MazeData.Height} | Seed: {mazePanel1.MazeData.Seed}";
			zoom.Minimum = (int)Math.Min(mazePanel1.MazeData.CellSizeX, mazePanel1.MazeData.CellSizeY);
			mazePanel1.ZoomX = zoom.Value;
			mazePanel1.ZoomY = zoom.Value;
		}

		private void zoom_Scroll(object sender, EventArgs e)
		{
			mazePanel1.ZoomX = zoom.Value;
			mazePanel1.ZoomY = zoom.Value;
		}
	}
}
