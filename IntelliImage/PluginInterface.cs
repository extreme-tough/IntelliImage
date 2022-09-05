using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImage
{
    public interface IPlugin
    {
        IPluginHost Host { get; set; }

        string Name { get; }
        string Description { get; }
        string NullText { get; }
        string Caption { get; }
        string Author { get; }
        string Version { get; }

        void Initialize();
        void Dispose();

        string StartDownload(string input);
    }

    public interface IPluginHost
    {
        void Feedback(string Feedback, IPlugin Plugin);
    }
}
