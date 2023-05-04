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
    public interface IWebocApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the Web OC Configuration
        /// </summary>
        /// <remarks>
        /// Get the Web OC Configuration
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestWebocConfiguration</returns>
        PiRestWebocConfiguration WebocConfig(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);

        /// <summary>
        /// Get the Web OC Configuration
        /// </summary>
        /// <remarks>
        /// Get the Web OC Configuration
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestWebocConfiguration</returns>
        ApiResponse<PiRestWebocConfiguration> WebocConfigWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebocApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the Web OC Configuration
        /// </summary>
        /// <remarks>
        /// Get the Web OC Configuration
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestWebocConfiguration</returns>
        System.Threading.Tasks.Task<PiRestWebocConfiguration> WebocConfigAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the Web OC Configuration
        /// </summary>
        /// <remarks>
        /// Get the Web OC Configuration
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestWebocConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<PiRestWebocConfiguration>> WebocConfigWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebocApi : IWebocApiSync, IWebocApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebocApi : IWebocApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebocApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebocApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebocApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebocApi(string basePath)
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
        /// Initializes a new instance of the <see cref="WebocApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebocApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WebocApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WebocApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Get the Web OC Configuration Get the Web OC Configuration
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>PiRestWebocConfiguration</returns>
        public PiRestWebocConfiguration WebocConfig(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestWebocConfiguration> localVarResponse = WebocConfigWithHttpInfo(documentFormat, documentVersion);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Web OC Configuration Get the Web OC Configuration
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of PiRestWebocConfiguration</returns>
        public Org.OpenAPITools.Client.ApiResponse<PiRestWebocConfiguration> WebocConfigWithHttpInfo(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0)
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

            localVarRequestOptions.Operation = "WebocApi.WebocConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PiRestWebocConfiguration>("/weboc/config", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WebocConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the Web OC Configuration Get the Web OC Configuration
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PiRestWebocConfiguration</returns>
        public async System.Threading.Tasks.Task<PiRestWebocConfiguration> WebocConfigAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PiRestWebocConfiguration> localVarResponse = await WebocConfigWithHttpInfoAsync(documentFormat, documentVersion, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Web OC Configuration Get the Web OC Configuration
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentFormat">Supported Document Format: PI_JSON,  (optional)</param>
        /// <param name="documentVersion">Document Version. Latest version is: 1.33 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PiRestWebocConfiguration)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PiRestWebocConfiguration>> WebocConfigWithHttpInfoAsync(string documentFormat = default(string), string documentVersion = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "WebocApi.WebocConfig";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<PiRestWebocConfiguration>("/weboc/config", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WebocConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}