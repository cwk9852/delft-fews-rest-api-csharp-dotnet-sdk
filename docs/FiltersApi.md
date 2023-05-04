# Org.OpenAPITools.Api.FiltersApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Filters**](FiltersApi.md#filters) | **GET** /filters | Get filters that are a subfilter of the default filter |
| [**FiltersActions**](FiltersApi.md#filtersactions) | **GET** /filters/actions | Get the actions for a set of filters |

<a name="filters"></a>
# **Filters**
> PiRestFilters Filters (string filterId = null, string documentFormat = null, string documentVersion = null)

Get filters that are a subfilter of the default filter

Get filters that are a subfilter of the default filter. An existing subfilter of the default filter id can be specified as well.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FiltersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FiltersApi(config);
            var filterId = "filterId_example";  // string | An existing subfilter of the default filter id (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get filters that are a subfilter of the default filter
                PiRestFilters result = apiInstance.Filters(filterId, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FiltersApi.Filters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FiltersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get filters that are a subfilter of the default filter
    ApiResponse<PiRestFilters> response = apiInstance.FiltersWithHttpInfo(filterId, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FiltersApi.FiltersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | An existing subfilter of the default filter id | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestFilters**](PiRestFilters.md)

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

<a name="filtersactions"></a>
# **FiltersActions**
> PiRestActions FiltersActions (string filterId = null, string parameterGroupId = null, string parameterIds = null, string timeZero = null, string documentFormat = null, string documentVersion = null)

Get the actions for a set of filters

Get the actions for a set of filters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FiltersActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FiltersApi(config);
            var filterId = "filterId_example";  // string | a filter id (optional) 
            var parameterGroupId = "parameterGroupId_example";  // string | a parameter group id, the time series in the filters will be filtered by using the defined parameter group id (optional) 
            var parameterIds = "parameterIds_example";  // string | one or more parameter ids, the time series in the filters will be filtered by using the defined parameter id (optional) 
            var timeZero = "timeZero_example";  // string | the timezero for which the actions should be requested. If this parameter is ommitted the time zero will be assumed equal to the current system time (optional) 
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the actions for a set of filters
                PiRestActions result = apiInstance.FiltersActions(filterId, parameterGroupId, parameterIds, timeZero, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FiltersApi.FiltersActions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FiltersActionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the actions for a set of filters
    ApiResponse<PiRestActions> response = apiInstance.FiltersActionsWithHttpInfo(filterId, parameterGroupId, parameterIds, timeZero, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FiltersApi.FiltersActionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | a filter id | [optional]  |
| **parameterGroupId** | **string** | a parameter group id, the time series in the filters will be filtered by using the defined parameter group id | [optional]  |
| **parameterIds** | **string** | one or more parameter ids, the time series in the filters will be filtered by using the defined parameter id | [optional]  |
| **timeZero** | **string** | the timezero for which the actions should be requested. If this parameter is ommitted the time zero will be assumed equal to the current system time | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestActions**](PiRestActions.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

