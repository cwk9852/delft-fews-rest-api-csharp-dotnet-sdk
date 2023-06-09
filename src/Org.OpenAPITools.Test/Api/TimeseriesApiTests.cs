/*
 * Delft-FEWS Web Services REST API v1
 *
 * Delft-FEWS Web Services REST API v1. For more information see: https://publicwiki.deltares.nl/x/fwNdBw
 *
 * The version of the OpenAPI document: v1-2023-05-03T00:04:18Z
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing TimeseriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TimeseriesApiTests : IDisposable
    {
        private TimeseriesApi instance;

        public TimeseriesApiTests()
        {
            instance = new TimeseriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimeseriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TimeseriesApi
            //Assert.IsType<TimeseriesApi>(instance);
        }

        /// <summary>
        /// Test EnsemblesMembers
        /// </summary>
        [Fact]
        public void EnsemblesMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> ensembleIds = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.EnsemblesMembers(ensembleIds, documentFormat, documentVersion);
            //Assert.IsType<PiRestTimeseriesEnsemblesMembers>(response);
        }

        /// <summary>
        /// Test Posttimeseries
        /// </summary>
        [Fact]
        public void PosttimeseriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //string convertDatum = null;
            //string piTimeSeriesXmlContent = null;
            //var response = instance.Posttimeseries(filterId, convertDatum, piTimeSeriesXmlContent);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Timeseries
        /// </summary>
        [Fact]
        public void TimeseriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //List<string> locationIds = null;
            //List<string> parameterIds = null;
            //List<string> moduleInstanceIds = null;
            //List<string> qualifierIds = null;
            //List<string> taskRunIds = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //DateTime? startCreationTime = null;
            //DateTime? endCreationTime = null;
            //decimal? forecastCount = null;
            //DateTime? startForecastTime = null;
            //DateTime? endForecastTime = null;
            //List<string> externalForecastTimes = null;
            //string ensembleId = null;
            //string ensembleMemberId = null;
            //string timeStepId = null;
            //decimal? thinning = null;
            //string exportIdMap = null;
            //string matchAsQualifierSet = null;
            //string importFromExternalDataSource = null;
            //string convertDatum = null;
            //string showEnsembleMemberIds = null;
            //string useDisplayUnits = null;
            //string showThresholds = null;
            //string omitMissing = null;
            //string omitEmptyTimeSeries = null;
            //string onlyManualEdits = null;
            //string onlyHeaders = null;
            //string onlyForecasts = null;
            //string showStatistics = null;
            //string useMilliseconds = null;
            //string showProducts = null;
            //string timeSeriesType = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Timeseries(filterId, locationIds, parameterIds, moduleInstanceIds, qualifierIds, taskRunIds, startTime, endTime, startCreationTime, endCreationTime, forecastCount, startForecastTime, endForecastTime, externalForecastTimes, ensembleId, ensembleMemberId, timeStepId, thinning, exportIdMap, matchAsQualifierSet, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
            //Assert.IsType<Timeseries200Response>(response);
        }

        /// <summary>
        /// Test TimeseriesDisplaygroups
        /// </summary>
        [Fact]
        public void TimeseriesDisplaygroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string plotId = null;
            //List<string> locationIds = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //decimal? thinning = null;
            //string convertDatum = null;
            //string showEnsembleMemberIds = null;
            //string useDisplayUnits = null;
            //string showThresholds = null;
            //string omitMissing = null;
            //string omitEmptyTimeSeries = null;
            //string onlyHeaders = null;
            //string onlyManualEdits = null;
            //string onlyForecasts = null;
            //string showStatistics = null;
            //string useMilliseconds = null;
            //string showProducts = null;
            //string timeSeriesType = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.TimeseriesDisplaygroups(plotId, locationIds, startTime, endTime, thinning, convertDatum, showEnsembleMemberIds, useDisplayUnits, showThresholds, omitMissing, omitEmptyTimeSeries, onlyHeaders, onlyManualEdits, onlyForecasts, showStatistics, useMilliseconds, showProducts, timeSeriesType, documentFormat, documentVersion);
            //Assert.IsType<Timeseries200Response>(response);
        }

        /// <summary>
        /// Test Timeseriesgrid
        /// </summary>
        [Fact]
        public void TimeseriesgridTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bbox = null;
            //DateTime startTime = null;
            //DateTime endTime = null;
            //string layers = null;
            //double x = null;
            //double y = null;
            //DateTime? externalForecastTime = null;
            //string ensembleId = null;
            //string ensembleMemberId = null;
            //double? elevation = null;
            //decimal? thinning = null;
            //string importFromExternalDataSource = null;
            //string convertDatum = null;
            //string showEnsembleMemberIds = null;
            //string useDisplayUnits = null;
            //string showVerticalProfile = null;
            //string showThresholds = null;
            //string omitMissing = null;
            //string omitEmptyTimeSeries = null;
            //string onlyManualEdits = null;
            //string onlyHeaders = null;
            //string onlyForecasts = null;
            //string showStatistics = null;
            //string useMilliseconds = null;
            //string showProducts = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Timeseriesgrid(bbox, startTime, endTime, layers, x, y, externalForecastTime, ensembleId, ensembleMemberId, elevation, thinning, importFromExternalDataSource, convertDatum, showEnsembleMemberIds, useDisplayUnits, showVerticalProfile, showThresholds, omitMissing, omitEmptyTimeSeries, onlyManualEdits, onlyHeaders, onlyForecasts, showStatistics, useMilliseconds, showProducts, documentFormat, documentVersion);
            //Assert.IsType<Timeseries200Response>(response);
        }
    }
}
