// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           ReportManagerTests.cs
// Created:            25.04.2017
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
    public class ReportManagerTests
    {
        [Test]
        public void TryLoadingPlugins()
        {
            var reportManager = new ReportManager(); // init, load plugins
            
            reportManager.Plugins.Count.ShouldBeGreaterThan(0);
        }

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