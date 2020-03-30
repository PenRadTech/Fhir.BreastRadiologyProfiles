using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    /// <summary>
    /// Class that created an item and lazy loads it into
    /// saved var for future use.
    /// </summary>
    class TaskVar<T>
    {
        public delegate void Fcn(out T s);

        T value;
        readonly Fcn entry;

        public T Value()
        {
            if (this.value == null)
                this.entry(out this.value);
            return this.value;
        }

        public TaskVar(Fcn entry)
        {
            this.entry = entry;
        }
    }

    class VSTaskVar : TaskVar<ValueSet>
    {
        public VSTaskVar(Fcn entry) : base(entry)
        {
        }
    }

    class CSTaskVar : TaskVar<CodeSystem>
    {
        public CSTaskVar(Fcn entry) : base(entry)
        {
        }
    }

    class SDTaskVar : TaskVar<StructureDefinition>
    {
        public SDTaskVar(Fcn entry) : base(entry)
        {
        }
    }
}