/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.3
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
    ///  Class for testing ClientIntrospectedOAuth2Token
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientIntrospectedOAuth2TokenTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientIntrospectedOAuth2Token
        //private ClientIntrospectedOAuth2Token instance;

        public ClientIntrospectedOAuth2TokenTests()
        {
            // TODO uncomment below to create an instance of ClientIntrospectedOAuth2Token
            //instance = new ClientIntrospectedOAuth2Token();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientIntrospectedOAuth2Token
        /// </summary>
        [Fact]
        public void ClientIntrospectedOAuth2TokenInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientIntrospectedOAuth2Token
            //Assert.IsType<ClientIntrospectedOAuth2Token>(instance);
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
        /// Test the property 'Aud'
        /// </summary>
        [Fact]
        public void AudTest()
        {
            // TODO unit test for the property 'Aud'
        }

        /// <summary>
        /// Test the property 'ClientId'
        /// </summary>
        [Fact]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }

        /// <summary>
        /// Test the property 'Exp'
        /// </summary>
        [Fact]
        public void ExpTest()
        {
            // TODO unit test for the property 'Exp'
        }

        /// <summary>
        /// Test the property 'Ext'
        /// </summary>
        [Fact]
        public void ExtTest()
        {
            // TODO unit test for the property 'Ext'
        }

        /// <summary>
        /// Test the property 'Iat'
        /// </summary>
        [Fact]
        public void IatTest()
        {
            // TODO unit test for the property 'Iat'
        }

        /// <summary>
        /// Test the property 'Iss'
        /// </summary>
        [Fact]
        public void IssTest()
        {
            // TODO unit test for the property 'Iss'
        }

        /// <summary>
        /// Test the property 'Nbf'
        /// </summary>
        [Fact]
        public void NbfTest()
        {
            // TODO unit test for the property 'Nbf'
        }

        /// <summary>
        /// Test the property 'ObfuscatedSubject'
        /// </summary>
        [Fact]
        public void ObfuscatedSubjectTest()
        {
            // TODO unit test for the property 'ObfuscatedSubject'
        }

        /// <summary>
        /// Test the property 'Scope'
        /// </summary>
        [Fact]
        public void ScopeTest()
        {
            // TODO unit test for the property 'Scope'
        }

        /// <summary>
        /// Test the property 'Sub'
        /// </summary>
        [Fact]
        public void SubTest()
        {
            // TODO unit test for the property 'Sub'
        }

        /// <summary>
        /// Test the property 'TokenType'
        /// </summary>
        [Fact]
        public void TokenTypeTest()
        {
            // TODO unit test for the property 'TokenType'
        }

        /// <summary>
        /// Test the property 'TokenUse'
        /// </summary>
        [Fact]
        public void TokenUseTest()
        {
            // TODO unit test for the property 'TokenUse'
        }

        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Fact]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }
    }
}
