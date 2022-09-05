using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace IntelliImageInterface
{
    public class Configuration
    {
        public Configuration Settings = new Configuration();
        public Configuration()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("settings.iid", FileMode.Open, FileAccess.Read, FileShare.None);
            Settings = (Configuration)formatter.Deserialize(stream);
            stream.Close();
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("settings.iid", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public string ProxyServer = "172.16.6.61";
        public int ProxyPort = 8080;
        public string ProxyUserName = "rkrishnamoorthy";
        public string ProxyPassword = "710@Welcome";
    }
}
