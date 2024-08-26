/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.4
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
    /// ClientSetProject
    /// </summary>
    [DataContract(Name = "setProject")]
    public partial class ClientSetProject : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSetProject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSetProject()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSetProject" /> class.
        /// </summary>
        /// <param name="corsAdmin">corsAdmin (required).</param>
        /// <param name="corsPublic">corsPublic (required).</param>
        /// <param name="name">The name of the project. (required).</param>
        /// <param name="services">services (required).</param>
        public ClientSetProject(ClientProjectCors corsAdmin = default(ClientProjectCors), ClientProjectCors corsPublic = default(ClientProjectCors), string name = default(string), ClientProjectServices services = default(ClientProjectServices))
        {
            // to ensure "corsAdmin" is required (not null)
            if (corsAdmin == null)
            {
                throw new ArgumentNullException("corsAdmin is a required property for ClientSetProject and cannot be null");
            }
            this.CorsAdmin = corsAdmin;
            // to ensure "corsPublic" is required (not null)
            if (corsPublic == null)
            {
                throw new ArgumentNullException("corsPublic is a required property for ClientSetProject and cannot be null");
            }
            this.CorsPublic = corsPublic;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientSetProject and cannot be null");
            }
            this.Name = name;
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for ClientSetProject and cannot be null");
            }
            this.Services = services;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets CorsAdmin
        /// </summary>
        [DataMember(Name = "cors_admin", IsRequired = true, EmitDefaultValue = true)]
        public ClientProjectCors CorsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets CorsPublic
        /// </summary>
        [DataMember(Name = "cors_public", IsRequired = true, EmitDefaultValue = true)]
        public ClientProjectCors CorsPublic { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = true)]
        public ClientProjectServices Services { get; set; }

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
            sb.Append("class ClientSetProject {\n");
            sb.Append("  CorsAdmin: ").Append(CorsAdmin).Append("\n");
            sb.Append("  CorsPublic: ").Append(CorsPublic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
