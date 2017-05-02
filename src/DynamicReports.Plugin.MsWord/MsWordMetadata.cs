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
    public class MsWordMetadata : IMetadata
    {
        public string TemplateExtension => MsWordPluginConstants.TemplateExtension;
        public string TargetExtension => MsWordPluginConstants.TargetExtension;
        public string Name => MsWordPluginConstants.PluginName;
        public string Note => "Plugin for working with Microsoft Word templates throught OpenXML API";

        public IReportGenerator Instance { get; } = new MsWordReportGenerator();
    }
}