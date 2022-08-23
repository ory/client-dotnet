/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.16
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
    ///  Class for testing ReadApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReadApiTests : IDisposable
    {
        private ReadApi instance;

        public ReadApiTests()
        {
            instance = new ReadApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReadApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReadApi
            //Assert.IsType<ReadApi>(instance);
        }

        /// <summary>
        /// Test GetCheck
        /// </summary>
        [Fact]
        public void GetCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //long? maxDepth = null;
            //var response = instance.GetCheck(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation, maxDepth);
            //Assert.IsType<ClientGetCheckResponse>(response);
        }

        /// <summary>
        /// Test GetCheckMirrorStatus
        /// </summary>
        [Fact]
        public void GetCheckMirrorStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCheckMirrorStatus();
            //Assert.IsType<ClientGetCheckResponse>(response);
        }

        /// <summary>
        /// Test GetExpand
        /// </summary>
        [Fact]
        public void GetExpandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //long? maxDepth = null;
            //var response = instance.GetExpand(_namespace, _object, relation, maxDepth);
            //Assert.IsType<ClientExpandTree>(response);
        }

        /// <summary>
        /// Test GetRelationTuples
        /// </summary>
        [Fact]
        public void GetRelationTuplesTest()
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
            //var response = instance.GetRelationTuples(pageToken, pageSize, _namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
            //Assert.IsType<ClientGetRelationTuplesResponse>(response);
        }

        /// <summary>
        /// Test PostCheck
        /// </summary>
        [Fact]
        public void PostCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? maxDepth = null;
            //ClientRelationQuery clientRelationQuery = null;
            //var response = instance.PostCheck(maxDepth, clientRelationQuery);
            //Assert.IsType<ClientGetCheckResponse>(response);
        }

        /// <summary>
        /// Test PostCheckMirrorStatus
        /// </summary>
        [Fact]
        public void PostCheckMirrorStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PostCheckMirrorStatus();
            //Assert.IsType<ClientGetCheckResponse>(response);
        }
    }
}
