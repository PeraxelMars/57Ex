using System;
using System.Web.Mvc;
using ModelMetadata = System.Web.Mvc.ModelMetadata;

namespace _57_Exercises.Helpers
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false) ]
    public class PlaceholderAttribute : Attribute, IMetadataAware
    {
        public string Placeholder { get; }

        public PlaceholderAttribute(string placeholder)
        {
            Placeholder = placeholder;
        }

        public void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues.Add("Placeholder", Placeholder);
        }
    }
}