using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    [Flags]
    public enum Modalities
    {
        MG = 0x001,
        US = 0x002,
        MRI = 0x004,
        NM = 0x008,

        All = MG | US | MRI | NM
    }
}