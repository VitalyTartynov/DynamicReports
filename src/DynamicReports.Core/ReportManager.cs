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

        internal ICollection<IPlugin> Plugins { get; }

        public ReportManager(string pathToPlugins = null)
        {
            if (pathToPlugins == null)
            {
                pathToPlugins = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }

            Plugins = LoadPlugins(pathToPlugins);
        }

        private ICollection<IPlugin> LoadPlugins(string pathToPlugins)
        {
            var result = new List<IPlugin>();
            foreach (var pluginFilename in Directory.GetFiles(pathToPlugins, PluginMask))
            {
                try
                {
                    var assembly = Assembly.LoadFrom(new FileInfo(pluginFilename).FullName);
                    var pluginType = assembly
                        .GetTypes()
                        .FirstOrDefault(type => type.IsClass && typeof(IPlugin).IsAssignableFrom(type));
                    if (pluginType == null) continue;
                    
                    var plugin = Activator.CreateInstance(pluginType) as IPlugin;
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
            var plugin = Plugins.FirstOrDefault(x => x.Extension == configuration.TemplateExtension);
            if (plugin == null)
            {
                throw new ReportGenerationException($"Plugin for file type '{configuration.TemplateExtension}' not found");
            }
        }
    }
}