using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public abstract class ComponentSimpleItem<T> : IComponentItem<T>
        where T : class
    {
        T value;
        public T Get() => this.value;
        public void Set(T value) => this.value = value;
    }

    public abstract class ComponentSimpleCollection<T> : IComponentCollection<T>
        where T : class
    {
        protected List<T> items = new List<T>();
        public void Append(T item) => items.Add(item);
        public void Clear() => items.Clear();
        public Int32 Count() => items.Count;
        public IEnumerable<T> Items() => items;
    }
}
