namespace Xero.Util.Model
{
    public struct Traffic
    {
        public string Date { get; set; }
        public long OutputIn { get; set; }
        public long OutputOut { get; set; }
        public long InputIn { get; set; }
        public long InputOut { get; set; }
        public long In { get => InputIn + OutputIn; }
        public long Out { get => InputOut + OutputOut; }
        public double EFR { get => 1.0 * Out / In; }
        public double GetEffectIn(KernelType kt) => In * Kernel.GetTrafficEFR(kt);
        public double GetEffectOut(KernelType kt) => Out * Kernel.GetTrafficEFR(kt);
        public KernelType? KernelType { get; set; }
        public double EffectIn
        {
            get
            {
                if (KernelType.HasValue) return GetEffectIn(KernelType.Value);
                else return In;
            }
        }
        public double EffectOut
        {
            get
            {
                if (KernelType.HasValue) return GetEffectOut(KernelType.Value);
                else return Out;
            }
        }
    }
}
