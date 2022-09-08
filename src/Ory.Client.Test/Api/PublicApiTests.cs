/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.36
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
    ///  Class for testing PublicApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicApiTests : IDisposable
    {
        private PublicApi instance;

        public PublicApiTests()
        {
            instance = new PublicApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicApi
            //Assert.IsType<PublicApi>(instance);
        }

        /// <summary>
        /// Test DisconnectUser
        /// </summary>
        [Fact]
        public void DisconnectUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DisconnectUser();
        }

        /// <summary>
        /// Test DiscoverOpenIDConfiguration
        /// </summary>
        [Fact]
        public void DiscoverOpenIDConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DiscoverOpenIDConfiguration();
            //Assert.IsType<ClientWellKnown>(response);
        }

        /// <summary>
        /// Test DynamicClientRegistrationCreateOAuth2Client
        /// </summary>
        [Fact]
        public void DynamicClientRegistrationCreateOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.DynamicClientRegistrationCreateOAuth2Client(clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test DynamicClientRegistrationDeleteOAuth2Client
        /// </summary>
        [Fact]
        public void DynamicClientRegistrationDeleteOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DynamicClientRegistrationDeleteOAuth2Client(id);
        }

        /// <summary>
        /// Test DynamicClientRegistrationGetOAuth2Client
        /// </summary>
        [Fact]
        public void DynamicClientRegistrationGetOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DynamicClientRegistrationGetOAuth2Client(id);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test DynamicClientRegistrationUpdateOAuth2Client
        /// </summary>
        [Fact]
        public void DynamicClientRegistrationUpdateOAuth2ClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientOAuth2Client clientOAuth2Client = null;
            //var response = instance.DynamicClientRegistrationUpdateOAuth2Client(id, clientOAuth2Client);
            //Assert.IsType<ClientOAuth2Client>(response);
        }

        /// <summary>
        /// Test Oauth2Token
        /// </summary>
        [Fact]
        public void Oauth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string grantType = null;
            //string clientId = null;
            //string code = null;
            //string redirectUri = null;
            //string refreshToken = null;
            //var response = instance.Oauth2Token(grantType, clientId, code, redirectUri, refreshToken);
            //Assert.IsType<ClientOauth2TokenResponse>(response);
        }

        /// <summary>
        /// Test OauthAuth
        /// </summary>
        [Fact]
        public void OauthAuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.OauthAuth();
        }

        /// <summary>
        /// Test RevokeOAuth2Token
        /// </summary>
        [Fact]
        public void RevokeOAuth2TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //instance.RevokeOAuth2Token(token);
        }

        /// <summary>
        /// Test Userinfo
        /// </summary>
        [Fact]
        public void UserinfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Userinfo();
            //Assert.IsType<ClientUserinfoResponse>(response);
        }

        /// <summary>
        /// Test WellKnown
        /// </summary>
        [Fact]
        public void WellKnownTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.WellKnown();
            //Assert.IsType<ClientJSONWebKeySet>(response);
        }
    }
}
