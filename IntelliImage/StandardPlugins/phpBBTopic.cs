using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class phpBBTopic : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "phpBBTopic";
        string myDescription = "Grabbing images from the forum page of a phpBB based site";
        string myNullText = "Please enter the URL list here\nEg: http://www.gaiaonline.com/forum/picture-post/f.7/\nhttp://forums.pearljam.com/viewforum.php?f=11&sid=775f3dd2690e1e2f18e4371fa05f9365";
        string myCaption = "phpBB Topic URL";

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
