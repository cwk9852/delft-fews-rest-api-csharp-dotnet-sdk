# Org.OpenAPITools.Api.ParametersApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Parameters**](ParametersApi.md#parameters) | **GET** /parameters | Get parameters that are available for the &#39;filterId&#39; argument |
| [**ParametersNodes**](ParametersApi.md#parametersnodes) | **GET** /parameters/nodes | Get all parameter nodes and its parameters that are available in the region config |

<a name="parameters"></a>
# **Parameters**
> PiRestParameters Parameters (string filterId = null, string showAttributes = null, string documentFormat = null, string documentVersion = null)

Get parameters that are available for the 'filterId' argument

Get parameters that are available for the 'filterId' argument. Parameters are also returned if no time series are available for a parameter in the filter. If no filterId is passed then all parameters configured in the pre-defined filter will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ParametersApi(config);
            var filterId = "filterId_example";  // string | An existing subfilter of the default filter id (optional) 
            var showAttributes = "true";  // string | Show parameter attributes (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get parameters that are available for the 'filterId' argument
                PiRestParameters result = apiInstance.Parameters(filterId, showAttributes, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParametersApi.Parameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get parameters that are available for the 'filterId' argument
    ApiResponse<PiRestParameters> response = apiInstance.ParametersWithHttpInfo(filterId, showAttributes, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParametersApi.ParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | An existing subfilter of the default filter id | [optional]  |
| **showAttributes** | **string** | Show parameter attributes | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestParameters**](PiRestParameters.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parametersnodes"></a>
# **ParametersNodes**
> PiRestParametersNodes ParametersNodes (string documentFormat = null, string documentVersion = null)

Get all parameter nodes and its parameters that are available in the region config

Get all parameter nodes and its parameters that are available in the region config. For each parameterNode the parent node, children nodes and all parameter ids are provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ParametersNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ParametersApi(config);
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all parameter nodes and its parameters that are available in the region config
                PiRestParametersNodes result = apiInstance.ParametersNodes(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ParametersApi.ParametersNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParametersNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all parameter nodes and its parameters that are available in the region config
    ApiResponse<PiRestParametersNodes> response = apiInstance.ParametersNodesWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ParametersApi.ParametersNodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestParametersNodes**](PiRestParametersNodes.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

