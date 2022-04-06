/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.157
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
    ///  Class for testing ClientAdminIdentityImportCredentials
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientAdminIdentityImportCredentialsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientAdminIdentityImportCredentials
        //private ClientAdminIdentityImportCredentials instance;

        public ClientAdminIdentityImportCredentialsTests()
        {
            // TODO uncomment below to create an instance of ClientAdminIdentityImportCredentials
            //instance = new ClientAdminIdentityImportCredentials();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientAdminIdentityImportCredentials
        /// </summary>
        [Fact]
        public void ClientAdminIdentityImportCredentialsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientAdminIdentityImportCredentials
            //Assert.IsType<ClientAdminIdentityImportCredentials>(instance);
        }


        /// <summary>
        /// Test the property 'Oidc'
        /// </summary>
        [Fact]
        public void OidcTest()
        {
            // TODO unit test for the property 'Oidc'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

    }

}
