using System;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;

namespace BtUnpair
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Error.WriteLine("A device address is required as the first argument!");
                Environment.Exit(1);
            }
            
            try
            {
                BluetoothSecurity.RemoveDevice(BluetoothAddress.Parse(args[0]));
            }
            catch (Exception x)
            {
                Console.Error.WriteLine(x.ToString());
                Environment.Exit(1);
            }
        }
    }
}
