// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// Генератор отчётов
// </summary>
// \***************************************************************************/

using JetBrains.Annotations;

namespace DynamicReports.Core
{
    public interface IReportGenerator
    {
        void Initialize([NotNull]ReportConfiguration configuration);
        void PrepareTemplate();
        void InsertData();
        void Save();
    }
}