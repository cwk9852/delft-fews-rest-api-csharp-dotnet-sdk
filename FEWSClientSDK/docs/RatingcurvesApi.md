# Org.OpenAPITools.Api.RatingcurvesApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Ratingcurves**](RatingcurvesApi.md#ratingcurves) | **GET** /ratingcurves | Get all configured rating curves from the region config and optionally filter by locationIds |
| [**RatingcurvesDischargetostage**](RatingcurvesApi.md#ratingcurvesdischargetostage) | **POST** /ratingcurves/dischargetostage | Converts discharge values to stage values using a rating curve at a specific location |
| [**RatingcurvesStagetodischarge**](RatingcurvesApi.md#ratingcurvesstagetodischarge) | **POST** /ratingcurves/stagetodischarge | Converts stage values to discharge values using a rating curve at a specific location |

<a name="ratingcurves"></a>
# **Ratingcurves**
> PiRestRatingcurves Ratingcurves (List<string> locationIds = null, string onlyHeaders = null, string documentFormat = null, string documentVersion = null)

Get all configured rating curves from the region config and optionally filter by locationIds

Get all configured rating curves from the region config and optionally filter by locationIds. Since 2022.02

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingcurvesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingcurvesApi(config);
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var onlyHeaders = "true";  // string | Toggle to return only rating curver headers (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all configured rating curves from the region config and optionally filter by locationIds
                PiRestRatingcurves result = apiInstance.Ratingcurves(locationIds, onlyHeaders, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingcurvesApi.Ratingcurves: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RatingcurvesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all configured rating curves from the region config and optionally filter by locationIds
    ApiResponse<PiRestRatingcurves> response = apiInstance.RatingcurvesWithHttpInfo(locationIds, onlyHeaders, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingcurvesApi.RatingcurvesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **onlyHeaders** | **string** | Toggle to return only rating curver headers | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestRatingcurves**](PiRestRatingcurves.md)

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

<a name="ratingcurvesdischargetostage"></a>
# **RatingcurvesDischargetostage**
> PiRestRatingcurvesStage RatingcurvesDischargetostage (string locationId, string documentFormat = null, string documentVersion = null, string dischargeValues = null)

Converts discharge values to stage values using a rating curve at a specific location

Converts discharge values to stage values using a rating curve at a specific location. The dischargeValues should be passed in the body of the POST request as a key value pair where the key is dischargeValues and the value is URL Encoded JSON that conforms to the pi_rest_ratingcurves_discharge.json schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_discharge.json. Since 2022.02. Also available in readonly mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingcurvesDischargetostageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingcurvesApi(config);
            var locationId = "locationId_example";  // string | Location id
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 
            var dischargeValues = "dischargeValues_example";  // string | Discharge values in JSON format that conforms to the schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_discharge.json. Example: {   \\\"dischargeValues\\\" : [ \\\"9920.0\\\", \\\"10200.0\\\" ] } (optional) 

            try
            {
                // Converts discharge values to stage values using a rating curve at a specific location
                PiRestRatingcurvesStage result = apiInstance.RatingcurvesDischargetostage(locationId, documentFormat, documentVersion, dischargeValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingcurvesApi.RatingcurvesDischargetostage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RatingcurvesDischargetostageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Converts discharge values to stage values using a rating curve at a specific location
    ApiResponse<PiRestRatingcurvesStage> response = apiInstance.RatingcurvesDischargetostageWithHttpInfo(locationId, documentFormat, documentVersion, dischargeValues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingcurvesApi.RatingcurvesDischargetostageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **string** | Location id |  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |
| **dischargeValues** | **string** | Discharge values in JSON format that conforms to the schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_discharge.json. Example: {   \\\&quot;dischargeValues\\\&quot; : [ \\\&quot;9920.0\\\&quot;, \\\&quot;10200.0\\\&quot; ] } | [optional]  |

### Return type

[**PiRestRatingcurvesStage**](PiRestRatingcurvesStage.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

<a name="ratingcurvesstagetodischarge"></a>
# **RatingcurvesStagetodischarge**
> PiRestRatingcurvesDischarge RatingcurvesStagetodischarge (string locationId, string documentFormat = null, string documentVersion = null, string stageValues = null)

Converts stage values to discharge values using a rating curve at a specific location

Converts stage values to discharge values using a rating curve at a specific location. The stageValues should be passed in the body of the POST request as a key value pair where the key is dischargeValue and the value is URL Encoded JSON that conforms to the pi_rest_ratingcurves_stage.json schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_stage.json. Since 2022.02. Also available in readonly mode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingcurvesStagetodischargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RatingcurvesApi(config);
            var locationId = "locationId_example";  // string | Location id
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 
            var stageValues = "stageValues_example";  // string | Stage values in JSON format that conforms to the schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_stage.json. Example: {   \\\"stageValues\\\" : [ \\\"22.1\\\", \\\"22.2\\\" ] } (optional) 

            try
            {
                // Converts stage values to discharge values using a rating curve at a specific location
                PiRestRatingcurvesDischarge result = apiInstance.RatingcurvesStagetodischarge(locationId, documentFormat, documentVersion, stageValues);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatingcurvesApi.RatingcurvesStagetodischarge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RatingcurvesStagetodischargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Converts stage values to discharge values using a rating curve at a specific location
    ApiResponse<PiRestRatingcurvesDischarge> response = apiInstance.RatingcurvesStagetodischargeWithHttpInfo(locationId, documentFormat, documentVersion, stageValues);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatingcurvesApi.RatingcurvesStagetodischargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **locationId** | **string** | Location id |  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |
| **stageValues** | **string** | Stage values in JSON format that conforms to the schema: https://fewsdocs.deltares.nl/webservices/rest-api/v1/schemas/pirest/pi_rest_ratingcurves_stage.json. Example: {   \\\&quot;stageValues\\\&quot; : [ \\\&quot;22.1\\\&quot;, \\\&quot;22.2\\\&quot; ] } | [optional]  |

### Return type

[**PiRestRatingcurvesDischarge**](PiRestRatingcurvesDischarge.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

