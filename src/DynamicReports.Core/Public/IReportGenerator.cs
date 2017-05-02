// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// Генератор отчётов
// </summary>
// \***************************************************************************/

using System.Collections.Generic;
using JetBrains.Annotations;

namespace DynamicReports.Core
{
    public interface IReportGenerator
    {
        void Initialize([NotNull]ReportConfiguration configuration, Dictionary<string, object> data);
        void PrepareTemplate();
        void InsertData();
        void Save();
    }
}