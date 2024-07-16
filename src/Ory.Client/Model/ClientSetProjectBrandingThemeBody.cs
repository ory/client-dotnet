/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.0
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
    /// ClientSetProjectBrandingThemeBody
    /// </summary>
    [DataContract(Name = "setProjectBrandingThemeBody")]
    public partial class ClientSetProjectBrandingThemeBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSetProjectBrandingThemeBody" /> class.
        /// </summary>
        /// <param name="faviconType">Favicon Type.</param>
        /// <param name="faviconUrl">Favicon URL.</param>
        /// <param name="logoType">Logo type.</param>
        /// <param name="logoUrl">Logo URL.</param>
        /// <param name="name">Branding name.</param>
        /// <param name="theme">theme.</param>
        public ClientSetProjectBrandingThemeBody(string faviconType = default(string), string faviconUrl = default(string), string logoType = default(string), string logoUrl = default(string), string name = default(string), ClientProjectBrandingColors theme = default(ClientProjectBrandingColors))
        {
            this.FaviconType = faviconType;
            this.FaviconUrl = faviconUrl;
            this.LogoType = logoType;
            this.LogoUrl = logoUrl;
            this.Name = name;
            this.Theme = theme;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Favicon Type
        /// </summary>
        /// <value>Favicon Type</value>
        [DataMember(Name = "favicon_type", EmitDefaultValue = false)]
        public string FaviconType { get; set; }

        /// <summary>
        /// Favicon URL
        /// </summary>
        /// <value>Favicon URL</value>
        [DataMember(Name = "favicon_url", EmitDefaultValue = false)]
        public string FaviconUrl { get; set; }

        /// <summary>
        /// Logo type
        /// </summary>
        /// <value>Logo type</value>
        [DataMember(Name = "logo_type", EmitDefaultValue = false)]
        public string LogoType { get; set; }

        /// <summary>
        /// Logo URL
        /// </summary>
        /// <value>Logo URL</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// Branding name
        /// </summary>
        /// <value>Branding name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public ClientProjectBrandingColors Theme { get; set; }

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
            sb.Append("class ClientSetProjectBrandingThemeBody {\n");
            sb.Append("  FaviconType: ").Append(FaviconType).Append("\n");
            sb.Append("  FaviconUrl: ").Append(FaviconUrl).Append("\n");
            sb.Append("  LogoType: ").Append(LogoType).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
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
