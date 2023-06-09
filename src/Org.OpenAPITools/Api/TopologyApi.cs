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
    public interface ITopologyApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the display group actions for a certain topology node
        /// </summary>
        /// <remarks>
        /// Get the display group actions for a certain topology node
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestActions</returns>
        PiRestActions TopologyActions(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);

        /// <summary>
        /// Get the display group actions for a certain topology node
        /// </summary>
        /// <remarks>
        /// Get the display group actions for a certain topology node
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestActions</returns>
        ApiResponse<PiRestActions> TopologyActionsWithHttpInfo(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);
        /// <summary>
        /// Returns the topology config of the fews system
        /// </summary>
        /// <remarks>
        /// Returns the topology config of the fews system.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestTopologyNodes</returns>
        PiRestTopologyNodes TopologyNodes(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);

        /// <summary>
        /// Returns the topology config of the fews system
        /// </summary>
        /// <remarks>
        /// Returns the topology config of the fews system.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestTopologyNodes</returns>
        ApiResponse<PiRestTopologyNodes> TopologyNodesWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITopologyApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the display group actions for a certain topology node
        /// </summary>
        /// <remarks>
        /// Get the display group actions for a certain topology node
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestActions</returns>
        System.Threading.Tasks.Task<PiRestActions> TopologyActionsAsync(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the display group actions for a certain topology node
        /// </summary>
        /// <remarks>
        /// Get the display group actions for a certain topology node
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestActions)</returns>
        System.Threading.Tasks.Task<ApiResponse<PiRestActions>> TopologyActionsWithHttpInfoAsync(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the topology config of the fews system
        /// </summary>
        /// <remarks>
        /// Returns the topology config of the fews system.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestTopologyNodes</returns>
        System.Threading.Tasks.Task<PiRestTopologyNodes> TopologyNodesAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the topology config of the fews system
        /// </summary>
        /// <remarks>
        /// Returns the topology config of the fews system.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestTopologyNodes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PiRestTopologyNodes>> TopologyNodesWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITopologyApi : ITopologyApiSync, ITopologyApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TopologyApi : ITopologyApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TopologyApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TopologyApi(string basePath)
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
        /// Initializes a new instance of the <see cref="TopologyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TopologyApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="TopologyApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TopologyApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Get the display group actions for a certain topology node Get the display group actions for a certain topology node
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestActions</returns>
        public PiRestActions TopologyActions(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestActions> localVarResponse = TopologyActionsWithHttpInfo(nodeId, timeZero, documentFormat, documentVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the display group actions for a certain topology node Get the display group actions for a certain topology node
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestActions</returns>
        public Org.OpenAPITools.Client.ApiResponse<PiRestActions> TopologyActionsWithHttpInfo(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
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

            if (nodeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "nodeId", nodeId));
            }
            if (timeZero != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "timeZero", timeZero));
            }
            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "TopologyApi.TopologyActions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PiRestActions>("/topology/actions", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TopologyActions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the display group actions for a certain topology node Get the display group actions for a certain topology node
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestActions</returns>
        public async System.Threading.Tasks.Task<PiRestActions> TopologyActionsAsync(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestActions> localVarResponse = await TopologyActionsWithHttpInfoAsync(nodeId, timeZero, documentFormat, documentVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the display group actions for a certain topology node Get the display group actions for a certain topology node
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nodeId">the id of the topology node (optional)</param>
        /// <param name="timeZero">the timezero for which the displaysgroups should be requested. If this parameter is omitted the time zero will be assumed equal to the current system time (optional)</param>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestActions)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PiRestActions>> TopologyActionsWithHttpInfoAsync(string nodeId = default(string), string timeZero = default(string), string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            if (nodeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "nodeId", nodeId));
            }
            if (timeZero != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "timeZero", timeZero));
            }
            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "TopologyApi.TopologyActions";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PiRestActions>("/topology/actions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TopologyActions", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the topology config of the fews system Returns the topology config of the fews system.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestTopologyNodes</returns>
        public PiRestTopologyNodes TopologyNodes(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestTopologyNodes> localVarResponse = TopologyNodesWithHttpInfo(documentFormat, documentVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the topology config of the fews system Returns the topology config of the fews system.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestTopologyNodes</returns>
        public Org.OpenAPITools.Client.ApiResponse<PiRestTopologyNodes> TopologyNodesWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
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

            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "TopologyApi.TopologyNodes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PiRestTopologyNodes>("/topology/nodes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TopologyNodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the topology config of the fews system Returns the topology config of the fews system.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestTopologyNodes</returns>
        public async System.Threading.Tasks.Task<PiRestTopologyNodes> TopologyNodesAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestTopologyNodes> localVarResponse = await TopologyNodesWithHttpInfoAsync(documentFormat, documentVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the topology config of the fews system Returns the topology config of the fews system.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestTopologyNodes)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PiRestTopologyNodes>> TopologyNodesWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            if (documentFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentFormat", documentFormat));
            }
            if (documentVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "documentVersion", documentVersion));
            }

            localVarRequestOptions.Operation = "TopologyApi.TopologyNodes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PiRestTopologyNodes>("/topology/nodes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TopologyNodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
