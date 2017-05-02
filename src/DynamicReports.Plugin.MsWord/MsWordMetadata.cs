// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Plugin.MsWord
// Filename:           MsWordMetadata.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Plugin.MsWord
{
    public class MsWordMetadata : IPluginMetadata
    {
        public string TemplateExtension => MsWordPluginConstants.TemplateExtension;
        public string OutputExtension => MsWordPluginConstants.OutputExtension;
        public string Name => MsWordPluginConstants.PluginName;
        public string Note => "Plugin for working with Microsoft Word templates throught OpenXML API";

        public IPluginGenerator Instance => new MsWordGenerator();
    }
}