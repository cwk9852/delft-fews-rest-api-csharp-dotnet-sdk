# Org.OpenAPITools - the C# library for the Delft-FEWS Web Services REST API v1

Delft-FEWS Web Services REST API v1. For more information see: https://publicwiki.deltares.nl/x/fwNdBw

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1-2023-05-03T00:04:18Z
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArchiveApi.ArchiveAreas: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fewsdocs.deltares.nl/FewsWebServices/rest/fewspiservice/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ArchiveApi* | [**ArchiveAreas**](docs/ArchiveApi.md#archiveareas) | **GET** /archive/areas | Returns the available areas for the open archive, netcdf-storage and the archive database
*ArchiveApi* | [**ArchiveAttributes**](docs/ArchiveApi.md#archiveattributes) | **GET** /archive/attributes | Get attributes with their values that are available in the archive
*ArchiveApi* | [**ArchiveLocations**](docs/ArchiveApi.md#archivelocations) | **GET** /archive/locations | Get locations that are available in the archive
*ArchiveApi* | [**ArchiveModuleinstances**](docs/ArchiveApi.md#archivemoduleinstances) | **GET** /archive/moduleinstances | Returns the available module instaces for the netcdf storage
*ArchiveApi* | [**ArchiveNetcdfstorageforecasts**](docs/ArchiveApi.md#archivenetcdfstorageforecasts) | **GET** /archive/netcdfstorageforecasts | Get forecasts with its attributes from the external netcdf storage from the archive
*ArchiveApi* | [**ArchiveParameters**](docs/ArchiveApi.md#archiveparameters) | **GET** /archive/parameters | Get parameters that are available in the archive
*ArchiveApi* | [**ArchiveProducts**](docs/ArchiveApi.md#archiveproducts) | **GET** /archive/products | Returns a zip-file with the requested products or a binary file if only one file is requested, that are available in the archive filtered by the specified parameters
*ArchiveApi* | [**ArchiveProductsId**](docs/ArchiveApi.md#archiveproductsid) | **GET** /archive/products/id | Return a specific product from the archive
*ArchiveApi* | [**ArchiveProductsmetadata**](docs/ArchiveApi.md#archiveproductsmetadata) | **GET** /archive/productsmetadata | Returns a list of metadata found in the archive, where the T0 falls between the startForecastTime and endForecastTime
*ArchiveApi* | [**ArchiveSources**](docs/ArchiveApi.md#archivesources) | **GET** /archive/sources | Returns the available sources for the open archive, netcdf-storage and the archive database
*ArchiveApi* | [**PostArchiveProducts**](docs/ArchiveApi.md#postarchiveproducts) | **POST** /archive/products | upload new products to the archive
*DisplaygroupsApi* | [**DisplaygroupsNodes**](docs/DisplaygroupsApi.md#displaygroupsnodes) | **GET** /displaygroups/nodes | Get all displaygroups nodes and its plots
*DisplaygroupsApi* | [**DisplaygroupsPlot**](docs/DisplaygroupsApi.md#displaygroupsplot) | **GET** /displaygroups/plot | Get a plot image from a display group using the display group id and the display id of the plot
*EmbeddedApi* | [**FiltersSelected**](docs/EmbeddedApi.md#filtersselected) | **GET** /filters/selected | Get the currently selected filter ids in the Operator Client or a Stand Alone
*EmbeddedApi* | [**Lastupdatetime**](docs/EmbeddedApi.md#lastupdatetime) | **GET** /lastupdatetime | Get the last time the timeseries were updated in the Operator Client or a Stand Alone
*EmbeddedApi* | [**LocationsSelected**](docs/EmbeddedApi.md#locationsselected) | **GET** /locations/selected | Get the currently selected location ids in the Operator Client or a Stand Alone
*EmbeddedApi* | [**ParametersSelected**](docs/EmbeddedApi.md#parametersselected) | **GET** /parameters/selected | Get the currently selected parameter ids in the Operator Client or a Stand Alone
*EmbeddedApi* | [**TimeseriesTopologyNode**](docs/EmbeddedApi.md#timeseriestopologynode) | **GET** /timeseries/topology/node | Get the time series for the selected topology node
*EmbeddedApi* | [**TopologySelected**](docs/EmbeddedApi.md#topologyselected) | **GET** /topology/selected | Get the currently selected topology node id in the Operator Client or a Stand Alone
*FiltersApi* | [**Filters**](docs/FiltersApi.md#filters) | **GET** /filters | Get filters that are a subfilter of the default filter
*FiltersApi* | [**FiltersActions**](docs/FiltersApi.md#filtersactions) | **GET** /filters/actions | Get the actions for a set of filters
*GeneralApi* | [**Oas**](docs/GeneralApi.md#oas) | **GET** /oas | The Open Api Specification
*GeneralApi* | [**ResourcesImages**](docs/GeneralApi.md#resourcesimages) | **GET** /resources/images/{id} | Get image resources from the Delft-FEWS IconFiles config folder
*GeneralApi* | [**ResourcesStatic**](docs/GeneralApi.md#resourcesstatic) | **GET** /resources/static/{id} | Get static resources from the PiClientConfigFiles folder
*GeneralApi* | [**Systemtime**](docs/GeneralApi.md#systemtime) | **GET** /systemtime | Get the system time of the Web Service
*GeneralApi* | [**Timezoneid**](docs/GeneralApi.md#timezoneid) | **GET** /timezoneid | The ID of Configured timezone in the FewsPiService
*GeneralApi* | [**Version**](docs/GeneralApi.md#version) | **GET** /version | The version of the running web service
*ImportstatusApi* | [**ImportStatus**](docs/ImportstatusApi.md#importstatus) | **GET** /import/status | Get the status of the imports
*LocationsApi* | [**Locations**](docs/LocationsApi.md#locations) | **GET** /locations | Get locations that are available for the 'filterId' argument
*ModifiersApi* | [**Modifiers**](docs/ModifiersApi.md#modifiers) | **GET** /modifiers | Get modifiers filtered by parameters like start time, end time and modifier type
*ModifiersApi* | [**Postmodifiers**](docs/ModifiersApi.md#postmodifiers) | **POST** /modifiers | Write modifiers to the Delft-FEWS database
*ModifiersApi* | [**Timeseriesmodifiers**](docs/ModifiersApi.md#timeseriesmodifiers) | **GET** /timeseriesmodifiers | Get timeseries modifiers filtered by parameters like start time, end time and modifier type
*ModuleruntablesApi* | [**ModuleruntablesCurrent**](docs/ModuleruntablesApi.md#moduleruntablescurrent) | **GET** /moduleruntables/current | Get the current module run table in CSV format by specifying a moduleInstanceId or taskRunId
*ParametersApi* | [**Parameters**](docs/ParametersApi.md#parameters) | **GET** /parameters | Get parameters that are available for the 'filterId' argument
*ParametersApi* | [**ParametersNodes**](docs/ParametersApi.md#parametersnodes) | **GET** /parameters/nodes | Get all parameter nodes and its parameters that are available in the region config
*ProcessdataApi* | [**Processdata**](docs/ProcessdataApi.md#processdata) | **GET** /processdata | Run workflow and make processed netcdf data available as an attachment of type application/octet-stream
*QualifiersApi* | [**Qualifiers**](docs/QualifiersApi.md#qualifiers) | **GET** /qualifiers | Get all configured qualifiers from the region config and optionally show all its attributes
*RatingcurvesApi* | [**Ratingcurves**](docs/RatingcurvesApi.md#ratingcurves) | **GET** /ratingcurves | Get all configured rating curves from the region config and optionally filter by locationIds
*RatingcurvesApi* | [**RatingcurvesDischargetostage**](docs/RatingcurvesApi.md#ratingcurvesdischargetostage) | **POST** /ratingcurves/dischargetostage | Converts discharge values to stage values using a rating curve at a specific location
*RatingcurvesApi* | [**RatingcurvesStagetodischarge**](docs/RatingcurvesApi.md#ratingcurvesstagetodischarge) | **POST** /ratingcurves/stagetodischarge | Converts stage values to discharge values using a rating curve at a specific location
*SamplesApi* | [**Samples**](docs/SamplesApi.md#samples) | **GET** /samples | Get samples filtered by parameters like filterId, sampleId, parameterId and creation time of a sample
*StatesApi* | [**Warmstates**](docs/StatesApi.md#warmstates) | **GET** /warmstates | Get the warm state file for the specified module instance id and state time
*StatesApi* | [**WarmstatesTimes**](docs/StatesApi.md#warmstatestimes) | **GET** /warmstates/times | Get all the available warm state times for the specified module instance ids
*TasksApi* | [**Moduleruntimes**](docs/TasksApi.md#moduleruntimes) | **GET** /moduleruntimes | Get all expected and pending runtimes for workflows per module instance id
*TasksApi* | [**Postruntask**](docs/TasksApi.md#postruntask) | **POST** /runtask | Runs a one-off task for a given workflowId
*TasksApi* | [**Taskruns**](docs/TasksApi.md#taskruns) | **GET** /taskruns | Get all taskruns for a workflowId filtered by parameters like forecast time or taskrun status
*TasksApi* | [**Taskrunstatus**](docs/TasksApi.md#taskrunstatus) | **GET** /taskrunstatus | Track the status of a workflow using the taskId, typically used to determine if a taskrun is completed
*TimeseriesApi* | [**EnsemblesMembers**](docs/TimeseriesApi.md#ensemblesmembers) | **GET** /ensembles/members | Get all ensemble member ids for one or more ensemble Ids
*TimeseriesApi* | [**Posttimeseries**](docs/TimeseriesApi.md#posttimeseries) | **POST** /timeseries | Timeseries will be written that are part of the timeseries sets defined by the filters
*TimeseriesApi* | [**Timeseries**](docs/TimeseriesApi.md#timeseries) | **GET** /timeseries | Get timeseries that are part of the default filter
*TimeseriesApi* | [**TimeseriesDisplaygroups**](docs/TimeseriesApi.md#timeseriesdisplaygroups) | **GET** /timeseries/displaygroups | Timeseries are filtered by the plotId from the DisplayGroups
*TimeseriesApi* | [**Timeseriesgrid**](docs/TimeseriesApi.md#timeseriesgrid) | **GET** /timeseries/grid | Get the timeseries containing the data from a grid cell for a request period
*TopologyApi* | [**TopologyActions**](docs/TopologyApi.md#topologyactions) | **GET** /topology/actions | Get the display group actions for a certain topology node
*TopologyApi* | [**TopologyNodes**](docs/TopologyApi.md#topologynodes) | **GET** /topology/nodes | Returns the topology config of the fews system
*WebocApi* | [**WebocConfig**](docs/WebocApi.md#webocconfig) | **GET** /weboc/config | Get the Web OC Configuration
*WorkflowsApi* | [**Workflows**](docs/WorkflowsApi.md#workflows) | **GET** /workflows | Get all default workflow xml files in one list that are available


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ActionRequest](docs/ActionRequest.md)
 - [Model.ActionRequestConfig](docs/ActionRequestConfig.md)
 - [Model.ActionResult](docs/ActionResult.md)
 - [Model.ArchiveArea](docs/ArchiveArea.md)
 - [Model.ArchiveAttribute](docs/ArchiveAttribute.md)
 - [Model.ArchiveDisplayConfig](docs/ArchiveDisplayConfig.md)
 - [Model.ArchiveLocation](docs/ArchiveLocation.md)
 - [Model.ArchiveLocations200Response](docs/ArchiveLocations200Response.md)
 - [Model.ArchiveModuleInstance](docs/ArchiveModuleInstance.md)
 - [Model.ArchiveParameter](docs/ArchiveParameter.md)
 - [Model.ArchiveParameters200Response](docs/ArchiveParameters200Response.md)
 - [Model.ArchiveProductsMetadataAttribute](docs/ArchiveProductsMetadataAttribute.md)
 - [Model.ArchiveProductsMetadataEntry](docs/ArchiveProductsMetadataEntry.md)
 - [Model.ArchiveSource](docs/ArchiveSource.md)
 - [Model.Attributes](docs/Attributes.md)
 - [Model.DataViewerConfig](docs/DataViewerConfig.md)
 - [Model.DisplayGroupsNodes](docs/DisplayGroupsNodes.md)
 - [Model.DisplayGroupsPlotNode](docs/DisplayGroupsPlotNode.md)
 - [Model.DomainAxis](docs/DomainAxis.md)
 - [Model.DomainAxisEvent](docs/DomainAxisEvent.md)
 - [Model.DomainAxisValue](docs/DomainAxisValue.md)
 - [Model.Domains](docs/Domains.md)
 - [Model.Event](docs/Event.md)
 - [Model.ExternalNetCDFStorageForecast](docs/ExternalNetCDFStorageForecast.md)
 - [Model.ExternalNetCDFStorageForecastAttribute](docs/ExternalNetCDFStorageForecastAttribute.md)
 - [Model.FewsDate](docs/FewsDate.md)
 - [Model.Filter](docs/Filter.md)
 - [Model.GeneralConfig](docs/GeneralConfig.md)
 - [Model.Geometry](docs/Geometry.md)
 - [Model.Header](docs/Header.md)
 - [Model.IconsConfig](docs/IconsConfig.md)
 - [Model.ImportStatus](docs/ImportStatus.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationGeoJsonAttributes](docs/LocationGeoJsonAttributes.md)
 - [Model.LocationGeoJsonCrs](docs/LocationGeoJsonCrs.md)
 - [Model.LocationGeoJsonCrsProperty](docs/LocationGeoJsonCrsProperty.md)
 - [Model.LocationGeoJsonFeature](docs/LocationGeoJsonFeature.md)
 - [Model.LocationGeoJsonFeatureProperties](docs/LocationGeoJsonFeatureProperties.md)
 - [Model.LocationGeoJsonRelation](docs/LocationGeoJsonRelation.md)
 - [Model.LocationRelation](docs/LocationRelation.md)
 - [Model.ModelVersion](docs/ModelVersion.md)
 - [Model.ModuleRunTime](docs/ModuleRunTime.md)
 - [Model.ParameterNode](docs/ParameterNode.md)
 - [Model.ParameterNodeChild](docs/ParameterNodeChild.md)
 - [Model.ParameterNodeParameter](docs/ParameterNodeParameter.md)
 - [Model.ParameterNodeParent](docs/ParameterNodeParent.md)
 - [Model.PiRestActions](docs/PiRestActions.md)
 - [Model.PiRestArchiveAreas](docs/PiRestArchiveAreas.md)
 - [Model.PiRestArchiveAttributes](docs/PiRestArchiveAttributes.md)
 - [Model.PiRestArchiveExternalnetcdfstorageforecasts](docs/PiRestArchiveExternalnetcdfstorageforecasts.md)
 - [Model.PiRestArchiveLocations](docs/PiRestArchiveLocations.md)
 - [Model.PiRestArchiveParameters](docs/PiRestArchiveParameters.md)
 - [Model.PiRestArchiveProductsmetadata](docs/PiRestArchiveProductsmetadata.md)
 - [Model.PiRestArchiveSources](docs/PiRestArchiveSources.md)
 - [Model.PiRestDisplaygroupsNodes](docs/PiRestDisplaygroupsNodes.md)
 - [Model.PiRestFilters](docs/PiRestFilters.md)
 - [Model.PiRestFiltersSelected](docs/PiRestFiltersSelected.md)
 - [Model.PiRestImportstatus](docs/PiRestImportstatus.md)
 - [Model.PiRestLastupdatetime](docs/PiRestLastupdatetime.md)
 - [Model.PiRestLocations](docs/PiRestLocations.md)
 - [Model.PiRestLocationsGeo](docs/PiRestLocationsGeo.md)
 - [Model.PiRestLocationsSelected](docs/PiRestLocationsSelected.md)
 - [Model.PiRestModuleRunTimes](docs/PiRestModuleRunTimes.md)
 - [Model.PiRestModuleinstances](docs/PiRestModuleinstances.md)
 - [Model.PiRestParameters](docs/PiRestParameters.md)
 - [Model.PiRestParametersNodes](docs/PiRestParametersNodes.md)
 - [Model.PiRestParametersSelected](docs/PiRestParametersSelected.md)
 - [Model.PiRestRatingcurves](docs/PiRestRatingcurves.md)
 - [Model.PiRestRatingcurvesDischarge](docs/PiRestRatingcurvesDischarge.md)
 - [Model.PiRestRatingcurvesStage](docs/PiRestRatingcurvesStage.md)
 - [Model.PiRestSystemtime](docs/PiRestSystemtime.md)
 - [Model.PiRestTaskruns](docs/PiRestTaskruns.md)
 - [Model.PiRestTaskrunstatus](docs/PiRestTaskrunstatus.md)
 - [Model.PiRestTimeseries](docs/PiRestTimeseries.md)
 - [Model.PiRestTimeseriesEnsemblesMembers](docs/PiRestTimeseriesEnsemblesMembers.md)
 - [Model.PiRestTopologyNodes](docs/PiRestTopologyNodes.md)
 - [Model.PiRestTopologySelected](docs/PiRestTopologySelected.md)
 - [Model.PiRestVersion](docs/PiRestVersion.md)
 - [Model.PiRestWarmstateTimes](docs/PiRestWarmstateTimes.md)
 - [Model.PiRestWebocConfiguration](docs/PiRestWebocConfiguration.md)
 - [Model.PiRestWebocConfigurationComponentsInner](docs/PiRestWebocConfigurationComponentsInner.md)
 - [Model.Product](docs/Product.md)
 - [Model.ProductCategory](docs/ProductCategory.md)
 - [Model.RatingCurve](docs/RatingCurve.md)
 - [Model.RatingCurveDate](docs/RatingCurveDate.md)
 - [Model.RatingCurveEquation](docs/RatingCurveEquation.md)
 - [Model.RatingCurveHeader](docs/RatingCurveHeader.md)
 - [Model.RatingCurveProperty](docs/RatingCurveProperty.md)
 - [Model.RatingCurveRow](docs/RatingCurveRow.md)
 - [Model.RatingCurveTable](docs/RatingCurveTable.md)
 - [Model.SchematicStatusDisplayConfig](docs/SchematicStatusDisplayConfig.md)
 - [Model.SpatialDisplayConfig](docs/SpatialDisplayConfig.md)
 - [Model.SystemMonitorConfig](docs/SystemMonitorConfig.md)
 - [Model.TaskRun](docs/TaskRun.md)
 - [Model.TimeSeriesDisplayConfig](docs/TimeSeriesDisplayConfig.md)
 - [Model.TimeSeriesDisplaySubplot](docs/TimeSeriesDisplaySubplot.md)
 - [Model.TimeSeriesDisplaySubplotItem](docs/TimeSeriesDisplaySubplotItem.md)
 - [Model.TimeSeriesDisplaySubplotItemAxis](docs/TimeSeriesDisplaySubplotItemAxis.md)
 - [Model.TimeSeriesDisplaySubplotItemThreshold](docs/TimeSeriesDisplaySubplotItemThreshold.md)
 - [Model.TimeSeriesEnsembleMember](docs/TimeSeriesEnsembleMember.md)
 - [Model.TimeSeriesParameter](docs/TimeSeriesParameter.md)
 - [Model.TimeSeriesParameterAttributes](docs/TimeSeriesParameterAttributes.md)
 - [Model.TimeSeriesResult](docs/TimeSeriesResult.md)
 - [Model.TimeSeriesThreshold](docs/TimeSeriesThreshold.md)
 - [Model.TimeStep](docs/TimeStep.md)
 - [Model.TimeStepOneOf](docs/TimeStepOneOf.md)
 - [Model.TimeStepOneOf1](docs/TimeStepOneOf1.md)
 - [Model.TimeStepOneOf2](docs/TimeStepOneOf2.md)
 - [Model.Timeseries200Response](docs/Timeseries200Response.md)
 - [Model.Timeseries400Response](docs/Timeseries400Response.md)
 - [Model.TopologyDisplayGroupItem](docs/TopologyDisplayGroupItem.md)
 - [Model.TopologyDisplayGroupPlotNode](docs/TopologyDisplayGroupPlotNode.md)
 - [Model.TopologyNode](docs/TopologyNode.md)
 - [Model.WarmStateTime](docs/WarmStateTime.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: Bearer Authentication

