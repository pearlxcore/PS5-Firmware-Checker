using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DarkUI;
using DarkUI.Forms;

namespace PS5_Firmware_Checker
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowError(string text)
        {
            DarkMessageBox.ShowError(text, "Error");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Helper.CheckForInternetConnection() == false) 
            { 
                ShowError("No internet network detected. Please check your internet connection.");
                return;
            }
                
            try
            {
                Helper.ParseRetailFirmware();
                //system
                tbLabel.Text = Helper.SystemFirmware.FirmwareLabel;
                tbSdkVersion.Text = Helper.SystemFirmware.SdkVersion;
                tbFwVersion.Text = Helper.SystemFirmware.FirmwareVersion;
                tbFwSize.Text = Helper.SystemFirmware.Size;
                tbMandatory.Text = Helper.SystemFirmware.Mandatory.ToString();
                tbMd5.Text = Helper.SystemFirmware.Md5;
                tbLink.Text = Helper.SystemFirmware.Link;
                //recovery
                tbLabelRec.Text = Helper.RecoveryFirmware.FirmwareLabel;
                tbSdkVersionRec.Text = Helper.RecoveryFirmware.SdkVersion;
                tbFwVersionRec.Text = Helper.RecoveryFirmware.FirmwareVersion;
                tbFwSizeRec.Text = Helper.RecoveryFirmware.Size;
                tbMandatoryRec.Text = Helper.RecoveryFirmware.Mandatory.ToString();
                tbMd5Rec.Text = Helper.RecoveryFirmware.Md5;
                tbLinkRec.Text = Helper.RecoveryFirmware.Link;
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnDownloadRecovery_Click(object sender, EventArgs e)
        {
            if (cbRegionSystem.SelectedText == "")
                return;
            string url = "";
            if (cbRegionSystem.SelectedText == "Southeast Asia")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dus01", "dsa01");
                url = Helper.SystemFirmware.Link + "?dest=sa";
            }
            else if (cbRegionSystem.SelectedText == "United Kingdom")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "duk01");
                url = Helper.SystemFirmware.Link + "?dest=uk";
            }
            else if (cbRegionSystem.SelectedText == "Australia")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dau01");
                url = Helper.SystemFirmware.Link + "?dest=au";
            }
            else if (cbRegionSystem.SelectedText == "Brazil")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dbr01");
                url = Helper.SystemFirmware.Link + "?dest=br";
            }
            else if (cbRegionSystem.SelectedText == "China")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dcn01");
                url = Helper.SystemFirmware.Link + "?dest=cn";
            }
            else if (cbRegionSystem.SelectedText == "European Union")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "deu01");
                url = Helper.SystemFirmware.Link + "?dest=eu";
            }
            else if (cbRegionSystem.SelectedText == "Latin/Central America")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dmx01");
                url = Helper.SystemFirmware.Link + "?dest=mx";
            }
            else if (cbRegionSystem.SelectedText == "Rusia")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dru01");
                url = Helper.SystemFirmware.Link + "?dest=ru";
            }
            else if (cbRegionSystem.SelectedText == "Taiwan")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dtw01");
                url = Helper.SystemFirmware.Link + "?dest=tw";
            }
            else if (cbRegionSystem.SelectedText == "Japan")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "djp01");
                url = Helper.SystemFirmware.Link + "?dest=jp";
            }
            else if (cbRegionSystem.SelectedText == "Korea")
            {
                Helper.SystemFirmware.Link = Helper.SystemFirmware.Link.Replace("dsa01", "dkr01");
                url = Helper.SystemFirmware.Link + "?dest=kr";
            }
            else if (cbRegionSystem.SelectedText == "United States")
            {
                url = Helper.SystemFirmware.Link + "?dest=us";
            }
            System.Diagnostics.Process.Start(url);
        }

        private void btnDownloadSystem_Click(object sender, EventArgs e)
        {
            if (cbRegionRecovery.SelectedText == "")
                return;
            string url = "";
            if (cbRegionRecovery.SelectedText == "Southeast Asia")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dus01", "dsa01");
                url = Helper.RecoveryFirmware.Link + "?dest=sa";
            }
            else if (cbRegionRecovery.SelectedText == "United Kingdom")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "duk01");
                url = Helper.RecoveryFirmware.Link + "?dest=uk";
            }
            else if (cbRegionRecovery.SelectedText == "Australia")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dau01");
                url = Helper.RecoveryFirmware.Link + "?dest=au";
            }
            else if (cbRegionRecovery.SelectedText == "Brazil")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dbr01");
                url = Helper.RecoveryFirmware.Link + "?dest=br";
            }
            else if (cbRegionRecovery.SelectedText == "China")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dcn01");
                url = Helper.RecoveryFirmware.Link + "?dest=cn";
            }
            else if (cbRegionRecovery.SelectedText == "European Union")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "deu01");
                url = Helper.RecoveryFirmware.Link + "?dest=eu";
            }
            else if (cbRegionRecovery.SelectedText == "Latin/Central America")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dmx01");
                url = Helper.RecoveryFirmware.Link + "?dest=mx";
            }
            else if (cbRegionRecovery.SelectedText == "Rusia")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dru01");
                url = Helper.RecoveryFirmware.Link + "?dest=ru";
            }
            else if (cbRegionRecovery.SelectedText == "Taiwan")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dtw01");
                url = Helper.RecoveryFirmware.Link + "?dest=tw";
            }
            else if (cbRegionRecovery.SelectedText == "Japan")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "djp01");
                url = Helper.RecoveryFirmware.Link + "?dest=jp";
            }
            else if (cbRegionRecovery.SelectedText == "Korea")
            {
                Helper.RecoveryFirmware.Link = Helper.RecoveryFirmware.Link.Replace("dsa01", "dkr01");
                url = Helper.RecoveryFirmware.Link + "?dest=kr";
            }
            else if (cbRegionRecovery.SelectedText == "United States")
            {
                url = Helper.RecoveryFirmware.Link + "?dest=us";
            }
            System.Diagnostics.Process.Start(url);
        }
    }
}
