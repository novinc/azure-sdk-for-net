// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DataLakeAnalyticsAccountOperations operations.
    /// </summary>
    public partial interface IDataLakeAnalyticsAccountOperations
    {
        /// <summary>
        /// Gets the specified Azure storage account details in the specified
        /// Data Lake Analytics account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve the Azure storage account
        /// details from
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccount>> GetStorageAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account specified to remove the
        /// specified Azure Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to remove the Azure Storage
        /// account from
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to remove
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteStorageAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified storage account. This is currently only
        /// supported for Azure blob accounts to update their access keys and
        /// suffix.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to modify storage accounts in
        /// </param>
        /// <param name='storageAccountName'>
        /// The Azure Storage account to modify
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and suffix to update the
        /// storage account with.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> UpdateStorageAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account specified to include the
        /// additional Azure Storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to add the Azure Storage
        /// account to
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure Storage account to add
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the access key and optional suffix for
        /// the Azure Storage Account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> AddStorageAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, AddStorageAccountParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Azure Storage container object associated with
        /// the specified Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to retrieve blob
        /// container for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve the blob
        /// container from
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<BlobContainer>> GetStorageContainerWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Azure Storage containers object associated with the
        /// specified Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to retrieve blob
        /// containers for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve blob containers
        /// from
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BlobContainer>>> ListStorageContainersWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the next page of the Azure Storage Container objects within
        /// the specified Azure Storage account, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Azure Storage Container page.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BlobContainer>>> StorageContainersListNextWithHttpMessagesAsync(string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the next page of the SAS token objects within the specified
        /// Azure Storage account and container, if any.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next Azure Storage Container SAS token page.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> SasTokensListNextWithHttpMessagesAsync(string nextLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake
        /// Analytics and WASB storage account and container combination.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to get the SAS token
        /// for
        /// </param>
        /// <param name='storageAccountName'>
        /// The name of the Azure storage account to retrieve the blob
        /// container from
        /// </param>
        /// <param name='containerName'>
        /// The name of the Azure storage container to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> ListSasTokensWithHttpMessagesAsync(string resourceGroupName, string accountName, string storageAccountName, string containerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Store account details in the
        /// specified Data Lake Analytics account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve the Data Lake Store account
        /// details from
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeStoreAccount>> GetDataLakeStoreAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account specified to remove the
        /// specified Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to remove the Data Lake Store
        /// account from
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to remove
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteDataLakeStoreAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account specified to include the
        /// additional Data Lake Store account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The Data Lake Analytics account name to add the Data Lake Store
        /// account to
        /// </param>
        /// <param name='dataLakeStoreAccountName'>
        /// The name of the Data Lake Store account to add
        /// </param>
        /// <param name='parameters'>
        /// The parameters containing the optional properties associated with
        /// the named Data Lake account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> AddDataLakeStoreAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, string dataLakeStoreAccountName, AddDataLakeStoreParameters parameters = default(AddDataLakeStoreParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to list Storage
        /// accounts for.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='skip'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='expand'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='select'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='orderby'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='count'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='search'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='format'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<StorageAccount>>> ListStorageAccountsWithHttpMessagesAsync(string resourceGroupName, string accountName, Expression<Func<StorageAccount, bool>> filter = default(Expression<Func<StorageAccount, bool>>), int? top = default(int?), int? skip = default(int?), string expand = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Store account objects within
        /// the specified Data Lake Analytics account. This includes a link
        /// to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to list Data Lake
        /// Store accounts for.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='skip'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='expand'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='select'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='orderby'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='count'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='search'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='format'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListDataLakeStoreAccountsWithHttpMessagesAsync(string resourceGroupName, string accountName, Expression<Func<DataLakeStoreAccount, bool>> filter = default(Expression<Func<DataLakeStoreAccount, bool>>), int? top = default(int?), int? skip = default(int?), string expand = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='skip'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='expand'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='select'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='orderby'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='count'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='search'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='format'>
        /// Query parameters. If null is passed returns all account items.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeAnalyticsAccount>>> ListWithHttpMessagesAsync(string resourceGroupName, Expression<Func<DataLakeAnalyticsAccount, bool>> filter = default(Expression<Func<DataLakeAnalyticsAccount, bool>>), int? top = default(int?), int? skip = default(int?), string expand = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), string search = default(string), string format = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Data Lake Analytics account object specified by the
        /// account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to retrieve
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataLakeAnalyticsAccount>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the delete delete process for the Data Lake Analytics
        /// account object specified by the account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the delete delete process for the Data Lake Analytics
        /// account object specified by the account name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the creation process for the specified Data Lake Analytics
        /// account.This supplies the user with computation services for Data
        /// Lake Analytics workloads
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group the account will be associated with.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> CreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Begins the creation process for the specified Data Lake Analytics
        /// account.This supplies the user with computation services for Data
        /// Lake Analytics workloads
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group the account will be associated with.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the
        /// accountName with the contents of the account object.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> UpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the Data Lake Analytics account object specified by the
        /// accountName with the contents of the account object.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update Data Lake Analytics account
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string name, DataLakeAnalyticsAccountCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the Azure Storage containers object associated with the
        /// specified Data Lake Analytics and Azure Storage accounts.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BlobContainer>>> ListStorageContainersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the next page of the Azure Storage Container objects within
        /// the specified Azure Storage account, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<BlobContainer>>> StorageContainersListNextNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the next page of the SAS token objects within the specified
        /// Azure Storage account and container, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> SasTokensListNextNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the SAS token associated with the specified Data Lake
        /// Analytics and WASB storage account and container combination.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SasTokenInfo>>> ListSasTokensNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<StorageAccount>>> ListStorageAccountsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Store account objects within
        /// the specified Data Lake Analytics account. This includes a link
        /// to the next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeStoreAccount>>> ListDataLakeStoreAccountsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of the Data Lake Analytics account objects
        /// within the subscription or within a specific resource group. This
        /// includes a link to the next page, if any.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataLakeAnalyticsAccount>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
