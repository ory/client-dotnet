/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
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
    ///  Class for testing ClientUpdateLoginFlowBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientUpdateLoginFlowBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientUpdateLoginFlowBody
        //private ClientUpdateLoginFlowBody instance;

        public ClientUpdateLoginFlowBodyTests()
        {
            // TODO uncomment below to create an instance of ClientUpdateLoginFlowBody
            //instance = new ClientUpdateLoginFlowBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientUpdateLoginFlowBody
        /// </summary>
        [Fact]
        public void ClientUpdateLoginFlowBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientUpdateLoginFlowBody
            //Assert.IsType<ClientUpdateLoginFlowBody>(instance);
        }

        /// <summary>
        /// Test the property 'CsrfToken'
        /// </summary>
        [Fact]
        public void CsrfTokenTest()
        {
            // TODO unit test for the property 'CsrfToken'
        }

        /// <summary>
        /// Test the property 'Identifier'
        /// </summary>
        [Fact]
        public void IdentifierTest()
        {
            // TODO unit test for the property 'Identifier'
        }

        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Fact]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }

        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

        /// <summary>
        /// Test the property 'PasswordIdentifier'
        /// </summary>
        [Fact]
        public void PasswordIdentifierTest()
        {
            // TODO unit test for the property 'PasswordIdentifier'
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
        /// Test the property 'IdToken'
        /// </summary>
        [Fact]
        public void IdTokenTest()
        {
            // TODO unit test for the property 'IdToken'
        }

        /// <summary>
        /// Test the property 'IdTokenNonce'
        /// </summary>
        [Fact]
        public void IdTokenNonceTest()
        {
            // TODO unit test for the property 'IdTokenNonce'
        }

        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }

        /// <summary>
        /// Test the property 'Traits'
        /// </summary>
        [Fact]
        public void TraitsTest()
        {
            // TODO unit test for the property 'Traits'
        }

        /// <summary>
        /// Test the property 'UpstreamParameters'
        /// </summary>
        [Fact]
        public void UpstreamParametersTest()
        {
            // TODO unit test for the property 'UpstreamParameters'
        }

        /// <summary>
        /// Test the property 'TotpCode'
        /// </summary>
        [Fact]
        public void TotpCodeTest()
        {
            // TODO unit test for the property 'TotpCode'
        }

        /// <summary>
        /// Test the property 'WebauthnLogin'
        /// </summary>
        [Fact]
        public void WebauthnLoginTest()
        {
            // TODO unit test for the property 'WebauthnLogin'
        }

        /// <summary>
        /// Test the property 'LookupSecret'
        /// </summary>
        [Fact]
        public void LookupSecretTest()
        {
            // TODO unit test for the property 'LookupSecret'
        }

        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Fact]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'Resend'
        /// </summary>
        [Fact]
        public void ResendTest()
        {
            // TODO unit test for the property 'Resend'
        }

        /// <summary>
        /// Test the property 'PasskeyLogin'
        /// </summary>
        [Fact]
        public void PasskeyLoginTest()
        {
            // TODO unit test for the property 'PasskeyLogin'
        }
    }
}
