// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Migrate.ResourceMover.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines reference to an Azure resource.
    /// </summary>
    public partial class AzureResourceReference
    {
        /// <summary>
        /// Initializes a new instance of the AzureResourceReference class.
        /// </summary>
        public AzureResourceReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureResourceReference class.
        /// </summary>
        /// <param name="sourceArmResourceId">Gets the ARM resource ID of the
        /// tracked resource being referenced.</param>
        public AzureResourceReference(string sourceArmResourceId)
        {
            SourceArmResourceId = sourceArmResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ARM resource ID of the tracked resource being referenced.
        /// </summary>
        [JsonProperty(PropertyName = "sourceArmResourceId")]
        public string SourceArmResourceId { get; set; }

    }
}
