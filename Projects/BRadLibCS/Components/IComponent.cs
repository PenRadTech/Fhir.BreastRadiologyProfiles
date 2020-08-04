using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IComponentItem<R, T>
        where R : DomainResource
        where T : class
    {
        T Get();
        void Set(T value);

        void Read(BreastRadiologyDocument doc, R resource);
        void Write(BreastRadiologyDocument doc, R resource);
        void Validate(StringBuilder sb);
    }

    public interface IComponentItem<R, S, T, U>
        where R : DomainResource
        where S : class
        where T : S
        where U : S
    {
        S Get();
        void Set(T value);
        void Set(U value);

        void Read(BreastRadiologyDocument doc, R resource);
        void Write(BreastRadiologyDocument doc, R resource);
        void Validate(StringBuilder sb);
    }

    public interface IComponentCollection<R, T>
        where R : DomainResource
        where T : class
    {
        Int32 Count();
        void Clear();
        void Append(T item);
        IEnumerable<T> Items();

        void Read(BreastRadiologyDocument doc, R resource);
        void Write(BreastRadiologyDocument doc, R resource);
        void Validate(StringBuilder sb);
    }
}
