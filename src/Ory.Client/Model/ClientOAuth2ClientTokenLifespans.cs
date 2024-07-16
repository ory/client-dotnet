/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.0
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
    /// Lifespans of different token types issued for this OAuth 2.0 Client.
    /// </summary>
    [DataContract(Name = "oAuth2ClientTokenLifespans")]
    public partial class ClientOAuth2ClientTokenLifespans : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOAuth2ClientTokenLifespans" /> class.
        /// </summary>
        /// <param name="authorizationCodeGrantAccessTokenLifespan">authorizationCodeGrantAccessTokenLifespan.</param>
        /// <param name="authorizationCodeGrantIdTokenLifespan">authorizationCodeGrantIdTokenLifespan.</param>
        /// <param name="authorizationCodeGrantRefreshTokenLifespan">authorizationCodeGrantRefreshTokenLifespan.</param>
        /// <param name="clientCredentialsGrantAccessTokenLifespan">clientCredentialsGrantAccessTokenLifespan.</param>
        /// <param name="implicitGrantAccessTokenLifespan">implicitGrantAccessTokenLifespan.</param>
        /// <param name="implicitGrantIdTokenLifespan">implicitGrantIdTokenLifespan.</param>
        /// <param name="jwtBearerGrantAccessTokenLifespan">jwtBearerGrantAccessTokenLifespan.</param>
        /// <param name="refreshTokenGrantAccessTokenLifespan">refreshTokenGrantAccessTokenLifespan.</param>
        /// <param name="refreshTokenGrantIdTokenLifespan">refreshTokenGrantIdTokenLifespan.</param>
        /// <param name="refreshTokenGrantRefreshTokenLifespan">refreshTokenGrantRefreshTokenLifespan.</param>
        public ClientOAuth2ClientTokenLifespans(string authorizationCodeGrantAccessTokenLifespan = default(string), string authorizationCodeGrantIdTokenLifespan = default(string), string authorizationCodeGrantRefreshTokenLifespan = default(string), string clientCredentialsGrantAccessTokenLifespan = default(string), string implicitGrantAccessTokenLifespan = default(string), string implicitGrantIdTokenLifespan = default(string), string jwtBearerGrantAccessTokenLifespan = default(string), string refreshTokenGrantAccessTokenLifespan = default(string), string refreshTokenGrantIdTokenLifespan = default(string), string refreshTokenGrantRefreshTokenLifespan = default(string))
        {
            this.AuthorizationCodeGrantAccessTokenLifespan = authorizationCodeGrantAccessTokenLifespan;
            this.AuthorizationCodeGrantIdTokenLifespan = authorizationCodeGrantIdTokenLifespan;
            this.AuthorizationCodeGrantRefreshTokenLifespan = authorizationCodeGrantRefreshTokenLifespan;
            this.ClientCredentialsGrantAccessTokenLifespan = clientCredentialsGrantAccessTokenLifespan;
            this.ImplicitGrantAccessTokenLifespan = implicitGrantAccessTokenLifespan;
            this.ImplicitGrantIdTokenLifespan = implicitGrantIdTokenLifespan;
            this.JwtBearerGrantAccessTokenLifespan = jwtBearerGrantAccessTokenLifespan;
            this.RefreshTokenGrantAccessTokenLifespan = refreshTokenGrantAccessTokenLifespan;
            this.RefreshTokenGrantIdTokenLifespan = refreshTokenGrantIdTokenLifespan;
            this.RefreshTokenGrantRefreshTokenLifespan = refreshTokenGrantRefreshTokenLifespan;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AuthorizationCodeGrantAccessTokenLifespan
        /// </summary>
        [DataMember(Name = "authorization_code_grant_access_token_lifespan", EmitDefaultValue = true)]
        public string AuthorizationCodeGrantAccessTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationCodeGrantIdTokenLifespan
        /// </summary>
        [DataMember(Name = "authorization_code_grant_id_token_lifespan", EmitDefaultValue = true)]
        public string AuthorizationCodeGrantIdTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationCodeGrantRefreshTokenLifespan
        /// </summary>
        [DataMember(Name = "authorization_code_grant_refresh_token_lifespan", EmitDefaultValue = true)]
        public string AuthorizationCodeGrantRefreshTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets ClientCredentialsGrantAccessTokenLifespan
        /// </summary>
        [DataMember(Name = "client_credentials_grant_access_token_lifespan", EmitDefaultValue = true)]
        public string ClientCredentialsGrantAccessTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets ImplicitGrantAccessTokenLifespan
        /// </summary>
        [DataMember(Name = "implicit_grant_access_token_lifespan", EmitDefaultValue = true)]
        public string ImplicitGrantAccessTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets ImplicitGrantIdTokenLifespan
        /// </summary>
        [DataMember(Name = "implicit_grant_id_token_lifespan", EmitDefaultValue = true)]
        public string ImplicitGrantIdTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets JwtBearerGrantAccessTokenLifespan
        /// </summary>
        [DataMember(Name = "jwt_bearer_grant_access_token_lifespan", EmitDefaultValue = true)]
        public string JwtBearerGrantAccessTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenGrantAccessTokenLifespan
        /// </summary>
        [DataMember(Name = "refresh_token_grant_access_token_lifespan", EmitDefaultValue = true)]
        public string RefreshTokenGrantAccessTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenGrantIdTokenLifespan
        /// </summary>
        [DataMember(Name = "refresh_token_grant_id_token_lifespan", EmitDefaultValue = true)]
        public string RefreshTokenGrantIdTokenLifespan { get; set; }

        /// <summary>
        /// Gets or Sets RefreshTokenGrantRefreshTokenLifespan
        /// </summary>
        [DataMember(Name = "refresh_token_grant_refresh_token_lifespan", EmitDefaultValue = true)]
        public string RefreshTokenGrantRefreshTokenLifespan { get; set; }

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
            sb.Append("class ClientOAuth2ClientTokenLifespans {\n");
            sb.Append("  AuthorizationCodeGrantAccessTokenLifespan: ").Append(AuthorizationCodeGrantAccessTokenLifespan).Append("\n");
            sb.Append("  AuthorizationCodeGrantIdTokenLifespan: ").Append(AuthorizationCodeGrantIdTokenLifespan).Append("\n");
            sb.Append("  AuthorizationCodeGrantRefreshTokenLifespan: ").Append(AuthorizationCodeGrantRefreshTokenLifespan).Append("\n");
            sb.Append("  ClientCredentialsGrantAccessTokenLifespan: ").Append(ClientCredentialsGrantAccessTokenLifespan).Append("\n");
            sb.Append("  ImplicitGrantAccessTokenLifespan: ").Append(ImplicitGrantAccessTokenLifespan).Append("\n");
            sb.Append("  ImplicitGrantIdTokenLifespan: ").Append(ImplicitGrantIdTokenLifespan).Append("\n");
            sb.Append("  JwtBearerGrantAccessTokenLifespan: ").Append(JwtBearerGrantAccessTokenLifespan).Append("\n");
            sb.Append("  RefreshTokenGrantAccessTokenLifespan: ").Append(RefreshTokenGrantAccessTokenLifespan).Append("\n");
            sb.Append("  RefreshTokenGrantIdTokenLifespan: ").Append(RefreshTokenGrantIdTokenLifespan).Append("\n");
            sb.Append("  RefreshTokenGrantRefreshTokenLifespan: ").Append(RefreshTokenGrantRefreshTokenLifespan).Append("\n");
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
            if (this.AuthorizationCodeGrantAccessTokenLifespan != null) {
                // AuthorizationCodeGrantAccessTokenLifespan (string) pattern
                Regex regexAuthorizationCodeGrantAccessTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexAuthorizationCodeGrantAccessTokenLifespan.Match(this.AuthorizationCodeGrantAccessTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorizationCodeGrantAccessTokenLifespan, must match a pattern of " + regexAuthorizationCodeGrantAccessTokenLifespan, new [] { "AuthorizationCodeGrantAccessTokenLifespan" });
                }
            }

            if (this.AuthorizationCodeGrantIdTokenLifespan != null) {
                // AuthorizationCodeGrantIdTokenLifespan (string) pattern
                Regex regexAuthorizationCodeGrantIdTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexAuthorizationCodeGrantIdTokenLifespan.Match(this.AuthorizationCodeGrantIdTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorizationCodeGrantIdTokenLifespan, must match a pattern of " + regexAuthorizationCodeGrantIdTokenLifespan, new [] { "AuthorizationCodeGrantIdTokenLifespan" });
                }
            }

            if (this.AuthorizationCodeGrantRefreshTokenLifespan != null) {
                // AuthorizationCodeGrantRefreshTokenLifespan (string) pattern
                Regex regexAuthorizationCodeGrantRefreshTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexAuthorizationCodeGrantRefreshTokenLifespan.Match(this.AuthorizationCodeGrantRefreshTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorizationCodeGrantRefreshTokenLifespan, must match a pattern of " + regexAuthorizationCodeGrantRefreshTokenLifespan, new [] { "AuthorizationCodeGrantRefreshTokenLifespan" });
                }
            }

            if (this.ClientCredentialsGrantAccessTokenLifespan != null) {
                // ClientCredentialsGrantAccessTokenLifespan (string) pattern
                Regex regexClientCredentialsGrantAccessTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexClientCredentialsGrantAccessTokenLifespan.Match(this.ClientCredentialsGrantAccessTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientCredentialsGrantAccessTokenLifespan, must match a pattern of " + regexClientCredentialsGrantAccessTokenLifespan, new [] { "ClientCredentialsGrantAccessTokenLifespan" });
                }
            }

            if (this.ImplicitGrantAccessTokenLifespan != null) {
                // ImplicitGrantAccessTokenLifespan (string) pattern
                Regex regexImplicitGrantAccessTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexImplicitGrantAccessTokenLifespan.Match(this.ImplicitGrantAccessTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImplicitGrantAccessTokenLifespan, must match a pattern of " + regexImplicitGrantAccessTokenLifespan, new [] { "ImplicitGrantAccessTokenLifespan" });
                }
            }

            if (this.ImplicitGrantIdTokenLifespan != null) {
                // ImplicitGrantIdTokenLifespan (string) pattern
                Regex regexImplicitGrantIdTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexImplicitGrantIdTokenLifespan.Match(this.ImplicitGrantIdTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImplicitGrantIdTokenLifespan, must match a pattern of " + regexImplicitGrantIdTokenLifespan, new [] { "ImplicitGrantIdTokenLifespan" });
                }
            }

            if (this.JwtBearerGrantAccessTokenLifespan != null) {
                // JwtBearerGrantAccessTokenLifespan (string) pattern
                Regex regexJwtBearerGrantAccessTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexJwtBearerGrantAccessTokenLifespan.Match(this.JwtBearerGrantAccessTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JwtBearerGrantAccessTokenLifespan, must match a pattern of " + regexJwtBearerGrantAccessTokenLifespan, new [] { "JwtBearerGrantAccessTokenLifespan" });
                }
            }

            if (this.RefreshTokenGrantAccessTokenLifespan != null) {
                // RefreshTokenGrantAccessTokenLifespan (string) pattern
                Regex regexRefreshTokenGrantAccessTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexRefreshTokenGrantAccessTokenLifespan.Match(this.RefreshTokenGrantAccessTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefreshTokenGrantAccessTokenLifespan, must match a pattern of " + regexRefreshTokenGrantAccessTokenLifespan, new [] { "RefreshTokenGrantAccessTokenLifespan" });
                }
            }

            if (this.RefreshTokenGrantIdTokenLifespan != null) {
                // RefreshTokenGrantIdTokenLifespan (string) pattern
                Regex regexRefreshTokenGrantIdTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexRefreshTokenGrantIdTokenLifespan.Match(this.RefreshTokenGrantIdTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefreshTokenGrantIdTokenLifespan, must match a pattern of " + regexRefreshTokenGrantIdTokenLifespan, new [] { "RefreshTokenGrantIdTokenLifespan" });
                }
            }

            if (this.RefreshTokenGrantRefreshTokenLifespan != null) {
                // RefreshTokenGrantRefreshTokenLifespan (string) pattern
                Regex regexRefreshTokenGrantRefreshTokenLifespan = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
                if (!regexRefreshTokenGrantRefreshTokenLifespan.Match(this.RefreshTokenGrantRefreshTokenLifespan).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefreshTokenGrantRefreshTokenLifespan, must match a pattern of " + regexRefreshTokenGrantRefreshTokenLifespan, new [] { "RefreshTokenGrantRefreshTokenLifespan" });
                }
            }

            yield break;
        }
    }

}
