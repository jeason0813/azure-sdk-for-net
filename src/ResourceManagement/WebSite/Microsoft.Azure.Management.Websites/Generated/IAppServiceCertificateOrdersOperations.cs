// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AppServiceCertificateOrdersOperations operations.
    /// </summary>
    public partial interface IAppServiceCertificateOrdersOperations
    {
        /// <summary>
        /// Lists all domains in a subscription
        /// </summary>
        /// Lists all domains in a subscription
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validate certificate purchase information
        /// </summary>
        /// Validate certificate purchase information
        /// <param name='appServiceCertificateOrder'>
        /// Certificate order
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> ValidatePurchaseInformationWithHttpMessagesAsync(AppServiceCertificateOrder appServiceCertificateOrder, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group
        /// </summary>
        /// Get certificate orders in a resource group
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order (only
        /// one certificate can be associated with an order at a time)
        /// </summary>
        /// List all certificates associated with a certificate order (only
        /// one certificate can be associated with an order at a time)
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='certificateOrderName'>
        /// Certificate name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificate>>> ListCertificatesWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get certificate associated with the certificate order
        /// </summary>
        /// Get certificate associated with the certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='certificateOrderName'>
        /// Certificate name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificate>> GetCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Associates a Key Vault secret to a certificate store that will be
        /// used for storing the certificate once it's ready
        /// </summary>
        /// Associates a Key Vault secret to a certificate store that will be
        /// used for storing the certificate once it's ready
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='certificateOrderName'>
        /// Certificate name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key Vault secret csm Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificate>> CreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificate keyVaultCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Associates a Key Vault secret to a certificate store that will be
        /// used for storing the certificate once it's ready
        /// </summary>
        /// Associates a Key Vault secret to a certificate store that will be
        /// used for storing the certificate once it's ready
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='certificateOrderName'>
        /// Certificate name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='keyVaultCertificate'>
        /// Key Vault secret csm Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificate>> BeginCreateOrUpdateCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, AppServiceCertificate keyVaultCertificate, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the certificate associated with the certificate order
        /// </summary>
        /// Deletes the certificate associated with the certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='certificateOrderName'>
        /// Certificate name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> DeleteCertificateWithHttpMessagesAsync(string resourceGroupName, string certificateOrderName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a certificate order
        /// </summary>
        /// Get a certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> GetWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order
        /// </summary>
        /// Create or update a certificate purchase order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to be used for purchasing certificate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, AppServiceCertificateOrder certificateDistinguishedName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a certificate purchase order
        /// </summary>
        /// Create or update a certificate purchase order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='certificateDistinguishedName'>
        /// Distinguished name to be used for purchasing certificate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AppServiceCertificateOrder>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, AppServiceCertificateOrder certificateDistinguishedName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing certificate order
        /// </summary>
        /// Delete an existing certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> DeleteCertificateOrderWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reissue an existing certificate order
        /// </summary>
        /// Reissue an existing certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='reissueCertificateOrderRequest'>
        /// Reissue parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> ReissueWithHttpMessagesAsync(string resourceGroupName, string name, ReissueCertificateOrderRequest reissueCertificateOrderRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Renew an existing certificate order
        /// </summary>
        /// Renew an existing certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate name
        /// </param>
        /// <param name='renewCertificateOrderRequest'>
        /// Renew parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> RenewWithHttpMessagesAsync(string resourceGroupName, string name, RenewCertificateOrderRequest renewCertificateOrderRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Resend certificate email
        /// </summary>
        /// Resend certificate email
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> ResendCertificateEmailWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve the list of certificate actions
        /// </summary>
        /// Retrieve the list of certificate actions
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<CertificateOrderAction>>> RetrieveCertificateActionsWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrive email history
        /// </summary>
        /// Retrive email history
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IList<CertificateEmail>>> RetrieveCertificateEmailHistoryWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Verify domain ownership for this certificate order
        /// </summary>
        /// Verify domain ownership for this certificate order
        /// <param name='resourceGroupName'>
        /// Azure resource group name
        /// </param>
        /// <param name='name'>
        /// Certificate order name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> VerifyDomainOwnershipWithHttpMessagesAsync(string resourceGroupName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all domains in a subscription
        /// </summary>
        /// Lists all domains in a subscription
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get certificate orders in a resource group
        /// </summary>
        /// Get certificate orders in a resource group
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificateOrder>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all certificates associated with a certificate order (only
        /// one certificate can be associated with an order at a time)
        /// </summary>
        /// List all certificates associated with a certificate order (only
        /// one certificate can be associated with an order at a time)
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AppServiceCertificate>>> ListCertificatesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
