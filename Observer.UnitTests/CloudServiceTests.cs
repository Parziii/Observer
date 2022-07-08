using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using


namespace Observer.UnitTests
{
    [TestClass]
    public class CloudServiceTests
    {
        [TestMethod]
        public void FormatPacketCorrectly()
        {
            CloudService cloudService = new CloudService();

            Dictionary<Int32, int> expected = new Dictionary<Int32, int>()
        {
            {1212, 1},
            {1213, 1},
            {1214, 0},
            {1215, 1}
        };

            Dictionary<Int32, int> shouldBeEqual = new Dictionary<Int32, int>()
        {
            {1212, 1},
            {1214, 0},
            {1215, 1}
        };

            Assert.AreEqual(shouldBeEqual, cloudService.FormatPacket(expected));
        }
    }
}