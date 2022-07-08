using observer.CloudModule;
using System;
using System.Threading.Tasks;

namespace observer.DeviceModule
{
    internal class DeviceService
    {
        private CloudService _cloudService;

        public DeviceService(CloudService cloudService)
        {
            _cloudService = cloudService;
        }

        public void Init(Device device)
        {
            PacketListener packetListener = new PacketListener(device);
            device.Attach(packetListener);

            Random rndGenerator = new Random();

            int counter = 0;
            Task.Run(async () =>
            {
                while (true)
                {
                    counter++;

                    device.DeviceState = rndGenerator.Next(0, 2);
                    device.Notify();

                    if (counter == 8)
                    {
                        _cloudService.FormatPacket(packetListener.GetPacket());
                        counter = 0;
                        packetListener.ClearState();
                    }

                    await Task.Delay(rndGenerator.Next(1000, 1100));
                }
            });

            Console.ReadKey();
        }
    }
}