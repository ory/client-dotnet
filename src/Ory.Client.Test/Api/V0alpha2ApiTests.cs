/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.187
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
    ///  Class for testing V0alpha2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class V0alpha2ApiTests : IDisposable
    {
        private V0alpha2Api instance;

        public V0alpha2ApiTests()
        {
            instance = new V0alpha2Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of V0alpha2Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' V0alpha2Api
            //Assert.IsType<V0alpha2Api>(instance);
        }

        /// <summary>
        /// Test AdminCreateIdentity
        /// </summary>
        [Fact]
        public void AdminCreateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientAdminCreateIdentityBody clientAdminCreateIdentityBody = null;
            //var response = instance.AdminCreateIdentity(clientAdminCreateIdentityBody);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test AdminCreateSelfServiceRecoveryLink
        /// </summary>
        [Fact]
        public void AdminCreateSelfServiceRecoveryLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientAdminCreateSelfServiceRecoveryLinkBody clientAdminCreateSelfServiceRecoveryLinkBody = null;
            //var response = instance.AdminCreateSelfServiceRecoveryLink(clientAdminCreateSelfServiceRecoveryLinkBody);
            //Assert.IsType<ClientSelfServiceRecoveryLink>(response);
        }

        /// <summary>
        /// Test AdminDeleteIdentity
        /// </summary>
        [Fact]
        public void AdminDeleteIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AdminDeleteIdentity(id);
        }

        /// <summary>
        /// Test AdminDeleteIdentitySessions
        /// </summary>
        [Fact]
        public void AdminDeleteIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.AdminDeleteIdentitySessions(id);
        }

        /// <summary>
        /// Test AdminExtendSession
        /// </summary>
        [Fact]
        public void AdminExtendSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AdminExtendSession(id);
            //Assert.IsType<ClientSession>(response);
        }

        /// <summary>
        /// Test AdminGetIdentity
        /// </summary>
        [Fact]
        public void AdminGetIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string> includeCredential = null;
            //var response = instance.AdminGetIdentity(id, includeCredential);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test AdminListIdentities
        /// </summary>
        [Fact]
        public void AdminListIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //var response = instance.AdminListIdentities(perPage, page);
            //Assert.IsType<List<ClientIdentity>>(response);
        }

        /// <summary>
        /// Test AdminListIdentitySessions
        /// </summary>
        [Fact]
        public void AdminListIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //long? perPage = null;
            //long? page = null;
            //bool? active = null;
            //var response = instance.AdminListIdentitySessions(id, perPage, page, active);
            //Assert.IsType<List<ClientSession>>(response);
        }

        /// <summary>
        /// Test AdminUpdateIdentity
        /// </summary>
        [Fact]
        public void AdminUpdateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientAdminUpdateIdentityBody clientAdminUpdateIdentityBody = null;
            //var response = instance.AdminUpdateIdentity(id, clientAdminUpdateIdentityBody);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test CreateProject
        /// </summary>
        [Fact]
        public void CreateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientCreateProjectBody clientCreateProjectBody = null;
            //var response = instance.CreateProject(clientCreateProjectBody);
            //Assert.IsType<ClientProject>(response);
        }

        /// <summary>
        /// Test CreateSelfServiceLogoutFlowUrlForBrowsers
        /// </summary>
        [Fact]
        public void CreateSelfServiceLogoutFlowUrlForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cookie = null;
            //var response = instance.CreateSelfServiceLogoutFlowUrlForBrowsers(cookie);
            //Assert.IsType<ClientSelfServiceLogoutUrl>(response);
        }

        /// <summary>
        /// Test GetJsonSchema
        /// </summary>
        [Fact]
        public void GetJsonSchemaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetJsonSchema(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetProject
        /// </summary>
        [Fact]
        public void GetProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.GetProject(projectId);
            //Assert.IsType<ClientProject>(response);
        }

        /// <summary>
        /// Test GetProjectMembers
        /// </summary>
        [Fact]
        public void GetProjectMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.GetProjectMembers(projectId);
            //Assert.IsType<List<ClientCloudAccount>>(response);
        }

        /// <summary>
        /// Test GetSelfServiceError
        /// </summary>
        [Fact]
        public void GetSelfServiceErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetSelfServiceError(id);
            //Assert.IsType<ClientSelfServiceError>(response);
        }

        /// <summary>
        /// Test GetSelfServiceLoginFlow
        /// </summary>
        [Fact]
        public void GetSelfServiceLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetSelfServiceLoginFlow(id, cookie);
            //Assert.IsType<ClientSelfServiceLoginFlow>(response);
        }

        /// <summary>
        /// Test GetSelfServiceRecoveryFlow
        /// </summary>
        [Fact]
        public void GetSelfServiceRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetSelfServiceRecoveryFlow(id, cookie);
            //Assert.IsType<ClientSelfServiceRecoveryFlow>(response);
        }

        /// <summary>
        /// Test GetSelfServiceRegistrationFlow
        /// </summary>
        [Fact]
        public void GetSelfServiceRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetSelfServiceRegistrationFlow(id, cookie);
            //Assert.IsType<ClientSelfServiceRegistrationFlow>(response);
        }

        /// <summary>
        /// Test GetSelfServiceSettingsFlow
        /// </summary>
        [Fact]
        public void GetSelfServiceSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.GetSelfServiceSettingsFlow(id, xSessionToken, cookie);
            //Assert.IsType<ClientSelfServiceSettingsFlow>(response);
        }

        /// <summary>
        /// Test GetSelfServiceVerificationFlow
        /// </summary>
        [Fact]
        public void GetSelfServiceVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string cookie = null;
            //var response = instance.GetSelfServiceVerificationFlow(id, cookie);
            //Assert.IsType<ClientSelfServiceVerificationFlow>(response);
        }

        /// <summary>
        /// Test GetWebAuthnJavaScript
        /// </summary>
        [Fact]
        public void GetWebAuthnJavaScriptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWebAuthnJavaScript();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceLoginFlowForBrowsers
        /// </summary>
        [Fact]
        public void InitializeSelfServiceLoginFlowForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string aal = null;
            //string returnTo = null;
            //var response = instance.InitializeSelfServiceLoginFlowForBrowsers(refresh, aal, returnTo);
            //Assert.IsType<ClientSelfServiceLoginFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceLoginFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void InitializeSelfServiceLoginFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //string aal = null;
            //string xSessionToken = null;
            //var response = instance.InitializeSelfServiceLoginFlowWithoutBrowser(refresh, aal, xSessionToken);
            //Assert.IsType<ClientSelfServiceLoginFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceRecoveryFlowForBrowsers
        /// </summary>
        [Fact]
        public void InitializeSelfServiceRecoveryFlowForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.InitializeSelfServiceRecoveryFlowForBrowsers(returnTo);
            //Assert.IsType<ClientSelfServiceRecoveryFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceRecoveryFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void InitializeSelfServiceRecoveryFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.InitializeSelfServiceRecoveryFlowWithoutBrowser();
            //Assert.IsType<ClientSelfServiceRecoveryFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceRegistrationFlowForBrowsers
        /// </summary>
        [Fact]
        public void InitializeSelfServiceRegistrationFlowForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.InitializeSelfServiceRegistrationFlowForBrowsers(returnTo);
            //Assert.IsType<ClientSelfServiceRegistrationFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceRegistrationFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void InitializeSelfServiceRegistrationFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.InitializeSelfServiceRegistrationFlowWithoutBrowser();
            //Assert.IsType<ClientSelfServiceRegistrationFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceSettingsFlowForBrowsers
        /// </summary>
        [Fact]
        public void InitializeSelfServiceSettingsFlowForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.InitializeSelfServiceSettingsFlowForBrowsers(returnTo);
            //Assert.IsType<ClientSelfServiceSettingsFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceSettingsFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void InitializeSelfServiceSettingsFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //var response = instance.InitializeSelfServiceSettingsFlowWithoutBrowser(xSessionToken);
            //Assert.IsType<ClientSelfServiceSettingsFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceVerificationFlowForBrowsers
        /// </summary>
        [Fact]
        public void InitializeSelfServiceVerificationFlowForBrowsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnTo = null;
            //var response = instance.InitializeSelfServiceVerificationFlowForBrowsers(returnTo);
            //Assert.IsType<ClientSelfServiceVerificationFlow>(response);
        }

        /// <summary>
        /// Test InitializeSelfServiceVerificationFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void InitializeSelfServiceVerificationFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.InitializeSelfServiceVerificationFlowWithoutBrowser();
            //Assert.IsType<ClientSelfServiceVerificationFlow>(response);
        }

        /// <summary>
        /// Test ListIdentitySchemas
        /// </summary>
        [Fact]
        public void ListIdentitySchemasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //var response = instance.ListIdentitySchemas(perPage, page);
            //Assert.IsType<List<ClientIdentitySchema>>(response);
        }

        /// <summary>
        /// Test ListProjects
        /// </summary>
        [Fact]
        public void ListProjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListProjects();
            //Assert.IsType<List<ClientProjectMetadata>>(response);
        }

        /// <summary>
        /// Test ListSessions
        /// </summary>
        [Fact]
        public void ListSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //string cookie = null;
            //long? perPage = null;
            //long? page = null;
            //var response = instance.ListSessions(xSessionToken, cookie, perPage, page);
            //Assert.IsType<List<ClientSession>>(response);
        }

        /// <summary>
        /// Test PatchProject
        /// </summary>
        [Fact]
        public void PatchProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //List<ClientJsonPatch> clientJsonPatch = null;
            //var response = instance.PatchProject(projectId, clientJsonPatch);
            //Assert.IsType<ClientSuccessfulProjectUpdate>(response);
        }

        /// <summary>
        /// Test PurgeProject
        /// </summary>
        [Fact]
        public void PurgeProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //instance.PurgeProject(projectId);
        }

        /// <summary>
        /// Test RemoveProjectMember
        /// </summary>
        [Fact]
        public void RemoveProjectMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string memberId = null;
            //instance.RemoveProjectMember(projectId, memberId);
        }

        /// <summary>
        /// Test RevokeSession
        /// </summary>
        [Fact]
        public void RevokeSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.RevokeSession(id);
        }

        /// <summary>
        /// Test RevokeSessions
        /// </summary>
        [Fact]
        public void RevokeSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.RevokeSessions(xSessionToken, cookie);
            //Assert.IsType<ClientRevokedSessions>(response);
        }

        /// <summary>
        /// Test SubmitSelfServiceLoginFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceLoginFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientSubmitSelfServiceLoginFlowBody clientSubmitSelfServiceLoginFlowBody = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.SubmitSelfServiceLoginFlow(flow, clientSubmitSelfServiceLoginFlowBody, xSessionToken, cookie);
            //Assert.IsType<ClientSuccessfulSelfServiceLoginWithoutBrowser>(response);
        }

        /// <summary>
        /// Test SubmitSelfServiceLogoutFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceLogoutFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string returnTo = null;
            //instance.SubmitSelfServiceLogoutFlow(token, returnTo);
        }

        /// <summary>
        /// Test SubmitSelfServiceLogoutFlowWithoutBrowser
        /// </summary>
        [Fact]
        public void SubmitSelfServiceLogoutFlowWithoutBrowserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientSubmitSelfServiceLogoutFlowWithoutBrowserBody clientSubmitSelfServiceLogoutFlowWithoutBrowserBody = null;
            //instance.SubmitSelfServiceLogoutFlowWithoutBrowser(clientSubmitSelfServiceLogoutFlowWithoutBrowserBody);
        }

        /// <summary>
        /// Test SubmitSelfServiceRecoveryFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceRecoveryFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientSubmitSelfServiceRecoveryFlowBody clientSubmitSelfServiceRecoveryFlowBody = null;
            //string token = null;
            //string cookie = null;
            //var response = instance.SubmitSelfServiceRecoveryFlow(flow, clientSubmitSelfServiceRecoveryFlowBody, token, cookie);
            //Assert.IsType<ClientSelfServiceRecoveryFlow>(response);
        }

        /// <summary>
        /// Test SubmitSelfServiceRegistrationFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceRegistrationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientSubmitSelfServiceRegistrationFlowBody clientSubmitSelfServiceRegistrationFlowBody = null;
            //string cookie = null;
            //var response = instance.SubmitSelfServiceRegistrationFlow(flow, clientSubmitSelfServiceRegistrationFlowBody, cookie);
            //Assert.IsType<ClientSuccessfulSelfServiceRegistrationWithoutBrowser>(response);
        }

        /// <summary>
        /// Test SubmitSelfServiceSettingsFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceSettingsFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientSubmitSelfServiceSettingsFlowBody clientSubmitSelfServiceSettingsFlowBody = null;
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.SubmitSelfServiceSettingsFlow(flow, clientSubmitSelfServiceSettingsFlowBody, xSessionToken, cookie);
            //Assert.IsType<ClientSelfServiceSettingsFlow>(response);
        }

        /// <summary>
        /// Test SubmitSelfServiceVerificationFlow
        /// </summary>
        [Fact]
        public void SubmitSelfServiceVerificationFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string flow = null;
            //ClientSubmitSelfServiceVerificationFlowBody clientSubmitSelfServiceVerificationFlowBody = null;
            //string token = null;
            //string cookie = null;
            //var response = instance.SubmitSelfServiceVerificationFlow(flow, clientSubmitSelfServiceVerificationFlowBody, token, cookie);
            //Assert.IsType<ClientSelfServiceVerificationFlow>(response);
        }

        /// <summary>
        /// Test ToSession
        /// </summary>
        [Fact]
        public void ToSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xSessionToken = null;
            //string cookie = null;
            //var response = instance.ToSession(xSessionToken, cookie);
            //Assert.IsType<ClientSession>(response);
        }

        /// <summary>
        /// Test UpdateProject
        /// </summary>
        [Fact]
        public void UpdateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ClientUpdateProject clientUpdateProject = null;
            //var response = instance.UpdateProject(projectId, clientUpdateProject);
            //Assert.IsType<ClientSuccessfulProjectUpdate>(response);
        }
    }
}
