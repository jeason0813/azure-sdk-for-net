// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies the retention policy for the log.
    /// </summary>
    public partial class RetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        public RetentionPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        /// <param name="enabled">a value indicating whether the retention
        /// policy is enabled.</param>
        /// <param name="days">the number of days for the retention in days. A
        /// value of 0 will retain the events indefinitely.</param>
        public RetentionPolicy(bool enabled, int days)
        {
            Enabled = enabled;
            Days = days;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether the retention policy is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the number of days for the retention in days. A value
        /// of 0 will retain the events indefinitely.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public int Days { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Days < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Days", 0);
            }
        }
    }
}