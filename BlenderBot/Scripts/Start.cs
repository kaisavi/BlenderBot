using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

namespace BlenderBot.Scripts
{
    public class Start
    {
        public static int Render(object args)
        {
            var _Render = Process.Start("CMD.exe", args.ToString());
            _Render.WaitForExit();
            Console.WriteLine($"Finished on {_Render.ExitTime.Date.ToLongDateString()} at {_Render.ExitTime.ToLongTimeString()}");

            return _Render.ExitCode;
        }

        public static int Animation(object args)
        {
            var _Animation = Process.Start("CMD.exe", args.ToString());
            _Animation.WaitForExit();
            Console.Write($"Finished on {_Animation.ExitTime.Date.ToLongDateString()} at {_Animation.ExitTime.ToLongTimeString()}");

            return _Animation.ExitCode;
        }
    }
}
