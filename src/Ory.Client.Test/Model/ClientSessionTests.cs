/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.17.2
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
    ///  Class for testing ClientSession
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientSessionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientSession
        //private ClientSession instance;

        public ClientSessionTests()
        {
            // TODO uncomment below to create an instance of ClientSession
            //instance = new ClientSession();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientSession
        /// </summary>
        [Fact]
        public void ClientSessionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientSession
            //Assert.IsType<ClientSession>(instance);
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
        /// Test the property 'AuthenticatedAt'
        /// </summary>
        [Fact]
        public void AuthenticatedAtTest()
        {
            // TODO unit test for the property 'AuthenticatedAt'
        }

        /// <summary>
        /// Test the property 'AuthenticationMethods'
        /// </summary>
        [Fact]
        public void AuthenticationMethodsTest()
        {
            // TODO unit test for the property 'AuthenticationMethods'
        }

        /// <summary>
        /// Test the property 'AuthenticatorAssuranceLevel'
        /// </summary>
        [Fact]
        public void AuthenticatorAssuranceLevelTest()
        {
            // TODO unit test for the property 'AuthenticatorAssuranceLevel'
        }

        /// <summary>
        /// Test the property 'Devices'
        /// </summary>
        [Fact]
        public void DevicesTest()
        {
            // TODO unit test for the property 'Devices'
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
        /// Test the property 'Identity'
        /// </summary>
        [Fact]
        public void IdentityTest()
        {
            // TODO unit test for the property 'Identity'
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
        /// Test the property 'Tokenized'
        /// </summary>
        [Fact]
        public void TokenizedTest()
        {
            // TODO unit test for the property 'Tokenized'
        }
    }
}
