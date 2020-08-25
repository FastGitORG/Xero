using System;

using Xero.Util.Model;

namespace Xero.Util
{
    class Kernel
    {
        // refer: https://www.affloc.com/1593.html
        public static double GetTrafficEFR(KernelType kt)
            => kt switch
            {
                KernelType.BBR_OLD => 1.2790,
                KernelType.BBRPLUS => 1.0209,
                KernelType.BBR_FQ => 1.0110,
                KernelType.BBR2_FQ => 1.1231,
                KernelType.BBR2_FQ_ECN => 1.1881,
                KernelType.BBR_CAKE => 0.3342,
                KernelType.BBR2_CAKE => 1.0419,
                KernelType.BBR2_CAKE_ECN => 1.2507,
                KernelType.TCPA => 1.5468,
                KernelType.LOTSERVER => 0.6761,
                _ => throw new ArgumentException()
            };
    }
}
