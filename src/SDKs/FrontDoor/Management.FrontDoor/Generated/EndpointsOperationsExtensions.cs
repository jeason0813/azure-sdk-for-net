// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EndpointsOperations.
    /// </summary>
    public static partial class EndpointsOperationsExtensions
    {
            /// <summary>
            /// Removes a content from Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can be a full URL, e.g.
            /// '/pictures/city.png' which removes a single file, or a directory with a
            /// wildcard, e.g. '/pictures/*' which removes all folders and files in the
            /// directory.
            /// </param>
            public static void PurgeContent(this IEndpointsOperations operations, string resourceGroupName, string frontDoorName, PurgeParameters contentFilePaths)
            {
                operations.PurgeContentAsync(resourceGroupName, frontDoorName, contentFilePaths).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a content from Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can be a full URL, e.g.
            /// '/pictures/city.png' which removes a single file, or a directory with a
            /// wildcard, e.g. '/pictures/*' which removes all folders and files in the
            /// directory.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeContentAsync(this IEndpointsOperations operations, string resourceGroupName, string frontDoorName, PurgeParameters contentFilePaths, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeContentWithHttpMessagesAsync(resourceGroupName, frontDoorName, contentFilePaths, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Removes a content from Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can be a full URL, e.g.
            /// '/pictures/city.png' which removes a single file, or a directory with a
            /// wildcard, e.g. '/pictures/*' which removes all folders and files in the
            /// directory.
            /// </param>
            public static void BeginPurgeContent(this IEndpointsOperations operations, string resourceGroupName, string frontDoorName, PurgeParameters contentFilePaths)
            {
                operations.BeginPurgeContentAsync(resourceGroupName, frontDoorName, contentFilePaths).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a content from Front Door.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='frontDoorName'>
            /// Name of the Front Door which is globally unique.
            /// </param>
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can be a full URL, e.g.
            /// '/pictures/city.png' which removes a single file, or a directory with a
            /// wildcard, e.g. '/pictures/*' which removes all folders and files in the
            /// directory.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeContentAsync(this IEndpointsOperations operations, string resourceGroupName, string frontDoorName, PurgeParameters contentFilePaths, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeContentWithHttpMessagesAsync(resourceGroupName, frontDoorName, contentFilePaths, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}