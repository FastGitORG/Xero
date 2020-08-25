namespace Xero.Util.Model
{
    public struct Traffic
    {
        public string Date;
        public long In;
        public long Out;
        public double EFR { get => 1.0 * Out / In; }
    }
}
