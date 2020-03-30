using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class ProfileTargetSlice
    {
        public String Profile { get; }
        public Int32 Min { get; }
        public String Max { get; }

        public ProfileTargetSlice(String profile, Int32 min, String max)
        {
            this.Profile = profile;
            this.Min = min;
            this.Max = max;
        }
    }
}