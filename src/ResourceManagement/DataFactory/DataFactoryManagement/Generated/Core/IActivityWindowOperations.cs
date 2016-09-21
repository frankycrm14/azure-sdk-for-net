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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Core
{
    /// <summary>
    /// Operations for activity windows.
    /// </summary>
    public partial interface IActivityWindowOperations
    {
        /// <summary>
        /// Gets the first page of activity window instances for a data factory
        /// with the link to the next page.
        /// </summary>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListByDataFactoryAsync(ActivityWindowsByDataFactoryListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of activity window instances for a dataset with
        /// the link to the next page.
        /// </summary>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListByDatasetAsync(ActivityWindowsByDatasetListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// with the link to the next page.
        /// </summary>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListByPipelineAsync(ActivityWindowsByPipelineListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the first page of activity window instances for a pipeline
        /// activity with the link to the next page.
        /// </summary>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListByPipelineActivityAsync(ActivityWindowsByActivityListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListNextByDataFactoryAsync(string nextLink, ActivityWindowsByDataFactoryListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListNextByDatasetAsync(string nextLink, ActivityWindowsByDatasetListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListNextByPipelineAsync(string nextLink, ActivityWindowsByPipelineListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of activity window instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The URL to the next page of activity windows.
        /// </param>
        /// <param name='parameters'>
        /// Filter parameters for activity windows list.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List activity windows operation response.
        /// </returns>
        Task<ActivityWindowListResponse> ListNextByPipelineActivityAsync(string nextLink, ActivityWindowsByActivityListParameters parameters, CancellationToken cancellationToken);
    }
}