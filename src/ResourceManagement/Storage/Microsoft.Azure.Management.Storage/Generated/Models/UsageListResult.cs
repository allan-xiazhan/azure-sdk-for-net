// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The List Usages operation response.
    /// </summary>
    public partial class UsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        public UsageListResult() { }

        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        public UsageListResult(IList<Usage> value = default(IList<Usage>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list Storage Resource Usages.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Usage> Value { get; set; }

    }
}