/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.19.0
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing OAuth2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OAuth2ApiTests : IDisposable
    {
        private OAuth2Api instance;

        public OAuth2ApiTests()
        {
            instance = new OAuth2Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth2Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OAuth2Api
            //Assert.IsType<OAuth2Api>(instance);
        }

        /// <summary>
        /// Test AcceptOAuth2ConsentRequest
        /// </summary>
        [Fact]
        public void AcceptOAuth2ConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //ClientAcceptOAuth2ConsentRequest? clientAcceptOAuth2ConsentRequest = null;
            //var response = instance.AcceptOAuth2ConsentRequest(consentChallenge, clientAcceptOAuth2ConsentRequest);
            //Assert.IsType<ClientOAuth2RedirectTo>(response);
        }

        /// <summary>
        /// Test AcceptOAuth2LoginRequest
        /// </summary>
        [Fact]
        public void AcceptOAuth2LoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //ClientAcceptOAuth2LoginRequest? clientAcceptOAuth2LoginRequest = null;
            //var response = instance.AcceptOAuth2LoginRequest(loginChallenge, clientAcceptOAuth2LoginRequest);
            //Assert.IsType<ClientOAuth2RedirectTo>(response);
        }

        /// <summary>
        /// Test AcceptOAuth2LogoutRequest
        /// </summary>
        [Fact]
        public void AcceptOAuth2LogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //var response = instance.AcceptOAuth2LogoutRequest(logoutChallenge);
            //Assert.IsType<ClientOAuth2RedirectTo>(response);
        }

        /// <summary>
        /// Test CreateOAuth2Client
        /// </summary>
        [Fact]
        public void CreateOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.CreateOAuth2Client(clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test DeleteOAuth2Client
        /// </summary>
        [Fact]
        public void DeleteOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteOAuth2Client(id);
        }

        /// <summary>
        /// Test DeleteOAuth2Token
        /// </summary>
        [Fact]
        public void DeleteOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //instance.DeleteOAuth2Token(clientId);
        }

        /// <summary>
        /// Test DeleteTrustedOAuth2JwtGrantIssuer
        /// </summary>
        [Fact]
        public void DeleteTrustedOAuth2JwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteTrustedOAuth2JwtGrantIssuer(id);
        }

        /// <summary>
        /// Test GetOAuth2Client
        /// </summary>
        [Fact]
        public void GetOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetOAuth2Client(id);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test GetOAuth2ConsentRequest
        /// </summary>
        [Fact]
        public void GetOAuth2ConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //var response = instance.GetOAuth2ConsentRequest(consentChallenge);
            //Assert.IsType<ClientOAuth2ConsentRequest>(response);
        }

        /// <summary>
        /// Test GetOAuth2LoginRequest
        /// </summary>
        [Fact]
        public void GetOAuth2LoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //var response = instance.GetOAuth2LoginRequest(loginChallenge);
            //Assert.IsType<ClientOAuth2LoginRequest>(response);
        }

        /// <summary>
        /// Test GetOAuth2LogoutRequest
        /// </summary>
        [Fact]
        public void GetOAuth2LogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //var response = instance.GetOAuth2LogoutRequest(logoutChallenge);
            //Assert.IsType<ClientOAuth2LogoutRequest>(response);
        }

        /// <summary>
        /// Test GetTrustedOAuth2JwtGrantIssuer
        /// </summary>
        [Fact]
        public void GetTrustedOAuth2JwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetTrustedOAuth2JwtGrantIssuer(id);
            //Assert.IsType<ClientTrustedOAuth2JwtGrantIssuer>(response);
        }

        /// <summary>
        /// Test IntrospectOAuth2Token
        /// </summary>
        [Fact]
        public void IntrospectOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string? scope = null;
            //var response = instance.IntrospectOAuth2Token(token, scope);
            //Assert.IsType<ClientIntrospectedOAuth2Token>(response);
        }

        /// <summary>
        /// Test ListOAuth2Clients
        /// </summary>
        [Fact]
        public void ListOAuth2ClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? pageSize = null;
            //string? pageToken = null;
            //string? clientName = null;
            //string? owner = null;
            //var response = instance.ListOAuth2Clients(pageSize, pageToken, clientName, owner);
            //Assert.IsType<List<ClientOAuth2Client>>(response);
        }

        /// <summary>
        /// Test ListOAuth2ConsentSessions
        /// </summary>
        [Fact]
        public void ListOAuth2ConsentSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subject = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //string? loginSessionId = null;
            //var response = instance.ListOAuth2ConsentSessions(subject, pageSize, pageToken, loginSessionId);
            //Assert.IsType<List<ClientOAuth2ConsentSession>>(response);
        }

        /// <summary>
        /// Test ListTrustedOAuth2JwtGrantIssuers
        /// </summary>
        [Fact]
        public void ListTrustedOAuth2JwtGrantIssuersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? maxItems = null;
            //long? defaultItems = null;
            //string? issuer = null;
            //var response = instance.ListTrustedOAuth2JwtGrantIssuers(maxItems, defaultItems, issuer);
            //Assert.IsType<List<ClientTrustedOAuth2JwtGrantIssuer>>(response);
        }

        /// <summary>
        /// Test OAuth2Authorize
        /// </summary>
        [Fact]
        public void OAuth2AuthorizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.OAuth2Authorize();
            //Assert.IsType<ClientErrorOAuth2>(response);
        }

        /// <summary>
        /// Test Oauth2TokenExchange
        /// </summary>
        [Fact]
        public void Oauth2TokenExchangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string grantType = null;
            //string? clientId = null;
            //string? code = null;
            //string? redirectUri = null;
            //string? refreshToken = null;
            //var response = instance.Oauth2TokenExchange(grantType, clientId, code, redirectUri, refreshToken);
            //Assert.IsType<ClientOAuth2TokenExchange>(response);
        }

        /// <summary>
        /// Test PatchOAuth2Client
        /// </summary>
        [Fact]
        public void PatchOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<ClientJsonPatch> clientJsonPatch = null;
            //var response = instance.PatchOAuth2Client(id, clientJsonPatch);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test RejectOAuth2ConsentRequest
        /// </summary>
        [Fact]
        public void RejectOAuth2ConsentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string consentChallenge = null;
            //ClientRejectOAuth2Request? clientRejectOAuth2Request = null;
            //var response = instance.RejectOAuth2ConsentRequest(consentChallenge, clientRejectOAuth2Request);
            //Assert.IsType<ClientOAuth2RedirectTo>(response);
        }

        /// <summary>
        /// Test RejectOAuth2LoginRequest
        /// </summary>
        [Fact]
        public void RejectOAuth2LoginRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loginChallenge = null;
            //ClientRejectOAuth2Request? clientRejectOAuth2Request = null;
            //var response = instance.RejectOAuth2LoginRequest(loginChallenge, clientRejectOAuth2Request);
            //Assert.IsType<ClientOAuth2RedirectTo>(response);
        }

        /// <summary>
        /// Test RejectOAuth2LogoutRequest
        /// </summary>
        [Fact]
        public void RejectOAuth2LogoutRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logoutChallenge = null;
            //instance.RejectOAuth2LogoutRequest(logoutChallenge);
        }

        /// <summary>
        /// Test RevokeOAuth2ConsentSessions
        /// </summary>
        [Fact]
        public void RevokeOAuth2ConsentSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? subject = null;
            //string? varClient = null;
            //string? consentRequestId = null;
            //bool? all = null;
            //instance.RevokeOAuth2ConsentSessions(subject, varClient, consentRequestId, all);
        }

        /// <summary>
        /// Test RevokeOAuth2LoginSessions
        /// </summary>
        [Fact]
        public void RevokeOAuth2LoginSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? subject = null;
            //string? sid = null;
            //instance.RevokeOAuth2LoginSessions(subject, sid);
        }

        /// <summary>
        /// Test RevokeOAuth2Token
        /// </summary>
        [Fact]
        public void RevokeOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string? clientId = null;
            //string? clientSecret = null;
            //instance.RevokeOAuth2Token(token, clientId, clientSecret);
        }

        /// <summary>
        /// Test SetOAuth2Client
        /// </summary>
        [Fact]
        public void SetOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.SetOAuth2Client(id, clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test SetOAuth2ClientLifespans
        /// </summary>
        [Fact]
        public void SetOAuth2ClientLifespansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientOAuth2ClientTokenLifespans? clientOAuth2ClientTokenLifespans = null;
            //var response = instance.SetOAuth2ClientLifespans(id, clientOAuth2ClientTokenLifespans);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test TrustOAuth2JwtGrantIssuer
        /// </summary>
        [Fact]
        public void TrustOAuth2JwtGrantIssuerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientTrustOAuth2JwtGrantIssuer? clientTrustOAuth2JwtGrantIssuer = null;
            //var response = instance.TrustOAuth2JwtGrantIssuer(clientTrustOAuth2JwtGrantIssuer);
            //Assert.IsType<ClientTrustedOAuth2JwtGrantIssuer>(response);
        }
    }
}
