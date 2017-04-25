// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           ReportConfiguration.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.IO;

namespace DynamicReports.Core
{
    public class ReportConfiguration
    {
        public string TemplateName { get; }
        public string TemplateExtension => Path.GetExtension(TemplateName);

        public ReportConfiguration(string templateName, string pathToTemplates = null)
        {
            TemplateName = templateName;

            if (pathToTemplates == null)
            {
                pathToTemplates = Directory.GetCurrentDirectory();
            }
        }
    }
}