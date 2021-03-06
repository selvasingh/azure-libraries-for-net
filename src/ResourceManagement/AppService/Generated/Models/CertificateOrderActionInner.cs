// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate order action.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CertificateOrderActionInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateOrderActionInner
        /// class.
        /// </summary>
        public CertificateOrderActionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateOrderActionInner
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="certificateOrderActionType">Action type. Possible
        /// values include: 'CertificateIssued', 'CertificateOrderCanceled',
        /// 'CertificateOrderCreated', 'CertificateRevoked',
        /// 'DomainValidationComplete', 'FraudDetected', 'OrgNameChange',
        /// 'OrgValidationComplete', 'SanDrop', 'FraudCleared',
        /// 'CertificateExpired', 'CertificateExpirationWarning',
        /// 'FraudDocumentationRequired', 'Unknown'</param>
        /// <param name="createdAt">Time at which the certificate action was
        /// performed.</param>
        public CertificateOrderActionInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), CertificateOrderActionType? certificateOrderActionType = default(CertificateOrderActionType?), System.DateTime? createdAt = default(System.DateTime?))
            : base(id, name, kind, type)
        {
            CertificateOrderActionType = certificateOrderActionType;
            CreatedAt = createdAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets action type. Possible values include:
        /// 'CertificateIssued', 'CertificateOrderCanceled',
        /// 'CertificateOrderCreated', 'CertificateRevoked',
        /// 'DomainValidationComplete', 'FraudDetected', 'OrgNameChange',
        /// 'OrgValidationComplete', 'SanDrop', 'FraudCleared',
        /// 'CertificateExpired', 'CertificateExpirationWarning',
        /// 'FraudDocumentationRequired', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public CertificateOrderActionType? CertificateOrderActionType { get; set; }

        /// <summary>
        /// Gets or sets time at which the certificate action was performed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; set; }

    }
}
