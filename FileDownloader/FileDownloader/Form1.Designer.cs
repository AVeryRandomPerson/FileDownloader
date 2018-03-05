namespace FileDownloader
{
    partial class DownloaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.saveLocationLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 108);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(574, 23);
            this.downloadProgressBar.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.AccessibleName = "";
            this.urlTextBox.Location = new System.Drawing.Point(102, 13);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(484, 20);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(102, 39);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(484, 20);
            this.savePathTextBox.TabIndex = 1;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(9, 16);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            // 
            // saveLocationLabel
            // 
            this.saveLocationLabel.AutoSize = true;
            this.saveLocationLabel.Location = new System.Drawing.Point(9, 42);
            this.saveLocationLabel.Name = "saveLocationLabel";
            this.saveLocationLabel.Size = new System.Drawing.Size(76, 13);
            this.saveLocationLabel.TabIndex = 2;
            this.saveLocationLabel.Text = "Save Location";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(451, 65);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(135, 37);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // DownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 143);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.saveLocationLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.downloadProgressBar);
            this.Name = "DownloaderForm";
            this.Text = "Download From URL !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label saveLocationLabel;
        private System.Windows.Forms.Button downloadButton;
    }
}

