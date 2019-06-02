﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {

            // Arrange

            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myReportViewModel = new ReportViewModel();

            // Act
            int numUsersTest = myReportViewModel.NumberOfUsers;

            // Assert
            // Should be zero users when it is first started
            Assert.AreEqual(0, numUsersTest);
        }

    }
}
