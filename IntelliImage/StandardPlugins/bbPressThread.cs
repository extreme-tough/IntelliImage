using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage.StandardPlugins
{
    class bbPressThread : IPlugin
    {
        IPluginHost myPluginHost = null;
        string myName = "bbPressThread";
        string myDescription = "Grabbing images from a topic page of a bbPress based site";
        string myNullText = "Please enter the URL list here\nEg: http://singletrackworld.com/forum/topic/fs-bike-split-forks-bars-and-a-left-handed-guitar-more-reductionspics-11\nhttp://kitezone.ca/forum/topic/piloter-en-mettant-le-poids-du-buggy-vers-lavantvous-avez-essaye";
        string myCaption = "bbPress Thread URL";

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
