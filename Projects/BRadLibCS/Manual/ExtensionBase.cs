using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public interface IExtensionBase : IBaseBase
    {
    }

    public class ExtensionBase : BaseBase, IExtensionBase
    {
        public String profileUrl { get; private set; }
        public Extension Resource => (Extension)this.resource;

        public override String Id
        {
            get => this.Resource.ElementId;
            set => this.Resource.ElementId = value;
        }

        public ExtensionBase() : base()
        {
        }

        protected void SetProfileUrl(String profileUrl)
        {
            this.profileUrl = profileUrl;
        }

        protected void ClearExtensions()
        {
            throw new NotImplementedException();
        }
    }
}
