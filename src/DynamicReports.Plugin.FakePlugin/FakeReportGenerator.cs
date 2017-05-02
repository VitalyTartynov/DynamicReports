// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakeReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;
using DynamicReports.Core;

namespace DynamicReports.Plugin.FakePlugin
{
    public class FakeReportGenerator : IReportGenerator
    {
        private ReportConfiguration _configuration;

        public void Initialize(ReportConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            _configuration = configuration;
        }

        public void PrepareTemplate()
        {
            throw new System.NotImplementedException();
        }

        public void InsertData()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}