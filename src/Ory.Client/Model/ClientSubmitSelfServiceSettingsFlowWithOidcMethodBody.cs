/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.41
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
    /// nolint:deadcode,unused
    /// </summary>
    [DataContract(Name = "submitSelfServiceSettingsFlowWithOidcMethodBody")]
    public partial class ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody : IEquatable<ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody" /> class.
        /// </summary>
        /// <param name="flow">Flow ID is the flow&#39;s ID.  in: query.</param>
        /// <param name="link">Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body.</param>
        /// <param name="method">Method  Should be set to profile when trying to update a profile. (required).</param>
        /// <param name="traits">The identity&#39;s traits  in: body.</param>
        /// <param name="unlink">Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body.</param>
        public ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody(string flow = default(string), string link = default(string), string method = default(string), Object traits = default(Object), string unlink = default(string))
        {
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody and cannot be null");
            }
            this.Method = method;
            this.Flow = flow;
            this.Link = link;
            this.Traits = traits;
            this.Unlink = unlink;
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
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// The identity&#39;s traits  in: body
        /// </summary>
        /// <value>The identity&#39;s traits  in: body</value>
        [DataMember(Name = "traits", EmitDefaultValue = false)]
        public Object Traits { get; set; }

        /// <summary>
        /// Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body
        /// </summary>
        /// <value>Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body</value>
        [DataMember(Name = "unlink", EmitDefaultValue = false)]
        public string Unlink { get; set; }

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
            sb.Append("class ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody {\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  Unlink: ").Append(Unlink).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceSettingsFlowWithOidcMethodBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Traits == input.Traits ||
                    (this.Traits != null &&
                    this.Traits.Equals(input.Traits))
                ) && 
                (
                    this.Unlink == input.Unlink ||
                    (this.Unlink != null &&
                    this.Unlink.Equals(input.Unlink))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Flow != null)
                {
                    hashCode = (hashCode * 59) + this.Flow.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Traits != null)
                {
                    hashCode = (hashCode * 59) + this.Traits.GetHashCode();
                }
                if (this.Unlink != null)
                {
                    hashCode = (hashCode * 59) + this.Unlink.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
