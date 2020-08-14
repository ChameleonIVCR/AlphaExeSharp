/*
 * Created by SharpDevelop.
 * User: Chame
 * Date: 31/05/2020
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using TGASharpLib;
using ConvertImage;

namespace AlphaExeC
{
	/// <summary>
	/// Description of FuncLibrary.
	/// </summary>
	public class FuncLibrary
	{		
//		[DllImport("VTFLib.dll")]
//		public static extern int vlGetVersion();
//		[DllImport("VTFLib.dll")]
//		public static extern bool vlInitialize();
//		[DllImport("VTFLib.dll")]
//		public static extern struct vlImageCreateDefaultCreateStructure(SVTFCreateOptions VTFCreateOptions);
		
		public static ImageCodecInfo GetEncoder(ImageFormat format)
		{
		    ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
		
		    foreach (ImageCodecInfo codec in codecs)
		    {
		        if (codec.FormatID == format.Guid)
		        {
		            return codec;
		        }
		    }
		    
		    return null;
		}

		public static void Convert(string filepath, string output, string outputformat, bool mode, int quality)
	    {
			string outputpath = System.String.Empty;

			if (output == System.String.Empty)
			{
					outputpath = Path.GetDirectoryName(filepath) + "\\" + Path.GetFileNameWithoutExtension(filepath) + "_output." + outputformat.ToLower();
			}
			else
			{
					outputpath = output + "\\" + Path.GetFileNameWithoutExtension(filepath) + "." + outputformat.ToLower();
			}


			Bitmap bmp = ConvertImage.ConvertImage.fromFile(filepath);

			#region do this later
				// let's uh
				// do this later
				/*
				Bitmap clonedbitmap = new Bitmap(bmp);
				Bitmap argbbmp = clonedbitmap.Clone(new Rectangle(0, 0, clonedbitmap.Width, clonedbitmap.Height), PixelFormat.Format32bppArgb);

				if (mode)
				{
					var data = argbbmp.LockBits(new Rectangle(0, 0, argbbmp.Width, argbbmp.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			        var line = data.Scan0;
			        var eof = line + data.Height * data.Stride;
			        while(line != eof)
			        {
			            var pixelAlpha = line + 3;
			            var eol = pixelAlpha + data.Width * 4;
			            while(pixelAlpha != eol)
			            {
			            	var alphavalue = System.Runtime.InteropServices.Marshal.ReadByte(pixelAlpha);
			            	System.Runtime.InteropServices.Marshal.WriteByte(pixelAlpha-3, alphavalue);
			            	System.Runtime.InteropServices.Marshal.WriteByte(pixelAlpha-2, alphavalue);
			            	System.Runtime.InteropServices.Marshal.WriteByte(pixelAlpha-1, alphavalue);
			                System.Runtime.InteropServices.Marshal.WriteByte(pixelAlpha, 255);
			                pixelAlpha += 4;
			            }
			            line += data.Stride;
			        }
					argbbmp.UnlockBits(data);
				}
				*/
				#endregion

			

			ConvertImage.ConvertImage.toFile(outputformat, bmp, outputpath, quality);

	    }
	}
}
