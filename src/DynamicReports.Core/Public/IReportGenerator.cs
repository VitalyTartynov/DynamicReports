// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// Генератор отчётов
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public interface IReportGenerator
    {
        bool Initialize(ReportConfiguration configuration);
        bool PrepareTemplate();
        bool InsertData();
        bool Save();
    }
}