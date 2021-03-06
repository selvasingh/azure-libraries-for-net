// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource group information.
    /// </summary>
    public partial class ResourceGroupInner
    {
        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        public ResourceGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceGroupInner class.
        /// </summary>
        /// <param name="location">The location of the resource group. It
        /// cannot be changed after the resource group has been created. Has to
        /// be one of the supported Azure Locations, such as West US, East US,
        /// West Europe, East Asia, etc.</param>
        /// <param name="id">The ID of the resource group.</param>
        /// <param name="name">The Name of the resource group.</param>
        /// <param name="tags">The tags attached to the resource group.</param>
        public ResourceGroupInner(string location, string id = default(string), string name = default(string), ResourceGroupProperties properties = default(ResourceGroupProperties), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Id = id;
            Name = name;
            Properties = properties;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the Name of the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ResourceGroupProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource group. It cannot be
        /// changed after the resource group has been created. Has to be one of
        /// the supported Azure Locations, such as West US, East US, West
        /// Europe, East Asia, etc.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
