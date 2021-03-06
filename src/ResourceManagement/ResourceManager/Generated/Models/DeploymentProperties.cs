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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment properties.
    /// </summary>
    public partial class DeploymentProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        /// <param name="mode">The deployment mode. Possible values include:
        /// 'Incremental', 'Complete'</param>
        /// <param name="template">The template content. It can be a JObject or
        /// a well formed JSON string. Use only one of Template or
        /// TemplateLink.</param>
        /// <param name="templateLink">The template URI. Use only one of
        /// Template or TemplateLink.</param>
        /// <param name="parameters">Deployment parameters. It can be a JObject
        /// or a well formed JSON string. Use only one of Parameters or
        /// ParametersLink.</param>
        /// <param name="parametersLink">The parameters URI. Use only one of
        /// Parameters or ParametersLink.</param>
        /// <param name="debugSetting">The debug setting of the
        /// deployment.</param>
        public DeploymentProperties(DeploymentMode mode, object template = default(object), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DebugSetting debugSetting = default(DebugSetting))
        {
            Template = template;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template content. It can be a JObject or a well
        /// formed JSON string. Use only one of Template or TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the template URI. Use only one of Template or
        /// TemplateLink.
        /// </summary>
        [JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; set; }

        /// <summary>
        /// Gets or sets deployment parameters. It can be a JObject or a well
        /// formed JSON string. Use only one of Parameters or ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the parameters URI. Use only one of Parameters or
        /// ParametersLink.
        /// </summary>
        [JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the deployment mode. Possible values include:
        /// 'Incremental', 'Complete'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public DeploymentMode Mode { get; set; }

        /// <summary>
        /// Gets or sets the debug setting of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TemplateLink != null)
            {
                TemplateLink.Validate();
            }
            if (ParametersLink != null)
            {
                ParametersLink.Validate();
            }
        }
    }
}
