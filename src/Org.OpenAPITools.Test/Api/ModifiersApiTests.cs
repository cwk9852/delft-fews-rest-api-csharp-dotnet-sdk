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
    ///  Class for testing ModifiersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ModifiersApiTests : IDisposable
    {
        private ModifiersApi instance;

        public ModifiersApiTests()
        {
            instance = new ModifiersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ModifiersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ModifiersApi
            //Assert.IsType<ModifiersApi>(instance);
        }

        /// <summary>
        /// Test Modifiers
        /// </summary>
        [Fact]
        public void ModifiersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTimeModifiers = null;
            //DateTime? endTimeModifiers = null;
            //string modifierType = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Modifiers(startTimeModifiers, endTimeModifiers, modifierType, documentFormat, documentVersion);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Postmodifiers
        /// </summary>
        [Fact]
        public void PostmodifiersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string commitModifiers = null;
            //string deleteAllModifiers = null;
            //string piModifiersXmlContent = null;
            //var response = instance.Postmodifiers(commitModifiers, deleteAllModifiers, piModifiersXmlContent);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Timeseriesmodifiers
        /// </summary>
        [Fact]
        public void TimeseriesmodifiersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startTimeModifiers = null;
            //DateTime? endTimeModifiers = null;
            //string modifierType = null;
            //string userId = null;
            //List<string> locationIds = null;
            //List<string> moduleInstanceIds = null;
            //string onlyActiveModifiers = null;
            //string userDefinedModifierDescription = null;
            //string documentFormat = null;
            //string documentVersion = null;
            //var response = instance.Timeseriesmodifiers(startTimeModifiers, endTimeModifiers, modifierType, userId, locationIds, moduleInstanceIds, onlyActiveModifiers, userDefinedModifierDescription, documentFormat, documentVersion);
            //Assert.IsType<Object>(response);
        }
    }
}
