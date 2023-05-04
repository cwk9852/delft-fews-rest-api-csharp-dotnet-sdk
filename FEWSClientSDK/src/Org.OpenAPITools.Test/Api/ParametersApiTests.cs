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
    ///  Class for testing ParametersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ParametersApiTests : IDisposable
    {
        private ParametersApi instance;

        public ParametersApiTests()
        {
            instance = new ParametersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ParametersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ParametersApi
            //Assert.IsType<ParametersApi>(instance);
        }

        /// <summary>
        /// Test Parameters
        /// </summary>
        [Fact]
        public void ParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //string showAttributes = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Parameters(filterId, showAttributes, documentFormat, documentVersion);
            //Assert.IsType<PiRestParameters>(response);
        }

        /// <summary>
        /// Test ParametersNodes
        /// </summary>
        [Fact]
        public void ParametersNodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.ParametersNodes(documentFormat, documentVersion);
            //Assert.IsType<PiRestParametersNodes>(response);
        }
    }
}
