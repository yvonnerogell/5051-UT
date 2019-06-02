using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using HW1c.Models;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        [TestMethod]
        public void LogBackend_Default_Instance_Should_Pass()
        {
            // Arrange

            // Act
            var result = LogBackend.Instance;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
