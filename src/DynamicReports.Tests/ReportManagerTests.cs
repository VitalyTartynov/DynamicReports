// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           ReportManagerTests.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

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
            var reportManager = new BaseReportManager(); // init, load plugins
            
            reportManager.PluginMetadatas.Any().ShouldBeTrue();
        }

        [Test]
        public void UnknownReportType()
        {
            var reportManager = new BaseReportManager();
            var configuration = new ReportConfiguration("UnknownTemplate.unknown");

            Assert.Throws<PluginNotFoundException>(() => reportManager.Generate(configuration));
        }
    }
}