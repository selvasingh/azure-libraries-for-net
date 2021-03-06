// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TagsOperations.
    /// </summary>
    public static partial class TagsOperationsExtensions
    {

        /// <summary>
        /// Delete a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteValueAsync(this ITagsOperations operations, string tagName, string tagValue, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Create a subscription resource tag value.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='tagValue'>
        /// The value of the tag.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<TagValueInner> CreateOrUpdateValueAsync(this ITagsOperations operations, string tagName, string tagValue, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateValueWithHttpMessagesAsync(tagName, tagValue, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Create a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<TagDetailsInner> CreateOrUpdateAsync(this ITagsOperations operations, string tagName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Delete a subscription resource tag.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='tagName'>
        /// The name of the tag.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this ITagsOperations operations, string tagName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(tagName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<TagDetailsInner>> ListAsync(this ITagsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Get a list of subscription resource tags.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<TagDetailsInner>> ListNextAsync(this ITagsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
