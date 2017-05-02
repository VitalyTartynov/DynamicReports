// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           ReportManagerTests.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.Collections.Generic;
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
            
            reportManager.PluginMetadatas.Any().ShouldBeTrue();
        }

        [Test]
        public void UnknownReportType()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("UnknownTemplate.unknown");
            var emptyData = new Dictionary<string, object>();

            Assert.Throws<PluginNotFoundException>(() => reportManager.Generate(configuration, emptyData));
        }
    }
}