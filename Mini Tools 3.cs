using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MiniTools
{
    public partial class MiniTools3 : Form
    {
        private string hostsPath = @"C:\Windows\System32\drivers\etc\hosts";
        private string currentVersion = "1.0.0"; // текущая версия программы

        public MiniTools3()
        {
            InitializeComponent();
        }

        private void MiniTools3_Load(object sender, EventArgs e)
        {
            // Подгружаем файл hosts в верхний TextBox
            try
            {
                if (File.Exists(hostsPath))
                    txtHostFile.Text = File.ReadAllText(hostsPath);
            }
            catch { }

            // Настройка ссылок для обратной связи
            linkChannel.Text = "Mini-Tools";
            linkChannel.Links.Add(0, linkChannel.Text.Length, "https://t.me/+RYQNf9ms--EwMmMy");

            linkChat.Text = "Чат Mini-Tools";
            linkChat.Links.Add(0, linkChat.Text.Length, "https://t.me/+RYQNf9ms--EwMmMy");

            linkChannel.Visible = false;
            linkChat.Visible = false;
        }

        // Открыть файл через диалог
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSecond.Text = File.ReadAllText(ofd.FileName);
            }
        }

        // Редактировать hosts через блокнот
        private void btnEditHosts_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("notepad.exe", hostsPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл hosts: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сохранить файл из нижнего TextBox
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtSecond.Text);
                MessageBox.Show("Файл сохранен!", "Info");
            }
        }

        // Обновление данных (пример)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обновление данных (реализовать свою логику).", "Info");
        }

        // Показать ссылки на обратную связь
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

        // Проверка обновлений через URL
        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/Vastega/Mini-Tools";
                WebClient client = new WebClient();
                string latestVersion = client.DownloadString(url).Trim();

                if (latestVersion != currentVersion)
                    MessageBox.Show($"Доступна новая версия: {latestVersion}", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("У вас установлена последняя версия.", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки обновлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
