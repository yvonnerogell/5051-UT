using System;
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

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var myReportViewModel = new ReportViewModel();

            // Act
            // Set number of users to 5
            myReportViewModel.NumberOfUsers = 5;

            // Assert
            // Should be 5
            Assert.AreEqual(5, myReportViewModel.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myReportViewModel = new ReportViewModel();

            // Act
            var myLogViewModel = myReportViewModel.LogViewModel;

            // Assert
            // Should NOT be null
            Assert.IsNotNull(myLogViewModel);

        }

    }
}
