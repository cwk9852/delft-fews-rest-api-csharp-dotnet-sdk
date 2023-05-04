/*
 * Delft-FEWS Web Services REST API v1
 *
 * Delft-FEWS Web Services REST API v1. For more information see: https://publicwiki.deltares.nl/x/fwNdBw
 *
 * The version of the OpenAPI document: v1-2023-05-03T00:04:18Z
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the warm state file for the specified module instance id and state time
        /// </summary>
        /// <remarks>
        /// Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        string Warmstates(string moduleInstanceId, DateTime stateTime, int operationIndex = 0);

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time
        /// </summary>
        /// <remarks>
        /// Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> WarmstatesWithHttpInfo(string moduleInstanceId, DateTime stateTime, int operationIndex = 0);
        /// <summary>
        /// Get all the available warm state times for the specified module instance ids
        /// </summary>
        /// <remarks>
        /// Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestWarmstateTimes</returns>
        PiRestWarmstateTimes WarmstatesTimes(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids
        /// </summary>
        /// <remarks>
        /// Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestWarmstateTimes</returns>
        ApiResponse<PiRestWarmstateTimes> WarmstatesTimesWithHttpInfo(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the warm state file for the specified module instance id and state time
        /// </summary>
        /// <remarks>
        /// Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> WarmstatesAsync(string moduleInstanceId, DateTime stateTime, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time
        /// </summary>
        /// <remarks>
        /// Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> WarmstatesWithHttpInfoAsync(string moduleInstanceId, DateTime stateTime, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get all the available warm state times for the specified module instance ids
        /// </summary>
        /// <remarks>
        /// Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestWarmstateTimes</returns>
        System.Threading.Tasks.Task<PiRestWarmstateTimes> WarmstatesTimesAsync(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids
        /// </summary>
        /// <remarks>
        /// Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestWarmstateTimes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PiRestWarmstateTimes>> WarmstatesTimesWithHttpInfoAsync(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatesApi : IStatesApiSync, IStatesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatesApi : IStatesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatesApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatesApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StatesApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>string</returns>
        public string Warmstates(string moduleInstanceId, DateTime stateTime, int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = WarmstatesWithHttpInfo(moduleInstanceId, stateTime);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of string</returns>
        public Org.OpenAPITools.Client.ApiResponse<string> WarmstatesWithHttpInfo(string moduleInstanceId, DateTime stateTime, int operationIndex = 0)
        {
            // verify the required parameter 'moduleInstanceId' is set
            if (moduleInstanceId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'moduleInstanceId' when calling StatesApi->Warmstates");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/zip",
                "plain/text"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "moduleInstanceId", moduleInstanceId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "stateTime", stateTime));

            localVarRequestOptions.Operation = "StatesApi.Warmstates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/warmstates", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Warmstates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> WarmstatesAsync(string moduleInstanceId, DateTime stateTime, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<string> localVarResponse = await WarmstatesWithHttpInfoAsync(moduleInstanceId, stateTime, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the warm state file for the specified module instance id and state time Get the warm state file for the specified module instance id and state time. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceId">Module instance id</param>
        /// <param name="stateTime">State time. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<string>> WarmstatesWithHttpInfoAsync(string moduleInstanceId, DateTime stateTime, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'moduleInstanceId' is set
            if (moduleInstanceId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'moduleInstanceId' when calling StatesApi->Warmstates");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/zip",
                "plain/text"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "moduleInstanceId", moduleInstanceId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "stateTime", stateTime));

            localVarRequestOptions.Operation = "StatesApi.Warmstates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/warmstates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Warmstates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestWarmstateTimes</returns>
        public PiRestWarmstateTimes WarmstatesTimes(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestWarmstateTimes> localVarResponse = WarmstatesTimesWithHttpInfo(moduleInstanceIds, documentFormat, documentVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestWarmstateTimes</returns>
        public Org.OpenAPITools.Client.ApiResponse<PiRestWarmstateTimes> WarmstatesTimesWithHttpInfo(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'moduleInstanceIds' is set
            if (moduleInstanceIds == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'moduleInstanceIds' when calling StatesApi->WarmstatesTimes");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "plain/text"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "moduleInstanceIds", moduleInstanceIds));
            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "StatesApi.WarmstatesTimes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PiRestWarmstateTimes>("/warmstates/times", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WarmstatesTimes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestWarmstateTimes</returns>
        public async System.Threading.Tasks.Task<PiRestWarmstateTimes> WarmstatesTimesAsync(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestWarmstateTimes> localVarResponse = await WarmstatesTimesWithHttpInfoAsync(moduleInstanceIds, documentFormat, documentVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the available warm state times for the specified module instance ids Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="moduleInstanceIds">One or more module instance ids</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestWarmstateTimes)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PiRestWarmstateTimes>> WarmstatesTimesWithHttpInfoAsync(List<string> moduleInstanceIds, string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'moduleInstanceIds' is set
            if (moduleInstanceIds == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'moduleInstanceIds' when calling StatesApi->WarmstatesTimes");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "plain/text"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("multi", "moduleInstanceIds", moduleInstanceIds));
            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "StatesApi.WarmstatesTimes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PiRestWarmstateTimes>("/warmstates/times", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WarmstatesTimes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
