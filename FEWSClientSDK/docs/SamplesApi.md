# Org.OpenAPITools.Api.SamplesApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Samples**](SamplesApi.md#samples) | **GET** /samples | Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample |

<a name="samples"></a>
# **Samples**
> Object Samples (string filterId = null, List<string> sampleIds = null, List<string> locationIds = null, List<string> parameterIds = null, List<string> qualifierIds = null, DateTime? startTime = null, DateTime? endTime = null, DateTime? startCreationTime = null, DateTime? endCreationTime = null, string omitMissing = null, string onlyHeaders = null, string documentFormat = null, string documentVersion = null)

Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample

Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SamplesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SamplesApi(config);
            var filterId = "filterId_example";  // string | Filter Id (optional) 
            var sampleIds = new List<string>(); // List<string> | One or more sample ids (optional) 
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var parameterIds = new List<string>(); // List<string> | One or more parameter ids (optional) 
            var qualifierIds = new List<string>(); // List<string> | One or more qualifier ids (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var startCreationTime = 2020-03-18T15:00Z;  // DateTime? | Creation start time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endCreationTime = 2020-03-18T15:00Z;  // DateTime? | Creation end time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var omitMissing = "true";  // string | Toggle omitting or returning of missing values in response. (optional) 
            var onlyHeaders = "true";  // string | Toggle to return only header information or also data. (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample
                Object result = apiInstance.Samples(filterId, sampleIds, locationIds, parameterIds, qualifierIds, startTime, endTime, startCreationTime, endCreationTime, omitMissing, onlyHeaders, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SamplesApi.Samples: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SamplesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample
    ApiResponse<Object> response = apiInstance.SamplesWithHttpInfo(filterId, sampleIds, locationIds, parameterIds, qualifierIds, startTime, endTime, startCreationTime, endCreationTime, omitMissing, onlyHeaders, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SamplesApi.SamplesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | Filter Id | [optional]  |
| **sampleIds** | [**List&lt;string&gt;**](string.md) | One or more sample ids | [optional]  |
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **parameterIds** | [**List&lt;string&gt;**](string.md) | One or more parameter ids | [optional]  |
| **qualifierIds** | [**List&lt;string&gt;**](string.md) | One or more qualifier ids | [optional]  |
| **startTime** | **DateTime?** | Start time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTime** | **DateTime?** | End time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **startCreationTime** | **DateTime?** | Creation start time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endCreationTime** | **DateTime?** | Creation end time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **omitMissing** | **string** | Toggle omitting or returning of missing values in response. | [optional]  |
| **onlyHeaders** | **string** | Toggle to return only header information or also data. | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

