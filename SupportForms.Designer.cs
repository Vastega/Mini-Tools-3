namespace MiniTools
{
    partial class SupportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.LinkLabel linkChannel;
        private System.Windows.Forms.LinkLabel linkChat;
        private System.Windows.Forms.Button btnEditHosts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnFeedback = new System.Windows.Forms.Button();
            this.linkChannel = new System.Windows.Forms.LinkLabel();
            this.linkChat = new System.Windows.Forms.LinkLabel();
            this.btnEditHosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(20, 20);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(150, 30);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "Обратная связь";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // linkChannel
            // 
            this.linkChannel.AutoSize = true;
            this.linkChannel.Location = new System.Drawing.Point(20, 60);
            this.linkChannel.Name = "linkChannel";
            this.linkChannel.Size = new System.Drawing.Size(50, 13);
            this.linkChannel.TabIndex = 1;
            this.linkChannel.TabStop = true;
            this.linkChannel.Visible = false;
            this.linkChannel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChannel_LinkClicked);
            // 
            // linkChat
            // 
            this.linkChat.AutoSize = true;
            this.linkChat.Location = new System.Drawing.Point(20, 90);
            this.linkChat.Name = "linkChat";
            this.linkChat.Size = new System.Drawing.Size(50, 13);
            this.linkChat.TabIndex = 2;
            this.linkChat.TabStop = true;
            this.linkChat.Visible = false;
            this.linkChat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChat_LinkClicked);
            // 
            // btnEditHosts
            // 
            this.btnEditHosts.Location = new System.Drawing.Point(200, 20);
            this.btnEditHosts.Name = "btnEditHosts";
            this.btnEditHosts.Size = new System.Drawing.Size(150, 30);
            this.btnEditHosts.TabIndex = 3;
            this.btnEditHosts.Text = "Редактировать hosts";
            this.btnEditHosts.UseVisualStyleBackColor = true;
            this.btnEditHosts.Click += new System.EventHandler(this.btnEditHosts_Click);
            // 
            // SupportForm
            // 
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.linkChannel);
            this.Controls.Add(this.linkChat);
            this.Controls.Add(this.btnEditHosts);
            this.Name = "SupportForm";
            this.Text = "Mini-Tools Support";
            this.Load += new System.EventHandler(this.SupportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
