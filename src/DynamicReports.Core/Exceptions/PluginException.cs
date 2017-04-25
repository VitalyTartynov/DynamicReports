// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           PluginException.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;

namespace DynamicReports.Core
{
    public class PluginException : Exception
    {
        public PluginException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}