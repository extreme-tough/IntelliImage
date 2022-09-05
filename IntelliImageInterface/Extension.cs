using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliImageInterface
{
    public static class Extension
    {
        public static string[] Split(this string str, string seperator)
        {
            return str.Split(new string[] { seperator }, StringSplitOptions.None);
        }

        public static string[] GetStringBetween(this string strSource, string strBegin, string strEnd, bool includeBegin = false, bool includeEnd = false)
        {
            string[] result = { "", "" };
            int iIndexOfBegin = strSource.IndexOf(strBegin);
            if (iIndexOfBegin != -1)
            {
                // include the Begin string if desired
                if (includeBegin)
                    iIndexOfBegin -= strBegin.Length;
                strSource = strSource.Substring(iIndexOfBegin
                    + strBegin.Length);
                int iEnd = strSource.IndexOf(strEnd);
                if (iEnd != -1)
                {
                    // include the End string if desired
                    if (includeEnd)
                        iEnd += strEnd.Length;
                    result[0] = strSource.Substring(0, iEnd);
                    // advance beyond this segment
                    if (iEnd + strEnd.Length < strSource.Length)
                        result[1] = strSource.Substring(iEnd
                            + strEnd.Length);
                }
            }
            else
                // stay where we are
                result[1] = strSource;
            return result;
        }
    }
}
