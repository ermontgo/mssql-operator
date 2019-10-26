using System;

namespace OperatorSharp.CustomResources.Metadata
{
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class ApiVersionAttribute : Attribute
    {
        public ApiVersionAttribute(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        public string ApiVersion { get; }
    }
}