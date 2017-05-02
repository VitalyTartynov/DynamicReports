// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakeGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Plugin.FakePlugin
{
    public class FakeGenerator : IPluginGenerator
    {
        public void Generate(ReportConfiguration configuration)
        {
            throw new System.NotImplementedException();
        }

        public void Save(string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}