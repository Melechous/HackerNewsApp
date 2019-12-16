using BusinessLogic.Services;
using DataProviders.Data_Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nextech.Controllers;
using System;
using System.Collections.Generic;
using UnitTests.Mock_Classes;
using Xunit.Sdk;

namespace UnitTests
{
    [TestClass]
    public class HackerNewsController_Test
    {
        [TestMethod]
        public void Index_ErrorReturns500()
        {
            var mockService = new Mock_HackerNewsService(true);
            var target = new HackerNewsController(new Mock_Configuration(), mockService);

            ObjectResult result = (ObjectResult)target.Index();

            Assert.AreEqual(500, result.StatusCode);
        }
    }
}
