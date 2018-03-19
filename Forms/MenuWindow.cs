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
    /// This Class Contains the actions of the menu
    /// </summary>

    public partial class MenuWindow : Form
    {
        GetStarted newreg;
        public MenuWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Open The Browser with URL
        /// </summary>
       
        private void GitHub_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Guila767");
            this.Close();
        }

        /// <summary>
        /// Open The GetStarted Window to create new registy 
        /// </summary>
        
        private void Create_btn_Click(object sender, EventArgs e)
        {
            newreg = new GetStarted(false);
            this.Hide();
            newreg.ShowDialog();
            this.Close();
        }
    }
}
