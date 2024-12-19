using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank.Utilities
{
	public static class ImageUtility
	{
		private static string VALID_IMG_FORMAT = ConfigurationManager.AppSettings["VALID_IMG_FORMAT"];
		private static string DEFAULT_IMG_PATH = ConfigurationManager.AppSettings["DEFAULT_IMG"];
		private static string EXCESS_PATH = ConfigurationManager.AppSettings["EXCESS_PATH"];

		private static string FullDefaultImagePath() => Path.Combine
			(AppDomain
			.CurrentDomain
			.BaseDirectory
			.Replace(EXCESS_PATH, ""), DEFAULT_IMG_PATH);

		public static PictureBox DefaultImage(PictureBox box)
		{
			string imagePath = FullDefaultImagePath(); 
			box.Image = Image.FromFile(imagePath);
			box.SizeMode = PictureBoxSizeMode.Zoom;
			return box;
		}

		public static Bitmap ByteArrayToBitmap(byte[] bytes)
		{
			if (bytes == null)
			{
				var path = FullDefaultImagePath();
			}
			using (var ms = new System.IO.MemoryStream(bytes))
			{
				var image = Image.FromStream(ms);
				var resizedBitmap = new Bitmap(50, 50, image.PixelFormat);
				using (var g = Graphics.FromImage(resizedBitmap))
				{
					g.Clear(Color.White); // Set the background color to white
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
					g.DrawImage(image, 0, 0, 50, 50);
				}
				return resizedBitmap;
			}
		}

		public static Image ImageToImageResizer(Image img)
		{
			var newImage = new Bitmap(150, 150);
			using (var g = Graphics.FromImage(newImage))
			{
				g.DrawImage(img, 0, 0, 150, 150);
			}
			return newImage;
		}

		public static Image OpenFileImage()
		{
			OpenFileDialog fileOpener = new OpenFileDialog();

			if(fileOpener == null)
			{
				return null;
			}

			string format = VALID_IMG_FORMAT;
			fileOpener.Filter = format;

			if (fileOpener.ShowDialog() == DialogResult.OK)
			{
				return Image.FromFile(fileOpener.FileName);
			}
			return null;
		}

		public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
		{
			using (var ms = new System.IO.MemoryStream())
			{
				imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}
		public static Bitmap ByteArrayToImage(byte[] byteArrayIn)
		{
			using (var ms = new System.IO.MemoryStream(byteArrayIn))
			{
				var image = Image.FromStream(ms);
				var bitmap = new Bitmap(image);
				return bitmap;
			}
		}
	}
}
