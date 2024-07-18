/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.2
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
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventsApi
            //Assert.IsType<EventsApi>(instance);
        }

        /// <summary>
        /// Test CreateEventStream
        /// </summary>
        [Fact]
        public void CreateEventStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //ClientCreateEventStreamBody clientCreateEventStreamBody = null;
            //var response = instance.CreateEventStream(projectId, clientCreateEventStreamBody);
            //Assert.IsType<ClientEventStream>(response);
        }

        /// <summary>
        /// Test DeleteEventStream
        /// </summary>
        [Fact]
        public void DeleteEventStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string eventStreamId = null;
            //instance.DeleteEventStream(projectId, eventStreamId);
        }

        /// <summary>
        /// Test ListEventStreams
        /// </summary>
        [Fact]
        public void ListEventStreamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //var response = instance.ListEventStreams(projectId);
            //Assert.IsType<ClientListEventStreams>(response);
        }

        /// <summary>
        /// Test SetEventStream
        /// </summary>
        [Fact]
        public void SetEventStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectId = null;
            //string eventStreamId = null;
            //ClientSetEventStreamBody? clientSetEventStreamBody = null;
            //var response = instance.SetEventStream(projectId, eventStreamId, clientSetEventStreamBody);
            //Assert.IsType<ClientEventStream>(response);
        }
    }
}
