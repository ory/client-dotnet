/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
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
    /// ClientProjectBranding
    /// </summary>
    [DataContract(Name = "projectBranding")]
    public partial class ClientProjectBranding : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectBranding" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProjectBranding()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectBranding" /> class.
        /// </summary>
        /// <param name="defaultTheme">defaultTheme (required).</param>
        /// <param name="projectId">The Project&#39;s ID this customization is associated with (required).</param>
        /// <param name="themes">themes (required).</param>
        public ClientProjectBranding(ClientProjectBrandingTheme defaultTheme = default(ClientProjectBrandingTheme), string projectId = default(string), List<ClientProjectBrandingTheme> themes = default(List<ClientProjectBrandingTheme>))
        {
            // to ensure "defaultTheme" is required (not null)
            if (defaultTheme == null)
            {
                throw new ArgumentNullException("defaultTheme is a required property for ClientProjectBranding and cannot be null");
            }
            this.DefaultTheme = defaultTheme;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for ClientProjectBranding and cannot be null");
            }
            this.ProjectId = projectId;
            // to ensure "themes" is required (not null)
            if (themes == null)
            {
                throw new ArgumentNullException("themes is a required property for ClientProjectBranding and cannot be null");
            }
            this.Themes = themes;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Customization Creation Date
        /// </summary>
        /// <value>The Customization Creation Date</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
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
        /// Gets or Sets DefaultTheme
        /// </summary>
        [DataMember(Name = "default_theme", IsRequired = true, EmitDefaultValue = true)]
        public ClientProjectBrandingTheme DefaultTheme { get; set; }

        /// <summary>
        /// The customization ID.
        /// </summary>
        /// <value>The customization ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
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
        /// The Project&#39;s ID this customization is associated with
        /// </summary>
        /// <value>The Project&#39;s ID this customization is associated with</value>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name = "themes", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientProjectBrandingTheme> Themes { get; set; }

        /// <summary>
        /// Last Time Branding was Updated
        /// </summary>
        /// <value>Last Time Branding was Updated</value>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
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
            sb.Append("class ClientProjectBranding {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DefaultTheme: ").Append(DefaultTheme).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
