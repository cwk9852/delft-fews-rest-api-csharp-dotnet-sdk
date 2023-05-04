# Org.OpenAPITools.Model.Header
The header

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | TimeSeries type | 
**ModuleInstanceId** | **string** | Module Instance Id | [optional] 
**LocationId** | **string** | Location id | 
**ParameterId** | **string** | Parameter id | 
**QualifierId** | **List&lt;string&gt;** | Qualifier Id | [optional] 
**EnsembleId** | **string** | Ensemble Id. Can be followed by either a ensembleMemberIndex or ensembleMemberId | [optional] 
**EnsembleMemberIndex** | **string** | Ensemble Member Index | [optional] 
**EnsembleMemberId** | **string** | Ensemble Member Id | [optional] 
**TimeStep** | [**TimeStep**](TimeStep.md) |  | [optional] 
**StartDate** | [**FewsDate**](FewsDate.md) |  | 
**EndDate** | [**FewsDate**](FewsDate.md) |  | 
**ForecastDate** | [**FewsDate**](FewsDate.md) |  | [optional] 
**MissVal** | **string** | Missing value | 
**LongName** | **string** | Long name | [optional] 
**StationName** | **string** | Station name | [optional] 
**Lat** | **string** | Latitude | [optional] 
**Lon** | **string** | Longitude | [optional] 
**X** | **string** | X | [optional] 
**Y** | **string** | Y | [optional] 
**Z** | **string** | Z | [optional] 
**Units** | **string** | Units | [optional] 
**DomainAxis** | [**List&lt;DomainAxis&gt;**](DomainAxis.md) | Domain Axis | [optional] 
**SourceOrganisation** | **string** | Source Organisation | [optional] 
**SourceSystem** | **string** | Source System | [optional] 
**FileDescription** | **string** | File Descriptor | [optional] 
**CreationDate** | **string** | Creation date | [optional] 
**CreationTime** | **string** | Creation time | [optional] 
**ApprovedDate** | [**FewsDate**](FewsDate.md) |  | [optional] 
**Region** | **string** | Region | [optional] 
**Thresholds** | [**List&lt;TimeSeriesThreshold&gt;**](TimeSeriesThreshold.md) | Thresholds | [optional] 
**FirstValueTime** | [**FewsDate**](FewsDate.md) |  | [optional] 
**LastValueTime** | [**FewsDate**](FewsDate.md) |  | [optional] 
**MaxValue** | **string** | Max value | [optional] 
**MinValue** | **string** | Min value | [optional] 
**ValueCount** | **string** | Value count | [optional] 
**MaxWarningLevelName** | **string** | Max Warning Level Name | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

