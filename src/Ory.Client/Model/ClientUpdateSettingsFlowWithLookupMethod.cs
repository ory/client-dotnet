/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.7
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
    /// Update Settings Flow with Lookup Method
    /// </summary>
    [DataContract(Name = "updateSettingsFlowWithLookupMethod")]
    public partial class ClientUpdateSettingsFlowWithLookupMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateSettingsFlowWithLookupMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUpdateSettingsFlowWithLookupMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateSettingsFlowWithLookupMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token.</param>
        /// <param name="lookupSecretConfirm">If set to true will save the regenerated lookup secrets.</param>
        /// <param name="lookupSecretDisable">Disables this method if true..</param>
        /// <param name="lookupSecretRegenerate">If set to true will regenerate the lookup secrets.</param>
        /// <param name="lookupSecretReveal">If set to true will reveal the lookup secrets.</param>
        /// <param name="method">Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing. (required).</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public ClientUpdateSettingsFlowWithLookupMethod(string csrfToken = default(string), bool lookupSecretConfirm = default(bool), bool lookupSecretDisable = default(bool), bool lookupSecretRegenerate = default(bool), bool lookupSecretReveal = default(bool), string method = default(string), Object transientPayload = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ClientUpdateSettingsFlowWithLookupMethod and cannot be null");
            }
            this.Method = method;
            this.CsrfToken = csrfToken;
            this.LookupSecretConfirm = lookupSecretConfirm;
            this.LookupSecretDisable = lookupSecretDisable;
            this.LookupSecretRegenerate = lookupSecretRegenerate;
            this.LookupSecretReveal = lookupSecretReveal;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// If set to true will save the regenerated lookup secrets
        /// </summary>
        /// <value>If set to true will save the regenerated lookup secrets</value>
        [DataMember(Name = "lookup_secret_confirm", EmitDefaultValue = true)]
        public bool LookupSecretConfirm { get; set; }

        /// <summary>
        /// Disables this method if true.
        /// </summary>
        /// <value>Disables this method if true.</value>
        [DataMember(Name = "lookup_secret_disable", EmitDefaultValue = true)]
        public bool LookupSecretDisable { get; set; }

        /// <summary>
        /// If set to true will regenerate the lookup secrets
        /// </summary>
        /// <value>If set to true will regenerate the lookup secrets</value>
        [DataMember(Name = "lookup_secret_regenerate", EmitDefaultValue = true)]
        public bool LookupSecretRegenerate { get; set; }

        /// <summary>
        /// If set to true will reveal the lookup secrets
        /// </summary>
        /// <value>If set to true will reveal the lookup secrets</value>
        [DataMember(Name = "lookup_secret_reveal", EmitDefaultValue = true)]
        public bool LookupSecretReveal { get; set; }

        /// <summary>
        /// Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [DataMember(Name = "transient_payload", EmitDefaultValue = false)]
        public Object TransientPayload { get; set; }

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
            sb.Append("class ClientUpdateSettingsFlowWithLookupMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  LookupSecretConfirm: ").Append(LookupSecretConfirm).Append("\n");
            sb.Append("  LookupSecretDisable: ").Append(LookupSecretDisable).Append("\n");
            sb.Append("  LookupSecretRegenerate: ").Append(LookupSecretRegenerate).Append("\n");
            sb.Append("  LookupSecretReveal: ").Append(LookupSecretReveal).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
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
