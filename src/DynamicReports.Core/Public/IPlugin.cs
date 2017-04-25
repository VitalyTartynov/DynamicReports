// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IPlugin.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public interface IPlugin
    {
        string Extension { get; }
        string Name { get; }

        void OnLoading();

        


        void Save(string filename);
    }
}