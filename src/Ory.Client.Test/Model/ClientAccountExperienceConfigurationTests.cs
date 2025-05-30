/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.11
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
    ///  Class for testing ClientAccountExperienceConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientAccountExperienceConfigurationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientAccountExperienceConfiguration
        //private ClientAccountExperienceConfiguration instance;

        public ClientAccountExperienceConfigurationTests()
        {
            // TODO uncomment below to create an instance of ClientAccountExperienceConfiguration
            //instance = new ClientAccountExperienceConfiguration();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientAccountExperienceConfiguration
        /// </summary>
        [Fact]
        public void ClientAccountExperienceConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientAccountExperienceConfiguration
            //Assert.IsType<ClientAccountExperienceConfiguration>(instance);
        }

        /// <summary>
        /// Test the property 'DefaultLocale'
        /// </summary>
        [Fact]
        public void DefaultLocaleTest()
        {
            // TODO unit test for the property 'DefaultLocale'
        }

        /// <summary>
        /// Test the property 'DefaultRedirectUrl'
        /// </summary>
        [Fact]
        public void DefaultRedirectUrlTest()
        {
            // TODO unit test for the property 'DefaultRedirectUrl'
        }

        /// <summary>
        /// Test the property 'ErrorUiUrl'
        /// </summary>
        [Fact]
        public void ErrorUiUrlTest()
        {
            // TODO unit test for the property 'ErrorUiUrl'
        }

        /// <summary>
        /// Test the property 'FaviconDarkUrl'
        /// </summary>
        [Fact]
        public void FaviconDarkUrlTest()
        {
            // TODO unit test for the property 'FaviconDarkUrl'
        }

        /// <summary>
        /// Test the property 'FaviconLightUrl'
        /// </summary>
        [Fact]
        public void FaviconLightUrlTest()
        {
            // TODO unit test for the property 'FaviconLightUrl'
        }

        /// <summary>
        /// Test the property 'LocaleBehavior'
        /// </summary>
        [Fact]
        public void LocaleBehaviorTest()
        {
            // TODO unit test for the property 'LocaleBehavior'
        }

        /// <summary>
        /// Test the property 'LoginUiUrl'
        /// </summary>
        [Fact]
        public void LoginUiUrlTest()
        {
            // TODO unit test for the property 'LoginUiUrl'
        }

        /// <summary>
        /// Test the property 'LogoDarkUrl'
        /// </summary>
        [Fact]
        public void LogoDarkUrlTest()
        {
            // TODO unit test for the property 'LogoDarkUrl'
        }

        /// <summary>
        /// Test the property 'LogoLightUrl'
        /// </summary>
        [Fact]
        public void LogoLightUrlTest()
        {
            // TODO unit test for the property 'LogoLightUrl'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'RecoveryEnabled'
        /// </summary>
        [Fact]
        public void RecoveryEnabledTest()
        {
            // TODO unit test for the property 'RecoveryEnabled'
        }

        /// <summary>
        /// Test the property 'RecoveryUiUrl'
        /// </summary>
        [Fact]
        public void RecoveryUiUrlTest()
        {
            // TODO unit test for the property 'RecoveryUiUrl'
        }

        /// <summary>
        /// Test the property 'RegistrationEnabled'
        /// </summary>
        [Fact]
        public void RegistrationEnabledTest()
        {
            // TODO unit test for the property 'RegistrationEnabled'
        }

        /// <summary>
        /// Test the property 'RegistrationUiUrl'
        /// </summary>
        [Fact]
        public void RegistrationUiUrlTest()
        {
            // TODO unit test for the property 'RegistrationUiUrl'
        }

        /// <summary>
        /// Test the property 'SettingsUiUrl'
        /// </summary>
        [Fact]
        public void SettingsUiUrlTest()
        {
            // TODO unit test for the property 'SettingsUiUrl'
        }

        /// <summary>
        /// Test the property 'Stylesheet'
        /// </summary>
        [Fact]
        public void StylesheetTest()
        {
            // TODO unit test for the property 'Stylesheet'
        }

        /// <summary>
        /// Test the property 'VerificationEnabled'
        /// </summary>
        [Fact]
        public void VerificationEnabledTest()
        {
            // TODO unit test for the property 'VerificationEnabled'
        }

        /// <summary>
        /// Test the property 'VerificationUiUrl'
        /// </summary>
        [Fact]
        public void VerificationUiUrlTest()
        {
            // TODO unit test for the property 'VerificationUiUrl'
        }
    }
}
