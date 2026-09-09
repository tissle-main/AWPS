using System.Threading;
using System.Diagnostics;

namespace AWPS.IoT
{
    public static class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");
            Thread.Sleep(Timeout.Infinite);
        }
    }
}