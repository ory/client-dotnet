/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientLoginFlow
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientLoginFlowTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientLoginFlow
        //private ClientLoginFlow instance;

        public ClientLoginFlowTests()
        {
            // TODO uncomment below to create an instance of ClientLoginFlow
            //instance = new ClientLoginFlow();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientLoginFlow
        /// </summary>
        [Fact]
        public void ClientLoginFlowInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientLoginFlow
            //Assert.IsType<ClientLoginFlow>(instance);
        }

        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
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
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'IssuedAt'
        /// </summary>
        [Fact]
        public void IssuedAtTest()
        {
            // TODO unit test for the property 'IssuedAt'
        }

        /// <summary>
        /// Test the property 'Oauth2LoginChallenge'
        /// </summary>
        [Fact]
        public void Oauth2LoginChallengeTest()
        {
            // TODO unit test for the property 'Oauth2LoginChallenge'
        }

        /// <summary>
        /// Test the property 'Oauth2LoginRequest'
        /// </summary>
        [Fact]
        public void Oauth2LoginRequestTest()
        {
            // TODO unit test for the property 'Oauth2LoginRequest'
        }

        /// <summary>
        /// Test the property 'OrganizationId'
        /// </summary>
        [Fact]
        public void OrganizationIdTest()
        {
            // TODO unit test for the property 'OrganizationId'
        }

        /// <summary>
        /// Test the property 'Refresh'
        /// </summary>
        [Fact]
        public void RefreshTest()
        {
            // TODO unit test for the property 'Refresh'
        }

        /// <summary>
        /// Test the property 'RequestUrl'
        /// </summary>
        [Fact]
        public void RequestUrlTest()
        {
            // TODO unit test for the property 'RequestUrl'
        }

        /// <summary>
        /// Test the property 'RequestedAal'
        /// </summary>
        [Fact]
        public void RequestedAalTest()
        {
            // TODO unit test for the property 'RequestedAal'
        }

        /// <summary>
        /// Test the property 'ReturnTo'
        /// </summary>
        [Fact]
        public void ReturnToTest()
        {
            // TODO unit test for the property 'ReturnTo'
        }

        /// <summary>
        /// Test the property 'SessionTokenExchangeCode'
        /// </summary>
        [Fact]
        public void SessionTokenExchangeCodeTest()
        {
            // TODO unit test for the property 'SessionTokenExchangeCode'
        }

        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }

        /// <summary>
        /// Test the property 'TransientPayload'
        /// </summary>
        [Fact]
        public void TransientPayloadTest()
        {
            // TODO unit test for the property 'TransientPayload'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Ui'
        /// </summary>
        [Fact]
        public void UiTest()
        {
            // TODO unit test for the property 'Ui'
        }

        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
    }
}
