/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.30
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
    ///  Class for testing RelationshipApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RelationshipApiTests : IDisposable
    {
        private RelationshipApi instance;

        public RelationshipApiTests()
        {
            instance = new RelationshipApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RelationshipApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RelationshipApi
            //Assert.IsType<RelationshipApi>(instance);
        }

        /// <summary>
        /// Test CheckOplSyntax
        /// </summary>
        [Fact]
        public void CheckOplSyntaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.CheckOplSyntax(body);
            //Assert.IsType<ClientCheckOplSyntaxResult>(response);
        }

        /// <summary>
        /// Test CreateRelationship
        /// </summary>
        [Fact]
        public void CreateRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientCreateRelationshipBody clientCreateRelationshipBody = null;
            //var response = instance.CreateRelationship(clientCreateRelationshipBody);
            //Assert.IsType<ClientRelationship>(response);
        }

        /// <summary>
        /// Test DeleteRelationships
        /// </summary>
        [Fact]
        public void DeleteRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //instance.DeleteRelationships(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
        }

        /// <summary>
        /// Test GetRelationships
        /// </summary>
        [Fact]
        public void GetRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pageToken = null;
            //long? pageSize = null;
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //var response = instance.GetRelationships(pageToken, pageSize, _namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
            //Assert.IsType<ClientRelationships>(response);
        }

        /// <summary>
        /// Test ListRelationshipNamespaces
        /// </summary>
        [Fact]
        public void ListRelationshipNamespacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListRelationshipNamespaces();
            //Assert.IsType<ClientRelationshipNamespaces>(response);
        }

        /// <summary>
        /// Test PatchRelationships
        /// </summary>
        [Fact]
        public void PatchRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ClientRelationshipPatch> clientRelationshipPatch = null;
            //instance.PatchRelationships(clientRelationshipPatch);
        }
    }
}
