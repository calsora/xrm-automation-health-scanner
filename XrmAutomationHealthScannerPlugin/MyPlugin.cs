using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using XrmAutomationHealthScannerPlugin;

namespace XrmAutomationHealthScannerPlugin

// TODO: Add logo and submit to plugin store
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Automation Health Scanner"),
        ExportMetadata("Description", "A simple plugin to scan inactive automations found within the workflows table."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64",
        "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAOdEVYdFNvZnR3YXJlAEZpZ21hnrGWYwAAAyxJREFUeAHtV0tIVGEU/v7/3jsvzReK2QMGggxXko9WlYkKGUSFQdBCzYyKaBFCS2cWFQXRY1eLtDZBiD03gYQGYpFF5qKsjVApNkYlY/O4r87/a5MTDo7QdDd+MAP3v/ec853znf/89zLMY7LJX8OATg6U20AeMgTy3W9buFnSO94trpn4CzX5Oy0ggP+LQHHPeJBN7ve3cBtdcACU9A6u2GiGQ5CSkyY1cAhEoJzDWeQ5TQArBBwnoC71gLKpClpFHeKaGzz6E3ziA+JP7yY/VHsA2qp8sG9TdK83scwK18C9bR8M04Q99BDml0/pE2C+HLhOXIJatgW6rsOjqmCMgXMOdfdRRM+3wQrNOfQ1HgIvWovo6CCwgIBStA7WzjYoZGeMvQAWIZBSAs/JK+CUvYAXBuz3w7CmJxAOh2HmFcNz+gbdyJ5zwimAYUBRlCQfJmWuEvG/15ckoFXWgZVWSkN9uA8/2qsQOdeKSEcDPM/uwe12I5ZdAG3rXvm8YVqwbRucJbsT9mI9Ho+nJLCoBGxjBSzLkobm7QtJ9yK3zsqfzDCxakt5zPzVUvNoNAqv1ws9t1BKpmkadMaXQWB9qXSozoRgfJ3AUlAV6g8KYlAf2M2d8FDWLqoSRAIkg5DHpjM4bQL29GcYG8rB3D6kA0FWBDFDZPf2uQyqU/ndJX5wklJUIZbCdnECH8fgEvq6CmBtroXx6skfA7p2VTfAiOvQX/bBHhmgRMk9SaaIbdgdkC8ZIt9YaRXUjuvw+XyYJVIsXQLG4ANg1xG4cgugtAah+ssQGx2CUlYNtf4gDHeWzIo/uib7gE5UeD0ezBrJzSbKLnaB6AlNJYnSrsDsDKw7F4H2M1Cy82A2Hkb2nuOyMWWpxZZ73JUYLKIH5LppJjunoAJCIitFD6ScA+bgfYRP1YO9GZDZiuAigPmOBsrlY4j0XF1IWWaqzQf8Dd3QJTFJIkUcNtXkt5EGWFaOrMy/RtqHUSaCL4tAprBCwHkCtD2+w0GICryGQ6DRNMBpdgXhFCx085Ke8X44QIKyD4ov5MSEFB+pzEYLLWxHhiD6jQKP0OgNzCeOX0ywN+eo+WJCAAAAAElFTkSuQmCC"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64",
        "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}