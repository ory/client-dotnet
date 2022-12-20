/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.3
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
    /// Introspection contains an access token&#39;s session data as specified by [IETF RFC 7662](https://tools.ietf.org/html/rfc7662)
    /// </summary>
    [DataContract(Name = "introspectedOAuth2Token")]
    public partial class ClientIntrospectedOAuth2Token : IEquatable<ClientIntrospectedOAuth2Token>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIntrospectedOAuth2Token" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientIntrospectedOAuth2Token()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIntrospectedOAuth2Token" /> class.
        /// </summary>
        /// <param name="active">Active is a boolean indicator of whether or not the presented token is currently active.  The specifics of a token&#39;s \&quot;active\&quot; state will vary depending on the implementation of the authorization server and the information it keeps about its tokens, but a \&quot;true\&quot; value return for the \&quot;active\&quot; property will generally indicate that a given token has been issued by this authorization server, has not been revoked by the resource owner, and is within its given time window of validity (e.g., after its issuance time and before its expiration time). (required).</param>
        /// <param name="aud">Audience contains a list of the token&#39;s intended audiences..</param>
        /// <param name="clientId">ID is aclient identifier for the OAuth 2.0 client that requested this token..</param>
        /// <param name="exp">Expires at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token will expire..</param>
        /// <param name="ext">Extra is arbitrary data set by the session..</param>
        /// <param name="iat">Issued at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token was originally issued..</param>
        /// <param name="iss">IssuerURL is a string representing the issuer of this token.</param>
        /// <param name="nbf">NotBefore is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token is not to be used before..</param>
        /// <param name="obfuscatedSubject">ObfuscatedSubject is set when the subject identifier algorithm was set to \&quot;pairwise\&quot; during authorization. It is the &#x60;sub&#x60; value of the ID Token that was issued..</param>
        /// <param name="scope">Scope is a JSON string containing a space-separated list of scopes associated with this token..</param>
        /// <param name="sub">Subject of the token, as defined in JWT [RFC7519]. Usually a machine-readable identifier of the resource owner who authorized this token..</param>
        /// <param name="tokenType">TokenType is the introspected token&#39;s type, typically &#x60;Bearer&#x60;..</param>
        /// <param name="tokenUse">TokenUse is the introspected token&#39;s use, for example &#x60;access_token&#x60; or &#x60;refresh_token&#x60;..</param>
        /// <param name="username">Username is a human-readable identifier for the resource owner who authorized this token..</param>
        public ClientIntrospectedOAuth2Token(bool active = default(bool), List<string> aud = default(List<string>), string clientId = default(string), long exp = default(long), Dictionary<string, Object> ext = default(Dictionary<string, Object>), long iat = default(long), string iss = default(string), long nbf = default(long), string obfuscatedSubject = default(string), string scope = default(string), string sub = default(string), string tokenType = default(string), string tokenUse = default(string), string username = default(string))
        {
            this.Active = active;
            this.Aud = aud;
            this.ClientId = clientId;
            this.Exp = exp;
            this.Ext = ext;
            this.Iat = iat;
            this.Iss = iss;
            this.Nbf = nbf;
            this.ObfuscatedSubject = obfuscatedSubject;
            this.Scope = scope;
            this.Sub = sub;
            this.TokenType = tokenType;
            this.TokenUse = tokenUse;
            this.Username = username;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Active is a boolean indicator of whether or not the presented token is currently active.  The specifics of a token&#39;s \&quot;active\&quot; state will vary depending on the implementation of the authorization server and the information it keeps about its tokens, but a \&quot;true\&quot; value return for the \&quot;active\&quot; property will generally indicate that a given token has been issued by this authorization server, has not been revoked by the resource owner, and is within its given time window of validity (e.g., after its issuance time and before its expiration time).
        /// </summary>
        /// <value>Active is a boolean indicator of whether or not the presented token is currently active.  The specifics of a token&#39;s \&quot;active\&quot; state will vary depending on the implementation of the authorization server and the information it keeps about its tokens, but a \&quot;true\&quot; value return for the \&quot;active\&quot; property will generally indicate that a given token has been issued by this authorization server, has not been revoked by the resource owner, and is within its given time window of validity (e.g., after its issuance time and before its expiration time).</value>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Audience contains a list of the token&#39;s intended audiences.
        /// </summary>
        /// <value>Audience contains a list of the token&#39;s intended audiences.</value>
        [DataMember(Name = "aud", EmitDefaultValue = false)]
        public List<string> Aud { get; set; }

        /// <summary>
        /// ID is aclient identifier for the OAuth 2.0 client that requested this token.
        /// </summary>
        /// <value>ID is aclient identifier for the OAuth 2.0 client that requested this token.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Expires at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token will expire.
        /// </summary>
        /// <value>Expires at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token will expire.</value>
        [DataMember(Name = "exp", EmitDefaultValue = false)]
        public long Exp { get; set; }

        /// <summary>
        /// Extra is arbitrary data set by the session.
        /// </summary>
        /// <value>Extra is arbitrary data set by the session.</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public Dictionary<string, Object> Ext { get; set; }

        /// <summary>
        /// Issued at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token was originally issued.
        /// </summary>
        /// <value>Issued at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token was originally issued.</value>
        [DataMember(Name = "iat", EmitDefaultValue = false)]
        public long Iat { get; set; }

        /// <summary>
        /// IssuerURL is a string representing the issuer of this token
        /// </summary>
        /// <value>IssuerURL is a string representing the issuer of this token</value>
        [DataMember(Name = "iss", EmitDefaultValue = false)]
        public string Iss { get; set; }

        /// <summary>
        /// NotBefore is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token is not to be used before.
        /// </summary>
        /// <value>NotBefore is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token is not to be used before.</value>
        [DataMember(Name = "nbf", EmitDefaultValue = false)]
        public long Nbf { get; set; }

        /// <summary>
        /// ObfuscatedSubject is set when the subject identifier algorithm was set to \&quot;pairwise\&quot; during authorization. It is the &#x60;sub&#x60; value of the ID Token that was issued.
        /// </summary>
        /// <value>ObfuscatedSubject is set when the subject identifier algorithm was set to \&quot;pairwise\&quot; during authorization. It is the &#x60;sub&#x60; value of the ID Token that was issued.</value>
        [DataMember(Name = "obfuscated_subject", EmitDefaultValue = false)]
        public string ObfuscatedSubject { get; set; }

        /// <summary>
        /// Scope is a JSON string containing a space-separated list of scopes associated with this token.
        /// </summary>
        /// <value>Scope is a JSON string containing a space-separated list of scopes associated with this token.</value>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Subject of the token, as defined in JWT [RFC7519]. Usually a machine-readable identifier of the resource owner who authorized this token.
        /// </summary>
        /// <value>Subject of the token, as defined in JWT [RFC7519]. Usually a machine-readable identifier of the resource owner who authorized this token.</value>
        [DataMember(Name = "sub", EmitDefaultValue = false)]
        public string Sub { get; set; }

        /// <summary>
        /// TokenType is the introspected token&#39;s type, typically &#x60;Bearer&#x60;.
        /// </summary>
        /// <value>TokenType is the introspected token&#39;s type, typically &#x60;Bearer&#x60;.</value>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// TokenUse is the introspected token&#39;s use, for example &#x60;access_token&#x60; or &#x60;refresh_token&#x60;.
        /// </summary>
        /// <value>TokenUse is the introspected token&#39;s use, for example &#x60;access_token&#x60; or &#x60;refresh_token&#x60;.</value>
        [DataMember(Name = "token_use", EmitDefaultValue = false)]
        public string TokenUse { get; set; }

        /// <summary>
        /// Username is a human-readable identifier for the resource owner who authorized this token.
        /// </summary>
        /// <value>Username is a human-readable identifier for the resource owner who authorized this token.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

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
            sb.Append("class ClientIntrospectedOAuth2Token {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Aud: ").Append(Aud).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Exp: ").Append(Exp).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  Iat: ").Append(Iat).Append("\n");
            sb.Append("  Iss: ").Append(Iss).Append("\n");
            sb.Append("  Nbf: ").Append(Nbf).Append("\n");
            sb.Append("  ObfuscatedSubject: ").Append(ObfuscatedSubject).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  TokenUse: ").Append(TokenUse).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as ClientIntrospectedOAuth2Token);
        }

        /// <summary>
        /// Returns true if ClientIntrospectedOAuth2Token instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIntrospectedOAuth2Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIntrospectedOAuth2Token input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Aud == input.Aud ||
                    this.Aud != null &&
                    input.Aud != null &&
                    this.Aud.SequenceEqual(input.Aud)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Exp == input.Exp ||
                    this.Exp.Equals(input.Exp)
                ) && 
                (
                    this.Ext == input.Ext ||
                    this.Ext != null &&
                    input.Ext != null &&
                    this.Ext.SequenceEqual(input.Ext)
                ) && 
                (
                    this.Iat == input.Iat ||
                    this.Iat.Equals(input.Iat)
                ) && 
                (
                    this.Iss == input.Iss ||
                    (this.Iss != null &&
                    this.Iss.Equals(input.Iss))
                ) && 
                (
                    this.Nbf == input.Nbf ||
                    this.Nbf.Equals(input.Nbf)
                ) && 
                (
                    this.ObfuscatedSubject == input.ObfuscatedSubject ||
                    (this.ObfuscatedSubject != null &&
                    this.ObfuscatedSubject.Equals(input.ObfuscatedSubject))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Sub == input.Sub ||
                    (this.Sub != null &&
                    this.Sub.Equals(input.Sub))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.TokenUse == input.TokenUse ||
                    (this.TokenUse != null &&
                    this.TokenUse.Equals(input.TokenUse))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Aud != null)
                {
                    hashCode = (hashCode * 59) + this.Aud.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Exp.GetHashCode();
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Iat.GetHashCode();
                if (this.Iss != null)
                {
                    hashCode = (hashCode * 59) + this.Iss.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nbf.GetHashCode();
                if (this.ObfuscatedSubject != null)
                {
                    hashCode = (hashCode * 59) + this.ObfuscatedSubject.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Sub != null)
                {
                    hashCode = (hashCode * 59) + this.Sub.GetHashCode();
                }
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }
                if (this.TokenUse != null)
                {
                    hashCode = (hashCode * 59) + this.TokenUse.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
