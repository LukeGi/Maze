//#define SHOWBORDERS

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using BlueMonster.Utilities;

namespace BlueMonster.MazeGame
{
	#region FullGame Form (Fully Painted)
	public partial class FormMaze : Form
	{

		#region ----- Variable Feilds -----

		private bool paused;
		private FormPage CurrentPage;
		private PageMainMenu pageMainMenu;
		private PageMazeCreator pageMazeCreator;
		private Bitmap blur;

		public string title = "Blue's Maze Game";

		#endregion

		#region ------ Override Methods -----

		protected override void OnPaint(PaintEventArgs e)
		{
			switch (paused)
			{
				case true:
					switch (blur)
					{
						case null:
							blur = new Bitmap(ClientSize.Width, ClientSize.Height, PixelFormat.Format32bppArgb);
							using (Graphics g = Graphics.FromImage(blur))
								CurrentPage.PaintPage(g);
							CurrentPage.DeleteCache();
							BitmapFilter.GaussianBlur(blur, 4);
							Invalidate();
							break;
						default:
							e.Graphics.DrawImage(blur, 0, 0);
							break;
					}
					break;
				case false:
					CurrentPage.PaintPage(e.Graphics);
					base.OnPaint(e);
					break;
			}
		}

		#endregion

		public void ChangeToPage(Page page)
		{
			switch (CurrentPage)
			{
				case null:
					break;
				default:
					CurrentPage.DeleteCache();
					break;
			}
			switch (page)
			{
				case Page.None:
					CurrentPage.Dispose();
					CurrentPage = null;
					pageMainMenu.Dispose();
					pageMazeCreator.Dispose();
					this.Close();
					break;
				case Page.MainMenu:
					CurrentPage = pageMainMenu;
					break;
				case Page.MazeCreator:
					CurrentPage = pageMazeCreator;
					break;
			}
			switch (CurrentPage)
			{
				case null:
					break;
				default:
					CurrentPage.PageSize = ClientSize;
					break;
			}
		}

		#region ----- Constructor -----

		public FormMaze()
		{
			InitializeComponent();
			BackgroundImageLayout = ImageLayout.None;

			SetStyle(ControlStyles.ResizeRedraw |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.EnableNotifyMessage,
				true);

			pageMainMenu = new PageMainMenu(this, ClientSize);
			pageMazeCreator = new PageMazeCreator(this, ClientSize);

			Disposed += EventDisposed;
			Load += EventFormLoad;
			Resize += EventResize;
			MouseMove += EventMouseMoved;
			MouseClick += EventMouseClick;
			KeyDown += EventKeyDown;
		}

		#endregion

		#region ----- Form Event Handlers -----

		private void EventDisposed(object sender, EventArgs e)
		{
			PageStyle.Dispose();
		}

		private void EventFormLoad(object sender, EventArgs e)
		{
			ChangeToPage(Page.MainMenu);
		}

		private void EventMouseMoved(object sender, MouseEventArgs e)
		{
			if (!paused)
				CurrentPage.HandleMouseMove(e.Location);
		}

		private void EventMouseClick(object sender, MouseEventArgs e)
		{
			if (!paused)
				CurrentPage.HandleMouseClick(e.Button);
		}

		private void EventResize(object sender, EventArgs e)
		{
			CurrentPage.PageSize = ClientSize;
			CurrentPage.DeleteCache();
		}

		private void EventKeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
					paused = !paused;
					DeleteBlur();
					Invalidate();
					break;
			}
		}

		#endregion

		#region ----- Caching Methods -----

		private void DeleteCache()
		{
			CurrentPage.DeleteCache();
			Invalidate();
		}

		private void DeleteBlur()
		{
			if (blur != null)
			{
				blur.Dispose();
				blur = null;
			}
		}

		#endregion
	}
	#endregion

	#region Page Style Objects  Holder Class
	public static class PageStyle
	{
		public static StringFormat stringFormat = new StringFormat()
		{
			Alignment = StringAlignment.Center,
			LineAlignment = StringAlignment.Center
		};

		private static SolidBrush backColor = new SolidBrush(Color.FromArgb(50, 60, 90));
		public static SolidBrush BGColor
		{
			get { return backColor; }
			set
			{
				if (value == null)
					backColor.Dispose();
				backColor = value;
			}
		}

		private static SolidBrush foreColor = new SolidBrush(Color.FromArgb(20, 20, 20));
		public static SolidBrush FGColor
		{
			get { return foreColor; }
			set
			{
				if (value == null)
					foreColor.Dispose();
				foreColor = value;
			}
		}

		private static SolidBrush featureColor = new SolidBrush(Color.FromArgb(50, 50, 50));
		public static SolidBrush FeatureColor
		{
			get { return featureColor; }
			set
			{
				if (value == null)
					featureColor.Dispose();
				featureColor = value;
			}
		}

		private static SolidBrush highlightedColor = new SolidBrush(Color.FromArgb(60, 60, 60));
		public static SolidBrush HighlightedColor
		{
			get { return highlightedColor; }
			set
			{
				if (value == null)
					highlightedColor.Dispose();
				highlightedColor = value;
			}
		}

		private static SolidBrush textColor = new SolidBrush(Color.DodgerBlue);
		public static SolidBrush TextColor
		{
			get { return textColor; }
			set
			{
				if (value == null)
					textColor.Dispose();
				textColor = value;
			}
		}

		private static Pen borderColor = new Pen(Color.Black);
		public static Pen BorderColor
		{
			get { return borderColor; }
			set
			{
				if (value == null)
					borderColor.Dispose();
				borderColor = value;
			}
		}

		private static Font titleFont = new Font("Marshmallows and Chocolate", 72);
		public static Font TitleFont
		{
			get { return titleFont; }
			set
			{
				if (value == null)
					titleFont.Dispose();
				titleFont = value;
			}
		}

		private static Font buttonFont = new Font("Microsoft Sans Serif", 24);
		public static Font ButtonFont
		{
			get { return buttonFont; }
			set
			{
				if (value == null)
					buttonFont.Dispose();
				buttonFont = value;
			}
		}

		public static void Dispose()
		{
			if (stringFormat != null)
			{
				stringFormat.Dispose();
				stringFormat = null;
			}
			if (BGColor != null) BGColor = null;
			if (FGColor != null) FGColor = null;
			if (FeatureColor != null) FeatureColor = null;
			if (HighlightedColor != null) HighlightedColor = null;
			if (TextColor != null) TextColor = null;
			if (BorderColor != null) BorderColor = null;
			if (TitleFont != null) TitleFont = null;
			if (ButtonFont != null) ButtonFont = null;
		}
	}
	#endregion

	#region Abstract Page Class

	public abstract class FormPage : IDisposable
	{
		#region ----- Feilds -----

		#region ----- Private Feilds -----

		private Page page;
		private FormMaze parent;
		private Size pageSize;
		private GameButton[] buttons;
		protected Bitmap bgImage;
		protected Bitmap fgImage;

		#endregion

		#region Properties

		public Page Page { get => page; set => page = value; }
		public GameButton[] Buttons { get => buttons; set => buttons = value; }
		public Size PageSize { get => pageSize; set => pageSize = value; }
		public FormMaze Parent { get => parent; set => parent = value; }

		#endregion

		#endregion

		#region ----- Constructor -----

		public FormPage(FormMaze parent, Page p, Size size)
		{
			Page = p;
			Buttons = GetButtons();
			PageSize = size;
			Parent = parent;
		}

		#endregion

		#region ===== Painting Methods =====

		public void PaintPage(Graphics g)
		{
			if (bgImage == null) GenerateBGImage();
			g.DrawImage(bgImage, 0, 0);
			if (fgImage == null) GenerateFGImage();
			g.DrawImage(fgImage, 0, 0);
		}

		#region ----- Helper Draw Methods -----

		internal void DrawButton(Graphics g, Font f, Brush backColour, Brush textColor,
			Pen borderColour, String btnText, ref Rectangle background)
		{
#if SHOWBORDERS
			borderColour = Pens.Black;
#endif
			g.FillRectangle(backColour, background);
			g.DrawRectangle(borderColour, background);
			g.DrawString(btnText, f, textColor, background, PageStyle.stringFormat);
		}

		#endregion

		#endregion

		#region ----- Overridable Methods -----

		internal abstract GameButton[] GetButtons();
		internal abstract void GenerateBGImage();
		internal abstract void GenerateFGImage();
		internal abstract void HandleMouseClick(MouseButtons button);

		internal virtual void HandleMouseMove(Point location)
		{
			for (int i = 0; i < Buttons.Length; i++)
				if (Buttons[i].Selected != Buttons[i].Collider.Contains(location))
				{
					Buttons[i].Selected = Buttons[i].Collider.Contains(location);
					DeleteFGImageCache();
				}
		}

		#endregion

		#region ----- Caching Methods -----

		public void DeleteCache()
		{
			DeleteBGImageCache();
			DeleteFGImageCache();
			Parent.Invalidate();
		}

		public void DeleteBGImageCache()
		{
			switch (bgImage == null)
			{
				case false:
					bgImage.Dispose();
					bgImage = null;
					Parent.Invalidate();
					break;
				default:
					return;
			}
		}

		public void DeleteFGImageCache()
		{
			switch (fgImage == null)
			{
				case false:
					fgImage.Dispose();
					fgImage = null;
					Parent.Invalidate();
					break;
				default:
					return;
			}
		}

		#endregion

		#region ----- Interface Methods -----

		public void Dispose()
		{
			DeleteCache();
		}

		#endregion
	}

	#endregion

	#region Page - Main Menu

	internal class PageMainMenu : FormPage
	{
		enum MainMenuButtons { None, SinglePlayer, Multiplayer, Settings, Exit }

		public PageMainMenu(FormMaze form, Size size) : base(form, Page.MainMenu, size)
		{
		}

		#region ----- Override Methods -----

		internal override GameButton[] GetButtons()
		{
			return new GameButton[] {
				new GameButton() {
					Reference = (byte) MainMenuButtons.SinglePlayer,
					ButtonText = "Single Player",
					Selected = false,
					Collider = Rectangle.Empty
				},
				new GameButton()
				{
					Reference = (byte) MainMenuButtons.Multiplayer,
					ButtonText = "Multiplayer",
					Selected = false,
					Collider = Rectangle.Empty
				},
				new GameButton()
				{
					Reference = (byte) MainMenuButtons.Settings,
					ButtonText = "Settings",
					Selected = false,
					Collider = Rectangle.Empty
				},
				new GameButton()
				{
					Reference = (byte) MainMenuButtons.Exit,
					ButtonText = "Exit",
					Selected = false,
					Collider = Rectangle.Empty
				}
			};
		}

		internal override void GenerateBGImage()
		{
			switch (bgImage)
			{
				case null:
					bgImage = new Bitmap(PageSize.Width, PageSize.Height, PixelFormat.Format32bppArgb);
					using (Graphics g = Graphics.FromImage(bgImage))
					{
						int q = PageSize.Width / 4;
						g.FillRectangle(PageStyle.BGColor, q + 10, 0, PageSize.Width - q - 10, PageSize.Width);
						g.FillRectangle(PageStyle.FGColor, 0, 0, q, PageSize.Height);
						g.FillRectangle(Brushes.Black, q, 0, 10, PageSize.Width);
					}
					break;
				default:
					DeleteBGImageCache();
					GenerateBGImage();
					break;
			}
		}

		internal override void GenerateFGImage()
		{
			switch (fgImage)
			{
				case null:
					fgImage = new Bitmap(PageSize.Width, PageSize.Height, PixelFormat.Format32bppArgb);
					using (Graphics g = Graphics.FromImage(fgImage))
					{
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
						g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

						int buttonWidth = (PageSize.Width / 4) - 20;
						int buttonHeight = 50;
						int listTop = (PageSize.Height - (buttonHeight * Buttons.Length) - ((Buttons.Length - 1) * 15)) / 2;
						for (int i = 0; i < Buttons.Length; i++)
						{
							Buttons[i].Collider = new Rectangle(10, listTop + (buttonHeight * i) + (15 * i), buttonWidth, buttonHeight);
							DrawButton(g, PageStyle.ButtonFont,
								Buttons[i].Selected ? PageStyle.HighlightedColor : PageStyle.FeatureColor,
								PageStyle.TextColor, PageStyle.BorderColor, Buttons[i].ButtonText, ref Buttons[i].Collider);
						}
						Rectangle btnSize = Rectangle.FromLTRB((PageSize.Width / 4) + 22, 12,
							PageSize.Width - 12, 12 + g.MeasureString(Parent.title, PageStyle.TitleFont).ToSize().Height);
						DrawButton(g, PageStyle.TitleFont, PageStyle.BGColor, Brushes.White, Pens.Transparent, Parent.title, ref btnSize);
					}
					break;
				default:
					DeleteFGImageCache();
					GenerateFGImage();
					break;
			}
		}

		internal override void HandleMouseClick(MouseButtons button)
		{
			for (int i = 0; i < Buttons.Length; i++)
				if (Buttons[i].Selected)
					switch (Buttons[i].Reference)
					{
						case (byte)MainMenuButtons.SinglePlayer:
							Parent.ChangeToPage(Page.MazeCreator);
							break;
						case (byte)MainMenuButtons.Multiplayer:
							break;
						case (byte)MainMenuButtons.Settings:
							break;
						case (byte)MainMenuButtons.Exit:
							Parent.ChangeToPage(Page.None);
							break;
					}
		}

		#endregion
	}

	#endregion

	internal class PageMazeCreator : FormPage
	{
		public PageMazeCreator(FormMaze parent, Size size) : base(parent, Page.MazeCreator, size)
		{
		}

		internal override void GenerateBGImage()
		{
			switch (bgImage)
			{
				case null:
					bgImage = new Bitmap(PageSize.Width, PageSize.Height, PixelFormat.Format32bppArgb);
					using (Graphics g = Graphics.FromImage(bgImage))
					{
						g.FillRectangle(PageStyle.BGColor, 0, 0, PageSize.Width, PageSize.Height);
					}
					break;
				default:
					DeleteBGImageCache();
					GenerateBGImage();
					break;
			}
		}

		internal override void GenerateFGImage()
		{
			switch (fgImage)
			{
				case null:
					fgImage = new Bitmap(PageSize.Width, PageSize.Height, PixelFormat.Format32bppArgb);
					break;
				default:
					DeleteFGImageCache();
					GenerateFGImage();
					break;
			}
		}

		internal override GameButton[] GetButtons()
		{
			return new GameButton[0];
		}

		internal override void HandleMouseClick(MouseButtons button)
		{
			// NOOP
		}
	}

	#region Game Button Struct
	public struct GameButton
	{
		public byte Reference;
		public string ButtonText;
		public bool Selected;
		public Rectangle Collider;
	}
	#endregion

	#region Page Enum
	public enum Page
	{
		None,
		MainMenu,
		MazeCreator,
		GamePlay
	}
	#endregion
}
