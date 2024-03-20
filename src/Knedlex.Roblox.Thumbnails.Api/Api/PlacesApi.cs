/*
 * Thumbnails Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Knedlex.Roblox.Thumbnails.Api.Client;
using Knedlex.Roblox.Thumbnails.Api.Model;

namespace Knedlex.Roblox.Thumbnails.Api.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlacesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out.
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse V1PlacesGameiconsGet(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1PlacesGameiconsGetWithHttpInfo(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlacesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1PlacesGameiconsGetAsync(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>> V1PlacesGameiconsGetWithHttpInfoAsync(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPlacesApi : IPlacesApiSync, IPlacesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PlacesApi : IPlacesApi
    {
        private Knedlex.Roblox.Thumbnails.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlacesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlacesApi(string basePath)
        {
            this.Configuration = Knedlex.Roblox.Thumbnails.Api.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Thumbnails.Api.Client.GlobalConfiguration.Instance,
                new Knedlex.Roblox.Thumbnails.Api.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Knedlex.Roblox.Thumbnails.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Thumbnails.Api.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Knedlex.Roblox.Thumbnails.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PlacesApi(Knedlex.Roblox.Thumbnails.Api.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Knedlex.Roblox.Thumbnails.Api.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Thumbnails.Api.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Knedlex.Roblox.Thumbnails.Api.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Thumbnails.Api.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Knedlex.Roblox.Thumbnails.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlacesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PlacesApi(Knedlex.Roblox.Thumbnails.Api.Client.ISynchronousClient client, Knedlex.Roblox.Thumbnails.Api.Client.IAsynchronousClient asyncClient, Knedlex.Roblox.Thumbnails.Api.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Knedlex.Roblox.Thumbnails.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Knedlex.Roblox.Thumbnails.Api.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Knedlex.Roblox.Thumbnails.Api.Client.ISynchronousClient Client { get; set; }

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
        public Knedlex.Roblox.Thumbnails.Api.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Knedlex.Roblox.Thumbnails.Api.Client.ExceptionFactory ExceptionFactory
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
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse V1PlacesGameiconsGet(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0)
        {
            Knedlex.Roblox.Thumbnails.Api.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> localVarResponse = V1PlacesGameiconsGetWithHttpInfo(placeIds, returnPolicy, size, format, isCircular);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public Knedlex.Roblox.Thumbnails.Api.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1PlacesGameiconsGetWithHttpInfo(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0)
        {
            // verify the required parameter 'placeIds' is set
            if (placeIds == null)
            {
                throw new Knedlex.Roblox.Thumbnails.Api.Client.ApiException(400, "Missing required parameter 'placeIds' when calling PlacesApi->V1PlacesGameiconsGet");
            }

            Knedlex.Roblox.Thumbnails.Api.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Thumbnails.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("csv", "placeIds", placeIds));
            if (returnPolicy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "returnPolicy", returnPolicy));
            }
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (isCircular != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "isCircular", isCircular));
            }

            localVarRequestOptions.Operation = "PlacesApi.V1PlacesGameiconsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>("/v1/places/gameicons", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1PlacesGameiconsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse</returns>
        public async System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> V1PlacesGameiconsGetAsync(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Knedlex.Roblox.Thumbnails.Api.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse> localVarResponse = await V1PlacesGameiconsGetWithHttpInfoAsync(placeIds, returnPolicy, size, format, isCircular, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Fetches game icon URLs for a list of places. Ids that do not correspond to a valid place will be filtered out. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Thumbnails.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="placeIds">The place ids.</param>
        /// <param name="returnPolicy">Optional policy to use in selecting game icon to return (default &#x3D; PlaceHolder). (optional, default to PlaceHolder)</param>
        /// <param name="size">The thumbnail size, formatted widthxheight (optional, default to 50x50)</param>
        /// <param name="format">The thumbnail format (optional, default to Png)</param>
        /// <param name="isCircular">The circle thumbnail output parameter, true or false (optional, default to false)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse)</returns>
        public async System.Threading.Tasks.Task<Knedlex.Roblox.Thumbnails.Api.Client.ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>> V1PlacesGameiconsGetWithHttpInfoAsync(List<long> placeIds, string returnPolicy = default(string), string size = default(string), string format = default(string), bool? isCircular = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'placeIds' is set
            if (placeIds == null)
            {
                throw new Knedlex.Roblox.Thumbnails.Api.Client.ApiException(400, "Missing required parameter 'placeIds' when calling PlacesApi->V1PlacesGameiconsGet");
            }


            Knedlex.Roblox.Thumbnails.Api.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Thumbnails.Api.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("csv", "placeIds", placeIds));
            if (returnPolicy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "returnPolicy", returnPolicy));
            }
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (format != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "format", format));
            }
            if (isCircular != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Thumbnails.Api.Client.ClientUtils.ParameterToMultiMap("", "isCircular", isCircular));
            }

            localVarRequestOptions.Operation = "PlacesApi.V1PlacesGameiconsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RobloxWebWebAPIModelsApiArrayResponseRobloxWebResponsesThumbnailsThumbnailResponse>("/v1/places/gameicons", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1PlacesGameiconsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
