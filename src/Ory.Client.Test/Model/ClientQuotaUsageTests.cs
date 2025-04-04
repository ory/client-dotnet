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
    ///  Class for testing ClientQuotaUsage
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientQuotaUsageTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientQuotaUsage
        //private ClientQuotaUsage instance;

        public ClientQuotaUsageTests()
        {
            // TODO uncomment below to create an instance of ClientQuotaUsage
            //instance = new ClientQuotaUsage();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientQuotaUsage
        /// </summary>
        [Fact]
        public void ClientQuotaUsageInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientQuotaUsage
            //Assert.IsType<ClientQuotaUsage>(instance);
        }

        /// <summary>
        /// Test the property 'AdditionalPrice'
        /// </summary>
        [Fact]
        public void AdditionalPriceTest()
        {
            // TODO unit test for the property 'AdditionalPrice'
        }

        /// <summary>
        /// Test the property 'CanUseMore'
        /// </summary>
        [Fact]
        public void CanUseMoreTest()
        {
            // TODO unit test for the property 'CanUseMore'
        }

        /// <summary>
        /// Test the property 'Feature'
        /// </summary>
        [Fact]
        public void FeatureTest()
        {
            // TODO unit test for the property 'Feature'
        }

        /// <summary>
        /// Test the property 'FeatureAvailable'
        /// </summary>
        [Fact]
        public void FeatureAvailableTest()
        {
            // TODO unit test for the property 'FeatureAvailable'
        }

        /// <summary>
        /// Test the property 'Included'
        /// </summary>
        [Fact]
        public void IncludedTest()
        {
            // TODO unit test for the property 'Included'
        }

        /// <summary>
        /// Test the property 'IsUnlimited'
        /// </summary>
        [Fact]
        public void IsUnlimitedTest()
        {
            // TODO unit test for the property 'IsUnlimited'
        }

        /// <summary>
        /// Test the property 'Used'
        /// </summary>
        [Fact]
        public void UsedTest()
        {
            // TODO unit test for the property 'Used'
        }
    }
}
