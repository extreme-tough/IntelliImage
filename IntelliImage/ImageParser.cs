using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using IntelliImageInterface;

namespace IntelliImage
{
    public enum SourceType
    {
        KEYWORD,
        VBULLETIN,
        BBPRESS,
        INVISION,
        URL
    };

    class ImageParser
    {
        public string inputSource;

        public SourceType AutoIdentify()
        {
            bool isURL=false;
            string urlToUse = inputSource.ToLower();

            if (inputSource == "")
            {
                throw new Exception("Input source not defined");                
            }

            string pattern = @"((https?|file):((//)|(\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)";
            Match match = Regex.Match(inputSource, pattern, RegexOptions.IgnoreCase);
            if (!match.Success)
                return SourceType.KEYWORD;
            else
            {
                string pageContents = DownloadPage();
                string generatorCode = getGenerator(pageContents);
                if (generatorCode.Contains("bbpress"))
                    return SourceType.BBPRESS;
                else if (generatorCode.Contains("vbulletin"))
                    return SourceType.VBULLETIN;

                if (pageContents.Contains("powered by vbulletin"))
                    return SourceType.VBULLETIN;
                else if (pageContents.Contains("powered by invision power board"))
                    return SourceType.INVISION;
                else if (pageContents.Contains("forum is proudly powered by invision power board"))
                    return SourceType.INVISION;

                if (urlToUse.Contains("forumdisplay.php") || urlToUse.Contains("showthread.php"))
                    return SourceType.VBULLETIN;
                else if (urlToUse.Contains("/forum/") || urlToUse.Contains("/topic/"))
                    return SourceType.BBPRESS;
            }
            return SourceType.URL;  
        }

        private string DownloadPage()
        {
            WebClient oClient = new WebClient();
            string downloadData = oClient.DownloadString(inputSource);
            return downloadData.ToLower();
        }

        private string getGenerator(string source)
        {
            string[] arContent = source.GetStringBetween("<meta name=\"generator\"", "/>");
            if (arContent.Length == 0)
                return "";
            else
            {
                arContent = arContent[0].GetStringBetween("content=\"", "\"");
            }
            if (arContent.Length > 0)
                return arContent[0];
            else
                return "";
        }
    }

}
