using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.IO.Compression;

namespace FreeRunner_Flashing_Utility.Classes
{
    internal class UpdateService
    {
        public static int checkStatus = 0;
        public static bool upToDate = true;
        public static string failedReason = "Uknown";
        public static string changelong = "Cound not rerieve changelog for some reason!";
        private static string deltaUrl, fullUrl;
        private static int serverRevision;
        public static int minDeltaRevision = 0;
        private static string expectedDeltaMd5 = "";
        private static string expectedFullMd5 = "";
        public static bool deleteFolders = false;
        public static bool noUpdateChk = false;
        public static bool runFullUpdate = false;
        private static WebClient wc = null;
        //private static UpdUI updUI = null;
        private static XmlTextReader xml = null;

        public static void checkUpdate() 
        { 
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12; //Enable TLS1.2 to connect to GitHub

            try
            {
                xml = new XmlTextReader("");
                xml.MoveToContent();
                string name = "";


            }
            catch 
            {
                
            }
        }
    }
}
