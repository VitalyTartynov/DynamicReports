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
        private IEnumerable<object> _data;
        private Dictionary<string, object> _dictionaryData;

        public void Initialize(ReportConfiguration configuration, IEnumerable<object> data)
        {
            _configuration = configuration;
            _data = data;
        }

        public void Initialize(ReportConfiguration configuration, Dictionary<string, object> data)
        {
            _configuration = configuration;
            _dictionaryData = data;
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