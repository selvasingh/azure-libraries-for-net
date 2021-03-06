// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CosmosDB;
    using Microsoft.Azure.Management.CosmosDB.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The consistency policy for the DocumentDB database account.
    /// </summary>
    public partial class ConsistencyPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ConsistencyPolicy class.
        /// </summary>
        public ConsistencyPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsistencyPolicy class.
        /// </summary>
        /// <param name="defaultConsistencyLevel">The default consistency level
        /// and configuration settings of the DocumentDB account. Possible
        /// values include: 'Eventual', 'Session', 'BoundedStaleness',
        /// 'Strong', 'ConsistentPrefix'</param>
        /// <param name="maxStalenessPrefix">When used with the Bounded
        /// Staleness consistency level, this value represents the number of
        /// stale requests tolerated. Accepted range for this value is 1 –
        /// 2,147,483,647. Required when defaultConsistencyPolicy is set to
        /// 'BoundedStaleness'.</param>
        /// <param name="maxIntervalInSeconds">When used with the Bounded
        /// Staleness consistency level, this value represents the time amount
        /// of staleness (in seconds) tolerated. Accepted range for this value
        /// is 1 - 100. Required when defaultConsistencyPolicy is set to
        /// 'BoundedStaleness'.</param>
        public ConsistencyPolicy(DefaultConsistencyLevel defaultConsistencyLevel, long? maxStalenessPrefix = default(long?), int? maxIntervalInSeconds = default(int?))
        {
            DefaultConsistencyLevel = defaultConsistencyLevel;
            MaxStalenessPrefix = maxStalenessPrefix;
            MaxIntervalInSeconds = maxIntervalInSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the default consistency level and configuration
        /// settings of the DocumentDB account. Possible values include:
        /// 'Eventual', 'Session', 'BoundedStaleness', 'Strong',
        /// 'ConsistentPrefix'
        /// </summary>
        [JsonProperty(PropertyName = "defaultConsistencyLevel")]
        public DefaultConsistencyLevel DefaultConsistencyLevel { get; set; }

        /// <summary>
        /// Gets or sets when used with the Bounded Staleness consistency
        /// level, this value represents the number of stale requests
        /// tolerated. Accepted range for this value is 1 – 2,147,483,647.
        /// Required when defaultConsistencyPolicy is set to
        /// 'BoundedStaleness'.
        /// </summary>
        [JsonProperty(PropertyName = "maxStalenessPrefix")]
        public long? MaxStalenessPrefix { get; set; }

        /// <summary>
        /// Gets or sets when used with the Bounded Staleness consistency
        /// level, this value represents the time amount of staleness (in
        /// seconds) tolerated. Accepted range for this value is 1 - 100.
        /// Required when defaultConsistencyPolicy is set to
        /// 'BoundedStaleness'.
        /// </summary>
        [JsonProperty(PropertyName = "maxIntervalInSeconds")]
        public int? MaxIntervalInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxStalenessPrefix > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxStalenessPrefix", 2147483647);
            }
            if (MaxStalenessPrefix < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxStalenessPrefix", 1);
            }
            if (MaxIntervalInSeconds > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxIntervalInSeconds", 100);
            }
            if (MaxIntervalInSeconds < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxIntervalInSeconds", 1);
            }
        }
    }
}
