// /****************************** DynamicReports ******************************\
// Project:            DynamicReports.Core
// Filename:           ReportManager.cs
// Created:            25.04.2017
// 
// <summary>
// 
// </summary>
// \***************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DynamicReports.Core
{
    public class ReportManager
    {
        private const string PluginMask = "DynamicReports.Plugin.*.dll";

        internal ICollection<IPluginMetadata> PluginMetadatas { get; }

        public ReportManager(string pathToPlugins = null)
        {
            if (pathToPlugins == null)
            {
                pathToPlugins = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }

            PluginMetadatas = LoadPluginMetadatas(pathToPlugins);
        }

        private ICollection<IPluginMetadata> LoadPluginMetadatas(string pathToPlugins)
        {
            var result = new List<IPluginMetadata>();
            foreach (var pluginFilename in Directory.GetFiles(pathToPlugins, PluginMask))
            {
                try
                {
                    var assembly = Assembly.LoadFrom(new FileInfo(pluginFilename).FullName);
                    var pluginType = assembly
                        .GetTypes()
                        .FirstOrDefault(type => type.IsClass && typeof(IPluginMetadata).IsAssignableFrom(type));
                    if (pluginType == null) continue;
                    
                    var plugin = Activator.CreateInstance(pluginType) as IPluginMetadata;
                    if (plugin == null) continue;
                        
                    result.Add(plugin);
                }
                catch (Exception)
                {
                    // TODO: TartunovVA - это не должна быть ошибка с выходом
                    //throw new PluginException($"An error has occurred when load assembly '{pluginFilename}'", e);
                }
            }

            return result;
        }

        public void Generate(ReportConfiguration configuration)
        {
            var plugin = PluginMetadatas.FirstOrDefault(x => x.TemplateExtension == configuration.TemplateExtension);
            if (plugin == null)
            {
                throw new PluginNotFoundException($"Plugin for file type '{configuration.TemplateExtension}' not found");
            }

            plugin.Instance.Generate(configuration);
        }
    }
}