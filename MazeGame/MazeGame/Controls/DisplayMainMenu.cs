using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MazeGame.Controls
{
	public partial class DisplayMainMenu : UserControl
	{
		private Bitmap Cache;
		private Parts[] parts;

		public DisplayMainMenu()
		{
			InitializeComponent();

			Resize += DisplayMainMenu_Resize;
			Disposed += DisplayMainMenu_Disposed;

			InitializeDisplay();
		}

		private void InitializeDisplay()
		{
			this.ClientSize = new Size(1280, 720);
			RefreshCache();
			Graphics g = Graphics.FromImage(Cache);
			AddBackground(g);
			AddMenuComponents(g);
			AddText(g);
			BackgroundImage = (Image)Cache;
			g.Dispose();
		}

		private void AddBackground(Graphics g)
		{
			float MagicNumber = 255.0F / Cache.Height;
			float c = 0;
			for (int i = 0; i < Cache.Height; i++, c += MagicNumber)
			{
				Color colour = Color.FromArgb((int)c, (int)c, (int)c);
				g.DrawRectangle(new Pen(new SolidBrush(colour)), 0, i, Cache.Width, i);
			}
		}

		private void AddMenuComponents(Graphics g)
		{
			
		}

		private void AddText(Graphics g)
		{
			throw new NotImplementedException();
		}

		private void RefreshCache()
		{
			Cache = new Bitmap(ClientSize.Width, ClientSize.Height, PixelFormat.Format32bppArgb);
		}

		private void DisplayMainMenu_Resize(object sender, EventArgs e)
		{
			RefreshCache();
		}

		private void DisplayMainMenu_Disposed(object sender, EventArgs e)
		{
			Cache.Dispose();
		}

		private struct Parts
		{
			public Point[] shape;
			public bool hasOutline;
			public Color outlineColour;
			public bool fill;
			public Color backgroundColour;
		}
	}
}
