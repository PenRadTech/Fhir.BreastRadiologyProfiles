using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationHasMemberItem<T> : ComponentSimpleItem<T>
        where T : class
    {
        public override void Read<F>(BreastRadiologyDocument doc, F resource) => throw new NotImplementedException();
        public override void Write(BreastRadiologyDocument doc) => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }

    public class ObservationHasMemberCollection<T> : ComponentSimpleCollection<T>
        where T : class
    {
        public override void Read<F>(BreastRadiologyDocument doc, F resource) => throw new NotImplementedException();
        public override void Write(BreastRadiologyDocument doc) => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }
}
