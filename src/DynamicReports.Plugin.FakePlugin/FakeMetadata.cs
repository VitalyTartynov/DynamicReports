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
    public class FakeMetadata : IPluginMetadata
    {
        public string TemplateExtension => FakePluginConstants.TemplateExtension;
        public string OutputExtension => FakePluginConstants.OutputExtension;
        public string Name => FakePluginConstants.PluginName;
        public string Note => "Fake note";

        public IPluginGenerator Instance => new FakeGenerator();
    }
}