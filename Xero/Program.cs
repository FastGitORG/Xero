using System;

using Xero.Util.Model;
using Xero.Util.Parser;
using Xero.Util.Text;
using Xero.Util.Net;
using Xero.Util;

namespace Xero
{
    class Program
    {
        static void Main()
        {
            var key = KeyParser.GetKeyString(FString.KEY_PATH);
            Console.WriteLine("Key: " + key);


            var l = TrafficParser
                .GetTrafficList(
                HttpGet.Get(
                    Url.SERVER_ID_TRAFFIC(7269),
                    FString.HTTPGET_HEADER_KEY,
                    key,
                    10000,
                    FString.USER_AGENT)
                .ToJObject());

            long countIn = 0;
            long countOut = 0;

            foreach (var i in l)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Date: " + i.Date);
                Console.WriteLine("In  : " + i.In);
                Console.WriteLine("Out : " + i.Out);
                Console.WriteLine("EFR : " + 100.0 * i.EFR + "%");
                countIn += i.In;
                countOut += i.Out;
            }
            Console.WriteLine("==============================");
            Console.WriteLine("Total In : " + countIn);
            Console.WriteLine("Total Out: " + countOut);
            Console.WriteLine("Avg. EFR : " + 100.0 * countOut / countIn + "%");
            Console.WriteLine("==============================");
            Console.WriteLine("Finished! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
