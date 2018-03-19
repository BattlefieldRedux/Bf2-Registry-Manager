using System;
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
    /// This class is responsible for getting the game dir
    /// </summary>
    public partial class GameDir : Form
    {
        const string Txtbx = @"...\BF2.exe";
        string gameDir, gameExe;
        bool is64Bits;

        public GameDir()
        {
            is64Bits = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            InitializeComponent();
        }

        #region Buttons
        private void Search_btn_Click(object sender, EventArgs e)
        {
            txtBx_Dir.Text = Txtbx;
            OpenFileDialog.ShowDialog();
        }
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (gameDir != "" && gameExe == "BF2.exe")
            {
                Bf2Registry.DeleteRegistry(is64Bits);
                Bf2Registry.NewGame(gameDir, gameExe, is64Bits);
                this.Close();
            }
        }
        #endregion

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (OpenFileDialog.SafeFileName == "BF2.exe")
            {
                gameDir = OpenFileDialog.FileName.Substring(0, OpenFileDialog.FileName.LastIndexOf(@"\"));
                gameExe = OpenFileDialog.SafeFileName;
                txtBx_Dir.Text = gameDir + "\\" + gameExe;
                txtBx_Dir.Update();
            }
            else
                gameDir = String.Empty;
        }
    }
}
