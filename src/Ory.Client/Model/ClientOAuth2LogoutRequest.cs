/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.23
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
    /// ClientOAuth2LogoutRequest
    /// </summary>
    [DataContract(Name = "oAuth2LogoutRequest")]
    public partial class ClientOAuth2LogoutRequest : IEquatable<ClientOAuth2LogoutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOAuth2LogoutRequest" /> class.
        /// </summary>
        /// <param name="challenge">Challenge is the identifier (\&quot;logout challenge\&quot;) of the logout authentication request. It is used to identify the session..</param>
        /// <param name="_client">_client.</param>
        /// <param name="requestUrl">RequestURL is the original Logout URL requested..</param>
        /// <param name="rpInitiated">RPInitiated is set to true if the request was initiated by a Relying Party (RP), also known as an OAuth 2.0 Client..</param>
        /// <param name="sid">SessionID is the login session ID that was requested to log out..</param>
        /// <param name="subject">Subject is the user for whom the logout was request..</param>
        public ClientOAuth2LogoutRequest(string challenge = default(string), ClientOAuth2Client _client = default(ClientOAuth2Client), string requestUrl = default(string), bool rpInitiated = default(bool), string sid = default(string), string subject = default(string))
        {
            this.Challenge = challenge;
            this._Client = _client;
            this.RequestUrl = requestUrl;
            this.RpInitiated = rpInitiated;
            this.Sid = sid;
            this.Subject = subject;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Challenge is the identifier (\&quot;logout challenge\&quot;) of the logout authentication request. It is used to identify the session.
        /// </summary>
        /// <value>Challenge is the identifier (\&quot;logout challenge\&quot;) of the logout authentication request. It is used to identify the session.</value>
        [DataMember(Name = "challenge", EmitDefaultValue = false)]
        public string Challenge { get; set; }

        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public ClientOAuth2Client _Client { get; set; }

        /// <summary>
        /// RequestURL is the original Logout URL requested.
        /// </summary>
        /// <value>RequestURL is the original Logout URL requested.</value>
        [DataMember(Name = "request_url", EmitDefaultValue = false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// RPInitiated is set to true if the request was initiated by a Relying Party (RP), also known as an OAuth 2.0 Client.
        /// </summary>
        /// <value>RPInitiated is set to true if the request was initiated by a Relying Party (RP), also known as an OAuth 2.0 Client.</value>
        [DataMember(Name = "rp_initiated", EmitDefaultValue = true)]
        public bool RpInitiated { get; set; }

        /// <summary>
        /// SessionID is the login session ID that was requested to log out.
        /// </summary>
        /// <value>SessionID is the login session ID that was requested to log out.</value>
        [DataMember(Name = "sid", EmitDefaultValue = false)]
        public string Sid { get; set; }

        /// <summary>
        /// Subject is the user for whom the logout was request.
        /// </summary>
        /// <value>Subject is the user for whom the logout was request.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

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
            sb.Append("class ClientOAuth2LogoutRequest {\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  _Client: ").Append(_Client).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  RpInitiated: ").Append(RpInitiated).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as ClientOAuth2LogoutRequest);
        }

        /// <summary>
        /// Returns true if ClientOAuth2LogoutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientOAuth2LogoutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientOAuth2LogoutRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Challenge == input.Challenge ||
                    (this.Challenge != null &&
                    this.Challenge.Equals(input.Challenge))
                ) && 
                (
                    this._Client == input._Client ||
                    (this._Client != null &&
                    this._Client.Equals(input._Client))
                ) && 
                (
                    this.RequestUrl == input.RequestUrl ||
                    (this.RequestUrl != null &&
                    this.RequestUrl.Equals(input.RequestUrl))
                ) && 
                (
                    this.RpInitiated == input.RpInitiated ||
                    this.RpInitiated.Equals(input.RpInitiated)
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Challenge != null)
                {
                    hashCode = (hashCode * 59) + this.Challenge.GetHashCode();
                }
                if (this._Client != null)
                {
                    hashCode = (hashCode * 59) + this._Client.GetHashCode();
                }
                if (this.RequestUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RequestUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RpInitiated.GetHashCode();
                if (this.Sid != null)
                {
                    hashCode = (hashCode * 59) + this.Sid.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
