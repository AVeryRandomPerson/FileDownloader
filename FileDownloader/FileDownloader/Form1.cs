using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class DownloaderForm : Form
    {
        public DownloaderForm()
        {
            InitializeComponent();
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            savePathTextBox.Text = Path.GetFileName(urlTextBox.Text);  
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadProgressBar.Value = 0;
            downloadButton.Enabled = false;
            WebClient downloadClient = new WebClient();
            downloadClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
            downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
            downloadClient.DownloadFileAsync(new Uri(urlTextBox.Text), savePathTextBox.Text);
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Download Finished !");
                downloadButton.Enabled = true;
            }
            else
            {
                MessageBox.Show(e.Error.Message);
            }

            ((WebClient)sender).Dispose();
        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgressBar.Value = e.ProgressPercentage;
        }
    }
}
