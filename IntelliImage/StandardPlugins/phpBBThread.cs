using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class phpBBThread : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "phpBBThread";
        string myDescription = "Grabbing images from a thread page of a phpBB based site";
        string myNullText = "Please enter the URL list here\nEg: http://www.gaiaonline.com/forum/picture-post/line-art-jam/t.828/\nhttp://forums.pearljam.com/viewtopic.php?f=11&t=67734";
        string myCaption = "phpBB Thread URL";

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
