using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationComponentBase
    {
        public CodeableConcept ConceptCode { get; }

        public ObservationComponentBase(CodeableConcept conceptCode)
        {
            this.ConceptCode = conceptCode;
        }
    }

    public class ObservationComponentItem<T> : ObservationComponentBase
        where T : Base
    {
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;


        public ObservationComponentItem(CodeableConcept conceptCode) : base(conceptCode)
        {
        }
    }

    public class ObservationComponentItem<T, U> : ObservationComponentBase
        where T : Base
        where U : Base
    {
        Base value;
        public Base Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public ObservationComponentItem(CodeableConcept conceptCode) : base(conceptCode)
        {
        }
    }
}
