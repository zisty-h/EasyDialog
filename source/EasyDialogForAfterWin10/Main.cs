using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDialog
{
    public partial class Main : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            if (IsDarkMode())
            {
                int value = 1;
                _ = NativeMethods.DwmSetWindowAttribute(Handle, NativeMethods.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref value, (uint)Marshal.SizeOf(typeof(int)));
            }
            
        }

        static bool IsDarkMode()
        {
            const string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string registryValue = "AppsUseLightTheme";

            try
            {
                // レジストリから値を取得
                object registryResult = Registry.GetValue(registryKey, registryValue, 1);

                if (registryResult != null && registryResult is int)
                {
                    // 0 はダークモード、1 はライトモード
                    int value = (int)registryResult;
                    return value == 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading registry: " + ex.Message);
            }

            // デフォルトはライトモード
            return true;
        }

        private static class NativeMethods
        {
            [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attribute, ref int pvAttribute, uint cbAttribute);
            public enum DWMWINDOWATTRIBUTE
            {
                DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
                DWMWA_WINDOW_CORNER_PREFERENCE = 33,
                DWMWA_MICA_EFFECT = 1029,
                DWMWA_LAST
            }
        }

        public Main()
        {
            InitializeComponent();


            if (IsDarkMode())
            {
                Color DarkGlay = Color.FromArgb(20, 20, 20);
                Color Glay = Color.FromArgb(30, 30, 30);

                BackColor = DarkGlay;
                ForeColor = Color.White;

                groupBox1.ForeColor = Color.White;

                groupBox2.ForeColor = Color.White;

                Run.BackColor = Glay;

                ContentTextBox.BackColor = Glay;
                ContentTextBox.ForeColor = Color.White;

                Title.BackColor = Glay;
                Title.ForeColor = Color.White;
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            //Set Icon.

            MessageBoxIcon icon = new MessageBoxIcon();

            if (Ico_None.Checked)
            {
                icon = MessageBoxIcon.None;
            }
            else if (Ico_Error.Checked)
            {
                icon = MessageBoxIcon.Error;
            }
            else if (Ico_Warn.Checked)
            {
                icon = MessageBoxIcon.Warning;
            }
            else if (Ico_Ques.Checked)
            {
                icon = MessageBoxIcon.Question;
            }
            else if (Ico_Info.Checked)
            {
                icon = MessageBoxIcon.Information;
            }

            /*--------------------------------------------------*/

            //Set button.

            MessageBoxButtons button = new MessageBoxButtons();

            if (Btn_OK.Checked)
            {
                button = MessageBoxButtons.OK;
            }
            else if (Btn_OkCancel.Checked)
            {
                button = MessageBoxButtons.OKCancel;
            }
            else if (Btn_YesNo.Checked)
            {
                button = MessageBoxButtons.YesNo;
            }
            else if (Btn_YesNoCan.Checked)
            {
                button = MessageBoxButtons.YesNoCancel;
            }
            else if (Btn_RetryCan.Checked)
            {
                button = MessageBoxButtons.RetryCancel;
            }
            else if (Btn_AbReIg.Checked)
            {
                button = MessageBoxButtons.AbortRetryIgnore;
            }

            /*--------------------------------------------------*/

            MessageBox.Show(ContentTextBox.Text, Title.Text, button, icon);
        }
    }
}
