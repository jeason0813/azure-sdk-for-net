// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// One property of operation, include metric specifications.
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification() { }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        /// <param name="metricSpecifications">Metric specifications of
        /// operation.</param>
        public ServiceSpecification(IList<MetricSpecification> metricSpecifications = default(IList<MetricSpecification>))
        {
            MetricSpecifications = metricSpecifications;
        }

        /// <summary>
        /// Gets or sets metric specifications of operation.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<MetricSpecification> MetricSpecifications { get; set; }

    }
}
