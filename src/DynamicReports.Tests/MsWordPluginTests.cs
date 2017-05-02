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
using DynamicReports.Plugin.MsWord;
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
            var reportManager = new BaseReportManager();
            var configuration = new ReportConfiguration("TestTemplate.dotx", Helpers.PathToTestTemplates);

            reportManager.PluginMetadatas.FirstOrDefault(x => x.Name == MsWordPluginConstants.PluginName).ShouldNotBeNull();

            Assert.Throws<NotImplementedException>(() => reportManager.Generate(configuration));
        }
    }
}