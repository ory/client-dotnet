/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.10
 * Contact: support@ory.sh
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

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing WellknownApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WellknownApiTests : IDisposable
    {
        private WellknownApi instance;

        public WellknownApiTests()
        {
            instance = new WellknownApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WellknownApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WellknownApi
            //Assert.IsType<WellknownApi>(instance);
        }

        /// <summary>
        /// Test DiscoverJsonWebKeys
        /// </summary>
        [Fact]
        public void DiscoverJsonWebKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DiscoverJsonWebKeys();
            //Assert.IsType<ClientJsonWebKeySet>(response);
        }
    }
}
