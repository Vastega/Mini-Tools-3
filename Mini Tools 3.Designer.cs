namespace MiniTools
{
    partial class MiniTools3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHostFile;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEditHosts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.LinkLabel linkChannel;
        private System.Windows.Forms.LinkLabel linkChat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtHostFile = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnEditHosts = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.linkChannel = new System.Windows.Forms.LinkLabel();
            this.linkChat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();

            // txtHostFile
            this.txtHostFile.Location = new System.Drawing.Point(20, 20);
            this.txtHostFile.Multiline = true;
            this.txtHostFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHostFile.Size = new System.Drawing.Size(450, 200);
            this.txtHostFile.ReadOnly = true;

            // txtSecond
            this.txtSecond.Location = new System.Drawing.Point(20, 240);
            this.txtSecond.Multiline = true;
            this.txtSecond.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecond.Size = new System.Drawing.Size(450, 200);

            int xBtn = 490;

            // btnBrowse
            this.btnBrowse.Location = new System.Drawing.Point(xBtn, 20);
            this.btnBrowse.Size = new System.Drawing.Size(150, 30);
            this.btnBrowse.Text = "Обзор";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // btnEditHosts
            this.btnEditHosts.Location = new System.Drawing.Point(xBtn, 60);
            this.btnEditHosts.Size = new System.Drawing.Size(150, 30);
            this.btnEditHosts.Text = "Редактировать hosts";
            this.btnEditHosts.Click += new System.EventHandler(this.btnEditHosts_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(xBtn, 100);
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(xBtn, 140);
            this.btnUpdate.Size = new System.Drawing.Size(150, 30);
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnFeedback
            this.btnFeedback.Location = new System.Drawing.Point(xBtn, 180);
            this.btnFeedback.Size = new System.Drawing.Size(150, 30);
            this.btnFeedback.Text = "Обратная связь";
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);

            // btnCheckUpdates
            this.btnCheckUpdates.Location = new System.Drawing.Point(xBtn, 220);
            this.btnCheckUpdates.Size = new System.Drawing.Size(150, 30);
            this.btnCheckUpdates.Text = "Проверить обновления";
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);

            // linkChannel
            this.linkChannel.Location = new System.Drawing.Point(xBtn, 270);
            this.linkChannel.AutoSize = true;
            this.linkChannel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChannel_LinkClicked);

            // linkChat
            this.linkChat.Location = new System.Drawing.Point(xBtn, 300);
            this.linkChat.AutoSize = true;
            this.linkChat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChat_LinkClicked);

            // MiniTools3
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.txtHostFile);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnEditHosts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.linkChannel);
            this.Controls.Add(this.linkChat);
            this.Text = "Mini Tools 3";
            this.Load += new System.EventHandler(this.MiniTools3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
