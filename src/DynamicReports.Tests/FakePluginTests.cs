// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakePluginTests.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;
using System.Collections.Generic;
using DynamicReports.Core;
using DynamicReports.Plugin.FakePlugin;
using NUnit.Framework;

namespace DynamicReports.Tests
{
    [TestFixture]
    public class FakePluginTests
    {
        [Test]
        public void TryGenerateWithFakePlugin()
        {
            var reportManager = new ReportManager();
            var configuration = new ReportConfiguration("FakeTemplate" + FakePluginConstants.TemplateExtension);
            var emptyData = new List<object>();

            Assert.Throws<NotImplementedException>(() => reportManager.Generate(configuration, emptyData));
        }
    }
}