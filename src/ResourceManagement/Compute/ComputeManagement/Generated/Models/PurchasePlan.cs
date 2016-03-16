// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Used for establishing the purchase context of any 3rd Party artifact
    /// through MarketPlace.
    /// </summary>
    public partial class PurchasePlan
    {
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the plan ID.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _product;
        
        /// <summary>
        /// Required. Gets or sets the product ID.
        /// </summary>
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }
        
        private string _publisher;
        
        /// <summary>
        /// Required. Gets or sets the publisher ID.
        /// </summary>
        public string Publisher
        {
            get { return this._publisher; }
            set { this._publisher = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PurchasePlan class.
        /// </summary>
        public PurchasePlan()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the PurchasePlan class with required
        /// arguments.
        /// </summary>
        public PurchasePlan(string publisher, string name, string product)
            : this()
        {
            if (publisher == null)
            {
                throw new ArgumentNullException("publisher");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            this.Publisher = publisher;
            this.Name = name;
            this.Product = product;
        }
    }
}