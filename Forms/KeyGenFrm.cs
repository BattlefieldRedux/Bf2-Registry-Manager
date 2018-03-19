using System;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bf2_Registry_Manager
{
    /// <summary>
    /// This class contains all functions of KeyGenFmr
    /// </summary>
    public partial class KeyGenFrm : Form
    {
        bool is64Bits, getStarted; 
        MenuWindow menu = new MenuWindow();

        #region Constructors
        /// <summary>
        /// This Constructor is used when the program is run for the first time
        /// </summary>

        public KeyGenFrm()
        {
            this.is64Bits = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            InitializeComponent();
            if (is64Bits)
                Lbl_OSarch.Text += "x64";
            else
                Lbl_OSarch.Text += "x86";
            ProgramRegistry.CreateReg(Display_GetStarted: false);
        }
        /// <summary>
        /// This Constructor has the parameters of the last options changed
        /// </summary>
        /// <param name="Bf2Hub">BF2Hub Compatibility</param>
        /// <param name="Mode1">Compatibility Mode 1</param>

        public KeyGenFrm(bool Bf2Hub, bool Mode1)
        {
            this.is64Bits = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            InitializeComponent();
            if (is64Bits)
                Lbl_OSarch.Text += "x64";
            else
                Lbl_OSarch.Text += "x86";
            ProgramRegistry.GetReg(out this.getStarted, out bool _Bf2Hub, out bool _Mode1);
            {
                CheckBx_Bf2Hub.Checked = _Bf2Hub;
                CheckBx_Mode1.Checked = _Mode1;
            }

        }
        #endregion

        #region Mouse
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT { public int X, Y; }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        /// <summary>
        /// This Functions is reponsible for gets the mouse positions (using the "user32.dll") 
        /// </summary>
        /// <returns>A struct of x and y coordinates</returns>

        public static POINT GetCursorPosition()
        {
            GetCursorPos(out POINT Point);
            return Point;
        }
        #endregion

        #region Buttons

        private void Btn_GetCDkey_Click(object sender, EventArgs e)
        {
            Bf2Registry.GetKey(out string BF2_key, out string BF2SF_key, is64Bits);
            if (BF2_key.Length >= 24 && BF2SF_key.Length >= 24)
            {
                if (!BF2SF_key.Contains("-") && !BF2_key.Contains("-"))
                {
                    for (int count = 4; count < 24; count += 5)
                    {
                        BF2_key = BF2_key.Insert(count, "-");
                        BF2SF_key = BF2SF_key.Insert(count, "-");
                    }
                }
                MessageBox.Show($"Battlefield 2:\n     {BF2_key}\n\nBattlefild 2 Special Forces:\n     {BF2SF_key}", "Your CD-KEY", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Battlefield 2:\n     {"Not Found"}\n\nBattlefild 2 Special Forces:\n     {"Not Found"}", "Your CD-KEY", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            string[] bf2Key = CDkeyGenerator.GenerateRandomKey().Split('-');
            string[] bf2SFkey;
            Thread.Sleep(100);

            if (CheckBx_Bf2Hub.Checked)
                bf2SFkey = bf2Key;
            else
                bf2SFkey = CDkeyGenerator.GenerateRandomKey().Split('-');
            

            TextBox[] bf2_key = { TxtBx_Bf2key1, TxtBx_Bf2key2, TxtBx_Bf2key3, TxtBx_Bf2key4, TxtBx_Bf2key5 };
            TextBox[] bf2SF_key = { TxtBx_Bf2SFkey1, TxtBx_Bf2SFkey2, TxtBx_Bf2SFkey3, TxtBx_Bf2SFkey4, TxtBx_Bf2SFkey5 };
            int count = 0;
            foreach (TextBox txtbf2 in bf2_key)
            {
                txtbf2.ForeColor = Color.Black;
                if (txtbf2 == bf2_key[count])
                    txtbf2.Text = bf2Key[count];
                count++;
            }
            count = 0;
            foreach (TextBox txtSF in bf2SF_key)
            {
                txtSF.ForeColor = Color.Black;
                if (txtSF == bf2SF_key[count])
                    txtSF.Text = bf2SFkey[count];
                count++;
            }
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            Btn_Apply.Enabled = false;
            bool KeyOk = false;
            TextBox[] bf2_key = { TxtBx_Bf2key1, TxtBx_Bf2key2, TxtBx_Bf2key3, TxtBx_Bf2key4, TxtBx_Bf2key5 };
            TextBox[] bf2SF_key = { TxtBx_Bf2SFkey1, TxtBx_Bf2SFkey2, TxtBx_Bf2SFkey3, TxtBx_Bf2SFkey4, TxtBx_Bf2SFkey5 };
            foreach (TextBox txtbf2 in bf2_key)
            {
                txtbf2.ForeColor = Color.Black;
                if (txtbf2.Text.Length == 4)
                    KeyOk = true;
                else
                {
                    SystemSounds.Asterisk.Play();
                    txtbf2.Focus();
                    KeyOk = false;
                    txtbf2.ForeColor = Color.Red;
                    break;
                }

            }
            if (KeyOk)
            {
                foreach (TextBox txtSF in bf2SF_key)
                {
                    txtSF.ForeColor = Color.Black;
                    if (txtSF.Text.Length == 4)
                        KeyOk = true;
                    else
                    {
                        SystemSounds.Asterisk.Play();
                        txtSF.Focus();
                        KeyOk = false;
                        txtSF.ForeColor = Color.Red;
                        break;
                    }

                }
            }

            if (KeyOk)
            {
                const int KeyLenght = 24;
                string BF2_key = "", BF2sf_key = "";
                foreach (TextBox txtbf2 in bf2_key)     // Bf2 key
                {
                    BF2_key += txtbf2.Text;
                    if (BF2_key.Length < KeyLenght && !CheckBx_Mode1.Checked)
                        BF2_key += "-";
                }
                foreach (TextBox txtSF in bf2SF_key)    // Bf2 Special Forces key
                {
                    BF2sf_key += txtSF.Text;
                    if (BF2sf_key.Length < KeyLenght && !CheckBx_Mode1.Checked)
                        BF2sf_key += "-";
                }
                Bf2Registry.SetKey(BF2_key, BF2sf_key, out bool Error, is64Bits);
                if (!Error)
                {
                    MessageBox.Show("Your CD-KEY has been successfully configured!", "All Done !", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Btn_Apply.Focus();
                }
            }
            Btn_Apply.Enabled = true;
        }

        private void Menu_Btn_Click(object sender, EventArgs e)
        {
            if (menu.IsDisposed || menu == null)
                menu = new MenuWindow();
            menu.SetDesktopLocation(GetCursorPosition().X - 50, GetCursorPosition().Y + -115);
            if (menu.Visible)
                menu.Hide();
            else if (!menu.Focused)
            {
                menu.Show();
                menu.Focus();
            }
        }

        private void Compatibility_State(object sender, EventArgs e)
        {
            ProgramRegistry.CreateReg(
                Display_GetStarted: this.getStarted,
                Bf2Hub: CheckBx_Bf2Hub.Checked,
                Mode1: CheckBx_Mode1.Checked
                );
        }
        
        #endregion

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            if (!menu.IsDisposed || menu == null)
                menu.Hide();
        }
    }
}