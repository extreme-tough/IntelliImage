using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class IPThread : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "IPThread";
        string myDescription = "Grabbing images from a thread page of a Invision Power Board based site";
        string myNullText = "Please enter the URL list here\nEg: http://www.hamaraforums.com/index.php?showtopic=75050\nhttp://wetpixel.com/forums/index.php?showtopic=44262";
        string myCaption = "Invision Power Thread URL";

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
