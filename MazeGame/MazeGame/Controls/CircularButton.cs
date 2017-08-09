using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MazeGame.Controls
{
	public partial class CircularButton : UserControl
	{
		GraphicsPath path = new GraphicsPath();

		public CircularButton()
		{
			InitializeComponent();
			Resize += CircularButton_Resize;
			DrawRoundedRectangle(null, 20, null);
			this.Region = new Region(path);

			this.BackColor = SystemColors.ControlDarkDark;
		}

		public void DrawRoundedRectangle(Graphics g, int r, Pen p)
		{
			path.AddLine(r, 0, Width - (r * 2), 0);
			path.AddArc(Width - (r * 2), 0, r * 2, r * 2, 270, 90);
			path.AddLine(Width, 0 + r, Width, Height - (r * 2));
			path.AddArc(Width - (r * 2), Height - (r * 2), r * 2, r * 2, 0, 90);
			path.AddLine(Width - (r * 2), Height, r, Height);
			path.AddArc(0, Height - (r * 2), r * 2, r * 2, 90, 90);
			path.AddLine(0, Height - (r * 2), 0, r);
			path.AddArc(0, 0, r * 2, r * 2, 180, 90);
			path.CloseFigure();
			if (g != null) g.DrawPath(p, path);
		}

		private void CircularButton_Resize(object sender, EventArgs e)
		{
			if (this.Region != null)
			{
				this.Region.Dispose();
				this.Region = null;
			}

			DrawRoundedRectangle(null, 20, null);
			this.Region = new Region(path);
		}
	}
}
