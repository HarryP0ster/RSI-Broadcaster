using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agorartc;

namespace DesctopAudioRecorder
{
    internal static class Program
    {
        enum ARGS 
        {
            TOKEN,
            CHANNEL_ID,
            PID
        }
        //appIn [token] [channelId] [pid]
        static internal int parentID;
        static internal string token;
        static internal string chname;
        static System.Diagnostics.Process proc;
        static void Main(string[] args)
        {
            parentID = System.Convert.ToInt32(args[(int)ARGS.PID]);
            token = args[(int)ARGS.TOKEN];
            chname = args[(int)ARGS.CHANNEL_ID];

            //Console.WriteLine(token);
            //Console.WriteLine(chname);
            //Console.WriteLine(parentID);

            XAgoraObject.JoinChannel(token, chname);
            proc = System.Diagnostics.Process.GetProcessById(parentID);

            proc.WaitForExit();

            XAgoraObject.StopScreenCapture();
            
        }
    }
}