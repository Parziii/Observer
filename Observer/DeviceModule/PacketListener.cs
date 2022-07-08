using System;
using System.Collections.Generic;

namespace observer.DeviceModule
{
    internal class PacketListener : Observer
    {
        private Device _device;

        private Dictionary<Int32, int> observerState = new Dictionary<Int32, int>();

        public PacketListener(Device device)
        {
            _device = device;
        }

        public Dictionary<Int32, int> GetPacket()
        {
            return observerState;
        }

        public void ClearState()
        {
            observerState.Clear();
        }

        public override void Update()
        {
            Int32 unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            observerState.Add(unixTimestamp, _device.DeviceState);
        }
    }
}