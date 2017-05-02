// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IPluginMetadata.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public interface IPluginMetadata
    {
        string TemplateExtension { get; }
        string OutputExtension { get; }
        string Name { get; }
        string Note { get; }

        IPluginGenerator Instance { get; }
    }
}