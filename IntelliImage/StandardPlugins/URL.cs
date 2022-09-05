using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class URLGrab : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "URL";
        string myDescription = "Grabbing images from any web page";
        string myNullText = "Please enter the URL list here\nEg: http://www.nasaimages.org/luna/servlet/view/all/what/Earth/\nhttp://www.flickr.com/photos/12617230@N03/sets/72157629373225051/";
        string myCaption = "URL";

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
