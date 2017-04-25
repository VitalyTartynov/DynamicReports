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

namespace DynamicReports.MsWord
{
    public class MsWordPlugin : IPlugin
    {
        public string Extension => ".dotx";
        public string Name => "Microsoft Word";

        public void OnLoading()
        {
            throw new System.NotImplementedException();
        }

        public void Save(string filename)
        {
            throw new System.NotImplementedException();
        }
    }
}