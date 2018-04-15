using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace xDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string ver = "v0.1";

        private void Form1_Load(object sender, EventArgs e)
        {

            string xDownloaderV = new WebClient().DownloadString("http://adikkk.xyz/files/xDownloaderV.txt");

            if (xDownloaderV == ver)
            {

                string fileName = string.Format("{0}/data.dat", Application.StartupPath);
                if (File.Exists(fileName))
                    App.DB.ReadXml(fileName);
                foreach (Database.FilesRow row in App.DB.Files)
                {
                    ListViewItem item = new ListViewItem(row.Id.ToString());
                    item.SubItems.Add(row.Url);
                    item.SubItems.Add(row.FileName);
                    item.SubItems.Add(row.FileSize);
                    item.SubItems.Add(row.DateTime.ToLongDateString());
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("There Is New Update, Click OK to Download It Now.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("http://adikkk.xyz/files/xDownloader.7z");
                this.Close();
            }


            

        }

        private void tsSetting_Click(object sender, EventArgs e)
        {
            using(frmSetting frm = new frmSetting())
            {
                frm.ShowDialog();
            }
        }

        private void tsAddUrl_Click(object sender, EventArgs e)
        {
            using (frmAddUrl frm = new frmAddUrl())
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    frmDownload frmDownload = new frmDownload(this);
                    frmDownload.Url = frm.Url;
                    frmDownload.Show();
                }
            }
        }

        private void tsRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to delete this record?", "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for(int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.DB.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();
                }

                App.DB.AcceptChanges();
                App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
