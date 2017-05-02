// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakePlugin.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Tests
{
    public class FakePlugin : IPlugin
    {
        public string Extension => FakePluginConstants.Extension;
        public string Name => FakePluginConstants.Name;
        public string Note => "Fake note";

        public void OnLoading()
        {
        }

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