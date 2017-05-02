// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           FakeMetadata.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Plugin.FakePlugin
{
    public class FakeMetadata : IMetadata
    {
        public string TemplateExtension => FakePluginConstants.TemplateExtension;
        public string TargetExtension => FakePluginConstants.OutputExtension;
        public string Name => FakePluginConstants.PluginName;
        public string Note => "Fake note";

        public IReportGenerator Instance { get; } = new FakeReportGenerator();
    }
}