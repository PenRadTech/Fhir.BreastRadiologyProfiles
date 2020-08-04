using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationHasMemberItem<T> : ComponentSimpleItem<Observation, T>
        where T : class
    {
        public override void Read() => throw new NotImplementedException();
        public override void Write() => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }

    public class ObservationHasMemberCollection<T> : ComponentSimpleCollection<Observation, T>
        where T : class
    {
        public override void Read() => throw new NotImplementedException();
        public override void Write() => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }
}
