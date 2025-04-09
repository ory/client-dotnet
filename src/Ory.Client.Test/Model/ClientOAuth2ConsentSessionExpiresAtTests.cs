/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.5
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
    ///  Class for testing ClientOAuth2ConsentSessionExpiresAt
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientOAuth2ConsentSessionExpiresAtTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientOAuth2ConsentSessionExpiresAt
        //private ClientOAuth2ConsentSessionExpiresAt instance;

        public ClientOAuth2ConsentSessionExpiresAtTests()
        {
            // TODO uncomment below to create an instance of ClientOAuth2ConsentSessionExpiresAt
            //instance = new ClientOAuth2ConsentSessionExpiresAt();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientOAuth2ConsentSessionExpiresAt
        /// </summary>
        [Fact]
        public void ClientOAuth2ConsentSessionExpiresAtInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientOAuth2ConsentSessionExpiresAt
            //Assert.IsType<ClientOAuth2ConsentSessionExpiresAt>(instance);
        }

        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Fact]
        public void AccessTokenTest()
        {
            // TODO unit test for the property 'AccessToken'
        }

        /// <summary>
        /// Test the property 'AuthorizeCode'
        /// </summary>
        [Fact]
        public void AuthorizeCodeTest()
        {
            // TODO unit test for the property 'AuthorizeCode'
        }

        /// <summary>
        /// Test the property 'IdToken'
        /// </summary>
        [Fact]
        public void IdTokenTest()
        {
            // TODO unit test for the property 'IdToken'
        }

        /// <summary>
        /// Test the property 'ParContext'
        /// </summary>
        [Fact]
        public void ParContextTest()
        {
            // TODO unit test for the property 'ParContext'
        }

        /// <summary>
        /// Test the property 'RefreshToken'
        /// </summary>
        [Fact]
        public void RefreshTokenTest()
        {
            // TODO unit test for the property 'RefreshToken'
        }
    }
}
