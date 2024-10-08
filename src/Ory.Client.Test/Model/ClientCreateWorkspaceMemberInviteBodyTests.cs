/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.6
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientCreateWorkspaceMemberInviteBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientCreateWorkspaceMemberInviteBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientCreateWorkspaceMemberInviteBody
        //private ClientCreateWorkspaceMemberInviteBody instance;

        public ClientCreateWorkspaceMemberInviteBodyTests()
        {
            // TODO uncomment below to create an instance of ClientCreateWorkspaceMemberInviteBody
            //instance = new ClientCreateWorkspaceMemberInviteBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientCreateWorkspaceMemberInviteBody
        /// </summary>
        [Fact]
        public void ClientCreateWorkspaceMemberInviteBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientCreateWorkspaceMemberInviteBody
            //Assert.IsType<ClientCreateWorkspaceMemberInviteBody>(instance);
        }

        /// <summary>
        /// Test the property 'InviteeEmail'
        /// </summary>
        [Fact]
        public void InviteeEmailTest()
        {
            // TODO unit test for the property 'InviteeEmail'
        }

        /// <summary>
        /// Test the property 'Role'
        /// </summary>
        [Fact]
        public void RoleTest()
        {
            // TODO unit test for the property 'Role'
        }
    }
}
