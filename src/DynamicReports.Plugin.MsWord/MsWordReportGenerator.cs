// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Plugin.MsWord
// Filename:           MsWordReportGenerator.cs
// Created:            02.05.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DynamicReports.Core;

namespace DynamicReports.Plugin.MsWord
{
    public class MsWordReportGenerator : IReportGenerator
    {
        private ReportConfiguration _configuration;
        private IEnumerable<object> _data;
        private Dictionary<string, object> _dictionaryData;

        private void Initialize(ReportConfiguration configuration)
        {
            _configuration = configuration;
            _configuration.TargetFilename = _configuration.TargetFilename.Replace(MsWordPluginConstants.TemplateExtension,
                MsWordPluginConstants.TargetExtension);
        }

        public void Initialize(ReportConfiguration configuration, IEnumerable<object> data)
        {
            Initialize(configuration);

            if (data == null || !data.Any())
                throw new ReportGenerationException("Нет данных для заполнения шаблона отчёта");
            _data = data;
        }

        public void Initialize(ReportConfiguration configuration, Dictionary<string, object> data)
        {
            Initialize(configuration);

            if (data == null || !data.Any())
                throw new ReportGenerationException("Нет данных для заполнения шаблона отчёта");
            _dictionaryData = data;
        }

        public void PrepareTemplate()
        {
            File.Copy(_configuration.FullTemplatePath, _configuration.FullTargetPath, overwrite: true);
            var document = WordprocessingDocument.Open(_configuration.FullTargetPath, isEditable:true);
            document.ChangeDocumentType(WordprocessingDocumentType.Document);
            document.Close();
        }

        public void InsertData()
        {
            var document = WordprocessingDocument.Open(_configuration.FullTargetPath, isEditable: true);
            var tables = document.MainDocumentPart.Document.Body.Elements<Table>();

            foreach (var table in tables)
            {
                var rows = table.Elements<TableRow>();
                for (int row = 0; row < rows.Count(); row++)
                {
                    var currentRow = rows.ElementAt(row);
                    var cells = currentRow.Elements<TableCell>();
                    for (int column = 0; column < cells.Count(); column++)
                    {
                        var currentCell = cells.ElementAt(column);
                        var text = currentCell.InnerText;

                        foreach (Match match in Tags.FullTag.Matches(text))
                        {
                            var fullTag = match.Value;
                            var nameTag = Tags.NameTag.Match(fullTag).Value;

                            var data = _dictionaryData[nameTag];
                            var newValue = data.ToString();

                            foreach (var paragraph in currentCell.Elements<Paragraph>())
                            {
                                RunProperties runProperties = null;
                                Run run;
                                while ((run = paragraph.GetFirstChild<Run>()) != null)
                                {
                                    if (runProperties == null)
                                    {
                                        runProperties = run.GetFirstChild<RunProperties>();
                                    }

                                    run.Remove();
                                }
                                
                                run = new Run(new Text(newValue));
                                if (runProperties != null)
                                {
                                    run.RunProperties = (RunProperties)runProperties.CloneNode(true);
                                }

                                paragraph.Append(run);
                            }
                        }
                    }
                }
            }

            document.Save();
            document.Close();
        }

        public void Save()
        {
        }
    }
}