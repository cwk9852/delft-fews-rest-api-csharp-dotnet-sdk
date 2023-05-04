# Org.OpenAPITools.Api.EmbeddedApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FiltersSelected**](EmbeddedApi.md#filtersselected) | **GET** /filters/selected | Get the currently selected filter ids in the Operator Client or a Stand Alone |
| [**Lastupdatetime**](EmbeddedApi.md#lastupdatetime) | **GET** /lastupdatetime | Get the last time the timeseries were updated in the Operator Client or a Stand Alone |
| [**LocationsSelected**](EmbeddedApi.md#locationsselected) | **GET** /locations/selected | Get the currently selected location ids in the Operator Client or a Stand Alone |
| [**ParametersSelected**](EmbeddedApi.md#parametersselected) | **GET** /parameters/selected | Get the currently selected parameter ids in the Operator Client or a Stand Alone |
| [**TimeseriesTopologyNode**](EmbeddedApi.md#timeseriestopologynode) | **GET** /timeseries/topology/node | Get the time series for the selected topology node |
| [**TopologySelected**](EmbeddedApi.md#topologyselected) | **GET** /topology/selected | Get the currently selected topology node id in the Operator Client or a Stand Alone |

<a name="filtersselected"></a>
# **FiltersSelected**
> PiRestFiltersSelected FiltersSelected (string documentFormat = null, string documentVersion = null)

Get the currently selected filter ids in the Operator Client or a Stand Alone

Get the currently selected filter ids in the Operator Client or a Stand Alone. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FiltersSelectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the currently selected filter ids in the Operator Client or a Stand Alone
                PiRestFiltersSelected result = apiInstance.FiltersSelected(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.FiltersSelected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FiltersSelectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the currently selected filter ids in the Operator Client or a Stand Alone
    ApiResponse<PiRestFiltersSelected> response = apiInstance.FiltersSelectedWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.FiltersSelectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestFiltersSelected**](PiRestFiltersSelected.md)

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

<a name="lastupdatetime"></a>
# **Lastupdatetime**
> string Lastupdatetime (string documentFormat = null, string documentVersion = null)

Get the last time the timeseries were updated in the Operator Client or a Stand Alone

Get the last time the timeseries were updated in the Operator Client or a Stand Alone. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LastupdatetimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the last time the timeseries were updated in the Operator Client or a Stand Alone
                string result = apiInstance.Lastupdatetime(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.Lastupdatetime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LastupdatetimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the last time the timeseries were updated in the Operator Client or a Stand Alone
    ApiResponse<string> response = apiInstance.LastupdatetimeWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.LastupdatetimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationsselected"></a>
# **LocationsSelected**
> PiRestLocationsSelected LocationsSelected (string documentFormat = null, string documentVersion = null)

Get the currently selected location ids in the Operator Client or a Stand Alone

Get the currently selected location ids in the Operator Client or a Stand Alone. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationsSelectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the currently selected location ids in the Operator Client or a Stand Alone
                PiRestLocationsSelected result = apiInstance.LocationsSelected(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.LocationsSelected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LocationsSelectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the currently selected location ids in the Operator Client or a Stand Alone
    ApiResponse<PiRestLocationsSelected> response = apiInstance.LocationsSelectedWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.LocationsSelectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestLocationsSelected**](PiRestLocationsSelected.md)

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

<a name="parametersselected"></a>
# **ParametersSelected**
> PiRestParametersSelected ParametersSelected (string documentFormat = null, string documentVersion = null)

Get the currently selected parameter ids in the Operator Client or a Stand Alone

Get the currently selected parameter ids in the Operator Client or a Stand Alone. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ParametersSelectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the currently selected parameter ids in the Operator Client or a Stand Alone
                PiRestParametersSelected result = apiInstance.ParametersSelected(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.ParametersSelected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ParametersSelectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the currently selected parameter ids in the Operator Client or a Stand Alone
    ApiResponse<PiRestParametersSelected> response = apiInstance.ParametersSelectedWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.ParametersSelectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestParametersSelected**](PiRestParametersSelected.md)

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

<a name="timeseriestopologynode"></a>
# **TimeseriesTopologyNode**
> PiRestTimeseries TimeseriesTopologyNode (string topologyNodeId = null, DateTime? timeZero = null, DateTime? startTime = null, DateTime? endTime = null, string thresholdsVisible = null, string omitMissing = null, string useDisplayUnits = null, string convertDatum = null, string documentFormat = null, string documentVersion = null)

Get the time series for the selected topology node

Get the time series for the selected topology node. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeseriesTopologyNodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var topologyNodeId = myNodeId;  // string | Id of the topology node for which the time series will be returned. (optional) 
            var timeZero = 2020-03-18T15:00Z;  // DateTime? |  time zero in format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Optional startTime for the requested period in format: yyyy-MM-ddTHH:mm:ssZ. If not set, the start time of the zoom period in the first time series dialog will be used. (optional) 
            var endTime = 2020-03-19T15:00Z;  // DateTime? | Optional endTime for the requested period in format: yyyy-MM-ddTHH:mm:ssZ. If not set, the end time of the zoom period in the first time series dialog will be used. (optional) 
            var thresholdsVisible = true;  // string | Set to true to make thresholds visible. (optional) 
            var omitMissing = "true";  // string | Toggle omitting or returning of missing values in response. Default is true (optional) 
            var useDisplayUnits = "true";  // string | Set to true to use display units (optional) 
            var convertDatum = "true";  // string | Set to true to convert datum (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the time series for the selected topology node
                PiRestTimeseries result = apiInstance.TimeseriesTopologyNode(topologyNodeId, timeZero, startTime, endTime, thresholdsVisible, omitMissing, useDisplayUnits, convertDatum, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.TimeseriesTopologyNode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeseriesTopologyNodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the time series for the selected topology node
    ApiResponse<PiRestTimeseries> response = apiInstance.TimeseriesTopologyNodeWithHttpInfo(topologyNodeId, timeZero, startTime, endTime, thresholdsVisible, omitMissing, useDisplayUnits, convertDatum, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.TimeseriesTopologyNodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **topologyNodeId** | **string** | Id of the topology node for which the time series will be returned. | [optional]  |
| **timeZero** | **DateTime?** |  time zero in format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **startTime** | **DateTime?** | Optional startTime for the requested period in format: yyyy-MM-ddTHH:mm:ssZ. If not set, the start time of the zoom period in the first time series dialog will be used. | [optional]  |
| **endTime** | **DateTime?** | Optional endTime for the requested period in format: yyyy-MM-ddTHH:mm:ssZ. If not set, the end time of the zoom period in the first time series dialog will be used. | [optional]  |
| **thresholdsVisible** | **string** | Set to true to make thresholds visible. | [optional]  |
| **omitMissing** | **string** | Toggle omitting or returning of missing values in response. Default is true | [optional]  |
| **useDisplayUnits** | **string** | Set to true to use display units | [optional]  |
| **convertDatum** | **string** | Set to true to convert datum | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestTimeseries**](PiRestTimeseries.md)

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

<a name="topologyselected"></a>
# **TopologySelected**
> PiRestTopologySelected TopologySelected (string documentFormat = null, string documentVersion = null)

Get the currently selected topology node id in the Operator Client or a Stand Alone

Get the currently selected topology node id in the Operator Client or a Stand Alone. Only supported when running as a embedded tomcat service in the Operator Client or in a Stand Alone. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TopologySelectedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EmbeddedApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the currently selected topology node id in the Operator Client or a Stand Alone
                PiRestTopologySelected result = apiInstance.TopologySelected(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmbeddedApi.TopologySelected: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TopologySelectedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the currently selected topology node id in the Operator Client or a Stand Alone
    ApiResponse<PiRestTopologySelected> response = apiInstance.TopologySelectedWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmbeddedApi.TopologySelectedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestTopologySelected**](PiRestTopologySelected.md)

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

