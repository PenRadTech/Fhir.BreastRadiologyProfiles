using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    public class ResourceBag
    {
        public Bundle Bundle { get; }
        Dictionary<String, Bundle.EntryComponent> resources = new Dictionary<string, Bundle.EntryComponent>(StringComparer.OrdinalIgnoreCase);

        public ResourceBag()
        {
            this.Bundle = new Bundle();
            this.Bundle.Type = Bundle.BundleType.Document;
        }

        public ResourceBag(Bundle bundle)
        {
            this.Bundle = bundle;

            if (this.Bundle.Type != Bundle.BundleType.Document)
                throw new Exception($"Expected bundle type 'Document', got '{this.Bundle.Type}'");
            foreach (Bundle.EntryComponent entry in bundle.Entry)
                this.resources.Add(entry.FullUrl, entry);
        }

        public IEnumerable<Bundle.EntryComponent> Entries => this.resources.Values;

        public bool TryGetEntry(String url, out Bundle.EntryComponent entry) => this.resources.TryGetValue(url, out entry);

        /// <summary>
        /// Add resource to the bundle and to the resource dictionary.
        /// </summary>
        /// <param name="fullUrl"></param>
        /// <param name="resource"></param>
        public void AddResource(DomainResource resource)
        {
            if (String.IsNullOrEmpty(resource.Id) == true)
                resource.Id = $"{Guid.NewGuid().ToString()}";

            if (this.resources.ContainsKey(resource.Id) == false)
            {
                Bundle.EntryComponent entry = this.Bundle.AddResourceEntry(resource, resource.Id);
                this.resources.Add(resource.Id, entry);
            }
        }
    }
}
