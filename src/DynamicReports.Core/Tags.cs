// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           Tags.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.Text.RegularExpressions;

namespace DynamicReports.Core
{
    public static class Tags
    {
        public static Regex FullTag => new Regex(@"#\{.+?}");
        public static Regex NameTag => new Regex(@"\w+(\[\d+\]){2}|\w+\[\d+\]|\w+");
    }
}