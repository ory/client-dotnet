/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.37
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// Response to the create project invite request
    /// </summary>
    [DataContract(Name = "createProjectInvitesResponse")]
    public partial class ClientCreateProjectInvitesResponse : IEquatable<ClientCreateProjectInvitesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateProjectInvitesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCreateProjectInvitesResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateProjectInvitesResponse" /> class.
        /// </summary>
        /// <param name="allInvites">allInvites (required).</param>
        /// <param name="createdInvites">createdInvites (required).</param>
        public ClientCreateProjectInvitesResponse(List<ClientProjectInvite> allInvites = default(List<ClientProjectInvite>), List<ClientProjectInvite> createdInvites = default(List<ClientProjectInvite>))
        {
            // to ensure "allInvites" is required (not null)
            if (allInvites == null) {
                throw new ArgumentNullException("allInvites is a required property for ClientCreateProjectInvitesResponse and cannot be null");
            }
            this.AllInvites = allInvites;
            // to ensure "createdInvites" is required (not null)
            if (createdInvites == null) {
                throw new ArgumentNullException("createdInvites is a required property for ClientCreateProjectInvitesResponse and cannot be null");
            }
            this.CreatedInvites = createdInvites;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AllInvites
        /// </summary>
        [DataMember(Name = "all_invites", IsRequired = true, EmitDefaultValue = false)]
        public List<ClientProjectInvite> AllInvites { get; set; }

        /// <summary>
        /// Gets or Sets CreatedInvites
        /// </summary>
        [DataMember(Name = "created_invites", IsRequired = true, EmitDefaultValue = false)]
        public List<ClientProjectInvite> CreatedInvites { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientCreateProjectInvitesResponse {\n");
            sb.Append("  AllInvites: ").Append(AllInvites).Append("\n");
            sb.Append("  CreatedInvites: ").Append(CreatedInvites).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientCreateProjectInvitesResponse);
        }

        /// <summary>
        /// Returns true if ClientCreateProjectInvitesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCreateProjectInvitesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCreateProjectInvitesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllInvites == input.AllInvites ||
                    this.AllInvites != null &&
                    input.AllInvites != null &&
                    this.AllInvites.SequenceEqual(input.AllInvites)
                ) && 
                (
                    this.CreatedInvites == input.CreatedInvites ||
                    this.CreatedInvites != null &&
                    input.CreatedInvites != null &&
                    this.CreatedInvites.SequenceEqual(input.CreatedInvites)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AllInvites != null)
                {
                    hashCode = (hashCode * 59) + this.AllInvites.GetHashCode();
                }
                if (this.CreatedInvites != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedInvites.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
