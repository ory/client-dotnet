/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.1
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Ory.Client.Client.Auth
{
    /// <summary>
    /// An authenticator for OAuth2 authentication flows
    /// </summary>
    public class OAuthAuthenticator : AuthenticatorBase
    {
        readonly string _tokenUrl;
        readonly string _clientId;
        readonly string _clientSecret;
        readonly string _grantType;
        readonly JsonSerializerSettings _serializerSettings;
        readonly IReadableConfiguration _configuration;

        /// <summary>
        /// Initialize the OAuth2 Authenticator
        /// </summary>
        public OAuthAuthenticator(
            string tokenUrl,
            string clientId,
            string clientSecret,
            OAuthFlow? flow,
            JsonSerializerSettings serializerSettings,
            IReadableConfiguration configuration) : base("")
        {
            _tokenUrl = tokenUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _serializerSettings = serializerSettings;
            _configuration = configuration;

            switch (flow)
            {
                /*case OAuthFlow.ACCESS_CODE:
                    _grantType = "authorization_code";
                    break;
                case OAuthFlow.IMPLICIT:
                    _grantType = "implicit";
                    break;
                case OAuthFlow.PASSWORD:
                    _grantType = "password";
                    break;*/
                case OAuthFlow.APPLICATION:
                    _grantType = "client_credentials";
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Creates an authentication parameter from an access token.
        /// </summary>
        /// <param name="accessToken">Access token to create a parameter from.</param>
        /// <returns>An authentication parameter.</returns>
        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token) ? await GetToken().ConfigureAwait(false) : Token;
            return new HeaderParameter(KnownHeaders.Authorization, token);
        }

        /// <summary>
        /// Gets the token from the OAuth2 server.
        /// </summary>
        /// <returns>An authentication token.</returns>
        async Task<string> GetToken()
        {
            var client = new RestClient(_tokenUrl,
                configureSerialization: serializerConfig => serializerConfig.UseSerializer(() => new CustomJsonCodec(_serializerSettings, _configuration)));

            var request = new RestRequest()
                .AddParameter("grant_type", _grantType)
                .AddParameter("client_id", _clientId)
                .AddParameter("client_secret", _clientSecret);
            var response = await client.PostAsync<TokenResponse>(request).ConfigureAwait(false);
            
            // RFC6749 - token_type is case insensitive.
            // RFC6750 - In Authorization header Bearer should be capitalized.
            // Fix the capitalization irrespective of token_type casing.
            switch (response.TokenType?.ToLower())
            {
                case "bearer":
                    return $"Bearer {response.AccessToken}";
                default:
                    return $"{response.TokenType} {response.AccessToken}";
            }
        }
    }
}
