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
                ShowError("No internet network detected. Please check your internet connection. Program will exit.");
                Application.Exit();
            }
                
            try
            {
                Helper.ParseRetailFirmware();
                //system
                tbLabel.Text = Helper.SystemFirmware.FirmwareLabel;
                tbSdkVersion.Text = Helper.SystemFirmware.SdkVersion;
                tbFwVersion.Text = Helper.SystemFirmware.FirmwareVersion;
                tbFwSize.Text = Helper.SystemFirmware.Size;
                tbSha256.Text = Helper.SystemFirmware.Sha256;
                //tbMandatory.Text = Helper.SystemFirmware.Mandatory.ToString();
                //tbMd5.Text = Helper.SystemFirmware.Md5;
                //tbLink.Text = Helper.SystemFirmware.Link;

                ////recovery
                //tbLabelRec.Text = Helper.RecoveryFirmware.FirmwareLabel;
                //tbSdkVersionRec.Text = Helper.RecoveryFirmware.SdkVersion;
                //tbFwVersionRec.Text = Helper.RecoveryFirmware.FirmwareVersion;
                //tbFwSizeRec.Text = Helper.RecoveryFirmware.Size;
                //tbMandatoryRec.Text = Helper.RecoveryFirmware.Mandatory.ToString();
                //tbMd5Rec.Text = Helper.RecoveryFirmware.Md5;
                //tbLinkRec.Text = Helper.RecoveryFirmware.Link;
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
        }


        private void btnDownloadSystem_Click_1(object sender, EventArgs e)
        {
            if (cbRegionSystem.SelectedItem == null)
                return;
            string url = "";
            if (cbRegionSystem.SelectedItem == "Southeast Asia")
            {
                url = Helper.SystemFirmware.Link;
            }
            else if (cbRegionSystem.SelectedItem == "United Kingdom")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "duk01").Replace("?dest=sa", "?dest=uk");
            }
            else if (cbRegionSystem.SelectedItem == "Australia")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dau01").Replace("?dest=sa", "?dest=au");
            }
            else if (cbRegionSystem.SelectedItem == "Brazil")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dbr01").Replace("?dest=sa", "?dest=br");
            }
            else if (cbRegionSystem.SelectedItem == "China")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dcn01").Replace("?dest=sa", "?dest=cn");
            }
            else if (cbRegionSystem.SelectedItem == "European Union")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "deu01").Replace("?dest=sa", "?dest=eu");
            }
            else if (cbRegionSystem.SelectedItem == "Latin/Central America")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dmx01").Replace("?dest=sa", "?dest=mx");
            }
            else if (cbRegionSystem.SelectedItem == "Rusia")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dru01").Replace("?dest=sa", "?dest=ru");
            }
            else if (cbRegionSystem.SelectedItem == "Taiwan")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dtw01").Replace("?dest=sa", "?dest=tw");
            }
            else if (cbRegionSystem.SelectedItem == "Japan")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "djp01").Replace("?dest=sa", "?dest=jp");
            }
            else if (cbRegionSystem.SelectedItem == "Korea")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dkr01").Replace("?dest=sa", "?dest=kr");
            }
            else if (cbRegionSystem.SelectedItem == "United States")
            {
                url = Helper.SystemFirmware.Link.Replace("dsa01", "dus01").Replace("?dest=sa", "?dest=us");
            }
            System.Diagnostics.Process.Start(url);
        }
    }
}
