using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;
using IntelliImage.StandardPlugins;

namespace IntelliImage
{
    class PluginServices : IPluginHost  
    {
        public PluginServices()
        {
        }

        private Types.AvailablePlugins colAvailablePlugins = new Types.AvailablePlugins();

        /// A Collection of all Plugins Found and Loaded by the FindPlugins() Method
        public Types.AvailablePlugins AvailablePlugins
        {
            get { return colAvailablePlugins; }
            set { colAvailablePlugins = value; }
        }

        /// Searches the Application's Startup Directory for Plugins
        public void FindPlugins()
        {
            FindPlugins(AppDomain.CurrentDomain.BaseDirectory );
        }

        /// Searches the passed Path for Plugins
        public void FindPlugins(string Path)
        {
            //First empty the collection, we're reloading them all
            colAvailablePlugins.Clear();

            //Go through all the files in the plugin directory
            if (!Directory.Exists(Path)) return;
            foreach (string fileOn in Directory.GetFiles(Path))
            {
                FileInfo file = new FileInfo(fileOn);

                //Preliminary check, must be .dll
                if (file.Extension.Equals(".dll"))
                {
                    //Add the 'plugin'
                    this.AddPlugin(fileOn);
                }
            }
        }

        /// Unloads and Closes all AvailablePlugins
        public void ClosePlugins()
        {
            foreach (Types.AvailablePlugin pluginOn in colAvailablePlugins)
            {
                //Close all plugin instances
                pluginOn.Instance.Dispose();
                pluginOn.Instance = null;
            }

            //Finally, clear our collection of available plugins
            colAvailablePlugins.Clear();
        }

        public void AddStandardPlugins()
        {
            IPlugin stdPlugin = new bbPressThread();
            Types.AvailablePlugin aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new bbPressTopic();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new GoogleImages();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new IPThread();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new IPTopic();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new URLGrab();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new vbThread();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

            stdPlugin = new vbTopic();
            aPlugin = new Types.AvailablePlugin();
            aPlugin.AssemblyPath = "";
            aPlugin.Instance = stdPlugin;
            aPlugin.Instance.Host = this;
            aPlugin.Instance.Initialize();
            this.colAvailablePlugins.Add(aPlugin);
            aPlugin = null;
            stdPlugin = null;

        }


        private void AddPlugin(string FileName)
        {
            //Create a new assembly from the plugin file we're adding..
            Assembly pluginAssembly = Assembly.LoadFrom(FileName);

            //Next we'll loop through all the Types found in the assembly
            foreach (Type pluginType in pluginAssembly.GetTypes())
            {
                if (pluginType.IsPublic) //Only look at public types
                {
                    if (!pluginType.IsAbstract)  //Only look at non-abstract types
                    {
                        //Gets a type object of the interface we need the plugins to match
                        Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);

                        //Make sure the interface we want to use actually exists
                        if (typeInterface != null)
                        {
                            //Create a new available plugin since the type implements the IPlugin interface
                            Types.AvailablePlugin newPlugin = new Types.AvailablePlugin();

                            //Set the filename where we found it
                            newPlugin.AssemblyPath = FileName;

                            //Create a new instance and store the instance in the collection for later use
                            //We could change this later on to not load an instance.. we have 2 options
                            newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));

                            //Set the Plugin's host to this class which inherited IPluginHost
                            newPlugin.Instance.Host = this;

                            //Call the initialization sub of the plugin
                            newPlugin.Instance.Initialize();

                            //Add the new plugin to our collection here
                            this.colAvailablePlugins.Add(newPlugin);

                            //cleanup a bit
                            newPlugin = null;
                        }

                        typeInterface = null; //Mr. Clean			
                    }
                }
            }

            pluginAssembly = null; //more cleanup
        }

        /// Displays a feedback dialog from the plugin
        public void Feedback(string Feedback, IPlugin Plugin)
        {
        }
    }
    namespace Types
    {
        /// Collection for AvailablePlugin Type
        public class AvailablePlugins : System.Collections.CollectionBase
        {
            /// Add a Plugin to the collection of Available plugins
            public void Add(Types.AvailablePlugin pluginToAdd)
            {
                this.List.Add(pluginToAdd);
            }

            /// Remove a Plugin to the collection of Available plugins
            public void Remove(Types.AvailablePlugin pluginToRemove)
            {
                this.List.Remove(pluginToRemove);
            }

            /// Finds a plugin in the available Plugins
            public Types.AvailablePlugin Find(string pluginNameOrPath)
            {
                Types.AvailablePlugin toReturn = null;

                //Loop through all the plugins
                foreach (Types.AvailablePlugin pluginOn in this.List)
                {
                    //Find the one with the matching name or filename
                    if ((pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath))
                    {
                        toReturn = pluginOn;
                        break;
                    }
                }
                return toReturn;
            }
        }

        /// Data Class for Available Plugin.  Holds and instance of the loaded Plugin, as well as the Plugin's Assembly Path
        public class AvailablePlugin
        {
            //This is the actual AvailablePlugin object.. 
            //Holds an instance of the plugin to access
            //ALso holds assembly path... not really necessary
            private IPlugin myInstance = null;
            private string myAssemblyPath = "";

            public IPlugin Instance
            {
                get { return myInstance; }
                set { myInstance = value; }
            }
            public string AssemblyPath
            {
                get { return myAssemblyPath; }
                set { myAssemblyPath = value; }
            }
        }
    }
}
