using System;
using System.Windows.Forms;

namespace MiniTools
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа в приложение.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем форму MiniTools3
            Application.Run(new MiniTools3());
        }
    }
}
