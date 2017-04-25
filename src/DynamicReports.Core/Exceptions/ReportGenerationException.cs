// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           ReportGenerationException.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;

namespace DynamicReports.Core
{
    public class ReportGenerationException : Exception
    {
        public ReportGenerationException(string message) 
            : base(message)
        {
        }
    }
}