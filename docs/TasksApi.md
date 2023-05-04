# Org.OpenAPITools.Api.TasksApi

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Moduleruntimes**](TasksApi.md#moduleruntimes) | **GET** /moduleruntimes | Get all expected and pending runtimes for workflows per module instance id |
| [**Postruntask**](TasksApi.md#postruntask) | **POST** /runtask | Runs a one-off task for a given workflowId |
| [**Taskruns**](TasksApi.md#taskruns) | **GET** /taskruns | Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status |
| [**Taskrunstatus**](TasksApi.md#taskrunstatus) | **GET** /taskrunstatus | Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed |

<a name="moduleruntimes"></a>
# **Moduleruntimes**
> PiRestModuleRunTimes Moduleruntimes (string workflowId = null, string documentFormat = null, string documentVersion = null)

Get all expected and pending runtimes for workflows per module instance id

Get all expected and pending runtimes for workflows per module instance id. The list can optionally be filtered by workflowId.  Only workflows of scheduled tasks that contain module instance descriptors that have been configured with updateModuleRunTimesOnCompletion enabled, will be available in this end point. The expected start time of a module is calculated based on the scheduled next due time and the expected pending duration time. The expected end time of a module is calculated based on the scheduled next due time, the expected pending duration time and the expected running time. For triggered tasks, the expected start time en end time won't be available until the task is actually started. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModuleruntimesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TasksApi(config);
            var workflowId = "workflowId_example";  // string | Filter module run time with the specified workflowId (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all expected and pending runtimes for workflows per module instance id
                PiRestModuleRunTimes result = apiInstance.Moduleruntimes(workflowId, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.Moduleruntimes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModuleruntimesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all expected and pending runtimes for workflows per module instance id
    ApiResponse<PiRestModuleRunTimes> response = apiInstance.ModuleruntimesWithHttpInfo(workflowId, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.ModuleruntimesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** | Filter module run time with the specified workflowId | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestModuleRunTimes**](PiRestModuleRunTimes.md)

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

<a name="postruntask"></a>
# **Postruntask**
> string Postruntask (string workflowId, DateTime? startTime = null, DateTime? endTime = null, DateTime? timeZero = null, string coldStateId = null, string scenarioId = null, string userId = null, string description = null, string runOption = null, string piParametersXmlContent = null)

Runs a one-off task for a given workflowId

Runs a one-off task for a given workflowId. The application/x-www-form-urlencoded encoding has to be used. Returns a handle to the task in the form of a taskId. This taskId can be used to track the status of the workflow using the taskrunstatus method. Since 2018.02 it is possible to use a workflow descriptor attribute: waitWhenAlreadyRunning. This will allow running a task that hasn't been scheduled to wait when another task of that workflow is already running. Since 2022.02 properties can be included in the url. These will be used as taskRunProperties, and override global or workflow properties. Each property has to be added to the URL separately. Example: &property(fileName)=exportFile&property(outputValue)=9.0 , where the name of the property is fileName, the value is exportFile. The name of the second property is outputValue, the value is 9.0

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PostruntaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TasksApi(config);
            var workflowId = "workflowId_example";  // string | Workflow Identifier of the task to run
            var startTime = 2020-03-18T15:00Z;  // DateTime? | Start of run period. Used for state selection period. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var endTime = 2020-03-18T15:00Z;  // DateTime? | End of run period. Used to define forecast length. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var timeZero = 2020-03-18T15:00Z;  // DateTime? | Forecast time zero. If missing System time is used. Format: yyyy-MM-ddTHH:mm:ssZ (optional) 
            var coldStateId = "coldStateId_example";  // string | Cold state id (optional) 
            var scenarioId = "scenarioId_example";  // string | Id of a predefined WhatIf scenario. Can be used to alter run parameters  (optional) 
            var userId = "userId_example";  // string | User id of the user that runs the task (optional) 
            var description = "description_example";  // string | Descriptive text to identify run (optional) 
            var runOption = "all";  // string | Run option can be any of: all, alloneatatime or allmostrecentonly. If not set, the default is used: all.\\nall: Multiple instances of this workflow can run simultaneously. alloneatatime: Running (and queued) instances of this workflow prevail. allmostrecentonly: A running instance of this workflow prevails. Queued instances of this workflow will be replaced by a recent one. <i>Since: 2022.02</i> (optional) 
            var piParametersXmlContent = "piParametersXmlContent_example";  // string | URL Encoded model parameters content that validates against the following xsd: https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_modelparameters.xsd (optional) 

            try
            {
                // Runs a one-off task for a given workflowId
                string result = apiInstance.Postruntask(workflowId, startTime, endTime, timeZero, coldStateId, scenarioId, userId, description, runOption, piParametersXmlContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.Postruntask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostruntaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Runs a one-off task for a given workflowId
    ApiResponse<string> response = apiInstance.PostruntaskWithHttpInfo(workflowId, startTime, endTime, timeZero, coldStateId, scenarioId, userId, description, runOption, piParametersXmlContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.PostruntaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** | Workflow Identifier of the task to run |  |
| **startTime** | **DateTime?** | Start of run period. Used for state selection period. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **endTime** | **DateTime?** | End of run period. Used to define forecast length. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **timeZero** | **DateTime?** | Forecast time zero. If missing System time is used. Format: yyyy-MM-ddTHH:mm:ssZ | [optional]  |
| **coldStateId** | **string** | Cold state id | [optional]  |
| **scenarioId** | **string** | Id of a predefined WhatIf scenario. Can be used to alter run parameters  | [optional]  |
| **userId** | **string** | User id of the user that runs the task | [optional]  |
| **description** | **string** | Descriptive text to identify run | [optional]  |
| **runOption** | **string** | Run option can be any of: all, alloneatatime or allmostrecentonly. If not set, the default is used: all.\\nall: Multiple instances of this workflow can run simultaneously. alloneatatime: Running (and queued) instances of this workflow prevail. allmostrecentonly: A running instance of this workflow prevails. Queued instances of this workflow will be replaced by a recent one. &lt;i&gt;Since: 2022.02&lt;/i&gt; | [optional]  |
| **piParametersXmlContent** | **string** | URL Encoded model parameters content that validates against the following xsd: https://fewsdocs.deltares.nl/schemas/version1.0/pi-schemas/pi_modelparameters.xsd | [optional]  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

<a name="taskruns"></a>
# **Taskruns**
> PiRestTaskruns Taskruns (string workflowId, string whatIfId = null, string mcId = null, DateTime? startForecastTime = null, DateTime? endForecastTime = null, DateTime? startDispatchTime = null, DateTime? endDispatchTime = null, List<string> taskRunStatusIds = null, string onlyForecasts = null, string onlyCurrent = null, string documentFormat = null, string documentVersion = null)

Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status

Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status. Default only taskruns of forecasts are returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaskrunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TasksApi(config);
            var workflowId = "workflowId_example";  // string | Workflow Id
            var whatIfId = "whatIfId_example";  // string | WhatIf Id (optional) 
            var mcId = "mcId_example";  // string | Filter by mcId. <i>Since: 2021.01</i> (optional) 
            var startForecastTime = 2020-03-18T15:00Z;  // DateTime? | Forecast Start time task run (optional) 
            var endForecastTime = 2020-03-18T15:00Z;  // DateTime? | Forecast end time task run (optional) 
            var startDispatchTime = 2020-03-18T15:00Z;  // DateTime? | Dispatch Start time task run (optional) 
            var endDispatchTime = 2020-03-18T15:00Z;  // DateTime? | Dispatch end time task run (optional) 
            var taskRunStatusIds = new List<string>(); // List<string> | Task run status ids (optional) 
            var onlyForecasts = "true";  // string | Toggle to return only forecast timeSeries (Since 2017.02). Default is 'true' (optional) 
            var onlyCurrent = "true";  // string | Only Current Forecast (optional) 
            var documentFormat = "PI_XML";  // string | Supported Document Format: PI_XML, PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status
                PiRestTaskruns result = apiInstance.Taskruns(workflowId, whatIfId, mcId, startForecastTime, endForecastTime, startDispatchTime, endDispatchTime, taskRunStatusIds, onlyForecasts, onlyCurrent, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.Taskruns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaskrunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status
    ApiResponse<PiRestTaskruns> response = apiInstance.TaskrunsWithHttpInfo(workflowId, whatIfId, mcId, startForecastTime, endForecastTime, startDispatchTime, endDispatchTime, taskRunStatusIds, onlyForecasts, onlyCurrent, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.TaskrunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workflowId** | **string** | Workflow Id |  |
| **whatIfId** | **string** | WhatIf Id | [optional]  |
| **mcId** | **string** | Filter by mcId. &lt;i&gt;Since: 2021.01&lt;/i&gt; | [optional]  |
| **startForecastTime** | **DateTime?** | Forecast Start time task run | [optional]  |
| **endForecastTime** | **DateTime?** | Forecast end time task run | [optional]  |
| **startDispatchTime** | **DateTime?** | Dispatch Start time task run | [optional]  |
| **endDispatchTime** | **DateTime?** | Dispatch end time task run | [optional]  |
| **taskRunStatusIds** | [**List&lt;string&gt;**](string.md) | Task run status ids | [optional]  |
| **onlyForecasts** | **string** | Toggle to return only forecast timeSeries (Since 2017.02). Default is &#39;true&#39; | [optional]  |
| **onlyCurrent** | **string** | Only Current Forecast | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_XML, PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestTaskruns**](PiRestTaskruns.md)

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

<a name="taskrunstatus"></a>
# **Taskrunstatus**
> PiRestTaskrunstatus Taskrunstatus (string taskId, decimal? maxWaitMillis = null, string documentFormat = null, string documentVersion = null)

Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed

Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed.<p>Possible response codes are:<ul><li>I = Invalid<li>P = Pending</li><li>T = Terminated<li>R = running</li><li>F = Failed</li><li>C = Completed fully successful</li><li>D = Completed partly successful</li><li>A = Approved</li><li>B = Approved partly successful</li><li>null = No status available (produces when method call times-out)</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TaskrunstatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskId = "taskId_example";  // string | Task Id
            var maxWaitMillis = 8.9M;  // decimal? | Max waiting time in milliseconds (optional) 
            var documentFormat = "PI_JSON";  // string | Supported Document Format: PI_JSON,  (optional) 
            var documentVersion = "documentVersion_example";  // string | Document Version. Latest version is: 1.33 (optional) 

            try
            {
                // Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed
                PiRestTaskrunstatus result = apiInstance.Taskrunstatus(taskId, maxWaitMillis, documentFormat, documentVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.Taskrunstatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TaskrunstatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed
    ApiResponse<PiRestTaskrunstatus> response = apiInstance.TaskrunstatusWithHttpInfo(taskId, maxWaitMillis, documentFormat, documentVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.TaskrunstatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskId** | **string** | Task Id |  |
| **maxWaitMillis** | **decimal?** | Max waiting time in milliseconds | [optional]  |
| **documentFormat** | **string** | Supported Document Format: PI_JSON,  | [optional]  |
| **documentVersion** | **string** | Document Version. Latest version is: 1.33 | [optional]  |

### Return type

[**PiRestTaskrunstatus**](PiRestTaskrunstatus.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/plain, plain/text


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** |  |  -  |
| **401** |  |  -  |
| **403** |  |  -  |
| **500** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

