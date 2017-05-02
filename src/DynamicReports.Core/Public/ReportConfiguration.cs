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
        private string _pathToTemplates = Directory.GetCurrentDirectory();
        private string _pathToTarget = Directory.GetCurrentDirectory();

        /// <summary>
        /// Имя обрабатываемого шаблона отчёта (с расширением)
        /// </summary>
        public string TemplateFilename { get; }

        /// <summary>
        /// Расширение обрабатываемого шаблона отчёта
        /// </summary>
        internal string TemplateExtension => Path.GetExtension(TemplateFilename);

        /// <summary>
        /// Полный путь к шаблону отчёта с названием файла и расширением
        /// </summary>
        public string FullTemplatePath => Path.Combine(_pathToTemplates, TemplateFilename);

        /// <summary>
        /// Полный путь к результирующему файлу отчёта с названием файла и расширением
        /// </summary>
        public string FullTargetPath => Path.Combine(_pathToTarget, TargetFilename);

        /// <summary>
        /// Имя результирующего файла отчёта (с расширением?)
        /// </summary>
        public string TargetFilename { get; set; }

        public ReportConfiguration(string templateFilename)
        {
            TemplateFilename = templateFilename;
            TargetFilename = templateFilename;
        }

        public ReportConfiguration(string templateFilename, string pathToTemplates = null)
            : this(templateFilename)
        {
            if (pathToTemplates != null)
            {
                _pathToTemplates = pathToTemplates;
            }
        }

        public ReportConfiguration(string templateFilename, string pathToTemplates = null, string pathToTarget = null)
            : this(templateFilename, pathToTemplates)
        {
            if (pathToTarget != null)
            {
                _pathToTarget = pathToTarget;
            }
        }
    }
}