using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRadLibCS
{
    public interface IResourceBase : IBaseBase
    {
        String profileUrl { get; }

        Meta Meta { get; }
    }

    public class ResourceBase : BaseBase, IResourceBase
    {
        DomainResource domainResource => (DomainResource)this.resource;
        public String profileUrl { get; private set; }

        public Meta Meta => this.GetMeta();

        public override String Id
        {
            get => this.domainResource.Id;
            set => this.domainResource.Id = value;
        }

        public ResourceBase(BreastRadiologyDocument doc) : base(doc)
        {
        }

        Meta GetMeta()
        {
            if (this.domainResource.Meta == null)
                this.domainResource.Meta = new Meta();
            return this.domainResource.Meta;
        }

        protected void SetProfileUrl(String profileUrl)
        {
            this.profileUrl = profileUrl;
            List<String> metaProfiles = this.Meta.Profile.ToList();
            if (metaProfiles.Contains(profileUrl) == false)
                metaProfiles.Add(profileUrl);
            this.domainResource.Meta.Profile = metaProfiles;
        }
    }
}
