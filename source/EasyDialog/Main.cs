using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDialog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

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
