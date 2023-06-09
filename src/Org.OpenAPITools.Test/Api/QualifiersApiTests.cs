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

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing QualifiersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class QualifiersApiTests : IDisposable
    {
        private QualifiersApi instance;

        public QualifiersApiTests()
        {
            instance = new QualifiersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QualifiersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' QualifiersApi
            //Assert.IsType<QualifiersApi>(instance);
        }

        /// <summary>
        /// Test Qualifiers
        /// </summary>
        [Fact]
        public void QualifiersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string showAttributes = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Qualifiers(showAttributes, documentFormat, documentVersion);
            //Assert.IsType<Object>(response);
        }
    }
}
