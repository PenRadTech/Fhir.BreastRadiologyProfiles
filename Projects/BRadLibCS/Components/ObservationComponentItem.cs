using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public class ObservationComponentItem<T> : ComponentSimpleItem<T>
        where T : Base
    {
        CodeableConcept conceptCode;

        public ObservationComponentItem(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
        }
    }

    public class ObservationComponentItem<T, U> : IComponentItem<T, U>
        where T : Base
        where U : Base
    {
        CodeableConcept conceptCode;
        Base value;
        public Base Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public ObservationComponentItem(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
        }
    }


    public class ObservationComponentCollection<T> : IComponentCollection<T>
        where T : Base
    {
        CodeableConcept conceptCode;
        List<T> items = new List<T>();

        public ObservationComponentCollection(CodeableConcept conceptCode)
        {
            this.conceptCode = conceptCode;
            throw new NotImplementedException();
        }

        public void Append(T item) => items.Add(item);
        public void Clear() => items.Clear();
        public Int32 Count() => items.Count;
        public IEnumerable<T> Items() => items;
    }
}
