# Org.OpenAPITools.Model.TaskRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | the id of the task run | 
**Forecast** | **bool** | Indicates if the task run is a forecast run or not | 
**Current** | **bool** | Indicates if the task run is current or not | 
**Status** | **string** | Current status of the task run. | 
**WorkflowId** | **string** | The id of the workflow | 
**DispatchTime** | **string** | The time at which the run was started | [optional] 
**CompletionTime** | **string** | The time at which the run was completed | [optional] 
**Time0** | **string** | The time zero of the task run | 
**User** | **string** | The user who started the task | 
**Description** | **string** | The description of the task run | 
**FssId** | **string** | The id of the forecasting shell which executed this task | [optional] 
**OutputStartTime** | **string** | The start time of the period for which data is available | [optional] 
**OutputEndTime** | **string** | The end time of the period for which data is available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

