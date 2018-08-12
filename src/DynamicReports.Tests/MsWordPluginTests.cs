// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           MsWordPluginTests.cs
// Created:            02.05.2017
// 
// <summary>
// Тесты плагина для отчётов в MS Word
// </summary>
// \***************************************************************************/

using System.Collections.Generic;
using System.IO;
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
        public void TryGenerateReportWithoutData()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("SimpleInsertDataTemplate.dotx", Helpers.PathToTestTemplates);
            var emptyDatas = new List<object>();

            reportManager.PluginMetadatas.Any(x => x.Name == MsWordPluginConstants.PluginName).ShouldBeTrue();

            Assert.Throws<ReportGenerationException>(() => reportManager.Generate(configuration, emptyDatas));
        }

        [Test]
        [Ignore("This test isn't completed")]
        public void InsertRowsFromCollection()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("InsertRowsTemplate.dotx", Helpers.PathToTestTemplates);
            var data = new List<object>
            {
                new TestObject {Column1 = "1 : 1", Column2 = "2 : 1", Column3 = "3 : 1"},
                new TestObject {Column1 = "1 : 2", Column2 = "2 : 2", Column3 = "3 : 2"},
            };

            reportManager.PluginMetadatas.Any(x => x.Name == MsWordPluginConstants.PluginName).ShouldBeTrue();
            reportManager.Generate(configuration, data);

            File.Exists(configuration.FullTargetPath).ShouldBeTrue();

            Assert.Fail();
        }

        [Test]
        [Ignore("Only manual usage")]
        public void InsertDataInTemplate()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("SimpleInsertDataTemplate.dotx", Helpers.PathToTestTemplates);
            var data = new Dictionary<string, object>
            {
                {"Column1_Row1", "1 : 1" },
                {"Column2_Row1", "2 : 1" },
                {"Column3_Row1", "3 : 1" },
                {"Column1_Row2", "1 : 2" },
                {"Column2_Row2", "2 : 2" },
                {"Column3_Row2", "3 : 2" },
            };

            reportManager.PluginMetadatas.Any(x => x.Name == MsWordPluginConstants.PluginName).ShouldBeTrue();
            reportManager.Generate(configuration, data);

            File.Exists(configuration.FullTargetPath).ShouldBeTrue();
        }
    }
}