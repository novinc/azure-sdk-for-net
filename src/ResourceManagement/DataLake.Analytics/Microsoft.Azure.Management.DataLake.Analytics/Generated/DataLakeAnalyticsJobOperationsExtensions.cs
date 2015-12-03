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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class DataLakeAnalyticsJobOperationsExtensions
    {
            /// <summary>
            /// Gets the job statistics object specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static JobStatistics GetStatistics(this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).GetStatisticsAsync(accountName, jobIdentity, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the job statistics object specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobStatistics> GetStatisticsAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<JobStatistics> result = await operations.GetStatisticsWithHttpMessagesAsync(accountName, jobIdentity, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the U-SQL job debug data information specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static JobDataPath GetDebugDataPath(this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).GetDebugDataPathAsync(accountName, jobIdentity, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the U-SQL job debug data information specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDataPath> GetDebugDataPathAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<JobDataPath> result = await operations.GetDebugDataPathWithHttpMessagesAsync(accountName, jobIdentity, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Builds (compiles) the specified job in the specified Data Lake Analytics
            /// account for job correctness and validation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to build the job for
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to build a job, which simulates submission.
            /// </param>
            public static JobInformation Build(this IDataLakeAnalyticsJobOperations operations, string accountName, string resourceGroupName, JobInfoBuildOrCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).BuildAsync(accountName, resourceGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Builds (compiles) the specified job in the specified Data Lake Analytics
            /// account for job correctness and validation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to build the job for
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to build a job, which simulates submission.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> BuildAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string resourceGroupName, JobInfoBuildOrCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<JobInformation> result = await operations.BuildWithHttpMessagesAsync(accountName, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Submits the specified job to the specified Data Lake Analytics account for
            /// computation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to create the job for
            /// </param>
            /// <param name='jobId'>
            /// The parameters to submit a job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to submit a job.
            /// </param>
            public static JobInformation Create(this IDataLakeAnalyticsJobOperations operations, string accountName, string jobId, string resourceGroupName, JobInfoBuildOrCreateParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).CreateAsync(accountName, jobId, resourceGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits the specified job to the specified Data Lake Analytics account for
            /// computation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to create the job for
            /// </param>
            /// <param name='jobId'>
            /// The parameters to submit a job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to submit a job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> CreateAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string jobId, string resourceGroupName, JobInfoBuildOrCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<JobInformation> result = await operations.CreateWithHttpMessagesAsync(accountName, jobId, resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Cancels the running job specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to cancel the job for
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID to cancel.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static void Cancel(this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName)
            {
                Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).CancelAsync(accountName, jobIdentity, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the running job specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to cancel the job for
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID to cancel.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CancelWithHttpMessagesAsync(accountName, jobIdentity, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the JobInfo object specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static JobInformation Get(this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).GetAsync(accountName, jobIdentity, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the JobInfo object specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> GetAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string jobIdentity, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<JobInformation> result = await operations.GetWithHttpMessagesAsync(accountName, jobIdentity, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the first page of the Data Lake Analytics JobInformation objects
            /// within the specified resource group with a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='skip'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='orderby'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='select'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            public static IPage<JobInformation> List(this IDataLakeAnalyticsJobOperations operations, string accountName, string resourceGroupName, Expression<Func<JobInformation, bool>> filter = default(Expression<Func<JobInformation, bool>>), int? top = default(int?), int? skip = default(int?), string orderby = default(string), string select = default(string))
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).ListAsync(accountName, resourceGroupName, filter, top, skip, orderby, select), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of the Data Lake Analytics JobInformation objects
            /// within the specified resource group with a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Data Lake Analytics account to get the job from
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='skip'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='orderby'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='select'>
            /// Query parameters. If null is passed returns all JobInfo items.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobInformation>> ListAsync( this IDataLakeAnalyticsJobOperations operations, string accountName, string resourceGroupName, Expression<Func<JobInformation, bool>> filter = default(Expression<Func<JobInformation, bool>>), int? top = default(int?), int? skip = default(int?), string orderby = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<JobInformation>> result = await operations.ListWithHttpMessagesAsync(accountName, resourceGroupName, filter, top, skip, orderby, select, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the first page of the Data Lake Analytics JobInformation objects
            /// within the specified resource group with a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<JobInformation> ListNext(this IDataLakeAnalyticsJobOperations operations, string nextPageLink, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IDataLakeAnalyticsJobOperations)s).ListNextAsync(nextPageLink, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the first page of the Data Lake Analytics JobInformation objects
            /// within the specified resource group with a link to the next page, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobInformation>> ListNextAsync( this IDataLakeAnalyticsJobOperations operations, string nextPageLink, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IPage<JobInformation>> result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
