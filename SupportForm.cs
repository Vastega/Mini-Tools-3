using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class SupportForm : Form
    {
        private string hostsPath = @"C:\Windows\System32\drivers\etc\hosts";

        public SupportForm()
        {
            InitializeComponent();
        }

        private void SupportForm_Load(object sender, EventArgs e)
        {
            // Настройка ссылок
            linkChannel.Text = "Mini-Tools";
            linkChannel.Links.Add(0, linkChannel.Text.Length, "https://t.me/+LbfA7oQzs0VkNGUy");

            linkChat.Text = "Чат Mini-Tools";
            linkChat.Links.Add(0, linkChat.Text.Length, "https://t.me/+bI0CB_Xm1OA2NzUy");

            linkChannel.Visible = false;
            linkChat.Visible = false;
        }

        // Обратная связь
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            linkChannel.Visible = true;
            linkChat.Visible = true;
        }

        private void linkChannel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }

        private void linkChat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }

        // Редактирование hosts через Блокнот
        private void btnEditHosts_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("notepad.exe", hostsPath)
                {
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл hosts: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
