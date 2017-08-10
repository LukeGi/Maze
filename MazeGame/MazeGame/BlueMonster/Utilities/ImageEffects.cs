using System.Drawing;
using System.Drawing.Imaging;

namespace BlueMonster.Utilities
{
	//TopLeft = 0, TopMid = 0, TopRight = 0;
	//public int MidLeft = 0, Pixel = 1, MidRight = 0;
	//public int BottomLeft = 0, BottomMid = 0, BottomRight = 0
	public class ConvMatrix
	{
		public int[] matrix = { 0, 0, 0, 0, 1, 0, 0, 0, 0 };
		public int Factor = 1;
		public int Offset = 0;
		public void SetAll(int nVal)
		{
			matrix[0] = nVal;
			matrix[1] = nVal;
			matrix[2] = nVal;
			matrix[3] = nVal;
			matrix[4] = nVal;
			matrix[5] = nVal;
			matrix[6] = nVal;
			matrix[7] = nVal;
			matrix[8] = nVal;
		}
	}

	public static class BitmapFilter
	{
		private static bool Conv3x3(Bitmap b, ConvMatrix m)
		{
			// Avoid divide by zero errors
			if (0 == m.Factor) return false;

			Bitmap bSrc = (Bitmap)b.Clone();

			// GDI+ still lies to us - the return format is BGR, NOT RGB.
			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int stride = bmData.Stride;
			int stride2 = stride * 2;
			System.IntPtr Scan0 = bmData.Scan0;
			System.IntPtr SrcScan0 = bmSrc.Scan0;

			unsafe
			{
				byte* p = (byte*)(void*)Scan0;
				byte* pSrc = (byte*)(void*)SrcScan0;

				int nOffset = stride + 6 - b.Width * 3;
				int nWidth = b.Width - 2;
				int nHeight = b.Height - 2;

				int nPixel;

				for (int y = 0; y < nHeight; ++y)
				{
					for (int x = 0; x < nWidth; ++x)
					{
						nPixel = ((((pSrc[2] * m.matrix[0]) + (pSrc[5] * m.matrix[1]) + (pSrc[8] * m.matrix[2]) +
							(pSrc[2 + stride] * m.matrix[3]) + (pSrc[5 + stride] * m.matrix[4]) + (pSrc[8 + stride] * m.matrix[5]) +
							(pSrc[2 + stride2] * m.matrix[6]) + (pSrc[5 + stride2] * m.matrix[7]) + (pSrc[8 + stride2] * m.matrix[8])) / m.Factor) + m.Offset);

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;

						p[5 + stride] = (byte)nPixel;

						nPixel = ((((pSrc[1] * m.matrix[0]) + (pSrc[4] * m.matrix[1]) + (pSrc[7] * m.matrix[2]) +
							(pSrc[1 + stride] * m.matrix[3]) + (pSrc[4 + stride] * m.matrix[4]) + (pSrc[7 + stride] * m.matrix[5]) +
							(pSrc[1 + stride2] * m.matrix[6]) + (pSrc[4 + stride2] * m.matrix[7]) + (pSrc[7 + stride2] * m.matrix[8])) / m.Factor) + m.Offset);

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;

						p[4 + stride] = (byte)nPixel;

						nPixel = ((((pSrc[0] * m.matrix[0]) + (pSrc[3] * m.matrix[1]) + (pSrc[6] * m.matrix[2]) +
							(pSrc[0 + stride] * m.matrix[3]) + (pSrc[3 + stride] * m.matrix[4]) + (pSrc[6 + stride] * m.matrix[5]) +
							(pSrc[0 + stride2] * m.matrix[6]) + (pSrc[3 + stride2] * m.matrix[7]) + (pSrc[6 + stride2] * m.matrix[8])) / m.Factor) + m.Offset);

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;

						p[3 + stride] = (byte)nPixel;

						p += 3;
						pSrc += 3;
					}

					p += nOffset;
					pSrc += nOffset;
				}
			}

			b.UnlockBits(bmData);
			bSrc.UnlockBits(bmSrc);
			bSrc.Dispose();
			bSrc = null;
			return true;
		}

		public static bool GaussianBlur(Bitmap b, int nWeight /* default to 4*/)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(1);
			m.matrix[4] = nWeight;
			m.matrix[1] = m.matrix[3] = m.matrix[5] = m.matrix[7] = 2;
			m.Factor = nWeight + 12;

			return BitmapFilter.Conv3x3(b, m);
		}

		public static bool Sharpen(Bitmap b, int nWeight /* default to 11*/)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(0);
			m.matrix[4] = nWeight;
			m.matrix[1] = m.matrix[3] = m.matrix[5] = m.matrix[7] = -2;
			m.Factor = nWeight + -8;

			return BitmapFilter.Conv3x3(b, m);
		}

		public static bool Smooth(Bitmap b, int nWeight /* default to 1 */)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(1);
			m.matrix[4] = nWeight;
			m.Factor = nWeight + 8;

			return BitmapFilter.Conv3x3(b, m);
		}

		public static bool MeanRemoval(Bitmap b, int nWeight /* default to 9 */)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(-1);
			m.matrix[4] = nWeight;
			m.Factor = nWeight - 8;

			return BitmapFilter.Conv3x3(b, m);
		}

		public static bool EdgeDetect(Bitmap b, int nWeight /* default to 1 */)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(0);
			m.matrix[0] = 1;	m.matrix[1] = -1;	m.matrix[2] = 1;
			m.matrix[3] = -1;	m.matrix[4] = 0;	m.matrix[5] = -1;
			m.matrix[6] = 1;	m.matrix[7] = -1;	m.matrix[8] = 1;
			m.Factor = 1;
			m.Offset = 127;

			return BitmapFilter.Conv3x3(b, m);
		}
	}
}
