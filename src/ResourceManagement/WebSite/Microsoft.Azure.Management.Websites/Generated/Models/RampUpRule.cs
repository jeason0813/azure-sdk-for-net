// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Routing rules for ramp up testing. This rule allows to redirect static
    /// traffic % to a slot or to gradually change routing % based on
    /// performance
    /// </summary>
    public partial class RampUpRule
    {
        /// <summary>
        /// Initializes a new instance of the RampUpRule class.
        /// </summary>
        public RampUpRule() { }

        /// <summary>
        /// Initializes a new instance of the RampUpRule class.
        /// </summary>
        public RampUpRule(string actionHostName = default(string), double? reroutePercentage = default(double?), double? changeStep = default(double?), int? changeIntervalInMinutes = default(int?), double? minReroutePercentage = default(double?), double? maxReroutePercentage = default(double?), string changeDecisionCallbackUrl = default(string), string name = default(string))
        {
            ActionHostName = actionHostName;
            ReroutePercentage = reroutePercentage;
            ChangeStep = changeStep;
            ChangeIntervalInMinutes = changeIntervalInMinutes;
            MinReroutePercentage = minReroutePercentage;
            MaxReroutePercentage = maxReroutePercentage;
            ChangeDecisionCallbackUrl = changeDecisionCallbackUrl;
            Name = name;
        }

        /// <summary>
        /// Hostname of a slot to which the traffic will be redirected if
        /// decided to. E.g. mysite-stage.azurewebsites.net
        /// </summary>
        [JsonProperty(PropertyName = "actionHostName")]
        public string ActionHostName { get; set; }

        /// <summary>
        /// Percentage of the traffic which will be redirected to
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.ActionHostName}
        /// </summary>
        [JsonProperty(PropertyName = "reroutePercentage")]
        public double? ReroutePercentage { get; set; }

        /// <summary>
        /// [Optional] In auto ramp up scenario this is the step to to
        /// add/remove from
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.ReroutePercentage}
        /// until it reaches
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.MinReroutePercentage}
        /// or
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.MaxReroutePercentage}.
        /// Site metrics are checked every N minutes specificed in
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.ChangeIntervalInMinutes}.
        /// Custom decision algorithm can be provided in
        /// TiPCallback site extension which Url can be specified in
        /// {Microsoft.Web.Hosting.Administration.RampUpRule.ChangeDecisionCallbackUrl}
        /// </summary>
        [JsonProperty(PropertyName = "changeStep")]
        public double? ChangeStep { get; set; }

        /// <summary>
        /// [Optional] Specifies interval in mimuntes to reevaluate
        /// ReroutePercentage
        /// </summary>
        [JsonProperty(PropertyName = "changeIntervalInMinutes")]
        public int? ChangeIntervalInMinutes { get; set; }

        /// <summary>
        /// [Optional] Specifies lower boundary above which ReroutePercentage
        /// will stay.
        /// </summary>
        [JsonProperty(PropertyName = "minReroutePercentage")]
        public double? MinReroutePercentage { get; set; }

        /// <summary>
        /// [Optional] Specifies upper boundary below which ReroutePercentage
        /// will stay.
        /// </summary>
        [JsonProperty(PropertyName = "maxReroutePercentage")]
        public double? MaxReroutePercentage { get; set; }

        /// <summary>
        /// Custom decision algorithm can be provided in TiPCallback site
        /// extension which Url can be specified. See TiPCallback site
        /// extension for the scaffold and contracts.
        /// https://www.siteextensions.net/packages/TiPCallback/
        /// </summary>
        [JsonProperty(PropertyName = "changeDecisionCallbackUrl")]
        public string ChangeDecisionCallbackUrl { get; set; }

        /// <summary>
        /// Name of the routing rule. The recommended name would be to point
        /// to the slot which will receive the traffic in the experiment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
