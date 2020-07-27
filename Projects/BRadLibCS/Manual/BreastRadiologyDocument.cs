using Hl7.Fhir.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BreastRadLib
{
    /// <summary>
    /// This is the base of the Breast Radiology Report
    /// It Implements a Fhir Document, which is a special type of bundle,
    /// and provides access to the index of that document, which is the
    /// Composition instance.
    /// </summary>
    public partial class BreastRadiologyDocument
    {
        /// <summary>
        /// Reference to Subject of document. This is propogated to all observations in this document that reference
        /// a subject.
        /// </summary>
        public ResourceReference Subject { get; set; }


        /// <summary>
        /// Reference to Encounter of document. This is propogated to all observations in this document that reference
        /// an encounter.
        /// </summary>
        public ResourceReference Encounter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Dictionary<Base, BaseBase> items = new Dictionary<Base, BaseBase>();

        /// <summary>
        /// Contains the Fhir Bundle, and a dictionary of each of the items in the
        /// bundle to allow quick access of each item.
        /// </summary>
        public ResourceBag ResourceBag { get; private set; }

        //    /// <summary>
        //    /// Fhir documents main composition item. This is the 'index' of the
        //    /// fhir document, and must be the first item in the bundle.
        //    /// </summary>
        //    public CBreastRadiologyComposition Index;

        //    /// <summary>
        //    /// Private constructor. Use the static helper methods.
        //    /// </summary>
        //    private BreastRadiologyDocument()
        //    {
        //    }

        public void Register(BaseBase baseItem)
        {
            this.ResourceBag.AddResource((DomainResource)baseItem.BaseResource);
            this.items.Add(baseItem.BaseResource, baseItem);
        }

        public bool TryGetRegisteredItem<T>(Base fhirBase, out T item)
            where T : BaseBase
        {
            item = null;
            if (this.items.TryGetValue(fhirBase, out BaseBase temp) == false)
                return false;
            item = temp as T;
            if (item == null)
                throw new Exception($"Item of class {temp.GetType().Name} can not be converted to class {typeof(T).Name}");
            return true;
        }

        /// <summary>
        /// Create a new BreastRadiologyDocument.
        /// </summary>
        /// <returns></returns>
        public static BreastRadiologyDocument Create()
        {
            throw new NotImplementedException();
            //$BreastRadiologyDocument retVal = new BreastRadiologyDocument();
            //retVal.ResourceBag = new ResourceBag();
            //retVal.Index = new BreastRadComposition(retVal);
            //retVal.ResourceBag.AddResource(retVal.Index.Resource);
            //return retVal;
        }

        //    /// <summary>
        //    /// Create a new BreastRadiologyDocument and load it with the passed fhir document.
        //    /// </summary>
        //    /// <returns></returns>
        //    public static BreastRadiologyDocument Read(Bundle bundle)
        //    {
        //        throw new NotImplementedException();
        //        //$BreastRadiologyDocument retVal = new BreastRadiologyDocument();
        //        //retVal.LoadBundle(bundle);

        //        //// now write all the others.
        //        //foreach (BaseBase baseItem in retVal.items.Values.ToArray())
        //        //{
        //        //    baseItem.Read(); ;
        //        //}

        //        //retVal.Subject = retVal.Index.Resource.Subject;
        //        //retVal.Encounter = retVal.Index.Resource.Encounter;
        //        //return retVal;
        //    }

        //    /// <summary>
        //    /// Read FhirDocument from a bundle.
        //    /// </summary>
        //    /// <returns></returns>
        //    void LoadBundle(Bundle bundle)
        //    {
        //        throw new NotImplementedException();
        //        //$this.ResourceBag = new ResourceBag(bundle);

        //        //// First entry is always composition item.
        //        //{
        //        //    Composition index = bundle.Entry?.First().Resource as Composition;
        //        //    if (index == null)
        //        //        throw new Exception($"Invalid bundle. First item is not a Composition");
        //        //    this.Index = new BreastRadComposition(this, index);
        //        //}
        //        //foreach (Bundle.EntryComponent entry in bundle.Entry.Skip(1))
        //        //{
        //        //    String profile = entry.Resource?.Meta?.Profile?.First();
        //        //    if (profile == null)
        //        //        throw new Exception("Resource in bundle lacks Meta.Profile element to identify the profile.");
        //        //    var item = ResourceFactory.CreateBreastRadProfileResource(this,
        //        //        profile,
        //        //        entry.Resource);
        //        //    if (item == null)
        //        //        item = new ResourceBase(this, (DomainResource)entry.Resource);
        //        //}
        //    }

        //    /// <summary>
        //    /// Validate resource.
        //    /// Throw exception if obvious error.
        //    /// </summary>
        //    public bool Validate(StringBuilder sb)
        //    {
        //        bool retVal = true;
        //        if (this.Subject == null)
        //        {
        //            sb.Append($"BreastRadiologyDocument.Subject not set");
        //            retVal = false;
        //        }

        //        if (this.Encounter == null)
        //        {
        //            sb.Append($"BreastRadiologyDocument.Encounter not set");
        //            retVal = false;
        //        }

        //        foreach (BaseBase baseItem in this.items.Values)
        //        {
        //            if (baseItem.Validate(sb) == false)
        //                retVal = false;
        //        }

        //        return retVal;
        //    }

        //    /// <summary>
        //    /// Write FhirDocument to a bundle and return it.
        //    /// </summary>
        //    /// <returns></returns>
        //    public Bundle Write()
        //    {
        //        throw new NotImplementedException();
        //        //$Bundle retVal = new Bundle();
        //        //retVal.Type = Bundle.BundleType.Document;

        //        //void WriteItem(BaseBase baseItem)
        //        //{
        //        //    baseItem.Write();
        //        //    if (String.IsNullOrEmpty(baseItem.Id) == true)
        //        //        throw new Exception($"Error saving resource. Resource has no id!");
        //        //    retVal.AddResourceEntry((Resource)baseItem.BaseResource, baseItem.Id);
        //        //}

        //        //// Composition must be written first....
        //        //WriteItem(this.Index);

        //        //// now write all the others.
        //        //foreach (BaseBase baseItem in this.items.Values)
        //        //{
        //        //    if (baseItem != this.Index)
        //        //        WriteItem(baseItem);
        //        //}

        //        //return this.ResourceBag.Bundle;
        //    }

        public T ReferencedResource<T>(ResourceReference resRef)
            where T : Base
        {
            if (this.ResourceBag.TryGetEntry(resRef.Reference, out var entry) == false)
                throw new Exception($"Error referencing section resource '{resRef.Reference}'");
            Resource referencedResource = entry.Resource;
            if (referencedResource.Meta.Profile.Count() != 1)
                throw new Exception($"Invalid Meta.profile. Expected 1, got {referencedResource.Meta.Profile.Count()}");
            T retVal = referencedResource as T;
            if (retVal == null)
                throw new Exception($"Resource can not be converted to {typeof(T).Name}");
            return retVal;
        }

        public ResourceBase GetResource(ResourceReference resRef)
        {
            Resource referencedResource = this.ReferencedResource<Resource>(resRef);
            if (this.TryGetRegisteredItem(referencedResource, out ResourceBase item) == false)
                throw new Exception($"Referenced resource {referencedResource.Id} not found in bundle");
            return item;
        }
    }
}
