/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.4
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
    /// ClientNormalizedProject
    /// </summary>
    [DataContract(Name = "normalizedProject")]
    public partial class ClientNormalizedProject : IEquatable<ClientNormalizedProject>, IValidatableObject
    {
        /// <summary>
        /// The environment of the project. prod Production dev Development
        /// </summary>
        /// <value>The environment of the project. prod Production dev Development</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnvironmentEnum
        {
            /// <summary>
            /// Enum Prod for value: prod
            /// </summary>
            [EnumMember(Value = "prod")]
            Prod = 1,

            /// <summary>
            /// Enum Dev for value: dev
            /// </summary>
            [EnumMember(Value = "dev")]
            Dev = 2

        }


        /// <summary>
        /// The environment of the project. prod Production dev Development
        /// </summary>
        /// <value>The environment of the project. prod Production dev Development</value>
        [DataMember(Name = "environment", IsRequired = true, EmitDefaultValue = false)]
        public EnvironmentEnum Environment { get; set; }
        /// <summary>
        /// The state of the project. running Running halted Halted deleted Deleted
        /// </summary>
        /// <value>The state of the project. running Running halted Halted deleted Deleted</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            [EnumMember(Value = "running")]
            Running = 1,

            /// <summary>
            /// Enum Halted for value: halted
            /// </summary>
            [EnumMember(Value = "halted")]
            Halted = 2,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 3

        }


        /// <summary>
        /// The state of the project. running Running halted Halted deleted Deleted
        /// </summary>
        /// <value>The state of the project. running Running halted Halted deleted Deleted</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public StateEnum State { get; set; }

        /// <summary>
        /// Returns false as State should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeState()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientNormalizedProject()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProject" /> class.
        /// </summary>
        /// <param name="currentRevision">currentRevision (required).</param>
        /// <param name="environment">The environment of the project. prod Production dev Development (required).</param>
        /// <param name="hosts">hosts (required).</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="subscriptionPlan">subscriptionPlan.</param>
        /// <param name="workspaceId">workspaceId (required).</param>
        public ClientNormalizedProject(ClientNormalizedProjectRevision currentRevision = default(ClientNormalizedProjectRevision), EnvironmentEnum environment = default(EnvironmentEnum), List<string> hosts = default(List<string>), string subscriptionId = default(string), string subscriptionPlan = default(string), string workspaceId = default(string))
        {
            // to ensure "currentRevision" is required (not null)
            if (currentRevision == null) {
                throw new ArgumentNullException("currentRevision is a required property for ClientNormalizedProject and cannot be null");
            }
            this.CurrentRevision = currentRevision;
            this.Environment = environment;
            // to ensure "hosts" is required (not null)
            if (hosts == null) {
                throw new ArgumentNullException("hosts is a required property for ClientNormalizedProject and cannot be null");
            }
            this.Hosts = hosts;
            // to ensure "workspaceId" is required (not null)
            if (workspaceId == null) {
                throw new ArgumentNullException("workspaceId is a required property for ClientNormalizedProject and cannot be null");
            }
            this.WorkspaceId = workspaceId;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionPlan = subscriptionPlan;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Project&#39;s Creation Date
        /// </summary>
        /// <value>The Project&#39;s Creation Date</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentRevision
        /// </summary>
        [DataMember(Name = "current_revision", IsRequired = true, EmitDefaultValue = false)]
        public ClientNormalizedProjectRevision CurrentRevision { get; set; }

        /// <summary>
        /// Gets or Sets Hosts
        /// </summary>
        [DataMember(Name = "hosts", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// The project&#39;s ID.
        /// </summary>
        /// <value>The project&#39;s ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The project&#39;s slug
        /// </summary>
        /// <value>The project&#39;s slug</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = false)]
        public string Slug { get; private set; }

        /// <summary>
        /// Returns false as Slug should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSlug()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscription_id", EmitDefaultValue = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionPlan
        /// </summary>
        [DataMember(Name = "subscription_plan", EmitDefaultValue = true)]
        public string SubscriptionPlan { get; set; }

        /// <summary>
        /// Last Time Project was Updated
        /// </summary>
        /// <value>Last Time Project was Updated</value>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name = "workspace_id", IsRequired = true, EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

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
            sb.Append("class ClientNormalizedProject {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentRevision: ").Append(CurrentRevision).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  SubscriptionPlan: ").Append(SubscriptionPlan).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
            return this.Equals(input as ClientNormalizedProject);
        }

        /// <summary>
        /// Returns true if ClientNormalizedProject instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientNormalizedProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientNormalizedProject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CurrentRevision == input.CurrentRevision ||
                    (this.CurrentRevision != null &&
                    this.CurrentRevision.Equals(input.CurrentRevision))
                ) && 
                (
                    this.Environment == input.Environment ||
                    this.Environment.Equals(input.Environment)
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    input.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.SubscriptionPlan == input.SubscriptionPlan ||
                    (this.SubscriptionPlan != null &&
                    this.SubscriptionPlan.Equals(input.SubscriptionPlan))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.WorkspaceId == input.WorkspaceId ||
                    (this.WorkspaceId != null &&
                    this.WorkspaceId.Equals(input.WorkspaceId))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CurrentRevision != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentRevision.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                if (this.Hosts != null)
                {
                    hashCode = (hashCode * 59) + this.Hosts.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                if (this.SubscriptionPlan != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionPlan.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.WorkspaceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkspaceId.GetHashCode();
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
