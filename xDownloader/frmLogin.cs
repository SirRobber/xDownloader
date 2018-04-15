using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using Microsoft.Win32;

namespace xDownloader
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public string GetHDDSerial()
        {
            string location = @"SOFTWARE\Microsoft\CryptoGraphy";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using(RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                    {
                        throw new KeyNotFoundException(string.Format("Key Not Found {0}", location));
                    }

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index Not Found {0}", name));
                    return machineGuid.ToString();
                }
            }
        }

        public void getHWID()
        {
            MessageBox.Show("HWID: " + Environment.NewLine + GetHDDSerial(), Text);
            Clipboard.SetText(GetHDDSerial());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient Wc = new WebClient();

            string pplbanned = Wc.DownloadString("http://adikkk.xyz/Auth/bHWID.txt");
            string pplallowed = Wc.DownloadString("http://adikkk.xyz/Auth/aHWID.txt");
            //btw the random site do i add my hwid site? ye
            if (pplbanned.Contains(GetHDDSerial()))
            {
                MessageBox.Show("You have been banned from xDownloader!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else if (pplallowed.Contains(GetHDDSerial()))
            {
                MessageBox.Show("You're allowed to use xDownloader, Welcome.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You're not whitelisted, make sure you sent Your" +
                    " Hwid to xDownloader and you bought our product.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(-1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getHWID();
        }
    }
}
