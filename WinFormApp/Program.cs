using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.UserForms;

namespace WinFormApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);
            //执行登录
            LoginForm login = new LoginForm();
            var result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            // Application.Run(new LoginForm());
        }
    }
}
