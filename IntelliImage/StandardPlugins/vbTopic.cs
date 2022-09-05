using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class vbTopic : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "vbTopic";
        string myDescription = "Grabbing images from a topics page of a vBulletin based site";
        string myNullText = "Please enter the URL list here\nEg: http://advrider.com/forums/forumdisplay.php?s=e272aaeee5394c30397948295f90ae43&f=78\nhttp://www.militaryphotos.net/forums/forumdisplay.php?6-Strictly-Photos-amp-Video&s=8d27552e915519cb316a60473ce60289";
        string myCaption = "vBulletin Topic URL";

        public IPluginHost Host
        {
            get { return myPluginHost; }
            set { myPluginHost = value; }
        }

        public string Name
        {
            get { return myName; }
        }

        public string Description
        {
            get { return myDescription; }
        }

        public string Caption
        {
            get { return myCaption; }
        }

        public string NullText
        {
            get { return myNullText; }
        }
        public string Author
        {
            get { return "Cuebiz Technologies"; }
        }

        public string Version
        {
            get { return "1.0"; }
        }

        public void Initialize()
        {
            // Nothing for now
        }

        public void Dispose()
        {
            // Nothing for now
        }

        public string StartDownload(string input)
        {
            throw new NotImplementedException();
        }
    }
}
