using ByteSizeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS5_Firmware_Checker
{
    public class Helper
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply.Status != IPStatus.Success)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void ParseRetailFirmware()
        {
            //using (WebClient retailDownloadXML = new WebClient())
            //SystemFirmware.DownloadString = retailDownloadXML.DownloadString("https://fus01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/list/us/updatelist.xml");
            //XDocument xdoc = XDocument.Parse(SystemFirmware.DownloadString);

            var nasdaq = string.Format(@"https://fsa01.ps5.update.playstation.net/update/ps5/official/tJMRE80IbXnE9YuG0jzTXgKEjIMoabr6/list/sa/updatelist.xml");
            using (WebClient wc = new WebClient())
            {
                ServicePointManager
       .ServerCertificateValidationCallback +=
       (send, cert, chain, sslPolicyErrors) => true;
                wc.Headers.Add("cookie", "");

                SystemFirmware.DownloadString = wc.DownloadString(nasdaq);
                XDocument xdoc = XDocument.Parse(SystemFirmware.DownloadString);
                //system pup
                xdoc.Descendants("region").Select(sys => new
                {
                    label = sys.Element("system_pup").Attribute("label").Value,
                    sdkVersion = sys.Element("system_pup").Attribute("sdk_version").Value,
                    fwVersion = sys.Element("system_pup").Attribute("upd_version").Value,
                }).ToList().ForEach(sys =>
                {
                    SystemFirmware.FirmwareLabel = sys.label;
                    SystemFirmware.SdkVersion = sys.sdkVersion;
                    SystemFirmware.FirmwareVersion = sys.fwVersion;
                });
                //xdoc.Descendants("force_update").Select(misc => new
                //{
                //    mandatory = misc.Element("system").Attribute("level0_system_version"),
                //}).ToList().ForEach(misc =>
                //{
                //    SystemFirmware.MandatoryString = misc.mandatory.ToString();
                //    SystemFirmware.MandatoryString = SystemFirmware.MandatoryString.Replace("level0_system_version", "").Replace("\"", "").Replace("=", "");
                //    if (SystemFirmware.FirmwareVersion != SystemFirmware.MandatoryString)
                //        SystemFirmware.Mandatory = false;
                //    else
                //        SystemFirmware.Mandatory = true;
                //});
                xdoc.Descendants("update_data").Select(misc => new
                {
                    Size = misc.Element("image").Attribute("size").Value,
                }).ToList().ForEach(misc =>
                {
                    SystemFirmware.SizeString = misc.Size;
                    var size_int = Convert.ToInt32(SystemFirmware.SizeString);
                    SystemFirmware.Size = ByteSize.FromBytes(size_int).ToString();
                });
                xdoc.Descendants("update_data").Select(misc => new
                {
                    Link = misc.Element("image").Value

                }).ToList().ForEach(misc =>
                {
                    SystemFirmware.Link = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">", "").Replace("?dest=sa</image>", "").Replace(">", "").Replace(SystemFirmware.Size, "").Replace(SystemFirmware.SizeString, ""); ;
                });
                SystemFirmware.Sha256 = SystemFirmware.Link.Substring(SystemFirmware.Link.IndexOf('_') + 10);
                string SysMd5 = SystemFirmware.Sha256.Split('/')[0];
                SystemFirmware.Sha256 = SysMd5.ToUpper();
                #region recovery
                //recovery pup
                //xdoc.Descendants("recovery_pup").Select(misc => new
                //{
                //    size = misc.Element("image").Attribute("size"),
                //}).ToList().ForEach(misc =>
                //{
                //    RecoveryFirmware.SizeString = misc.size.ToString().Replace("size=", "").Replace("\"", "");
                //    var size_int = Convert.ToInt32(RecoveryFirmware.SizeString);
                //    RecoveryFirmware.Size = ByteSize.FromBytes(size_int).ToString();
                //});
                //xdoc.Descendants("recovery_pup").Select(misc => new
                //{
                //    Link = misc.Element("image")
                //}).ToList().ForEach(misc =>
                //{
                //    RecoveryFirmware.Link = misc.Link.ToString().Replace("<image size=\"", "").Replace("\"", "").Replace("\">", "").Replace("?dest=sa</image>", "").Replace(">", "").Replace(RecoveryFirmware.SizeString, "");
                //});
                //xdoc.Descendants("recovery_pup").Select(rec => new
                //{
                //    label = rec.Element("system_pup").Attribute("label"),
                //    sdkVersion = rec.Element("system_pup").Attribute("sdk_version"),
                //    fwVersion = rec.Element("system_pup").Attribute("version"),

                //}).ToList().ForEach(rec =>
                //{
                //    RecoveryFirmware.FirmwareLabel = rec.label.ToString().Replace("label=", "").Replace("\"", "");
                //    RecoveryFirmware.SdkVersion = rec.sdkVersion.ToString().Replace("sdk_version=", "").Replace("\"", "");
                //    RecoveryFirmware.FirmwareVersion = rec.fwVersion.ToString().Replace("version=", "").Replace("\"", "");
                //});
                //RecoveryFirmware.Md5 = RecoveryFirmware.Link.Substring(RecoveryFirmware.Link.IndexOf('_') + 10);
                //string recMd5 = RecoveryFirmware.Md5.Split('/')[0];
                //RecoveryFirmware.Md5 = recMd5.ToUpper();
                #endregion recovery
            }



        }

        public static void ParseBetaFirmware()
        {
            // Directory.CreateDirectory(path + "\\Temp");

            // try
            // {
            //     var nasdaq = string.Format(@"https://fus01.ps4.update.playstation.net/update/ps4/beta/list/us/ps4-eap-updatelist_PR2daYNOWIyy6WYwNw5JVwsRAWMl85Av.xml");
            //     using (WebClient wc = new WebClient())
            //     {
            //         ServicePointManager
            //.ServerCertificateValidationCallback +=
            //(send, cert, chain, sslPolicyErrors) => true;
            //         wc.Headers.Add("cookie", "");

            //         wc.DownloadFile(nasdaq, path + "\\Temp\\ps4-eap-updatelist.xml");
            //     }

            //     XDocument beta_read = XDocument.Load(path + @"\\Temp\ps4-eap-updatelist.xml");
            //     beta_read.Descendants("region").Select(sys => new
            //     {
            //         sdkVersion_BETA = sys.Element("system_pup").Attribute("sdk_version"),
            //         fwVersion_BETA = sys.Element("system_pup").Attribute("version"),

            //     }).ToList().ForEach(sys =>
            //     {
            //         string sdkbeta = sys.sdkVersion_BETA.ToString().Replace("sdk_version=", "").Replace("\"", "").Replace(".", "");
            //         string first_4 = sdkbeta.Substring(0, 4);
            //         string first_4_final = first_4.Substring(1, 3);
            //         string last_4 = sdkbeta.Substring(4, 4);
            //         string last_4_final = last_4.Substring(0, 1);
            //         tbSDKBETA.Text = first_4_final.Insert(1, ".") + " B" + last_4_final;

            //         string rollback = sys.fwVersion_BETA.ToString().Replace("version=", "").Replace("\"", "").Replace(".", "");
            //         string first_4_rollback = rollback.Substring(0, 4);
            //         string first_4_rollback_final = first_4_rollback.Substring(1, 3);

            //         tbFWVersionBETA.Text = first_4_rollback_final.Insert(1, ".");
            //     });
            // }
            // catch
            // {
            //     MessageBox.Show("Could not retrieved beta firmware info", "PS4 Firmware Checker");
            // }
        }

        public class SystemFirmware
        {
            private static string DownloadString_;
            internal static string DownloadString
            {
                get { return DownloadString_; }
                set { DownloadString_ = value; }
            }
            private static string FirmwareLabel_;
            public static string FirmwareLabel
            {
                get { return FirmwareLabel_; }
                set { FirmwareLabel_ = value; }
            }
            private static string SdkVersion_;
            public static string SdkVersion
            {
                get { return SdkVersion_; }
                set { SdkVersion_ = value; }
            }
            private static string FirmwareVersion_;
            public static string FirmwareVersion
            {
                get { return FirmwareVersion_; }
                set { FirmwareVersion_ = value; }
            }
            private static string SizeString_;
            internal static string SizeString
            {
                get { return SizeString_; }
                set { SizeString_ = value; }
            }
            private static string Size_;
            public static string Size
            {
                get { return Size_; }
                set { Size_ = value; }
            }
            private static string MandatoryString_;
            internal static string MandatoryString
            {
                get { return MandatoryString_; }
                set { MandatoryString_ = value; }
            }
            private static bool Mandatory_;
            public static bool Mandatory
            {
                get { return Mandatory_; }
                set { Mandatory_ = value; }
            }
            private static string Sha256_;
            public static string Sha256
            {
                get { return Sha256_; }
                set { Sha256_ = value; }
            }
            private static string Link_;
            public static string Link
            {
                get { return Link_; }
                set { Link_ = value; }
            }
        }
        public class RecoveryFirmware
        {
            private static string DownloadString_;
            internal static string DownloadString
            {
                get { return DownloadString_; }
                set { DownloadString_ = value; }
            }
            private static string FirmwareLabel_;
            public static string FirmwareLabel
            {
                get { return FirmwareLabel_; }
                set { FirmwareLabel_ = value; }
            }
            private static string SdkVersion_;
            public static string SdkVersion
            {
                get { return SdkVersion_; }
                set { SdkVersion_ = value; }
            }
            private static string FirmwareVersion_;
            public static string FirmwareVersion
            {
                get { return FirmwareVersion_; }
                set { FirmwareVersion_ = value; }
            }
            private static string SizeString_;
            internal static string SizeString
            {
                get { return SizeString_; }
                set { SizeString_ = value; }
            }
            private static string Size_;
            public static string Size
            {
                get { return Size_; }
                set { Size_ = value; }
            }
            private static string MandatoryString_;
            internal static string MandatoryString
            {
                get { return MandatoryString_; }
                set { MandatoryString_ = value; }
            }
            private static bool Mandatory_;
            public static bool Mandatory
            {
                get { return Mandatory_; }
                set { Mandatory_ = value; }
            }
            private static string Md5_;
            public static string Md5
            {
                get { return Md5_; }
                set { Md5_ = value; }
            }
            private static string Link_;
            public static string Link
            {
                get { return Link_; }
                set { Link_ = value; }
            }
        }
    }
}
