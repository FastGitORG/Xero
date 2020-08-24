using Newtonsoft.Json.Linq;

namespace Xero.Util
{
    public static class Stringcs
    {
        public static JObject ToJObject(this string s) => JObject.Parse(s);
    }
}
