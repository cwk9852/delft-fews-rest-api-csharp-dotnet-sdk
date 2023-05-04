# Org.OpenAPITools.Api.LocationsApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Locations**](LocationsApi.md#locations) | **GET** /locations | Get locations that are available for the &#39;filterId&#39; argument |

<a name="locations"></a>
# **Locations**
> PiRestLocations Locations (string filterId = null, string parameterIds = null, string parameterGroupId = null, string showAttributes = null, string includeLocationRelations = null, string includeTimeDependency = null, string documentFormat = null, string documentVersion = null)

Get locations that are available for the 'filterId' argument

Get locations that are available for the 'filterId' argument. Locations are also returned if no time series are available for a location in the filter. If not filterId is passed then all locations configured in the pre-defined filter will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new LocationsApi(config);
            var filterId = "filterId_example";  // string | An existing subfilter of the default filter id (optional) 
            var parameterIds = "parameterIds_example";  // string | One or more parameters which will be used to filter the time series sets in the filter (optional) 
            var parameterGroupId = "parameterGroupId_example";  // string | The parameter group id which will be used to filter the time series sets in the filter (optional) 
            var showAttributes = "true";  // string | Show location attributes (optional) 
            var includeLocationRelations = "true";  // string | Include location relations (optional) 
            var includeTimeDependency = "true";  // string | Include time depency (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, GEO_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get locations that are available for the 'filterId' argument
                PiRestLocations result = apiInstance.Locations(filterId, parameterIds, parameterGroupId, showAttributes, includeLocationRelations, includeTimeDependency, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationsApi.Locations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get locations that are available for the 'filterId' argument
    ApiResponse<PiRestLocations> response = apiInstance.LocationsWithHttpInfo(filterId, parameterIds, parameterGroupId, showAttributes, includeLocationRelations, includeTimeDependency, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LocationsApi.LocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | An existing subfilter of the default filter id | [optional]  |
| **parameterIds** | **string** | One or more parameters which will be used to filter the time series sets in the filter | [optional]  |
| **parameterGroupId** | **string** | The parameter group id which will be used to filter the time series sets in the filter | [optional]  |
| **showAttributes** | **string** | Show location attributes | [optional]  |
| **includeLocationRelations** | **string** | Include location relations | [optional]  |
| **includeTimeDependency** | **string** | Include time depency | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, GEO_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestLocations**](PiRestLocations.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/geojson, application/xml, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

