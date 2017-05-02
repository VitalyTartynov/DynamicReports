// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakeReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Plugin.FakePlugin
{
    public class FakeReportGenerator : IReportGenerator
    {
        public bool Initialize(ReportConfiguration configuration)
        {
            throw new System.NotImplementedException();
        }

        public bool PrepareTemplate()
        {
            throw new System.NotImplementedException();
        }

        public bool InsertData()
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }
    }
}