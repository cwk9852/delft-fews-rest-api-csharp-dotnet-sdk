# Org.OpenAPITools.Api.ArchiveApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ArchiveAreas**](ArchiveApi.md#archiveareas) | **GET** /archive/areas | Returns the available areas for the open archive, netcdf-storage and the archive database |
| [**ArchiveAttributes**](ArchiveApi.md#archiveattributes) | **GET** /archive/attributes | Get attributes with their values that are available in the archive |
| [**ArchiveLocations**](ArchiveApi.md#archivelocations) | **GET** /archive/locations | Get locations that are available in the archive |
| [**ArchiveModuleinstances**](ArchiveApi.md#archivemoduleinstances) | **GET** /archive/moduleinstances | Returns the available module instaces for the netcdf storage |
| [**ArchiveNetcdfstorageforecasts**](ArchiveApi.md#archivenetcdfstorageforecasts) | **GET** /archive/netcdfstorageforecasts | Get forecasts with its attributes from the external netcdf storage from the archive |
| [**ArchiveParameters**](ArchiveApi.md#archiveparameters) | **GET** /archive/parameters | Get parameters that are available in the archive |
| [**ArchiveProducts**](ArchiveApi.md#archiveproducts) | **GET** /archive/products | Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters |
| [**ArchiveProductsId**](ArchiveApi.md#archiveproductsid) | **GET** /archive/products/id | Return a specific product from the archive |
| [**ArchiveProductsmetadata**](ArchiveApi.md#archiveproductsmetadata) | **GET** /archive/productsmetadata | Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime |
| [**ArchiveSources**](ArchiveApi.md#archivesources) | **GET** /archive/sources | Returns the available sources for the open archive, netcdf-storage and the archive database |
| [**PostArchiveProducts**](ArchiveApi.md#postarchiveproducts) | **POST** /archive/products | upload new products to the archive |

<a name="archiveareas"></a>
# **ArchiveAreas**
> PiRestArchiveAreas ArchiveAreas (string documentFormat = null, string documentVersion = null)

Returns the available areas for the open archive, netcdf-storage and the archive database

Returns the available areas for the open archive, netcdf-storage and the archive database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveAreasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Returns the available areas for the open archive, netcdf-storage and the archive database
                PiRestArchiveAreas result = apiInstance.ArchiveAreas(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveAreas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveAreasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the available areas for the open archive, netcdf-storage and the archive database
    ApiResponse<PiRestArchiveAreas> response = apiInstance.ArchiveAreasWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveAreasWithHttpInfo: " + e.Message);
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

[**PiRestArchiveAreas**](PiRestArchiveAreas.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archiveattributes"></a>
# **ArchiveAttributes**
> PiRestArchiveAttributes ArchiveAttributes (string parameterIds = null, string locationIds = null, List<string> moduleInstanceIds = null, List<string> areaIds = null, List<string> sourceIds = null, List<string> attributes = null, string documentFormat = null, string documentVersion = null)

Get attributes with their values that are available in the archive

Get attributes with their values that are available in the archive. Optionally the attributes can be filtered by one or more attribute keys, a parameter ids or a location id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var parameterIds = "parameterIds_example";  // string | Parameter ids (optional) 
            var locationIds = "locationIds_example";  // string | Location ids (optional) 
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids (optional) 
            var areaIds = new List<string>(); // List<string> | One or more area ids (optional) 
            var sourceIds = new List<string>(); // List<string> | One or more source ids (optional) 
            var attributes = new List<string>(); // List<string> | One or more attributes (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get attributes with their values that are available in the archive
                PiRestArchiveAttributes result = apiInstance.ArchiveAttributes(parameterIds, locationIds, moduleInstanceIds, areaIds, sourceIds, attributes, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get attributes with their values that are available in the archive
    ApiResponse<PiRestArchiveAttributes> response = apiInstance.ArchiveAttributesWithHttpInfo(parameterIds, locationIds, moduleInstanceIds, areaIds, sourceIds, attributes, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parameterIds** | **string** | Parameter ids | [optional]  |
| **locationIds** | **string** | Location ids | [optional]  |
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids | [optional]  |
| **areaIds** | [**List&lt;string&gt;**](string.md) | One or more area ids | [optional]  |
| **sourceIds** | [**List&lt;string&gt;**](string.md) | One or more source ids | [optional]  |
| **attributes** | [**List&lt;string&gt;**](string.md) | One or more attributes | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestArchiveAttributes**](PiRestArchiveAttributes.md)

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

<a name="archivelocations"></a>
# **ArchiveLocations**
> ArchiveLocations200Response ArchiveLocations (List<string> parameterIds = null, List<string> moduleInstanceIds = null, List<string> areaIds = null, List<string> sourceIds = null, string documentFormat = null, string documentVersion = null)

Get locations that are available in the archive

Get locations that are available in the archive. Optionally the locations can be filtered by one or more parameter ids or archive attributes. Archive attributes can be added in the following format: attribute(key)=value. Attributes are passed by passing the key as an argument to the attribute() parameter and the value as parameter value. For example attribute(storageId)=storageA.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var parameterIds = new List<string>(); // List<string> | One or more parameter ids (optional) 
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids (optional) 
            var areaIds = new List<string>(); // List<string> | One or more area ids (optional) 
            var sourceIds = new List<string>(); // List<string> | One or more source ids (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, GEO_JSON, NAME_LIST, DD_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get locations that are available in the archive
                ArchiveLocations200Response result = apiInstance.ArchiveLocations(parameterIds, moduleInstanceIds, areaIds, sourceIds, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get locations that are available in the archive
    ApiResponse<ArchiveLocations200Response> response = apiInstance.ArchiveLocationsWithHttpInfo(parameterIds, moduleInstanceIds, areaIds, sourceIds, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parameterIds** | [**List&lt;string&gt;**](string.md) | One or more parameter ids | [optional]  |
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids | [optional]  |
| **areaIds** | [**List&lt;string&gt;**](string.md) | One or more area ids | [optional]  |
| **sourceIds** | [**List&lt;string&gt;**](string.md) | One or more source ids | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, GEO_JSON, NAME_LIST, DD_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**ArchiveLocations200Response**](ArchiveLocations200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/plain, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archivemoduleinstances"></a>
# **ArchiveModuleinstances**
> PiRestModuleinstances ArchiveModuleinstances (List<string> locationIds = null, List<string> parameterIds = null, List<string> areaIds = null, List<string> sourceIds = null, string documentFormat = null, string documentVersion = null)

Returns the available module instaces for the netcdf storage

Returns the available module instaces for the netcdf storage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveModuleinstancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var parameterIds = new List<string>(); // List<string> | One or more parameter ids (optional) 
            var areaIds = new List<string>(); // List<string> | One or more area ids (optional) 
            var sourceIds = new List<string>(); // List<string> | One or more source ids (optional) 
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Returns the available module instaces for the netcdf storage
                PiRestModuleinstances result = apiInstance.ArchiveModuleinstances(locationIds, parameterIds, areaIds, sourceIds, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveModuleinstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveModuleinstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the available module instaces for the netcdf storage
    ApiResponse<PiRestModuleinstances> response = apiInstance.ArchiveModuleinstancesWithHttpInfo(locationIds, parameterIds, areaIds, sourceIds, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveModuleinstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **parameterIds** | [**List&lt;string&gt;**](string.md) | One or more parameter ids | [optional]  |
| **areaIds** | [**List&lt;string&gt;**](string.md) | One or more area ids | [optional]  |
| **sourceIds** | [**List&lt;string&gt;**](string.md) | One or more source ids | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestModuleinstances**](PiRestModuleinstances.md)

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

<a name="archivenetcdfstorageforecasts"></a>
# **ArchiveNetcdfstorageforecasts**
> PiRestArchiveExternalnetcdfstorageforecasts ArchiveNetcdfstorageforecasts (DateTime startTime, DateTime endTime, List<string> requestedAttributes = null, decimal? forecastCount = null, string documentFormat = null, string documentVersion = null)

Get forecasts with its attributes from the external netcdf storage from the archive

Get forecasts with its attributes from the external netcdf storage from the archive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveNetcdfstorageforecastsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var startTime = 2020-03-18T15:00Z;  // DateTime | Start time. Format: yyyy-MM-ddTHH:mm:ssZ
            var endTime = 2020-03-18T15:00Z;  // DateTime | End time. Format: yyyy-MM-ddTHH:mm:ssZ
            var requestedAttributes = new List<string>(); // List<string> | Requested attributes (optional) 
            var forecastCount = 8.9M;  // decimal? | Forecast count (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get forecasts with its attributes from the external netcdf storage from the archive
                PiRestArchiveExternalnetcdfstorageforecasts result = apiInstance.ArchiveNetcdfstorageforecasts(startTime, endTime, requestedAttributes, forecastCount, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveNetcdfstorageforecasts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveNetcdfstorageforecastsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get forecasts with its attributes from the external netcdf storage from the archive
    ApiResponse<PiRestArchiveExternalnetcdfstorageforecasts> response = apiInstance.ArchiveNetcdfstorageforecastsWithHttpInfo(startTime, endTime, requestedAttributes, forecastCount, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveNetcdfstorageforecastsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTime** | **DateTime** | Start time. Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **endTime** | **DateTime** | End time. Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **requestedAttributes** | [**List&lt;string&gt;**](string.md) | Requested attributes | [optional]  |
| **forecastCount** | **decimal?** | Forecast count | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestArchiveExternalnetcdfstorageforecasts**](PiRestArchiveExternalnetcdfstorageforecasts.md)

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

<a name="archiveparameters"></a>
# **ArchiveParameters**
> ArchiveParameters200Response ArchiveParameters (List<string> locationIds = null, List<string> moduleInstanceIds = null, List<string> areaIds = null, List<string> sourceIds = null, string documentFormat = null, string documentVersion = null)

Get parameters that are available in the archive

Get parameters that are available in the archive. Optionally the parameters can be filtered by one or more location ids or archive attributes. Archive attributes can be added in the following format: attribute(key)=value. Attributes are passed by passing the key as an argument to the attribute() parameter and the value as parameter value. For example attribute(storageId)=storageA.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids (optional) 
            var areaIds = new List<string>(); // List<string> | One or more area ids (optional) 
            var sourceIds = new List<string>(); // List<string> | One or more source ids (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, NAME_LIST, DD_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get parameters that are available in the archive
                ArchiveParameters200Response result = apiInstance.ArchiveParameters(locationIds, moduleInstanceIds, areaIds, sourceIds, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveParameters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get parameters that are available in the archive
    ApiResponse<ArchiveParameters200Response> response = apiInstance.ArchiveParametersWithHttpInfo(locationIds, moduleInstanceIds, areaIds, sourceIds, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveParametersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids | [optional]  |
| **areaIds** | [**List&lt;string&gt;**](string.md) | One or more area ids | [optional]  |
| **sourceIds** | [**List&lt;string&gt;**](string.md) | One or more source ids | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, NAME_LIST, DD_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**ArchiveParameters200Response**](ArchiveParameters200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/plain, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="archiveproducts"></a>
# **ArchiveProducts**
> string ArchiveProducts (string sourceId = null, string areaId = null, decimal? productCount = null, DateTime? startTime = null, DateTime? endTime = null, DateTime? startForecastTime = null, DateTime? endForecastTime = null, DateTime? productFileName = null, string documentFormat = null)

Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters

Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var sourceId = "sourceId_example";  // string | Source Id (optional) 
            var areaId = "areaId_example";  // string | Area Id (optional) 
            var productCount = 8.9M;  // decimal? | Archived Product Count (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var startForecastTime = 2020-03-18T15:00Z;  // DateTime? | Start Time Archive Forecast Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endForecastTime = 2020-03-18T15:00Z;  // DateTime? | End Time Archive Forecast Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var productFileName = 2020-03-18T15:00Z;  // DateTime? | An optional product file name. If this is specified only this item will be returned (optional) 
            var documentFormat = "BINARY";  // string | Supported Document Format: BINARY, BINARY_ZIP,  (optional) 

            try
            {
                // Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters
                string result = apiInstance.ArchiveProducts(sourceId, areaId, productCount, startTime, endTime, startForecastTime, endForecastTime, productFileName, documentFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters
    ApiResponse<string> response = apiInstance.ArchiveProductsWithHttpInfo(sourceId, areaId, productCount, startTime, endTime, startForecastTime, endForecastTime, productFileName, documentFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceId** | **string** | Source Id | [optional]  |
| **areaId** | **string** | Area Id | [optional]  |
| **productCount** | **decimal?** | Archived Product Count | [optional]  |
| **startTime** | **DateTime?** | Start Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTime** | **DateTime?** | End Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **startForecastTime** | **DateTime?** | Start Time Archive Forecast Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endForecastTime** | **DateTime?** | End Time Archive Forecast Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **productFileName** | **DateTime?** | An optional product file name. If this is specified only this item will be returned | [optional]  |
| **documentFormat** | **string** | Supported Document Format: BINARY, BINARY_ZIP,  | [optional]  |

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

<a name="archiveproductsid"></a>
# **ArchiveProductsId**
> Object ArchiveProductsId (string relativePath = null, string documentFormat = null)

Return a specific product from the archive

Return a specific product from the archive. The relative path in the archive will be used as the id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveProductsIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var relativePath = products-rws/2022/05/rivieren/10/product/weerbeeld_maas/2022_05_10_T_09_00_00/KNMI_20220510085242/weerbeeld_maas.txt;  // string |  the relative path of the product in the archive (optional) 
            var documentFormat = "BINARY";  // string | Supported Document Format: BINARY,  (optional) 

            try
            {
                // Return a specific product from the archive
                Object result = apiInstance.ArchiveProductsId(relativePath, documentFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveProductsId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveProductsIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return a specific product from the archive
    ApiResponse<Object> response = apiInstance.ArchiveProductsIdWithHttpInfo(relativePath, documentFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveProductsIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relativePath** | **string** |  the relative path of the product in the archive | [optional]  |
| **documentFormat** | **string** | Supported Document Format: BINARY,  | [optional]  |

### Return type

**Object**

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

<a name="archiveproductsmetadata"></a>
# **ArchiveProductsmetadata**
> PiRestArchiveProductsmetadata ArchiveProductsmetadata (DateTime? startForecastTime = null, DateTime? endForecastTime = null, string documentFormat = null, string documentVersion = null)

Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime

Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveProductsmetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var startForecastTime = 2020-03-18T15:00Z;  // DateTime? | Start Forecast Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endForecastTime = 2020-03-18T15:00Z;  // DateTime? | End Forecast Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime
                PiRestArchiveProductsmetadata result = apiInstance.ArchiveProductsmetadata(startForecastTime, endForecastTime, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveProductsmetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveProductsmetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime
    ApiResponse<PiRestArchiveProductsmetadata> response = apiInstance.ArchiveProductsmetadataWithHttpInfo(startForecastTime, endForecastTime, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveProductsmetadataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startForecastTime** | **DateTime?** | Start Forecast Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endForecastTime** | **DateTime?** | End Forecast Time Archive Search Period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestArchiveProductsmetadata**](PiRestArchiveProductsmetadata.md)

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

<a name="archivesources"></a>
# **ArchiveSources**
> PiRestArchiveSources ArchiveSources (string documentFormat = null, string documentVersion = null)

Returns the available sources for the open archive, netcdf-storage and the archive database

Returns the available sources for the open archive, netcdf-storage and the archive database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ArchiveSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Returns the available sources for the open archive, netcdf-storage and the archive database
                PiRestArchiveSources result = apiInstance.ArchiveSources(documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the available sources for the open archive, netcdf-storage and the archive database
    ApiResponse<PiRestArchiveSources> response = apiInstance.ArchiveSourcesWithHttpInfo(documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.ArchiveSourcesWithHttpInfo: " + e.Message);
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

[**PiRestArchiveSources**](PiRestArchiveSources.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postarchiveproducts"></a>
# **PostArchiveProducts**
> string PostArchiveProducts (DateTime? timeZero = null, string areaId = null, string sourceId = null, string subFolder = null, string file = null)

upload new products to the archive

upload new products to the archive. The multipart/form-data encoding has to be used. The metaData.xml will be automatically generated. It is only possible to upload a single product file each time this endpoint is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostArchiveProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ArchiveApi(config);
            var timeZero = 2020-03-18T15:00Z;  // DateTime? |  time zero of the uploaded product. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var areaId = "areaId_example";  // string | area id of the uploaded product (optional) 
            var sourceId = "sourceId_example";  // string | source id of the uploaded product (optional) 
            var subFolder = "subFolder_example";  // string | The sub folder in which the product will be stored. This can be used as an folder to identify the product easier (optional) 
            var file = "file_example";  // string | file to upload (optional) 

            try
            {
                // upload new products to the archive
                string result = apiInstance.PostArchiveProducts(timeZero, areaId, sourceId, subFolder, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArchiveApi.PostArchiveProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostArchiveProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // upload new products to the archive
    ApiResponse<string> response = apiInstance.PostArchiveProductsWithHttpInfo(timeZero, areaId, sourceId, subFolder, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArchiveApi.PostArchiveProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timeZero** | **DateTime?** |  time zero of the uploaded product. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **areaId** | **string** | area id of the uploaded product | [optional]  |
| **sourceId** | **string** | source id of the uploaded product | [optional]  |
| **subFolder** | **string** | The sub folder in which the product will be stored. This can be used as an folder to identify the product easier | [optional]  |
| **file** | **string** | file to upload | [optional]  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

