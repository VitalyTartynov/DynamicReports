// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           PluginNotFoundException.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public class PluginNotFoundException : ReportGenerationException
    {
        public PluginNotFoundException(string message)
            : base(message)
        {
        }
    }
}