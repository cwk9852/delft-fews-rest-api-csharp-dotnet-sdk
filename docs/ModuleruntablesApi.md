# Org.OpenAPITools.Api.ModuleruntablesApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ModuleruntablesCurrent**](ModuleruntablesApi.md#moduleruntablescurrent) | **GET** /moduleruntables/current | Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId |

<a name="moduleruntablescurrent"></a>
# **ModuleruntablesCurrent**
> string ModuleruntablesCurrent (string moduleInstanceId = null, string taskRunId = null)

Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId

Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModuleruntablesCurrentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ModuleruntablesApi(config);
            var moduleInstanceId = "moduleInstanceId_example";  // string | Module instance id of the module run table to retrieve (optional) 
            var taskRunId = "taskRunId_example";  // string | Task run id of the task run to retrieve (optional) 

            try
            {
                // Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId
                string result = apiInstance.ModuleruntablesCurrent(moduleInstanceId, taskRunId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModuleruntablesApi.ModuleruntablesCurrent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModuleruntablesCurrentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId
    ApiResponse<string> response = apiInstance.ModuleruntablesCurrentWithHttpInfo(moduleInstanceId, taskRunId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModuleruntablesApi.ModuleruntablesCurrentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moduleInstanceId** | **string** | Module instance id of the module run table to retrieve | [optional]  |
| **taskRunId** | **string** | Task run id of the task run to retrieve | [optional]  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/csv, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

