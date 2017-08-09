using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using BlueMonster;
using BlueMonster.Utilities;

namespace MazeGame.Controls
{
	public partial class MazePanel : UserControl
	{
		private Bitmap mvar_MazeBackground;
		private Bitmap mvar_MazeWalls;
		private Bitmap mvar_Players;
		private Bitmap mvar_Trails;
		private SolidBrush mvar_BGBrush = new SolidBrush(Color.LightGray);
		private Color mvar_MazeBGColour = Color.LightGray;
		private SolidBrush mvar_WallBrush = new SolidBrush(Color.Black);
		private Color mvar_WallColour = Color.Black;
		private byte[] Maze;
		private bool mvar_MouseHover;
		private int OffsetX = 0;
		private int OffsetY = 0;

		public MazeData MazeData;
		private float WallZoomX;
		private float WallZoomY;

		public Color MazeBackgroundColour
		{
			get { return mvar_MazeBGColour; }
			set
			{
				mvar_MazeBGColour = value;
				mvar_BGBrush = new SolidBrush(value);
				if (mvar_MazeBackground == null) return;
				mvar_MazeBackground.Dispose();
				mvar_MazeBackground = null;
			}
		}

		public Color WallColor
		{
			get { return mvar_WallColour; }
			set
			{
				mvar_WallColour = value;
				mvar_WallBrush = new SolidBrush(value);
				if (mvar_MazeWalls == null) return;
				mvar_MazeWalls.Dispose();
				mvar_MazeWalls = null;
			}
		}

		public int ZoomX { get; set; }
		public int ZoomY { get; set; }

		public MazePanel()
		{
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

			Load += MazePanel_Load;
			Disposed += MazePanel_Disposed;
			Click += MazePanel_Click;
			MouseEnter += MouseIn;
			MouseLeave += MouseOut;
			Resize += MazePanel_Resize;
		}

		private void MazePanel_Resize(object sender, EventArgs e)
		{
			if (MazeData.Width > 0)
			{
				MazeData.CellSizeX = (float)Width / (float)MazeData.Width;
				MazeData.CellSizeY = (float)Height / (float)MazeData.Height;
				WallZoomX = MazeData.CellSizeX;
				WallZoomY = MazeData.CellSizeY;
			}
			DeleteCache();
		}

		private void MazePanel_Click(object sender, EventArgs e)
		{
			if (mvar_MazeWalls == null) return;
			Point p = PointToClient(Cursor.Position);
			int TheoreticalWidth = (int)(MazeData.Width * WallZoomX) + 1;
			int TheoreticalHeight = (int)(MazeData.Height * WallZoomY) + 1;
			if ((TheoreticalWidth > Width || TheoreticalHeight > Height) && mvar_MouseHover)
			{
				if (p.X > (Width * 0.75))
				{
					if (OffsetX > Width - TheoreticalWidth)
					{
						OffsetX -= (int) Math.Min((TheoreticalWidth - Width) + OffsetX, WallZoomX);
						DeleteCache();
					}
				}
				else if (p.X < (Width * 0.25))
				{
					if (OffsetX < 0)
					{
						OffsetX += (int)Math.Min(WallZoomX, -OffsetX);
						DeleteCache();
					}
				}
				if (p.Y > (Height * 0.75))
				{
					if (OffsetY > Height - TheoreticalHeight)
					{
						OffsetY -= (int)Math.Min((TheoreticalHeight - Height) + OffsetY, WallZoomY);
						DeleteCache();
					}
				}
				else if (p.Y < (Height * 0.25))
				{
					if (OffsetY < 0)
					{
						OffsetY += (int)Math.Min(WallZoomY, -OffsetY);
						DeleteCache();
					}
				}
			}
		}

		private void MouseOut(object sender, EventArgs e)
		{
			mvar_MouseHover = false;
		}

		private void MouseIn(object sender, EventArgs e)
		{
			mvar_MouseHover = true;
		}

		private void MazePanel_Disposed(object sender, EventArgs e)
		{
			if (mvar_MazeBackground != null)
			{
				mvar_MazeBackground.Dispose();
				mvar_MazeBackground = null;
			}
			if (mvar_BGBrush != null)
			{
				mvar_BGBrush.Dispose();
				mvar_BGBrush = null;
			}
			if (mvar_MazeWalls != null)
			{
				mvar_MazeWalls.Dispose();
				mvar_MazeWalls = null;
			}
			if (mvar_Players != null)
			{
				mvar_Players.Dispose();
				mvar_Players = null;
			}
			if (mvar_Trails != null)
			{
				mvar_Trails.Dispose();
				mvar_Trails = null;
			}
		}

		private void MazePanel_Load(object sender, EventArgs e)
		{
			timer1.Start();
			MazeData.CellSizeX = (float)Width / (float)MazeData.Width;
			MazeData.CellSizeY = (float)Height / (float)MazeData.Height;
			WallZoomX = MazeData.CellSizeX;
			WallZoomY = MazeData.CellSizeY;
			BackgroundImage = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
			Maze = MazeGenerators.GenerateMazeRecursiveBacktracker(ref MazeData);
			Invalidate();
		}

		private void GenerateBackground()
		{
			if (mvar_MazeBackground == null)
			{
				mvar_MazeBackground = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
				using (Graphics theg = Graphics.FromImage(mvar_MazeBackground))
				{
					theg.FillRectangle(mvar_BGBrush, 0, 0, MazeData.Width * WallZoomX, MazeData.Height * WallZoomY);
					int StartX = OffsetX + (int)((MazeData.StartPosition % MazeData.Width) * WallZoomX);
					int StartY = OffsetY + (int)(Math.Floor((float)MazeData.StartPosition / (float)MazeData.Width) * WallZoomY);
					int EndX = OffsetX + (int)((MazeData.EndPosition % MazeData.Width) * WallZoomX);
					int EndY = OffsetY + (int)(Math.Floor((float)MazeData.EndPosition / (float)MazeData.Width) * WallZoomY);
					theg.FillRectangle(Brushes.Green, StartX + 1, StartY + 1, WallZoomX - 1, WallZoomY - 1);
					theg.FillRectangle(Brushes.Red, EndX + 1, EndY + 1, WallZoomX - 1, WallZoomY - 1);
					theg.Flush();
				}
			}
		}

		private void GenerateWalls()
		{
			if (mvar_MazeWalls == null)
			{
				mvar_MazeWalls = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
				using (Graphics theg = Graphics.FromImage(mvar_MazeWalls))
				{
					int x = 0;
					int y = 0;
					int x1, x2, y1, y2;
					for (int i = 0; i < Maze.Length; i++)
					{
						if (x == MazeData.Width) { x = 0; y++; }
						bool[] bools = { (Maze[i] & (int)MazeDirection.North) == (int)MazeDirection.North, (Maze[i] & (int)MazeDirection.East) == (int)MazeDirection.East, (Maze[i] & (int)MazeDirection.South) == (int)MazeDirection.South, (Maze[i] & (int)MazeDirection.West) == (int)MazeDirection.West };
						x1 = (int)(OffsetX + (x * WallZoomX));
						y1 = (int)(OffsetY + (y * WallZoomY));
						x2 = (int)(OffsetX + ((x + 1) * WallZoomX));
						y2 = (int)(OffsetY + ((y + 1) * WallZoomY));
						for (int b = 0; b < bools.Length; b++)
							if (bools[b])
								switch (b)
								{
									case 0: // North
										theg.DrawLine(new Pen(mvar_WallBrush), x1, y1, x2, y1);
										break;
									case 1: // East
										theg.DrawLine(new Pen(mvar_WallBrush), x2, y1, x2, y2);
										break;
									case 2: // South
										theg.DrawLine(new Pen(mvar_WallBrush), x2, y2, x1, y2);
										break;
									case 3: // West
										theg.DrawLine(new Pen(mvar_WallBrush), x1, y2, x1, y1);
										break;
								}
						x++;
					}
					theg.Flush();
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			bool happened = false;
			if (mvar_MouseHover)
			{
				if (WallZoomX < ZoomX)
				{
					WallZoomX *= 1.1f;
					DeleteCache();
					happened = true;
				}
				if (WallZoomY < ZoomY)
				{
					WallZoomY *= 1.1f;
					DeleteCache();
					happened = true;
				}
			}
			else
			{
				if (WallZoomX > MazeData.CellSizeX)
				{
					WallZoomX *= 0.9f;
					if (WallZoomX < MazeData.CellSizeX)
						WallZoomX = MazeData.CellSizeX;
					DeleteCache();
					happened = true;
				}
				if (WallZoomY > MazeData.CellSizeY)
				{
					WallZoomY *= 0.9f;
					if (WallZoomY < MazeData.CellSizeY)
						WallZoomY = MazeData.CellSizeY;
					DeleteCache();
					happened = true;
				}
			}
			int TheoreticalWidth = (int)(MazeData.Width * WallZoomX) + 1;
			int TheoreticalHeight = (int)(MazeData.Height * WallZoomY) + 1;
			if (OffsetX + (WallZoomX * MazeData.Width) + 1 < Width)
			{
				OffsetX += Math.Min(-((TheoreticalWidth - Width) + OffsetX), ZoomX);
				DeleteCache();
				happened = true;
			}
			if (OffsetY + (WallZoomY * MazeData.Height) + 1 < Height)
			{
				OffsetY += Math.Min(-((Height - TheoreticalHeight) + OffsetY), ZoomY);
				DeleteCache();
				happened = true;
			}
			if (happened)
			{
				timer1.Interval = 1;
			}
			else
			{
				timer1.Interval = 500;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (Maze.Length > 0)
			{
				if (mvar_MazeBackground == null)
					GenerateBackground();
				if (mvar_MazeWalls == null)
					GenerateWalls();
				//if (CachedTrails == null)
				//GenerateCachedTrails();

				e.Graphics.DrawImage(mvar_MazeBackground, 0, 0);
				e.Graphics.DrawImage(mvar_MazeWalls, 0, 0);
			}

			base.OnPaint(e);
		}

		protected new void Invalidate()
		{
			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(Invalidate));
			}
			else
			{
				base.Invalidate();
			}
		}

		#region --- Caching Methods ---

		private void DeleteCache()
		{
			DeleteCachedWalls();
			DeleteCachedBackground();
			Invalidate();
		}

		private void DeleteCachedBackground()
		{
			if (mvar_MazeBackground != null)
			{
				mvar_MazeBackground.Dispose();
				mvar_MazeBackground = null;
				Invalidate();
			}
		}

		private void DeleteCachedWalls()
		{
			if (mvar_MazeWalls != null)
			{
				mvar_MazeWalls.Dispose();
				mvar_MazeWalls = null;
				Invalidate();
			}
		}

		#endregion
	}
}
