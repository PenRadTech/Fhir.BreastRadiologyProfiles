using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public abstract class ComponentSimpleItem<B, T> : IComponentItem<B, T>
        where B : DomainResource
        where T : class
    {
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;

        public abstract void Read(BreastRadiologyDocument doc, B resource);
        public abstract void Write(BreastRadiologyDocument doc, B resource);
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleItem<B, S, T, U> : IComponentItem<B, S, T, U>
        where B : DomainResource
        where S : class
        where T : class, S
        where U : class, S
    {
        S value;

        public S Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public abstract void Read(BreastRadiologyDocument doc, B resource);
        public abstract void Write(BreastRadiologyDocument doc, B resource);
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleCollection<B, T> : IComponentCollection<B, T>
        where B : DomainResource
        where T : class
    {
        protected List<T> items = new List<T>();
        public void Append(T item) => items.Add(item);
        public void Clear() => items.Clear();
        public Int32 Count() => items.Count;
        public IEnumerable<T> Items() => items;

        public abstract void Read(BreastRadiologyDocument doc, B resource);
        public abstract void Write(BreastRadiologyDocument doc, B resource);
        public abstract void Validate(StringBuilder sb);
    }
}
