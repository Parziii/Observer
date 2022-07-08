using System;
using System.Collections.Generic;
using System.Linq;

namespace observer.CloudModule
{
    public class CloudService
    {
        public Dictionary<Int32, int> FormatPacket(Dictionary<Int32, int> packet)
        {
            Dictionary<Int32, int> formattedPacket = new Dictionary<Int32, int>();

            Console.WriteLine("-------- packet received --------");

            int i = 0;
            foreach (KeyValuePair<Int32, int> entry in packet)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);

                // handle if i = 1
                if (i == 0)
                {
                    formattedPacket.Add(entry.Key, entry.Value);
                }

                // handle if i != 0 && i < packet.Count - 1
                if (i != 0 && i <= packet.Count && packet.ElementAt(i - 1).Value != entry.Value)
                {
                    formattedPacket.Add(entry.Key, entry.Value);
                }

                i++;
            }

            Console.WriteLine("-------- packet formatted --------");
            foreach (KeyValuePair<Int32, int> entry in formattedPacket)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }

            return formattedPacket;
        }
    }
}