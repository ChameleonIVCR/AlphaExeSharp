
using System;   
using System.Configuration;

namespace AlphaExeC.utils{
    public sealed class Configuration : ConfigurationElement {
        
        public Configuration(string key) {
            Properties = key;
        }
        
        private bool isBetween(int x, int min, int max){
            return x >= min && x <= max;
        }
        
        //key
        
        [ConfigurationProperty("properties", IsKey = true, IsRequired = true)]
        public new string Properties {
            get { return (string) this["properties"]; }
            set { this["properties"] = value; }
        }
        
        //general options
        
        [ConfigurationProperty("pixelformat")]
        public int PixelFormat {
            get {
                int fetch = (int)this["pixelformat"]; 
                if (isBetween(fetch, 0, 11)){
                    return fetch;
                }
                PixelFormat = 0;
                return 0;
            }
            set { 
                this["pixelformat"] = value; 
            }
        }
        

        [ConfigurationProperty("quality")]
        public int Quality {
            get {
                int fetch = (int)this["quality"]; 
                if (isBetween(fetch, 10, 100)){
                    return fetch;
                }
                Quality = 80;
                return 80;
            }
            set { 
                this["quality"] = value; 
            }
        }
        
        [ConfigurationProperty("allowallinputformats")]
        public bool AllowAllInputFormats {
            get { return (bool)this["allowallinputformats"]; }
            set { this["allowallinputformats"] = value; }
        }
        
        [ConfigurationProperty("replacergbwithalpha")]
        public bool ReplaceRGBwithA {
            get { return (bool)this["replacergbwithalpha"]; }
            set { this["replacergbwithalpha"] = value; }
        }
        
        //DXT options
        
        [ConfigurationProperty("dxtrgbformat")]
        public int DXTRgbFormat {
            get {
                int fetch = (int)this["dxtrgbformat"]; 
                if (isBetween(fetch, 0, 4)){
                    return fetch;
                }
                DXTRgbFormat = 0;
                return 0;
            }
            set { 
                this["dxtrgbformat"] = value; 
            }
        }
        
        [ConfigurationProperty("dxtalphaformat")]
        public int DXTAlphaFormat {
            get {
                int fetch = (int)this["dxtalphaformat"]; 
                if (isBetween(fetch, 0, 4)){
                    return fetch;
                }
                DXTAlphaFormat = 0;
                return 0;
            }
            set { 
                this["dxtalphaformat"] = value; 
            }
        }
        
        [ConfigurationProperty("dxtcompression")]
        public int DXTCompression {
            get {
                int fetch = (int)this["dxtcompression"]; 
                if (isBetween(fetch, 0, 3)){
                    return fetch;
                }
                DXTCompression = 0;
                return 0;
            }
            set { 
                this["dxtcompression"] = value; 
            }
        }
    }
}

