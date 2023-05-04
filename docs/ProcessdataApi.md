# Org.OpenAPITools.Api.ProcessdataApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Processdata**](ProcessdataApi.md#processdata) | **GET** /processdata | Run workflow and make processed netcdf data available as an attachment of type application/octet-stream |

<a name="processdata"></a>
# **Processdata**
> string Processdata (string workflowId = null, DateTime? startTime = null, DateTime? endTime = null, string xMin = null, string xMax = null, string yMin = null, string yMax = null, string xCellSize = null, string yCellSize = null, string deleteOutputFolder = null)

Run workflow and make processed netcdf data available as an attachment of type application/octet-stream

Run workflow and make processed netcdf data available as an attachment of type application/octet-stream. A property EXPORT_FOLDER_PROCESS_DATA should be configured in the global properties or in the webservice properties. The workflow indicated by the workflow id should export data to a folder EXPORT_FOLDER_PROCESS_DATA. Readonly mode has to be disabled in the FewsPiService.properties to allow this functionality.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProcessdataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProcessdataApi(config);
            var workflowId = "workflowId_example";  // string | Workflow Id (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var xMin = "xMin_example";  // string | x min (optional) 
            var xMax = "xMax_example";  // string | x max (optional) 
            var yMin = "yMin_example";  // string | y min (optional) 
            var yMax = "yMax_example";  // string | y max (optional) 
            var xCellSize = "xCellSize_example";  // string | x cell size (optional) 
            var yCellSize = "yCellSize_example";  // string | y cell size (optional) 
            var deleteOutputFolder = "true";  // string | Delte output folder (optional) 

            try
            {
                // Run workflow and make processed netcdf data available as an attachment of type application/octet-stream
                string result = apiInstance.Processdata(workflowId, startTime, endTime, xMin, xMax, yMin, yMax, xCellSize, yCellSize, deleteOutputFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessdataApi.Processdata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessdataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run workflow and make processed netcdf data available as an attachment of type application/octet-stream
    ApiResponse<string> response = apiInstance.ProcessdataWithHttpInfo(workflowId, startTime, endTime, xMin, xMax, yMin, yMax, xCellSize, yCellSize, deleteOutputFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessdataApi.ProcessdataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** | Workflow Id | [optional]  |
| **startTime** | **DateTime?** | Start time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTime** | **DateTime?** | End time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **xMin** | **string** | x min | [optional]  |
| **xMax** | **string** | x max | [optional]  |
| **yMin** | **string** | y min | [optional]  |
| **yMax** | **string** | y max | [optional]  |
| **xCellSize** | **string** | x cell size | [optional]  |
| **yCellSize** | **string** | y cell size | [optional]  |
| **deleteOutputFolder** | **string** | Delte output folder | [optional]  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

