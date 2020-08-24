namespace Xero.Util.Text
{
    public static class Url
    {
        public static string SERVER_ID_TRAFFIC(int serverId) => "https://api.dogyun.com/cvm/server/" + serverId + "/traffic";

        public const string TRAFFIC_LIST = "https://api.dogyun.com/cvm/server/traffic";
    }
}
