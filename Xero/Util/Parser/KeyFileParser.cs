using System.Collections.Generic;
using System.IO;

namespace Xero.Util.Parser
{
    class KeyParser
    {
        public static string[] GetKeyArray(string path)
        {
            var f = File.ReadAllLines(path);
            var l = new List<string>();
            for (int i = 0; i < f.Length; ++i)
            {
                if (string.IsNullOrWhiteSpace(f[i])) continue;
                var v = f[i].Split('#')[0].Trim();
                if (string.IsNullOrWhiteSpace(v)) continue;
                l.Add(v);
            }
            return l.ToArray();
        }

        public static string GetKeyString(string path)
        {
            string key = string.Empty;
            var v = GetKeyArray(path);
            for (int i = 0; i < v.Length; ++i)
            {
                key += v[i];
                if (i != v.Length - 1) key += "\n";
            }
            return key;
        }
    }
}
