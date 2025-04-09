/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.5
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
    /// Update Settings Flow with OpenID Connect Method
    /// </summary>
    [DataContract(Name = "updateSettingsFlowWithOidcMethod")]
    public partial class ClientUpdateSettingsFlowWithOidcMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateSettingsFlowWithOidcMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUpdateSettingsFlowWithOidcMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateSettingsFlowWithOidcMethod" /> class.
        /// </summary>
        /// <param name="flow">Flow ID is the flow&#39;s ID.  in: query.</param>
        /// <param name="link">Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body.</param>
        /// <param name="method">Method  Should be set to profile when trying to update a profile. (required).</param>
        /// <param name="traits">The identity&#39;s traits  in: body.</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        /// <param name="unlink">Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body.</param>
        /// <param name="upstreamParameters">UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;..</param>
        public ClientUpdateSettingsFlowWithOidcMethod(string flow = default(string), string link = default(string), string method = default(string), Object traits = default(Object), Object transientPayload = default(Object), string unlink = default(string), Object upstreamParameters = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ClientUpdateSettingsFlowWithOidcMethod and cannot be null");
            }
            this.Method = method;
            this.Flow = flow;
            this.Link = link;
            this.Traits = traits;
            this.TransientPayload = transientPayload;
            this.Unlink = unlink;
            this.UpstreamParameters = upstreamParameters;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Flow ID is the flow&#39;s ID.  in: query
        /// </summary>
        /// <value>Flow ID is the flow&#39;s ID.  in: query</value>
        [DataMember(Name = "flow", EmitDefaultValue = false)]
        public string Flow { get; set; }

        /// <summary>
        /// Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body
        /// </summary>
        /// <value>Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body</value>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public string Link { get; set; }

        /// <summary>
        /// Method  Should be set to profile when trying to update a profile.
        /// </summary>
        /// <value>Method  Should be set to profile when trying to update a profile.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// The identity&#39;s traits  in: body
        /// </summary>
        /// <value>The identity&#39;s traits  in: body</value>
        [DataMember(Name = "traits", EmitDefaultValue = false)]
        public Object Traits { get; set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [DataMember(Name = "transient_payload", EmitDefaultValue = false)]
        public Object TransientPayload { get; set; }

        /// <summary>
        /// Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body
        /// </summary>
        /// <value>Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body</value>
        [DataMember(Name = "unlink", EmitDefaultValue = false)]
        public string Unlink { get; set; }

        /// <summary>
        /// UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.
        /// </summary>
        /// <value>UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: &#x60;login_hint&#x60; (string): The &#x60;login_hint&#x60; parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. &#x60;hd&#x60; (string): The &#x60;hd&#x60; parameter limits the login/registration process to a Google Organization, e.g. &#x60;mycollege.edu&#x60;. &#x60;prompt&#x60; (string): The &#x60;prompt&#x60; specifies whether the Authorization Server prompts the End-User for reauthentication and consent, e.g. &#x60;select_account&#x60;.</value>
        [DataMember(Name = "upstream_parameters", EmitDefaultValue = false)]
        public Object UpstreamParameters { get; set; }

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
            sb.Append("class ClientUpdateSettingsFlowWithOidcMethod {\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("  Unlink: ").Append(Unlink).Append("\n");
            sb.Append("  UpstreamParameters: ").Append(UpstreamParameters).Append("\n");
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
