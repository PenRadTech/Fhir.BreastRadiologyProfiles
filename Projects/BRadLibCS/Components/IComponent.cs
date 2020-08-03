using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IComponentItem<T>
    {
        T Get();
        void Set(T value);
    }
    public interface IComponentItem<T, U>
    {
        Base Get();
        void Set(T value);
        void Set(U value);
    }

    public interface IComponentCollection<T>
    {
        Int32 Count();
        void Clear();
        void Append(T item);
        IEnumerable<T> Items();
    }
}
