// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IPluginGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public interface IPluginGenerator
    {
        void Generate(ReportConfiguration configuration);

        void Save(string filename);
    }
}