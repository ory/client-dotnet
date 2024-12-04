/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientAccountExperienceConfiguration
    /// </summary>
    [DataContract(Name = "accountExperienceConfiguration")]
    public partial class ClientAccountExperienceConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAccountExperienceConfiguration" /> class.
        /// </summary>
        /// <param name="accountExperienceThemeStylesheet">accountExperienceThemeStylesheet.</param>
        /// <param name="faviconType">faviconType.</param>
        /// <param name="faviconUrl">faviconUrl.</param>
        /// <param name="kratosSelfserviceDefaultBrowserReturnUrl">kratosSelfserviceDefaultBrowserReturnUrl.</param>
        /// <param name="kratosSelfserviceFlowsRecoveryEnabled">kratosSelfserviceFlowsRecoveryEnabled.</param>
        /// <param name="kratosSelfserviceFlowsRegistrationEnabled">kratosSelfserviceFlowsRegistrationEnabled.</param>
        /// <param name="kratosSelfserviceFlowsVerificationEnabled">kratosSelfserviceFlowsVerificationEnabled.</param>
        /// <param name="logoUrl">logoUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="organizationMap">organizationMap.</param>
        public ClientAccountExperienceConfiguration(string accountExperienceThemeStylesheet = default(string), string faviconType = default(string), string faviconUrl = default(string), string kratosSelfserviceDefaultBrowserReturnUrl = default(string), bool kratosSelfserviceFlowsRecoveryEnabled = default(bool), bool kratosSelfserviceFlowsRegistrationEnabled = default(bool), bool kratosSelfserviceFlowsVerificationEnabled = default(bool), string logoUrl = default(string), string name = default(string), Dictionary<string, string> organizationMap = default(Dictionary<string, string>))
        {
            this.AccountExperienceThemeStylesheet = accountExperienceThemeStylesheet;
            this.FaviconType = faviconType;
            this.FaviconUrl = faviconUrl;
            this.KratosSelfserviceDefaultBrowserReturnUrl = kratosSelfserviceDefaultBrowserReturnUrl;
            this.KratosSelfserviceFlowsRecoveryEnabled = kratosSelfserviceFlowsRecoveryEnabled;
            this.KratosSelfserviceFlowsRegistrationEnabled = kratosSelfserviceFlowsRegistrationEnabled;
            this.KratosSelfserviceFlowsVerificationEnabled = kratosSelfserviceFlowsVerificationEnabled;
            this.LogoUrl = logoUrl;
            this.Name = name;
            this.OrganizationMap = organizationMap;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AccountExperienceThemeStylesheet
        /// </summary>
        [DataMember(Name = "account_experience_theme_stylesheet", EmitDefaultValue = false)]
        public string AccountExperienceThemeStylesheet { get; set; }

        /// <summary>
        /// Gets or Sets FaviconType
        /// </summary>
        [DataMember(Name = "favicon_type", EmitDefaultValue = false)]
        public string FaviconType { get; set; }

        /// <summary>
        /// Gets or Sets FaviconUrl
        /// </summary>
        [DataMember(Name = "favicon_url", EmitDefaultValue = false)]
        public string FaviconUrl { get; set; }

        /// <summary>
        /// Gets or Sets KratosSelfserviceDefaultBrowserReturnUrl
        /// </summary>
        [DataMember(Name = "kratos_selfservice_default_browser_return_url", EmitDefaultValue = false)]
        public string KratosSelfserviceDefaultBrowserReturnUrl { get; set; }

        /// <summary>
        /// Gets or Sets KratosSelfserviceFlowsRecoveryEnabled
        /// </summary>
        [DataMember(Name = "kratos_selfservice_flows_recovery_enabled", EmitDefaultValue = true)]
        public bool KratosSelfserviceFlowsRecoveryEnabled { get; set; }

        /// <summary>
        /// Gets or Sets KratosSelfserviceFlowsRegistrationEnabled
        /// </summary>
        [DataMember(Name = "kratos_selfservice_flows_registration_enabled", EmitDefaultValue = true)]
        public bool KratosSelfserviceFlowsRegistrationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets KratosSelfserviceFlowsVerificationEnabled
        /// </summary>
        [DataMember(Name = "kratos_selfservice_flows_verification_enabled", EmitDefaultValue = true)]
        public bool KratosSelfserviceFlowsVerificationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LogoUrl
        /// </summary>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationMap
        /// </summary>
        [DataMember(Name = "organization_map", EmitDefaultValue = false)]
        public Dictionary<string, string> OrganizationMap { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientAccountExperienceConfiguration {\n");
            sb.Append("  AccountExperienceThemeStylesheet: ").Append(AccountExperienceThemeStylesheet).Append("\n");
            sb.Append("  FaviconType: ").Append(FaviconType).Append("\n");
            sb.Append("  FaviconUrl: ").Append(FaviconUrl).Append("\n");
            sb.Append("  KratosSelfserviceDefaultBrowserReturnUrl: ").Append(KratosSelfserviceDefaultBrowserReturnUrl).Append("\n");
            sb.Append("  KratosSelfserviceFlowsRecoveryEnabled: ").Append(KratosSelfserviceFlowsRecoveryEnabled).Append("\n");
            sb.Append("  KratosSelfserviceFlowsRegistrationEnabled: ").Append(KratosSelfserviceFlowsRegistrationEnabled).Append("\n");
            sb.Append("  KratosSelfserviceFlowsVerificationEnabled: ").Append(KratosSelfserviceFlowsVerificationEnabled).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationMap: ").Append(OrganizationMap).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
