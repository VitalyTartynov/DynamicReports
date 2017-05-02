// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IReportManager.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.Collections.Generic;
using JetBrains.Annotations;

namespace DynamicReports.Core
{
    public interface IReportManager
    {
        void Generate([NotNull]ReportConfiguration configuration, [NotNull]Dictionary<string,object> data);
    }
}