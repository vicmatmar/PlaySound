using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;
using System.Threading;

namespace PlaySound
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 2500;
            timer.Enabled = true;

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;


        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SystemSounds.Hand.Play();
            Thread.Sleep(750);
            SystemSounds.Asterisk.Play();
        }
    }
}
