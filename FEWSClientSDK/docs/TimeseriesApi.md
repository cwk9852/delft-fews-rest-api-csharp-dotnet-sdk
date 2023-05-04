# Org.OpenAPITools.Api.TimeseriesApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EnsemblesMembers**](TimeseriesApi.md#ensemblesmembers) | **GET** /ensembles/members | Get all ensemble member ids for one or more ensemble Ids |
| [**Posttimeseries**](TimeseriesApi.md#posttimeseries) | **POST** /timeseries | Timeseries will be written that are part of the timeseries sets defined by the filters |
| [**Timeseries**](TimeseriesApi.md#timeseries) | **GET** /timeseries | Get timeseries that are part of the default filter |
| [**TimeseriesDisplaygroups**](TimeseriesApi.md#timeseriesdisplaygroups) | **GET** /timeseries/displaygroups | Timeseries are filtered by the plotId from the DisplayGroups |
| [**Timeseriesgrid**](TimeseriesApi.md#timeseriesgrid) | **GET** /timeseries/grid | Get the timeseries containing the data from a grid cell for a request period |

<a name="ensemblesmembers"></a>
# **EnsemblesMembers**
> PiRestTimeseriesEnsemblesMembers EnsemblesMembers (List<string> ensembleIds, string documentFormat = null, string documentVersion = null)

Get all ensemble member ids for one or more ensemble Ids

Get all ensemble member ids for one or more ensemble Ids. The available member ids depend on an up-to-date index. This is run once a day on a forecasting shell server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnsemblesMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeseriesApi(config);
            var ensembleIds = new List<string>(); // List<string> | One or more ensemble ids
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all ensemble member ids for one or more ensemble Ids
                PiRestTimeseriesEnsemblesMembers result = apiInstance.EnsemblesMembers(ensembleIds, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeseriesApi.EnsemblesMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnsemblesMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all ensemble member ids for one or more ensemble Ids
    ApiResponse<PiRestTimeseriesEnsemblesMembers> response = apiInstance.EnsemblesMembersWithHttpInfo(ensembleIds, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeseriesApi.EnsemblesMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ensembleIds** | [**List&lt;string&gt;**](string.md) | One or more ensemble ids |  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestTimeseriesEnsemblesMembers**](PiRestTimeseriesEnsemblesMembers.md)

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

<a name="posttimeseries"></a>
# **Posttimeseries**
> Object Posttimeseries (string filterId = null, string convertDatum = null, string piTimeSeriesXmlContent = null)

Timeseries will be written that are part of the timeseries sets defined by the filters

Timeseries will be written that are part of the timeseries sets defined by the filters. The application/x-www-form-urlencoded encoding has to be used. Readonly mode has to be disable in the FewsPiService.properties to allow this functionality.<p>The timeseries you post to the rest service should match one of the time series sets in the default filter or one of its sub filters. To make sure you only write time series for a specific filter, you can pass a filterId with the POST request. Only timeseries that have timeseries sets that are configured in that filter (or one of its sub filters) will be accepted. If no filterId is used, all time series will be accepted that are configured in the default filter. Writing the time series works similar to importing time series using the pi.xml format using the \"PI\" import type. See also: <a target='_new' href='https://publicwiki.deltares.nl/x/uIGE'>Delft-Fews Published Interface timeseries Format (PI) Import</a>  The 'convertDatum' argument is to allow timeseries that support a datum to have their values converted to a value relative to the location height. If values are already relative to location then enter FALSE or omit.  In case a time series already exists in the database, the time series will be overwritten by the ones that are posted. For forecast time series with different forecastDates a new time series will be added. The latter can be achieved by providing a forecastDate element in the POST request, e.g. <forecastDate date=\"2013-01-01\" time=\"00:00:00\"/>.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PosttimeseriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeseriesApi(config);
            var filterId = "filterId_example";  // string | An existing subfilter of the default filter id (optional) 
            var convertDatum = "true";  // string | Convert Datum (optional) 
            var piTimeSeriesXmlContent = "piTimeSeriesXmlContent_example";  // string | https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_timeseries.xsd (optional) 

            try
            {
                // Timeseries will be written that are part of the timeseries sets defined by the filters
                Object result = apiInstance.Posttimeseries(filterId, convertDatum, piTimeSeriesXmlContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeseriesApi.Posttimeseries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PosttimeseriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Timeseries will be written that are part of the timeseries sets defined by the filters
    ApiResponse<Object> response = apiInstance.PosttimeseriesWithHttpInfo(filterId, convertDatum, piTimeSeriesXmlContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeseriesApi.PosttimeseriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | An existing subfilter of the default filter id | [optional]  |
| **convertDatum** | **string** | Convert Datum | [optional]  |
| **piTimeSeriesXmlContent** | **string** | https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_timeseries.xsd | [optional]  |

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

<a name="timeseries"></a>
# **Timeseries**
> Timeseries200Response Timeseries (string filterId = null, List<string> locationIds = null, List<string> parameterIds = null, List<string> moduleInstanceIds = null, List<string> qualifierIds = null, List<string> taskRunIds = null, DateTime? startTime = null, DateTime? endTime = null, DateTime? startCreationTime = null, DateTime? endCreationTime = null, decimal? forecastCount = null, DateTime? startForecastTime = null, DateTime? endForecastTime = null, List<string> externalForecastTimes = null, string ensembleId = null, string ensembleMemberId = null, string timeStepId = null, decimal? thinning = null, string exportIdMap = null, string matchAsQualifierSet = null, string importFromExternalDataSource = null, string convertDatum = null, string showEnsembleMemberIds = null, string useDisplayUnits = null, string showThresholds = null, string omitMissing = null, string omitEmptyTimeSeries = null, string onlyManualEdits = null, string onlyHeaders = null, string onlyForecasts = null, string showStatistics = null, string useMilliseconds = null, string showProducts = null, string timeSeriesType = null, string documentFormat = null, string documentVersion = null)

Get timeseries that are part of the default filter

Get timeseries that are part of the default filter.<p><h2>parameters</h2> Not all parameters can be combined. The following combinations are commonly used valid combinations of parameters. The main way to filter timeseries is by using filter ids or taskrun ids.<p> <table border='1'>     <tr>         <th>Use cases</th>         <th>filterId</th>         <th>taskRunIds</th>         <th>startTime, endTime</th>         <th>startCreationTime, endCreationTime</th>         <th>startForecastTime, endForecastTime</th>     </tr>     <tr>         <td>Apply a filter to the time series. The requested period will be set to the current time minus one day and one hour ago until the current time plus one day and one hour</td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td></td>         <td></td>     </tr>     <tr>         <td>Get all time series created by one or more taskRuns. All time steps of the matching time series are returned.</td>         <td></td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td></td>     </tr>     <tr>         <td>Get the time series created by a taskrun and apply a filter from the Filters configuration. startTime and endTime cannot be specified. The complete time series will be returned. Since             2020.01.         </td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td></td>     </tr>     <tr>         <td>Apply a filter to the time series and return time steps that are in the startTime and endTime range. If the startTime or endTime doesn't match a timestamp of the time series, the closest time step before startTime and/or after endTime is returned as well.</td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>     </tr>     <tr>         <td>Apply a filter to the time series. Only time series created during the startCreationTime and endCreationTime period will be returned. All time steps of the matching time series are             returned.         </td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series created during the creation time period. Only return timesteps in the startTime and endTime range.</td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series with external forecast times in the startForecastTime and endForecastTime period. Only return timesteps in the startTime and             endTime range.         </td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series with external forecast times in the startForecastTime and endForecastTime period that were created in the creation time period.             Only return time steps in the startTime and endTime range.         </td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series created during the creation time period. All time steps of the matching time series are returned. (before 2020.01 startTime and             endTime had to be specified).         </td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series with external forecast times in the startForecastTime and endForecastTime period. All time steps of the matching time series are             returned.         </td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>     </tr>     <tr>         <td>Apply a filter to the time series. Return only time series created during the creation time period and with external forecast times in the startForecastTime and endForecastTime period. All             time steps of the matching time series are returned..         </td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td></td>         <td></td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>         <td  style=\"background-color: LightGray; text-align: center;\">&nbsp;X</td>     </tr> </table>  <h2>no data vs no time series</h2> If a timeseries query has matching timeseries sets a http 200 code will be returned and the headers of all matching time series sets will be returned. If there is any data for the requested period, the headers will be followed by the actual events that contain the data. So even if no data is available at all the headers are always returned.  It is also possible that a timeseries query doesn't match any time series sets at all. This is seen as in invalid request and will result in a HTTP 400 response code. The following are examples of use cases where this might occur: <ul>     <li>query parameters don't occur in filter. For example: the default filter has subfilters: filterA and filterB. filterA contains timeseries sets with module instance id moduleInstanceA and filterB contains timeseries sets with module instance id moduleInstanceB.         If a timeseries query is done with parameters: filterId=filterA and moduleInstanceId=moduleInstanceB, this will return in a HTTP 400 response</li>     <li>no timeseries for creation period. For example: if a query is using startCreationTime and endCreationTime and no time series have been produced during that period, this is seen as an invalid request and a HTTP 400 response is returned.</li> </ul>  <h2>availability of new timeseries</h2> When new timeseries have been created, it can take some time before they can be found by the WebServices. The web services updates its indexes every second (every five seconds before 2023.01). Once the indexes have been updated, newly created time series can be found. So it typically can take a few seconds before newly created time series can be found.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeseriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeseriesApi(config);
            var filterId = "filterId_example";  // string | An existing subfilter of the default filter id (optional) 
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var parameterIds = new List<string>(); // List<string> | One or more parameter ids (optional) 
            var moduleInstanceIds = new List<string>(); // List<string> | One or more module instance ids (optional) 
            var qualifierIds = new List<string>(); // List<string> | One or more qualifier ids. Subset of qualifiers for which to retrieve time series. All time series that have any of the specified qualifierIds will be returned. To indicate that no qualifier is available, use qualifierIds: \"none\" (optional) 
            var taskRunIds = new List<string>(); // List<string> | One or more taskRunIds (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start time of search period that looks for timeseries values that are within this period. If the startTime doesn't match a timestamp of the time series, the closest timestamp before the startTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ. Take note that if no startTime and endTime are specified, the requested period will be set to the current time minus one day and one hour ago until the current time plus one day and one hour. If only the startTime is specified, the requested period will be set to the startTime until the startTime time plus one day and one hour. If only the endTime is specified, the requested period will be set to the endTime minus one day and one hour until the endTime. (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End time of search period that looks for timeseries values that are within this period. If the endTime doesn't match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ. Take note that if no startTime and endTime are specified, the requested period will be set to the current time minus one day and one hour ago until the current time plus one day and one hour. If only the startTime is specified, the requested period will be set to the startTime until the startTime time plus one day and one hour. If only the endTime is specified, the requested period will be set to the endTime minus one day and one hour until the endTime. (optional) 
            var startCreationTime = 2020-03-18T15:00Z;  // DateTime? | Creation start time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endCreationTime = 2020-03-18T15:00Z;  // DateTime? | Creation end time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var forecastCount = 1;  // decimal? | Number of forecasts that will be searched for when startForecastTime and endForecastTime have been specified. Default 1 (optional) 
            var startForecastTime = 2020-03-18T15:00Z;  // DateTime? | Start time of search period that looks for time series produced by forecasts that have their forecast time within this period. Format: yyyy-MM-ddTHH:mm:ssZ. If left empty all forecasts up to the endForecastTime will be used as search period. (optional) 
            var endForecastTime = 2020-03-18T15:00Z;  // DateTime? | End time of search period that looks for time series produced by forecasts that have their forecast time within this period. Format: yyyy-MM-ddTHH:mm:ssZ. If left empty all forecasts starting from the startForecastTime will be used as search period. (optional) 
            var externalForecastTimes = new List<string>(); // List<string> | One or more external forecast times. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var ensembleId = "ensembleId_example";  // string | Ensemble Id. Ensemble identifier of time series (optional) 
            var ensembleMemberId = "ensembleMemberId_example";  // string | Ensemble MemberId. Ensemble member identifier of time series. Only allowed in combination with ensembleId <i>Since: 2022.02</i> (optional) 
            var timeStepId = "timeStepId_example";  // string | Time Step Id. Filter time series by the time step that has been configured in the TimeSteps.xml. N.B.: It is not required to use the timeStepId's in the filter configurations to be able to use them as long as they have been configured in the TimeSteps.xml. <i>Since: 2018.02</i> (optional) 
            var thinning = 15408668;  // decimal? | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 = 15408668. unit ms/pixel. (optional) 
            var exportIdMap = "exportIdMap_example";  // string | Name of the id map that should be used as exportIdMap. This parameter will overrule a configured exportIdMap. <i>Since: 2022.02</i> (optional) 
            var matchAsQualifierSet = "true";  // string | Since 2023.01. If this option is to true the qualifier from time series selected from the filter must contain all of the given qualifiers ids and only consist only of the given qualifiers ids (optional) 
            var importFromExternalDataSource = "true";  // string | import data from external data source, defaults to true. (optional) 
            var convertDatum = "true";  // string | Convert values from relative location height to absolute height values (optional) 
            var showEnsembleMemberIds = "true";  // string | Show ensemble member ids instead of ensemble member indices. (optional) 
            var useDisplayUnits = "true";  // string | Export values using display units. (optional) 
            var showThresholds = "true";  // string | Option to toggle the returning of threshold information in the headers. (optional) 
            var omitMissing = "true";  // string | Toggle omitting or returning of missing values in response. (optional) 
            var omitEmptyTimeSeries = "true";  // string | Toggle omitting or returning headers of empty timeSeries. Default is false. <i>Since: 2020.02</i> (optional) 
            var onlyManualEdits = "true";  // string | Toggle to return only manual edits. (optional) 
            var onlyHeaders = "true";  // string | Toggle to return only header information or also data. (optional) 
            var onlyForecasts = "true";  // string | Toggle to return only forecast timeSeries (Since 2017.02). (optional) 
            var showStatistics = "true";  // string | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:<ul><li>firstValueTime: First time with a value in the timeSeries</li><li>maxValue: Maximum value in the timeSeries</li><li>minValue: Minimum value in the timeSeries</li><li>valueCount: Number of values in the timeSeries</li></ul>. These statistics are only provided if there is any data, otherwise they are left out. (optional) 
            var useMilliseconds = "true";  // string | Toggle to return milliseconds in time step. (optional) 
            var showProducts = "true";  // string | Toggle to display product information that is assigned to a forecast. (Since 2019.02). (optional) 
            var timeSeriesType = "EXTERNAL_HISTORICAL";  // string | Explicitly filter on a specific time series type. <i>Since: 2020.01</i> (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT, BINARY,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get timeseries that are part of the default filter
                Timeseries200Response result = apiInstance.Timeseries(filterId, locationIds, parameterIds, moduleInstanceIds, qualifierIds, taskRunIds, startTime, endTime, startCreationTime, endCreationTime, forecastCount, startForecastTime, endForecastTime, externalForecastTimes, ensembleId, ensembleMemberId, timeStepId, thinning, exportIdMap, matchAsQualifierSet, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeseriesApi.Timeseries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeseriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get timeseries that are part of the default filter
    ApiResponse<Timeseries200Response> response = apiInstance.TimeseriesWithHttpInfo(filterId, locationIds, parameterIds, moduleInstanceIds, qualifierIds, taskRunIds, startTime, endTime, startCreationTime, endCreationTime, forecastCount, startForecastTime, endForecastTime, externalForecastTimes, ensembleId, ensembleMemberId, timeStepId, thinning, exportIdMap, matchAsQualifierSet, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeseriesApi.TimeseriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterId** | **string** | An existing subfilter of the default filter id | [optional]  |
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **parameterIds** | [**List&lt;string&gt;**](string.md) | One or more parameter ids | [optional]  |
| **moduleInstanceIds** | [**List&lt;string&gt;**](string.md) | One or more module instance ids | [optional]  |
| **qualifierIds** | [**List&lt;string&gt;**](string.md) | One or more qualifier ids. Subset of qualifiers for which to retrieve time series. All time series that have any of the specified qualifierIds will be returned. To indicate that no qualifier is available, use qualifierIds: \&quot;none\&quot; | [optional]  |
| **taskRunIds** | [**List&lt;string&gt;**](string.md) | One or more taskRunIds | [optional]  |
| **startTime** | **DateTime?** | Start time of search period that looks for timeseries values that are within this period. If the startTime doesn&#39;t match a timestamp of the time series, the closest timestamp before the startTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ. Take note that if no startTime and endTime are specified, the requested period will be set to the current time minus one day and one hour ago until the current time plus one day and one hour. If only the startTime is specified, the requested period will be set to the startTime until the startTime time plus one day and one hour. If only the endTime is specified, the requested period will be set to the endTime minus one day and one hour until the endTime. | [optional]  |
| **endTime** | **DateTime?** | End time of search period that looks for timeseries values that are within this period. If the endTime doesn&#39;t match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ. Take note that if no startTime and endTime are specified, the requested period will be set to the current time minus one day and one hour ago until the current time plus one day and one hour. If only the startTime is specified, the requested period will be set to the startTime until the startTime time plus one day and one hour. If only the endTime is specified, the requested period will be set to the endTime minus one day and one hour until the endTime. | [optional]  |
| **startCreationTime** | **DateTime?** | Creation start time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endCreationTime** | **DateTime?** | Creation end time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **forecastCount** | **decimal?** | Number of forecasts that will be searched for when startForecastTime and endForecastTime have been specified. Default 1 | [optional]  |
| **startForecastTime** | **DateTime?** | Start time of search period that looks for time series produced by forecasts that have their forecast time within this period. Format: yyyy-MM-ddTHH:mm:ssZ. If left empty all forecasts up to the endForecastTime will be used as search period. | [optional]  |
| **endForecastTime** | **DateTime?** | End time of search period that looks for time series produced by forecasts that have their forecast time within this period. Format: yyyy-MM-ddTHH:mm:ssZ. If left empty all forecasts starting from the startForecastTime will be used as search period. | [optional]  |
| **externalForecastTimes** | [**List&lt;string&gt;**](string.md) | One or more external forecast times. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **ensembleId** | **string** | Ensemble Id. Ensemble identifier of time series | [optional]  |
| **ensembleMemberId** | **string** | Ensemble MemberId. Ensemble member identifier of time series. Only allowed in combination with ensembleId &lt;i&gt;Since: 2022.02&lt;/i&gt; | [optional]  |
| **timeStepId** | **string** | Time Step Id. Filter time series by the time step that has been configured in the TimeSteps.xml. N.B.: It is not required to use the timeStepId&#39;s in the filter configurations to be able to use them as long as they have been configured in the TimeSteps.xml. &lt;i&gt;Since: 2018.02&lt;/i&gt; | [optional]  |
| **thinning** | **decimal?** | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 &#x3D; 15408668. unit ms/pixel. | [optional]  |
| **exportIdMap** | **string** | Name of the id map that should be used as exportIdMap. This parameter will overrule a configured exportIdMap. &lt;i&gt;Since: 2022.02&lt;/i&gt; | [optional]  |
| **matchAsQualifierSet** | **string** | Since 2023.01. If this option is to true the qualifier from time series selected from the filter must contain all of the given qualifiers ids and only consist only of the given qualifiers ids | [optional]  |
| **importFromExternalDataSource** | **string** | import data from external data source, defaults to true. | [optional]  |
| **convertDatum** | **string** | Convert values from relative location height to absolute height values | [optional]  |
| **showEnsembleMemberIds** | **string** | Show ensemble member ids instead of ensemble member indices. | [optional]  |
| **useDisplayUnits** | **string** | Export values using display units. | [optional]  |
| **showThresholds** | **string** | Option to toggle the returning of threshold information in the headers. | [optional]  |
| **omitMissing** | **string** | Toggle omitting or returning of missing values in response. | [optional]  |
| **omitEmptyTimeSeries** | **string** | Toggle omitting or returning headers of empty timeSeries. Default is false. &lt;i&gt;Since: 2020.02&lt;/i&gt; | [optional]  |
| **onlyManualEdits** | **string** | Toggle to return only manual edits. | [optional]  |
| **onlyHeaders** | **string** | Toggle to return only header information or also data. | [optional]  |
| **onlyForecasts** | **string** | Toggle to return only forecast timeSeries (Since 2017.02). | [optional]  |
| **showStatistics** | **string** | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:&lt;ul&gt;&lt;li&gt;firstValueTime: First time with a value in the timeSeries&lt;/li&gt;&lt;li&gt;maxValue: Maximum value in the timeSeries&lt;/li&gt;&lt;li&gt;minValue: Minimum value in the timeSeries&lt;/li&gt;&lt;li&gt;valueCount: Number of values in the timeSeries&lt;/li&gt;&lt;/ul&gt;. These statistics are only provided if there is any data, otherwise they are left out. | [optional]  |
| **useMilliseconds** | **string** | Toggle to return milliseconds in time step. | [optional]  |
| **showProducts** | **string** | Toggle to display product information that is assigned to a forecast. (Since 2019.02). | [optional]  |
| **timeSeriesType** | **string** | Explicitly filter on a specific time series type. &lt;i&gt;Since: 2020.01&lt;/i&gt; | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT, BINARY,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**Timeseries200Response**](Timeseries200Response.md)

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

<a name="timeseriesdisplaygroups"></a>
# **TimeseriesDisplaygroups**
> Timeseries200Response TimeseriesDisplaygroups (string plotId, List<string> locationIds = null, DateTime? startTime = null, DateTime? endTime = null, decimal? thinning = null, string convertDatum = null, string showEnsembleMemberIds = null, string useDisplayUnits = null, string showThresholds = null, string omitMissing = null, string omitEmptyTimeSeries = null, string onlyHeaders = null, string onlyManualEdits = null, string onlyForecasts = null, string showStatistics = null, string useMilliseconds = null, string showProducts = null, string timeSeriesType = null, string documentFormat = null, string documentVersion = null)

Timeseries are filtered by the plotId from the DisplayGroups

Timeseries are filtered by the plotId from the DisplayGroups.xml configuration in the SystemConfigFiles folder.<p>The TimeSeriesSets configured for the plotId will be used to filter the timeSeries. The line, area and clusteredBars elements are used when determining the relevant TimeSeriesSets. In case of forecasts, this means only the current forecast will be retrieved. It is not possible to request older forecasts. If no line, area or clusteredBars elements are used in the displayGroups.xml configuration, the TimeSeriesSets will not be applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeseriesDisplaygroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeseriesApi(config);
            var plotId = "plotId_example";  // string | Plot Id
            var locationIds = new List<string>(); // List<string> | One or more location ids (optional) 
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start time of search period that looks for timeseries values that are within this period. If the startTime doesn't match a timestamp of the time series, the closest timestamp before the startTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End time of search period that looks for timeseries values that are within this period. If the endTime doesn't match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var thinning = 15408668;  // decimal? | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 = 15408668. unit ms/pixel. (optional) 
            var convertDatum = "true";  // string | Convert Datum (optional) 
            var showEnsembleMemberIds = "true";  // string | Show ensemble member ids instead of ensemble member indices. (optional) 
            var useDisplayUnits = "true";  // string | Export values using display units (optional) 
            var showThresholds = "true";  // string | Option to toggle the returning of threshold information in the headers. (optional) 
            var omitMissing = "true";  // string | Toggle omitting or returning of missing values in response. (optional) 
            var omitEmptyTimeSeries = "true";  // string | Toggle omitting or returning headers of empty timeSeries. Default is false. <i>Since: 2020.02</i> (optional) 
            var onlyHeaders = "true";  // string | Toggle to return only header information or also data. (optional) 
            var onlyManualEdits = "true";  // string | Toggle to return only manual edits. (optional) 
            var onlyForecasts = "true";  // string | Toggle to return only forecast timeSeries (Since 2017.02). (optional) 
            var showStatistics = "true";  // string | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:<ul><li>firstValueTime: First time with a value in the timeSeries</li><li>maxValue: Maximum value in the timeSeries</li><li>minValue: Minimum value in the timeSeries</li><li>valueCount: Number of values in the timeSeries</li></ul>. These statistics are only provided if there is any data, otherwise they are left out. (optional) 
            var useMilliseconds = "true";  // string | Toggle to return milliseconds in time step. (optional) 
            var showProducts = "true";  // string | Toggle to display product information that is assigned to a forecast. (Since 2019.02). (optional) 
            var timeSeriesType = "EXTERNAL_HISTORICAL";  // string | Explicitly filter on a specific time series type. <i>Since: 2020.01</i> (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Timeseries are filtered by the plotId from the DisplayGroups
                Timeseries200Response result = apiInstance.TimeseriesDisplaygroups(plotId, locationIds, startTime, endTime, thinning, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyHeaders, onlyManualEdits, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeseriesApi.TimeseriesDisplaygroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeseriesDisplaygroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Timeseries are filtered by the plotId from the DisplayGroups
    ApiResponse<Timeseries200Response> response = apiInstance.TimeseriesDisplaygroupsWithHttpInfo(plotId, locationIds, startTime, endTime, thinning, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyHeaders, onlyManualEdits, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeseriesApi.TimeseriesDisplaygroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **plotId** | **string** | Plot Id |  |
| **locationIds** | [**List&lt;string&gt;**](string.md) | One or more location ids | [optional]  |
| **startTime** | **DateTime?** | Start time of search period that looks for timeseries values that are within this period. If the startTime doesn&#39;t match a timestamp of the time series, the closest timestamp before the startTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTime** | **DateTime?** | End time of search period that looks for timeseries values that are within this period. If the endTime doesn&#39;t match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **thinning** | **decimal?** | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 &#x3D; 15408668. unit ms/pixel. | [optional]  |
| **convertDatum** | **string** | Convert Datum | [optional]  |
| **showEnsembleMemberIds** | **string** | Show ensemble member ids instead of ensemble member indices. | [optional]  |
| **useDisplayUnits** | **string** | Export values using display units | [optional]  |
| **showThresholds** | **string** | Option to toggle the returning of threshold information in the headers. | [optional]  |
| **omitMissing** | **string** | Toggle omitting or returning of missing values in response. | [optional]  |
| **omitEmptyTimeSeries** | **string** | Toggle omitting or returning headers of empty timeSeries. Default is false. &lt;i&gt;Since: 2020.02&lt;/i&gt; | [optional]  |
| **onlyHeaders** | **string** | Toggle to return only header information or also data. | [optional]  |
| **onlyManualEdits** | **string** | Toggle to return only manual edits. | [optional]  |
| **onlyForecasts** | **string** | Toggle to return only forecast timeSeries (Since 2017.02). | [optional]  |
| **showStatistics** | **string** | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:&lt;ul&gt;&lt;li&gt;firstValueTime: First time with a value in the timeSeries&lt;/li&gt;&lt;li&gt;maxValue: Maximum value in the timeSeries&lt;/li&gt;&lt;li&gt;minValue: Minimum value in the timeSeries&lt;/li&gt;&lt;li&gt;valueCount: Number of values in the timeSeries&lt;/li&gt;&lt;/ul&gt;. These statistics are only provided if there is any data, otherwise they are left out. | [optional]  |
| **useMilliseconds** | **string** | Toggle to return milliseconds in time step. | [optional]  |
| **showProducts** | **string** | Toggle to display product information that is assigned to a forecast. (Since 2019.02). | [optional]  |
| **timeSeriesType** | **string** | Explicitly filter on a specific time series type. &lt;i&gt;Since: 2020.01&lt;/i&gt; | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**Timeseries200Response**](Timeseries200Response.md)

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

<a name="timeseriesgrid"></a>
# **Timeseriesgrid**
> Timeseries200Response Timeseriesgrid (string bbox, DateTime startTime, DateTime endTime, string layers, double x, double y, DateTime? externalForecastTime = null, string ensembleId = null, string ensembleMemberId = null, double? elevation = null, decimal? thinning = null, string importFromExternalDataSource = null, string convertDatum = null, string showEnsembleMemberIds = null, string useDisplayUnits = null, string showVerticalProfile = null, string showThresholds = null, string omitMissing = null, string omitEmptyTimeSeries = null, string onlyManualEdits = null, string onlyHeaders = null, string onlyForecasts = null, string showStatistics = null, string useMilliseconds = null, string showProducts = null, string documentFormat = null, string documentVersion = null)

Get the timeseries containing the data from a grid cell for a request period

Get the timeseries containing the data from a grid cell for a request period. The grid is specified by passing a layerId.<p>The grid cell is determined by specifying a x and y coordinate and a bounding box. Currenly only EPSG:3857 is supported for the x,y, and bounding box coordinates. At least a layer, startTime, endTime, x,y and bounding box are required. The timeseries/grid endpoint is intended to be used together with the Delf-FEWS WMS service. Every layer that is provided by the WMS service, can be used with this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TimeseriesgridExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimeseriesApi(config);
            var bbox = -1558755.612890017,4979850.04379049,1623657.8112034467,6709422.556884765;  // string | bounding box of map that is viewed in , separated EPSG:3857 format. The order of the coordinates is as follows: bottom left X, bottom left Y, top right X, top right Y.
            var startTime = 2020-03-18T15:00Z;  // DateTime | Start time of search period that looks for timeseries values that are within this period. If the start time doesn't match a timestamp of the time series, the closest timestamp before the startTime, will also be returned.  Format: yyyy-MM-ddTHH:mm:ssZ
            var endTime = 2020-03-18T15:00Z;  // DateTime | End time of search period that looks for timeseries values that are within this period. If the endTime doesn't match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ
            var layers = Temp_forecast;  // string |  layerd id (only one layer is supported and required) that matches the gridPlot id as configured in the gridDisplay. Every gridPlot that has been configured in the grid display configuration represents a WMS layer.
            var x = 458757.12883912364;  // double | x position on the map in EPSG:3857 format.
            var y = 5811252.569955047;  // double | y position on the map in EPSG:3857 format.
            var externalForecastTime = 2020-03-18T15:00Z;  // DateTime? | Time value of external forecast time. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var ensembleId = "ensembleId_example";  // string | Used in combination with ensembleMemberId to identify a unique ensemble. <i>Since: 2020.01</i> (optional) 
            var ensembleMemberId = "ensembleMemberId_example";  // string | Used in combination with ensembleId to identify a unique ensemble <i>Since: 2020.01</i> (optional) 
            var elevation = "elevation_example";  // double? | Used for 3d data, like for example water depth, to get the timeseries of a grid point at a specific elevation. <i>Since:  2020.01</i> (optional) 
            var thinning = 15408668;  // decimal? | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 = 15408668. unit ms/pixel. (optional) 
            var importFromExternalDataSource = "true";  // string | import data from external data source, defaults to true. (optional) 
            var convertDatum = "true";  // string | Convert values from relative location height to absolute height values. (optional) 
            var showEnsembleMemberIds = "true";  // string | Show ensemble member ids instead of ensemble member indices. (optional) 
            var useDisplayUnits = "true";  // string | Export values using display units. (optional) 
            var showVerticalProfile = "true";  // string | Show vertical profile in case of 3D data. <i>Since: 2020.01</i> (optional) 
            var showThresholds = "true";  // string | Option to toggle the returning of threshold information in the headers. (optional) 
            var omitMissing = "true";  // string | Toggle omitting or returning of missing values in response. (optional) 
            var omitEmptyTimeSeries = "true";  // string | Toggle omitting or returning headers of empty timeSeries. Default is false. <i>Since: 2020.02</i> (optional) 
            var onlyManualEdits = "true";  // string | Toggle to return only manual edits. (optional) 
            var onlyHeaders = "true";  // string | Toggle to return only header information or also data. (optional) 
            var onlyForecasts = "true";  // string | Toggle to return only forecast timeSeries (Since 2017.02). (optional) 
            var showStatistics = "true";  // string | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:<ul><li>firstValueTime: First time with a value in the timeSeries</li><li>maxValue: Maximum value in the timeSeries</li><li>minValue: Minimum value in the timeSeries</li><li>valueCount: Number of values in the timeSeries</li></ul>. These statistics are only provided if there is any data, otherwise they are left out. (optional) 
            var useMilliseconds = "true";  // string | Toggle to return milliseconds in time step. (optional) 
            var showProducts = "true";  // string | Toggle to display product information that is assigned to a forecast. <i>Since: 2019.02</i> (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get the timeseries containing the data from a grid cell for a request period
                Timeseries200Response result = apiInstance.Timeseriesgrid(bbox, startTime, endTime, layers, x, y, externalForecastTime, ensembleId, ensembleMemberId, elevation, thinning, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showVerticalProfile, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimeseriesApi.Timeseriesgrid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TimeseriesgridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the timeseries containing the data from a grid cell for a request period
    ApiResponse<Timeseries200Response> response = apiInstance.TimeseriesgridWithHttpInfo(bbox, startTime, endTime, layers, x, y, externalForecastTime, ensembleId, ensembleMemberId, elevation, thinning, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showVerticalProfile, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimeseriesApi.TimeseriesgridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bbox** | **string** | bounding box of map that is viewed in , separated EPSG:3857 format. The order of the coordinates is as follows: bottom left X, bottom left Y, top right X, top right Y. |  |
| **startTime** | **DateTime** | Start time of search period that looks for timeseries values that are within this period. If the start time doesn&#39;t match a timestamp of the time series, the closest timestamp before the startTime, will also be returned.  Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **endTime** | **DateTime** | End time of search period that looks for timeseries values that are within this period. If the endTime doesn&#39;t match a timestamp of the time series, the closest timestamp after the endTime, will also be returned. Format: yyyy-MM-ddTHH:mm:ssZ |  |
| **layers** | **string** |  layerd id (only one layer is supported and required) that matches the gridPlot id as configured in the gridDisplay. Every gridPlot that has been configured in the grid display configuration represents a WMS layer. |  |
| **x** | **double** | x position on the map in EPSG:3857 format. |  |
| **y** | **double** | y position on the map in EPSG:3857 format. |  |
| **externalForecastTime** | **DateTime?** | Time value of external forecast time. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **ensembleId** | **string** | Used in combination with ensembleMemberId to identify a unique ensemble. &lt;i&gt;Since: 2020.01&lt;/i&gt; | [optional]  |
| **ensembleMemberId** | **string** | Used in combination with ensembleId to identify a unique ensemble &lt;i&gt;Since: 2020.01&lt;/i&gt; | [optional]  |
| **elevation** | **double?** | Used for 3d data, like for example water depth, to get the timeseries of a grid point at a specific elevation. &lt;i&gt;Since:  2020.01&lt;/i&gt; | [optional]  |
| **thinning** | **decimal?** | Thinning is used to retrieve the visually interesting time steps of timeSeries. It tries to keep the peaks and gaps and minimizes the number of time steps that have to be retrieved. It is typically used for visualizations. The value to be specified should be equal to the view period in milliseconds of the timeSeries that is visualized divided by the number of pixels that are available for display. For example: visualizing a view period of 5 years (157784760000 milliseconds) on a display of 1024 pixels, the thinning parameter should be set to 157784760000/1024 &#x3D; 15408668. unit ms/pixel. | [optional]  |
| **importFromExternalDataSource** | **string** | import data from external data source, defaults to true. | [optional]  |
| **convertDatum** | **string** | Convert values from relative location height to absolute height values. | [optional]  |
| **showEnsembleMemberIds** | **string** | Show ensemble member ids instead of ensemble member indices. | [optional]  |
| **useDisplayUnits** | **string** | Export values using display units. | [optional]  |
| **showVerticalProfile** | **string** | Show vertical profile in case of 3D data. &lt;i&gt;Since: 2020.01&lt;/i&gt; | [optional]  |
| **showThresholds** | **string** | Option to toggle the returning of threshold information in the headers. | [optional]  |
| **omitMissing** | **string** | Toggle omitting or returning of missing values in response. | [optional]  |
| **omitEmptyTimeSeries** | **string** | Toggle omitting or returning headers of empty timeSeries. Default is false. &lt;i&gt;Since: 2020.02&lt;/i&gt; | [optional]  |
| **onlyManualEdits** | **string** | Toggle to return only manual edits. | [optional]  |
| **onlyHeaders** | **string** | Toggle to return only header information or also data. | [optional]  |
| **onlyForecasts** | **string** | Toggle to return only forecast timeSeries (Since 2017.02). | [optional]  |
| **showStatistics** | **string** | Toggle to return statistics information about timeseries. Typically used in combination with onlyHeaders. Returns additional information about data availability of timeseries:&lt;ul&gt;&lt;li&gt;firstValueTime: First time with a value in the timeSeries&lt;/li&gt;&lt;li&gt;maxValue: Maximum value in the timeSeries&lt;/li&gt;&lt;li&gt;minValue: Minimum value in the timeSeries&lt;/li&gt;&lt;li&gt;valueCount: Number of values in the timeSeries&lt;/li&gt;&lt;/ul&gt;. These statistics are only provided if there is any data, otherwise they are left out. | [optional]  |
| **useMilliseconds** | **string** | Toggle to return milliseconds in time step. | [optional]  |
| **showProducts** | **string** | Toggle to display product information that is assigned to a forecast. &lt;i&gt;Since: 2019.02&lt;/i&gt; | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON, DD_JSON, NOOS_TEXT,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**Timeseries200Response**](Timeseries200Response.md)

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

