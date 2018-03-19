using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bf2_Registry_Manager
{
    /// <summary>
    /// This class is responsible for Get Started Window
    /// </summary>
    public partial class GetStarted : Form
    {
        #region Constructors

        /// <summary>
        /// This Constructor is used when the program is run for the first time and provide all the resources of UI
        /// </summary>
        public GetStarted()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This Constructor has parameters to disable resources of the UI
        /// </summary>
        /// <param name="Disable_ChangeRbtn">Disable The "Change_radioBtn" Radio Button </param>
        public GetStarted(bool Disable_ChangeRbtn)
        {
            InitializeComponent();
            Change_radioBtn.Enabled = Disable_ChangeRbtn;
        }

        #endregion

        #region MoveFmr

        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0x00A1;

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern bool ReleaseCapture();

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hwnd,
            int wMsg,
            int wParam,
            int lParam);

        private void TopPainel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        #region Buttons
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to quit?", "Close This App?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK) { Application.Exit(); }
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            if (Install_radioBtn.Checked)
            {
                GameDir gameDir = new GameDir();
                gameDir.ShowDialog();
                this.Close();
            }
            else if (Change_radioBtn.Checked)
            {
                this.Close();
            }
        }
        #endregion
    }
}
