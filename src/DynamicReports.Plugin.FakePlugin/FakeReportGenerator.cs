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
using System.Collections.Generic;
using DynamicReports.Core;

namespace DynamicReports.Plugin.FakePlugin
{
    public class FakeReportGenerator : IReportGenerator
    {
        private ReportConfiguration _configuration;
        private Dictionary<string, object> _data;

        public void Initialize(ReportConfiguration configuration, Dictionary<string, object> data)
        {
            _configuration = configuration;
            _data = data;
        }

        public void PrepareTemplate()
        {
            throw new NotImplementedException();
        }

        public void InsertData()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}