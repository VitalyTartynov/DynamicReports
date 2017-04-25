﻿// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           ReportManagerTests.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using NUnit.Framework;

namespace DynamicReports.Core.Tests
{
    [TestFixture]
    public class ReportManagerTests
    {
        [Test]
        public void TryGenerateWithoutPlugins()
        {
            var configuration = new ReportConfiguration("TestTemplate.dotx");
            var reportManager = new ReportManager(); // init, load plugins

            Assert.Throws<ReportGenerationException>(() => reportManager.Generate(configuration));
        }
    }
}