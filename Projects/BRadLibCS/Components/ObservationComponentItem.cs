using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationComponentItem<T> : ComponentSimpleItem<T>
        where T : class
    {
        CodeableConcept conceptCode;

        public ObservationComponentItem(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
        }

        public override void Read<F>(BreastRadiologyDocument doc, F resource)
        {
            throw new NotImplementedException();
        }

        public override void Write(BreastRadiologyDocument doc) => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }

    public class ObservationComponentItem<S, T, U> : ComponentSimpleItem<S, T, U>
        where S : class
        where T : class, S
        where U : class, S
    {
        CodeableConcept conceptCode;

        public ObservationComponentItem(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
        }

        public override void Read<F>(BreastRadiologyDocument doc, F resource)
        {
            throw new NotImplementedException();
        }

        public override void Write(BreastRadiologyDocument doc) => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();
    }


    public class ObservationComponentCollection<T> : ComponentSimpleCollection<T>
        where T : class
    {
        CodeableConcept conceptCode;

        public ObservationComponentCollection(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
            throw new NotImplementedException();
        }

        public override void Read<F>(BreastRadiologyDocument doc, F resource) => throw new NotImplementedException();
        public override void Write(BreastRadiologyDocument doc) => throw new NotImplementedException();
        public override void Validate(StringBuilder sb) => throw new NotImplementedException();

    }
}
