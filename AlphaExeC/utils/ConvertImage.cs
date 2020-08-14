using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using TGASharpLib;
using System.Drawing;

namespace ConvertImage
{
    public static class ConvertImage
    {

        // stole this from funclibrary.cs, can remove from funclibrary.cs probably once this class is fully implemented
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // loop through till you find a codec that works
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }


        public static readonly Dictionary<string, Func<string, Bitmap>> importFunctions = new Dictionary<string, Func<string, Bitmap>>
        {
            {"tga", fromTGA },
            {"bmp", fromBMP }
        };
        

        // couldn't get this to work

        public static readonly Dictionary<string, Action<Bitmap, string, EncoderParameters>> outputFunctions = new Dictionary<string, Action<Bitmap, string, EncoderParameters>>
        {
            {"jpg", toJPG },
            {"png", toPNG },
            {"tiff", toTIFF },
            {"gif", toGIF },
            {"bmp", toBMP}
        };


        #region to bitmap

        public static Bitmap fromFile(string filepath)
        {
            return importFunctions[filepath.Substring(filepath.Length - 3).ToLower()](filepath);
        }

        public static Bitmap fromTGA(string filepath)
        {
            return (Bitmap) new TGA(filepath);
        }

        public static Bitmap fromBMP(string filepath)
        {
            return new Bitmap(filepath);
        }

        #endregion

        #region from bitmap
        
        public static void toFile(string outputFormat, Bitmap bmp, string outputPath, EncoderParameters encoderParameters)
        {
            outputFunctions[outputFormat](bmp, outputPath, encoderParameters);
        }

        public static void toJPG(Bitmap bmp, string outputpath, EncoderParameters encoderParameters)
        {
            ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Jpeg);
            bmp.Save(outputpath, imgencoder, encoderParameters);
        }

        public static void toPNG(Bitmap bmp, string outputpath, EncoderParameters encoderParameters)
        {
            ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Png);
            bmp.Save(outputpath, imgencoder, encoderParameters);
        }

        public static void toTIFF(Bitmap bmp, string outputpath, EncoderParameters encoderParameters)
        {
            ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Tiff);
            bmp.Save(outputpath, imgencoder, encoderParameters);
        }

        public static void toGIF(Bitmap bmp, string outputpath, EncoderParameters encoderParameters)
        {
            ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Gif);
            bmp.Save(outputpath, imgencoder, encoderParameters);
        }

        public static void toBMP(Bitmap bmp, string outputpath, EncoderParameters encoderParameters)
        {
            ImageCodecInfo imgencoder = GetEncoder(ImageFormat.Bmp);
            bmp.Save(outputpath, imgencoder, encoderParameters);
        }

        #endregion
    }
}