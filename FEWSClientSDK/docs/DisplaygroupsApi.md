# Org.OpenAPITools.Api.DisplaygroupsApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DisplaygroupsNodes**](DisplaygroupsApi.md#displaygroupsnodes) | **GET** /displaygroups/nodes | Get all displaygroups nodes and its plots |
| [**DisplaygroupsPlot**](DisplaygroupsApi.md#displaygroupsplot) | **GET** /displaygroups/plot | Get a plot image from a display group using the display group id and the display id of the plot |

<a name="displaygroupsnodes"></a>
# **DisplaygroupsNodes**
> PiRestDisplaygroupsNodes DisplaygroupsNodes (string documentFormat = null, string documentVersion = null)

Get all displaygroups nodes and its plots

Get all displaygroups nodes and its plots.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DisplaygroupsNodesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisplaygroupsApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all displaygroups nodes and its plots
                PiRestDisplaygroupsNodes result = apiInstance.DisplaygroupsNodes(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplaygroupsApi.DisplaygroupsNodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisplaygroupsNodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all displaygroups nodes and its plots
    ApiResponse<PiRestDisplaygroupsNodes> response = apiInstance.DisplaygroupsNodesWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplaygroupsApi.DisplaygroupsNodesWithHttpInfo: " + e.Message);
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

[**PiRestDisplaygroupsNodes**](PiRestDisplaygroupsNodes.md)

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

<a name="displaygroupsplot"></a>
# **DisplaygroupsPlot**
> System.IO.Stream DisplaygroupsPlot (string displayGroupId, string displayId, DateTime startTime, DateTime endTime, decimal? width = null, decimal? height = null)

Get a plot image from a display group using the display group id and the display id of the plot

Get a plot image from a display group using the display group id and the display id of the plot. The displaygroups/nodes and topology/nodes endpoint report all supported nodes and its plots.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DisplaygroupsPlotExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DisplaygroupsApi(config);
            var displayGroupId = "displayGroupId_example";  // string | the displayGroupId of where the plot is configured.
            var displayId = "displayId_example";  // string | The displayId of a plot node.
            var startTime = 2020-03-18T15:00Z;  // DateTime | Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ
            var endTime = 2020-03-18T15:00Z;  // DateTime | End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ
            var width = 8.9M;  // decimal? | the width of the plot in pixels. Default 1080 (optional) 
            var height = 8.9M;  // decimal? | the height of the plot in pixels. Default 720 (optional) 

            try
            {
                // Get a plot image from a display group using the display group id and the display id of the plot
                System.IO.Stream result = apiInstance.DisplaygroupsPlot(displayGroupId, displayId, startTime, endTime, width, height);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplaygroupsApi.DisplaygroupsPlot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisplaygroupsPlotWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a plot image from a display group using the display group id and the display id of the plot
    ApiResponse<System.IO.Stream> response = apiInstance.DisplaygroupsPlotWithHttpInfo(displayGroupId, displayId, startTime, endTime, width, height);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplaygroupsApi.DisplaygroupsPlotWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayGroupId** | **string** | the displayGroupId of where the plot is configured. |  |
| **displayId** | **string** | The displayId of a plot node. |  |
| **startTime** | **DateTime** | Start time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **endTime** | **DateTime** | End time of the view period. Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **width** | **decimal?** | the width of the plot in pixels. Default 1080 | [optional]  |
| **height** | **decimal?** | the height of the plot in pixels. Default 720 | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

