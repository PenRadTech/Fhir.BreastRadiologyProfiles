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
        public B ContainingResource { get; set; }
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;

        public abstract void Read();
        public abstract void Write();
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleItem<B, S, T, U> : IComponentItem<B, S, T, U>
        where B : DomainResource
        where S : class
        where T : class, S
        where U : class, S
    {
        public B ContainingResource { get; set; }
        S value;

        public S Get() => this.value;
        public void Set(T value) => this.value = value;
        public void Set(U value) => this.value = value;

        public abstract void Read();
        public abstract void Write();
        public abstract void Validate(StringBuilder sb);
    }

    public abstract class ComponentSimpleCollection<B, T> : IComponentCollection<B, T>
        where B : DomainResource
        where T : class
    {
        public B ContainingResource { get; set; }

        protected List<T> items = new List<T>();
        public void Append(T item) => items.Add(item);
        public void Clear() => items.Clear();
        public Int32 Count() => items.Count;
        public IEnumerable<T> Items() => items;

        public abstract void Read();
        public abstract void Write();
        public abstract void Validate(StringBuilder sb);
    }
}
