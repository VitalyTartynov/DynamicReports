// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           IMetadata.cs
// Created:            25.04.2017
// 
// <summary>
// Метаданные плагина
// </summary>
// \***************************************************************************/

namespace DynamicReports.Core
{
    public interface IMetadata
    {
        /// <summary>
        /// Расширение файла шаблона, поддерживаемое данным плагином
        /// </summary>
        string TemplateExtension { get; }

        /// <summary>
        /// Расширение выходного файла отчёта
        /// </summary>
        string TargetExtension { get; }

        /// <summary>
        /// Человекочитаемое название плагина
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Примечание
        /// </summary>
        string Note { get; }

        IReportGenerator Instance { get; }
    }
}