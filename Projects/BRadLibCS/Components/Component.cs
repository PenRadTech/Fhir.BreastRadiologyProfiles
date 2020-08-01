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


        public Component(CodeableConcept conceptCode, T value) : base(conceptCode)
        {
            this.Set(value);
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

        public Component(CodeableConcept conceptCode, Base value) : base(conceptCode)
        {
            if (!(value is T) && !(value is U))
                throw new Exception($"Component type must be {typeof(T).GetType().Name} or {typeof(U).GetType().Name}");
            this.value = value;
        }
    }
}
