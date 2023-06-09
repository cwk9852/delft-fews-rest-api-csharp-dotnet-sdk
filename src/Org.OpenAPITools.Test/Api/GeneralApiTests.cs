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
    ///  Class for testing GeneralApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GeneralApiTests : IDisposable
    {
        private GeneralApi instance;

        public GeneralApiTests()
        {
            instance = new GeneralApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GeneralApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GeneralApi
            //Assert.IsType<GeneralApi>(instance);
        }

        /// <summary>
        /// Test Oas
        /// </summary>
        [Fact]
        public void OasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Oas();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ResourcesImages
        /// </summary>
        [Fact]
        public void ResourcesImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResourcesImages();
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test ResourcesStatic
        /// </summary>
        [Fact]
        public void ResourcesStaticTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResourcesStatic();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test Systemtime
        /// </summary>
        [Fact]
        public void SystemtimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Systemtime(documentFormat, documentVersion);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test Timezoneid
        /// </summary>
        [Fact]
        public void TimezoneidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Timezoneid();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test Version
        /// </summary>
        [Fact]
        public void VersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Version(documentFormat, documentVersion);
            //Assert.IsType<PiRestVersion>(response);
        }
    }
}
