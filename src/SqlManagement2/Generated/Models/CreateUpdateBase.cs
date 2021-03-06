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
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    public partial class CreateUpdateBase
    {
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets the location of the resource.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Required. Gets or sets the tags associated with the request.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CreateUpdateBase class.
        /// </summary>
        public CreateUpdateBase()
        {
            this.Tags = new Dictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the CreateUpdateBase class with
        /// required arguments.
        /// </summary>
        public CreateUpdateBase(string location, IDictionary<string, string> tags)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            if (tags == null)
            {
                throw new ArgumentNullException("tags");
            }
            this.Location = location;
            this.Tags = tags;
        }
    }
}
