using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IComponentItem<B, T>
        where B : DomainResource
        where T : class
    {
        B ContainingResource { get; }
        T Get();
        void Set(T value);

        void Read();
        void Write();
        void Validate(StringBuilder sb);
    }

    public interface IComponentItem<B, S, T, U>
        where B : DomainResource
        where S : class
        where T : S
        where U : S
    {
        B ContainingResource { get; }

        S Get();
        void Set(T value);
        void Set(U value);

        void Read();
        void Write();
        void Validate(StringBuilder sb);
    }

    public interface IComponentCollection<B, T>
        where B : DomainResource
        where T : class
    {
        B ContainingResource { get; }

        Int32 Count();
        void Clear();
        void Append(T item);
        IEnumerable<T> Items();

        void Read();
        void Write();
        void Validate(StringBuilder sb);
    }
}
