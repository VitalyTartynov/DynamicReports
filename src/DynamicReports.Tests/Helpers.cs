// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Tests
// Filename:           Helpers.cs
// Created:            28.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DynamicReports.Tests
{
    public static class Helpers
    {
        public static string PathToTestTemplates => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestTemplates");
    }
}