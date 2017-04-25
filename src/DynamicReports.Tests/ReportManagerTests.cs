// /****************************** DynamicReports ******************************\
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
        public void UsageSample()
        {
            var templateName = "TestTemplate.dotx";
            var reportManager = new ReportManager(); // init, load plugins
            reportManager.Generate(templateName);
        }
    }
}