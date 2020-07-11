using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace game
{
    class CMp3
    {
        
        [DllImport("winmm.dll")]
        private static extern long mciSendString
            (
                string lpstrCommand,
                StringBuilder lpstrReturnString,
                int uReturnLength,
                IntPtr hwdCallBack
            );
        public bool Repeat { get; set; }
        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile"  ;
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void play()
        {
            string command = "play MediaFile";
            if (Repeat) command += "Repeat";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
       
    }
}
