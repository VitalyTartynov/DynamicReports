// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Plugin.MsWord
// Filename:           MsWordPlugin.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using DynamicReports.Core;

namespace DynamicReports.Plugin.MsWord
{
    public class MsWordPlugin : IPlugin
    {
        public string Extension => Constants.MsWordExtension;
        public string Name => Constants.MsWordPluginName;
        public string Note => "Plugin for working with Microsoft Word templates throught OpenXML API";

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