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
        T Get();
        void Set(T value);

        void Read(BreastRadiologyDocument doc, B resource);
        void Write(BreastRadiologyDocument doc, B resource);
        void Validate(StringBuilder sb);
    }
    public interface IComponentItem<B, S, T, U>
        where B : DomainResource
        where S : class
        where T : S
        where U : S
    {
        S Get();
        void Set(T value);
        void Set(U value);

        void Read(BreastRadiologyDocument doc, B resource);
        void Write(BreastRadiologyDocument doc, B resource);
        void Validate(StringBuilder sb);
    }

    public interface IComponentCollection<B, T>
        where B : DomainResource
        where T : class
    {
        Int32 Count();
        void Clear();
        void Append(T item);
        IEnumerable<T> Items();

        void Read(BreastRadiologyDocument doc, B resource);
        void Write(BreastRadiologyDocument doc, B resource);
        void Validate(StringBuilder sb);
    }
}
