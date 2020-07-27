using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreastRadLib
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

        public Base BaseResource => this.resource;
        protected Base resource;
        public BreastRadiologyDocument Doc { get; private set; }

        public BaseBase()
        {
        }

        public virtual void Init(BreastRadiologyDocument doc, Base resource = null)
        {
            this.Doc = doc;
            if (resource == null)
                return;
            this.resource = resource;
            this.Doc.Register(this);
        }

        public virtual void Write()
        {
        }

        public virtual bool Validate(StringBuilder sb)
        {
            return true;
        }

        public virtual void Read()
        {
        }
    }
}
