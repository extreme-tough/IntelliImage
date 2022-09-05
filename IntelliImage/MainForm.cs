using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IntelliImage
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        Types.AvailablePlugin selectedPlugin;

        public MainForm()
        {
            InitializeComponent();
        }

        private void sourcemenu_Click(object sender, EventArgs e)
        {
            selectedPlugin = (Types.AvailablePlugin) (((Telerik.WinControls.UI.RadMenuItem) sender).Tag);

            SourceType.Text= ((Telerik.WinControls.UI.RadMenuItem)(sender)).Text;
            sourceList.Clear();
            sourceList.NullText = selectedPlugin.Instance.NullText;
        }

        private void LoadAddins()
        {
            Telerik.WinControls.UI.RadMenuItem sourcemenu;
            Global.Plugins.FindPlugins(Application.StartupPath + @"\Plugins");
            Global.Plugins.AddStandardPlugins();
            foreach (Types.AvailablePlugin pluginOn in Global.Plugins.AvailablePlugins)
            {
                sourcemenu = new Telerik.WinControls.UI.RadMenuItem();
                sourcemenu.AccessibleDescription = pluginOn.Instance.Caption;
                sourcemenu.AccessibleName = pluginOn.Instance.Caption;
                sourcemenu.Name = pluginOn.Instance.Name;
                sourcemenu.Text = pluginOn.Instance.Caption;
                sourcemenu.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                sourcemenu.Tag = pluginOn;
                sourcemenu.Click += new System.EventHandler(this.sourcemenu_Click);                
                SourceType.Items.Add(sourcemenu);
                if (sourcemenu.Name == "URL")
                {
                    sourcemenu_Click(sourcemenu,new EventArgs());
                }

                sourcemenu = null;
            }
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAddins();
        }

       
    }
}
