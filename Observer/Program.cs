using observer.CloudModule;
using observer.DeviceModule;

namespace observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CloudService cloudService = new CloudService();
            Device device = new Device();

            DeviceService deviceService = new DeviceService(cloudService);

            deviceService.Init(device);
        }
    }
}