using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LZWCompresser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int IsRunning = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (Process RunningProcess in Process.GetProcesses())
            {
                if (RunningProcess.ProcessName.Contains("LZWCompresser"))
                    IsRunning += 1;
            }

            if (IsRunning > 1)
            {
                MessageBox.Show("LZWCompresser is already running.","LZW Compresser - Warning",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                Application.Exit();
            }
            else
                Application.Run(new MainForm());
        }
    }
}
