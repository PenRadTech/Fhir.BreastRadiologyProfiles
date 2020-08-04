using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRadLibCS
{
    public interface IBaseBase
    {
        /// <summary>
        /// Fhir instance id.
        /// </summary>
        String Id { get; set; }
    }

    public abstract class BaseBase : IBaseBase
    {
        public abstract String Id { get; set; }

        public BreastRadiologyDocument Doc { get; }
        public Base BaseResource => this.resource;
        protected Base resource;

        public BaseBase(BreastRadiologyDocument doc)
        {
            this.Doc = doc;
        }

        protected virtual void Init()
        {
        }

        public virtual bool Validate(StringBuilder sb)
        {
            return true;
        }

        public virtual void Write()
        {
        }

        public virtual void Read()
        {
        }
    }
}
