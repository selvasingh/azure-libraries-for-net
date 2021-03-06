// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A backup long term retention policy
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupLongTermRetentionPolicyInner : ProxyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BackupLongTermRetentionPolicyInner class.
        /// </summary>
        public BackupLongTermRetentionPolicyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BackupLongTermRetentionPolicyInner class.
        /// </summary>
        /// <param name="state">The status of the backup long term retention
        /// policy. Possible values include: 'Disabled', 'Enabled'</param>
        /// <param name="recoveryServicesBackupPolicyResourceId">The azure
        /// recovery services backup protection policy resource id</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        public BackupLongTermRetentionPolicyInner(BackupLongTermRetentionPolicyState state, string recoveryServicesBackupPolicyResourceId, string location = default(string), string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            Location = location;
            State = state;
            RecoveryServicesBackupPolicyResourceId = recoveryServicesBackupPolicyResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets the status of the backup long term retention policy.
        /// Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public BackupLongTermRetentionPolicyState State { get; set; }

        /// <summary>
        /// Gets or sets the azure recovery services backup protection policy
        /// resource id
        /// </summary>
        [JsonProperty(PropertyName = "properties.recoveryServicesBackupPolicyResourceId")]
        public string RecoveryServicesBackupPolicyResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecoveryServicesBackupPolicyResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryServicesBackupPolicyResourceId");
            }
        }
    }
}
