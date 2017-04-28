﻿// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           ReportManagerTests.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;
using System.IO;
using System.Linq;
using System.Reflection;
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
            var pathToTemplates = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestTemplates");
            var configuration = new ReportConfiguration("TestTemplate.dotx", pathToTemplates);

            reportManager.Plugins.FirstOrDefault(x => x.Name == "Microsoft Word").ShouldNotBeNull();
            Assert.Throws<NotImplementedException>(() => reportManager.Generate(configuration));
        }
    }
}