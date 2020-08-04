using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IComponentItem<T>
        where T : class
    {
        T Get();
        void Set(T value);

        void Read<F>(BreastRadiologyDocument doc, F resource)
            where F :DomainResource;
        void Write(BreastRadiologyDocument doc);
        void Validate(StringBuilder sb);
    }
    public interface IComponentItem<S, T, U>
        where S : class
        where T : S
        where U : S
    {
        S Get();
        void Set(T value);
        void Set(U value);

        void Read<F>(BreastRadiologyDocument doc, F resource)
            where F : DomainResource;
        void Write(BreastRadiologyDocument doc);
        void Validate(StringBuilder sb);
    }

    public interface IComponentCollection<T>
        where T : class
    {
        Int32 Count();
        void Clear();
        void Append(T item);
        IEnumerable<T> Items();

        void Read<F>(BreastRadiologyDocument doc, F resource)
            where F : DomainResource;
        void Write(BreastRadiologyDocument doc);
        void Validate(StringBuilder sb);
    }
}
