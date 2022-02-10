/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.84
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
    ///  Class for testing V0alpha0Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class V0alpha0ApiTests : IDisposable
    {
        private V0alpha0Api instance;

        public V0alpha0ApiTests()
        {
            instance = new V0alpha0Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of V0alpha0Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' V0alpha0Api
            //Assert.IsType<V0alpha0Api>(instance);
        }

        /// <summary>
        /// Test CreateProject
        /// </summary>
        [Fact]
        public void CreateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientProjectRevision clientProjectRevision = null;
            //var response = instance.CreateProject(clientProjectRevision);
            //Assert.IsType<ClientProject>(response);
        }

        /// <summary>
        /// Test GetActiveProject
        /// </summary>
        [Fact]
        public void GetActiveProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetActiveProject();
            //Assert.IsType<ClientActiveProject>(response);
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
        /// Test ListProjects
        /// </summary>
        [Fact]
        public void ListProjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListProjects();
            //Assert.IsType<List<ClientProject>>(response);
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
        /// Test SetActiveProject
        /// </summary>
        [Fact]
        public void SetActiveProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientInlineObject clientInlineObject = null;
            //instance.SetActiveProject(clientInlineObject);
        }

        /// <summary>
        /// Test UpdateProject
        /// </summary>
        [Fact]
        public void UpdateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ClientProjectRevision clientProjectRevision = null;
            //var response = instance.UpdateProject(projectId, clientProjectRevision);
            //Assert.IsType<ClientProject>(response);
        }

        /// <summary>
        /// Test UpdateProjectConfig
        /// </summary>
        [Fact]
        public void UpdateProjectConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ClientUpdateProjectConfigConfig clientUpdateProjectConfigConfig = null;
            //var response = instance.UpdateProjectConfig(projectId, clientUpdateProjectConfigConfig);
            //Assert.IsType<ClientSuccessfulProjectConfigUpdate>(response);
        }
    }
}
