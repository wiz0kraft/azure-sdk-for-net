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
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataFactories.Core.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// The List tables operation response.
    /// </summary>
    public partial class TableListResponse : AzureOperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Required. The link (url) to the next page of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<Table> _tables;
        
        /// <summary>
        /// Optional. A list of the returned table instances.
        /// </summary>
        public IList<Table> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TableListResponse class.
        /// </summary>
        public TableListResponse()
        {
            this.Tables = new LazyList<Table>();
        }
        
        /// <summary>
        /// Initializes a new instance of the TableListResponse class with
        /// required arguments.
        /// </summary>
        public TableListResponse(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}