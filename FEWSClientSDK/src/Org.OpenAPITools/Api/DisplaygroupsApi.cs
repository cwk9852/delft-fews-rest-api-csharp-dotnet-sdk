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
    public interface IDisplaygroupsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all displaygroups nodes and its plots
        /// </summary>
        /// <remarks>
        /// Get all displaygroups nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestDisplaygroupsNodes</returns>
        PiRestDisplaygroupsNodes DisplaygroupsNodes(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);

        /// <summary>
        /// Get all displaygroups nodes and its plots
        /// </summary>
        /// <remarks>
        /// Get all displaygroups nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestDisplaygroupsNodes</returns>
        ApiResponse<PiRestDisplaygroupsNodes> DisplaygroupsNodesWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);
        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot
        /// </summary>
        /// <remarks>
        /// Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream DisplaygroupsPlot(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0);

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot
        /// </summary>
        /// <remarks>
        /// Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> DisplaygroupsPlotWithHttpInfo(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDisplaygroupsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all displaygroups nodes and its plots
        /// </summary>
        /// <remarks>
        /// Get all displaygroups nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestDisplaygroupsNodes</returns>
        System.Threading.Tasks.Task<PiRestDisplaygroupsNodes> DisplaygroupsNodesAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all displaygroups nodes and its plots
        /// </summary>
        /// <remarks>
        /// Get all displaygroups nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestDisplaygroupsNodes)</returns>
        System.Threading.Tasks.Task<ApiResponse<PiRestDisplaygroupsNodes>> DisplaygroupsNodesWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot
        /// </summary>
        /// <remarks>
        /// Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> DisplaygroupsPlotAsync(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot
        /// </summary>
        /// <remarks>
        /// Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> DisplaygroupsPlotWithHttpInfoAsync(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDisplaygroupsApi : IDisplaygroupsApiSync, IDisplaygroupsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DisplaygroupsApi : IDisplaygroupsApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplaygroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DisplaygroupsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplaygroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DisplaygroupsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="DisplaygroupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DisplaygroupsApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DisplaygroupsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DisplaygroupsApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Get all displaygroups nodes and its plots Get all displaygroups nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestDisplaygroupsNodes</returns>
        public PiRestDisplaygroupsNodes DisplaygroupsNodes(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestDisplaygroupsNodes> localVarResponse = DisplaygroupsNodesWithHttpInfo(documentFormat, documentVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all displaygroups nodes and its plots Get all displaygroups nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestDisplaygroupsNodes</returns>
        public Org.OpenAPITools.Client.ApiResponse<PiRestDisplaygroupsNodes> DisplaygroupsNodesWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "DisplaygroupsApi.DisplaygroupsNodes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PiRestDisplaygroupsNodes>("/displaygroups/nodes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DisplaygroupsNodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all displaygroups nodes and its plots Get all displaygroups nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestDisplaygroupsNodes</returns>
        public async System.Threading.Tasks.Task<PiRestDisplaygroupsNodes> DisplaygroupsNodesAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestDisplaygroupsNodes> localVarResponse = await DisplaygroupsNodesWithHttpInfoAsync(documentFormat, documentVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all displaygroups nodes and its plots Get all displaygroups nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestDisplaygroupsNodes)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PiRestDisplaygroupsNodes>> DisplaygroupsNodesWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "DisplaygroupsApi.DisplaygroupsNodes";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PiRestDisplaygroupsNodes>("/displaygroups/nodes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DisplaygroupsNodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream DisplaygroupsPlot(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<System.IO.Stream> localVarResponse = DisplaygroupsPlotWithHttpInfo(displayGroupId, displayId, startTime, endTime, width, height);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public Org.OpenAPITools.Client.ApiResponse<System.IO.Stream> DisplaygroupsPlotWithHttpInfo(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0)
        {
            // verify the required parameter 'displayGroupId' is set
            if (displayGroupId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'displayGroupId' when calling DisplaygroupsApi->DisplaygroupsPlot");
            }

            // verify the required parameter 'displayId' is set
            if (displayId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'displayId' when calling DisplaygroupsApi->DisplaygroupsPlot");
            }

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/png",
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

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "displayGroupId", displayGroupId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "displayId", displayId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            if (width != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "width", width));
            }
            if (height != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "height", height));
            }

            localVarRequestOptions.Operation = "DisplaygroupsApi.DisplaygroupsPlot";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/displaygroups/plot", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DisplaygroupsPlot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> DisplaygroupsPlotAsync(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<System.IO.Stream> localVarResponse = await DisplaygroupsPlotWithHttpInfoAsync(displayGroupId, displayId, startTime, endTime, width, height, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a plot image from a display group using the display group id and the display id of the plot Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="displayGroupId">the displayGroupId of where the plot is configured.</param>
        /// <param name="displayId">The displayId of a plot node.</param>
        /// <param name="startTime">Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="endTime">End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ</param>
        /// <param name="width">the width of the plot in pixels. Default 1080 (optional)</param>
        /// <param name="height">the height of the plot in pixels. Default 720 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<System.IO.Stream>> DisplaygroupsPlotWithHttpInfoAsync(string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = default(decimal?), decimal? height = default(decimal?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'displayGroupId' is set
            if (displayGroupId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'displayGroupId' when calling DisplaygroupsApi->DisplaygroupsPlot");
            }

            // verify the required parameter 'displayId' is set
            if (displayId == null)
            {
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'displayId' when calling DisplaygroupsApi->DisplaygroupsPlot");
            }


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "image/png",
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

            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "displayGroupId", displayGroupId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "displayId", displayId));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            if (width != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "width", width));
            }
            if (height != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "height", height));
            }

            localVarRequestOptions.Operation = "DisplaygroupsApi.DisplaygroupsPlot";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/displaygroups/plot", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DisplaygroupsPlot", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
