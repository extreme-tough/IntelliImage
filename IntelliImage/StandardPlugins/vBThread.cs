using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class vbThread : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "vbThread";
        string myDescription = "Grabbing images from a thread page of a vBulletin based site";
        string myNullText = "Please enter the URL list here\nEg: http://www.militaryphotos.net/forums/showthread.php?213244-Weekend-Photos-2nd-and-3rd-June-2012\nhttp://advrider.com/forums/showthread.php?t=611722";
        string myCaption = "vBulletin Thread URL";

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
