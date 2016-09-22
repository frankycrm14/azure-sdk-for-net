// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Tag count.
    /// </summary>
    public partial class TagCount
    {
        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        public TagCount() { }

        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        /// <param name="type">Type of count.</param>
        /// <param name="value">Value of count.</param>
        public TagCount(string type = default(string), string value = default(string))
        {
            Type = type;
            Value = value;
        }

        /// <summary>
        /// Gets or sets type of count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets value of count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}