using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Xero.Util.Model;

namespace Xero.Util.Parser
{
    public class TrafficParser
    {
        public static Traffic GetTraffic(JObject jo)
            => new Traffic()
            {
                Date = jo["date"].ToString(),
                In = long.Parse(jo["inputIn"].ToString()) + long.Parse(jo["outputIn"].ToString()),
                Out = long.Parse(jo["inputOut"].ToString()) + long.Parse(jo["outputOut"].ToString())
            };
       
        public static List<Traffic> GetTrafficList(JObject jo)
        {
            if ((bool)jo["success"] != true) throw new ValidationException();
            var l = new List<Traffic>();
            foreach (JObject j in jo["data"] as JArray)
            {
                l.Add(GetTraffic(j));
            }
            return l;
        }

        public static List<Traffic> GetTrafficList(string s) => GetTrafficList(s.ToJObject());
    }
}
