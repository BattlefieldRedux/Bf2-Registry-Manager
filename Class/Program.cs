using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Bf2_Registry_Manager
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProgramRegistry.GetReg(out bool getStarted, out bool Bf2Hub, out bool Mode1);
            if (getStarted)
                Application.Run(new GetStarted());
            if (!getStarted)
                Application.Run(new KeyGenFrm(
                    Bf2Hub: Bf2Hub,
                    Mode1: Mode1
                    ));
            else
                Application.Run(new KeyGenFrm());
        }
    }

    static class ProgramRegistry
    {
        /// <summary>
        /// Creates or Sets The Program Registry.
        /// </summary>
        /// <param name="Display_GetStarted">True To Display The GetStarted window or False to not</param>
        /// <param name="Bf2Hub">Set Last State for "BF2Hub Compatibility""</param>
        /// <param name="Mode1">Set Last State For "Compatibility Mode 1"</param>
        public static void CreateReg(bool Display_GetStarted = true, bool Bf2Hub = false, bool Mode1 = false)
        {
            RegistryKey Software = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey Bf2RegManager = Software.CreateSubKey("Bf2RegManager");
            Bf2RegManager.SetValue("GetStarted", Display_GetStarted.ToString(), RegistryValueKind.String);
            Bf2RegManager.SetValue("BF2Hub", Bf2Hub.ToString(), RegistryValueKind.String);
            Bf2RegManager.SetValue("Mode1", Mode1.ToString(), RegistryValueKind.String);
            Bf2RegManager.Close();
        }

        private static void Read(out bool parse, out bool getStarted, out bool Bf2Hub, out bool Mode1)
        {
            getStarted = true;   // Default
            Bf2Hub = Mode1 = false; // Default
            parse = false;
            RegistryKey Bf2RegManager;
            try
            {
                RegistryKey Software = Registry.CurrentUser.OpenSubKey("Software");
                Bf2RegManager = Software.OpenSubKey("Bf2RegManager");
                parse = bool.TryParse(Bf2RegManager.GetValue("GetStarted").ToString(), out getStarted);
                bool.TryParse(Bf2RegManager.GetValue("BF2Hub").ToString(), out Bf2Hub);
                bool.TryParse(Bf2RegManager.GetValue("Mode1").ToString(), out Mode1);
                Bf2RegManager.Close();
            }
            catch (NullReferenceException)
            {
                CreateReg();
                parse = false;
            }
        }

        /// <summary>
        /// Gets the data from Registry 
        /// </summary>
        /// <param name="getStarted">Gets the boolean value to display or not the GetStarted window</param>
        /// <param name="Bf2Hub">Gets the boolean value of the last state of "BF2Hub Compatibility"</param>
        /// <param name="Mode1">Gets the boolean value of the last state of "Compatibility Mode 1"</param>
        public static void GetReg(out bool getStarted, out bool Bf2Hub, out bool Mode1)
        {
            Read(parse: out bool parse, getStarted: out getStarted, Bf2Hub: out Bf2Hub, Mode1: out Mode1);
            if (!parse)
            {
                Read(parse: out parse, getStarted: out getStarted, Bf2Hub: out Bf2Hub, Mode1: out Mode1);
            }
        }
    }
}
