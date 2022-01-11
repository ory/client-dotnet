/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.44
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
    /// ClientRedirectionConfig
    /// </summary>
    [DataContract(Name = "RedirectionConfig")]
    public partial class ClientRedirectionConfig : IEquatable<ClientRedirectionConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRedirectionConfig" /> class.
        /// </summary>
        /// <param name="global">global.</param>
        /// <param name="login">login.</param>
        /// <param name="logout">logout.</param>
        /// <param name="recovery">recovery.</param>
        /// <param name="registration">registration.</param>
        /// <param name="settings">settings.</param>
        /// <param name="urlAllowlist">urlAllowlist.</param>
        /// <param name="verification">verification.</param>
        public ClientRedirectionConfig(ClientRedirectionField global = default(ClientRedirectionField), ClientRedirectionField login = default(ClientRedirectionField), ClientRedirectionField logout = default(ClientRedirectionField), ClientRedirectionField recovery = default(ClientRedirectionField), ClientRedirectionField registration = default(ClientRedirectionField), ClientRedirectionField settings = default(ClientRedirectionField), List<string> urlAllowlist = default(List<string>), ClientRedirectionField verification = default(ClientRedirectionField))
        {
            this.Global = global;
            this.Login = login;
            this.Logout = logout;
            this.Recovery = recovery;
            this.Registration = registration;
            this.Settings = settings;
            this.UrlAllowlist = urlAllowlist;
            this.Verification = verification;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name = "global", EmitDefaultValue = false)]
        public ClientRedirectionField Global { get; set; }

        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        public ClientRedirectionField Login { get; set; }

        /// <summary>
        /// Gets or Sets Logout
        /// </summary>
        [DataMember(Name = "logout", EmitDefaultValue = false)]
        public ClientRedirectionField Logout { get; set; }

        /// <summary>
        /// Gets or Sets Recovery
        /// </summary>
        [DataMember(Name = "recovery", EmitDefaultValue = false)]
        public ClientRedirectionField Recovery { get; set; }

        /// <summary>
        /// Gets or Sets Registration
        /// </summary>
        [DataMember(Name = "registration", EmitDefaultValue = false)]
        public ClientRedirectionField Registration { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public ClientRedirectionField Settings { get; set; }

        /// <summary>
        /// Gets or Sets UrlAllowlist
        /// </summary>
        [DataMember(Name = "url_allowlist", EmitDefaultValue = false)]
        public List<string> UrlAllowlist { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", EmitDefaultValue = false)]
        public ClientRedirectionField Verification { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class ClientRedirectionConfig {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Logout: ").Append(Logout).Append("\n");
            sb.Append("  Recovery: ").Append(Recovery).Append("\n");
            sb.Append("  Registration: ").Append(Registration).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  UrlAllowlist: ").Append(UrlAllowlist).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
            return this.Equals(input as ClientRedirectionConfig);
        }

        /// <summary>
        /// Returns true if ClientRedirectionConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientRedirectionConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientRedirectionConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Global == input.Global ||
                    (this.Global != null &&
                    this.Global.Equals(input.Global))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Logout == input.Logout ||
                    (this.Logout != null &&
                    this.Logout.Equals(input.Logout))
                ) && 
                (
                    this.Recovery == input.Recovery ||
                    (this.Recovery != null &&
                    this.Recovery.Equals(input.Recovery))
                ) && 
                (
                    this.Registration == input.Registration ||
                    (this.Registration != null &&
                    this.Registration.Equals(input.Registration))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.UrlAllowlist == input.UrlAllowlist ||
                    this.UrlAllowlist != null &&
                    input.UrlAllowlist != null &&
                    this.UrlAllowlist.SequenceEqual(input.UrlAllowlist)
                ) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
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
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Logout != null)
                    hashCode = hashCode * 59 + this.Logout.GetHashCode();
                if (this.Recovery != null)
                    hashCode = hashCode * 59 + this.Recovery.GetHashCode();
                if (this.Registration != null)
                    hashCode = hashCode * 59 + this.Registration.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.UrlAllowlist != null)
                    hashCode = hashCode * 59 + this.UrlAllowlist.GetHashCode();
                if (this.Verification != null)
                    hashCode = hashCode * 59 + this.Verification.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
