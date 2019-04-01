using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using findpersonalinfo.Controllers;
using findpersonalinfo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace findpersonalinfo.Tests.Controllers
{
    [TestClass]
    public class FoundInformationControllerTest
    {
        [TestMethod]
        public void IndexActionReturnsHomeIndexView()
        {
            var foundInformationController = new FoundInformationController();
            var result = foundInformationController.Index() as RedirectToRouteResult;
            Assert.AreEqual("Index", result.RouteValues["action"]);
            Assert.AreEqual("Home", result.RouteValues["controller"]);
        }

        [TestMethod]
        public void ReturnCorrectEmailAfterSearch()
        {
            var fakeDb = new FakeApplicationDbContext();
            fakeDb.FoundInformation = new FakeDbSet<FoundInformation>();
            var foundInformation = new FoundInformation { Email = "Test@Email.com", Username = "User1" };
            fakeDb.FoundInformation.Add(foundInformation);

            FoundInformationController foundInformationController = new FoundInformationController(fakeDb);
            var returnedResult = (PartialViewResult)foundInformationController.Details(new
                Search
            { SearchTerm = "User1" });
            //https://stackoverflow.com/questions/55449065/how-can-i-get-the-index-of-a-viewresult
            var foundInfoEmail = returnedResult.Model as List<FoundInformation>;
            Assert.AreEqual("Test@Email.com", foundInfoEmail[0].Email);
        }
    }
}
