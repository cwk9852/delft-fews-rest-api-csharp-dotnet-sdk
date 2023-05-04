# Org.OpenAPITools.Api.ModifiersApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Modifiers**](ModifiersApi.md#modifiers) | **GET** /modifiers | Get modifiers filtered by parameters like start time, end time and modifier type |
| [**Postmodifiers**](ModifiersApi.md#postmodifiers) | **POST** /modifiers | Write modifiers to the Delft-FEWS database |
| [**Timeseriesmodifiers**](ModifiersApi.md#timeseriesmodifiers) | **GET** /timeseriesmodifiers | Get timeseries modifiers filtered by parameters like start time, end time and modifier type |

<a name="modifiers"></a>
# **Modifiers**
> Object Modifiers (DateTime? startTimeModifiers = null, DateTime? endTimeModifiers = null, string modifierType = null, string documentFormat = null, string documentVersion = null)

Get modifiers filtered by parameters like start time, end time and modifier type

Get modifiers filtered by parameters like start time, end time and modifier type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ModifiersApi(config);
            var startTimeModifiers = 2020-03-18T15:00Z;  // DateTime? | Start time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTimeModifiers = 2020-03-18T15:00Z;  // DateTime? | End time modifiers (optional) 
            var modifierType = "modifierType_example";  // string | Modifier Type (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get modifiers filtered by parameters like start time, end time and modifier type
                Object result = apiInstance.Modifiers(startTimeModifiers, endTimeModifiers, modifierType, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModifiersApi.Modifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get modifiers filtered by parameters like start time, end time and modifier type
    ApiResponse<Object> response = apiInstance.ModifiersWithHttpInfo(startTimeModifiers, endTimeModifiers, modifierType, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModifiersApi.ModifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTimeModifiers** | **DateTime?** | Start time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTimeModifiers** | **DateTime?** | End time modifiers | [optional]  |
| **modifierType** | **string** | Modifier Type | [optional]  |
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

<a name="postmodifiers"></a>
# **Postmodifiers**
> Object Postmodifiers (string commitModifiers = null, string deleteAllModifiers = null, string piModifiersXmlContent = null)

Write modifiers to the Delft-FEWS database

Write modifiers to the Delft-FEWS database. The application/x-www-form-urlencoded encoding has to be used. Readonly mode has to be disabled in the FewsPiService.properties to allow this functionality.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostmodifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ModifiersApi(config);
            var commitModifiers = "true";  // string | Commit modifiers (optional) 
            var deleteAllModifiers = "true";  // string | Delete all modifiers (optional) 
            var piModifiersXmlContent = "piModifiersXmlContent_example";  // string | https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_modifiers.xsd (optional) 

            try
            {
                // Write modifiers to the Delft-FEWS database
                Object result = apiInstance.Postmodifiers(commitModifiers, deleteAllModifiers, piModifiersXmlContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModifiersApi.Postmodifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostmodifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Write modifiers to the Delft-FEWS database
    ApiResponse<Object> response = apiInstance.PostmodifiersWithHttpInfo(commitModifiers, deleteAllModifiers, piModifiersXmlContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModifiersApi.PostmodifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **commitModifiers** | **string** | Commit modifiers | [optional]  |
| **deleteAllModifiers** | **string** | Delete all modifiers | [optional]  |
| **piModifiersXmlContent** | **string** | https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_modifiers.xsd | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

<a name="timeseriesmodifiers"></a>
# **Timeseriesmodifiers**
> Object Timeseriesmodifiers (DateTime? startTimeModifiers = null, DateTime? endTimeModifiers = null, string modifierType = null, string userId = null, List<string> locationIds = null, List<string> moduleInstanceIds = null, string onlyActiveModifiers = null, string userDefinedModifierDescription = null, string documentFormat = null, string documentVersion = null)

Get timeseries modifiers filtered by parameters like start time, end time and modifier type

Get timeseries modifiers filtered by parameters like start time, end time and modifier type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeseriesmodifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ModifiersApi(config);
            var startTimeModifiers = 2020-03-18T15:00Z;  // DateTime? | Start time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTimeModifiers = 2020-03-18T15:00Z;  // DateTime? | End time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var modifierType = "modifierType_example";  // string | Modifier Type (optional) 
            var userId = "userId_example";  // string | User Id (optional) 
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids (optional) 
            var onlyActiveModifiers = "true";  // string | Only Active Modifiers (optional) 
            var userDefinedModifierDescription = "userDefinedModifierDescription_example";  // string | User Defined Modifier Description (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get timeseries modifiers filtered by parameters like start time, end time and modifier type
                Object result = apiInstance.Timeseriesmodifiers(startTimeModifiers, endTimeModifiers, modifierType, userId, locationIds, moduleInstanceIds, onlyActiveModifiers, userDefinedModifierDescription, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModifiersApi.Timeseriesmodifiers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeseriesmodifiersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get timeseries modifiers filtered by parameters like start time, end time and modifier type
    ApiResponse<Object> response = apiInstance.TimeseriesmodifiersWithHttpInfo(startTimeModifiers, endTimeModifiers, modifierType, userId, locationIds, moduleInstanceIds, onlyActiveModifiers, userDefinedModifierDescription, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModifiersApi.TimeseriesmodifiersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTimeModifiers** | **DateTime?** | Start time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTimeModifiers** | **DateTime?** | End time modifiers. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **modifierType** | **string** | Modifier Type | [optional]  |
| **userId** | **string** | User Id | [optional]  |
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids | [optional]  |
| **onlyActiveModifiers** | **string** | Only Active Modifiers | [optional]  |
| **userDefinedModifierDescription** | **string** | User Defined Modifier Description | [optional]  |
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

