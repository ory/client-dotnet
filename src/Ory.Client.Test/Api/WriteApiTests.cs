/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.28
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
    ///  Class for testing WriteApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WriteApiTests : IDisposable
    {
        private WriteApi instance;

        public WriteApiTests()
        {
            instance = new WriteApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WriteApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WriteApi
            //Assert.IsType<WriteApi>(instance);
        }

        /// <summary>
        /// Test CreateRelationTuple
        /// </summary>
        [Fact]
        public void CreateRelationTupleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientRelationQuery clientRelationQuery = null;
            //var response = instance.CreateRelationTuple(clientRelationQuery);
            //Assert.IsType<ClientRelationQuery>(response);
        }

        /// <summary>
        /// Test DeleteRelationTuples
        /// </summary>
        [Fact]
        public void DeleteRelationTuplesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string _namespace = null;
            //string _object = null;
            //string relation = null;
            //string subjectId = null;
            //string subjectSetNamespace = null;
            //string subjectSetObject = null;
            //string subjectSetRelation = null;
            //instance.DeleteRelationTuples(_namespace, _object, relation, subjectId, subjectSetNamespace, subjectSetObject, subjectSetRelation);
        }

        /// <summary>
        /// Test PatchRelationTuples
        /// </summary>
        [Fact]
        public void PatchRelationTuplesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ClientPatchDelta> clientPatchDelta = null;
            //instance.PatchRelationTuples(clientPatchDelta);
        }
    }
}
