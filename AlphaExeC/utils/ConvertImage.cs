using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing.Imaging;
using TGASharpLib;
using System.Drawing;
using WebPWrapper;
using System.Linq;

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
            {"bmp", fromGeneric },
            {"webp", fromWebP },
            {"jpg", fromGeneric },
            {"png", fromGeneric },
            {"gif", fromGeneric },
            {"tif", fromGeneric },
            {"tiff", fromGeneric },
            {"emf", fromEMF }
        };
        

        public static readonly Dictionary<string, Action<Bitmap, string, int>> outputFunctions = new Dictionary<string, Action<Bitmap, string, int>>
        {
            {"jpg", (x, y, z) => toGeneric(x, y, z, ImageFormat.Jpeg) },
            {"png", (x, y, z) => toGeneric(x, y, z, ImageFormat.Png) },
            {"tiff", (x, y, z) => toGeneric(x, y, z, ImageFormat.Tiff) },
            {"gif", (x, y, z) => toGeneric(x, y, z, ImageFormat.Gif) },
            {"bmp", (x, y, z) => toGeneric(x, y, z, ImageFormat.Bmp) },
            {"webp", toWebP }
        };
        
        public static Bitmap getThumbnail(string path, int width = 64, int height = 64) {
            
            switch (Path.GetExtension(path).ToLower()){
                case ".tga":
                    using (TGA tga = new TGA(path)) {
                        Bitmap rawThumbnail = tga.GetThumbnail();
                        Bitmap thumbnail = new Bitmap(width, height);
                        
                        using (Graphics g = Graphics.FromImage(thumbnail)) {
                            g.DrawImage(rawThumbnail, 0, 0, width, height);
                            return thumbnail;
                        }
                    }
                case ".webp":
                    using (WebP webp = new WebP()){
                        return webp.LoadThumbnail(path, width, height);
                    }
                case ".emf":
                    using (Metafile source = new Metafile(path)){
                        Bitmap target = new Bitmap(width, height);
                        using (var g = Graphics.FromImage(target)) {
                            g.Clear(Color.White);
                            g.DrawImage(source, 0, 0, width, height);
                            return target;
                        }
                    }
                default:
                    Image src = Image.FromFile(path);
                    return (Bitmap) src.GetThumbnailImage(width, height, () => false, IntPtr.Zero);
            }
        }


        #region from bitmap

        public static Bitmap fromFile(string filepath)
        {

            string format = Path.GetExtension(filepath).Substring(1).ToLower();


            try
            {
                return importFunctions[format](filepath);
            }
            catch (KeyNotFoundException)
            {
                throw new NotImplementedException("Unknown/Unsupported import format: " + format);
            }
        }

        public static Bitmap fromTGA(string filepath)
        {
            return (Bitmap) new TGA(filepath);
        }

        public static Bitmap fromGeneric(string filepath)
        {
            return new Bitmap(filepath);
        }

        public static Bitmap fromWebP(string filepath)
        {
            using (WebP webp = new WebP())
            {
                return webp.Load(filepath);
            }              
        }

        public static Bitmap fromEMF(string filepath)
        {
            using (Metafile source = new Metafile(filepath)){
                
                MetafileHeader header = source.GetMetafileHeader();
                
                //TODO get Scale from slider in Settings through the configuration class that Viruz refuses to make :YagooCry:
                float scale = 4f;
                int width = (int)Math.Round((scale * source.Width / header.DpiX * 100), 0, MidpointRounding.ToEven);
                int height = (int)Math.Round((scale * source.Height / header.DpiY * 100), 0, MidpointRounding.ToEven);
                //TODO set background color to white or transparent depending on the target format.
                Bitmap target = new Bitmap(width, height);
                
                using (var g = Graphics.FromImage(target))
                {
                    g.DrawImage(source, 0, 0, width, height);
                    return target;
                }
            }
        }

        #endregion

        #region to bitmap
        
        public static void toFile(string outputFormat, Bitmap bmp, string outputPath, int quality)
        {
            try
            {
                outputFunctions[outputFormat.ToLower()](bmp, outputPath, quality);
            }
            catch (KeyNotFoundException)
            {
                throw new NotImplementedException("Unknown/Unsupported output format: " + outputFormat.ToLower());
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void toGeneric(Bitmap bmp, string outputpath, int quality, ImageFormat format)
        {
            // what is this idk
            var encoder = Encoder.Quality;
            var encoderParameters = new EncoderParameters(1);
            var encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;

            ImageCodecInfo imgencoder = GetEncoder(format);
            bmp.Save(outputpath, imgencoder, encoderParameters);

        }

        public static void toWebP(Bitmap bmp, string outputpath, int quality)
        {
            using (WebP webp = new WebP())
            {
                webp.Save(bmp, outputpath, quality);
            }
        }

        #endregion
    }
}