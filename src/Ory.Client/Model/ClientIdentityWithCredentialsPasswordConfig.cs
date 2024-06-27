/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
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
    /// Create Identity and Import Password Credentials Configuration
    /// </summary>
    [DataContract(Name = "identityWithCredentialsPasswordConfig")]
    public partial class ClientIdentityWithCredentialsPasswordConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentityWithCredentialsPasswordConfig" /> class.
        /// </summary>
        /// <param name="hashedPassword">The hashed password in [PHC format](https://www.ory.sh/docs/kratos/manage-identities/import-user-accounts-identities#hashed-passwords).</param>
        /// <param name="password">The password in plain text if no hash is available..</param>
        public ClientIdentityWithCredentialsPasswordConfig(string hashedPassword = default(string), string password = default(string))
        {
            this.HashedPassword = hashedPassword;
            this.Password = password;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The hashed password in [PHC format](https://www.ory.sh/docs/kratos/manage-identities/import-user-accounts-identities#hashed-passwords)
        /// </summary>
        /// <value>The hashed password in [PHC format](https://www.ory.sh/docs/kratos/manage-identities/import-user-accounts-identities#hashed-passwords)</value>
        [DataMember(Name = "hashed_password", EmitDefaultValue = false)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// The password in plain text if no hash is available.
        /// </summary>
        /// <value>The password in plain text if no hash is available.</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

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
            sb.Append("class ClientIdentityWithCredentialsPasswordConfig {\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
