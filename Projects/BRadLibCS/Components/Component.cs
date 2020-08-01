using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ComponentBase
    {
        public CodeableConcept ConceptCode { get; }

        public ComponentBase(CodeableConcept conceptCode)
        {
            this.ConceptCode = conceptCode;
        }
    }

    public class Component<T> : ComponentBase
        where T : Base
    {
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;


        public Component(CodeableConcept conceptCode) : base(conceptCode)
        {
        }
    }

    public class Component<T, U> : ComponentBase
        where T : Base
        where U : Base
    {
        Base value;
        public Base Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public Component(CodeableConcept conceptCode) : base(conceptCode)
        {
        }
    }
}
