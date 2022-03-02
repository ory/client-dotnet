/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.111
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Api;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientSelfServiceRecoveryLink
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientSelfServiceRecoveryLinkTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientSelfServiceRecoveryLink
        //private ClientSelfServiceRecoveryLink instance;

        public ClientSelfServiceRecoveryLinkTests()
        {
            // TODO uncomment below to create an instance of ClientSelfServiceRecoveryLink
            //instance = new ClientSelfServiceRecoveryLink();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientSelfServiceRecoveryLink
        /// </summary>
        [Fact]
        public void ClientSelfServiceRecoveryLinkInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientSelfServiceRecoveryLink
            //Assert.IsType<ClientSelfServiceRecoveryLink>(instance);
        }


        /// <summary>
        /// Test the property 'ExpiresAt'
        /// </summary>
        [Fact]
        public void ExpiresAtTest()
        {
            // TODO unit test for the property 'ExpiresAt'
        }
        /// <summary>
        /// Test the property 'RecoveryLink'
        /// </summary>
        [Fact]
        public void RecoveryLinkTest()
        {
            // TODO unit test for the property 'RecoveryLink'
        }

    }

}
