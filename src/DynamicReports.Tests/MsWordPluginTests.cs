// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           MsWordPluginTests.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;
using System.Linq;
using DynamicReports.Core;
using FluentAssert;
using NUnit.Framework;

namespace DynamicReports.Tests
{
    [TestFixture]
    public class MsWordPluginTests
    {
        [Test]
        public void TryGenerateMsWordReport()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("TestTemplate.dotx", Helpers.PathToTestTemplates);

            reportManager.Plugins.FirstOrDefault(x => x.Name == Constants.MsWordPluginName).ShouldNotBeNull();

            Assert.Throws<NotImplementedException>(() => reportManager.Generate(configuration));
        }
    }
}