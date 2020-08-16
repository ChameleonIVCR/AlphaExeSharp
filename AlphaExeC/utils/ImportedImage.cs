using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ConvertImage {

    public class ImportedImage : ConvertImage {
        private readonly string filepath;
        private readonly Bitmap thumbnail;
        private static string outputPath;
        private static string outputFormat;
        private static int quality;
        
        public ImportedImage(string filepath) : base(){
            this.filepath = filepath;
            this.thumbnail = ConvertImage.getThumbnail(filepath);
        }
        
        public void convert() {
            toFile(outputFormat, fromFile(filepath), outputPath, quality);
        }
        
        public static void setConversionVariables(string outP, string outF, int qual) {
            outputPath = outP;
            outputFormat = outF;
            quality = qual;
        }
    }
}
