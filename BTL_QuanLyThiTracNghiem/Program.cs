using BTL_QuanLyThiTracNghiem.FormsManager;
using System;
using System.Threading;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Thread thread1 = new Thread(() =>
            {
                Application.Run(new FormDangNhap());
            });
            thread1.Start();*/
            Application.Run(new FormDangNhap());
        }
        public static Form FindFormExisting(string nameform)
        {
            foreach (Form item in Application.OpenForms)
                if (item.Name.Equals(nameform))
                    return item;
            return null;
        }
    }
}
