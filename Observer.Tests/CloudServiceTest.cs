using Microsoft.VisualStudio.TestTools.UnitTesting;
using observer.CloudModule;
using System;
using System.Collections.Generic;

namespace Observer.Tests
{
    [TestClass]
    public class CloudServiceTest
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

            CollectionAssert.AreEqual(shouldBeEqual, cloudService.FormatPacket(expected));
        }

        [TestMethod]
        public void FormatPacketImproperly()
        {
            CloudService cloudService = new CloudService();

            Dictionary<Int32, int> receivedPacket = new Dictionary<Int32, int>()
        {
            {1212, 1},
            {1213, 1},
            {1214, 0},
            {1215, 1}
        };

            Dictionary<Int32, int> badFormatted = new Dictionary<Int32, int>()
        {
            {1212, 1},
            {1214, 0},
            {1215, 1},
            {1216, 1},
            {1217, 1}
        };

            CollectionAssert.AreNotEqual(badFormatted, cloudService.FormatPacket(receivedPacket));
        }
    }
}