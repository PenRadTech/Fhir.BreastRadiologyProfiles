using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationHasMemberItem<T> : ComponentSimpleItem<T>
        where T : class
    {
    }

    public class ObservationHasMemberCollection<T> : ComponentSimpleCollection<T>
        where T : class
    {
    }
}
