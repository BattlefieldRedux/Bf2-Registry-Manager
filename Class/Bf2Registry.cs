using System;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bf2_Registry_Manager
{
    /// <summary>
    /// This class has the functions to manage the registry of the game
    /// </summary>
    static class Bf2Registry
    {
        /// <summary>
        /// This functions creates a Log File which contains the state of procediments and errors
        /// </summary>
        /// <param name="text">The Message that will be written</param>
        /// <param name="Info">The Title of the massege</param>
        public static void LogFile(string text, string Info = "None:")
        {
            if (!File.Exists("Log.txt"))
                File.Create("Log.txt").Close();
            File.AppendAllText("Log.txt", $"\n\n{Info}\n    " + text);
        }

        /// <summary>
        /// Creates a new Game Registry
        /// </summary>
        /// <param name="GameDir">The Game directory path that needs to be informed</param>
        /// <param name="GameExe">The Game directory with the path of executable file </param>
        /// <param name="OS_isX64">The type of OS, True to x64 and False to x86 system</param>
        public static void NewGame(string GameDir, string GameExe, bool OS_isX64)
        {
            string execption = null;
            RegistryKey EA, EA_CORE, EA_Games;

            try
            {
                if (OS_isX64)
                    EA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts"); // X64
                else
                    EA = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Electronic Arts");   // X86

                LogFile("Trying To Create Registry", "Create Reg:");
                EA_CORE = EA.CreateSubKey("EA CORE");
                EA_Games = EA.CreateSubKey("EA Games");

                #region EA CORE

                RegistryKey BF2_2006 = EA_CORE.CreateSubKey("INSTALLED GAMES").CreateSubKey("EAGAMES").CreateSubKey("BF2-2006");
                #region BF2-2006
                RegistryKey BF2_EPE1 = BF2_2006.CreateSubKey("ONLINE_CONTENT").CreateSubKey("BF2-EP1");
                BF2_EPE1.SetValue("DisplayName", "Battlefield 2 Special Forces", RegistryValueKind.String);
                BF2_EPE1.SetValue("GameLauncherParameters", "+menu 1 +fullscreen 1 +modPath mods/xpack +ignoreAsserts 1", RegistryValueKind.String);
                BF2_EPE1.SetValue("GameLauncherPath", GameDir + "\\" + GameExe, RegistryValueKind.String);
                BF2_EPE1.SetValue("Version", "1.50", RegistryValueKind.String);

                RegistryKey Online_Map_Content = BF2_2006.CreateSubKey("ONLINE_MAP_CONTENT");
                #region Online_map_content
                RegistryKey BF2AF = Online_Map_Content.CreateSubKey("BF2AF");
                BF2AF.SetValue("DisplayName", "Battlefield 2: Armored Fury Booster Pack", RegistryValueKind.String);
                BF2AF.SetValue("GameLauncherParameters", "+menu 1 +fullscreen 1", RegistryValueKind.String);
                BF2AF.SetValue("GameLauncherPath", GameDir + "\\" + GameExe, RegistryValueKind.String);
                BF2AF.SetValue("Version", "1.50", RegistryValueKind.String);

                RegistryKey BF2EF = Online_Map_Content.CreateSubKey("BF2EF");
                BF2EF.SetValue("DisplayName", "Battlefield 2: Euro Force Booster Pack", RegistryValueKind.String);
                BF2EF.SetValue("GameLauncherParameters", "+menu 1 +fullscreen 1", RegistryValueKind.String);
                BF2EF.SetValue("GameLauncherPath", GameDir + "\\" + GameExe, RegistryValueKind.String);
                BF2EF.SetValue("Version", "1.50", RegistryValueKind.String);

                #endregion

                #endregion

                #endregion

                #region EA_Games
                RegistryKey Battlefiled2 = EA_Games.CreateSubKey("Battlefield 2");
                Battlefiled2.SetValue("InstallDir", GameDir, RegistryValueKind.String); // Moficar o Game Path
                Battlefiled2.SetValue("Language", "English", RegistryValueKind.String);
                Battlefiled2.SetValue("Locale", "en_US", RegistryValueKind.String);
                Battlefiled2.SetValue("MemberName", "user", RegistryValueKind.String);
                Battlefiled2.SetValue("Version", "1.50", RegistryValueKind.String);

                RegistryKey ergc = Battlefiled2.CreateSubKey("ergc");
                ergc.SetValue("", "WAIT_FOR_KEY", RegistryValueKind.String);

                RegistryKey wdc = Battlefiled2.CreateSubKey("wdc");
                wdc.SetValue("", "true", RegistryValueKind.String);

                RegistryKey Battlefiled2_SF = EA_Games.CreateSubKey("Battlefield 2 Special Forces");
                Battlefiled2_SF.SetValue("InstallDir", GameDir, RegistryValueKind.String); // Modificar o Game Path
                Battlefiled2_SF.SetValue("Language", "English", RegistryValueKind.String);
                Battlefiled2_SF.SetValue("Locale", "en_US", RegistryValueKind.String);
                Battlefiled2_SF.SetValue("Version", "1.50", RegistryValueKind.String);

                RegistryKey ergc_SF = Battlefiled2_SF.CreateSubKey("ergc");
                ergc_SF.SetValue("", "WAIT_FOR_KEY", RegistryValueKind.String);

                RegistryKey wdc_Sf = Battlefiled2_SF.CreateSubKey("wdc");
                wdc_Sf.SetValue("", "true", RegistryValueKind.String);
                #endregion
            }
            catch (Exception e)
            {
                execption = e.Message;
                MessageBox.Show("Create Registry Error: Error description in log file...", "Create Registry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogFile(e.Message, "Create Registry Error:");
            }
            if (execption == null)
            {
                LogFile("Done", "Create Reg:");
                MessageBox.Show("The Battlefield Registry was successfully created!", "All Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Gets The game Key in the registry
        /// </summary>
        /// <param name="BF2_key">Battlefield 2 Key</param>
        /// <param name="BF2SF_key">Battlefield 2 Special Forces Key</param>
        /// <param name="OS_isX64">The type of OS, True to x64 and False to x86 system</param>
        public static void GetKey(out string BF2_key, out string BF2SF_key, bool OS_isX64)
        {
            BF2_key = BF2SF_key = "";
            try
            {
                RegistryKey Ea_Games;
                if (OS_isX64)
                    Ea_Games = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EA Games", true); // X64
                else
                    Ea_Games = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Electronic Arts\EA Games", true);   // X86

                LogFile("Trying To Get CD-Key...", "Get CD-Key");
                RegistryKey BF2ergc = Ea_Games.OpenSubKey(@"Battlefield 2\ergc", true);
                RegistryKey SFergc = Ea_Games.OpenSubKey(@"Battlefield 2 Special Forces\ergc", true);
                BF2_key = BF2ergc.GetValue("").ToString();
                BF2SF_key = SFergc.GetValue("").ToString();

                BF2_key = BF2_key.Substring(5);
                BF2SF_key = BF2SF_key.Substring(5);
                LogFile("Done", "Get CD-KEY");
            }
            catch (Exception e)
            { LogFile(e.Message, "Get the Key:"); }
        }

        /// <summary>
        /// Sets The Game Key in the registry
        /// </summary>
        /// <param name="Bf2">The Battlefield 2 key to be setted</param>
        /// <param name="Bf2_Sf">The Battlefield 2 Special Forces key to be setted</param>
        /// <param name="Error">if any error occurs this boolean become "true" for error and "false" for not</param>
        /// <param name="OS_isX64">The type of OS, True to x64 and False to x86 system</param>
        public static void SetKey(string Bf2, string Bf2_Sf, out bool Error, bool OS_isX64)
        {
            Error = false;
            const string Prefix = "x9392";
            RegistryKey EA_Games;

            try
            {
                LogFile("Trying Set CD-KEY....", "Set CD-KEy:");
                //EA_CORE = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EA CORE", true);
                if (OS_isX64)
                    EA_Games = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts\EA Games", true);    // X64
                else
                    EA_Games = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Electronic Arts\EA Games", true);    // X86

                RegistryKey BF2_ergc = EA_Games.OpenSubKey(@"Battlefield 2\ergc", true);
                RegistryKey BF2SF_ergc = EA_Games.OpenSubKey(@"Battlefield 2 Special Forces\ergc", true);

                BF2_ergc.SetValue("", Prefix + Bf2);
                BF2SF_ergc.SetValue("", Prefix + Bf2_Sf);
                LogFile("Done", "Set CD-KEy:");
                //CreateReg.Program();
            }
            catch (Exception e)
            {
                Error = true;
                if (e is NullReferenceException)
                {
                    MessageBox.Show("CD-KEY Error: Game registry probably does not exist.\nTry Install New BF2 Registry ",
                        "Unable to change CD-KEY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogFile(e.Message, "CD-KEY Error:");
                }
                else
                {
                    MessageBox.Show("CD-KEY Error: Error description in log file...", "Unable to change CD-KEY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogFile(e.Message, "CD-KEY Error:");
                }
            }
         
        }

        /// <summary>
        /// Deletes The Current registry if have one
        /// </summary>
        /// <param name="OS_isX64">The type of OS, True to x64 and False to x86 system</param>
        public static void DeleteRegistry(bool OS_isX64)
        {
            try
            {
                LogFile("Trying Delete Registry", "Delete Registry:");
                if (OS_isX64)
                {
                    RegistryKey EA = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Electronic Arts", true);
                    RegistryKey EA_Games = EA.OpenSubKey("EA Games", true);
                    EA_Games.DeleteSubKeyTree("Battlefield 2", false);
                    EA_Games.DeleteSubKeyTree("Battlefield 2 Special Forces", false);

                    RegistryKey EAGAMES = EA.OpenSubKey(@"EA CORE\INSTALLED GAMES\EAGAMES", true);
                    EAGAMES.DeleteSubKeyTree("BF2-2006", false);

                    // Wrong Registry Generate by "\Support\EReg.exe"
                    RegistryKey HKEY_CLASSES_ROOT = Registry.ClassesRoot.OpenSubKey(@"VirtualStore\MACHINE\SOFTWARE\WOW6432Node", true);
                    HKEY_CLASSES_ROOT.DeleteSubKeyTree("Electronic Arts", false);

                    // Deletes the x86 Game registry installed in x64 system ( because the game's x86 reg doesn't work on the 
                    // x64 system )
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    using (var key = hklm.OpenSubKey(@"SOFTWARE", true))
                    {
                        key.DeleteSubKeyTree(@"Electronic Arts\EA CORE\INSTALLED GAMES\EAGAMES\BF2-2006", false);
                        key.DeleteSubKeyTree(@"Electronic Arts\EA Games\Battlefield 2", false);
                        key.DeleteSubKeyTree(@"Electronic Arts\EA Games\Battlefield 2 Special Forces", false);
                    };
                }

                if (!OS_isX64) // Deletes the x86 game registry if installed on an x86 system and wrong registry
                {
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                    using (var key = hklm.OpenSubKey(@"SOFTWARE", true))
                    {
                        key.DeleteSubKeyTree(@"Electronic Arts\EA CORE\INSTALLED GAMES\EAGAMES\BF2-2006", false);
                        key.DeleteSubKeyTree(@"Electronic Arts\EA Games\Battlefield 2", false);
                        key.DeleteSubKeyTree(@"Electronic Arts\EA Games\Battlefield 2 Special Forces", false);
                    };
                    // Wrong Registry Generate by "\Support\EReg.exe"
                    using (var hkcr = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32))
                    using (var skey = hkcr.OpenSubKey(@"VirtualStore\MACHINE\SOFTWARE\WOW6432Node", true))
                    {
                        skey.DeleteSubKeyTree("Electronic Arts", false);
                    };
                }
                LogFile("Done", "Delete Registry");
            }
            catch (Exception e)
            {
                LogFile(e.Message, "Delete Registry:");
            }
        }
    }
}
