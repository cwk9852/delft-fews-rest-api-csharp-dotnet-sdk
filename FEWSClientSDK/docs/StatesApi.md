# Org.OpenAPITools.Api.StatesApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Warmstates**](StatesApi.md#warmstates) | **GET** /warmstates | Get the warm state file for the specified module instance id and state time |
| [**WarmstatesTimes**](StatesApi.md#warmstatestimes) | **GET** /warmstates/times | Get all the available warm state times for the specified module instance ids |

<a name="warmstates"></a>
# **Warmstates**
> string Warmstates (string moduleInstanceId, DateTime stateTime)

Get the warm state file for the specified module instance id and state time

Get the warm state file for the specified module instance id and state time. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WarmstatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatesApi(config);
            var moduleInstanceId = "moduleInstanceId_example";  // string | Module instance id
            var stateTime = 2020-03-18T15:00Z;  // DateTime | State time. Format: yyyy-MM-ddTHH:mm:ssZ

            try
            {
                // Get the warm state file for the specified module instance id and state time
                string result = apiInstance.Warmstates(moduleInstanceId, stateTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatesApi.Warmstates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarmstatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the warm state file for the specified module instance id and state time
    ApiResponse<string> response = apiInstance.WarmstatesWithHttpInfo(moduleInstanceId, stateTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatesApi.WarmstatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moduleInstanceId** | **string** | Module instance id |  |
| **stateTime** | **DateTime** | State time. Format: yyyy-MM-ddTHH:mm:ssZ |  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/zip, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="warmstatestimes"></a>
# **WarmstatesTimes**
> PiRestWarmstateTimes WarmstatesTimes (List<string> moduleInstanceIds, string documentFormat = null, string documentVersion = null)

Get all the available warm state times for the specified module instance ids

Get all the available warm state times for the specified module instance ids. The module instance id is used to retrieve the current taskrun. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class WarmstatesTimesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatesApi(config);
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all the available warm state times for the specified module instance ids
                PiRestWarmstateTimes result = apiInstance.WarmstatesTimes(moduleInstanceIds, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatesApi.WarmstatesTimes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WarmstatesTimesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all the available warm state times for the specified module instance ids
    ApiResponse<PiRestWarmstateTimes> response = apiInstance.WarmstatesTimesWithHttpInfo(moduleInstanceIds, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatesApi.WarmstatesTimesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids |  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestWarmstateTimes**](PiRestWarmstateTimes.md)

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

