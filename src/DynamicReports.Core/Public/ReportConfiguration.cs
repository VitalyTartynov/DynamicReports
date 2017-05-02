// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           ReportConfiguration.cs
// Created:            25.04.2017
// 
// <summary>
// Параметры запуска генерации отчётов
// </summary>
// \***************************************************************************/

using System.IO;

namespace DynamicReports.Core
{
    public class ReportConfiguration
    {
        private string _pathToTemplates;

        /// <summary>
        /// Имя обрабатываемого шаблона отчёта
        /// </summary>
        public string TemplateFilename { get; }

        /// <summary>
        /// Расширение обрабатываемого шаблона отчёта
        /// </summary>
        public string TemplateExtension => Path.GetExtension(TemplateFilename);

        /// <summary>
        /// Имя результирующего файла отчёта
        /// </summary>
        public string TargetFilename { get; set; }

        public ReportConfiguration(string templateFilename, string pathToTemplates = null)
        {
            TemplateFilename = templateFilename;
            _pathToTemplates = pathToTemplates ?? Directory.GetCurrentDirectory();
        }
    }
}