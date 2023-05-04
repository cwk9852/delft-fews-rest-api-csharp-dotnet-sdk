# Org.OpenAPITools.Api.QualifiersApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Qualifiers**](QualifiersApi.md#qualifiers) | **GET** /qualifiers | Get all configured qualifiers from the region config and optionally show all its attributes |

<a name="qualifiers"></a>
# **Qualifiers**
> Object Qualifiers (string showAttributes = null, string documentFormat = null, string documentVersion = null)

Get all configured qualifiers from the region config and optionally show all its attributes

Get all configured qualifiers from the region config and optionally show all its attributes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QualifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new QualifiersApi(config);
            var showAttributes = "true";  // string | Show attributes (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all configured qualifiers from the region config and optionally show all its attributes
                Object result = apiInstance.Qualifiers(showAttributes, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QualifiersApi.Qualifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QualifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all configured qualifiers from the region config and optionally show all its attributes
    ApiResponse<Object> response = apiInstance.QualifiersWithHttpInfo(showAttributes, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QualifiersApi.QualifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showAttributes** | **string** | Show attributes | [optional]  |
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

