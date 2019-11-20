using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Screen_Status
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            Console.ReadLine();
        }
        static void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                //I left my desk
                Console.WriteLine("I left my desk");
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                //I returned to my desk
                Console.WriteLine("I returned to my desk");
            }
        }
    }
}
