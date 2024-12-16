using System;
using System.Collections.Generic;
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
		private const string VALID_IMG_FORMAT = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

		public static Bitmap ByteArrayToBitmap(byte[] bytes)
		{
			if (bytes == null)
			{
				var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"\resources\images\default.png"));

			}
			using (var ms = new System.IO.MemoryStream(bytes))
			{
				var image = Image.FromStream(ms);
				var bitmap = new Bitmap(image, 50, 50);
				return bitmap;
			}
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
		public static Image ByteArrayToImage(byte[] byteArrayIn)
		{
			using (var ms = new System.IO.MemoryStream(byteArrayIn))
			{
				var returnImage = System.Drawing.Image.FromStream(ms);
				return returnImage;
			}
		}
	}
}
