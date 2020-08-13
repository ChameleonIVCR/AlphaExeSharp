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
			try
			{
				Bitmap bmp;
				if (output == System.String.Empty)
				{
					outputpath = Path.GetDirectoryName(filepath)+"\\"+Path.GetFileNameWithoutExtension(filepath)+"_output."+outputformat.ToLower();
				}
				else
				{
					outputpath = output+"\\"+Path.GetFileNameWithoutExtension(filepath)+"."+outputformat.ToLower();
				}
				switch(filepath.Substring(filepath.Length - 3).ToLower())
				{
					case "tga":
						var tga = new TGA(filepath);
						bmp = (Bitmap)tga;
						break;
					case "vtf":
						throw new NotImplementedException();
						break;
					case "dds":
						throw new NotImplementedException();
						break;
					default:
						bmp = new Bitmap(filepath);
						break;
				}
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
	            var encoder =  Encoder.Quality;
	            var encoderParameters = new EncoderParameters(1);
	            var encoderParameter = new EncoderParameter(encoder, quality);
	            encoderParameters.Param[0] = encoderParameter;
				switch(outputformat.ToLower())
				{
					case "tga":
						var tga = new TGA(filepath);
						Bitmap bitmaptga = (Bitmap)tga;
						break;
					case "vtf":
						throw new NotImplementedException();
						break;
					case "dds":
						throw new NotImplementedException();
						break;
					case "jpg":
						ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Jpeg);
						argbbmp.Save(outputpath, imgencoder, encoderParameters);
						break;
					case "png":
						ImageCodecInfo imgencoder2 = GetEncoder(ImageFormat.Png);
						argbbmp.Save(outputpath, imgencoder2, encoderParameters);
						break;
					case "tiff":
						ImageCodecInfo imgencoder3 = GetEncoder(ImageFormat.Tiff);
						argbbmp.Save(outputpath, imgencoder3, encoderParameters);
						break;
					case "gif":
						ImageCodecInfo imgencoder4 = GetEncoder(ImageFormat.Gif);
						argbbmp.Save(outputpath, imgencoder4, encoderParameters);
						break;
					case "bmp":
						ImageCodecInfo imgencoder5 = GetEncoder(ImageFormat.Bmp);
						argbbmp.Save(outputpath, imgencoder5, encoderParameters);
						break;
					default:
						throw new NotImplementedException();
						break;
				}
				argbbmp.Dispose();
				clonedbitmap.Dispose();
				bmp.Dispose();
			}
			catch(Exception error)
			{
				
			}
	    }
	}
}
