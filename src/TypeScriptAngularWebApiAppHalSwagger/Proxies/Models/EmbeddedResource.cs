// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TypeScriptAngularWebApiAppHalSwagger.Proxies.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class EmbeddedResource
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsSourceAnArray")]
        public bool? IsSourceAnArray { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resources")]
        public IList<IResource> Resources { get; private set; }

    }
}
